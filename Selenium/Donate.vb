
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

Public Class Donate
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=GCYKQX5XWXHAY&source=url")
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://www.unknowncheats.me/forum/reputation.php?p=2757215")
    End Sub

    Public Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://baseult.com/")
    End Sub

    Private Sub Donate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class