Imports SwdevIUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Me.pnlUtama = New System.Windows.Forms.Panel()
        Me.breadCumb = New SwdevIUI.BreadCrumb()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.lblTitle = New gLabel.gLabel()
        Me.linkMax = New System.Windows.Forms.LinkLabel()
        Me.linkClose = New System.Windows.Forms.LinkLabel()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.linkLatestNews = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUtama
        '
        Me.pnlUtama.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUtama.AutoScroll = True
        Me.pnlUtama.BackColor = System.Drawing.Color.White
        Me.pnlUtama.Location = New System.Drawing.Point(12, 153)
        Me.pnlUtama.Margin = New System.Windows.Forms.Padding(15)
        Me.pnlUtama.Name = "pnlUtama"
        Me.pnlUtama.Size = New System.Drawing.Size(1095, 448)
        Me.pnlUtama.TabIndex = 25
        '
        'breadCumb
        '
        Me.breadCumb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.breadCumb.BackColor = System.Drawing.Color.Transparent
        Me.breadCumb.Location = New System.Drawing.Point(12, 120)
        Me.breadCumb.Name = "breadCumb"
        Me.breadCumb.Size = New System.Drawing.Size(1094, 28)
        Me.breadCumb.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMaximize)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.linkMax)
        Me.Panel1.Controls.Add(Me.linkClose)
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1119, 114)
        Me.Panel1.TabIndex = 22
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(931, 11)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(57, 32)
        Me.btnMinimize.TabIndex = 31
        Me.btnMinimize.Text = "Min"
        Me.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1057, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 32)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMaximize.Location = New System.Drawing.Point(994, 11)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(57, 32)
        Me.btnMaximize.TabIndex = 29
        Me.btnMaximize.Text = "Max"
        Me.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.BorderWidth = 1.0!
        Me.lblTitle.FillType = gLabel.gLabel.eFillType.Solid
        Me.lblTitle.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.lblTitle.ForeColorBlend = CBlendItems1
        Me.lblTitle.Glow = 12
        Me.lblTitle.GlowColor = System.Drawing.Color.Crimson
        Me.lblTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblTitle.MouseOver = False
        Me.lblTitle.MouseOverColor = System.Drawing.Color.Gray
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.PulseSpeed = 100
        Me.lblTitle.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.lblTitle.Size = New System.Drawing.Size(241, 34)
        Me.lblTitle.TabIndex = 28
        Me.lblTitle.TabStop = True
        Me.lblTitle.Text = "<diganti>"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linkMax
        '
        Me.linkMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkMax.AutoSize = True
        Me.linkMax.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkMax.LinkColor = System.Drawing.Color.White
        Me.linkMax.Location = New System.Drawing.Point(1073, 17)
        Me.linkMax.Name = "linkMax"
        Me.linkMax.Size = New System.Drawing.Size(16, 13)
        Me.linkMax.TabIndex = 27
        Me.linkMax.TabStop = True
        Me.linkMax.Text = "[ ]"
        '
        'linkClose
        '
        Me.linkClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkClose.AutoSize = True
        Me.linkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkClose.LinkColor = System.Drawing.Color.White
        Me.linkClose.Location = New System.Drawing.Point(1095, 17)
        Me.linkClose.Name = "linkClose"
        Me.linkClose.Size = New System.Drawing.Size(12, 13)
        Me.linkClose.TabIndex = 26
        Me.linkClose.TabStop = True
        Me.linkClose.Text = "x"
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Image = Global.PersonalCapoeiraWorksheet.My.Resources.Resources.left_arrow
        Me.btnPrev.Location = New System.Drawing.Point(53, 49)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(35, 36)
        Me.btnPrev.TabIndex = 24
        Me.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Image = Global.PersonalCapoeiraWorksheet.My.Resources.Resources.right_arrow
        Me.btnNext.Location = New System.Drawing.Point(94, 49)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(35, 36)
        Me.btnNext.TabIndex = 23
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Image = Global.PersonalCapoeiraWorksheet.My.Resources.Resources.home
        Me.btnHome.Location = New System.Drawing.Point(12, 49)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(35, 36)
        Me.btnHome.TabIndex = 22
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'linkLatestNews
        '
        Me.linkLatestNews.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.linkLatestNews.AutoSize = True
        Me.linkLatestNews.Location = New System.Drawing.Point(12, 616)
        Me.linkLatestNews.Name = "linkLatestNews"
        Me.linkLatestNews.Size = New System.Drawing.Size(209, 13)
        Me.linkLatestNews.TabIndex = 27
        Me.linkLatestNews.TabStop = True
        Me.linkLatestNews.Text = "Latest Capoeira Senzala Yogyakarta News"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1119, 640)
        Me.Controls.Add(Me.linkLatestNews)
        Me.Controls.Add(Me.breadCumb)
        Me.Controls.Add(Me.pnlUtama)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<< TITLE >>"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents linkMax As System.Windows.Forms.LinkLabel
    Friend WithEvents linkClose As System.Windows.Forms.LinkLabel
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents pnlUtama As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As gLabel.gLabel
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMaximize As System.Windows.Forms.Button
    'Friend WithEvents flatMenu As MenuControls.FlatMenuBar
    Friend WithEvents breadCumb As BreadCrumb
    Friend WithEvents linkLatestNews As System.Windows.Forms.LinkLabel
End Class
