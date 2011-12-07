<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits SwdevIUI.PageTemplate

    'UserControl overrides dispose to clean up the component list.
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
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Me.lblClock = New gLabel.gLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.linkStartStop = New System.Windows.Forms.LinkLabel()
        Me.linkPause = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClock
        '
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.BorderWidth = 1.0!
        Me.lblClock.FillType = gLabel.gLabel.eFillType.Solid
        Me.lblClock.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.lblClock.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.SystemColors.Control
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.lblClock.ForeColorBlend = CBlendItems1
        Me.lblClock.Glow = 12
        Me.lblClock.GlowColor = System.Drawing.Color.Red
        Me.lblClock.Location = New System.Drawing.Point(101, 348)
        Me.lblClock.MouseOver = False
        Me.lblClock.MouseOverColor = System.Drawing.Color.Gray
        Me.lblClock.Name = "lblClock"
        Me.lblClock.PulseSpeed = 100
        Me.lblClock.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.lblClock.Size = New System.Drawing.Size(387, 108)
        Me.lblClock.TabIndex = 29
        Me.lblClock.TabStop = True
        Me.lblClock.Text = "00:00:00"
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'linkStartStop
        '
        Me.linkStartStop.AutoSize = True
        Me.linkStartStop.Location = New System.Drawing.Point(6, 11)
        Me.linkStartStop.Name = "linkStartStop"
        Me.linkStartStop.Size = New System.Drawing.Size(29, 13)
        Me.linkStartStop.TabIndex = 30
        Me.linkStartStop.TabStop = True
        Me.linkStartStop.Text = "Start"
        '
        'linkPause
        '
        Me.linkPause.AutoSize = True
        Me.linkPause.Location = New System.Drawing.Point(6, 37)
        Me.linkPause.Name = "linkPause"
        Me.linkPause.Size = New System.Drawing.Size(37, 13)
        Me.linkPause.TabIndex = 31
        Me.linkPause.TabStop = True
        Me.linkPause.Text = "Pause"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PersonalCapoeiraWorksheet.My.Resources.Resources.eko
        Me.PictureBox1.Location = New System.Drawing.Point(98, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 333)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.linkPause)
        Me.Controls.Add(Me.linkStartStop)
        Me.ImageTitle = Global.PersonalCapoeiraWorksheet.My.Resources.Resources.home
        Me.Name = "HomePage"
        Me.Size = New System.Drawing.Size(528, 463)
        Me.Title = "Salve!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClock As gLabel.gLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents linkStartStop As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPause As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
