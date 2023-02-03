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
        Me.btnRHR = New System.Windows.Forms.Button()
        Me.lblValueHR = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblValueIR = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblValueIS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRHR
        '
        Me.btnRHR.Location = New System.Drawing.Point(46, 363)
        Me.btnRHR.Name = "btnRHR"
        Me.btnRHR.Size = New System.Drawing.Size(256, 23)
        Me.btnRHR.TabIndex = 0
        Me.btnRHR.Text = "Read Holding Register TCPIP"
        Me.btnRHR.UseVisualStyleBackColor = True
        '
        'lblValueHR
        '
        Me.lblValueHR.AutoSize = True
        Me.lblValueHR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblValueHR.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblValueHR.Location = New System.Drawing.Point(289, 112)
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
        Me.lblValueIR.Location = New System.Drawing.Point(289, 153)
        Me.lblValueIR.Name = "lblValueIR"
        Me.lblValueIR.Size = New System.Drawing.Size(13, 13)
        Me.lblValueIR.TabIndex = 2
        Me.lblValueIR.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HR Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "IR Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "IS Value"
        '
        'lblValueIS
        '
        Me.lblValueIS.AutoSize = True
        Me.lblValueIS.Location = New System.Drawing.Point(289, 192)
        Me.lblValueIS.Name = "lblValueIS"
        Me.lblValueIS.Size = New System.Drawing.Size(13, 13)
        Me.lblValueIS.TabIndex = 6
        Me.lblValueIS.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 450)
        Me.Controls.Add(Me.lblValueIS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblValueIR)
        Me.Controls.Add(Me.lblValueHR)
        Me.Controls.Add(Me.btnRHR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRHR As Button
    Friend WithEvents lblValueHR As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblValueIR As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblValueIS As Label
End Class
