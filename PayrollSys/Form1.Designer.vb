<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.maskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel1.AutoSize = True
        Me.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.panel1.Location = New System.Drawing.Point(59, 61)
        Me.panel1.Margin = New System.Windows.Forms.Padding(50)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(40)
        Me.panel1.Size = New System.Drawing.Size(767, 439)
        Me.panel1.TabIndex = 1
        Me.panel1.UseWaitCursor = True
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.Plum
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel2.Controls.Add(Me.maskedTextBox1)
        Me.panel2.Controls.Add(Me.button2)
        Me.panel2.Controls.Add(Me.button1)
        Me.panel2.Controls.Add(Me.label5)
        Me.panel2.Controls.Add(Me.label4)
        Me.panel2.Controls.Add(Me.chkShowPassword)
        Me.panel2.Controls.Add(Me.textBox1)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panel2.Location = New System.Drawing.Point(310, 156)
        Me.panel2.Name = "panel2"
        Me.panel2.Padding = New System.Windows.Forms.Padding(20)
        Me.panel2.Size = New System.Drawing.Size(404, 240)
        Me.panel2.TabIndex = 3
        Me.panel2.UseWaitCursor = True
        '
        'maskedTextBox1
        '
        Me.maskedTextBox1.Location = New System.Drawing.Point(143, 109)
        Me.maskedTextBox1.Name = "maskedTextBox1"
        Me.maskedTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.maskedTextBox1.Size = New System.Drawing.Size(238, 20)
        Me.maskedTextBox1.TabIndex = 8
        Me.maskedTextBox1.UseWaitCursor = True
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Curlz MT", 11.25!)
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.button2.Location = New System.Drawing.Point(297, 186)
        Me.button2.Margin = New System.Windows.Forms.Padding(0)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(84, 34)
        Me.button2.TabIndex = 7
        Me.button2.Text = "Sign up"
        Me.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button2.UseVisualStyleBackColor = False
        Me.button2.UseWaitCursor = True
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Curlz MT", 11.25!)
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.button1.Location = New System.Drawing.Point(143, 186)
        Me.button1.Margin = New System.Windows.Forms.Padding(0)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(84, 34)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Login"
        Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button1.UseVisualStyleBackColor = False
        Me.button1.UseWaitCursor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Curlz MT", 15.75!, System.Drawing.FontStyle.Bold)
        Me.label5.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.label5.Location = New System.Drawing.Point(23, 101)
        Me.label5.Margin = New System.Windows.Forms.Padding(0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(93, 28)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Password"
        Me.label5.UseWaitCursor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Curlz MT", 15.75!, System.Drawing.FontStyle.Bold)
        Me.label4.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.label4.Location = New System.Drawing.Point(23, 47)
        Me.label4.Margin = New System.Windows.Forms.Padding(0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 28)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Username"
        Me.label4.UseWaitCursor = True
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Curlz MT", 11.25!, System.Drawing.FontStyle.Italic)
        Me.chkShowPassword.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.chkShowPassword.Location = New System.Drawing.Point(143, 135)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(117, 23)
        Me.chkShowPassword.TabIndex = 3
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        Me.chkShowPassword.UseWaitCursor = True
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Curlz MT", 11.25!)
        Me.textBox1.Location = New System.Drawing.Point(143, 55)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(238, 20)
        Me.textBox1.TabIndex = 1
        Me.textBox1.UseWaitCursor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Curlz MT", 11.25!)
        Me.label3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.label3.Location = New System.Drawing.Point(-4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(109, 19)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Please, login first."
        Me.label3.UseWaitCursor = True
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
        Me.label2.Location = New System.Drawing.Point(264, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(230, 46)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Payroll System"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.label2.UseWaitCursor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Curlz MT", 32.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.label1.Location = New System.Drawing.Point(48, 0)
        Me.label1.Margin = New System.Windows.Forms.Padding(3)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label1.Size = New System.Drawing.Size(676, 57)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Infotech College of Arts and Sciences"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label1.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PayrollSys.My.Resources.Resources.NicePng_girl_birthday_frame_png_3674469
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.panel1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Opacity = 0.2R
        Me.Text = "Login"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents panel2 As Panel
    Private WithEvents maskedTextBox1 As MaskedTextBox
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents chkShowPassword As CheckBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
