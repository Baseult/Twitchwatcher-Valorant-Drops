
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

'Copyright(c) 2020 Baseult - https://baseult.com - Discord: https://baseult.com/twitchwatcher



Imports System.IO
Imports System.Net
Imports System.Threading
Imports Microsoft.VisualBasic
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Firefox

Public Class Power

    Public Waitms As String
    Public Waits As String
    Public Waitscount As Integer
    Public Waitmilis As String
    Public html_source As String
    Public Waitforcheck As Boolean
    Public Diffstream As Boolean = True
    Public Streamchathide As Boolean = False
    Public Streamquality As Boolean = False
    Public hiddenchrome As Boolean = False
    Public Crossthread As Boolean = True
    Public Streamwatch As Boolean = True
    Public subsonly As Boolean = False
    Public Follow As Boolean = False
    Public Chat As Boolean = False
    Public driverchrome As ChromeDriver
    Public driverfox As FirefoxDriver
    Public Text1 As Boolean = True
    Public video As IWebElement
    Public chromehide As Boolean = False
    Public tokenlogin As Boolean = False
    Public customaudio As Boolean = False
    Public prioritymode As Boolean = False
    Public cookiesave As Boolean = False
    Public commandhide As Boolean = False
    Public waitminute As String
    Public Message1 As String
    Public Message2 As String
    Public Watchstreamer As Boolean
    Public Waittime As String
    Public Streamertext As String
    Public muteaudio As Boolean
    Public volume As String
    Public checkdrop As Boolean
    Public claimpoints As Boolean
    Public Passinput As Boolean
    Public Proxy As Boolean
    Public Proxyport As String
    Public tokentext As String
    Public Background As Boolean
    Public Userinput As String


    Private do1 As Thread
    Public chromeactive As Boolean

    Const THREAD_BASE_PRIORITY_IDLE = -15       'Dont need all of them but will leave them here for further coding
    Const THREAD_BASE_PRIORITY_LOWRT = 15
    Const THREAD_BASE_PRIORITY_MIN = -2
    Const THREAD_BASE_PRIORITY_MAX = 2
    Const THREAD_PRIORITY_LOWEST = THREAD_BASE_PRIORITY_MIN
    Const THREAD_PRIORITY_HIGHEST = THREAD_BASE_PRIORITY_MAX
    Const THREAD_PRIORITY_BELOW_NORMAL = (THREAD_PRIORITY_LOWEST + 1)
    Const THREAD_PRIORITY_ABOVE_NORMAL = (THREAD_PRIORITY_HIGHEST - 1)
    Const THREAD_PRIORITY_IDLE = THREAD_BASE_PRIORITY_IDLE
    Const THREAD_PRIORITY_NORMAL = 0
    Const THREAD_PRIORITY_TIME_CRITICAL = THREAD_BASE_PRIORITY_LOWRT
    Const HIGH_PRIORITY_CLASS = &H80
    Const IDLE_PRIORITY_CLASS = &H40
    Const NORMAL_PRIORITY_CLASS = &H20
    Const REALTIME_PRIORITY_CLASS = &H100
    Private Declare Function SetThreadPriority Lib "kernel32" (ByVal hThread As Long, ByVal nPriority As Long) As Long
    Private Declare Function SetPriorityClass Lib "kernel32" (ByVal hProcess As Long, ByVal dwPriorityClass As Long) As Long
    Private Declare Function GetThreadPriority Lib "kernel32" (ByVal hThread As Long) As Long
    Private Declare Function GetPriorityClass Lib "kernel32" (ByVal hProcess As Long) As Long
    Private Declare Function GetCurrentThread Lib "kernel32" () As Long
    Private Declare Function GetCurrentProcess Lib "kernel32" () As Long


    Public Shared Function SetPriority(ByVal plngPriority As Long) As Long
        SetPriority = SetThreadPriority(GetCurrentThread(), plngPriority)
    End Function

    Private Sub Mainstart(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False 'not using invoke delegate because im lazy 

        If File.Exists(Application.StartupPath & "\start-with-low-cpu.txt") = True Then
            MessageBox.Show("Started Application with lowest Priority." & vbLf & "If you want to start normal mode remove the start-with-low-cpu.txt file")
            Dim hThread As Long, hProcess As Long
            hThread = GetCurrentThread
            hProcess = GetCurrentProcess
            SetThreadPriority(hThread, THREAD_PRIORITY_LOWEST)
            SetPriorityClass(hProcess, IDLE_PRIORITY_CLASS)
        End If

        Me.Show()
        Nextbutton.Hide()

    End Sub

    Private Sub Mainshow(sender As Object, e As EventArgs) Handles Me.Shown
        BackgroundWorker6.RunWorkerAsync()
    End Sub

    Private Sub Instancestart(sender As Object, e As EventArgs) Handles Startbutton.Click

        If Chromebox.Checked = False And Firefoxbox.Checked = False Then
            MessageBox.Show("Oops something went wrong!" & vbLf & vbLf & "You forgot to choose the Browser." & vbLf & "Please choose between:" & vbLf & "GoogleChrome or Firefox")
            Return
        End If

        If Crossthread = False And Background = False Then
            MessageBox.Show("Oops something went wrong!" & vbLf & vbLf & "You forgot to choose the Multithread." & vbLf & "Please go to your Settings and choose between:" & vbLf & "Crossthreadcalls or Backgroundworker")
            Return
        End If

        Stopbutton.Show()
        Startbutton.Hide()
        Nextbutton.Show()

        If prioritymode = True Then
            If chromeactive = True Then
                Chatshow1("Started using Crossthread with low priority")
                do1 = New System.Threading.Thread(AddressOf Startbot) With {
           .Priority = ThreadPriority.Lowest
       }
                do1.Start()
            Else
                Chatshow1("Started using Crossthread with low priority")
                do1 = New System.Threading.Thread(AddressOf Startbot2) With {
           .Priority = ThreadPriority.Lowest
       }
                do1.Start()
            End If

        Else
            Try
                Chatshow1("Started using Backgroundworker")
                BackgroundWorker1.RunWorkerAsync() ' Start Backgroundworker 1 for responsive menu and more stable than crossthread without invoke delegate
            Catch
                MessageBox.Show("Something went wrong!" & vbLf & "Please use the ""NEXT"" Button for more Accounts.") 'Do not use more than 5 Backgroundworkers (high cpu)
            End Try
        End If

    End Sub

    Public Function Chatshow1(str As String)
        Dim timeStamp As DateTime = DateTime.Now
        Me.TextBox1.AppendText(Environment.NewLine & "[" & timeStamp & "]   -   " & str & "")
    End Function

    Private Sub Chromebox_CheckedChanged(sender As Object, e As EventArgs) Handles Chromebox.CheckedChanged
        If Chromebox.Checked = True Then
            chromeactive = True
            Firefoxbox.Hide()
            Firefoxbox.Enabled = False
        Else
            chromeactive = False
            Firefoxbox.Show()
            Firefoxbox.Enabled = True
        End If
    End Sub

    Private Sub Firefoxbox_CheckedChanged(sender As Object, e As EventArgs) Handles Firefoxbox.CheckedChanged
        If Firefoxbox.Checked = True Then
            chromeactive = False
            Chromebox.Hide()
            chromebox.Enabled = False
            MessageBox.Show("WORK IN PROGRESS!" & vbLf & "Issues may occur!")
        Else
            chromeactive = True
            Chromebox.Show()
            chromebox.Enabled = True
        End If
    End Sub

    Private Sub Newinstance(sender As Object, e As EventArgs) Handles Nextbutton.Click

        If Chromebox.Checked = False And Firefoxbox.Checked = False Then
            MessageBox.Show("Oops something went wrong!" & vbLf & vbLf & "You forgot to choose the Browser." & vbLf & "Please choose between:" & vbLf & "GoogleChrome or Firefox")
            Return
        End If

        If Crossthread = False And Background = False Then
            MessageBox.Show("Oops something went wrong!" & vbLf & vbLf & "You forgot to choose the Multithread." & vbLf & "Please go to your Settings and choose between:" & vbLf & "Crossthreadcalls or Backgroundworker")
            Return
        End If

        If cookiesave = True Then
            MessageBox.Show("Oops something went wrong!" & vbLf & vbLf & "You forgot to disable 'Save Session'" & vbLf & "It only works for one Account" & vbLf & "Disable it in your Settings")
            Return
        End If

        If Not Crossthread = True Then

            'If Crossthread enabled start new Task in crossthread
            If prioritymode = True Then
                If chromeactive = True Then
                    Chatshow1("Started using Crossthread with low priority")
                    do1 = New System.Threading.Thread(AddressOf Startbot) With {
           .Priority = ThreadPriority.Lowest
       }
                    do1.Start()
                Else
                    Chatshow1("Started using Crossthread with low priority")
                    do1 = New System.Threading.Thread(AddressOf Startbot2) With {
           .Priority = ThreadPriority.Lowest
       }
                    do1.Start()
                End If
            End If
        Else                                            'Else start Backgroundworker
            Try
                BackgroundWorker2.RunWorkerAsync() 'If Backgroundworker already runs start Backgroundworker3..
                Chatshow1("Backgroundworker 2 Started")
            Catch
                Try
                    BackgroundWorker3.RunWorkerAsync() 'for responsive menu
                    Chatshow1("Backgroundworker 3 Started")
                Catch
                    Try
                        BackgroundWorker4.RunWorkerAsync() 'for responsive menu
                        Chatshow1("Backgroundworker 4 Started")
                    Catch
                        Try
                            BackgroundWorker5.RunWorkerAsync() 'for responsive menu
                            Chatshow1("Backgroundworker 5 Started")
                        Catch
                            MessageBox.Show("Can not run more than 4 Backgroundworkers!" & vbCrLf & "Please use the Crossthreadcalls method for more")
                        End Try
                    End Try
                End Try
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Twitchwatcher.Close()
    End Sub

    Private Sub Stopbutton_Click(sender As Object, e As EventArgs) Handles Stopbutton.Click
        Try
            Dim x() As Process
            x = Process.GetProcesses
            For Each p As Process In x
                If p.MainWindowTitle.Contains("chrome") Or p.MainWindowTitle.Contains("chromedriver") Or p.MainWindowTitle.Contains("Chrome") Or p.MainWindowTitle.Contains("gecko") Or p.MainWindowTitle.Contains("firefox") Or p.MainWindowTitle.Contains("Firefox") Then
                    Try
                        p.Kill()
                    Catch
                        Chatshow1("Could not Stop Process")
                    End Try
                End If
            Next

            Try
                BackgroundWorker1.CancelAsync()
            Catch
                Try
                    BackgroundWorker2.CancelAsync()
                Catch
                    Try
                        BackgroundWorker3.CancelAsync()
                    Catch
                        Try
                            BackgroundWorker4.CancelAsync()
                        Catch
                            Try
                                BackgroundWorker5.CancelAsync()
                            Catch
                            End Try
                        End Try
                    End Try
                End Try
            End Try

            Startbutton.Show()
            Stopbutton.Hide()
            Chatshow1("Stopped Bot")
        Catch
        End Try
    End Sub

    Private Sub BackgroundWorker6_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker6.DoWork
        Chatshow1("Searching for new updates")
        Try
            Using vs As New WebClient

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls And SecurityProtocolType.Tls11 And SecurityProtocolType.Tls12 And SecurityProtocolType.Ssl3 'using outdated securityprotocolsfor https even it is http - even more dumb 
                Dim ProgramVersion As String = vs.DownloadString(New Uri("http://baseult.com/twitchbot/version.txt"))
                Dim LocalVersion As String = "1.1.0"

                If ProgramVersion = LocalVersion Then
                    Chatshow1("Running latest Version: " & LocalVersion)
                Else
                    Chatshow1("New update found. Your version is: " & LocalVersion & " - New version is: " & ProgramVersion)
                    MessageBox.Show("New update found!." & vbLf & vbLf & "Download the new Version on my Discord or Github!")
                    Dim address As String = "http://baseult.com/twitchbot/Message.txt"
                    Dim client As WebClient = New WebClient()
                    Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
                    Chatshow1(reader.ReadToEnd)
                    Process.Start("https://baseult.com/twitchbot/redirect.php")

                End If
            End Using
        Catch
            Try
                Chatshow1("Could not find a new Version")
                BackgroundWorker1.CancelAsync()
            Catch
            End Try
        End Try
        Try
            BackgroundWorker1.CancelAsync()
        Catch
        End Try

    End Sub

    Public Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If chromeactive = True Then
            Startbot()
        Else
            Startbot2()
        End If
    End Sub

    Public Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If chromeactive = True Then
            Startbot()
        Else
            Startbot2()
        End If
    End Sub

    Public Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        If chromeactive = True Then
            Startbot()
        Else
            Startbot2()
        End If
    End Sub

    Public Sub BackgroundWorker4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        If chromeactive = True Then
            Startbot()
        Else
            Startbot2()
        End If
    End Sub

    Public Sub BackgroundWorker5_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker5.DoWork
        If chromeactive = True Then
            Startbot()
        Else
            Startbot2()
        End If
    End Sub

    Public Sub Wait(ByVal interval As Integer)
        Dim stopW As New Stopwatch
        stopW.Start()
        Do While stopW.ElapsedMilliseconds < interval
            ' Allows your UI to remain responsive
            Application.DoEvents()
        Loop
        stopW.Stop()
    End Sub

    Public Sub Startbot()
Restart:

        Dim Token As String

        Token = tokentext
        '################################################################################ Browser Options ################################################################################


        Dim options As ChromeOptions = New ChromeOptions
        Dim driverService = ChromeDriverService.CreateDefaultService()

        If chromeactive = True Then
            options.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.113 Safari/537.36")
        End If

        Dim optionsx As FirefoxOptions = New FirefoxOptions
        Dim driverServicex = FirefoxDriverService.CreateDefaultService


        'WORK IN PROGRESS! Firefox -
        '
        'Else
        '    Try
        '        Dim optionsx As FirefoxOptions = New FirefoxOptions
        '        Dim driverServicex = FirefoxDriverService.CreateDefaultService()
        '        optionsx = optionsx
        '        DriverService = driverServicex
        '    Catch
        '        MessageBox.Show("Your Firefoxversion is outdated. Please update your Google Chrome!")
        '    End Try



        If chromehide = True Then
            options.AddArgument("headless")
            hiddenchrome = True
        Else
            hiddenchrome = False
            If cookiesave = True Then
                options.AddArguments("user-data-dir=/profile")     'Will only save cookies in nonheadless mode otherwise it crashes
            End If
        End If

        If Proxy = True Then
            options.AddArguments("--proxy-server=" & Proxyport)
        End If

        If muteaudio = True Then
            options.AddArgument("--mute-audio")
        End If

        If commandhide = True Then
            driverService.HideCommandPromptWindow = True
        End If

        If tokenlogin = True Then
            Chatshow1("Starting Browser for: " & tokentext)
        Else
            Chatshow1("Starting Browser for: " & Userinput)
        End If



        '################################################################################ Start Browser ################################################################################


        Dim driver As ChromeDriver = New ChromeDriver(driverService, options)
        driverchrome = driver

        driver.Navigate().GoToUrl("https://twitch.tv/login")


        Chatshow1("Navigate to Twitch Login")


        Dim d As Double

        If Double.TryParse(Waittime, d) Then
            Dim Waitmilliseconds = TimeSpan.FromMinutes(d).TotalMilliseconds.ToString("N0")
            Dim Waitseconds = TimeSpan.FromMinutes(d).TotalSeconds.ToString("N0")
            Waits = Waitseconds
            Waitscount = Waitseconds
            Waitms = Waitmilliseconds
        End If

        If Double.TryParse(waitminute, d) Then
            Dim Waitmilliseconds = TimeSpan.FromMinutes(d).TotalMilliseconds.ToString("N0")
            Waitmilis = Waitmilliseconds
        End If

        Timer2.Interval = Waitmilis

        Wait(10000)

        '################################################################################ Change Language1 ################################################################################

        Try
            Chatshow1("Changing language to english - please wait")      'Changing language to detect English Twitch Login title
            Dim Cookie3 = New OpenQA.Selenium.Cookie("language", "en", ".twitch.tv", "/", "2022-10-16T17:36:40.000Z")
            Wait(2000)
            driver.Manage.Cookies.AddCookie(Cookie3)
            Wait(2000)
            driver.Navigate.Refresh()
            Chatshow1("Changed language")
        Catch
            Chatshow1("Something went wrong trying to change language to English")
        End Try

        Wait(10000)

        Dim title1 As String = driver.Title

        '################################################################################ Login Progress ################################################################################

        If title1 = "Anmelden - Twitch" Or title1 = "Log In - Twitch" Then
            Chatshow1("Login Start")

            If tokenlogin = True Then
                Dim Cookie2 = New OpenQA.Selenium.Cookie("auth-token", Token, ".twitch.tv", "/", "2022-10-16T17:36:40.000Z") 'Cookie for auth-token login
                Chatshow1("Put in Cookies - Token")
                Wait(2000)

                driver.Manage.Cookies.AddCookie(Cookie2)
                Chatshow1("Manage Cookie")
                Wait(2000)

                driver.Navigate.Refresh()
                Chatshow1("Refresh")
                Wait(10000)
            Else

                Try
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[3]/div/div/div/div[3]/form/div/div[1]/div/div[2]/input")).SendKeys(Userinput)
                    Chatshow1("Put in Username: " & Userinput)
                Catch
                    Chatshow1("Something went wrong with the Username Input")
                End Try
                Wait(2000)
                Try
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[3]/div/div/div/div[3]/form/div/div[2]/div/div[1]/div[2]/div[1]/input")).SendKeys(Passinput)
                    Chatshow1("Put in Password: ********")
                Catch
                    Chatshow1("Something went wrong with the Password Input")
                End Try
                Wait(2000)
                Try
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[3]/div/div/div/div[3]/form/div/div[3]/button")).Click()
                    Chatshow1("Pressing Login Button")
                Catch
                    Try
                        driver.FindElement(By.XPath("//*[text()='Log In']"))
                    Catch
                        Chatshow1("Something went wrong with pressing the Login Button")
                    End Try
                End Try
            End If
        Else
            Waitforcheck = True  'Otherwise if session stored login may not needed
        End If

Recheck:

        Wait(10000)

        Dim title As String = driver.Title
        Try
            If title = "Anmelden - Twitch" Or title = "Log In - Twitch" Then
                Chatshow1("Waiting for authentication - Please insert the Authcode or verify the captcha!")
                Waitforcheck = False
                If hiddenchrome = True Then
                    MessageBox.Show("Manual human verification is needed!" & "Please restart Chrome in visible mode.")
                    driver.Quit()
                End If
                GoTo Recheck

            Else
                Chatshow1("Logged in!")
                Nextbutton.Enabled = True
            End If
        Catch
            Chatshow1("Something went wrong while checking the Chrome Title")
        End Try

        '################################################################################ Change Language2 ################################################################################

        Try
            Chatshow1("Changing language to english - please wait")
            Dim Cookie3 = New OpenQA.Selenium.Cookie("language", "en", ".twitch.tv", "/", "2022-10-16T17:36:40.000Z")
            Wait(2000)
            driver.Manage.Cookies.AddCookie(Cookie3)
            Wait(2000)
            driver.Navigate.Refresh()
            Chatshow1("Changed language")
        Catch
            Chatshow1("Something went wrong trying to change language to English")
        End Try


watching:

        '################################################################################ Check for Drop ################################################################################

        subsonly = False 'resets subsonly chat detection

        Wait(10000)

        If checkdrop = True Then
            Chatshow1("Navigate to Twitch Inventory")
            driver.Navigate().GoToUrl("https://www.twitch.tv/inventory")

            Wait(10000)

            Chatshow1("Searching for Valorant Drop")
            html_source = driver.PageSource

            Wait(5000)

            If html_source.Contains("<p class=""tw-font-size-5 tw-semibold"" data-test-selector=""drops-list__drop-name"">VALORANT</p>") Then
                Dropfound.Text = "True"
                Wait(2000)
                Chatshow1("Valorant Drop found. Congratulations!")
                Wait(2000)
                MessageBox.Show("Valorant Drop found. Congratulations!" & vbLf & vbLf & "If you liked the Tool I would be very happy about a review or rating on UC.")
                Process.Start("https://www.unknowncheats.me/forum/valorant/387918-valorant-twitchwatcher-windows-net.html")
            Else
                Chatshow1("No Valorant Drop yet. Continue!")
                Dropfound.Text = "False"
            End If

            Wait(2000)
        End If


        '################################################################################ Search Streams ################################################################################

        Chatshow1("Searching for Drop Active Streamers")
        If Diffstream = True Then
            driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?sort=VIEWER_COUNT_ASC&tl=c2542d6d-cd10-4532-919b-3d19f30a768b")
        Else
            driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?tl=c2542d6d-cd10-4532-919b-3d19f30a768b")
        End If

        Wait(10000)

        Dim Streamername As String

        Try
            driver.FindElement(By.CssSelector("button[data-a-target='consent-banner-accept']")).Click()
            Chatshow1("Accepted Cookies")
        Catch
            Try
                driver.FindElement(By.XPath("//*[@data-a-target='consent-banner-accept']")).Click()
                Chatshow1("Accepted Cookies")
            Catch

            End Try
        End Try

        Wait(2000)

        If Watchstreamer = True Then
            Chatshow1("Searching for Streamer: " & Streamertext)
            Try
                driver.FindElement(By.XPath("//*[text()='" & Streamertext & "']")).Click()
                Chatshow1("Found Streamer " & Streamertext)
                Wait(10000)
                Try
                    driver.FindElement(By.CssSelector("a[data-a-target='home-channel-header-item']")).Click()
                Catch
                    Try
                        driver.FindElement(By.XPath("//div[text()='Home']")).Click()
                    Catch
                        Try
                            driver.Navigate().GoToUrl("https://www.twitch.tv/" & Streamertext)
                        Catch
                            Chatshow1("Something went wrong trying to find Home Button")
                        End Try
                    End Try
                End Try
                Wait(10000)
                Chatshow1("Watching Streamer: " & Streamertext)
                Timertext.Text = Waitscount
                Timertext.Visible = True
                Timertext.Enabled = True
                Timer1.Enabled = True
                Remainingtime.Visible = True
                Streamwatch = False  'Custom Streamer Found then False
            Catch
                Chatshow1("Could not find Streamer: " & Streamertext)
                Chatshow1("Searching other Streamers")
                If Diffstream = True Then
                    driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?sort=VIEWER_COUNT_ASC&tl=c2542d6d-cd10-4532-919b-3d19f30a768b")
                Else
                    driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?tl=c2542d6d-cd10-4532-919b-3d19f30a768b")
                End If
                Wait(10000)
                Streamwatch = True 'No custom streamer Found then True
            End Try
        End If

SearchChannel:

        Wait(2000)

        If Streamwatch = True Then  'If no custom streamer found then do this...
            Try
                Dim Streamer = driver.FindElement(By.CssSelector("a[data-a-target='preview-card-channel-link']"))
                Streamername = Streamer.Text
                Streamer.Click()
            Catch
                Chatshow1("Something went wrong while searching for Streams")
                GoTo SearchChannel
            End Try

            Timertext.Text = Waitscount
            Timertext.Enabled = True
            Timertext.Visible = True
            Timer1.Enabled = True
            Remainingtime.Visible = True

            Chatshow1("Found a Streamer. Watching for: " & Waits & " Seconds. Watching Stream: " & Streamername)

            Wait(10000)

            Try
                driver.FindElement(By.CssSelector("a[data-a-target='home-channel-header-item']")).Click()
            Catch
                Chatshow1("Something went wrong while Searching for Home Button")
                driver.Navigate().GoToUrl("https://www.twitch.tv/" & Streamername)
            End Try
        End If

        '################################################################################ Detect Maturecontent Warning ################################################################################

        Chatshow1("checking for mature content popup - please wait")

        Wait(10000)

        Try
            driver.FindElement(By.XPath("//*[@id=""root""]/div/div[2]/div/main/div[2]/div[3]/div/div/div[2]/div[2]/div[2]/div/div/div/div[9]/div/div[3]/button")).Click()
            Chatshow1("Mature content warning detected- pressing okay")
        Catch
            Try
                driver.FindElement(By.XPath("//*[@data-a-target='player-overlay-mature-accept']")).Click()
                Chatshow1("Mature content warning detected- pressing okay")
            Catch ex As Exception
            End Try
        End Try

Ignoreit:

        Wait(2000)

        '################################################################################ Custom Audio ################################################################################

        If customaudio = True Then
            Try
                video = driver.FindElement(By.CssSelector("video"))

                Chatshow1("Changed custom volume")
                Wait(2000)
            Catch
                Chatshow1("Failed to change custom volume")
            End Try
        End If

        '################################################################################ Streamquality ################################################################################

        If Streamquality = True Then
            Dim body As IWebElement
            Try
                body = driver.FindElement(By.CssSelector("button[data-a-target='player-play-pause-button']"))   'Pause the video else it cant change settings why so ever
                body.SendKeys(Keys.Space)
            Catch
                Chatshow1("Something went wrong searching the pause button")
                GoTo Ignorenext
            End Try

            Wait(2000)

            Try
                driver.FindElement(By.XPath("//*[@data-a-target='player-settings-button']")).Click()
            Catch
                Chatshow1("Something went wrong trying to search Settings Button")
                GoTo Ignorenext
            End Try

            Wait(2000)


            Try
                driver.FindElement(By.CssSelector("button[data-a-target='player-settings-menu-item-quality']")).Click()
            Catch
                Chatshow1("Something went wrong trying to find Quality Button")
                GoTo Ignorenext
            End Try

            Wait(2000)

            Try
                driver.FindElement(By.XPath("//*[text()='160p']")).Click()
                Chatshow1("Changed Streamquality to low")
                Wait(1000)
            Catch
                Try
                    driver.FindElement(By.XPath("//*[text()='360p']")).Click()
                    Chatshow1("Changed Streamquality to low")
                    Wait(1000)
                Catch
                    Try
                        driver.FindElement(By.XPath("//*[text()='480p']")).Click()
                        Chatshow1("Changed Streamquality to low")
                        Wait(1000)
                    Catch
                        Try
                            driver.FindElement(By.XPath("//*[text()='720p']")).Click()
                            Chatshow1("Changed Streamquality to low")
                            Wait(1000)
                        Catch
                            Try
                                Chatshow1("Could not change Streamquality")
                                Refresh()
                                Wait(10000)
                            Catch
                                GoTo watching
                            End Try
                        End Try

                    End Try

                End Try
            End Try


            Wait(3000)

            Try
                body = driver.FindElement(By.CssSelector("button[data-a-target='player-play-pause-button']"))
                body.SendKeys(Keys.Space)
            Catch
                driver.Navigate.Refresh()
                Wait(10000)
                GoTo Ignorenext
            End Try
        End If

Ignorenext:

        Wait(2000)

        '################################################################################ Hide Streamchat ################################################################################

        If Streamchathide = True Then
            Try
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[5]/div[3]/div[2]/div[2]/div[2]/div/div/div[1]/button")).Click()
                Wait(2000)
            Catch
                Try
                    driver.FindElement(By.XPath("//*[@data-a-target='chat-settings']")).Click()
                    Wait(2000)
                Catch
                    Chatshow1("Something went wrong trying To find Chat Settings")
                    GoTo Ignoremore
                End Try
            End Try

            Wait(2000)

            Try
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div[2]/section/div/div[5]/div[3]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[3]/div/div/div/div[3]/div[5]/button")).Click()
                Wait(1000)
            Catch
                Try
                    driver.FindElement(By.XPath("//*[contains(text(), 'Hide Chat')]")).Click()
                    Wait(1000)
                Catch
                    Chatshow1("Something went wrong trying to find hide Chat Button")
                    GoTo Ignoremore
                End Try
            End Try

            Try
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[2]")).Click()
                Chatshow1("Closed Streamchat")
                Wait(1000)
            Catch
                Chatshow1("Something went wrong while trying to close Streamchat")
            End Try
        End If

Ignoremore:

        '################################################################################ Follow Streamer ################################################################################

        If Follow = True Then
            Try
                driver.FindElement(By.XPath("//*[@id=""root""]/div/div[2]/div/main/div[1]/div/div[2]/div/div[1]/div[3]/div[1]/div/div/div[1]")).Click()
                Chatshow1("Followed the Streamer: " & Streamername & " to be able to write in Chat")
            Catch
                Chatshow1("Something went wrong while trying to follow a Streamer")
            End Try
        End If

        '################################################################################ Start Writechat Timer ################################################################################

        If Chat = True Then
            Timer2.Enabled = True
        End If

        If claimpoints = True Then
            Timer5.Enabled = True
        End If

        Wait(Waitms)

        Timer2.Enabled = False
        Timer5.Enabled = False

        Wait(2000)

        GoTo watching

    End Sub

    Public Sub Startbot2()

Restart:
        Dim Token As String

        Token = tokentext
        '################################################################################ Browser Options ################################################################################


        Dim options As FirefoxOptions = New FirefoxOptions
        Dim driverService = FirefoxDriverService.CreateDefaultService


        'WORK IN PROGRESS! Firefox -
        '
        'Else
        '    Try
        '        Dim optionsx As FirefoxOptions = New FirefoxOptions
        '        Dim driverServicex = FirefoxDriverService.CreateDefaultService()
        '        optionsx = optionsx
        '        DriverService = driverServicex
        '    Catch
        '        MessageBox.Show("Your Firefoxversion is outdated. Please update your Google Chrome!")
        '    End Try



        If chromehide = True Then
            options.AddArgument("headless")
            hiddenchrome = True
        Else
            hiddenchrome = False
            If cookiesave = True Then
                options.AddArguments("user-data-dir=/profile")     'Will only save cookies in nonheadless mode otherwise it crashes
            End If
        End If

        If Proxy = True Then
            options.AddArguments("--proxy-server=" & Settings.proxyinput.Text)
        End If

        If muteaudio = True Then
            options.AddArgument("--mute-audio")
        End If

        If commandhide = True Then
            driverService.HideCommandPromptWindow = True
        End If

        If tokenlogin = True Then
            Chatshow1("Starting Browser for: " & Settings.tokeninput.Text)
        Else
            Chatshow1("Starting Browser for: " & Settings.Namebox.Text)
        End If



        '################################################################################ Start Browser ################################################################################


        Dim driver As FirefoxDriver = New FirefoxDriver(driverService, options)
        driverfox = driver

        driver.Navigate().GoToUrl("https://twitch.tv/login")

        Chatshow1("Navigate to Twitch Login")


        Dim d As Double

        If Double.TryParse(Waittime, d) Then
            Dim Waitmilliseconds = TimeSpan.FromMinutes(d).TotalMilliseconds.ToString("N0")
            Dim Waitseconds = TimeSpan.FromMinutes(d).TotalSeconds.ToString("N0")
            Waits = Waitseconds
            Waitscount = Waitseconds
            Waitms = Waitmilliseconds
        End If

        If Double.TryParse(waitminute, d) Then
            Dim Waitmilliseconds = TimeSpan.FromMinutes(d).TotalMilliseconds.ToString("N0")
            Waitmilis = Waitmilliseconds
        End If

        Timer2.Interval = Waitmilis
        Wait(10000)

        '################################################################################ Change Language1 ################################################################################

        Try
            Chatshow1("Changing language to english - please wait")      'Changing language to detect English Twitch Login title
            Dim Cookie3 = New OpenQA.Selenium.Cookie("language", "en", ".twitch.tv", "/", "2022-10-16T17:36:40.000Z")
            Wait(2000)
            driver.Manage.Cookies.AddCookie(Cookie3)
            Wait(2000)
            driver.Navigate.Refresh()
            Chatshow1("Changed language")
        Catch
            Chatshow1("Something went wrong trying to change language to English")
        End Try

        Wait(10000)

        Dim title1 As String = driver.Title

        '################################################################################ Login Progress ################################################################################

        If title1 = "Anmelden - Twitch" Or title1 = "Log In - Twitch" Then
            Chatshow1("Login Start")

            If tokenlogin = True Then
                Dim Cookie2 = New OpenQA.Selenium.Cookie("auth-token", Token, ".twitch.tv", "/", "2022-10-16T17:36:40.000Z") 'Cookie for auth-token login
                Chatshow1("Put in Cookies - Token")
                Wait(2000)

                driver.Manage.Cookies.AddCookie(Cookie2)
                Chatshow1("Manage Cookie")
                Wait(2000)

                driver.Navigate.Refresh()
                Chatshow1("Refresh")
                Wait(10000)
            Else

                Try
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[3]/div/div/div/div[3]/form/div/div[1]/div/div[2]/input")).SendKeys(Userinput)
                    Chatshow1("Put in Username: " & Userinput)
                Catch
                    Chatshow1("Something went wrong with the Username Input")
                End Try
                Wait(2000)
                Try
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[3]/div/div/div/div[3]/form/div/div[2]/div/div[1]/div[2]/div[1]/input")).SendKeys(Passinput)
                    Chatshow1("Put in Password: ********")
                Catch
                    Chatshow1("Something went wrong with the Password Input")
                End Try
                Wait(2000)
                Try
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[3]/div/div/div/div[3]/form/div/div[3]/button")).Click()
                    Chatshow1("Pressing Login Button")
                Catch
                    Try
                        driver.FindElement(By.XPath("//*[text()='Log In']"))
                    Catch
                        Chatshow1("Something went wrong with pressing the Login Button")
                    End Try
                End Try
            End If
        Else
            Waitforcheck = True  'Otherwise if session stored login may not needed
        End If

Recheck:

        Wait(10000)

        Dim title As String = driver.Title
        Try
            If title = "Anmelden - Twitch" Or title = "Log In - Twitch" Then
                Chatshow1("Waiting for authentication - Please insert the Authcode or verify the captcha!")
                Waitforcheck = False
                If hiddenchrome = True Then
                    MessageBox.Show("Manual human verification is needed!" & "Please restart Chrome in visible mode.")
                    driver.Quit()
                End If
                GoTo Recheck

            Else
                Chatshow1("Logged in!")
                Nextbutton.Enabled = True
            End If
        Catch
            Chatshow1("Something went wrong while checking the Chrome Title")
        End Try

        '################################################################################ Change Language2 ################################################################################

        Try
            Chatshow1("Changing language to english - please wait")
            Dim Cookie3 = New OpenQA.Selenium.Cookie("language", "en", ".twitch.tv", "/", "2022-10-16T17:36:40.000Z")
            Wait(2000)
            driver.Manage.Cookies.AddCookie(Cookie3)
            Wait(2000)
            driver.Navigate.Refresh()
            Chatshow1("Changed language")
        Catch
            Chatshow1("Something went wrong trying to change language to English")
        End Try


watching:

        '################################################################################ Check for Drop ################################################################################

        subsonly = False 'resets subsonly chat detection

        Wait(10000)

        If checkdrop = True Then
            Chatshow1("Navigate to Twitch Inventory")
            driver.Navigate().GoToUrl("https://www.twitch.tv/inventory")

            Wait(10000)

            Chatshow1("Searching for Valorant Drop")
            html_source = driver.PageSource

            Wait(5000)

            If html_source.Contains("<p class=""tw-font-size-5 tw-semibold"" data-test-selector=""drops-list__drop-name"">VALORANT</p>") Then
                Dropfound.Text = "True"
                Wait(2000)
                Chatshow1("Valorant Drop found. Congratulations!")
                Wait(2000)
                MessageBox.Show("Valorant Drop found. Congratulations!" & vbLf & vbLf & "If you liked the Tool I would be very happy about a review or rating on UC.")
                Process.Start("https://www.unknowncheats.me/forum/valorant/387918-valorant-twitchwatcher-windows-net.html")
            Else
                Chatshow1("No Valorant Drop yet. Continue!")
                Dropfound.Text = "False"
            End If

            Wait(2000)
        End If


        '################################################################################ Search Streams ################################################################################

        Chatshow1("Searching for Drop Active Streamers")
        If Diffstream = True Then
            driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?sort=VIEWER_COUNT_ASC&tl=c2542d6d-cd10-4532-919b-3d19f30a768b")
        Else
            driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?tl=c2542d6d-cd10-4532-919b-3d19f30a768b")
        End If

        Wait(10000)

        Dim Streamername As String

        Try
            driver.FindElement(By.CssSelector("button[data-a-target='consent-banner-accept']")).Click()
            Chatshow1("Accepted Cookies")
        Catch
            Try
                driver.FindElement(By.XPath("//*[@data-a-target='consent-banner-accept']")).Click()
                Chatshow1("Accepted Cookies")
            Catch

            End Try
        End Try

        Wait(2000)

        If Watchstreamer = True Then
            Chatshow1("Searching for Streamer: " & Streamertext)
            Try
                driver.FindElement(By.XPath("//*[text()='" & Streamertext & "']")).Click()
                Chatshow1("Found Streamer " & Streamertext)
                Wait(10000)
                Try
                    driver.FindElement(By.CssSelector("a[data-a-target='home-channel-header-item']")).Click()
                Catch
                    Try
                        driver.FindElement(By.XPath("//div[text()='Home']")).Click()
                    Catch
                        Try
                            driver.Navigate().GoToUrl("https://www.twitch.tv/" & Streamertext)
                        Catch
                            Chatshow1("Something went wrong trying to find Home Button")
                        End Try
                    End Try
                End Try
                Wait(10000)
                Chatshow1("Watching Streamer: " & Streamertext)
                Timertext.Text = Waitscount
                Timertext.Visible = True
                Timertext.Enabled = True
                Timer1.Enabled = True
                Remainingtime.Visible = True
                Streamwatch = False  'Custom Streamer Found then False
            Catch
                Chatshow1("Could not find Streamer: " & Streamertext)
                Chatshow1("Searching other Streamers")
                If Diffstream = True Then
                    driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?sort=VIEWER_COUNT_ASC&tl=c2542d6d-cd10-4532-919b-3d19f30a768b")
                Else
                    driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?tl=c2542d6d-cd10-4532-919b-3d19f30a768b")
                End If
                Wait(10000)
                Streamwatch = True 'No custom streamer Found then True
            End Try
        End If

SearchChannel:

        Wait(2000)

        If Streamwatch = True Then  'If no custom streamer found then do this...
            Try
                Dim Streamer = driver.FindElement(By.CssSelector("a[data-a-target='preview-card-channel-link']"))
                Streamername = Streamer.Text
                Streamer.Click()
            Catch
                Chatshow1("Something went wrong while searching for Streams")
                GoTo SearchChannel
            End Try

            Timertext.Text = Waitscount
            Timertext.Enabled = True
            Timertext.Visible = True
            Timer1.Enabled = True
            Remainingtime.Visible = True

            Chatshow1("Found a Streamer. Watching for: " & Waits & " Seconds. Watching Stream: " & Streamername)

            Wait(10000)

            Try
                driver.FindElement(By.CssSelector("a[data-a-target='home-channel-header-item']")).Click()
            Catch
                Chatshow1("Something went wrong while Searching for Home Button")
                driver.Navigate().GoToUrl("https://www.twitch.tv/" & Streamername)
            End Try
        End If

        '################################################################################ Detect Maturecontent Warning ################################################################################

        Chatshow1("checking for mature content popup - please wait")

        Wait(10000)

        Try
            driver.FindElement(By.XPath("//*[@id=""root""]/div/div[2]/div/main/div[2]/div[3]/div/div/div[2]/div[2]/div[2]/div/div/div/div[9]/div/div[3]/button")).Click()
            Chatshow1("Mature content warning detected- pressing okay")
        Catch
            Try
                driver.FindElement(By.XPath("//*[@data-a-target='player-overlay-mature-accept']")).Click()
                Chatshow1("Mature content warning detected- pressing okay")
            Catch ex As Exception
            End Try
        End Try

Ignoreit:

        Wait(2000)

        '################################################################################ Custom Audio ################################################################################

        If customaudio = True Then
            Try
                video = driver.FindElement(By.CssSelector("video"))

                Chatshow1("Changed custom volume")
                Wait(2000)
            Catch
                Chatshow1("Failed to change custom volume")
            End Try
        End If

        '################################################################################ Streamquality ################################################################################

        If Streamquality = True Then
            Dim body As IWebElement
            Try
                body = driver.FindElement(By.CssSelector("button[data-a-target='player-play-pause-button']"))   'Pause the video else it cant change settings why so ever
                body.SendKeys(Keys.Space)
            Catch
                Chatshow1("Something went wrong searching the pause button")
                GoTo Ignorenext
            End Try

            Wait(2000)

            Try
                driver.FindElement(By.XPath("//*[@data-a-target='player-settings-button']")).Click()
            Catch
                Chatshow1("Something went wrong trying to search Settings Button")
                GoTo Ignorenext
            End Try

            Wait(2000)


            Try
                driver.FindElement(By.CssSelector("button[data-a-target='player-settings-menu-item-quality']")).Click()
            Catch
                Chatshow1("Something went wrong trying to find Quality Button")
                GoTo Ignorenext
            End Try

            Wait(2000)

            Try
                driver.FindElement(By.XPath("//*[text()='160p']")).Click()
                Chatshow1("Changed Streamquality to low")
                Wait(1000)
            Catch
                Try
                    driver.FindElement(By.XPath("//*[text()='360p']")).Click()
                    Chatshow1("Changed Streamquality to low")
                    Wait(1000)
                Catch
                    Try
                        driver.FindElement(By.XPath("//*[text()='480p']")).Click()
                        Chatshow1("Changed Streamquality to low")
                        Wait(1000)
                    Catch
                        Try
                            driver.FindElement(By.XPath("//*[text()='720p']")).Click()
                            Chatshow1("Changed Streamquality to low")
                            Wait(1000)
                        Catch
                            Try
                                Chatshow1("Could not change Streamquality")
                                Refresh()
                                Wait(10000)
                            Catch
                                GoTo watching
                            End Try
                        End Try

                    End Try

                End Try
            End Try


            Wait(3000)

            Try
                body = driver.FindElement(By.CssSelector("button[data-a-target='player-play-pause-button']"))
                body.SendKeys(Keys.Space)
            Catch
                driver.Navigate.Refresh()
                Wait(10000)
                GoTo Ignorenext
            End Try
        End If

Ignorenext:

        Wait(2000)

        '################################################################################ Hide Streamchat ################################################################################

        If Streamchathide = True Then
            Try
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[5]/div[3]/div[2]/div[2]/div[2]/div/div/div[1]/button")).Click()
                Wait(2000)
            Catch
                Try
                    driver.FindElement(By.XPath("//*[@data-a-target='chat-settings']")).Click()
                    Wait(2000)
                Catch
                    Chatshow1("Something went wrong trying To find Chat Settings")
                    GoTo Ignoremore
                End Try
            End Try

            Wait(2000)

            Try
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div[2]/section/div/div[5]/div[3]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[3]/div/div/div/div[3]/div[5]/button")).Click()
                Wait(1000)
            Catch
                Try
                    driver.FindElement(By.XPath("//*[contains(text(), 'Hide Chat')]")).Click()
                    Wait(1000)
                Catch
                    Chatshow1("Something went wrong trying to find hide Chat Button")
                    GoTo Ignoremore
                End Try
            End Try

            Try
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[2]")).Click()
                Chatshow1("Closed Streamchat")
                Wait(1000)
            Catch
                Chatshow1("Something went wrong while trying to close Streamchat")
            End Try
        End If

Ignoremore:

        '################################################################################ Follow Streamer ################################################################################

        If Follow = True Then
            Try
                driver.FindElement(By.XPath("//*[@id=""root""]/div/div[2]/div/main/div[1]/div/div[2]/div/div[1]/div[3]/div[1]/div/div/div[1]")).Click()
                Chatshow1("Followed the Streamer: " & Streamername & " to be able to write in Chat")
            Catch
                Chatshow1("Something went wrong while trying to follow a Streamer")
            End Try
        End If

        '################################################################################ Start Writechat Timer ################################################################################

        If Chat = True Then
            Timer2.Enabled = True
        End If

        If claimpoints = True Then
            Timer5.Enabled = True
        End If

        Wait(Waitms)

        Timer2.Enabled = False
        Timer5.Enabled = False

        Wait(2000)

        GoTo watching

    End Sub

    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If chromeactive = True Then
            html_source = driverchrome.PageSource

            If html_source.Contains("<p class=""tw-strong"">Subscribers-Only Chat</p>") Then
                Chatshow1("Streamchat is Subscribers Only - Won't write in Chat")
            Else

                If Text1 = True Then
                    Try
                        driverchrome.FindElement(By.ClassName("chat-input__textarea")).Click()
                        Chatshow1("Click Textarea")
                        Wait(2000)
                    Catch
                        Try
                            driverchrome.FindElement(By.XPath("//*[contains(@src,'Send a message')]"))
                            Chatshow1("Click Textarea")
                            Wait(2000)
                        Catch
                            Chatshow1("Something went wrong while trying to write in Chat")
                        End Try
                    End Try

                    Try
                        driverchrome.FindElement(By.CssSelector("chat-rules-ok-button")).Click()
                        Chatshow1("Click Okay")
                    Catch
                        Try
                            driverchrome.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div[1]/div/div/section/div/div[5]/div[1]/div/div[2]/div[2]/button")).Click()
                            Chatshow1("Click Okay")
                        Catch
                            Try
                                driverchrome.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[4]/div[1]/div/div[2]/div[2]/button")).Click()
                                Chatshow1("Click Okay")
                            Catch
                                Try
                                    driverchrome.FindElement(By.XPath("//p[text()='Okay, Got It!']")).Click()
                                    Chatshow1("Click Okay")
                                Catch
                                    Chatshow1("Something went wrong while trying to write in Chat")
                                End Try
                            End Try
                        End Try
                    End Try

                    Try
                        driverchrome.FindElement(By.ClassName("tw-textarea")).SendKeys(Message1)
                        Chatshow1("Write")
                        Wait(2000)
                        driverchrome.FindElement(By.ClassName("tw-textarea")).SendKeys(Keys.Enter)
                        Chatshow1("Writing in Chat")
                        Text1 = False
                    Catch
                        Try
                            driverchrome.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Message1)
                            Chatshow1("Write")
                            Wait(2000)
                            driverchrome.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Keys.Enter)
                            Chatshow1("Writing in Chat")
                            Text1 = False
                        Catch
                            Chatshow1("Something went wrong while trying to write in Chat")
                        End Try
                    End Try

                ElseIf Text1 = False Then

                    Try
                        driverchrome.FindElement(By.ClassName("chat-input__textarea")).Click()
                        Chatshow1("Click Textarea")
                        Wait(2000)
                    Catch
                        Try
                            driverchrome.FindElement(By.XPath("//*[contains(@src,'Send a message')]"))
                            Chatshow1("Click Textarea")
                            Wait(2000)
                        Catch
                            Chatshow1("Something went wrong while trying to write in Chat")
                        End Try
                    End Try

                    Try
                        driverchrome.FindElement(By.CssSelector("chat-rules-ok-button")).Click()
                        Chatshow1("Click Okay")
                    Catch
                        Try
                            driverchrome.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div[1]/div/div/section/div/div[5]/div[1]/div/div[2]/div[2]/button")).Click()
                            Chatshow1("Click Okay")
                        Catch
                            Try
                                driverchrome.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[4]/div[1]/div/div[2]/div[2]/button")).Click()
                                Chatshow1("Click Okay")
                            Catch
                                Try
                                    driverchrome.FindElement(By.XPath("//p[text()='Okay, Got It!']")).Click()
                                    Chatshow1("Click Okay")
                                Catch
                                    Chatshow1("Something went wrong while trying to write in Chat")
                                End Try
                            End Try
                        End Try
                    End Try

                    Try
                        driverchrome.FindElement(By.ClassName("tw-textarea")).SendKeys(Message2)
                        Chatshow1("Write")
                        Wait(2000)
                        driverchrome.FindElement(By.ClassName("tw-textarea")).SendKeys(Keys.Enter)
                        Chatshow1("Writing in Chat")
                        Text1 = False
                    Catch
                        Try
                            driverchrome.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Message2)
                            Chatshow1("Write")
                            Wait(2000)
                            driverchrome.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Keys.Enter)
                            Chatshow1("Writing in Chat")
                            Text1 = False
                        Catch
                            Chatshow1("Something went wrong while trying to write in Chat")
                        End Try
                    End Try
                End If
            End If
        Else
            html_source = driverfox.PageSource

            If html_source.Contains("<p class=""tw-strong"">Subscribers-Only Chat</p>") Then
                Chatshow1("Streamchat is Subscribers Only - Won't write in Chat")
            Else

                If Text1 = True Then
                    Try
                        driverfox.FindElement(By.ClassName("chat-input__textarea")).Click()
                        Chatshow1("Click Textarea")
                        Wait(2000)
                    Catch
                        Try
                            driverfox.FindElement(By.XPath("//*[contains(@src,'Send a message')]"))
                            Chatshow1("Click Textarea")
                            Wait(2000)
                        Catch
                            Chatshow1("Something went wrong while trying to write in Chat")
                        End Try
                    End Try

                    Try
                        driverfox.FindElement(By.CssSelector("chat-rules-ok-button")).Click()
                        Chatshow1("Click Okay")
                    Catch
                        Try
                            driverfox.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div[1]/div/div/section/div/div[5]/div[1]/div/div[2]/div[2]/button")).Click()
                            Chatshow1("Click Okay")
                        Catch
                            Try
                                driverfox.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[4]/div[1]/div/div[2]/div[2]/button")).Click()
                                Chatshow1("Click Okay")
                            Catch
                                Try
                                    driverfox.FindElement(By.XPath("//p[text()='Okay, Got It!']")).Click()
                                    Chatshow1("Click Okay")
                                Catch
                                    Chatshow1("Something went wrong while trying to write in Chat")
                                End Try
                            End Try
                        End Try
                    End Try

                    Try
                        driverfox.FindElement(By.ClassName("tw-textarea")).SendKeys(Message1)
                        Chatshow1("Write")
                        Wait(2000)
                        driverfox.FindElement(By.ClassName("tw-textarea")).SendKeys(Keys.Enter)
                        Chatshow1("Writing in Chat")
                        Text1 = False
                    Catch
                        Try
                            driverfox.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Message1)
                            Chatshow1("Write")
                            Wait(2000)
                            driverfox.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Keys.Enter)
                            Chatshow1("Writing in Chat")
                            Text1 = False
                        Catch
                            Chatshow1("Something went wrong while trying to write in Chat")
                        End Try
                    End Try

                ElseIf Text1 = False Then

                    Try
                        driverfox.FindElement(By.ClassName("chat-input__textarea")).Click()
                        Chatshow1("Click Textarea")
                        Wait(2000)
                    Catch
                        Try
                            driverfox.FindElement(By.XPath("//*[contains(@src,'Send a message')]"))
                            Chatshow1("Click Textarea")
                            Wait(2000)
                        Catch
                            Chatshow1("Something went wrong while trying to write in Chat")
                        End Try
                    End Try

                    Try
                        driverfox.FindElement(By.CssSelector("chat-rules-ok-button")).Click()
                        Chatshow1("Click Okay")
                    Catch
                        Try
                            driverfox.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div[1]/div/div/section/div/div[5]/div[1]/div/div[2]/div[2]/button")).Click()
                            Chatshow1("Click Okay")
                        Catch
                            Try
                                driverfox.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[4]/div[1]/div/div[2]/div[2]/button")).Click()
                                Chatshow1("Click Okay")
                            Catch
                                Try
                                    driverfox.FindElement(By.XPath("//p[text()='Okay, Got It!']")).Click()
                                    Chatshow1("Click Okay")
                                Catch
                                    Chatshow1("Something went wrong while trying to write in Chat")
                                End Try
                            End Try
                        End Try
                    End Try

                    Try
                        driverfox.FindElement(By.ClassName("tw-textarea")).SendKeys(Message2)
                        Chatshow1("Write")
                        Wait(2000)
                        driverfox.FindElement(By.ClassName("tw-textarea")).SendKeys(Keys.Enter)
                        Chatshow1("Writing in Chat")
                        Text1 = False
                    Catch
                        Try
                            driverfox.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Message2)
                            Chatshow1("Write")
                            Wait(2000)
                            driverfox.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Keys.Enter)
                            Chatshow1("Writing in Chat")
                            Text1 = False
                        Catch
                            Chatshow1("Something went wrong while trying to write in Chat")
                        End Try
                    End Try
                End If
            End If
        End If



    End Sub

    Public Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If chromeactive = True Then
            Try
                driverchrome.FindElement(By.XPath("//*[text()='Click to claim a bonus!']")).Click()
                Chatshow1("Claimed Channelpoints")
            Catch
                Try
                    driverchrome.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[5]/div[2]/div[2]/div[1]/div/div/div/div[2]/div/div/div/button")).Click()
                    Chatshow1("Claimed Channelpoints")
                Catch
                End Try

            End Try
        Else
            Try
                driverfox.FindElement(By.XPath("//*[text()='Click to claim a bonus!']")).Click()
                Chatshow1("Claimed Channelpoints")
            Catch
                Try
                    driverfox.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[5]/div[2]/div[2]/div[1]/div/div/div/div[2]/div/div/div/button")).Click()
                    Chatshow1("Claimed Channelpoints")
                Catch
                End Try

            End Try
        End If

    End Sub

    '################################################################################ Other Stuff ################################################################################

    Public Sub Auth_Click(sender As Object, e As EventArgs)
        Waitforcheck = True
        Chatshow1("Will continue please Wait!")
    End Sub

End Class
