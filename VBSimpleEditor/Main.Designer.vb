<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開くOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上書き保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTextArea = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.元に戻すUToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.切り取りTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.コピーCToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.貼り付けPToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.すべて選択AToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ホームToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(396, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開くOToolStripMenuItem, Me.上書き保存ToolStripMenuItem, Me.AToolStripMenuItem, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '開くOToolStripMenuItem
        '
        Me.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem"
        Me.開くOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.開くOToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.開くOToolStripMenuItem.Text = "開く(&O)"
        '
        '上書き保存ToolStripMenuItem
        '
        Me.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem"
        Me.上書き保存ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.上書き保存ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.上書き保存ToolStripMenuItem.Text = "上書き保存(&S)"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AToolStripMenuItem.Text = "名前を付けて保存(&A)"
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        'txtTextArea
        '
        Me.txtTextArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTextArea.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtTextArea.Location = New System.Drawing.Point(0, 27)
        Me.txtTextArea.Name = "txtTextArea"
        Me.txtTextArea.Size = New System.Drawing.Size(396, 235)
        Me.txtTextArea.TabIndex = 1
        Me.txtTextArea.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.元に戻すUToolStripMenuItem1, Me.ToolStripSeparator2, Me.切り取りTToolStripMenuItem, Me.コピーCToolStripMenuItem1, Me.貼り付けPToolStripMenuItem1, Me.すべて選択AToolStripMenuItem1, Me.ホームToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 142)
        '
        '元に戻すUToolStripMenuItem1
        '
        Me.元に戻すUToolStripMenuItem1.Name = "元に戻すUToolStripMenuItem1"
        Me.元に戻すUToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.元に戻すUToolStripMenuItem1.Text = "元に戻す(&U)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(140, 6)
        '
        '切り取りTToolStripMenuItem
        '
        Me.切り取りTToolStripMenuItem.Name = "切り取りTToolStripMenuItem"
        Me.切り取りTToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.切り取りTToolStripMenuItem.Text = "切り取り(&T)"
        '
        'コピーCToolStripMenuItem1
        '
        Me.コピーCToolStripMenuItem1.Name = "コピーCToolStripMenuItem1"
        Me.コピーCToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.コピーCToolStripMenuItem1.Text = "コピー(&C)"
        '
        '貼り付けPToolStripMenuItem1
        '
        Me.貼り付けPToolStripMenuItem1.Name = "貼り付けPToolStripMenuItem1"
        Me.貼り付けPToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.貼り付けPToolStripMenuItem1.Text = "貼り付け(&P)"
        '
        'すべて選択AToolStripMenuItem1
        '
        Me.すべて選択AToolStripMenuItem1.Name = "すべて選択AToolStripMenuItem1"
        Me.すべて選択AToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.すべて選択AToolStripMenuItem1.Text = "すべて選択(&A)"
        '
        'ホームToolStripMenuItem
        '
        Me.ホームToolStripMenuItem.Name = "ホームToolStripMenuItem"
        Me.ホームToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ホームToolStripMenuItem.Text = "ホーム"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(396, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 261)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtTextArea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "エディタ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 終了XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 開くOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 上書き保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTextArea As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 元に戻すUToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 切り取りTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents コピーCToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 貼り付けPToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents すべて選択AToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ホームToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
