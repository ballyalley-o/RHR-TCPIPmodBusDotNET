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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblValueIS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblValueCS = New System.Windows.Forms.Label()
        Me.btnWSR = New System.Windows.Forms.Button()
        Me.txtRegVal = New System.Windows.Forms.TextBox()
        Me.txtCoilVal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtGrpxIS = New System.Windows.Forms.TextBox()
        Me.txtGrpxCS = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.prbgGrpxIR = New System.Windows.Forms.ProgressBar()
        Me.lblValueHR = New System.Windows.Forms.Label()
        Me.lblValueIR = New System.Windows.Forms.Label()
        Me.prbgGrpxHR = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HR Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "IR Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "IS Value"
        '
        'lblValueIS
        '
        Me.lblValueIS.AutoSize = True
        Me.lblValueIS.BackColor = System.Drawing.SystemColors.Control
        Me.lblValueIS.ForeColor = System.Drawing.SystemColors.Info
        Me.lblValueIS.Location = New System.Drawing.Point(247, 281)
        Me.lblValueIS.Name = "lblValueIS"
        Me.lblValueIS.Size = New System.Drawing.Size(13, 13)
        Me.lblValueIS.TabIndex = 6
        Me.lblValueIS.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CS Value"
        '
        'lblValueCS
        '
        Me.lblValueCS.AutoSize = True
        Me.lblValueCS.ForeColor = System.Drawing.SystemColors.Info
        Me.lblValueCS.Location = New System.Drawing.Point(247, 317)
        Me.lblValueCS.Name = "lblValueCS"
        Me.lblValueCS.Size = New System.Drawing.Size(13, 13)
        Me.lblValueCS.TabIndex = 8
        Me.lblValueCS.Text = "0"
        '
        'btnWSR
        '
        Me.btnWSR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnWSR.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWSR.ForeColor = System.Drawing.SystemColors.Info
        Me.btnWSR.Location = New System.Drawing.Point(45, 365)
        Me.btnWSR.Name = "btnWSR"
        Me.btnWSR.Size = New System.Drawing.Size(127, 23)
        Me.btnWSR.TabIndex = 9
        Me.btnWSR.Text = "Write Single Register"
        Me.btnWSR.UseVisualStyleBackColor = False
        '
        'txtRegVal
        '
        Me.txtRegVal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtRegVal.ForeColor = System.Drawing.SystemColors.Menu
        Me.txtRegVal.Location = New System.Drawing.Point(221, 367)
        Me.txtRegVal.Name = "txtRegVal"
        Me.txtRegVal.Size = New System.Drawing.Size(79, 20)
        Me.txtRegVal.TabIndex = 10
        '
        'txtCoilVal
        '
        Me.txtCoilVal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCoilVal.ForeColor = System.Drawing.SystemColors.Info
        Me.txtCoilVal.Location = New System.Drawing.Point(221, 411)
        Me.txtCoilVal.Multiline = True
        Me.txtCoilVal.Name = "txtCoilVal"
        Me.txtCoilVal.Size = New System.Drawing.Size(79, 20)
        Me.txtCoilVal.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(45, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Write Single Coil"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtGrpxIS
        '
        Me.txtGrpxIS.Location = New System.Drawing.Point(221, 278)
        Me.txtGrpxIS.Name = "txtGrpxIS"
        Me.txtGrpxIS.Size = New System.Drawing.Size(79, 20)
        Me.txtGrpxIS.TabIndex = 13
        '
        'txtGrpxCS
        '
        Me.txtGrpxCS.Location = New System.Drawing.Point(221, 314)
        Me.txtGrpxCS.Name = "txtGrpxCS"
        Me.txtGrpxCS.Size = New System.Drawing.Size(79, 20)
        Me.txtGrpxCS.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(149, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 49)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 30)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Mod Freq"
        '
        'prbgGrpxIR
        '
        Me.prbgGrpxIR.Location = New System.Drawing.Point(221, 236)
        Me.prbgGrpxIR.Name = "prbgGrpxIR"
        Me.prbgGrpxIR.Size = New System.Drawing.Size(79, 23)
        Me.prbgGrpxIR.TabIndex = 17
        '
        'lblValueHR
        '
        Me.lblValueHR.AutoSize = True
        Me.lblValueHR.BackColor = System.Drawing.SystemColors.Control
        Me.lblValueHR.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblValueHR.Location = New System.Drawing.Point(267, 198)
        Me.lblValueHR.Name = "lblValueHR"
        Me.lblValueHR.Size = New System.Drawing.Size(18, 18)
        Me.lblValueHR.TabIndex = 1
        Me.lblValueHR.Text = "0"
        '
        'lblValueIR
        '
        Me.lblValueIR.AutoSize = True
        Me.lblValueIR.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueIR.Location = New System.Drawing.Point(267, 241)
        Me.lblValueIR.Name = "lblValueIR"
        Me.lblValueIR.Size = New System.Drawing.Size(18, 18)
        Me.lblValueIR.TabIndex = 2
        Me.lblValueIR.Text = "0"
        '
        'prbgGrpxHR
        '
        Me.prbgGrpxHR.Location = New System.Drawing.Point(221, 193)
        Me.prbgGrpxHR.Name = "prbgGrpxHR"
        Me.prbgGrpxHR.Size = New System.Drawing.Size(79, 23)
        Me.prbgGrpxHR.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 491)
        Me.Controls.Add(Me.prbgGrpxHR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCoilVal)
        Me.Controls.Add(Me.txtRegVal)
        Me.Controls.Add(Me.btnWSR)
        Me.Controls.Add(Me.lblValueCS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblValueIS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblValueHR)
        Me.Controls.Add(Me.txtGrpxIS)
        Me.Controls.Add(Me.txtGrpxCS)
        Me.Controls.Add(Me.prbgGrpxIR)
        Me.Controls.Add(Me.lblValueIR)
        Me.Name = "Form1"
        Me.Text = "Mod Freq"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblValueIS As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblValueCS As Label
    Friend WithEvents btnWSR As Button
    Friend WithEvents txtRegVal As TextBox
    Friend WithEvents txtCoilVal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtGrpxIS As TextBox
    Friend WithEvents txtGrpxCS As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents prbgGrpxIR As ProgressBar
    Friend WithEvents lblValueHR As Label
    Friend WithEvents lblValueIR As Label
    Friend WithEvents prbgGrpxHR As ProgressBar
End Class
