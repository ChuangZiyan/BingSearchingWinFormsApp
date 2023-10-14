Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Threading
Imports System.Collections
Imports System.Text.RegularExpressions
Imports Microsoft.Web.WebView2.Core
Imports System.Text

Public Class Form1

    Public currentDirectory As String = My.Application.Info.DirectoryPath
    Public searchingResultDir As String = currentDirectory + "\SearchingResult"
    Public keywordFilePath As String = "keyword.txt"

    Public PAUSE_FLAG = False
    Public NAVIGATION_COMPLETED = False




    Private Sub Open_Note_Btn_Click(sender As Object, e As EventArgs) Handles Open_Note_Btn.Click

        If File.Exists(keywordFilePath) Then
            Dim fileContent As String = File.ReadAllText(keywordFilePath)
        Else
            Dim fs As FileStream = File.Create(keywordFilePath)
            fs.Close()
        End If

        Process.Start("explorer.exe", keywordFilePath)

    End Sub

    Private Sub Read_LineText_By_LineNumber_Btn_Click(sender As Object, e As EventArgs) Handles Read_LineText_By_LineNumber_Btn.Click
        SearchingContent_TextBox.Text = ""
        Dim selected_line_number = Line_Number_NumericUpDown.Value
        Using reader As New StreamReader(keywordFilePath)
            Dim line_counter = 1
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                If line_counter = selected_line_number Then
                    SearchingContent_TextBox.Text = line
                End If
                line_counter += 1
            End While
        End Using
    End Sub

    Private Sub Read_LineCount_Button_Click(sender As Object, e As EventArgs) Handles Read_LineCount_Button.Click
        Dim line_counter = 0
        Using reader As New StreamReader(keywordFilePath)

            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                line_counter += 1
            End While
        End Using

        Line_Number_Counter_Label.Text = "共" & line_counter & "行"
    End Sub

    Private Async Sub Start_Searching_Button_Click(sender As Object, e As EventArgs) Handles Start_Searching_Button.Click
        Start_Searching_Button.Enabled = False
        Pause_Button.Enabled = True
        Pause_Button.Text = "暫停"

        Start_Searching_Button.Text = "搜尋中..."
        Start_Time_TextBox.Text = Now.ToString("G")
        End_Time_TextBox.Text = ""

        Dim result_filePath As String = searchingResultDir + "\SearchingResult_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt"
        'File.Create(result_filePath).Dispose()

        Dim keyword_list As New List(Of String)

        Using reader As New StreamReader(keywordFilePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                keyword_list.Add(line)
            End While
        End Using

        Dim my_counter = 0

        For Each kword In keyword_list
            Message_RichTextBox.Clear()

            'EventLog_ListBox.Items.Add(Now.ToString("yyyy-MM-dd HH:mm:ss") + " - 搜尋: " + kword + " 中")

            SearchingContent_TextBox.Text = kword
            Line_Number_NumericUpDown.Value = my_counter + 1

            Dim curr_searching_page = 0
            Dim page_sum = Max_Searching_Page_Limit_NumericUpDown.Value


            'Debug.WriteLine(kword)
            For start = 1 To Max_Searching_Page_Limit_NumericUpDown.Value * 10 - 1 Step 10
                curr_searching_page += 1
                page_sum -= 1
                Curr_Searching_Page_Label.Text = "正在搜尋第 " & curr_searching_page & " 頁，剩餘 " & page_sum & " 頁"

                While PAUSE_FLAG
                    'Debug.WriteLine("PAUSE")
                    Await Delay_msec(1000)
                End While

                Dim searching_result_text = Await Submit_Get_Bing_Searching_Result_Html(kword, start)
                'Dim searching_result_text = "429" ' for test
                If searching_result_text = "429" Then
                    For sec = Http_429_Delay_Sec_NumericUpDown.Value To 0 Step -1
                        Http_429_Delay_Sec_Label.Text = "剩餘 : " & sec & " 秒"
                        Await Delay_msec(1000)
                    Next
                    searching_result_text = Await Submit_Get_Bing_Searching_Result_Html(kword, start)
                End If

                Dim mail_list = FindEmails(searching_result_text)

                For Each email As String In mail_list
                    Debug.WriteLine(email)

                    If CheckEmailExistInRichTextBox(email) = False Then
                        Message_RichTextBox.AppendText(email & vbCrLf)
                        ' Save email to file 
                        result_filePath = searchingResultDir + "\SearchingResult_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"
                        Using writer As New StreamWriter(result_filePath, True)
                            writer.WriteLine(email)
                            writer.Close()
                        End Using
                    End If

                    'If CheckEmailExistInFile(result_filePath, email) Then
                    '   Continue For
                    'End If
                Next

                Await Delay_msec(Delay_Sec_Between_Searching_NumericUpDown.Value * 1000)
            Next

            my_counter += 1

            If my_counter < keyword_list.Count Then

                If my_counter Mod Number_Of_Searching_Count_NumericUpDown.Value = 0 Then

                    For sec = Searching_Time_Delay_Sec_NumericUpDown.Value To 0 Step -1
                        Searching_15Time_Delay_Sec_Label.Text = "剩餘 : " & sec & " 秒"
                        Await Delay_msec(1000)
                    Next

                Else
                    For sec = Delay_Sec_Between_Keyword_NumericUpDown.Value To 0 Step -1
                        Keyword_Delay_Sec_Label.Text = "剩餘 : " & sec & " 秒"
                        Await Delay_msec(1000)
                    Next
                End If

            End If
        Next

        'EventLog_ListBox.Items.Add(Now.ToString("yyyy-MM-dd HH:mm:ss") + " - 搜尋結束")
        End_Time_TextBox.Text = Now.ToString("G")
        Start_Searching_Button.Enabled = True
        Start_Searching_Button.Text = "開始搜尋"
        Pause_Button.Enabled = False
        Pause_Button.Text = "暫停"
        PAUSE_FLAG = False
    End Sub


    Public Async Function Submit_Get_Bing_Searching_Result_Html(keyword As String, start As Integer) As Task(Of String)

        'Dim apiUrl As String = "https://search.yahoo.com/search?p=" + "%40 " + keyword + " EMAIL HK&b=" & start
        Dim apiUrl As String = "https://www.bing.com/search?q=" + "%40 " + keyword + " EMAIL HK&first=" & start

        Debug.WriteLine(apiUrl)

        'Return "hello this is test email.test@hello.com feel free to contact us"

        Try
            MainWebView2.CoreWebView2.Navigate(apiUrl)
            ' wait 15 secs until page ready
            NAVIGATION_COMPLETED = False
            For wait_sec = 0 To 15
                If NAVIGATION_COMPLETED Then
                    Exit For
                Else
                    Await Delay_msec(1000)
                End If

            Next

            Dim script As String = Await MainWebView2.ExecuteScriptAsync("document.querySelector('main').outerHTML.toString();")

            script = script.Replace("\""", "").Replace("\u003C", "<")

            Debug.WriteLine(script)
            Dim pattern As String = "<strong>(.*?)</strong>"
            Dim cleanText As String = Regex.Replace(script, pattern, "$1")

            Return cleanText

        Catch ex As Exception
            Return "exception"
            'EventLog_ListBox.Items.Add("查詢發生錯誤")

        End Try


        Return "error"

    End Function


    Public Shared Function FindEmails(input As String) As List(Of String)
        Dim emailPattern As String = "\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}(?:\b|\s|\.|[,;!])"
        'Dim emailPattern As String = "\b[A-Za-z0-9._%+-]+@(<strong>|)[A-Za-z0-9.-]+\.[A-Za-z]{2,}(<\/strong>|)\b"


        Dim regex As New Regex(emailPattern)
        Dim matches As MatchCollection = regex.Matches(input)
        Dim emails As New List(Of String)

        For Each match As Match In matches

            'have to remove the tag for bing search
            Dim my_mail = match.Value.Replace("<strong>", "").Replace("</strong>", "")
            emails.Add(my_mail)
        Next

        Return emails
    End Function


    Public Function CheckEmailExistInFile(file_path As String, email_str As String) As Boolean

        Using reader As New StreamReader(file_path)

            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                If line = email_str Then
                    Return True
                End If
            End While
        End Using

        Return False

    End Function

    Public Function CheckEmailExistInRichTextBox(email_str)
        For Each line As String In Message_RichTextBox.Lines
            If line = email_str Then
                Return True
            End If
        Next

        Return False
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check if Folder exists
        If Not Directory.Exists(searchingResultDir) Then
            Directory.CreateDirectory(searchingResultDir)
        End If

        If File.Exists(keywordFilePath) Then
            Dim fileContent As String = File.ReadAllText(keywordFilePath)
        Else
            Dim fs As FileStream = File.Create(keywordFilePath)
            fs.Close()
        End If

        Dim line_counter = 0
        Using reader As New StreamReader(keywordFilePath)

            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                line_counter += 1
            End While
        End Using

        Line_Number_Counter_Label.Text = "共" & line_counter & "行"

        AddHandler MainWebView2.NavigationCompleted, AddressOf WebView2_NavigationCompletedAsync
    End Sub


    Private Async Function WebView2_NavigationCompletedAsync(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) As Task(Of Boolean)

        Await Delay_msec(1000)
        If e.IsSuccess Then
            NAVIGATION_COMPLETED = True
            Debug.WriteLine("PAGE READY : " & NAVIGATION_COMPLETED)
        Else
            Debug_Msg_ListBox.Items.Add("頁面載入失敗")
            NAVIGATION_COMPLETED = False
        End If


        Return False
    End Function

    Public Shared Async Function Delay_msec(msec As Integer) As Task
        Await Task.Delay(msec)
    End Function

    Private Sub Reveal_Searching_Result_Dir_Btn_Click(sender As Object, e As EventArgs) Handles Reveal_Searching_Result_Dir_Btn.Click
        Process.Start("explorer.exe", searchingResultDir)
    End Sub

    Private Sub Pause_Button_Click(sender As Object, e As EventArgs) Handles Pause_Button.Click

        If PAUSE_FLAG Then
            PAUSE_FLAG = False
            Pause_Button.Text = "暫停"
        Else
            PAUSE_FLAG = True
            Pause_Button.Text = "繼續"
        End If

    End Sub
End Class
