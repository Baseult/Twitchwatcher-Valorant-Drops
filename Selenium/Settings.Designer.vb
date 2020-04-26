<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.prioritymode = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chromehide = New System.Windows.Forms.CheckBox()
        Me.commandhide = New System.Windows.Forms.CheckBox()
        Me.cookiessave = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Backgroundbox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Crossthreadbox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Chatbox = New System.Windows.Forms.CheckBox()
        Me.Chatinput = New System.Windows.Forms.TextBox()
        Me.Chatinput2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chatminute = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Checkdrop = New System.Windows.Forms.CheckBox()
        Me.Claimpoints = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Waitbox = New System.Windows.Forms.TextBox()
        Me.Followbox = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.muteaudio = New System.Windows.Forms.CheckBox()
        Me.proxyinput = New System.Windows.Forms.TextBox()
        Me.proxycheckbox = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Watchstreamer = New System.Windows.Forms.CheckBox()
        Me.Streamerinput = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.customaudio = New System.Windows.Forms.CheckBox()
        Me.volinput = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.randomstreambox = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Namebox = New System.Windows.Forms.MaskedTextBox()
        Me.Passbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tokeninput = New System.Windows.Forms.TextBox()
        Me.tokenlogin = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.restart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'prioritymode
        '
        Me.prioritymode.AutoSize = True
        Me.prioritymode.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prioritymode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.prioritymode.Location = New System.Drawing.Point(304, 7)
        Me.prioritymode.Name = "prioritymode"
        Me.prioritymode.Size = New System.Drawing.Size(160, 22)
        Me.prioritymode.TabIndex = 47
        Me.prioritymode.Text = "Low Priority Mode"
        Me.ToolTip1.SetToolTip(Me.prioritymode, "This will start all Threads with low priority and should lower the CPU Usage." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(M" &
        "ight slow down the Bot)")
        Me.prioritymode.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(13, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 22)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Hide Tooltips"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Disabled (Default): You will see this Helpboxes describing all Features and showi" &
        "ng tutorials." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enabled: Will hide this messages")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chromehide
        '
        Me.chromehide.AutoSize = True
        Me.chromehide.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chromehide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chromehide.Location = New System.Drawing.Point(473, 70)
        Me.chromehide.Name = "chromehide"
        Me.chromehide.Size = New System.Drawing.Size(146, 22)
        Me.chromehide.TabIndex = 19
        Me.chromehide.Text = "Hide Chrometab"
        Me.ToolTip1.SetToolTip(Me.chromehide, "This will hide your Google Chrome Tab. You will still receive Valorant Drops.")
        Me.chromehide.UseVisualStyleBackColor = True
        '
        'commandhide
        '
        Me.commandhide.AutoSize = True
        Me.commandhide.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commandhide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.commandhide.Location = New System.Drawing.Point(262, 70)
        Me.commandhide.Name = "commandhide"
        Me.commandhide.Size = New System.Drawing.Size(194, 22)
        Me.commandhide.TabIndex = 18
        Me.commandhide.Text = "Hide Commandprompt"
        Me.ToolTip1.SetToolTip(Me.commandhide, "This will hide the CMD Commandprompt Window which will Popup on Botstart")
        Me.commandhide.UseVisualStyleBackColor = True
        '
        'cookiessave
        '
        Me.cookiessave.AutoSize = True
        Me.cookiessave.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cookiessave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cookiessave.Location = New System.Drawing.Point(14, 70)
        Me.cookiessave.Name = "cookiessave"
        Me.cookiessave.Size = New System.Drawing.Size(225, 22)
        Me.cookiessave.TabIndex = 26
        Me.cookiessave.Text = "Save Session - Store Cookies"
        Me.ToolTip1.SetToolTip(Me.cookiessave, "It will save your Cookies and Session so you don't have to login anymore." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Disab" &
        "le it if you use Bot with more than one Account)")
        Me.cookiessave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(9, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Bot Settings:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(159, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "CPU - Performance:"
        '
        'Backgroundbox
        '
        Me.Backgroundbox.AutoSize = True
        Me.Backgroundbox.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backgroundbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Backgroundbox.Location = New System.Drawing.Point(13, 129)
        Me.Backgroundbox.Name = "Backgroundbox"
        Me.Backgroundbox.Size = New System.Drawing.Size(203, 22)
        Me.Backgroundbox.TabIndex = 62
        Me.Backgroundbox.Text = "Use Backgroundworkers"
        Me.ToolTip1.SetToolTip(Me.Backgroundbox, resources.GetString("Backgroundbox.ToolTip"))
        Me.Backgroundbox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(9, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Multithreading:"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'Crossthreadbox
        '
        Me.Crossthreadbox.AutoSize = True
        Me.Crossthreadbox.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Crossthreadbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Crossthreadbox.Location = New System.Drawing.Point(302, 129)
        Me.Crossthreadbox.Name = "Crossthreadbox"
        Me.Crossthreadbox.Size = New System.Drawing.Size(177, 22)
        Me.Crossthreadbox.TabIndex = 63
        Me.Crossthreadbox.Text = "Use CrossThreadCalls"
        Me.ToolTip1.SetToolTip(Me.Crossthreadbox, resources.GetString("Crossthreadbox.ToolTip"))
        Me.Crossthreadbox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(226, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "<- or ->"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(300, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Custom Message in Streamerchat:"
        Me.ToolTip1.SetToolTip(Me.Label5, "It will write the Messages below in the Streamers Chat")
        '
        'Chatbox
        '
        Me.Chatbox.AutoSize = True
        Me.Chatbox.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chatbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Chatbox.Location = New System.Drawing.Point(13, 212)
        Me.Chatbox.Name = "Chatbox"
        Me.Chatbox.Size = New System.Drawing.Size(255, 22)
        Me.Chatbox.TabIndex = 8
        Me.Chatbox.Text = "Write Messages in Streamerchat"
        Me.ToolTip1.SetToolTip(Me.Chatbox, "With this enabled it will write Custom Messages in the Streamers Chat")
        Me.Chatbox.UseVisualStyleBackColor = True
        '
        'Chatinput
        '
        Me.Chatinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chatinput.ForeColor = System.Drawing.Color.Black
        Me.Chatinput.Location = New System.Drawing.Point(303, 248)
        Me.Chatinput.Multiline = True
        Me.Chatinput.Name = "Chatinput"
        Me.Chatinput.Size = New System.Drawing.Size(144, 20)
        Me.Chatinput.TabIndex = 9
        Me.Chatinput.Text = "Message 1"
        Me.ToolTip1.SetToolTip(Me.Chatinput, "Write here your first Message")
        '
        'Chatinput2
        '
        Me.Chatinput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chatinput2.ForeColor = System.Drawing.Color.Black
        Me.Chatinput2.Location = New System.Drawing.Point(454, 248)
        Me.Chatinput2.Multiline = True
        Me.Chatinput2.Name = "Chatinput2"
        Me.Chatinput2.Size = New System.Drawing.Size(144, 20)
        Me.Chatinput2.TabIndex = 16
        Me.Chatinput2.Text = "Message 2"
        Me.ToolTip1.SetToolTip(Me.Chatinput2, "Write here your second Message")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(299, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Write every X Minutes in Chat:"
        Me.ToolTip1.SetToolTip(Me.Label6, "The Bot will write every X Minutes in the Streamers Chat")
        '
        'Chatminute
        '
        Me.Chatminute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chatminute.ForeColor = System.Drawing.Color.Black
        Me.Chatminute.Location = New System.Drawing.Point(526, 188)
        Me.Chatminute.Name = "Chatminute"
        Me.Chatminute.Size = New System.Drawing.Size(72, 22)
        Me.Chatminute.TabIndex = 24
        Me.Chatminute.Text = "3"
        Me.Chatminute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Chatminute, "Type here how many Minutes the Bot should wait until he writes a new Message" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F" &
        "or example: ""3"" for 3 Minutes - It will write every 3 Minutes a new Message in C" &
        "hat")
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox2.Location = New System.Drawing.Point(14, 188)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(213, 22)
        Me.CheckBox2.TabIndex = 34
        Me.CheckBox2.Text = "Hide - Disable Streamchat"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "This will first disable and then hide the Streamerschat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(requested by a user)")
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Checkdrop
        '
        Me.Checkdrop.AutoSize = True
        Me.Checkdrop.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkdrop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Checkdrop.Location = New System.Drawing.Point(136, 445)
        Me.Checkdrop.Name = "Checkdrop"
        Me.Checkdrop.Size = New System.Drawing.Size(203, 22)
        Me.Checkdrop.TabIndex = 45
        Me.Checkdrop.Text = "Check for Valorant Drop"
        Me.ToolTip1.SetToolTip(Me.Checkdrop, "This will search in your Twitchinventory for Valorant Drops." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If a Drop has been " &
        "found it will show a Message on your Screen to inform you.")
        Me.Checkdrop.UseVisualStyleBackColor = True
        '
        'Claimpoints
        '
        Me.Claimpoints.AutoSize = True
        Me.Claimpoints.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Claimpoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Claimpoints.Location = New System.Drawing.Point(346, 445)
        Me.Claimpoints.Name = "Claimpoints"
        Me.Claimpoints.Size = New System.Drawing.Size(250, 22)
        Me.Claimpoints.TabIndex = 46
        Me.Claimpoints.Text = "Claim Streamers Channelpoints"
        Me.ToolTip1.SetToolTip(Me.Claimpoints, "This will claim the Streamerpoints which you get if you wch a Stream, write in Ch" &
        "at or claim the Boxes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(kinda buggy - still in development)")
        Me.Claimpoints.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(9, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 17)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Streamchat Settings:"
        '
        'Waitbox
        '
        Me.Waitbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Waitbox.ForeColor = System.Drawing.Color.Black
        Me.Waitbox.Location = New System.Drawing.Point(525, 312)
        Me.Waitbox.Name = "Waitbox"
        Me.Waitbox.Size = New System.Drawing.Size(72, 22)
        Me.Waitbox.TabIndex = 11
        Me.Waitbox.Text = "20"
        Me.Waitbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Waitbox, resources.GetString("Waitbox.ToolTip"))
        '
        'Followbox
        '
        Me.Followbox.AutoSize = True
        Me.Followbox.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Followbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Followbox.Location = New System.Drawing.Point(13, 234)
        Me.Followbox.Name = "Followbox"
        Me.Followbox.Size = New System.Drawing.Size(241, 40)
        Me.Followbox.TabIndex = 7
        Me.Followbox.Text = "Follow the Streamer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( write in follower-only chats)"
        Me.ToolTip1.SetToolTip(Me.Followbox, "With this enabled it will follow the Streamer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Helpful if the Streamer has 'on" &
        "ly-follower' chat enabled." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You will be able to write in chat since you followed" &
        " the Streamer.")
        Me.Followbox.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(298, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(217, 18)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Every X Minutes new Stream:"
        Me.ToolTip1.SetToolTip(Me.Label10, resources.GetString("Label10.ToolTip"))
        '
        'muteaudio
        '
        Me.muteaudio.AutoSize = True
        Me.muteaudio.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.muteaudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.muteaudio.Location = New System.Drawing.Point(15, 390)
        Me.muteaudio.Name = "muteaudio"
        Me.muteaudio.Size = New System.Drawing.Size(110, 22)
        Me.muteaudio.TabIndex = 20
        Me.muteaudio.Text = "Mute Audio"
        Me.ToolTip1.SetToolTip(Me.muteaudio, "This will Mute your chromedrivers Audio." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It doesn't flag you as AFK so you can u" &
        "se that to Mute the Stream.")
        Me.muteaudio.UseVisualStyleBackColor = True
        '
        'proxyinput
        '
        Me.proxyinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proxyinput.ForeColor = System.Drawing.Color.Black
        Me.proxyinput.Location = New System.Drawing.Point(423, 484)
        Me.proxyinput.Name = "proxyinput"
        Me.proxyinput.Size = New System.Drawing.Size(174, 22)
        Me.proxyinput.TabIndex = 29
        Me.proxyinput.Text = "IP:Port"
        Me.proxyinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.proxyinput, "Usage IP:Port" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Example: 192.168.2.1:8080")
        '
        'proxycheckbox
        '
        Me.proxycheckbox.AutoSize = True
        Me.proxycheckbox.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proxycheckbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.proxycheckbox.Location = New System.Drawing.Point(302, 483)
        Me.proxycheckbox.Name = "proxycheckbox"
        Me.proxycheckbox.Size = New System.Drawing.Size(115, 22)
        Me.proxycheckbox.TabIndex = 30
        Me.proxycheckbox.Text = "Use a proxy:"
        Me.ToolTip1.SetToolTip(Me.proxycheckbox, "If you have been IP banned or you won't get Drops in your country just use a Prox" &
        "y to bypass.")
        Me.proxycheckbox.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox3.Location = New System.Drawing.Point(15, 411)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(229, 22)
        Me.CheckBox3.TabIndex = 35
        Me.CheckBox3.Text = "Set Stream Quality to lowest"
        Me.ToolTip1.SetToolTip(Me.CheckBox3, "This will set the Quality of the Stream to 160p if possible." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Should lower the CP" &
        "U and speed up loading time.")
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Watchstreamer
        '
        Me.Watchstreamer.AutoSize = True
        Me.Watchstreamer.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Watchstreamer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Watchstreamer.Location = New System.Drawing.Point(12, 337)
        Me.Watchstreamer.Name = "Watchstreamer"
        Me.Watchstreamer.Size = New System.Drawing.Size(203, 22)
        Me.Watchstreamer.TabIndex = 40
        Me.Watchstreamer.Text = "Watch specific Streamer:"
        Me.ToolTip1.SetToolTip(Me.Watchstreamer, resources.GetString("Watchstreamer.ToolTip"))
        Me.Watchstreamer.UseVisualStyleBackColor = True
        '
        'Streamerinput
        '
        Me.Streamerinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Streamerinput.ForeColor = System.Drawing.Color.Black
        Me.Streamerinput.Location = New System.Drawing.Point(361, 337)
        Me.Streamerinput.Name = "Streamerinput"
        Me.Streamerinput.Size = New System.Drawing.Size(237, 22)
        Me.Streamerinput.TabIndex = 41
        Me.Streamerinput.Text = "Streamername"
        Me.ToolTip1.SetToolTip(Me.Streamerinput, resources.GetString("Streamerinput.ToolTip"))
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(298, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 18)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Name:"
        '
        'customaudio
        '
        Me.customaudio.AutoSize = True
        Me.customaudio.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customaudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.customaudio.Location = New System.Drawing.Point(303, 390)
        Me.customaudio.Name = "customaudio"
        Me.customaudio.Size = New System.Drawing.Size(144, 22)
        Me.customaudio.TabIndex = 43
        Me.customaudio.Text = "Custom Volume:"
        Me.ToolTip1.SetToolTip(Me.customaudio, "Set a custom volume of the Stream." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 = 100% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.5 = 50% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.1 = 10" &
        "% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.01 = 1% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Example: ""0.01"" - Sets the Volume to 1%")
        Me.customaudio.UseVisualStyleBackColor = True
        '
        'volinput
        '
        Me.volinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volinput.ForeColor = System.Drawing.Color.Black
        Me.volinput.Location = New System.Drawing.Point(304, 413)
        Me.volinput.Name = "volinput"
        Me.volinput.Size = New System.Drawing.Size(173, 22)
        Me.volinput.TabIndex = 44
        Me.volinput.Text = "0.5"
        Me.volinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.volinput, "Set a custom volume of the Stream." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 = 100% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.5 = 50% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.1 = 10" &
        "% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.01 = 1% Volume" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Example: ""0.01"" - Sets the Volume to 1%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(10, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 17)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Stream Settings:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(11, 370)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 17)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Video Settings:"
        '
        'randomstreambox
        '
        Me.randomstreambox.AutoSize = True
        Me.randomstreambox.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.randomstreambox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.randomstreambox.Location = New System.Drawing.Point(13, 313)
        Me.randomstreambox.Name = "randomstreambox"
        Me.randomstreambox.Size = New System.Drawing.Size(216, 22)
        Me.randomstreambox.TabIndex = 66
        Me.randomstreambox.Text = "Watch different Streamers"
        Me.ToolTip1.SetToolTip(Me.randomstreambox, resources.GetString("randomstreambox.ToolTip"))
        Me.randomstreambox.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(1337, 771)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 20)
        Me.Label16.TabIndex = 13
        Me.Label16.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(9, 507)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(136, 18)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Twitch Username:"
        Me.ToolTip1.SetToolTip(Me.Label19, "You can use your Twitch Username to login")
        '
        'Namebox
        '
        Me.Namebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namebox.ForeColor = System.Drawing.Color.Black
        Me.Namebox.Location = New System.Drawing.Point(151, 507)
        Me.Namebox.Name = "Namebox"
        Me.Namebox.Size = New System.Drawing.Size(138, 22)
        Me.Namebox.TabIndex = 1
        Me.Namebox.Text = "Username"
        Me.ToolTip1.SetToolTip(Me.Namebox, "You can use your Twitch Username to login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Passbox
        '
        Me.Passbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passbox.ForeColor = System.Drawing.Color.Black
        Me.Passbox.Location = New System.Drawing.Point(151, 533)
        Me.Passbox.Name = "Passbox"
        Me.Passbox.Size = New System.Drawing.Size(138, 22)
        Me.Passbox.TabIndex = 3
        Me.Passbox.Text = "Password"
        Me.ToolTip1.SetToolTip(Me.Passbox, "You can use your Twitch Password to login.")
        Me.Passbox.UseSystemPasswordChar = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(9, 533)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(131, 18)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Twitch Password:"
        Me.ToolTip1.SetToolTip(Me.Label20, "You can use your Twitch Password to login.")
        '
        'tokeninput
        '
        Me.tokeninput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tokeninput.ForeColor = System.Drawing.Color.Black
        Me.tokeninput.Location = New System.Drawing.Point(302, 533)
        Me.tokeninput.Name = "tokeninput"
        Me.tokeninput.Size = New System.Drawing.Size(295, 22)
        Me.tokeninput.TabIndex = 22
        Me.tokeninput.Text = "Twitch Auth-Token"
        Me.tokeninput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tokeninput, resources.GetString("tokeninput.ToolTip"))
        '
        'tokenlogin
        '
        Me.tokenlogin.AutoSize = True
        Me.tokenlogin.BackColor = System.Drawing.Color.Transparent
        Me.tokenlogin.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tokenlogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tokenlogin.Location = New System.Drawing.Point(302, 508)
        Me.tokenlogin.Name = "tokenlogin"
        Me.tokenlogin.Size = New System.Drawing.Size(294, 22)
        Me.tokenlogin.TabIndex = 27
        Me.tokenlogin.Text = "Login with your Twtich ""auth-token"":"
        Me.ToolTip1.SetToolTip(Me.tokenlogin, resources.GetString("tokenlogin.ToolTip"))
        Me.tokenlogin.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(9, 483)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 17)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Login:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(10, 447)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 17)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Reward Settings:"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 10000
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 15000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 20
        '
        'Timer5
        '
        Me.Timer5.Interval = 120000
        '
        'Timer1
        '
        '
        'restart
        '
        Me.restart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restart.ForeColor = System.Drawing.Color.Black
        Me.restart.Location = New System.Drawing.Point(474, 4)
        Me.restart.Name = "restart"
        Me.restart.Size = New System.Drawing.Size(124, 28)
        Me.restart.TabIndex = 48
        Me.restart.Text = "Low Priority"
        Me.ToolTip1.SetToolTip(Me.restart, "This will restart your Bot with the lowest possible priority." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It will reduce you" &
        "r CPU while you are playing other games." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Might slow down the Bot)")
        Me.restart.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BackgroundImage = Global.Twitchbot.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(636, 570)
        Me.Controls.Add(Me.randomstreambox)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.chromehide)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.commandhide)
        Me.Controls.Add(Me.tokenlogin)
        Me.Controls.Add(Me.tokeninput)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Crossthreadbox)
        Me.Controls.Add(Me.Passbox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Namebox)
        Me.Controls.Add(Me.cookiessave)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Backgroundbox)
        Me.Controls.Add(Me.volinput)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.customaudio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.restart)
        Me.Controls.Add(Me.Streamerinput)
        Me.Controls.Add(Me.prioritymode)
        Me.Controls.Add(Me.Watchstreamer)
        Me.Controls.Add(Me.Claimpoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Checkdrop)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.proxycheckbox)
        Me.Controls.Add(Me.Chatbox)
        Me.Controls.Add(Me.proxyinput)
        Me.Controls.Add(Me.Chatinput)
        Me.Controls.Add(Me.Chatinput2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.muteaudio)
        Me.Controls.Add(Me.Chatminute)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Waitbox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Followbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents prioritymode As CheckBox
    Public WithEvents CheckBox1 As CheckBox
    Public WithEvents chromehide As CheckBox
    Public WithEvents commandhide As CheckBox
    Public WithEvents cookiessave As CheckBox
    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Backgroundbox As CheckBox
    Public WithEvents Label3 As Label
    Public WithEvents Crossthreadbox As CheckBox
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Chatbox As CheckBox
    Public WithEvents Chatinput As TextBox
    Public WithEvents Chatinput2 As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents Chatminute As TextBox
    Public WithEvents CheckBox2 As CheckBox
    Public WithEvents Checkdrop As CheckBox
    Public WithEvents Claimpoints As CheckBox
    Public WithEvents Label8 As Label
    Public WithEvents Waitbox As TextBox
    Public WithEvents Followbox As CheckBox
    Public WithEvents Label10 As Label
    Public WithEvents muteaudio As CheckBox
    Public WithEvents proxyinput As TextBox
    Public WithEvents proxycheckbox As CheckBox
    Public WithEvents CheckBox3 As CheckBox
    Public WithEvents Watchstreamer As CheckBox
    Public WithEvents Streamerinput As TextBox
    Public WithEvents Label12 As Label
    Public WithEvents customaudio As CheckBox
    Public WithEvents volinput As TextBox
    Public WithEvents Label13 As Label
    Public WithEvents Label14 As Label
    Public WithEvents randomstreambox As CheckBox
    Public WithEvents Label16 As Label
    Public WithEvents Label19 As Label
    Public WithEvents Namebox As MaskedTextBox
    Public WithEvents Passbox As MaskedTextBox
    Public WithEvents Label20 As Label
    Public WithEvents tokeninput As TextBox
    Public WithEvents tokenlogin As CheckBox
    Public WithEvents Label21 As Label
    Public WithEvents Label9 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Public WithEvents restart As Button
End Class
