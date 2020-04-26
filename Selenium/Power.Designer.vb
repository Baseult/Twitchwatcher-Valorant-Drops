<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Power
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Power))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Startbutton = New System.Windows.Forms.Button()
        Me.Stopbutton = New System.Windows.Forms.Button()
        Me.Nextbutton = New System.Windows.Forms.Button()
        Me.Chromebox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Firefoxbox = New System.Windows.Forms.CheckBox()
        Me.Remainingtime = New System.Windows.Forms.Label()
        Me.Watchertime = New System.Windows.Forms.Label()
        Me.Dropfound = New System.Windows.Forms.Label()
        Me.Timertext = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker5 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker6 = New System.ComponentModel.BackgroundWorker()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(234, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(76, 276)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(485, 86)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Twitchbot by Baseult" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Startbutton
        '
        Me.Startbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Startbutton.BackgroundImage = Global.Twitchbot.My.Resources.Resources.abstract_digital_art_3d_abstract_lines_wallpaper
        Me.Startbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Startbutton.Font = New System.Drawing.Font("Impact", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Startbutton.ForeColor = System.Drawing.Color.White
        Me.Startbutton.Location = New System.Drawing.Point(251, 125)
        Me.Startbutton.Name = "Startbutton"
        Me.Startbutton.Size = New System.Drawing.Size(132, 87)
        Me.Startbutton.TabIndex = 0
        Me.Startbutton.Text = "START"
        Me.Startbutton.UseVisualStyleBackColor = False
        '
        'Stopbutton
        '
        Me.Stopbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Stopbutton.BackgroundImage = Global.Twitchbot.My.Resources.Resources.abstract_digital_art_3d_abstract_lines_wallpaper
        Me.Stopbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Stopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Stopbutton.Font = New System.Drawing.Font("Impact", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Stopbutton.ForeColor = System.Drawing.Color.White
        Me.Stopbutton.Location = New System.Drawing.Point(251, 125)
        Me.Stopbutton.Name = "Stopbutton"
        Me.Stopbutton.Size = New System.Drawing.Size(132, 87)
        Me.Stopbutton.TabIndex = 28
        Me.Stopbutton.Text = "STOP"
        Me.Stopbutton.UseMnemonic = False
        Me.Stopbutton.UseVisualStyleBackColor = False
        '
        'Nextbutton
        '
        Me.Nextbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Nextbutton.BackgroundImage = Global.Twitchbot.My.Resources.Resources.abstract_digital_art_3d_abstract_lines_wallpaper
        Me.Nextbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nextbutton.Font = New System.Drawing.Font("Impact", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Nextbutton.ForeColor = System.Drawing.Color.White
        Me.Nextbutton.Location = New System.Drawing.Point(441, 125)
        Me.Nextbutton.Name = "Nextbutton"
        Me.Nextbutton.Size = New System.Drawing.Size(132, 87)
        Me.Nextbutton.TabIndex = 29
        Me.Nextbutton.Text = "NEXT"
        Me.Nextbutton.UseVisualStyleBackColor = False
        '
        'Chromebox
        '
        Me.Chromebox.AutoSize = True
        Me.Chromebox.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Chromebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chromebox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Chromebox.Location = New System.Drawing.Point(42, 135)
        Me.Chromebox.Name = "Chromebox"
        Me.Chromebox.Size = New System.Drawing.Size(161, 22)
        Me.Chromebox.TabIndex = 60
        Me.Chromebox.Text = "Use GoogleChrome"
        Me.Chromebox.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(88, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "<- or ->"
        '
        'Firefoxbox
        '
        Me.Firefoxbox.AutoSize = True
        Me.Firefoxbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Firefoxbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firefoxbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Firefoxbox.Location = New System.Drawing.Point(61, 183)
        Me.Firefoxbox.Name = "Firefoxbox"
        Me.Firefoxbox.Size = New System.Drawing.Size(108, 22)
        Me.Firefoxbox.TabIndex = 61
        Me.Firefoxbox.Text = "Use FireFox"
        Me.Firefoxbox.UseVisualStyleBackColor = False
        '
        'Remainingtime
        '
        Me.Remainingtime.AutoSize = True
        Me.Remainingtime.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Remainingtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Remainingtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remainingtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Remainingtime.Location = New System.Drawing.Point(171, 44)
        Me.Remainingtime.Name = "Remainingtime"
        Me.Remainingtime.Size = New System.Drawing.Size(162, 20)
        Me.Remainingtime.TabIndex = 36
        Me.Remainingtime.Text = "Valorant Drop Found:"
        '
        'Watchertime
        '
        Me.Watchertime.AutoSize = True
        Me.Watchertime.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Watchertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Watchertime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Watchertime.Location = New System.Drawing.Point(171, 9)
        Me.Watchertime.Name = "Watchertime"
        Me.Watchertime.Size = New System.Drawing.Size(257, 20)
        Me.Watchertime.TabIndex = 14
        Me.Watchertime.Text = "Remaining watchtime on Streamer:"
        Me.Watchertime.Visible = False
        '
        'Dropfound
        '
        Me.Dropfound.AutoSize = True
        Me.Dropfound.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Dropfound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dropfound.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dropfound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dropfound.Location = New System.Drawing.Point(335, 44)
        Me.Dropfound.Name = "Dropfound"
        Me.Dropfound.Size = New System.Drawing.Size(126, 20)
        Me.Dropfound.TabIndex = 37
        Me.Dropfound.Text = "Not Checked yet"
        '
        'Timertext
        '
        Me.Timertext.AutoSize = True
        Me.Timertext.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Timertext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timertext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Timertext.Location = New System.Drawing.Point(434, 9)
        Me.Timertext.Name = "Timertext"
        Me.Timertext.Size = New System.Drawing.Size(27, 20)
        Me.Timertext.TabIndex = 66
        Me.Timertext.Text = "10"
        Me.Timertext.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Twitchbot.My.Resources.Resources.close_circle_red_512
        Me.PictureBox2.Location = New System.Drawing.Point(603, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'BackgroundWorker3
        '
        Me.BackgroundWorker3.WorkerReportsProgress = True
        Me.BackgroundWorker3.WorkerSupportsCancellation = True
        '
        'BackgroundWorker4
        '
        Me.BackgroundWorker4.WorkerReportsProgress = True
        Me.BackgroundWorker4.WorkerSupportsCancellation = True
        '
        'BackgroundWorker5
        '
        Me.BackgroundWorker5.WorkerReportsProgress = True
        Me.BackgroundWorker5.WorkerSupportsCancellation = True
        '
        'BackgroundWorker6
        '
        Me.BackgroundWorker6.WorkerReportsProgress = True
        Me.BackgroundWorker6.WorkerSupportsCancellation = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 10000
        '
        'Timer2
        '
        '
        'Timer1
        '
        '
        'Timer5
        '
        Me.Timer5.Interval = 120000
        '
        'Power
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(636, 368)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Timertext)
        Me.Controls.Add(Me.Firefoxbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Startbutton)
        Me.Controls.Add(Me.Nextbutton)
        Me.Controls.Add(Me.Chromebox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Dropfound)
        Me.Controls.Add(Me.Stopbutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Remainingtime)
        Me.Controls.Add(Me.Watchertime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Power"
        Me.Text = "Power"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Startbutton As Button
    Friend WithEvents Stopbutton As Button
    Friend WithEvents Nextbutton As Button
    Friend WithEvents Chromebox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Firefoxbox As CheckBox
    Friend WithEvents Remainingtime As Label
    Friend WithEvents Watchertime As Label
    Friend WithEvents Dropfound As Label
    Friend WithEvents Timertext As Label
    Friend WithEvents PictureBox2 As PictureBox
    Public WithEvents TextBox1 As TextBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker6 As System.ComponentModel.BackgroundWorker
    Public WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer5 As Timer
End Class
