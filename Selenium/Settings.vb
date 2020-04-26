Imports System.IO
Imports System.Net
Imports System.Threading
Imports Microsoft.VisualBasic


Public Class Settings

    Public Sub Wait(ByVal interval As Integer)
        Dim stopW As New Stopwatch
        stopW.Start()
        Do While stopW.ElapsedMilliseconds < interval
            ' Allows your UI to remain responsive
            Application.DoEvents()
        Loop
        stopW.Stop()
    End Sub

    Public Property AddresOf As ThreadStart

    '################################################################################ Custom Chat ################################################################################

    Public Sub Followbox_CheckedChanged(sender As Object, e As EventArgs) Handles Followbox.CheckedChanged
        If Followbox.Checked = True Then
            Power.Follow = True
        Else
            Power.Follow = False
        End If

    End Sub

    Public Sub Chatbox_CheckedChanged(sender As Object, e As EventArgs) Handles Chatbox.CheckedChanged
        If chromehide.Checked = True Then
            MessageBox.Show("You are using ""Hide Chrometab""." & vbLf & "It may will not be able to write in Streamers Chat." & vbLf & vbLf & "If you want this feature to work 100% disable ""Hide Chrometab"".")
        End If

        If Chatbox.Checked = True Then
            Power.Chat = True
        Else
            Power.Chat = False
        End If
    End Sub

    Public Sub Chromehide_CheckedChanged(sender As Object, e As EventArgs) Handles chromehide.CheckedChanged
        If tokenlogin.Checked = True Then
            If chromehide.Checked = True Then
                Power.chromehide = True
            Else
                Power.chromehide = False
            End If
        Else
            If chromehide.Checked = True Then
                MessageBox.Show("Please use this only with Twitch auth token login." & vbLf & "Using this with Username Password login may leads to issues!")
                Power.chromehide = True
            Else
                Power.chromehide = False
            End If
        End If
    End Sub

    Public Sub Tokenlogin_CheckedChanged(sender As Object, e As EventArgs) Handles tokenlogin.CheckedChanged
        If tokenlogin.Checked = True Then
            MessageBox.Show("You might need a new token." & vbLf & "Please use a new token every 24 - 42 hours.")
            Power.tokenlogin = True
        Else
            Power.tokenlogin = False
        End If
    End Sub

    Public Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ToolTip1.Active = False
        Else
            ToolTip1.Active = True
        End If
    End Sub

    Public Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Power.Streamquality = True
        Else
            Power.Streamquality = False
        End If
    End Sub

    Public Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Power.Streamchathide = True
            Chatbox.Hide()
            Chatinput.Hide()
            Chatinput2.Hide()
            Chatbox.Enabled = False
            Chatinput.Enabled = False
            Chatinput2.Enabled = False
            Chatminute.Hide()
            Chatminute.Enabled = False
            Label6.Enabled = False
            Label6.Hide()
            Label5.Enabled = False
            Label5.Hide()
        Else
            Power.Streamchathide = False
            Chatbox.Show()
            Chatinput.Show()
            Chatinput2.Show()
            Chatbox.Enabled = True
            Chatinput.Enabled = True
            Chatinput2.Enabled = True
            Chatminute.Show()
            Chatminute.Enabled = True
            Label6.Enabled = True
            Label6.Show()
            Label5.Enabled = True
            Label5.Show()
        End If
    End Sub

    Public Sub Muteaudio_CheckedChanged(sender As Object, e As EventArgs) Handles muteaudio.CheckedChanged
        If muteaudio.Checked = True Then
            customaudio.Hide()
            customaudio.Enabled = False
            volinput.Hide()
            volinput.Enabled = False
            Power.muteaudio = True
        Else
            customaudio.Show()
            customaudio.Enabled = True
            volinput.Show()
            volinput.Enabled = True
            Power.muteaudio = False
        End If
    End Sub

    Public Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles randomstreambox.CheckedChanged
        If randomstreambox.Checked = True Then
            Power.Diffstream = True
        Else
            Power.Diffstream = True
        End If
    End Sub


    '################################################################################ Start With low CPU ################################################################################

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles restart.Click
        If File.Exists(Application.StartupPath & "\start-with-low-cpu.txt") = True Then         'Too bad I couldn't have done better, but I tried. You better thank me.
            Application.Restart()
        Else
            File.Create(Application.StartupPath & "\start-with-low-cpu.txt").Dispose()
            Wait(1000)
            Dim fs As New FileStream("start-with-low-cpu.txt", FileMode.Open)
            Wait(1000)
            Dim sw As New StreamWriter(fs)
            Wait(1000)
            sw.WriteLine("Delete This .txt File if you want to start the Program with Normal Priority again")
            Wait(1000)
            sw.Close()
            Wait(100)
            Application.Restart()
        End If
    End Sub

    Public Sub Prioritymode_CheckedChanged(sender As Object, e As EventArgs) Handles prioritymode.CheckedChanged

        If prioritymode.Checked = True Then
            Power.prioritymode = True
            If Power.Background = True Then
                prioritymode.Checked = False
                MessageBox.Show("This feature only works in ""CrossThreadCall"" mode" & vbLf & vbLf & "Please switch the Button from ""Backgroundworkers"" to ""CrossThreadCalls""")
                Power.prioritymode = False
            End If
        End If

    End Sub

    Public Sub Backgroundbox_CheckedChanged(sender As Object, e As EventArgs) Handles Backgroundbox.CheckedChanged

        If Backgroundbox.Checked = True Then
            Power.Crossthread = False
            Power.Background = True
            Crossthreadbox.Hide()
            Crossthreadbox.Enabled = False
            If prioritymode.Checked = True Then
                MessageBox.Show("Low Prioritymode only works with CrossThreadCalls" & vbLf & vbLf & "Please disable Low Priority!")
                Power.Background = False
                Crossthreadbox.Show()
                Crossthreadbox.Enabled = True
                Backgroundbox.Checked = False
            End If
        Else
            Crossthreadbox.Show()
            Crossthreadbox.Enabled = True
            Power.Background = False
        End If
    End Sub

    Public Sub Crossthreadbox_CheckedChanged(sender As Object, e As EventArgs) Handles Crossthreadbox.CheckedChanged
        If Crossthreadbox.Checked = True Then
            Power.Crossthread = True
            Power.Background = False
            Backgroundbox.Hide()
            Backgroundbox.Enabled = False
        Else
            Backgroundbox.Show()
            Backgroundbox.Enabled = True
            Power.Crossthread = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Power.Userinput = Usernametext.Text
        Power.waitminute = Chatminute.Text
        Power.Message1 = Chatinput.Text
        Power.Message2 = Chatinput2.Text
        Power.Waittime = Waitbox.Text
        Power.volume = volinput.Text
        Power.Streamertext = Streamerinput.Text
        Power.Passinput = Passwordtext.Text
        Power.Proxyport = proxyinput.Text
        'cookiesave
        'Prioritymode
        'commandhide
        'chromehide
        'crossthread
        'Streamchathide
        'chat
        'Follow
        'Diffstream
        'Watchstreamer
        'customaudio
        'Streamquality
        'muteaudio
        'checkdrop
        'claimpoints
        'Proxy
        'tokenlogin
    End Sub

    Private Sub Cookiessave_CheckedChanged(sender As Object, e As EventArgs) Handles cookiessave.CheckedChanged
        If cookiessave.Checked = True Then
            Power.cookiesave = True
        Else
            Power.cookiesave = False
        End If
    End Sub

    Private Sub Commandhide_CheckedChanged(sender As Object, e As EventArgs) Handles commandhide.CheckedChanged
        If commandhide.Checked = True Then
            Power.commandhide = True
        Else
            Power.commandhide = False
        End If
    End Sub

    Private Sub Chatminute_TextChanged(sender As Object, e As EventArgs) Handles Chatminute.TextChanged
        Power.waitminute = Chatminute.Text
    End Sub

    Private Sub Chatinput_TextChanged(sender As Object, e As EventArgs) Handles Chatinput.TextChanged
        Power.Message1 = Chatinput.Text
    End Sub

    Private Sub Chatinput2_TextChanged(sender As Object, e As EventArgs) Handles Chatinput2.TextChanged
        Power.Message2 = Chatinput2.Text
    End Sub

    Private Sub Watchstreamer_CheckedChanged(sender As Object, e As EventArgs) Handles Watchstreamer.CheckedChanged
        If Watchstreamer.Checked = True Then
            Power.Watchstreamer = True
        Else
            Power.Watchstreamer = False
        End If
    End Sub

    Private Sub Waitbox_TextChanged(sender As Object, e As EventArgs) Handles Waitbox.TextChanged
        Power.Waittime = Waitbox.Text
    End Sub

    Private Sub Streamerinput_TextChanged(sender As Object, e As EventArgs) Handles Streamerinput.TextChanged
        Power.Streamertext = Streamerinput.Text
    End Sub

    Private Sub Customaudio_CheckedChanged(sender As Object, e As EventArgs) Handles customaudio.CheckedChanged
        If customaudio.Checked = True Then
            Power.customaudio = True
        Else
            Power.customaudio = False
        End If
    End Sub

    Private Sub Volinput_TextChanged(sender As Object, e As EventArgs) Handles volinput.TextChanged
        Power.volume = volinput.Text
    End Sub

    Private Sub Checkdrop_CheckedChanged(sender As Object, e As EventArgs) Handles Checkdrop.CheckedChanged
        If Checkdrop.Checked = True Then
            Power.checkdrop = True
        Else
            Power.checkdrop = False
        End If
    End Sub

    Private Sub Claimpoints_CheckedChanged(sender As Object, e As EventArgs) Handles Claimpoints.CheckedChanged
        If Claimpoints.Checked = True Then
            Power.claimpoints = True
        Else
            Power.claimpoints = False
        End If
    End Sub

    Private Sub Proxycheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles proxycheckbox.CheckedChanged
        If proxycheckbox.Checked = True Then
            Power.Proxy = True
        Else
            Power.Proxy = False
        End If
    End Sub

    Private Sub Proxyinput_TextChanged(sender As Object, e As EventArgs) Handles proxyinput.TextChanged
        Power.Proxyport = proxyinput.Text
    End Sub

    Private Sub Tokeninput_TextChanged(sender As Object, e As EventArgs) Handles tokeninput.TextChanged
        Power.tokentext = tokeninput.Text
    End Sub

    Private Sub Usernametext_TextChanged(sender As Object, e As EventArgs) Handles Usernametext.TextChanged
        Power.Usernameinput = Usernametext.Text
    End Sub

    Private Sub Passwordtext_TextChanged(sender As Object, e As EventArgs) Handles Passwordtext.TextChanged
        Power.Passwordinput = Passwordtext.Text
    End Sub
End Class