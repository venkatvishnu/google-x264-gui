Public Class Form1
    Dim workpath As String
    Dim outname As String = ""
    Dim inname As String = ""
    Dim assname As String = ""
    Dim audiofilter As String = ""
    Dim videofilter As String = ""
    Dim nerodefault As String = "-q 0.38 -lc"
    Public Function AddExt(ByVal name As String, ByVal ext As String) As String
        Return (name.Remove(name.LastIndexOf(".")) & ext)
    End Function
    Public Function findass(name As String) As String
        Dim Aname As String = AddExt(name, ".ass")
        If File.Exists(Aname) Then Return Aname
        Aname = AddExt(name, ".ssa")
        If File.Exists(Aname) Then Return Aname
        Aname = AddExt(name, ".srt")
        If File.Exists(Aname) Then Return Aname
        Aname = AddExt(name, ".sc.ssa")
        If File.Exists(Aname) Then Return Aname
        Aname = AddExt(name, ".sc.ass")
        If File.Exists(Aname) Then Return Aname
        Dim Dinfo As New DirectoryInfo(Path.GetDirectoryName(name) & "\")
        Dim info As FileInfo
        Dim Nname = Path.GetFileNameWithoutExtension(name)
        For Each info In Dinfo.GetFiles
            If ((info.Name.IndexOf(Nname) <> -1) And ((info.Name.IndexOf(".srt") <> -1) Or (info.Name.IndexOf(".ass") <> -1)) Or (info.Name.IndexOf(".ssa") <> -1)) Then
                If File.Exists(Path.GetDirectoryName(name) & "\" & info.Name) Then Return Path.GetDirectoryName(name) & "\" & info.Name
            End If
        Next
        Return ""
    End Function
    'Form block
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim strArray As String() = New String() {"temp.avs", "x264.bat", "auto.bat"}
        Dim str As String
        For Each str In strArray
            File.Delete(str)
        Next
        Dim contents As String = String.Concat(cmdlist.Text, ";", nerodefault)
        File.WriteAllText(workpath & "\settings.ini", contents)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Process.GetCurrentProcess.MainModule.ModuleName)).Length > 1) Then
            MessageBox.Show("不要同时运行两个o(╯□╰)o", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            MyBase.Close()
        End If
        Me.audiobox.SelectedIndex = Me.audiobox.Items.IndexOf("FAAC")
        audiocmd.Text = "--abitrate 128"
        Me.sethigh.SelectedIndex = Me.sethigh.Items.IndexOf("普通")
        workpath = Application.StartupPath
        If File.Exists("settings.ini") Then
            Dim reader As New StreamReader("settings.ini")
            Dim str As String = reader.ReadToEnd
            reader.Close()
            Dim strArray As String() = str.Split(New Char() {";"c})
            cmdlist.Text = strArray(0)
            '    txtAVS.Text = strArray(3)
            nerodefault = strArray(1)
        End If
        Dim Dinfo As New DirectoryInfo(workpath)
        Dim info As FileInfo
        If Directory.Exists((workpath & "\preset")) Then
            Dim Pinfo As New DirectoryInfo("preset")
            For Each info In Pinfo.GetFiles
                Me.preset.Items.Add(info.Name.Replace(".txt", ""))
            Next
        End If
        For Each info In Dinfo.GetFiles
            If ((info.Name.IndexOf("x264") <> -1) And (info.Name.IndexOf(".exe") <> -1)) Then
                Me.setx264.Items.Add(info.Name)
            End If
        Next
        Me.setx264.SelectedIndex = Me.setx264.Items.IndexOf("x264_64_tMod-8bit-420.exe")
    End Sub
    'Media info block
    Public Function MediaInfo(ByVal VideoName As String) As String
        Dim MI As New MediaInfo
        Dim info As String = "无视频信息"
        If File.Exists(VideoName) Then
            MI.Open(VideoName)
            MI.Option_("Complete")
            info = MI.Inform()
            MI.Close()
        End If
        Return info
    End Function
    Private Sub TextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox1.DragDrop
        Me.TextBox1.Text = MediaInfo(DirectCast(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString)
    End Sub
    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'MP4&MKV block
    'AVS block
    'Solo block
    Private Sub audiobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles audiobox.SelectedIndexChanged
                Select audiobox.Text
            Case "无音频流"
                audiocmd.Text = ""
            Case "复制音频流"
                audiocmd.Text = ""
            Case "QTAAC(x64不可使用)"
                audiocmd.Text = "--abitrate 128"
            Case "libaacplus(低码率)"""
                audiocmd.Text = "--abitrate 128"
            Case "FAAC"
                audiocmd.Text = "--abitrate 128"
            Case "Neroaacenc"
                audiocmd.Text = nerodefault
        End Select
    End Sub
    Private Sub dealnew()
        Dim info As New MediaInfo
        assname = findass(inname)
        If assname.Length <> 0 Then
            asspath.Text = assname
            assenable.Checked = True
        End If
        info.Open(inname)
        If info.Get_(StreamKind.Video, 0, "BitDepth").Equals("10") Then is10bit.Checked = True
        info.Close()
        outname = Path.GetDirectoryName(inname) & "\out\"
        If Not Directory.Exists(outname) Then Directory.CreateDirectory(outname)
        outname += Path.GetFileNameWithoutExtension(inname)
        If RadioMKV.Checked Then outname += ".mkv" Else outname += ".mp4"
        outpath.Text = outname
        btnstart.Enabled = True
        btnadd.Enabled = True
        If ListBox1.Items.Count <> 0 Then btngo.Enabled = True
    End Sub
    Private Sub openvideo_Click(sender As Object, e As EventArgs) Handles openvideo.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "视频" & "(*.mkv;*.mp4;*.avi;*.rmvb)|*.mkv;*.mp4;*.avi;*.rmvb|" & "所有文件" & "(*.*)|*.*"
        If (dialog.ShowDialog = DialogResult.OK) Then
            inname = dialog.FileName
            videopath.Text = inname
            dealnew()
        End If
    End Sub
    Private Sub openout_Click(sender As Object, e As EventArgs) Handles openout.Click
        Dim dialog As New SaveFileDialog
        If RadioMKV.Checked Then
            dialog.Filter = "视频" & "(*.mkv)|*.mkv"
        Else
            dialog.Filter = "视频" & "(*.mp4)|*.mp4"
        End If
        If (dialog.ShowDialog = DialogResult.OK) Then
            outname = dialog.FileName
            outpath.Text = outname
        End If
    End Sub
    Private Sub openass_Click(sender As Object, e As EventArgs)
        Dim dialog As New SaveFileDialog
        dialog.Filter = "字幕" & "(*.srt;*.ass;*.ssa)|*.srt;*.ass;*.ssa"
        If (dialog.ShowDialog = DialogResult.OK) Then
            assname = dialog.FileName
            asspath.Text = assname
            assenable.Checked = True
        End If
    End Sub
    Private Sub checkvideofilter(ByRef ass As String)
        videofilter = "--vf "
        If is10bit.Checked = True Then
            videofilter += "resize:csp=i420:8/"
        End If
        If (assenable.Checked = True) And (ass.Length <> 0) Then
            videofilter += "subtitles/"
        End If
        If videofilter.Length = 5 Then videofilter = "/"
        videofilter = videofilter.Remove(videofilter.LastIndexOf("/"))
        Return
    End Sub
    Private Function lastx264(ByRef inn As String, ByRef out As String, ByRef ass As String) As String
        Dim cmdline As String = cmdlist.Text
        checkvideofilter(ass)
        cmdline += " " & videofilter
        audiofilter = ""
        Select Case audiobox.Text
            Case "无音频流"
                audiofilter = " --acodec none"
            Case "复制音频流"
                audiofilter = " --acodec copy"
                'Case "外置音频流"
                '    audiofilter = (audiofilter & " --audiofile """ & Me.txtX264audio.Text & """")
                '    Exit Select
            Case "QTAAC(x64不可使用)"
                audiofilter = " --acodec qtaac " & audiocmd.Text
            Case "libaacplus(低码率)"""
                audiofilter = " --acodec libaacplus " & audiocmd.Text
            Case "FAAC"
                audiofilter = " --acodec faac " & audiocmd.Text
            Case "Neroaacenc"
                audiofilter = " --audiofile " & """" & AddExt(out, ".m4a") & """"
        End Select
        cmdline += " " & audiofilter
        If (assenable.Checked = True) And (ass.Length <> 0) Then cmdline += " --sub " & """" & ass & """"
        cmdline += " --demuxer lavf "
        cmdline = String.Concat("""", workpath, "\", setx264.SelectedItem.ToString, """  ", cmdline, " -o """, out, """ """, inn, """" & vbCrLf)
        Return cmdline
    End Function
    Private Function getmuxcmdline(ByRef inn As String, ByRef out As String, ByRef ass As String) As String
        Dim cmdline As String = ""
        If audiobox.Text = "Neroaacenc" Then
            cmdline += "ffmpeg.exe -i " & """" & inn & """" & " -f wav - |neroaacenc -ignorelength " & audiocmd.Text & " -if - -of " & """" & AddExt(out, ".m4a") & """" & vbCrLf
        End If
        cmdline += lastx264(inn, out, ass) & vbCrLf
        If audiobox.Text = "Neroaacenc" Then cmdline += "del " & """" & AddExt(inn, ".m4a") & """" & vbCrLf
        Return cmdline
    End Function
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Dim cmdline As String = getmuxcmdline(inname, outname, assname)
        cmdline += "cmd" & vbCrLf
        Dim bat = workpath & "\x264.bat"
        File.WriteAllText(bat, cmdline, System.Text.Encoding.Default)
        If setx264.SelectedItem.ToString.IndexOf("_32_") <> -1 Then
            File.Copy(workpath & "\opencl32.dll", workpath & "\opencl.dll", True)
        Else
            File.Copy(workpath & "\opencl64.dll", workpath & "\opencl.dll", True)
        End If
        Process.Start(bat)
    End Sub
    Private Sub RadioMKV_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMKV.CheckedChanged
        If outname.Length = 0 Then Return
        If RadioMKV.Checked Then outname = AddExt(outname, ".mkv") Else outname = AddExt(outname, ".mp4")
        outpath.Text = outname
    End Sub
    Private Sub audiocmd_TextChanged(sender As Object, e As EventArgs) Handles audiocmd.TextChanged
        If audiobox.Text = "Neroaacenc" Then
            nerodefault = audiocmd.Text
        End If
    End Sub
    Private Sub preset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles preset.SelectedIndexChanged
        Dim reader As New StreamReader((Me.workpath & "\preset\" & preset.Text & ".txt"))
        cmdlist.Text = reader.ReadToEnd
        reader.Close()
    End Sub
    Private Sub sethigh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sethigh.SelectedIndexChanged
        Dim processes As Process() = Process.GetProcesses
        If (((sethigh.SelectedIndex = 4) Or (sethigh.SelectedIndex = 5)) AndAlso (MessageBox.Show("后果自负哦 =。=", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No)) Then
            sethigh.SelectedIndex = 2
        End If
        Dim i As Integer
        For i = 0 To processes.GetLength(0) - 1
            If processes(i).ProcessName.Contains("x264") Then
                Select Case sethigh.SelectedIndex
                    Case 0
                        processes(i).PriorityClass = ProcessPriorityClass.Idle
                        Exit Select
                    Case 1
                        processes(i).PriorityClass = ProcessPriorityClass.BelowNormal
                        Exit Select
                    Case 2
                        processes(i).PriorityClass = ProcessPriorityClass.Normal
                        Exit Select
                    Case 3
                        processes(i).PriorityClass = ProcessPriorityClass.AboveNormal
                        Exit Select
                    Case 4
                        processes(i).PriorityClass = ProcessPriorityClass.High
                        Exit Select
                    Case 5
                        processes(i).PriorityClass = ProcessPriorityClass.RealTime
                        Exit Select
                End Select
            End If
        Next i
    End Sub
    Private Sub solo_DragDrop(sender As Object, e As DragEventArgs) Handles solo.DragDrop
        videopath.Text = DirectCast(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString
        inname = videopath.Text
        dealnew()
    End Sub
    Private Sub solo_DragEnter(sender As Object, e As DragEventArgs) Handles solo.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Batch block
    Private Sub checkall()
        Dim i As Integer
        i = 0
        Do While i <= ListBox1.Items.Count - 1
            If Not cvideo(Path.GetExtension(ListBox1.Items.Item(i).ToString)) Then
                ListBox1.Items.RemoveAt(i)
            Else
                i += 1
            End If
        Loop
    End Sub
    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If ((ListBox1.Items.Count > 0) And (ListBox1.SelectedItems.Count > 0)) Then
            Dim selected As Integer = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If (selected = ListBox1.Items.Count) Then ListBox1.SelectedIndex = (selected - 1)
            If (((selected >= 0) And (selected < ListBox1.Items.Count)) And (ListBox1.Items.Count > 0)) Then ListBox1.SelectedIndex = selected
        End If
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim dialog As New OpenFileDialog
        dialog.Multiselect = True
        dialog.Filter = "视频" & "(*.mkv;*.mp4;*.avi;*.rmvb)|*.mkv;*.mp4;*.avi;*.rmvb|" & "所有文件" & "(*.*)|*.*"
        If (dialog.ShowDialog = DialogResult.OK) Then
            ListBox1.Items.AddRange(dialog.FileNames)
            checkall()
        End If
        btngo.Enabled = True
    End Sub
    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop
        ListBox1.Items.AddRange(DirectCast(e.Data.GetData(DataFormats.FileDrop), Array))
        checkall()
    End Sub
    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Public Function batchAuto() As String
        Dim autocmd As String = ""
        Dim i As Integer
        Dim output As String
        Dim infile As String
        For i = 0 To ListBox1.Items.Count - 1
            infile = ListBox1.Items.Item(i).ToString
            output = Path.GetDirectoryName(infile) & "\out\"
            If Not Directory.Exists(output) Then Directory.CreateDirectory(output)
            output += Path.GetFileNameWithoutExtension(infile)
            If RadioMKV.Checked Then output += ".mkv" Else output += ".mp4"
            autocmd += getmuxcmdline(infile, output, findass(inname))
        Next i
        If Checkshut.Checked Then
            autocmd += "shutdown -f -s -t 60" & vbCrLf
        End If
        Return autocmd & vbCrLf & "cmd"
    End Function
    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        If (ListBox1.Items.Count <> 0) Then
            Dim bat = (workpath & "\auto.bat")
            File.WriteAllText(bat, batchAuto(), System.Text.Encoding.Default)
            If setx264.SelectedItem.ToString.IndexOf("_32_") <> -1 Then
                File.Copy(workpath & "\opencl32.dll", workpath & "\opencl.dll", True)
            Else
                File.Copy(workpath & "\opencl64.dll", workpath & "\opencl.dll", True)
            End If
            Process.Start(bat)
        Else
            MessageBox.Show("请输入视频文件！不许卖萌！", ChrW(38169) & ChrW(35823), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Function cvideo(ByRef ext As String) As Boolean
        If ext = ".mp4" Or ext = ".mkv" Or ext = ".rm" Or ext = ".rmvb" Or ext = ".avi" Then Return True
        Return False
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MessageBox.Show("什么都没有的！ばが！乱戳人家好讨厌的！戳坏了怎么办？！", "讨厌你", MessageBoxButtons.OK)
        Me.Close()
    End Sub


End Class
