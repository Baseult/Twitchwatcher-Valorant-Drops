
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

Public Class Form1
    Private do1 As Thread
    Private Waitms As String
    Private Waits As String
    Private Waitscount As Integer
    Private Waitmilis As String
    Private html_source As String
    Private Waitforcheck As Boolean
    Private Streamchathide As Boolean = False
    Private Streamquality As Boolean = False
    Private hiddenchrome As Boolean = False
    Private Crossthread As Boolean = True
    Private Streamwatch As Boolean = True
    Private subsonly As Boolean = False
    Private Follow As Boolean = False
    Private Chat As Boolean = False
    Private chromeactive As Boolean = False
    Public driverx
    Public driver
    Public options
    Public driverService

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


    End Sub

    Private Sub Mainshow(sender As Object, e As EventArgs) Handles Me.Shown
        Chatshow("Searching for new updates")
        Try
            Using vs As New WebClient

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls And SecurityProtocolType.Tls11 And SecurityProtocolType.Tls12 And SecurityProtocolType.Ssl3 'using outdated securityprotocolsfor https even it is http - even more dumb 
                Dim ProgramVersion As String = vs.DownloadString(New Uri("http://baseult.com/twitchbot/version.txt"))
                Dim LocalVersion As String = "1.0.6"

                If ProgramVersion = LocalVersion Then
                    Chatshow("Running latest Version: " & LocalVersion)
                Else
                    Chatshow("New update found. Your version is: " & LocalVersion & " - New version is: " & ProgramVersion)
                    MessageBox.Show("New update found. Visit the thread to download the new version")
                End If
            End Using
        Catch
            Chatshow("Could not find a new Version")
        End Try
    End Sub

    Private Sub Newinstance(sender As Object, e As EventArgs) Handles Button2.Click
        If Crossthread = True Then                      'If Crossthread enabled start new Task in crossthread
            If prioritymode.Checked = True Then
                Chatshow("Started using Crossthread with low priority")
                do1 = New System.Threading.Thread(AddressOf Startbot) With {
               .Priority = ThreadPriority.Lowest
           }
                do1.Start()
            Else
                Chatshow("Started using Crossthread with normal priority")
                do1 = New System.Threading.Thread(AddressOf Startbot) 'multithreading For more accounts
                do1.Start()
            End If
        Else                                            'Else start Backgroundworker
            Try
                BackgroundWorker2.RunWorkerAsync() 'If Backgroundworker already runs start Backgroundworker3..
                Chatshow("Backgroundworker 2 Started")
            Catch
                Try
                    BackgroundWorker3.RunWorkerAsync() 'for responsive menu
                    Chatshow("Backgroundworker 3 Started")
                Catch
                    Try
                        BackgroundWorker4.RunWorkerAsync() 'for responsive menu
                        Chatshow("Backgroundworker 4 Started")
                    Catch
                        Try
                            BackgroundWorker5.RunWorkerAsync() 'for responsive menu
                            Chatshow("Backgroundworker 5 Started")
                        Catch
                            MessageBox.Show("Can not run more than 4 Backgroundworkers!" & vbCrLf & "Please use the Crossthreadcalls method for more")
                        End Try
                    End Try
                End Try
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If prioritymode.Checked = True Then
            Chatshow("Started using Crossthread with low priority")
            do1 = New System.Threading.Thread(AddressOf Startbot) With {
           .Priority = ThreadPriority.Lowest
       }
            do1.Start()
        Else
            Try
                Chatshow("Started using Backgroundworker")
                BackgroundWorker1.RunWorkerAsync() ' Start Backgroundworker 1 for responsive menu and more stable than crossthread without invoke delegate
            Catch
                MessageBox.Show("If you want to bot multiple Accounts please use the ""Start another Account"" Button") 'Do not use more than 5 Backgroundworkers (high cpu)
            End Try
        End If
    End Sub

    Public Sub Startbot()

Restart:

        '################################################################################ Browser Options ################################################################################

        If chromeactive = True Then
            Try
                Dim optionsx As ChromeOptions = New ChromeOptions
                Dim driverServicex = ChromeDriverService.CreateDefaultService()
                options = optionsx
                driverService = driverServicex
                options.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.113 Safari/537.36")
            Catch
                MessageBox.Show("Your Chromeversion is outdated. Please update your Google Chrome!")
            End Try


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

        End If

        If chromehide.Checked = True Then
            options.AddArgument("headless")
            hiddenchrome = True
        Else
            hiddenchrome = False
            If cookiessave.Checked = True Then
                options.AddArguments("user-data-dir=/profile")     'Will only save cookies in nonheadless mode otherwise it crashes
            End If
        End If

        If proxycheckbox.Checked = True Then
            options.AddArguments("--proxy-server=" & proxyinput.Text)
        End If

        If muteaudio.Checked = True Then
            options.AddArgument("--mute-audio")
        End If

        If commandhide.Checked = True Then
            driverService.HideCommandPromptWindow = True
        End If

        If tokenlogin.Checked = True Then
            Chatshow("Starting Browser for: " & tokeninput.Text)
        Else
            Chatshow("Starting Browser for: " & Namebox.Text)
        End If

        '################################################################################ Start Browser ################################################################################


        If chromeactive = True Then
            Try
                Dim driverx As ChromeDriver = New ChromeDriver()
                driver = driverx
            Catch
                MessageBox.Show("Your Chromeversion is outdated. Please update your Google Chrome!")
            End Try
        Else
            Try
                Dim driverx As FirefoxDriver = New FirefoxDriver()
                driver = driverx
            Catch
                MessageBox.Show("Your Firefoxversion is outdated. Please update your Google Chrome!")
            End Try

        End If

        driver.Navigate().GoToUrl("https://twitch.tv/login")

        Chatshow("Navigate to Twitch Login")


        Dim d As Double

        If Double.TryParse(Waitbox.Text, d) Then
            Dim Waitmilliseconds = TimeSpan.FromMinutes(d).TotalMilliseconds.ToString("N0")
            Dim Waitseconds = TimeSpan.FromMinutes(d).TotalSeconds.ToString("N0")
            Waits = Waitseconds
            Waitscount = Waitseconds
            Waitms = Waitmilliseconds
        End If

        If Double.TryParse(Chatminute.Text, d) Then
            Dim Waitmilliseconds = TimeSpan.FromMinutes(d).TotalMilliseconds.ToString("N0")
            Waitmilis = Waitmilliseconds
        End If

        Timer2.Interval = Waitmilis
        Wait(10000)

        '################################################################################ Change Language1 ################################################################################

        Try
            Chatshow("Changing language to english - please wait")      'Changing language to detect English Twitch Login title
            Dim Cookie3 = New OpenQA.Selenium.Cookie("language", "en", ".twitch.tv", "/", "2022-10-16T17:36:40.000Z")
            Wait(2000)
            driver.Manage.Cookies.AddCookie(Cookie3)
            Wait(2000)
            driver.Navigate.Refresh()
            Chatshow("Changed language")
        Catch
            Chatshow("Something went wrong trying to change language to English")
        End Try

        Wait(10000)

        Dim title1 As String = driver.Title

        '################################################################################ Login Progress ################################################################################

        If title1 = "Anmelden - Twitch" Or title1 = "Log In - Twitch" Then
            Chatshow("Login Start")

            If tokenlogin.Checked = True Then
                Dim Cookie2 = New OpenQA.Selenium.Cookie("auth-token", tokeninput.Text, ".twitch.tv", "/", "2022-10-16T17:36:40.000Z") 'Cookie for auth-token login
                Chatshow("Put in Cookies - Token")
                Wait(2000)

                driver.Manage.Cookies.AddCookie(Cookie2)
                Chatshow("Manage Cookie")
                Wait(2000)

                driver.Navigate.Refresh()
                Chatshow("Refresh")
                Wait(10000)
            Else

                Try
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[3]/div/div/div/div[3]/form/div/div[1]/div/div[2]/input")).SendKeys(Namebox.Text)
                    Chatshow("Put in Username: " & Namebox.Text)
                Catch
                    Chatshow("Something went wrong with the Username Input")
                End Try
                Wait(2000)
                Try
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[3]/div/div/div/div[3]/form/div/div[2]/div/div[1]/div[2]/div[1]/input")).SendKeys(Passbox.Text)
                    Chatshow("Put in Password: ********")
                Catch
                    Chatshow("Something went wrong with the Password Input")
                End Try
                Wait(2000)
                Try
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[3]/div/div/div/div[3]/form/div/div[3]/button")).Click()
                    Chatshow("Pressing Login Button")
                Catch
                    Try
                        driver.FindElement(By.XPath("//*[text()='Log In']"))
                    Catch
                        Chatshow("Something went wrong with pressing the Login Button")
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
                Chatshow("Waiting for authentication - Please insert the Authcode or verify the captcha!")
                Waitforcheck = False
                If hiddenchrome = True Then
                    MessageBox.Show("Manual human verification is needed!" & "Please restart Chrome in visible mode.")
                    driver.Quit()
                End If
                GoTo Recheck
            End If
        Catch
            Chatshow("Something went wrong while checking the Chrome Title")
        End Try

        '################################################################################ Change Language2 ################################################################################

        Try
            Chatshow("Changing language to english - please wait")
            Dim Cookie3 = New OpenQA.Selenium.Cookie("language", "en", ".twitch.tv", "/", "2022-10-16T17:36:40.000Z")
            Wait(2000)
            driver.Manage.Cookies.AddCookie(Cookie3)
            Wait(2000)
            driver.Navigate.Refresh()
            Chatshow("Changed language")
        Catch
            Chatshow("Something went wrong trying to change language to English")
        End Try


watching:

        '################################################################################ Check for Drop ################################################################################

        subsonly = False 'resets subsonly chat detection

        Wait(10000)

        If Checkdrop.Checked = True Then
            Chatshow("Navigate to Twitch Inventory")
            driver.Navigate().GoToUrl("https://www.twitch.tv/inventory")

            Wait(10000)

            Chatshow("Searching for Valorant Drop")
            html_source = driver.PageSource

            Wait(5000)

            If html_source.Contains("<p class=""tw-font-size-5 tw-semibold"" data-test-selector=""drops-list__drop-name"">VALORANT</p>") Then
                Dropfound.Text = "True"
                Wait(2000)
                Chatshow("Valorant Drop found. Congratulations!")
                Wait(2000)
                MessageBox.Show("Valorant Drop found. Congratulations!")
            Else
                Chatshow("No Valorant Drop yet. Continue!")
                Dropfound.Text = "False"
            End If

            Wait(2000)
        End If


        '################################################################################ Search Streams ################################################################################

        Chatshow("Searching for Drop Active Streamers")
        driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?tl=c2542d6d-cd10-4532-919b-3d19f30a768b")

        Wait(10000)

        Dim Streamername As String

        If Watchstreamer.Checked = True Then
            Chatshow("Searching for Streamer: " & Streamerinput.Text)
            Try
                driver.FindElement(By.XPath("//*[text()='" & Streamerinput.Text & "']")).Click()
                Chatshow("Found Streamer " & Streamerinput.Text)
                Wait(10000)
                Try
                    driver.FindElement(By.CssSelector("a[data-a-target='home-channel-header-item']")).Click()
                Catch
                    Try
                        driver.FindElement(By.XPath("//div[text()='Home']")).Click()
                    Catch
                        Try
                            driver.Navigate().GoToUrl("https://www.twitch.tv/" & Streamerinput.Text)
                        Catch
                            Chatshow("Something went wrong trying to find Home Button")
                        End Try
                    End Try
                End Try
                Wait(10000)
                Chatshow("Watching Streamer: " & Streamerinput.Text)
                Timertext.Text = Waitscount
                Timertext.Visible = True
                Timertext.Enabled = True
                Timer1.Enabled = True
                Remainingtime.Visible = True
                Streamwatch = False  'Custom Streamer Found then False
            Catch
                Chatshow("Could not find Streamer: " & Streamerinput.Text)
                Chatshow("Searching other Streamers")
                driver.Navigate().GoToUrl("https://www.twitch.tv/directory/game/VALORANT?tl=c2542d6d-cd10-4532-919b-3d19f30a768b")
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
                Chatshow("Something went wrong while searching for Streams")
                GoTo SearchChannel
            End Try

            Timertext.Text = Waitscount
            Timertext.Enabled = True
            Timertext.Visible = True
            Timer1.Enabled = True
            Remainingtime.Visible = True

            Chatshow("Found a Streamer. Watching for: " & Waits & " Seconds. Watching Stream: " & Streamername)

            Wait(10000)

            Try
                driver.FindElement(By.CssSelector("a[data-a-target='home-channel-header-item']")).Click()
            Catch
                Chatshow("Something went wrong while Searching for Home Button")
                driver.Navigate().GoToUrl("https://www.twitch.tv/" & Streamername)
            End Try
        End If

        '################################################################################ Detect Maturecontent Warning ################################################################################

        Chatshow("checking for mature content popup - please wait")

        Wait(10000)

        Try
            driver.FindElement(By.XPath("//*[@id=""root""]/div/div[2]/div/main/div[2]/div[3]/div/div/div[2]/div[2]/div[2]/div/div/div/div[9]/div/div[3]/button")).Click()
            Chatshow("Mature content warning detected- pressing okay")
        Catch
            Try
                driver.FindElement(By.XPath("//*[@data-a-target='player-overlay-mature-accept']")).Click()
                Chatshow("Mature content warning detected- pressing okay")
            Catch ex As Exception
            End Try
        End Try

Ignoreit:

        Wait(2000)

        '################################################################################ Custom Audio ################################################################################

        If customaudio.Checked = True Then
            Try
                video = driver.FindElement(By.CssSelector("video"))
                driver.ExecuteScript("arguments[0].volume = " & volinput.Text & ";", video)     ' Changes the video sound to a custom volume (1 = 100%, 0.1 = 10%, 0.01 = 1%)
                Chatshow("Changed custom volume")
                Wait(2000)
            Catch
                Chatshow("Failed to change custom volume")
            End Try
        End If

        '################################################################################ Streamquality ################################################################################

        If Streamquality = True Then
            Dim body As IWebElement
            Try
                body = driver.FindElement(By.CssSelector("button[data-a-target='player-play-pause-button']"))   'Pause the video else it cant change settings why so ever
                body.SendKeys(Keys.Space)
            Catch
                Chatshow("Something went wrong searching the pause button")
                GoTo Ignorenext
            End Try

            Wait(2000)

            Try
                driver.FindElement(By.XPath("//*[@data-a-target='player-settings-button']")).Click()
            Catch
                Chatshow("Something went wrong trying to search Settings Button")
                GoTo Ignorenext
            End Try

            Wait(2000)


            Try
                driver.FindElement(By.CssSelector("button[data-a-target='player-settings-menu-item-quality']")).Click()
            Catch
                Chatshow("Something went wrong trying to find Quality Button")
                GoTo Ignorenext
            End Try

            Wait(2000)

            Try
                driver.FindElement(By.XPath("//*[text()='160p']")).Click()
                Chatshow("Changed Streamquality to low")
                Wait(1000)
            Catch
                Chatshow("Something went wrong trying to set Streamquality to low")
                GoTo Ignorenext
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
                    Chatshow("Something went wrong trying To find Chat Settings")
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
                    Chatshow("Something went wrong trying to find hide Chat Button")
                    GoTo Ignoremore
                End Try
            End Try

            Try
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[2]")).Click()
                Chatshow("Closed Streamchat")
                Wait(1000)
            Catch
                Chatshow("Something went wrong while trying to close Streamchat")
            End Try
        End If

Ignoremore:

        '################################################################################ Follow Streamer ################################################################################

        If Follow = True Then
            Try
                driver.FindElement(By.XPath("//*[@id=""root""]/div/div[2]/div/main/div[1]/div/div[2]/div/div[1]/div[3]/div[1]/div/div/div[1]")).Click()
                Chatshow("Followed the Streamer: " & Streamername & " to be able to write in Chat")
            Catch
                Chatshow("Something went wrong while trying to follow a Streamer")
            End Try
        End If

        '################################################################################ Start Writechat Timer ################################################################################

        If Chat = True Then
            Timer2.Enabled = True
        End If

        If Claimpoints.Checked = True Then
            Timer5.Enabled = True
        End If

        Wait(Waitms)

        Timer2.Enabled = False
        Timer5.Enabled = False

        Wait(2000)

        GoTo watching

    End Sub

    Private Sub Wait(ByVal interval As Integer)
        Dim stopW As New Stopwatch
        stopW.Start()
        Do While stopW.ElapsedMilliseconds < interval
            ' Allows your UI to remain responsive
            Application.DoEvents()
        Loop
        stopW.Stop()
    End Sub


    Dim Text1 As Boolean = True
    Private video As IWebElement
    Public Property AddresOf As ThreadStart

    '################################################################################ Custom Chat ################################################################################

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        html_source = driver.PageSource

        If html_source.Contains("<p class=""tw-strong"">Subscribers-Only Chat</p>") Then
            Chatshow("Streamchat is Subscribers Only - Won't write in Chat")
        Else

            If Text1 = True Then
                Try
                    driver.FindElement(By.ClassName("chat-input__textarea")).Click()
                    Chatshow("Click Textarea")
                    Wait(2000)
                Catch
                    Try
                        driver.FindElement(By.XPath("//*[contains(@src,'Send a message')]"))
                        Chatshow("Click Textarea")
                        Wait(2000)
                    Catch
                        Chatshow("Something went wrong while trying to write in Chat")
                    End Try
                End Try

                Try
                    driver.FindElement(By.CssSelector("chat-rules-ok-button")).Click()
                    Chatshow("Click Okay")
                Catch
                    Try
                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div[1]/div/div/section/div/div[5]/div[1]/div/div[2]/div[2]/button")).Click()
                        Chatshow("Click Okay")
                    Catch
                        Try
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[4]/div[1]/div/div[2]/div[2]/button")).Click()
                            Chatshow("Click Okay")
                        Catch
                            Try
                                driver.FindElement(By.XPath("//p[text()='Okay, Got It!']")).Click()
                                Chatshow("Click Okay")
                            Catch
                                Chatshow("Something went wrong while trying to write in Chat")
                            End Try
                        End Try
                    End Try
                End Try

                Try
                    driver.FindElement(By.ClassName("tw-textarea")).SendKeys(Chatinput.Text)
                    Chatshow("Write")
                    Wait(2000)
                    driver.FindElement(By.ClassName("tw-textarea")).SendKeys(Keys.Enter)
                    Chatshow("Writing in Chat")
                    Text1 = False
                Catch
                    Try
                        driver.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Chatinput.Text)
                        Chatshow("Write")
                        Wait(2000)
                        driver.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Keys.Enter)
                        Chatshow("Writing in Chat")
                        Text1 = False
                    Catch
                        Chatshow("Something went wrong while trying to write in Chat")
                    End Try
                End Try

            ElseIf Text1 = False Then

                Try
                    driver.FindElement(By.ClassName("chat-input__textarea")).Click()
                    Chatshow("Click Textarea")
                    Wait(2000)
                Catch
                    Try
                        driver.FindElement(By.XPath("//*[contains(@src,'Send a message')]"))
                        Chatshow("Click Textarea")
                        Wait(2000)
                    Catch
                        Chatshow("Something went wrong while trying to write in Chat")
                    End Try
                End Try

                Try
                    driver.FindElement(By.CssSelector("chat-rules-ok-button")).Click()
                    Chatshow("Click Okay")
                Catch
                    Try
                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div[1]/div/div/section/div/div[5]/div[1]/div/div[2]/div[2]/button")).Click()
                        Chatshow("Click Okay")
                    Catch
                        Try
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[4]/div[1]/div/div[2]/div[2]/button")).Click()
                            Chatshow("Click Okay")
                        Catch
                            Try
                                driver.FindElement(By.XPath("//p[text()='Okay, Got It!']")).Click()
                                Chatshow("Click Okay")
                            Catch
                                Chatshow("Something went wrong while trying to write in Chat")
                            End Try
                        End Try
                    End Try
                End Try

                Try
                    driver.FindElement(By.ClassName("tw-textarea")).SendKeys(Chatinput2.Text)
                    Chatshow("Write")
                    Wait(2000)
                    driver.FindElement(By.ClassName("tw-textarea")).SendKeys(Keys.Enter)
                    Chatshow("Writing in Chat")
                    Text1 = False
                Catch
                    Try
                        driver.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Chatinput2.Text)
                        Chatshow("Write")
                        Wait(2000)
                        driver.FindElement(By.XPath("//*[text()='Send a message']")).SendKeys(Keys.Enter)
                        Chatshow("Writing in Chat")
                        Text1 = False
                    Catch
                        Chatshow("Something went wrong while trying to write in Chat")
                    End Try
                End Try
            End If
        End If

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Try
            driver.FindElement(By.XPath("//*[text()='Click to claim a bonus!']")).Click()
            Chatshow("Claimed Channelpoints")
        Catch
            Try
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/section/div/div[5]/div[2]/div[2]/div[1]/div/div/div/div[2]/div/div/div/button")).Click()
                Chatshow("Claimed Channelpoints")
            Catch
            End Try

        End Try
    End Sub

    '################################################################################ Other Stuff ################################################################################

    Private Sub Auth_Click(sender As Object, e As EventArgs)
        Waitforcheck = True
        Chatshow("Will continue please wait!")
    End Sub

    Private Sub Followbox_CheckedChanged(sender As Object, e As EventArgs) Handles Followbox.CheckedChanged
        Follow = True
    End Sub

    Private Sub Chatbox_CheckedChanged(sender As Object, e As EventArgs) Handles Chatbox.CheckedChanged
        If chromehide.Checked = True Then
            MessageBox.Show("You are using ""Hide Chrometab""." & vbLf & "It may will not be able to write in Streamers Chat." & vbLf & vbLf & "If you want this feature to work 100% disable ""Hide Chrometab"".")
        End If
        Chat = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timertext.Text = Val(Timertext.Text) - 1
        If Timertext.Text < 0 Then Timertext.Text = "Wait.."
    End Sub

    Public Function Chatshow(str As String)
        Dim timeStamp As DateTime = DateTime.Now
        Me.Textbox.AppendText(Environment.NewLine & "[" & timeStamp & "]   -   " & str & "")
    End Function

    Private Sub Chromehide_CheckedChanged(sender As Object, e As EventArgs) Handles chromehide.CheckedChanged
        If tokenlogin.Checked = True Then
        Else
            If chromehide.Checked = True Then
                MessageBox.Show("Please use this only with Twitch auth token login." & vbLf & "Using this with Username Password login may leads to issues!")
            End If
        End If

    End Sub

    Private Sub Stopbutton_Click(sender As Object, e As EventArgs) Handles Stopbutton.Click
        Stopinstance()
    End Sub

    Private Sub Stopinstance()
        Try
            Dim x() As Process
            x = Process.GetProcesses
            driver.Quit()
            For Each p As Process In x
                If p.MainWindowTitle.Contains("chrome") Or p.MainWindowTitle.Contains("twitch") Or p.MainWindowTitle.Contains("Firefox") or p.MainWindowTitle.Contains("chromedriver") Then
                    Try
                        p.Kill()
                    Catch
                    End Try
                Else
                    BackgroundWorker1.CancelAsync()
                    BackgroundWorker2.CancelAsync()
                    BackgroundWorker3.CancelAsync()
                    BackgroundWorker4.CancelAsync()
                    BackgroundWorker5.CancelAsync()
                End If
            Next
        Catch
        End Try

    End Sub


    Private Sub Tokenlogin_CheckedChanged(sender As Object, e As EventArgs) Handles tokenlogin.CheckedChanged
        If tokenlogin.Checked = True Then
            MessageBox.Show("You might need a new token." & vbLf & "Please use a new token every 24 - 42 hours.")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ToolTip1.Active = False
        Else
            ToolTip1.Active = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Streamquality = True
        Else
            Streamquality = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Streamchathide = True
            Label3.Hide()
            Chatbox.Hide()
            Chatinput.Hide()
            Chatinput2.Hide()
            Label3.Enabled = False
            Chatbox.Enabled = False
            Chatinput.Enabled = False
            Chatinput2.Enabled = False
            Label8.Hide()
            Label8.Enabled = False
            Label9.Hide()
            Label9.Enabled = False
            Chatminute.Hide()
            Chatminute.Enabled = False
        Else
            Streamchathide = False
            Label3.Show()
            Chatbox.Show()
            Chatinput.Show()
            Chatinput2.Show()
            Label3.Enabled = True
            Chatbox.Enabled = True
            Chatinput.Enabled = True
            Chatinput2.Enabled = True
            Label8.Show()
            Label8.Enabled = True
            Label9.Show()
            Label9.Enabled = True
            Chatminute.Show()
            Chatminute.Enabled = True
        End If
    End Sub

    Private Sub Muteaudio_CheckedChanged(sender As Object, e As EventArgs) Handles muteaudio.CheckedChanged
        If muteaudio.Checked = True Then
            customaudio.Hide()
            customaudio.Enabled = False
            volinput.Hide()
            volinput.Enabled = False
        Else
            customaudio.Show()
            customaudio.Enabled = True
            volinput.Show()
            volinput.Enabled = True
        End If
    End Sub

    Private Sub Chromebox_CheckedChanged(sender As Object, e As EventArgs) Handles chromebox.CheckedChanged
        If chromebox.Checked = True Then
            chromeactive = True
            Firefoxbox.Hide()
            Firefoxbox.Enabled = False
        Else
            Firefoxbox.Show()
            Firefoxbox.Enabled = True
        End If
    End Sub

    Private Sub Firefoxbox_CheckedChanged(sender As Object, e As EventArgs) Handles Firefoxbox.CheckedChanged
        If Firefoxbox.Checked = True Then
            chromeactive = False
            chromebox.Hide()
            chromebox.Enabled = False
            MessageBox.Show("WORK IN PROGRESS!" & vblf & """Bot Settings"" will not work for Firefox. Please use Chrome for that!")
        Else
            chromebox.Show()
            chromebox.Enabled = True
        End If
    End Sub

    '################################################################################ Backgroundworkers ################################################################################

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Startbot()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Startbot()
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Startbot()
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        Startbot()
    End Sub

    Private Sub BackgroundWorker5_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker5.DoWork
        Startbot()
    End Sub

    '################################################################################ Start With low CPU ################################################################################

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Prioritymode_CheckedChanged(sender As Object, e As EventArgs) Handles prioritymode.CheckedChanged

        If prioritymode.Checked = True Then
            MessageBox.Show("This feature is work in progress. It works but may leads to issues." & vbLf & vbLf & "If you experience any issues disable it!")
            If Crossthread = False Then
                prioritymode.Checked = False
                MessageBox.Show("This feature only works in ""CrossThreadCall"" mode" & vbLf & vbLf & "Please switch the Button from ""Backgroundworkers"" to ""CrossThreadCalls""")
            End If
        End If

    End Sub

    Private Sub Backgroundbox_CheckedChanged(sender As Object, e As EventArgs) Handles backgroundbox.CheckedChanged
        If backgroundbox.Checked = True Then
            Crossthread = False
            crossthreadbox.Hide()
            crossthreadbox.Enabled = False
            If prioritymode.Checked = True Then
                MessageBox.Show("Low Prioritymode only works with CrossThreadCalls" & vbLf & vbLf & "Please disable Low Priority!")
            End If
        Else
            crossthreadbox.Show()
            crossthreadbox.Enabled = True
        End If
    End Sub

    Private Sub Crossthreadbox_CheckedChanged(sender As Object, e As EventArgs) Handles crossthreadbox.CheckedChanged
        If crossthreadbox.Checked = True Then
            Crossthread = True
            backgroundbox.Hide()
            backgroundbox.Enabled = False
        Else
            backgroundbox.Show()
            backgroundbox.Enabled = True
        End If
    End Sub
End Class
