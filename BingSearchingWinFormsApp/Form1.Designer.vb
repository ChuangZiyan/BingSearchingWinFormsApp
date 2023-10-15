<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Open_Note_Btn = New Button()
        Label2 = New Label()
        Line_Number_NumericUpDown = New NumericUpDown()
        Label3 = New Label()
        SearchingContent_TextBox = New TextBox()
        Label4 = New Label()
        Read_LineText_By_LineNumber_Btn = New Button()
        Label5 = New Label()
        Start_Searching_Button = New Button()
        Read_LineCount_Button = New Button()
        Line_Number_Counter_Label = New Label()
        Delay_Sec_Between_Searching_NumericUpDown = New NumericUpDown()
        Label7 = New Label()
        Label6 = New Label()
        Delay_Sec_Between_Keyword_NumericUpDown = New NumericUpDown()
        Keyword_Delay_Sec_Label = New Label()
        Max_Searching_Page_Limit_NumericUpDown = New NumericUpDown()
        Label8 = New Label()
        Label9 = New Label()
        Reveal_Searching_Result_Dir_Btn = New Button()
        Label10 = New Label()
        Searching_Time_Delay_Sec_NumericUpDown = New NumericUpDown()
        Searching_15Time_Delay_Sec_Label = New Label()
        Message_RichTextBox = New RichTextBox()
        Label11 = New Label()
        Label12 = New Label()
        Start_Time_TextBox = New TextBox()
        End_Time_TextBox = New TextBox()
        Pause_Button = New Button()
        Number_Of_Searching_Count_NumericUpDown = New NumericUpDown()
        Label13 = New Label()
        Label14 = New Label()
        Http_429_Delay_Sec_NumericUpDown = New NumericUpDown()
        Http_429_Delay_Sec_Label = New Label()
        Curr_Searching_Page_Label = New Label()
        MainWebView2 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Label15 = New Label()
        Debug_Msg_ListBox = New ListBox()
        CType(Line_Number_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(Delay_Sec_Between_Searching_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(Delay_Sec_Between_Keyword_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(Max_Searching_Page_Limit_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(Searching_Time_Delay_Sec_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(Number_Of_Searching_Count_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(Http_429_Delay_Sec_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(MainWebView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 19)
        Label1.TabIndex = 0
        Label1.Text = "輸入搜尋內容 : "
        ' 
        ' Open_Note_Btn
        ' 
        Open_Note_Btn.Location = New Point(128, 24)
        Open_Note_Btn.Name = "Open_Note_Btn"
        Open_Note_Btn.Size = New Size(94, 29)
        Open_Note_Btn.TabIndex = 1
        Open_Note_Btn.Text = "記事本"
        Open_Note_Btn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 19)
        Label2.TabIndex = 2
        Label2.Text = "第"
        ' 
        ' Line_Number_NumericUpDown
        ' 
        Line_Number_NumericUpDown.Location = New Point(128, 65)
        Line_Number_NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Line_Number_NumericUpDown.Name = "Line_Number_NumericUpDown"
        Line_Number_NumericUpDown.Size = New Size(69, 27)
        Line_Number_NumericUpDown.TabIndex = 3
        Line_Number_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(233, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 19)
        Label3.TabIndex = 4
        Label3.Text = "內容 : @"
        ' 
        ' SearchingContent_TextBox
        ' 
        SearchingContent_TextBox.Location = New Point(304, 65)
        SearchingContent_TextBox.Name = "SearchingContent_TextBox"
        SearchingContent_TextBox.Size = New Size(234, 27)
        SearchingContent_TextBox.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(544, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 19)
        Label4.TabIndex = 6
        Label4.Text = "EMAIL HK"
        ' 
        ' Read_LineText_By_LineNumber_Btn
        ' 
        Read_LineText_By_LineNumber_Btn.Location = New Point(12, 62)
        Read_LineText_By_LineNumber_Btn.Name = "Read_LineText_By_LineNumber_Btn"
        Read_LineText_By_LineNumber_Btn.Size = New Size(80, 29)
        Read_LineText_By_LineNumber_Btn.TabIndex = 7
        Read_LineText_By_LineNumber_Btn.Text = "讀取"
        Read_LineText_By_LineNumber_Btn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(203, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(24, 19)
        Label5.TabIndex = 8
        Label5.Text = "行"
        ' 
        ' Start_Searching_Button
        ' 
        Start_Searching_Button.Location = New Point(444, 231)
        Start_Searching_Button.Name = "Start_Searching_Button"
        Start_Searching_Button.Size = New Size(94, 29)
        Start_Searching_Button.TabIndex = 9
        Start_Searching_Button.Text = "開始搜尋"
        Start_Searching_Button.UseVisualStyleBackColor = True
        ' 
        ' Read_LineCount_Button
        ' 
        Read_LineCount_Button.Location = New Point(228, 24)
        Read_LineCount_Button.Name = "Read_LineCount_Button"
        Read_LineCount_Button.Size = New Size(94, 29)
        Read_LineCount_Button.TabIndex = 11
        Read_LineCount_Button.Text = "讀取行數"
        Read_LineCount_Button.UseVisualStyleBackColor = True
        ' 
        ' Line_Number_Counter_Label
        ' 
        Line_Number_Counter_Label.AutoSize = True
        Line_Number_Counter_Label.Location = New Point(328, 29)
        Line_Number_Counter_Label.Name = "Line_Number_Counter_Label"
        Line_Number_Counter_Label.Size = New Size(67, 19)
        Line_Number_Counter_Label.TabIndex = 12
        Line_Number_Counter_Label.Text = "共N/A行"
        ' 
        ' Delay_Sec_Between_Searching_NumericUpDown
        ' 
        Delay_Sec_Between_Searching_NumericUpDown.Location = New Point(128, 197)
        Delay_Sec_Between_Searching_NumericUpDown.Name = "Delay_Sec_Between_Searching_NumericUpDown"
        Delay_Sec_Between_Searching_NumericUpDown.Size = New Size(70, 27)
        Delay_Sec_Between_Searching_NumericUpDown.TabIndex = 13
        Delay_Sec_Between_Searching_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(23, 203)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 19)
        Label7.TabIndex = 14
        Label7.Text = "頁數間延遲 :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 172)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 19)
        Label6.TabIndex = 15
        Label6.Text = "關鍵字間延遲 : "
        ' 
        ' Delay_Sec_Between_Keyword_NumericUpDown
        ' 
        Delay_Sec_Between_Keyword_NumericUpDown.Location = New Point(128, 164)
        Delay_Sec_Between_Keyword_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Delay_Sec_Between_Keyword_NumericUpDown.Name = "Delay_Sec_Between_Keyword_NumericUpDown"
        Delay_Sec_Between_Keyword_NumericUpDown.Size = New Size(70, 27)
        Delay_Sec_Between_Keyword_NumericUpDown.TabIndex = 16
        Delay_Sec_Between_Keyword_NumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' Keyword_Delay_Sec_Label
        ' 
        Keyword_Delay_Sec_Label.AutoSize = True
        Keyword_Delay_Sec_Label.Location = New Point(203, 172)
        Keyword_Delay_Sec_Label.Name = "Keyword_Delay_Sec_Label"
        Keyword_Delay_Sec_Label.Size = New Size(78, 19)
        Keyword_Delay_Sec_Label.TabIndex = 17
        Keyword_Delay_Sec_Label.Text = "剩餘 : 0 秒"
        ' 
        ' Max_Searching_Page_Limit_NumericUpDown
        ' 
        Max_Searching_Page_Limit_NumericUpDown.Location = New Point(290, 197)
        Max_Searching_Page_Limit_NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Max_Searching_Page_Limit_NumericUpDown.Name = "Max_Searching_Page_Limit_NumericUpDown"
        Max_Searching_Page_Limit_NumericUpDown.Size = New Size(56, 27)
        Max_Searching_Page_Limit_NumericUpDown.TabIndex = 18
        Max_Searching_Page_Limit_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(204, 203)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 19)
        Label8.TabIndex = 19
        Label8.Text = "搜尋頁數 : "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(352, 203)
        Label9.Name = "Label9"
        Label9.Size = New Size(24, 19)
        Label9.TabIndex = 20
        Label9.Text = "頁"
        ' 
        ' Reveal_Searching_Result_Dir_Btn
        ' 
        Reveal_Searching_Result_Dir_Btn.Location = New Point(444, 264)
        Reveal_Searching_Result_Dir_Btn.Name = "Reveal_Searching_Result_Dir_Btn"
        Reveal_Searching_Result_Dir_Btn.Size = New Size(94, 29)
        Reveal_Searching_Result_Dir_Btn.TabIndex = 21
        Reveal_Searching_Result_Dir_Btn.Text = "搜尋結果"
        Reveal_Searching_Result_Dir_Btn.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(203, 133)
        Label10.Name = "Label10"
        Label10.Size = New Size(39, 19)
        Label10.TabIndex = 22
        Label10.Text = "延遲"
        ' 
        ' Searching_Time_Delay_Sec_NumericUpDown
        ' 
        Searching_Time_Delay_Sec_NumericUpDown.Location = New Point(248, 131)
        Searching_Time_Delay_Sec_NumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Searching_Time_Delay_Sec_NumericUpDown.Name = "Searching_Time_Delay_Sec_NumericUpDown"
        Searching_Time_Delay_Sec_NumericUpDown.Size = New Size(70, 27)
        Searching_Time_Delay_Sec_NumericUpDown.TabIndex = 23
        Searching_Time_Delay_Sec_NumericUpDown.Value = New Decimal(New Integer() {1800, 0, 0, 0})
        ' 
        ' Searching_15Time_Delay_Sec_Label
        ' 
        Searching_15Time_Delay_Sec_Label.AutoSize = True
        Searching_15Time_Delay_Sec_Label.Location = New Point(324, 133)
        Searching_15Time_Delay_Sec_Label.Name = "Searching_15Time_Delay_Sec_Label"
        Searching_15Time_Delay_Sec_Label.Size = New Size(78, 19)
        Searching_15Time_Delay_Sec_Label.TabIndex = 24
        Searching_15Time_Delay_Sec_Label.Text = "剩餘 : 0 秒"
        ' 
        ' Message_RichTextBox
        ' 
        Message_RichTextBox.Location = New Point(12, 330)
        Message_RichTextBox.Name = "Message_RichTextBox"
        Message_RichTextBox.Size = New Size(364, 289)
        Message_RichTextBox.TabIndex = 25
        Message_RichTextBox.Text = ""
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(34, 236)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 19)
        Label11.TabIndex = 26
        Label11.Text = "開始時間 : "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(34, 266)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 19)
        Label12.TabIndex = 27
        Label12.Text = "結束時間 : "
        ' 
        ' Start_Time_TextBox
        ' 
        Start_Time_TextBox.Location = New Point(128, 230)
        Start_Time_TextBox.Name = "Start_Time_TextBox"
        Start_Time_TextBox.Size = New Size(248, 27)
        Start_Time_TextBox.TabIndex = 28
        ' 
        ' End_Time_TextBox
        ' 
        End_Time_TextBox.Location = New Point(128, 263)
        End_Time_TextBox.Name = "End_Time_TextBox"
        End_Time_TextBox.Size = New Size(248, 27)
        End_Time_TextBox.TabIndex = 29
        ' 
        ' Pause_Button
        ' 
        Pause_Button.Enabled = False
        Pause_Button.Location = New Point(544, 231)
        Pause_Button.Name = "Pause_Button"
        Pause_Button.Size = New Size(94, 29)
        Pause_Button.TabIndex = 30
        Pause_Button.Text = "暫停"
        Pause_Button.UseVisualStyleBackColor = True
        ' 
        ' Number_Of_Searching_Count_NumericUpDown
        ' 
        Number_Of_Searching_Count_NumericUpDown.Location = New Point(128, 131)
        Number_Of_Searching_Count_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Number_Of_Searching_Count_NumericUpDown.Name = "Number_Of_Searching_Count_NumericUpDown"
        Number_Of_Searching_Count_NumericUpDown.Size = New Size(70, 27)
        Number_Of_Searching_Count_NumericUpDown.TabIndex = 31
        Number_Of_Searching_Count_NumericUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(98, 133)
        Label13.Name = "Label13"
        Label13.Size = New Size(24, 19)
        Label13.TabIndex = 32
        Label13.Text = "每"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(11, 100)
        Label14.Name = "Label14"
        Label14.Size = New Size(107, 19)
        Label14.TabIndex = 33
        Label14.Text = "Http429延遲 : "
        ' 
        ' Http_429_Delay_Sec_NumericUpDown
        ' 
        Http_429_Delay_Sec_NumericUpDown.Location = New Point(128, 98)
        Http_429_Delay_Sec_NumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Http_429_Delay_Sec_NumericUpDown.Name = "Http_429_Delay_Sec_NumericUpDown"
        Http_429_Delay_Sec_NumericUpDown.Size = New Size(69, 27)
        Http_429_Delay_Sec_NumericUpDown.TabIndex = 34
        Http_429_Delay_Sec_NumericUpDown.Value = New Decimal(New Integer() {900, 0, 0, 0})
        ' 
        ' Http_429_Delay_Sec_Label
        ' 
        Http_429_Delay_Sec_Label.AutoSize = True
        Http_429_Delay_Sec_Label.Location = New Point(204, 100)
        Http_429_Delay_Sec_Label.Name = "Http_429_Delay_Sec_Label"
        Http_429_Delay_Sec_Label.Size = New Size(78, 19)
        Http_429_Delay_Sec_Label.TabIndex = 35
        Http_429_Delay_Sec_Label.Text = "剩餘 : 0 秒"
        ' 
        ' Curr_Searching_Page_Label
        ' 
        Curr_Searching_Page_Label.AutoSize = True
        Curr_Searching_Page_Label.Location = New Point(12, 308)
        Curr_Searching_Page_Label.Name = "Curr_Searching_Page_Label"
        Curr_Searching_Page_Label.Size = New Size(80, 19)
        Curr_Searching_Page_Label.TabIndex = 36
        Curr_Searching_Page_Label.Text = "正在搜尋 : "
        ' 
        ' MainWebView2
        ' 
        MainWebView2.AllowExternalDrop = True
        MainWebView2.CreationProperties = Nothing
        MainWebView2.DefaultBackgroundColor = Color.White
        MainWebView2.Location = New Point(644, 29)
        MainWebView2.Name = "MainWebView2"
        MainWebView2.Size = New Size(660, 590)
        MainWebView2.Source = New Uri("https://www.bing.com/", UriKind.Absolute)
        MainWebView2.TabIndex = 37
        MainWebView2.ZoomFactor = 1R
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(382, 308)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 19)
        Label15.TabIndex = 38
        Label15.Text = "Debug : "
        ' 
        ' Debug_Msg_ListBox
        ' 
        Debug_Msg_ListBox.FormattingEnabled = True
        Debug_Msg_ListBox.ItemHeight = 19
        Debug_Msg_ListBox.Location = New Point(382, 330)
        Debug_Msg_ListBox.Name = "Debug_Msg_ListBox"
        Debug_Msg_ListBox.Size = New Size(256, 289)
        Debug_Msg_ListBox.TabIndex = 39
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1316, 635)
        Controls.Add(Debug_Msg_ListBox)
        Controls.Add(Label15)
        Controls.Add(MainWebView2)
        Controls.Add(Curr_Searching_Page_Label)
        Controls.Add(Http_429_Delay_Sec_Label)
        Controls.Add(Http_429_Delay_Sec_NumericUpDown)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Number_Of_Searching_Count_NumericUpDown)
        Controls.Add(Pause_Button)
        Controls.Add(End_Time_TextBox)
        Controls.Add(Start_Time_TextBox)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Message_RichTextBox)
        Controls.Add(Searching_15Time_Delay_Sec_Label)
        Controls.Add(Searching_Time_Delay_Sec_NumericUpDown)
        Controls.Add(Label10)
        Controls.Add(Reveal_Searching_Result_Dir_Btn)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Max_Searching_Page_Limit_NumericUpDown)
        Controls.Add(Keyword_Delay_Sec_Label)
        Controls.Add(Delay_Sec_Between_Keyword_NumericUpDown)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Delay_Sec_Between_Searching_NumericUpDown)
        Controls.Add(Line_Number_Counter_Label)
        Controls.Add(Read_LineCount_Button)
        Controls.Add(Start_Searching_Button)
        Controls.Add(Label5)
        Controls.Add(Read_LineText_By_LineNumber_Btn)
        Controls.Add(Label4)
        Controls.Add(SearchingContent_TextBox)
        Controls.Add(Label3)
        Controls.Add(Line_Number_NumericUpDown)
        Controls.Add(Label2)
        Controls.Add(Open_Note_Btn)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Bing Search Form"
        CType(Line_Number_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(Delay_Sec_Between_Searching_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(Delay_Sec_Between_Keyword_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(Max_Searching_Page_Limit_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(Searching_Time_Delay_Sec_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(Number_Of_Searching_Count_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(Http_429_Delay_Sec_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(MainWebView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Open_Note_Btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Line_Number_NumericUpDown As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents SearchingContent_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Read_LineText_By_LineNumber_Btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Start_Searching_Button As Button
    Friend WithEvents Read_LineCount_Button As Button
    Friend WithEvents Line_Number_Counter_Label As Label
    Friend WithEvents Delay_Sec_Between_Searching_NumericUpDown As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Delay_Sec_Between_Keyword_NumericUpDown As NumericUpDown
    Friend WithEvents Keyword_Delay_Sec_Label As Label
    Friend WithEvents Max_Searching_Page_Limit_NumericUpDown As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Reveal_Searching_Result_Dir_Btn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Searching_Time_Delay_Sec_NumericUpDown As NumericUpDown
    Friend WithEvents Searching_15Time_Delay_Sec_Label As Label
    Friend WithEvents Message_RichTextBox As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Start_Time_TextBox As TextBox
    Friend WithEvents End_Time_TextBox As TextBox
    Friend WithEvents Pause_Button As Button
    Friend WithEvents Number_Of_Searching_Count_NumericUpDown As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Http_429_Delay_Sec_NumericUpDown As NumericUpDown
    Friend WithEvents Http_429_Delay_Sec_Label As Label
    Friend WithEvents Curr_Searching_Page_Label As Label
    Friend WithEvents MainWebView2 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Label15 As Label
    Friend WithEvents Debug_Msg_ListBox As ListBox
End Class
