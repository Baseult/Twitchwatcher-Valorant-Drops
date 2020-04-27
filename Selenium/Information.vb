
'   _______             _             _    _               ______                              _         
'  (_______)           | |           | |  | |             (____  \                            | |    _   
'   _         ___    __| | _____   __| |  | |__   _   _    ____)  ) _____   ___  _____  _   _ | |  _| |_ 
'  | |       / _ \  / _  || ___ | / _  |  |  _ \ | | | |  |  __  ( (____ | /___)| ___ || | | || | (_   _)
'  | |_____ | |_| |( (_| || ____|( (_| |  | |_) )| |_| |  | |__)  )/ ___ ||___ || ____|| |_| || |   | |_ 
'   \______) \___/  \____||_____) \____|  |____/  \__  |  |______/ \_____|(___/ |_____)|____/  \_)   \__)
'                                                (____/                                                  

'Some Information stuff..
'Using CrossThreadCalls instead of invoke with delegate ^ yes this source is shit > first project in visual basic don't judge me thx.
'This Source is unoptimized, confusing full of ~Try Catch~ I know you can code that better.. well if you can do, what are you looking for here, program your own bot stop making fun of it ;)

'Copyright(c) 2020 Baseult - https://baseult.com - Discord: https://baseult.com/twitchbot/redirect.php

Public Class Information
    Public Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://void.to/u/Baseult")
    End Sub

    Public Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://baseult.com/")
    End Sub

    Public Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://github.com/baseult")
    End Sub

    Public Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("https://www.unknowncheats.me/forum/members/3154276.html")
    End Sub

    Public Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class