Imports System.Net
Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Win32
Imports System.Security.Principal
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Management
Imports System.Security.Cryptography
Imports System.Threading

Public Class Twitchwatcher
    Public currentChildForm As Form
    Public Picbox2 As Boolean = False
    Public Picbox3 As Boolean = False
    Public Picbox4 As Boolean = False
    Public Picbox5 As Boolean = False

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
    Public Declare Function SetThreadPriority Lib "kernel32" (ByVal hThread As Long, ByVal nPriority As Long) As Long
    Public Declare Function SetPriorityClass Lib "kernel32" (ByVal hProcess As Long, ByVal dwPriorityClass As Long) As Long
    Public Declare Function GetThreadPriority Lib "kernel32" (ByVal hThread As Long) As Long
    Public Declare Function GetPriorityClass Lib "kernel32" (ByVal hProcess As Long) As Long
    Public Declare Function GetCurrentThread Lib "kernel32" () As Long
    Public Declare Function GetCurrentProcess Lib "kernel32" () As Long


    Public Shared Function SetPriority(ByVal plngPriority As Long) As Long
        SetPriority = SetThreadPriority(GetCurrentThread(), plngPriority)
    End Function

    Public Sub Mainstart(sender As Object, e As EventArgs) Handles MyBase.Load

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

    End Sub
    Public Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False 'not using invoke delegate because im lazy 

        Dim appName As String = My.Application.Info.AssemblyName
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)

    End Sub

    Public Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.MouseDown

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

        If Picbox2 = True Then
            Picbox2 = False
            currentChildForm.Hide()
        Else
            Picbox2 = True
            Picbox3 = False
            Picbox4 = False
            Picbox5 = False
            OpenChildForm(Power)
        End If

        ClickHandler()

    End Sub

    Public Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.MouseDown

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

        If Picbox3 = True Then
            Picbox3 = False
            currentChildForm.Hide()
        Else
            Picbox3 = True
            Picbox2 = False
            Picbox4 = False
            Picbox5 = False
            OpenChildForm(Settings)
        End If

        ClickHandler()

    End Sub

    Public Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.MouseDown

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

        If Picbox4 = True Then
            Picbox4 = False
            currentChildForm.Hide()
        Else
            Picbox4 = True
            Picbox2 = False
            Picbox3 = False
            Picbox5 = False
            OpenChildForm(Donate)
        End If

        ClickHandler()

    End Sub

    Public Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.MouseDown

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)


        If Picbox5 = True Then
            Picbox5 = False
            currentChildForm.Hide()
        Else
            Picbox5 = True
            Picbox2 = False
            Picbox3 = False
            Picbox4 = False
            OpenChildForm(Information)
        End If

        ClickHandler()

    End Sub

    Public Sub ClickHandler()

        If Picbox2 = True Then
            Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer))
        Else
            Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        End If

        If Picbox3 = True Then
            Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer))
        Else
            Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        End If

        If Picbox4 = True Then
            Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer))
        Else
            Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        End If

        If Picbox5 = True Then
            Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer))
        Else
            Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        End If

    End Sub

    Public Sub OpenChildForm(childForm As Form)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    'Drag Form

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Public Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
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

End Class
