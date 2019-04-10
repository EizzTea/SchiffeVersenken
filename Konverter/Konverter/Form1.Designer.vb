<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbIp = New System.Windows.Forms.Label()
        Me.lbConv = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbIp
        '
        Me.lbIp.AutoSize = True
        Me.lbIp.Location = New System.Drawing.Point(77, 29)
        Me.lbIp.Name = "lbIp"
        Me.lbIp.Size = New System.Drawing.Size(39, 13)
        Me.lbIp.TabIndex = 0
        Me.lbIp.Text = "Label1"
        '
        'lbConv
        '
        Me.lbConv.AutoSize = True
        Me.lbConv.Location = New System.Drawing.Point(77, 84)
        Me.lbConv.Name = "lbConv"
        Me.lbConv.Size = New System.Drawing.Size(39, 13)
        Me.lbConv.TabIndex = 1
        Me.lbConv.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(80, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbConv)
        Me.Controls.Add(Me.lbIp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbIp As System.Windows.Forms.Label
    Friend WithEvents lbConv As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
