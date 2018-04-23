<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class StaffLoginForm
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
        Me.components = New System.ComponentModel.Container()
        Dim Staff_numberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffLoginForm))
        Me.OK = New System.Windows.Forms.Button()
        Me.FinalDatabaseDataSet = New projectTake2.finalDatabaseDataSet()
        Me.EmployeeDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDataTableAdapter = New projectTake2.finalDatabaseDataSetTableAdapters.EmployeeDataTableAdapter()
        Me.TableAdapterManager = New projectTake2.finalDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Staff_numberTextBox = New System.Windows.Forms.TextBox()
        Staff_numberLabel = New System.Windows.Forms.Label()
        CType(Me.FinalDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Staff_numberLabel
        '
        Staff_numberLabel.AutoSize = True
        Staff_numberLabel.Location = New System.Drawing.Point(39, 83)
        Staff_numberLabel.Name = "Staff_numberLabel"
        Staff_numberLabel.Size = New System.Drawing.Size(70, 13)
        Staff_numberLabel.TabIndex = 11
        Staff_numberLabel.Text = "Staff number:"
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OK.Location = New System.Drawing.Point(103, 127)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(81, 22)
        Me.OK.TabIndex = 10
        Me.OK.Text = "&OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'FinalDatabaseDataSet
        '
        Me.FinalDatabaseDataSet.DataSetName = "finalDatabaseDataSet"
        Me.FinalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeDataBindingSource
        '
        Me.EmployeeDataBindingSource.DataMember = "EmployeeData"
        Me.EmployeeDataBindingSource.DataSource = Me.FinalDatabaseDataSet
        '
        'EmployeeDataTableAdapter
        '
        Me.EmployeeDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AllowancesDataTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DeductionsDataTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeDataTableAdapter = Me.EmployeeDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = projectTake2.finalDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Staff_numberTextBox
        '
        Me.Staff_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Staff_number", True))
        Me.Staff_numberTextBox.Location = New System.Drawing.Point(115, 80)
        Me.Staff_numberTextBox.Name = "Staff_numberTextBox"
        Me.Staff_numberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Staff_numberTextBox.TabIndex = 12
        '
        'StaffLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Staff_numberLabel)
        Me.Controls.Add(Me.Staff_numberTextBox)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StaffLoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StaffLoginForm"
        CType(Me.FinalDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK As Button
    Friend WithEvents FinalDatabaseDataSet As finalDatabaseDataSet
    Friend WithEvents EmployeeDataBindingSource As BindingSource
    Friend WithEvents EmployeeDataTableAdapter As finalDatabaseDataSetTableAdapters.EmployeeDataTableAdapter
    Friend WithEvents TableAdapterManager As finalDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeDataBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmployeeDataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Staff_numberTextBox As TextBox
End Class
