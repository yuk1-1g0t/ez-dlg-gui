<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TabPage2 = New TabPage()
        title = New Label()
        subtitle = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 165)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1398, 781)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1390, 743)
        TabPage1.TabIndex = 0
        TabPage1.Text = "全般"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Yu Gothic UI", 9F)
        Button1.Location = New Point(463, 57)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 2
        Button1.Text = "参照…"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Yu Gothic UI", 10F)
        TextBox1.Location = New Point(16, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(432, 34)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 25)
        Label1.TabIndex = 0
        Label1.Text = "デフォルトの保存先"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.White
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1390, 743)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("Yu Gothic UI", 15F)
        title.Location = New Point(16, 36)
        title.Name = "title"
        title.Size = New Size(138, 41)
        title.TabIndex = 1
        title.Text = "環境設定"
        ' 
        ' subtitle
        ' 
        subtitle.AutoSize = True
        subtitle.Font = New Font("Yu Gothic UI", 10F)
        subtitle.Location = New Point(16, 77)
        subtitle.Name = "subtitle"
        subtitle.Size = New Size(265, 28)
        subtitle.TabIndex = 2
        subtitle.Text = "ez-dlp-gui の設定を変更します"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(title)
        Panel1.Controls.Add(subtitle)
        Panel1.Location = New Point(-4, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1428, 142)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.settings
        PictureBox1.Location = New Point(1309, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(90, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' settings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1422, 1069)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "settings"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "環境設定"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents title As Label
    Friend WithEvents subtitle As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
