'
'
'
Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text

Public Class Main

    Private FileName As String = ""
    Private TitleName As String
    Private Modified As Boolean
    Private fileCode As String = ""

    Private sText As String

    Private Sub SetTitle()
        Text = FileName
    End Sub

    Private Sub ReadFile(code As String)
        Dim ofd As New OpenFileDialog

        If CheckFileProcess() = False Then
            Exit Sub
        End If

        Try

            ofd.DefaultExt = "txt"
            ofd.Filter = "Textファイル|*.txt|すべてのファイル|*.*"
            If ofd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            txtTextArea.Text = ""
            
            FileName = ofd.FileName
            
            LoadFile(FileName, code)

            SetTitle()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LoadFile(ByVal sFileName As String, code As String)

        Dim sBuf As String           ' バッファ

        sText = ""

        Try

            Dim sr1 As New StreamReader(sFileName, Encoding.GetEncoding(code))

            While sr1.Peek >= 0
                sBuf = sr1.ReadLine()
                sText += sBuf + vbNewLine

            End While

            sr1.Close()

            txtTextArea.Text = sText


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "LoadFile")
        End Try
    End Sub

    Private Function SaveFile(code As String) As Boolean
        Dim sr2 As StreamWriter

        sText = txtTextArea.Text
        If FileName = "" Then
            Dim sfd As New SaveFileDialog
            sfd.DefaultExt = "txt"
            sfd.Filter = "テキストファイル|*.txt|すべてのファイル|*.*"
            If sfd.ShowDialog() <> DialogResult.OK Then
                Return False
            End If
            FileName = sfd.FileName

        End If

        sr2 = New StreamWriter( _
            New FileStream(FileName, FileMode.Create), _
            Encoding.GetEncoding(code))
        sr2.WriteLine(sText)
        sr2.Close()

        Modified = false

        Return True

    End Function


    Private Function CheckFileProcess() As Boolean
        If Modified = True Then
            Dim result As DialogResult = MessageBox.Show(Me, "ファイルは変更されています。" + vbNewLine + "の変更を保存しますか？", TitleName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim ret As Boolean
                ret = SaveFile(fileCode)
                If ret = False Then
                    Return False
                End If
            Else
                If result = DialogResult.Cancel Then
                    Return False
                End If
            End If
        End If

        Return True

    End Function

    Private Sub SaveAsFile(code As String)
        Dim sfd As New SaveFileDialog
        Dim sr2 As StreamWriter
        
        Try

            sfd.FileName = FileName
            '
            sfd.DefaultExt = "txt"
            sfd.Filter = "Textファイル|*.txt|すべてのファイル|*.*"
            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            FileName = sfd.FileName
            sText = txtTextArea.Text

            sr2 = New StreamWriter( _
                New FileStream(FileName, FileMode.Create), _
                Encoding.GetEncoding(code))
            sr2.WriteLine(sText)
            
            sr2.Close()
            SetTitle()

            Modified = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub 開くOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開くOToolStripMenuItem.Click
        fileCode = "Shift-JIS"
        ReadFile(fileCode)
        Modified = False
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        SaveAsFile(fileCode)
    End Sub

    Private Sub 上書き保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上書き保存ToolStripMenuItem.Click
        Dim ret As Boolean
        ret = SaveFile(fileCode)
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'https://docs.microsoft.com/ja-jp/dotnet/api/system.environment.getcommandlineargs?view=netframework-4.8
        dim args as string() = Environment.GetCommandLineArgs()
        If args.Length <> 1 And args.Length <> 3 Then
            MsgBox("コマンドライン引数を指定してください。例） xxx.exe ファイル名 文字コード ")
        ElseIf args.Length = 3 Then 'コマンド自身を含まない
            Dim arg As String
            For Each arg In args

                FileName = args(1)
                fileCode = args(2)

            Next
        End If


        txtTextArea.Font = New Font("MSゴシック", 10)
        txtTextArea.BackColor = Color.Black
        txtTextArea.ForeColor = Color.LightGray

        Left = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainLeft", "30"))
        Top = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainTop", "30"))
        Width = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainWidth", "600"))
        Height = CInt(GetSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainHeight", "600"))

        If FileName <> "" Then
            LoadFile(FileName, fileCode)
        End If

        Modified = False

    End Sub

    Private Sub SubSave()
        Dim iTmp As Integer
        If Me.Left >= 0 Then
            SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainLeft", CStr(Me.Left))
        End If
        If Me.Top >= 0 Then
            SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainTop", CStr(Me.Top))
        End If
        If Me.Width >= 0 Then
            SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainWidth", CStr(Me.Width))
        End If
        If Me.Height >= 0 Then
            SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "MainHeight", CStr(Me.Height))
        End If

        SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontName", txtTextArea.Font.Name)
        If txtTextArea.Font.Bold = True Then
            iTmp = 1
        Else
            iTmp = 0
        End If

        SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontSize", CStr(txtTextArea.Font.SizeInPoints))

        SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontBold", CStr(iTmp))

        If txtTextArea.Font.Italic = True Then
            iTmp = 1
        Else
            iTmp = 0
        End If
        SaveSetting(My.Application.Info.ProductName + "_NET", "Settings", "FontItalic", CStr(iTmp))

    End Sub

    Private Sub ホームToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ホームToolStripMenuItem.Click
        txtTextArea.SelectionStart = 0
        txtTextArea.SelectionLength = 0
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Modified = True Then

            Dim ret As Boolean = CheckFileProcess()

            If ret = False Then
                e.Cancel = True
            End If

        End If
        SubSave()

    End Sub

    Private Sub txtTextArea_TextChanged(sender As Object, e As EventArgs) Handles txtTextArea.TextChanged
        Modified = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim row As Integer = txtTextArea.GetLineFromCharIndex(txtTextArea.SelectionStart)
        Dim column As Integer = txtTextArea.SelectionStart - txtTextArea.GetFirstCharIndexFromLine(row)
        StatusStrip1.Items(0).Text = "" + column.ToString() + ":" + row.ToString()
    End Sub
End Class