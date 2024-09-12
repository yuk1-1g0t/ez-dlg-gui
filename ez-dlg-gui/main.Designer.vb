<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        subtitle = New Label()
        title = New Label()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        vurl = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        GroupBox4 = New GroupBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        CheckBox1 = New CheckBox()
        GroupBox3 = New GroupBox()
        Label4 = New Label()
        vainfo = New Label()
        Label2 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        ToolTip1 = New ToolTip(components)
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button1 = New Button()
        GroupBox5 = New GroupBox()
        CheckBox2 = New CheckBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Label6 = New Label()
        ComboBox2 = New ComboBox()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(subtitle)
        Panel1.Controls.Add(title)
        Panel1.Location = New Point(-2, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2096, 144)
        Panel1.TabIndex = 1
        ' 
        ' subtitle
        ' 
        subtitle.AutoSize = True
        subtitle.Font = New Font("Yu Gothic UI", 10F)
        subtitle.Location = New Point(14, 81)
        subtitle.Name = "subtitle"
        subtitle.Size = New Size(317, 28)
        subtitle.TabIndex = 3
        subtitle.Text = "ダウンロードする動画/形式を選択します"
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("Yu Gothic UI", 15F)
        title.Location = New Point(14, 40)
        title.Name = "title"
        title.Size = New Size(157, 41)
        title.TabIndex = 2
        title.Text = "ez-dlp-gui"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(vurl)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(21, 161)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(672, 144)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "動画"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Yu Gothic UI", 8F)
        Button2.Location = New Point(507, 72)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 42)
        Button2.TabIndex = 2
        Button2.Text = "貼りつけ"
        ToolTip1.SetToolTip(Button2, "クリップボードから貼り付けます")
        Button2.UseVisualStyleBackColor = True
        ' 
        ' vurl
        ' 
        vurl.Location = New Point(22, 77)
        vurl.Name = "vurl"
        vurl.Size = New Size(479, 31)
        vurl.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 10F)
        Label1.Location = New Point(22, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 0
        Label1.Text = "動画のURL"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox4)
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Location = New Point(716, 161)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(672, 702)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "設定"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(ComboBox2)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(ComboBox1)
        GroupBox4.Controls.Add(CheckBox1)
        GroupBox4.Location = New Point(22, 283)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(625, 355)
        GroupBox4.TabIndex = 1
        GroupBox4.TabStop = False
        GroupBox4.Text = "詳細設定"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 25)
        Label3.TabIndex = 2
        Label3.Text = "ファイル拡張子"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Enabled = False
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(147, 70)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(187, 33)
        ComboBox1.TabIndex = 1
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(25, 35)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(160, 29)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "詳細設定を使用"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(vainfo)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(RadioButton2)
        GroupBox3.Controls.Add(RadioButton1)
        GroupBox3.Location = New Point(22, 30)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(625, 247)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "基本設定"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 10F)
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(16, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 28)
        Label4.TabIndex = 3
        Label4.Text = "保存形式"
        ' 
        ' vainfo
        ' 
        vainfo.AutoSize = True
        vainfo.Cursor = Cursors.IBeam
        vainfo.Location = New Point(16, 148)
        vainfo.Name = "vainfo"
        vainfo.Size = New Size(489, 75)
        vainfo.TabIndex = 9
        vainfo.Text = "動画ファイルとしてダウンロードします。" & vbCrLf & "VLCなどのメディアプレイヤーで映像と音声で再生することができます。" & vbCrLf & "ファイルサイズは、必然的に大きくなります。"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(16, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 25)
        Label2.TabIndex = 8
        Label2.Text = "説明"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(167, 71)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(124, 29)
        RadioButton2.TabIndex = 7
        RadioButton2.Text = "音声ファイル"
        ToolTip1.SetToolTip(RadioButton2, "音声ファイルとしてダウンロードします")
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(37, 71)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(124, 29)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.Text = "動画ファイル"
        ToolTip1.SetToolTip(RadioButton1, "動画ファイルとしてダウンロードします")
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Yu Gothic UI", 8F)
        Button3.Location = New Point(177, 168)
        Button3.Name = "Button3"
        Button3.Size = New Size(140, 42)
        Button3.TabIndex = 5
        Button3.Text = "参照…"
        ToolTip1.SetToolTip(Button3, "保存先のフォルダを参照します")
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Yu Gothic UI", 8F)
        Button4.Location = New Point(507, 168)
        Button4.Name = "Button4"
        Button4.Size = New Size(140, 42)
        Button4.TabIndex = 6
        Button4.Text = "貼りつけ"
        ToolTip1.SetToolTip(Button4, "クリップボードから貼り付けます")
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Yu Gothic UI", 8F)
        Button5.Location = New Point(323, 168)
        Button5.Name = "Button5"
        Button5.Size = New Size(178, 42)
        Button5.TabIndex = 7
        Button5.Text = "エクスプローラーで開く"
        ToolTip1.SetToolTip(Button5, "保存先のフォルダを開きます")
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1806, 876)
        Button1.Name = "Button1"
        Button1.Size = New Size(251, 68)
        Button1.TabIndex = 5
        Button1.Text = "ダウンロード"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(CheckBox2)
        GroupBox5.Controls.Add(Button5)
        GroupBox5.Controls.Add(TextBox1)
        GroupBox5.Controls.Add(Label5)
        GroupBox5.Controls.Add(Button4)
        GroupBox5.Controls.Add(Button3)
        GroupBox5.Location = New Point(21, 311)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(672, 237)
        GroupBox5.TabIndex = 6
        GroupBox5.TabStop = False
        GroupBox5.Text = "保存先"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Checked = True
        CheckBox2.CheckState = CheckState.Checked
        CheckBox2.Location = New Point(22, 38)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(193, 29)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "既定の保存先を使用"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.ImeMode = ImeMode.Off
        TextBox1.Location = New Point(22, 125)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(625, 31)
        TextBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 10F)
        Label5.Location = New Point(22, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 28)
        Label5.TabIndex = 3
        Label5.Text = "動画の保存先"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 117)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 25)
        Label6.TabIndex = 4
        Label6.Text = "ファイル拡張子"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Enabled = False
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(147, 114)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(187, 33)
        ComboBox2.TabIndex = 3
        ' 
        ' main
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(2089, 973)
        Controls.Add(GroupBox5)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ez-dlp-gui"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        settings.ShowDialog()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents title As Label
    Friend WithEvents subtitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents vurl As TextBox

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.Clipboard.ContainsText Then
            Dim clipboardText = My.Computer.Clipboard.GetText
            vurl.Text = clipboardText
        End If
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        vainfo.Text = "音声ファイルとしてダウンロードします。
VLCなどのメディアプレイヤーで音声のみで再生することができます。
ファイルサイズは、動画ファイルに比べて小さくなります。"
        Label5.Text = "音声ファイルの保存先"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        vainfo.Text = "動画ファイルとしてダウンロードします。
VLCなどのメディアプレイヤーで映像と音声で再生することができます。
ファイルサイズは、必然的に大きくなります。"
        Label5.Text = "動画ファイルの保存先"
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents vainfo As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Ret As DialogResult
        Using Dialog As New FolderBrowserDialog()
            With Dialog
                .Description = "保存先のフォルダ"
            End With
            Ret = Dialog.ShowDialog()
            If Ret = DialogResult.OK Then
                TextBox1.Text = Dialog.SelectedPath
            End If
        End Using
    End Sub

    Friend WithEvents CheckBox2 As CheckBox

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked = True Then
            TextBox1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        Else
            TextBox1.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim folderPath As String
        folderPath = TextBox1.Text.Replace("/", "\")
        folderPath = Chr(34) & folderPath & Chr(34)
        If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) = True Then
            System.Diagnostics.Process.Start("EXPLORER.EXE", folderPath)
        Else
            MessageBox.Show(TextBox1.Text & " を開けません
フォルダパスまたは、アクセス権を確認してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim clipboardText = My.Computer.Clipboard.GetText
        TextBox1.Text = clipboardText
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim folderPath As String
        folderPath = TextBox1.Text.Replace("/", "\")
        TextBox1.Text = folderPath
        TextBox1.Select(TextBox1.Text.Length, 0)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
End Class
