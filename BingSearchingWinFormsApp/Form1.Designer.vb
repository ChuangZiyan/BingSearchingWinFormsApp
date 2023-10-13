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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Open_Note_Btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Line_Number_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchingContent_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Read_LineText_By_LineNumber_Btn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Start_Searching_Button = New System.Windows.Forms.Button()
        Me.Read_LineCount_Button = New System.Windows.Forms.Button()
        Me.Line_Number_Counter_Label = New System.Windows.Forms.Label()
        Me.Delay_Sec_Between_Searching_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Delay_Sec_Between_Keyword_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Keyword_Delay_Sec_Label = New System.Windows.Forms.Label()
        Me.Max_Searching_Page_Limit_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Reveal_Searching_Result_Dir_Btn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Searching_Time_Delay_Sec_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Searching_15Time_Delay_Sec_Label = New System.Windows.Forms.Label()
        Me.Message_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Start_Time_TextBox = New System.Windows.Forms.TextBox()
        Me.End_Time_TextBox = New System.Windows.Forms.TextBox()
        Me.Pause_Button = New System.Windows.Forms.Button()
        Me.Number_Of_Searching_Count_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Http_429_Delay_Sec_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Http_429_Delay_Sec_Label = New System.Windows.Forms.Label()
        Me.Curr_Searching_Page_Label = New System.Windows.Forms.Label()
        Me.MainWebView2 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Debug_Msg_ListBox = New System.Windows.Forms.ListBox()
        CType(Me.Line_Number_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delay_Sec_Between_Searching_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delay_Sec_Between_Keyword_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Max_Searching_Page_Limit_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Searching_Time_Delay_Sec_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Number_Of_Searching_Count_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Http_429_Delay_Sec_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainWebView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "輸入搜尋內容 : "
        '
        'Open_Note_Btn
        '
        Me.Open_Note_Btn.Location = New System.Drawing.Point(128, 24)
        Me.Open_Note_Btn.Name = "Open_Note_Btn"
        Me.Open_Note_Btn.Size = New System.Drawing.Size(94, 29)
        Me.Open_Note_Btn.TabIndex = 1
        Me.Open_Note_Btn.Text = "記事本"
        Me.Open_Note_Btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "第"
        '
        'Line_Number_NumericUpDown
        '
        Me.Line_Number_NumericUpDown.Location = New System.Drawing.Point(128, 65)
        Me.Line_Number_NumericUpDown.Name = "Line_Number_NumericUpDown"
        Me.Line_Number_NumericUpDown.Size = New System.Drawing.Size(69, 27)
        Me.Line_Number_NumericUpDown.TabIndex = 3
        Me.Line_Number_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "內容 : @"
        '
        'SearchingContent_TextBox
        '
        Me.SearchingContent_TextBox.Location = New System.Drawing.Point(304, 65)
        Me.SearchingContent_TextBox.Name = "SearchingContent_TextBox"
        Me.SearchingContent_TextBox.Size = New System.Drawing.Size(234, 27)
        Me.SearchingContent_TextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(544, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EMAIL HK"
        '
        'Read_LineText_By_LineNumber_Btn
        '
        Me.Read_LineText_By_LineNumber_Btn.Location = New System.Drawing.Point(12, 62)
        Me.Read_LineText_By_LineNumber_Btn.Name = "Read_LineText_By_LineNumber_Btn"
        Me.Read_LineText_By_LineNumber_Btn.Size = New System.Drawing.Size(80, 29)
        Me.Read_LineText_By_LineNumber_Btn.TabIndex = 7
        Me.Read_LineText_By_LineNumber_Btn.Text = "讀取"
        Me.Read_LineText_By_LineNumber_Btn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "行"
        '
        'Start_Searching_Button
        '
        Me.Start_Searching_Button.Location = New System.Drawing.Point(444, 231)
        Me.Start_Searching_Button.Name = "Start_Searching_Button"
        Me.Start_Searching_Button.Size = New System.Drawing.Size(94, 29)
        Me.Start_Searching_Button.TabIndex = 9
        Me.Start_Searching_Button.Text = "開始搜尋"
        Me.Start_Searching_Button.UseVisualStyleBackColor = True
        '
        'Read_LineCount_Button
        '
        Me.Read_LineCount_Button.Location = New System.Drawing.Point(228, 24)
        Me.Read_LineCount_Button.Name = "Read_LineCount_Button"
        Me.Read_LineCount_Button.Size = New System.Drawing.Size(94, 29)
        Me.Read_LineCount_Button.TabIndex = 11
        Me.Read_LineCount_Button.Text = "讀取行數"
        Me.Read_LineCount_Button.UseVisualStyleBackColor = True
        '
        'Line_Number_Counter_Label
        '
        Me.Line_Number_Counter_Label.AutoSize = True
        Me.Line_Number_Counter_Label.Location = New System.Drawing.Point(328, 29)
        Me.Line_Number_Counter_Label.Name = "Line_Number_Counter_Label"
        Me.Line_Number_Counter_Label.Size = New System.Drawing.Size(67, 19)
        Me.Line_Number_Counter_Label.TabIndex = 12
        Me.Line_Number_Counter_Label.Text = "共N/A行"
        '
        'Delay_Sec_Between_Searching_NumericUpDown
        '
        Me.Delay_Sec_Between_Searching_NumericUpDown.Location = New System.Drawing.Point(128, 197)
        Me.Delay_Sec_Between_Searching_NumericUpDown.Name = "Delay_Sec_Between_Searching_NumericUpDown"
        Me.Delay_Sec_Between_Searching_NumericUpDown.Size = New System.Drawing.Size(70, 27)
        Me.Delay_Sec_Between_Searching_NumericUpDown.TabIndex = 13
        Me.Delay_Sec_Between_Searching_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "頁數間延遲 :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "關鍵字間延遲 : "
        '
        'Delay_Sec_Between_Keyword_NumericUpDown
        '
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Location = New System.Drawing.Point(128, 164)
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Name = "Delay_Sec_Between_Keyword_NumericUpDown"
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Size = New System.Drawing.Size(70, 27)
        Me.Delay_Sec_Between_Keyword_NumericUpDown.TabIndex = 16
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Keyword_Delay_Sec_Label
        '
        Me.Keyword_Delay_Sec_Label.AutoSize = True
        Me.Keyword_Delay_Sec_Label.Location = New System.Drawing.Point(203, 172)
        Me.Keyword_Delay_Sec_Label.Name = "Keyword_Delay_Sec_Label"
        Me.Keyword_Delay_Sec_Label.Size = New System.Drawing.Size(78, 19)
        Me.Keyword_Delay_Sec_Label.TabIndex = 17
        Me.Keyword_Delay_Sec_Label.Text = "剩餘 : 0 秒"
        '
        'Max_Searching_Page_Limit_NumericUpDown
        '
        Me.Max_Searching_Page_Limit_NumericUpDown.Location = New System.Drawing.Point(290, 197)
        Me.Max_Searching_Page_Limit_NumericUpDown.Name = "Max_Searching_Page_Limit_NumericUpDown"
        Me.Max_Searching_Page_Limit_NumericUpDown.Size = New System.Drawing.Size(56, 27)
        Me.Max_Searching_Page_Limit_NumericUpDown.TabIndex = 18
        Me.Max_Searching_Page_Limit_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(204, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "搜尋頁數 : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "頁"
        '
        'Reveal_Searching_Result_Dir_Btn
        '
        Me.Reveal_Searching_Result_Dir_Btn.Location = New System.Drawing.Point(444, 264)
        Me.Reveal_Searching_Result_Dir_Btn.Name = "Reveal_Searching_Result_Dir_Btn"
        Me.Reveal_Searching_Result_Dir_Btn.Size = New System.Drawing.Size(94, 29)
        Me.Reveal_Searching_Result_Dir_Btn.TabIndex = 21
        Me.Reveal_Searching_Result_Dir_Btn.Text = "搜尋結果"
        Me.Reveal_Searching_Result_Dir_Btn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(203, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 19)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "延遲"
        '
        'Searching_Time_Delay_Sec_NumericUpDown
        '
        Me.Searching_Time_Delay_Sec_NumericUpDown.Location = New System.Drawing.Point(248, 131)
        Me.Searching_Time_Delay_Sec_NumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Searching_Time_Delay_Sec_NumericUpDown.Name = "Searching_Time_Delay_Sec_NumericUpDown"
        Me.Searching_Time_Delay_Sec_NumericUpDown.Size = New System.Drawing.Size(70, 27)
        Me.Searching_Time_Delay_Sec_NumericUpDown.TabIndex = 23
        Me.Searching_Time_Delay_Sec_NumericUpDown.Value = New Decimal(New Integer() {1800, 0, 0, 0})
        '
        'Searching_15Time_Delay_Sec_Label
        '
        Me.Searching_15Time_Delay_Sec_Label.AutoSize = True
        Me.Searching_15Time_Delay_Sec_Label.Location = New System.Drawing.Point(324, 133)
        Me.Searching_15Time_Delay_Sec_Label.Name = "Searching_15Time_Delay_Sec_Label"
        Me.Searching_15Time_Delay_Sec_Label.Size = New System.Drawing.Size(78, 19)
        Me.Searching_15Time_Delay_Sec_Label.TabIndex = 24
        Me.Searching_15Time_Delay_Sec_Label.Text = "剩餘 : 0 秒"
        '
        'Message_RichTextBox
        '
        Me.Message_RichTextBox.Location = New System.Drawing.Point(12, 330)
        Me.Message_RichTextBox.Name = "Message_RichTextBox"
        Me.Message_RichTextBox.Size = New System.Drawing.Size(364, 289)
        Me.Message_RichTextBox.TabIndex = 25
        Me.Message_RichTextBox.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 19)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "開始時間 : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 266)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 19)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "結束時間 : "
        '
        'Start_Time_TextBox
        '
        Me.Start_Time_TextBox.Location = New System.Drawing.Point(128, 230)
        Me.Start_Time_TextBox.Name = "Start_Time_TextBox"
        Me.Start_Time_TextBox.Size = New System.Drawing.Size(248, 27)
        Me.Start_Time_TextBox.TabIndex = 28
        '
        'End_Time_TextBox
        '
        Me.End_Time_TextBox.Location = New System.Drawing.Point(128, 263)
        Me.End_Time_TextBox.Name = "End_Time_TextBox"
        Me.End_Time_TextBox.Size = New System.Drawing.Size(248, 27)
        Me.End_Time_TextBox.TabIndex = 29
        '
        'Pause_Button
        '
        Me.Pause_Button.Enabled = False
        Me.Pause_Button.Location = New System.Drawing.Point(544, 231)
        Me.Pause_Button.Name = "Pause_Button"
        Me.Pause_Button.Size = New System.Drawing.Size(94, 29)
        Me.Pause_Button.TabIndex = 30
        Me.Pause_Button.Text = "暫停"
        Me.Pause_Button.UseVisualStyleBackColor = True
        '
        'Number_Of_Searching_Count_NumericUpDown
        '
        Me.Number_Of_Searching_Count_NumericUpDown.Location = New System.Drawing.Point(128, 131)
        Me.Number_Of_Searching_Count_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Number_Of_Searching_Count_NumericUpDown.Name = "Number_Of_Searching_Count_NumericUpDown"
        Me.Number_Of_Searching_Count_NumericUpDown.Size = New System.Drawing.Size(70, 27)
        Me.Number_Of_Searching_Count_NumericUpDown.TabIndex = 31
        Me.Number_Of_Searching_Count_NumericUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(98, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 19)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "每"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 19)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Http429延遲 : "
        '
        'Http_429_Delay_Sec_NumericUpDown
        '
        Me.Http_429_Delay_Sec_NumericUpDown.Location = New System.Drawing.Point(128, 98)
        Me.Http_429_Delay_Sec_NumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Http_429_Delay_Sec_NumericUpDown.Name = "Http_429_Delay_Sec_NumericUpDown"
        Me.Http_429_Delay_Sec_NumericUpDown.Size = New System.Drawing.Size(69, 27)
        Me.Http_429_Delay_Sec_NumericUpDown.TabIndex = 34
        Me.Http_429_Delay_Sec_NumericUpDown.Value = New Decimal(New Integer() {900, 0, 0, 0})
        '
        'Http_429_Delay_Sec_Label
        '
        Me.Http_429_Delay_Sec_Label.AutoSize = True
        Me.Http_429_Delay_Sec_Label.Location = New System.Drawing.Point(204, 100)
        Me.Http_429_Delay_Sec_Label.Name = "Http_429_Delay_Sec_Label"
        Me.Http_429_Delay_Sec_Label.Size = New System.Drawing.Size(78, 19)
        Me.Http_429_Delay_Sec_Label.TabIndex = 35
        Me.Http_429_Delay_Sec_Label.Text = "剩餘 : 0 秒"
        '
        'Curr_Searching_Page_Label
        '
        Me.Curr_Searching_Page_Label.AutoSize = True
        Me.Curr_Searching_Page_Label.Location = New System.Drawing.Point(12, 308)
        Me.Curr_Searching_Page_Label.Name = "Curr_Searching_Page_Label"
        Me.Curr_Searching_Page_Label.Size = New System.Drawing.Size(80, 19)
        Me.Curr_Searching_Page_Label.TabIndex = 36
        Me.Curr_Searching_Page_Label.Text = "正在搜尋 : "
        '
        'MainWebView2
        '
        Me.MainWebView2.AllowExternalDrop = True
        Me.MainWebView2.CreationProperties = Nothing
        Me.MainWebView2.DefaultBackgroundColor = System.Drawing.Color.White
        Me.MainWebView2.Location = New System.Drawing.Point(644, 29)
        Me.MainWebView2.Name = "MainWebView2"
        Me.MainWebView2.Size = New System.Drawing.Size(660, 590)
        Me.MainWebView2.Source = New System.Uri("https://www.bing.com/", System.UriKind.Absolute)
        Me.MainWebView2.TabIndex = 37
        Me.MainWebView2.ZoomFactor = 1.0R
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(382, 308)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 19)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Debug : "
        '
        'Debug_Msg_ListBox
        '
        Me.Debug_Msg_ListBox.FormattingEnabled = True
        Me.Debug_Msg_ListBox.ItemHeight = 19
        Me.Debug_Msg_ListBox.Location = New System.Drawing.Point(382, 330)
        Me.Debug_Msg_ListBox.Name = "Debug_Msg_ListBox"
        Me.Debug_Msg_ListBox.Size = New System.Drawing.Size(256, 289)
        Me.Debug_Msg_ListBox.TabIndex = 39
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 635)
        Me.Controls.Add(Me.Debug_Msg_ListBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.MainWebView2)
        Me.Controls.Add(Me.Curr_Searching_Page_Label)
        Me.Controls.Add(Me.Http_429_Delay_Sec_Label)
        Me.Controls.Add(Me.Http_429_Delay_Sec_NumericUpDown)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Number_Of_Searching_Count_NumericUpDown)
        Me.Controls.Add(Me.Pause_Button)
        Me.Controls.Add(Me.End_Time_TextBox)
        Me.Controls.Add(Me.Start_Time_TextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Message_RichTextBox)
        Me.Controls.Add(Me.Searching_15Time_Delay_Sec_Label)
        Me.Controls.Add(Me.Searching_Time_Delay_Sec_NumericUpDown)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Reveal_Searching_Result_Dir_Btn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Max_Searching_Page_Limit_NumericUpDown)
        Me.Controls.Add(Me.Keyword_Delay_Sec_Label)
        Me.Controls.Add(Me.Delay_Sec_Between_Keyword_NumericUpDown)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Delay_Sec_Between_Searching_NumericUpDown)
        Me.Controls.Add(Me.Line_Number_Counter_Label)
        Me.Controls.Add(Me.Read_LineCount_Button)
        Me.Controls.Add(Me.Start_Searching_Button)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Read_LineText_By_LineNumber_Btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SearchingContent_TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Line_Number_NumericUpDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Open_Note_Btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Yahoo Search Form"
        CType(Me.Line_Number_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Delay_Sec_Between_Searching_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Delay_Sec_Between_Keyword_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Max_Searching_Page_Limit_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Searching_Time_Delay_Sec_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Number_Of_Searching_Count_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Http_429_Delay_Sec_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainWebView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
