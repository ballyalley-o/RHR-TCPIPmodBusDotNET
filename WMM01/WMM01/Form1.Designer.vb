<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnRHR = New System.Windows.Forms.Button()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRHR
        '
        Me.btnRHR.Location = New System.Drawing.Point(61, 39)
        Me.btnRHR.Name = "btnRHR"
        Me.btnRHR.Size = New System.Drawing.Size(277, 23)
        Me.btnRHR.TabIndex = 2
        Me.btnRHR.Text = "Read Holding Register TCPIP"
        Me.btnRHR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnRHR.UseVisualStyleBackColor = True
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(190, 148)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(13, 15)
        Me.lblValue.TabIndex = 3
        Me.lblValue.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 450)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.btnRHR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRHR As Button
    Friend WithEvents lblValue As Label
End Class
