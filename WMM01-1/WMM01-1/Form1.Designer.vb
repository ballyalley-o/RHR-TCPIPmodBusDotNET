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
        Me.lblValueHR = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblValueIR = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'lblValueHR
        '
        Me.lblValueHR.AutoSize = True
        Me.lblValueHR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblValueHR.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblValueHR.Location = New System.Drawing.Point(292, 59)
        Me.lblValueHR.Name = "lblValueHR"
        Me.lblValueHR.Size = New System.Drawing.Size(13, 13)
        Me.lblValueHR.TabIndex = 1
        Me.lblValueHR.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'lblValueIR
        '
        Me.lblValueIR.AutoSize = True
        Me.lblValueIR.Location = New System.Drawing.Point(292, 100)
        Me.lblValueIR.Name = "lblValueIR"
        Me.lblValueIR.Size = New System.Drawing.Size(13, 13)
        Me.lblValueIR.TabIndex = 2
        Me.lblValueIR.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HR Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "IR Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "IS Value"
        '
        'lblValueIS
        '
        Me.lblValueIS.AutoSize = True
        Me.lblValueIS.Location = New System.Drawing.Point(292, 139)
        Me.lblValueIS.Name = "lblValueIS"
        Me.lblValueIS.Size = New System.Drawing.Size(13, 13)
        Me.lblValueIS.TabIndex = 6
        Me.lblValueIS.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CS Value"
        '
        'lblValueCS
        '
        Me.lblValueCS.AutoSize = True
        Me.lblValueCS.Location = New System.Drawing.Point(292, 176)
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
        Me.btnWSR.Location = New System.Drawing.Point(49, 224)
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
        Me.txtRegVal.Location = New System.Drawing.Point(225, 226)
        Me.txtRegVal.Name = "txtRegVal"
        Me.txtRegVal.Size = New System.Drawing.Size(79, 20)
        Me.txtRegVal.TabIndex = 10
        '
        'txtCoilVal
        '
        Me.txtCoilVal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCoilVal.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCoilVal.Location = New System.Drawing.Point(225, 270)
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
        Me.Button1.Location = New System.Drawing.Point(49, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Write Single Coil"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 438)
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
        Me.Controls.Add(Me.lblValueIR)
        Me.Controls.Add(Me.lblValueHR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblValueHR As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblValueIR As Label
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
End Class
