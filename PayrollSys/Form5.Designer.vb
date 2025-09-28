<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.button6 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel5.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.Firebrick
        Me.button6.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button6.Location = New System.Drawing.Point(739, 515)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(81, 31)
        Me.button6.TabIndex = 5
        Me.button6.Text = "Logout"
        Me.button6.UseVisualStyleBackColor = False
        Me.button6.UseWaitCursor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Curlz MT", 26.25!, System.Drawing.FontStyle.Bold)
        Me.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.label2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.label2.Location = New System.Drawing.Point(209, 0)
        Me.label2.Name = "label2"
        Me.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label2.Size = New System.Drawing.Size(338, 46)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Attendance Log Entry"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label2.UseWaitCursor = True
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.button2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.button2.Location = New System.Drawing.Point(292, 70)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(250, 55)
        Me.button2.TabIndex = 11
        Me.button2.Text = "Time-Out"
        Me.button2.UseVisualStyleBackColor = False
        Me.button2.UseWaitCursor = True
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.button1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.button1.Location = New System.Drawing.Point(43, 70)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(250, 55)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Time-In"
        Me.button1.UseVisualStyleBackColor = False
        Me.button1.UseWaitCursor = True
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.label10.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.label10.Location = New System.Drawing.Point(45, 28)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(88, 16)
        Me.label10.TabIndex = 9
        Me.label10.Text = "Employee ID:"
        Me.label10.UseWaitCursor = True
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Curlz MT", 11.25!)
        Me.textBox1.Location = New System.Drawing.Point(139, 23)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(238, 26)
        Me.textBox1.TabIndex = 1
        Me.textBox1.UseWaitCursor = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Time- Out"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Time-In"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Log Date"
        Me.Column1.Name = "Column1"
        '
        'Name
        '
        Me.Name.HeaderText = "ID"
        Me.Name.Name = "Name"
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name, Me.Column1, Me.Column2, Me.Column3})
        Me.dataGridView1.Location = New System.Drawing.Point(42, 131)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(500, 237)
        Me.dataGridView1.TabIndex = 12
        Me.dataGridView1.UseWaitCursor = True
        '
        'panel2
        '
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel2.Controls.Add(Me.dataGridView1)
        Me.panel2.Controls.Add(Me.button2)
        Me.panel2.Controls.Add(Me.button1)
        Me.panel2.Controls.Add(Me.label10)
        Me.panel2.Controls.Add(Me.textBox1)
        Me.panel2.Location = New System.Drawing.Point(165, 49)
        Me.panel2.Name = "panel2"
        Me.panel2.Padding = New System.Windows.Forms.Padding(40, 20, 40, 20)
        Me.panel2.Size = New System.Drawing.Size(589, 395)
        Me.panel2.TabIndex = 3
        Me.panel2.UseWaitCursor = True
        '
        'button4
        '
        Me.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button4.FlatAppearance.BorderSize = 0
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline)
        Me.button4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.button4.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.button4.Location = New System.Drawing.Point(41, 277)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(81, 31)
        Me.button4.TabIndex = 14
        Me.button4.Text = "Settings"
        Me.button4.UseVisualStyleBackColor = True
        Me.button4.UseWaitCursor = True
        '
        'button3
        '
        Me.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline)
        Me.button3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.button3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.button3.Location = New System.Drawing.Point(35, 233)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(91, 31)
        Me.button3.TabIndex = 13
        Me.button3.Text = "Attendance"
        Me.button3.UseVisualStyleBackColor = True
        Me.button3.UseWaitCursor = True
        '
        'button8
        '
        Me.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.button8.FlatAppearance.BorderSize = 0
        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline)
        Me.button8.ForeColor = System.Drawing.SystemColors.MenuText
        Me.button8.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.button8.Location = New System.Drawing.Point(41, 189)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(81, 31)
        Me.button8.TabIndex = 12
        Me.button8.Text = "Profile"
        Me.button8.UseVisualStyleBackColor = True
        Me.button8.UseWaitCursor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Image = Global.PayrollSys.My.Resources.Resources.download__3_
        Me.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.pictureBox1.Location = New System.Drawing.Point(-2, -3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(159, 159)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 2
        Me.pictureBox1.TabStop = False
        Me.pictureBox1.UseWaitCursor = True
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.Black
        Me.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button5.Font = New System.Drawing.Font("Curlz MT", 11.25!)
        Me.button5.ForeColor = System.Drawing.Color.White
        Me.button5.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.button5.Location = New System.Drawing.Point(297, 194)
        Me.button5.Margin = New System.Windows.Forms.Padding(0)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(84, 26)
        Me.button5.TabIndex = 7
        Me.button5.Text = "Exit"
        Me.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button5.UseVisualStyleBackColor = False
        Me.button5.UseWaitCursor = True
        '
        'panel5
        '
        Me.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel5.Controls.Add(Me.button4)
        Me.panel5.Controls.Add(Me.button3)
        Me.panel5.Controls.Add(Me.button8)
        Me.panel5.Controls.Add(Me.pictureBox1)
        Me.panel5.Controls.Add(Me.button5)
        Me.panel5.Location = New System.Drawing.Point(0, 49)
        Me.panel5.Name = "panel5"
        Me.panel5.Padding = New System.Windows.Forms.Padding(30, 20, 30, 20)
        Me.panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.panel5.Size = New System.Drawing.Size(159, 395)
        Me.panel5.TabIndex = 13
        Me.panel5.UseWaitCursor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Curlz MT", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label1.Location = New System.Drawing.Point(174, 12)
        Me.label1.Margin = New System.Windows.Forms.Padding(3)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label1.Size = New System.Drawing.Size(529, 44)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Infotech College of Arts and Sciences"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.label1.UseWaitCursor = True
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.AutoSize = True
        Me.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.panel5)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.panel1.Location = New System.Drawing.Point(64, 65)
        Me.panel1.Margin = New System.Windows.Forms.Padding(50)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(40, 40, 0, 0)
        Me.panel1.Size = New System.Drawing.Size(757, 447)
        Me.panel1.TabIndex = 3
        Me.panel1.UseWaitCursor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PayrollSys.My.Resources.Resources.NicePng_girl_birthday_frame_png_3674469
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.panel1)
        Me.DoubleBuffered = True
        Me.Name = "Form5"
        Me.Text = "Attendance Log Entry"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel5.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button6 As Button
    Private WithEvents label2 As Label
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents label10 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Name As DataGridViewTextBoxColumn
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents panel2 As Panel
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button8 As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button5 As Button
    Private WithEvents panel5 As Panel
    Private WithEvents label1 As Label
    Private WithEvents panel1 As Panel
End Class
