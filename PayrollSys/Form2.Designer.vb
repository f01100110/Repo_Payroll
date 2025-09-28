<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.toolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.toolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.toolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.toolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.toolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.toolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.toolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.panel1.SuspendLayout()
        Me.toolStrip3.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel1.AutoSize = True
        Me.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.toolStrip3)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.panel1.Location = New System.Drawing.Point(59, 63)
        Me.panel1.Margin = New System.Windows.Forms.Padding(50)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(40)
        Me.panel1.Size = New System.Drawing.Size(757, 439)
        Me.panel1.TabIndex = 11
        Me.panel1.UseWaitCursor = True
        '
        'panel2
        '
        Me.panel2.Location = New System.Drawing.Point(310, 156)
        Me.panel2.Name = "panel2"
        Me.panel2.Padding = New System.Windows.Forms.Padding(20)
        Me.panel2.Size = New System.Drawing.Size(404, 240)
        Me.panel2.TabIndex = 3
        Me.panel2.UseWaitCursor = True
        '
        'toolStrip3
        '
        Me.toolStrip3.AutoSize = False
        Me.toolStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel4, Me.toolStripLabel1, Me.toolStripLabel5, Me.toolStripLabel6})
        Me.toolStrip3.Location = New System.Drawing.Point(40, 40)
        Me.toolStrip3.Name = "toolStrip3"
        Me.toolStrip3.Padding = New System.Windows.Forms.Padding(5)
        Me.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.toolStrip3.Size = New System.Drawing.Size(677, 76)
        Me.toolStrip3.TabIndex = 4
        Me.toolStrip3.UseWaitCursor = True
        '
        'toolStripLabel4
        '
        Me.toolStripLabel4.BackColor = System.Drawing.Color.Transparent
        Me.toolStripLabel4.Font = New System.Drawing.Font("Curlz MT", 12.0!)
        Me.toolStripLabel4.Image = CType(resources.GetObject("toolStripLabel4.Image"), System.Drawing.Image)
        Me.toolStripLabel4.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.toolStripLabel4.Name = "toolStripLabel4"
        Me.toolStripLabel4.Size = New System.Drawing.Size(80, 66)
        Me.toolStripLabel4.Text = "Attendance"
        Me.toolStripLabel4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripLabel1
        '
        Me.toolStripLabel1.Font = New System.Drawing.Font("Curlz MT", 12.0!)
        Me.toolStripLabel1.Image = CType(resources.GetObject("toolStripLabel1.Image"), System.Drawing.Image)
        Me.toolStripLabel1.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.toolStripLabel1.Name = "toolStripLabel1"
        Me.toolStripLabel1.Size = New System.Drawing.Size(70, 66)
        Me.toolStripLabel1.Text = "Employee"
        Me.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripLabel5
        '
        Me.toolStripLabel5.Font = New System.Drawing.Font("Curlz MT", 12.0!)
        Me.toolStripLabel5.Image = CType(resources.GetObject("toolStripLabel5.Image"), System.Drawing.Image)
        Me.toolStripLabel5.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.toolStripLabel5.Name = "toolStripLabel5"
        Me.toolStripLabel5.Size = New System.Drawing.Size(51, 66)
        Me.toolStripLabel5.Text = "Payslip"
        Me.toolStripLabel5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripLabel6
        '
        Me.toolStripLabel6.Font = New System.Drawing.Font("Curlz MT", 12.0!)
        Me.toolStripLabel6.Image = CType(resources.GetObject("toolStripLabel6.Image"), System.Drawing.Image)
        Me.toolStripLabel6.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.toolStripLabel6.Name = "toolStripLabel6"
        Me.toolStripLabel6.Size = New System.Drawing.Size(53, 66)
        Me.toolStripLabel6.Text = "Logout"
        Me.toolStripLabel6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Image = Global.PayrollSys.My.Resources.Resources.download__3_
        Me.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.pictureBox1.Location = New System.Drawing.Point(43, 156)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(240, 240)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 2
        Me.pictureBox1.TabStop = False
        Me.pictureBox1.UseWaitCursor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Curlz MT", 26.25!, System.Drawing.FontStyle.Bold)
        Me.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.label2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.label2.Location = New System.Drawing.Point(224, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 46)
        Me.label2.TabIndex = 1
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.label2.UseWaitCursor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Curlz MT", 32.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.label1.Location = New System.Drawing.Point(8, -40)
        Me.label1.Margin = New System.Windows.Forms.Padding(3)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label1.Size = New System.Drawing.Size(0, 57)
        Me.label1.TabIndex = 0
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label1.UseWaitCursor = True
        '
        'toolStrip2
        '
        Me.toolStrip2.GripMargin = New System.Windows.Forms.Padding(0)
        Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton3, Me.toolStripDropDownButton4})
        Me.toolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip2.Margin = New System.Windows.Forms.Padding(50)
        Me.toolStrip2.Name = "toolStrip2"
        Me.toolStrip2.Padding = New System.Windows.Forms.Padding(0)
        Me.toolStrip2.Size = New System.Drawing.Size(884, 25)
        Me.toolStrip2.TabIndex = 12
        Me.toolStrip2.Text = "toolStrip2"
        Me.toolStrip2.UseWaitCursor = True
        '
        'toolStripDropDownButton3
        '
        Me.toolStripDropDownButton3.Font = New System.Drawing.Font("Curlz MT", 9.75!)
        Me.toolStripDropDownButton3.Image = CType(resources.GetObject("toolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.toolStripDropDownButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.toolStripDropDownButton3.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.toolStripDropDownButton3.MergeIndex = 50
        Me.toolStripDropDownButton3.Name = "toolStripDropDownButton3"
        Me.toolStripDropDownButton3.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.toolStripDropDownButton3.Size = New System.Drawing.Size(93, 25)
        Me.toolStripDropDownButton3.Text = "Employee"
        '
        'toolStripDropDownButton4
        '
        Me.toolStripDropDownButton4.Font = New System.Drawing.Font("Curlz MT", 9.75!)
        Me.toolStripDropDownButton4.Image = CType(resources.GetObject("toolStripDropDownButton4.Image"), System.Drawing.Image)
        Me.toolStripDropDownButton4.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.toolStripDropDownButton4.Name = "toolStripDropDownButton4"
        Me.toolStripDropDownButton4.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.toolStripDropDownButton4.Size = New System.Drawing.Size(122, 25)
        Me.toolStripDropDownButton4.Text = "Search Records"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PayrollSys.My.Resources.Resources.NicePng_girl_birthday_frame_png_3674469
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.toolStrip2)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "Dashboard"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.toolStrip3.ResumeLayout(False)
        Me.toolStrip3.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStrip2.ResumeLayout(False)
        Me.toolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents panel2 As Panel
    Private WithEvents toolStrip3 As ToolStrip
    Private WithEvents toolStripLabel4 As ToolStripLabel
    Private WithEvents toolStripLabel1 As ToolStripLabel
    Private WithEvents toolStripLabel5 As ToolStripLabel
    Private WithEvents toolStripLabel6 As ToolStripLabel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents toolStrip2 As ToolStrip
    Private WithEvents toolStripDropDownButton3 As ToolStripDropDownButton
    Private WithEvents toolStripDropDownButton4 As ToolStripDropDownButton
End Class
