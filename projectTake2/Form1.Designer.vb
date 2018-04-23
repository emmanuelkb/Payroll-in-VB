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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.staffButton = New System.Windows.Forms.Button()
        Me.adminButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'staffButton
        '
        Me.staffButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.staffButton.Location = New System.Drawing.Point(88, 56)
        Me.staffButton.Name = "staffButton"
        Me.staffButton.Size = New System.Drawing.Size(115, 60)
        Me.staffButton.TabIndex = 0
        Me.staffButton.Text = "View Payslip"
        Me.staffButton.UseVisualStyleBackColor = False
        '
        'adminButton
        '
        Me.adminButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.adminButton.Location = New System.Drawing.Point(88, 122)
        Me.adminButton.Name = "adminButton"
        Me.adminButton.Size = New System.Drawing.Size(115, 60)
        Me.adminButton.TabIndex = 1
        Me.adminButton.Text = "Admin"
        Me.adminButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.adminButton)
        Me.Controls.Add(Me.staffButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RollApplication"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents staffButton As Button
    Friend WithEvents adminButton As Button
End Class
