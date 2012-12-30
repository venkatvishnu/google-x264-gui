<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.solo = New System.Windows.Forms.TabPage()
        Me.RadioMP4 = New System.Windows.Forms.RadioButton()
        Me.RadioMKV = New System.Windows.Forms.RadioButton()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.Group2 = New System.Windows.Forms.GroupBox()
        Me.audiocmd = New System.Windows.Forms.TextBox()
        Me.audiobox = New System.Windows.Forms.ComboBox()
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.is10bit = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.preset = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdlist = New System.Windows.Forms.TextBox()
        Me.sethigh = New System.Windows.Forms.ComboBox()
        Me.setx264 = New System.Windows.Forms.ComboBox()
        Me.openout = New System.Windows.Forms.Button()
        Me.openass = New System.Windows.Forms.Button()
        Me.outpath = New System.Windows.Forms.TextBox()
        Me.assenable = New System.Windows.Forms.CheckBox()
        Me.asspath = New System.Windows.Forms.TextBox()
        Me.openvideo = New System.Windows.Forms.Button()
        Me.videopath = New System.Windows.Forms.TextBox()
        Me.batch = New System.Windows.Forms.TabPage()
        Me.btngo = New System.Windows.Forms.Button()
        Me.Checkshut = New System.Windows.Forms.CheckBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.info = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.box = New System.Windows.Forms.TabPage()
        Me.callmmg = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.avs = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.About = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tab1.SuspendLayout()
        Me.solo.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.batch.SuspendLayout()
        Me.info.SuspendLayout()
        Me.box.SuspendLayout()
        Me.avs.SuspendLayout()
        Me.About.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.solo)
        Me.Tab1.Controls.Add(Me.batch)
        Me.Tab1.Controls.Add(Me.info)
        Me.Tab1.Controls.Add(Me.box)
        Me.Tab1.Controls.Add(Me.avs)
        Me.Tab1.Controls.Add(Me.About)
        Me.Tab1.Location = New System.Drawing.Point(0, 0)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(716, 483)
        Me.Tab1.TabIndex = 0
        '
        'solo
        '
        Me.solo.AllowDrop = True
        Me.solo.Controls.Add(Me.RadioMP4)
        Me.solo.Controls.Add(Me.RadioMKV)
        Me.solo.Controls.Add(Me.btnstart)
        Me.solo.Controls.Add(Me.Group2)
        Me.solo.Controls.Add(Me.Group1)
        Me.solo.Location = New System.Drawing.Point(4, 22)
        Me.solo.Name = "solo"
        Me.solo.Padding = New System.Windows.Forms.Padding(3)
        Me.solo.Size = New System.Drawing.Size(708, 457)
        Me.solo.TabIndex = 0
        Me.solo.Text = "SOLO"
        Me.solo.UseVisualStyleBackColor = True
        '
        'RadioMP4
        '
        Me.RadioMP4.AutoSize = True
        Me.RadioMP4.Checked = True
        Me.RadioMP4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RadioMP4.Location = New System.Drawing.Point(218, 409)
        Me.RadioMP4.Name = "RadioMP4"
        Me.RadioMP4.Size = New System.Drawing.Size(63, 25)
        Me.RadioMP4.TabIndex = 14
        Me.RadioMP4.TabStop = True
        Me.RadioMP4.Text = "MP4"
        Me.RadioMP4.UseVisualStyleBackColor = True
        '
        'RadioMKV
        '
        Me.RadioMKV.AutoSize = True
        Me.RadioMKV.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RadioMKV.Location = New System.Drawing.Point(31, 409)
        Me.RadioMKV.Name = "RadioMKV"
        Me.RadioMKV.Size = New System.Drawing.Size(65, 25)
        Me.RadioMKV.TabIndex = 13
        Me.RadioMKV.Text = "MKV"
        Me.RadioMKV.UseVisualStyleBackColor = True
        '
        'btnstart
        '
        Me.btnstart.Enabled = False
        Me.btnstart.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnstart.Location = New System.Drawing.Point(523, 399)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(162, 52)
        Me.btnstart.TabIndex = 12
        Me.btnstart.Text = "压制"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'Group2
        '
        Me.Group2.Controls.Add(Me.audiocmd)
        Me.Group2.Controls.Add(Me.audiobox)
        Me.Group2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Group2.Location = New System.Drawing.Point(8, 324)
        Me.Group2.Name = "Group2"
        Me.Group2.Size = New System.Drawing.Size(691, 69)
        Me.Group2.TabIndex = 7
        Me.Group2.TabStop = False
        Me.Group2.Text = "Audio"
        '
        'audiocmd
        '
        Me.audiocmd.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.audiocmd.Location = New System.Drawing.Point(332, 32)
        Me.audiocmd.Name = "audiocmd"
        Me.audiocmd.Size = New System.Drawing.Size(345, 23)
        Me.audiocmd.TabIndex = 9
        '
        'audiobox
        '
        Me.audiobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.audiobox.FormattingEnabled = True
        Me.audiobox.Items.AddRange(New Object() {"Neroaacenc", "FAAC", "QTAAC（x64不可使用）", "libaacplus（低码率）", "复制音频流", "无音频流"})
        Me.audiobox.Location = New System.Drawing.Point(19, 28)
        Me.audiobox.Name = "audiobox"
        Me.audiobox.Size = New System.Drawing.Size(299, 29)
        Me.audiobox.TabIndex = 4
        '
        'Group1
        '
        Me.Group1.Controls.Add(Me.Label7)
        Me.Group1.Controls.Add(Me.is10bit)
        Me.Group1.Controls.Add(Me.Label6)
        Me.Group1.Controls.Add(Me.preset)
        Me.Group1.Controls.Add(Me.Label5)
        Me.Group1.Controls.Add(Me.Label4)
        Me.Group1.Controls.Add(Me.cmdlist)
        Me.Group1.Controls.Add(Me.sethigh)
        Me.Group1.Controls.Add(Me.setx264)
        Me.Group1.Controls.Add(Me.openout)
        Me.Group1.Controls.Add(Me.openass)
        Me.Group1.Controls.Add(Me.outpath)
        Me.Group1.Controls.Add(Me.assenable)
        Me.Group1.Controls.Add(Me.asspath)
        Me.Group1.Controls.Add(Me.openvideo)
        Me.Group1.Controls.Add(Me.videopath)
        Me.Group1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Group1.Location = New System.Drawing.Point(8, 6)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(691, 312)
        Me.Group1.TabIndex = 1
        Me.Group1.TabStop = False
        Me.Group1.Text = "Video"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(193, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(329, 21)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "黑边、分辨率、帧率、切边、AVS输入工事中"
        '
        'is10bit
        '
        Me.is10bit.AutoSize = True
        Me.is10bit.Location = New System.Drawing.Point(336, 231)
        Me.is10bit.Name = "is10bit"
        Me.is10bit.Size = New System.Drawing.Size(88, 25)
        Me.is10bit.TabIndex = 20
        Me.is10bit.Text = "10bit 源"
        Me.is10bit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 21)
        Me.Label6.TabIndex = 19
        '
        'preset
        '
        Me.preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.preset.FormattingEnabled = True
        Me.preset.Location = New System.Drawing.Point(402, 189)
        Me.preset.Name = "preset"
        Me.preset.Size = New System.Drawing.Size(279, 29)
        Me.preset.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "预置"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "优先级"
        '
        'cmdlist
        '
        Me.cmdlist.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmdlist.Location = New System.Drawing.Point(23, 170)
        Me.cmdlist.Multiline = True
        Me.cmdlist.Name = "cmdlist"
        Me.cmdlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cmdlist.Size = New System.Drawing.Size(299, 86)
        Me.cmdlist.TabIndex = 15
        '
        'sethigh
        '
        Me.sethigh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sethigh.FormattingEnabled = True
        Me.sethigh.Items.AddRange(New Object() {"低", "低于标准", "普通", "高于标准", "高", "实时"})
        Me.sethigh.Location = New System.Drawing.Point(402, 135)
        Me.sethigh.Name = "sethigh"
        Me.sethigh.Size = New System.Drawing.Size(279, 29)
        Me.sethigh.TabIndex = 14
        '
        'setx264
        '
        Me.setx264.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setx264.FormattingEnabled = True
        Me.setx264.Location = New System.Drawing.Point(23, 135)
        Me.setx264.Name = "setx264"
        Me.setx264.Size = New System.Drawing.Size(299, 29)
        Me.setx264.TabIndex = 13
        '
        'openout
        '
        Me.openout.Location = New System.Drawing.Point(606, 100)
        Me.openout.Name = "openout"
        Me.openout.Size = New System.Drawing.Size(75, 29)
        Me.openout.TabIndex = 6
        Me.openout.Text = "输出"
        Me.openout.UseVisualStyleBackColor = True
        '
        'openass
        '
        Me.openass.Location = New System.Drawing.Point(606, 65)
        Me.openass.Name = "openass"
        Me.openass.Size = New System.Drawing.Size(75, 29)
        Me.openass.TabIndex = 5
        Me.openass.Text = "字幕"
        Me.openass.UseVisualStyleBackColor = True
        '
        'outpath
        '
        Me.outpath.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.outpath.Location = New System.Drawing.Point(23, 100)
        Me.outpath.Name = "outpath"
        Me.outpath.Size = New System.Drawing.Size(577, 23)
        Me.outpath.TabIndex = 4
        '
        'assenable
        '
        Me.assenable.AutoSize = True
        Me.assenable.Location = New System.Drawing.Point(23, 72)
        Me.assenable.Name = "assenable"
        Me.assenable.Size = New System.Drawing.Size(15, 14)
        Me.assenable.TabIndex = 3
        Me.assenable.UseVisualStyleBackColor = True
        '
        'asspath
        '
        Me.asspath.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.asspath.Location = New System.Drawing.Point(44, 65)
        Me.asspath.Name = "asspath"
        Me.asspath.Size = New System.Drawing.Size(556, 23)
        Me.asspath.TabIndex = 2
        '
        'openvideo
        '
        Me.openvideo.Location = New System.Drawing.Point(606, 30)
        Me.openvideo.Name = "openvideo"
        Me.openvideo.Size = New System.Drawing.Size(75, 29)
        Me.openvideo.TabIndex = 1
        Me.openvideo.Text = "视频"
        Me.openvideo.UseVisualStyleBackColor = True
        '
        'videopath
        '
        Me.videopath.AllowDrop = True
        Me.videopath.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.videopath.Location = New System.Drawing.Point(23, 30)
        Me.videopath.Name = "videopath"
        Me.videopath.Size = New System.Drawing.Size(577, 23)
        Me.videopath.TabIndex = 0
        '
        'batch
        '
        Me.batch.Controls.Add(Me.btngo)
        Me.batch.Controls.Add(Me.Checkshut)
        Me.batch.Controls.Add(Me.btnclear)
        Me.batch.Controls.Add(Me.btndel)
        Me.batch.Controls.Add(Me.btnadd)
        Me.batch.Controls.Add(Me.ListBox1)
        Me.batch.Location = New System.Drawing.Point(4, 22)
        Me.batch.Name = "batch"
        Me.batch.Padding = New System.Windows.Forms.Padding(3)
        Me.batch.Size = New System.Drawing.Size(708, 457)
        Me.batch.TabIndex = 1
        Me.batch.Text = "批量"
        Me.batch.UseVisualStyleBackColor = True
        '
        'btngo
        '
        Me.btngo.Enabled = False
        Me.btngo.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btngo.Location = New System.Drawing.Point(566, 417)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(136, 34)
        Me.btngo.TabIndex = 5
        Me.btngo.Text = "GO！"
        Me.btngo.UseVisualStyleBackColor = True
        '
        'Checkshut
        '
        Me.Checkshut.AutoSize = True
        Me.Checkshut.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Checkshut.Location = New System.Drawing.Point(444, 426)
        Me.Checkshut.Name = "Checkshut"
        Me.Checkshut.Size = New System.Drawing.Size(109, 25)
        Me.Checkshut.TabIndex = 4
        Me.Checkshut.Text = "完成后关机"
        Me.Checkshut.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnclear.Location = New System.Drawing.Point(290, 420)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(136, 34)
        Me.btnclear.TabIndex = 3
        Me.btnclear.Text = "清空"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btndel.Location = New System.Drawing.Point(148, 420)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(136, 34)
        Me.btndel.TabIndex = 2
        Me.btndel.Text = "删除"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Enabled = False
        Me.btnadd.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnadd.Location = New System.Drawing.Point(6, 420)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(136, 34)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "添加"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(6, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(696, 400)
        Me.ListBox1.TabIndex = 0
        '
        'info
        '
        Me.info.Controls.Add(Me.TextBox1)
        Me.info.Location = New System.Drawing.Point(4, 22)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(708, 457)
        Me.info.TabIndex = 3
        Me.info.Text = "MediaInfo"
        Me.info.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.MaxLength = 2147438467
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(702, 454)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "拖入视频文件，吐出信息"
        '
        'box
        '
        Me.box.Controls.Add(Me.callmmg)
        Me.box.Controls.Add(Me.Label1)
        Me.box.Location = New System.Drawing.Point(4, 22)
        Me.box.Name = "box"
        Me.box.Size = New System.Drawing.Size(708, 457)
        Me.box.TabIndex = 4
        Me.box.Text = "MP4&MKV"
        Me.box.UseVisualStyleBackColor = True
        '
        'callmmg
        '
        Me.callmmg.Enabled = False
        Me.callmmg.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.callmmg.Location = New System.Drawing.Point(25, 16)
        Me.callmmg.Name = "callmmg"
        Me.callmmg.Size = New System.Drawing.Size(110, 44)
        Me.callmmg.TabIndex = 1
        Me.callmmg.Text = "调用mmg"
        Me.callmmg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "制作待决定"
        '
        'avs
        '
        Me.avs.Controls.Add(Me.Label3)
        Me.avs.Location = New System.Drawing.Point(4, 22)
        Me.avs.Name = "avs"
        Me.avs.Size = New System.Drawing.Size(708, 457)
        Me.avs.TabIndex = 6
        Me.avs.Text = "AVS"
        Me.avs.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(350, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 39)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "工事中……"
        '
        'About
        '
        Me.About.Controls.Add(Me.Label2)
        Me.About.Location = New System.Drawing.Point(4, 22)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(708, 457)
        Me.About.TabIndex = 5
        Me.About.Text = "About"
        Me.About.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(563, 429)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 491)
        Me.Controls.Add(Me.Tab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "My x264 GUI"
        Me.Tab1.ResumeLayout(False)
        Me.solo.ResumeLayout(False)
        Me.solo.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.batch.ResumeLayout(False)
        Me.batch.PerformLayout()
        Me.info.ResumeLayout(False)
        Me.info.PerformLayout()
        Me.box.ResumeLayout(False)
        Me.box.PerformLayout()
        Me.avs.ResumeLayout(False)
        Me.avs.PerformLayout()
        Me.About.ResumeLayout(False)
        Me.About.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab1 As System.Windows.Forms.TabControl
    Friend WithEvents solo As System.Windows.Forms.TabPage
    Friend WithEvents batch As System.Windows.Forms.TabPage
    Friend WithEvents info As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents box As System.Windows.Forms.TabPage
    Friend WithEvents callmmg As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents About As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Group1 As System.Windows.Forms.GroupBox
    Friend WithEvents videopath As System.Windows.Forms.TextBox
    Friend WithEvents avs As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents openvideo As System.Windows.Forms.Button
    Friend WithEvents openout As System.Windows.Forms.Button
    Friend WithEvents openass As System.Windows.Forms.Button
    Friend WithEvents outpath As System.Windows.Forms.TextBox
    Friend WithEvents assenable As System.Windows.Forms.CheckBox
    Friend WithEvents asspath As System.Windows.Forms.TextBox
    Friend WithEvents Group2 As System.Windows.Forms.GroupBox
    Friend WithEvents audiobox As System.Windows.Forms.ComboBox
    Friend WithEvents audiocmd As System.Windows.Forms.TextBox
    Friend WithEvents RadioMP4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMKV As System.Windows.Forms.RadioButton
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents setx264 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents sethigh As System.Windows.Forms.ComboBox
    Friend WithEvents btngo As System.Windows.Forms.Button
    Friend WithEvents Checkshut As System.Windows.Forms.CheckBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdlist As System.Windows.Forms.TextBox
    Friend WithEvents preset As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents is10bit As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
