﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee_
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
        Dim Staff_numberLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Other_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Home_addressLabel As System.Windows.Forms.Label
        Dim Staff_LevelLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim Job_TitleLabel As System.Windows.Forms.Label
        Dim Basic_PayLabel As System.Windows.Forms.Label
        Dim Bank_ACLabel As System.Windows.Forms.Label
        Dim Bank_BranchLabel As System.Windows.Forms.Label
        Dim ResponsibiltyLabel As System.Windows.Forms.Label
        Dim Off_CampusLabel As System.Windows.Forms.Label
        Dim Rent_AllowanceLabel As System.Windows.Forms.Label
        Dim Electricity_RebateLabel As System.Windows.Forms.Label
        Dim Vehicle_Maintenance_AllowanceLabel As System.Windows.Forms.Label
        Dim Market_PremiumLabel As System.Windows.Forms.Label
        Dim Entertainment_AllowanceLabel As System.Windows.Forms.Label
        Dim Security_and_SanitationLabel As System.Windows.Forms.Label
        Dim IRS_taxLabel As System.Windows.Forms.Label
        Dim Hospital_LevyLabel As System.Windows.Forms.Label
        Dim Super_AnnuationLabel As System.Windows.Forms.Label
        Dim SSNITLabel As System.Windows.Forms.Label
        Dim WelfareLabel As System.Windows.Forms.Label
        Dim GrossPayLabel As System.Windows.Forms.Label
        Dim NetPayLabel As System.Windows.Forms.Label
        Dim Bank_NameLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Dim Staff_numberLabel1 As System.Windows.Forms.Label
        Dim Staff_numberLabel2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEmployee_))
        Me.FinalDatabaseDataSet = New projectTake2.finalDatabaseDataSet()
        Me.EmployeeDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDataTableAdapter = New projectTake2.finalDatabaseDataSetTableAdapters.EmployeeDataTableAdapter()
        Me.TableAdapterManager = New projectTake2.finalDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Staff_numberTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Home_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TitleComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.Other_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Date_JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Bank_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Bank_BranchTextBox = New System.Windows.Forms.TextBox()
        Me.Bank_ACTextBox = New System.Windows.Forms.TextBox()
        Me.Basic_PayTextBox = New System.Windows.Forms.TextBox()
        Me.Job_TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_LevelComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ResponsibiltyTextBox = New System.Windows.Forms.TextBox()
        Me.AllowancesDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Off_CampusTextBox = New System.Windows.Forms.TextBox()
        Me.Rent_AllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.Electricity_RebateTextBox = New System.Windows.Forms.TextBox()
        Me.Vehicle_Maintenance_AllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.Market_PremiumTextBox = New System.Windows.Forms.TextBox()
        Me.Entertainment_AllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.Security_and_SanitationTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Staff_numberTextBox2 = New System.Windows.Forms.TextBox()
        Me.DeductionsDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IRS_taxTextBox = New System.Windows.Forms.TextBox()
        Me.Hospital_LevyTextBox = New System.Windows.Forms.TextBox()
        Me.Super_AnnuationTextBox = New System.Windows.Forms.TextBox()
        Me.SSNITTextBox = New System.Windows.Forms.TextBox()
        Me.WelfareTextBox = New System.Windows.Forms.TextBox()
        Me.AllowancesDataTableAdapter = New projectTake2.finalDatabaseDataSetTableAdapters.AllowancesDataTableAdapter()
        Me.DeductionsDataTableAdapter = New projectTake2.finalDatabaseDataSetTableAdapters.DeductionsDataTableAdapter()
        Me.GrossPayTextBox = New System.Windows.Forms.TextBox()
        Me.NetPayTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Staff_numberTextBox1 = New System.Windows.Forms.TextBox()
        Staff_numberLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Other_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Home_addressLabel = New System.Windows.Forms.Label()
        Staff_LevelLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        Job_TitleLabel = New System.Windows.Forms.Label()
        Basic_PayLabel = New System.Windows.Forms.Label()
        Bank_ACLabel = New System.Windows.Forms.Label()
        Bank_BranchLabel = New System.Windows.Forms.Label()
        ResponsibiltyLabel = New System.Windows.Forms.Label()
        Off_CampusLabel = New System.Windows.Forms.Label()
        Rent_AllowanceLabel = New System.Windows.Forms.Label()
        Electricity_RebateLabel = New System.Windows.Forms.Label()
        Vehicle_Maintenance_AllowanceLabel = New System.Windows.Forms.Label()
        Market_PremiumLabel = New System.Windows.Forms.Label()
        Entertainment_AllowanceLabel = New System.Windows.Forms.Label()
        Security_and_SanitationLabel = New System.Windows.Forms.Label()
        IRS_taxLabel = New System.Windows.Forms.Label()
        Hospital_LevyLabel = New System.Windows.Forms.Label()
        Super_AnnuationLabel = New System.Windows.Forms.Label()
        SSNITLabel = New System.Windows.Forms.Label()
        WelfareLabel = New System.Windows.Forms.Label()
        GrossPayLabel = New System.Windows.Forms.Label()
        NetPayLabel = New System.Windows.Forms.Label()
        Bank_NameLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        Staff_numberLabel1 = New System.Windows.Forms.Label()
        Staff_numberLabel2 = New System.Windows.Forms.Label()
        CType(Me.FinalDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AllowancesDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DeductionsDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Staff_numberLabel
        '
        Staff_numberLabel.AutoSize = True
        Staff_numberLabel.Location = New System.Drawing.Point(23, 9)
        Staff_numberLabel.Name = "Staff_numberLabel"
        Staff_numberLabel.Size = New System.Drawing.Size(70, 13)
        Staff_numberLabel.TabIndex = 1
        Staff_numberLabel.Text = "Staff number:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(29, 52)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 2
        SurnameLabel.Text = "Surname:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(21, 81)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'Other_NameLabel
        '
        Other_NameLabel.AutoSize = True
        Other_NameLabel.Location = New System.Drawing.Point(6, 104)
        Other_NameLabel.Name = "Other_NameLabel"
        Other_NameLabel.Size = New System.Drawing.Size(78, 13)
        Other_NameLabel.TabIndex = 6
        Other_NameLabel.Text = "Other Name(s):"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(34, 128)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 8
        GenderLabel.Text = "Gender:"
        AddHandler GenderLabel.Click, AddressOf Me.GenderLabel_Click
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(51, 25)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 9
        TitleLabel.Text = "Title:"
        AddHandler TitleLabel.Click, AddressOf Me.TitleLabel_Click
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(49, 179)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(3, 231)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 14
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Home_addressLabel
        '
        Home_addressLabel.AutoSize = True
        Home_addressLabel.Location = New System.Drawing.Point(6, 203)
        Home_addressLabel.Name = "Home_addressLabel"
        Home_addressLabel.Size = New System.Drawing.Size(78, 13)
        Home_addressLabel.TabIndex = 16
        Home_addressLabel.Text = "Home address:"
        '
        'Staff_LevelLabel
        '
        Staff_LevelLabel.AutoSize = True
        Staff_LevelLabel.Location = New System.Drawing.Point(20, 28)
        Staff_LevelLabel.Name = "Staff_LevelLabel"
        Staff_LevelLabel.Size = New System.Drawing.Size(61, 13)
        Staff_LevelLabel.TabIndex = 0
        Staff_LevelLabel.Text = "Staff Level:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(16, 55)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 2
        DepartmentLabel.Text = "Department:"
        '
        'Job_TitleLabel
        '
        Job_TitleLabel.AutoSize = True
        Job_TitleLabel.Location = New System.Drawing.Point(31, 86)
        Job_TitleLabel.Name = "Job_TitleLabel"
        Job_TitleLabel.Size = New System.Drawing.Size(50, 13)
        Job_TitleLabel.TabIndex = 4
        Job_TitleLabel.Text = "Job Title:"
        '
        'Basic_PayLabel
        '
        Basic_PayLabel.AutoSize = True
        Basic_PayLabel.Location = New System.Drawing.Point(24, 140)
        Basic_PayLabel.Name = "Basic_PayLabel"
        Basic_PayLabel.Size = New System.Drawing.Size(57, 13)
        Basic_PayLabel.TabIndex = 8
        Basic_PayLabel.Text = "Basic Pay:"
        '
        'Bank_ACLabel
        '
        Bank_ACLabel.AutoSize = True
        Bank_ACLabel.Location = New System.Drawing.Point(29, 166)
        Bank_ACLabel.Name = "Bank_ACLabel"
        Bank_ACLabel.Size = New System.Drawing.Size(52, 13)
        Bank_ACLabel.TabIndex = 10
        Bank_ACLabel.Text = "Bank AC:"
        '
        'Bank_BranchLabel
        '
        Bank_BranchLabel.AutoSize = True
        Bank_BranchLabel.Location = New System.Drawing.Point(9, 217)
        Bank_BranchLabel.Name = "Bank_BranchLabel"
        Bank_BranchLabel.Size = New System.Drawing.Size(72, 13)
        Bank_BranchLabel.TabIndex = 14
        Bank_BranchLabel.Text = "Bank Branch:"
        '
        'ResponsibiltyLabel
        '
        ResponsibiltyLabel.AutoSize = True
        ResponsibiltyLabel.Location = New System.Drawing.Point(11, 29)
        ResponsibiltyLabel.Name = "ResponsibiltyLabel"
        ResponsibiltyLabel.Size = New System.Drawing.Size(72, 13)
        ResponsibiltyLabel.TabIndex = 2
        ResponsibiltyLabel.Text = "Responsibilty:"
        '
        'Off_CampusLabel
        '
        Off_CampusLabel.AutoSize = True
        Off_CampusLabel.Location = New System.Drawing.Point(11, 55)
        Off_CampusLabel.Name = "Off_CampusLabel"
        Off_CampusLabel.Size = New System.Drawing.Size(65, 13)
        Off_CampusLabel.TabIndex = 4
        Off_CampusLabel.Text = "Off Campus:"
        '
        'Rent_AllowanceLabel
        '
        Rent_AllowanceLabel.AutoSize = True
        Rent_AllowanceLabel.Location = New System.Drawing.Point(11, 81)
        Rent_AllowanceLabel.Name = "Rent_AllowanceLabel"
        Rent_AllowanceLabel.Size = New System.Drawing.Size(85, 13)
        Rent_AllowanceLabel.TabIndex = 6
        Rent_AllowanceLabel.Text = "Rent Allowance:"
        '
        'Electricity_RebateLabel
        '
        Electricity_RebateLabel.AutoSize = True
        Electricity_RebateLabel.Location = New System.Drawing.Point(11, 107)
        Electricity_RebateLabel.Name = "Electricity_RebateLabel"
        Electricity_RebateLabel.Size = New System.Drawing.Size(93, 13)
        Electricity_RebateLabel.TabIndex = 8
        Electricity_RebateLabel.Text = "Electricity Rebate:"
        '
        'Vehicle_Maintenance_AllowanceLabel
        '
        Vehicle_Maintenance_AllowanceLabel.AutoSize = True
        Vehicle_Maintenance_AllowanceLabel.Location = New System.Drawing.Point(11, 133)
        Vehicle_Maintenance_AllowanceLabel.Name = "Vehicle_Maintenance_AllowanceLabel"
        Vehicle_Maintenance_AllowanceLabel.Size = New System.Drawing.Size(162, 13)
        Vehicle_Maintenance_AllowanceLabel.TabIndex = 10
        Vehicle_Maintenance_AllowanceLabel.Text = "Vehicle Maintenance Allowance:"
        '
        'Market_PremiumLabel
        '
        Market_PremiumLabel.AutoSize = True
        Market_PremiumLabel.Location = New System.Drawing.Point(11, 159)
        Market_PremiumLabel.Name = "Market_PremiumLabel"
        Market_PremiumLabel.Size = New System.Drawing.Size(86, 13)
        Market_PremiumLabel.TabIndex = 12
        Market_PremiumLabel.Text = "Market Premium:"
        '
        'Entertainment_AllowanceLabel
        '
        Entertainment_AllowanceLabel.AutoSize = True
        Entertainment_AllowanceLabel.Location = New System.Drawing.Point(11, 185)
        Entertainment_AllowanceLabel.Name = "Entertainment_AllowanceLabel"
        Entertainment_AllowanceLabel.Size = New System.Drawing.Size(127, 13)
        Entertainment_AllowanceLabel.TabIndex = 14
        Entertainment_AllowanceLabel.Text = "Entertainment Allowance:"
        '
        'Security_and_SanitationLabel
        '
        Security_and_SanitationLabel.AutoSize = True
        Security_and_SanitationLabel.Location = New System.Drawing.Point(11, 211)
        Security_and_SanitationLabel.Name = "Security_and_SanitationLabel"
        Security_and_SanitationLabel.Size = New System.Drawing.Size(119, 13)
        Security_and_SanitationLabel.TabIndex = 16
        Security_and_SanitationLabel.Text = "Security and Sanitation:"
        '
        'IRS_taxLabel
        '
        IRS_taxLabel.AutoSize = True
        IRS_taxLabel.Location = New System.Drawing.Point(15, 38)
        IRS_taxLabel.Name = "IRS_taxLabel"
        IRS_taxLabel.Size = New System.Drawing.Size(45, 13)
        IRS_taxLabel.TabIndex = 2
        IRS_taxLabel.Text = "IRS tax:"
        '
        'Hospital_LevyLabel
        '
        Hospital_LevyLabel.AutoSize = True
        Hospital_LevyLabel.Location = New System.Drawing.Point(15, 64)
        Hospital_LevyLabel.Name = "Hospital_LevyLabel"
        Hospital_LevyLabel.Size = New System.Drawing.Size(74, 13)
        Hospital_LevyLabel.TabIndex = 4
        Hospital_LevyLabel.Text = "Hospital Levy:"
        '
        'Super_AnnuationLabel
        '
        Super_AnnuationLabel.AutoSize = True
        Super_AnnuationLabel.Location = New System.Drawing.Point(15, 90)
        Super_AnnuationLabel.Name = "Super_AnnuationLabel"
        Super_AnnuationLabel.Size = New System.Drawing.Size(89, 13)
        Super_AnnuationLabel.TabIndex = 8
        Super_AnnuationLabel.Text = "Super Annuation:"
        '
        'SSNITLabel
        '
        SSNITLabel.AutoSize = True
        SSNITLabel.Location = New System.Drawing.Point(15, 116)
        SSNITLabel.Name = "SSNITLabel"
        SSNITLabel.Size = New System.Drawing.Size(42, 13)
        SSNITLabel.TabIndex = 10
        SSNITLabel.Text = "SSNIT:"
        '
        'WelfareLabel
        '
        WelfareLabel.AutoSize = True
        WelfareLabel.Location = New System.Drawing.Point(15, 142)
        WelfareLabel.Name = "WelfareLabel"
        WelfareLabel.Size = New System.Drawing.Size(47, 13)
        WelfareLabel.TabIndex = 12
        WelfareLabel.Text = "Welfare:"
        '
        'GrossPayLabel
        '
        GrossPayLabel.AutoSize = True
        GrossPayLabel.Location = New System.Drawing.Point(388, 532)
        GrossPayLabel.Name = "GrossPayLabel"
        GrossPayLabel.Size = New System.Drawing.Size(58, 13)
        GrossPayLabel.TabIndex = 19
        GrossPayLabel.Text = "Gross Pay:"
        '
        'NetPayLabel
        '
        NetPayLabel.AutoSize = True
        NetPayLabel.Location = New System.Drawing.Point(398, 561)
        NetPayLabel.Name = "NetPayLabel"
        NetPayLabel.Size = New System.Drawing.Size(48, 13)
        NetPayLabel.TabIndex = 20
        NetPayLabel.Text = "Net Pay:"
        '
        'Bank_NameLabel
        '
        Bank_NameLabel.AutoSize = True
        Bank_NameLabel.Location = New System.Drawing.Point(15, 190)
        Bank_NameLabel.Name = "Bank_NameLabel"
        Bank_NameLabel.Size = New System.Drawing.Size(66, 13)
        Bank_NameLabel.TabIndex = 15
        Bank_NameLabel.Text = "Bank Name:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(51, 154)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 19
        DOBLabel.Text = "DOB:"
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Location = New System.Drawing.Point(14, 114)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(67, 13)
        Date_JoinedLabel.TabIndex = 16
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'Staff_numberLabel1
        '
        Staff_numberLabel1.AutoSize = True
        Staff_numberLabel1.Location = New System.Drawing.Point(445, 20)
        Staff_numberLabel1.Name = "Staff_numberLabel1"
        Staff_numberLabel1.Size = New System.Drawing.Size(70, 13)
        Staff_numberLabel1.TabIndex = 24
        Staff_numberLabel1.Text = "Staff number:"
        Staff_numberLabel1.Visible = False
        '
        'Staff_numberLabel2
        '
        Staff_numberLabel2.AutoSize = True
        Staff_numberLabel2.Location = New System.Drawing.Point(27, 169)
        Staff_numberLabel2.Name = "Staff_numberLabel2"
        Staff_numberLabel2.Size = New System.Drawing.Size(70, 13)
        Staff_numberLabel2.TabIndex = 13
        Staff_numberLabel2.Text = "Staff number:"
        Staff_numberLabel2.Visible = False
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
        Me.Staff_numberTextBox.Location = New System.Drawing.Point(109, 6)
        Me.Staff_numberTextBox.Name = "Staff_numberTextBox"
        Me.Staff_numberTextBox.ReadOnly = True
        Me.Staff_numberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Staff_numberTextBox.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(DOBLabel)
        Me.GroupBox1.Controls.Add(Me.DOBDateTimePicker)
        Me.GroupBox1.Controls.Add(Home_addressLabel)
        Me.GroupBox1.Controls.Add(Me.Home_addressTextBox)
        Me.GroupBox1.Controls.Add(Phone_NumberLabel)
        Me.GroupBox1.Controls.Add(Me.Phone_NumberMaskedTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleComboBox)
        Me.GroupBox1.Controls.Add(GenderLabel)
        Me.GroupBox1.Controls.Add(Me.GenderComboBox)
        Me.GroupBox1.Controls.Add(Other_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Other_NameTextBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(SurnameLabel)
        Me.GroupBox1.Controls.Add(Me.SurnameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 262)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeDataBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(97, 150)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(193, 20)
        Me.DOBDateTimePicker.TabIndex = 20
        '
        'Home_addressTextBox
        '
        Me.Home_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Home_address", True))
        Me.Home_addressTextBox.Location = New System.Drawing.Point(97, 202)
        Me.Home_addressTextBox.Name = "Home_addressTextBox"
        Me.Home_addressTextBox.Size = New System.Drawing.Size(193, 20)
        Me.Home_addressTextBox.TabIndex = 17
        '
        'Phone_NumberMaskedTextBox
        '
        Me.Phone_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Phone_Number", True))
        Me.Phone_NumberMaskedTextBox.Location = New System.Drawing.Point(97, 228)
        Me.Phone_NumberMaskedTextBox.Mask = "(999) 000-0000"
        Me.Phone_NumberMaskedTextBox.Name = "Phone_NumberMaskedTextBox"
        Me.Phone_NumberMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Phone_NumberMaskedTextBox.TabIndex = 15
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(97, 176)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(193, 20)
        Me.EmailTextBox.TabIndex = 13
        '
        'TitleComboBox
        '
        Me.TitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Title", True))
        Me.TitleComboBox.FormattingEnabled = True
        Me.TitleComboBox.Items.AddRange(New Object() {"Prof.", "Dr.", "Mrs.", "Mr.", "Miss."})
        Me.TitleComboBox.Location = New System.Drawing.Point(97, 25)
        Me.TitleComboBox.Name = "TitleComboBox"
        Me.TitleComboBox.Size = New System.Drawing.Size(84, 21)
        Me.TitleComboBox.TabIndex = 10
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Female", "Male"})
        Me.GenderComboBox.Location = New System.Drawing.Point(97, 125)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(100, 21)
        Me.GenderComboBox.TabIndex = 9
        '
        'Other_NameTextBox
        '
        Me.Other_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Other_Name", True))
        Me.Other_NameTextBox.Location = New System.Drawing.Point(97, 101)
        Me.Other_NameTextBox.Name = "Other_NameTextBox"
        Me.Other_NameTextBox.Size = New System.Drawing.Size(193, 20)
        Me.Other_NameTextBox.TabIndex = 7
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(97, 78)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(122, 20)
        Me.First_NameTextBox.TabIndex = 5
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(97, 52)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(122, 20)
        Me.SurnameTextBox.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Date_JoinedLabel)
        Me.GroupBox2.Controls.Add(Me.Date_JoinedDateTimePicker)
        Me.GroupBox2.Controls.Add(Bank_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Bank_NameComboBox)
        Me.GroupBox2.Controls.Add(Bank_BranchLabel)
        Me.GroupBox2.Controls.Add(Me.Bank_BranchTextBox)
        Me.GroupBox2.Controls.Add(Bank_ACLabel)
        Me.GroupBox2.Controls.Add(Me.Bank_ACTextBox)
        Me.GroupBox2.Controls.Add(Basic_PayLabel)
        Me.GroupBox2.Controls.Add(Me.Basic_PayTextBox)
        Me.GroupBox2.Controls.Add(Job_TitleLabel)
        Me.GroupBox2.Controls.Add(Me.Job_TitleTextBox)
        Me.GroupBox2.Controls.Add(DepartmentLabel)
        Me.GroupBox2.Controls.Add(Me.DepartmentTextBox)
        Me.GroupBox2.Controls.Add(Staff_LevelLabel)
        Me.GroupBox2.Controls.Add(Me.Staff_LevelComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 311)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 281)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "More Info"
        '
        'Date_JoinedDateTimePicker
        '
        Me.Date_JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeDataBindingSource, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_JoinedDateTimePicker.Location = New System.Drawing.Point(87, 110)
        Me.Date_JoinedDateTimePicker.Name = "Date_JoinedDateTimePicker"
        Me.Date_JoinedDateTimePicker.Size = New System.Drawing.Size(161, 20)
        Me.Date_JoinedDateTimePicker.TabIndex = 17
        '
        'Bank_NameComboBox
        '
        Me.Bank_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Bank_Name", True))
        Me.Bank_NameComboBox.FormattingEnabled = True
        Me.Bank_NameComboBox.Items.AddRange(New Object() {"Access Bank", "ADB", "Barclays Bank", "CAL", "Fidelity", "GCB", "GN Bank", "HFC Bak", "Ecobank", "Prudential Bank", "Stanbic Bank", "Standard Chartered ", "UniBank", "Zenith Bank"})
        Me.Bank_NameComboBox.Location = New System.Drawing.Point(87, 187)
        Me.Bank_NameComboBox.Name = "Bank_NameComboBox"
        Me.Bank_NameComboBox.Size = New System.Drawing.Size(178, 21)
        Me.Bank_NameComboBox.TabIndex = 16
        '
        'Bank_BranchTextBox
        '
        Me.Bank_BranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Bank_Branch", True))
        Me.Bank_BranchTextBox.Location = New System.Drawing.Point(87, 214)
        Me.Bank_BranchTextBox.Name = "Bank_BranchTextBox"
        Me.Bank_BranchTextBox.Size = New System.Drawing.Size(178, 20)
        Me.Bank_BranchTextBox.TabIndex = 15
        '
        'Bank_ACTextBox
        '
        Me.Bank_ACTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Bank_AC", True))
        Me.Bank_ACTextBox.Location = New System.Drawing.Point(87, 163)
        Me.Bank_ACTextBox.Name = "Bank_ACTextBox"
        Me.Bank_ACTextBox.Size = New System.Drawing.Size(178, 20)
        Me.Bank_ACTextBox.TabIndex = 11
        '
        'Basic_PayTextBox
        '
        Me.Basic_PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Basic_Pay", True))
        Me.Basic_PayTextBox.Location = New System.Drawing.Point(87, 137)
        Me.Basic_PayTextBox.Name = "Basic_PayTextBox"
        Me.Basic_PayTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Basic_PayTextBox.TabIndex = 9
        '
        'Job_TitleTextBox
        '
        Me.Job_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Job_Title", True))
        Me.Job_TitleTextBox.Location = New System.Drawing.Point(87, 83)
        Me.Job_TitleTextBox.Name = "Job_TitleTextBox"
        Me.Job_TitleTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Job_TitleTextBox.TabIndex = 5
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(87, 52)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(161, 20)
        Me.DepartmentTextBox.TabIndex = 3
        '
        'Staff_LevelComboBox
        '
        Me.Staff_LevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "Staff_Level", True))
        Me.Staff_LevelComboBox.FormattingEnabled = True
        Me.Staff_LevelComboBox.Items.AddRange(New Object() {"Senior Member", "Senior Staff", "Junior Staff"})
        Me.Staff_LevelComboBox.Location = New System.Drawing.Point(87, 25)
        Me.Staff_LevelComboBox.Name = "Staff_LevelComboBox"
        Me.Staff_LevelComboBox.Size = New System.Drawing.Size(161, 21)
        Me.Staff_LevelComboBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(ResponsibiltyLabel)
        Me.GroupBox3.Controls.Add(Me.ResponsibiltyTextBox)
        Me.GroupBox3.Controls.Add(Off_CampusLabel)
        Me.GroupBox3.Controls.Add(Me.Off_CampusTextBox)
        Me.GroupBox3.Controls.Add(Rent_AllowanceLabel)
        Me.GroupBox3.Controls.Add(Me.Rent_AllowanceTextBox)
        Me.GroupBox3.Controls.Add(Electricity_RebateLabel)
        Me.GroupBox3.Controls.Add(Me.Electricity_RebateTextBox)
        Me.GroupBox3.Controls.Add(Vehicle_Maintenance_AllowanceLabel)
        Me.GroupBox3.Controls.Add(Me.Vehicle_Maintenance_AllowanceTextBox)
        Me.GroupBox3.Controls.Add(Market_PremiumLabel)
        Me.GroupBox3.Controls.Add(Me.Market_PremiumTextBox)
        Me.GroupBox3.Controls.Add(Entertainment_AllowanceLabel)
        Me.GroupBox3.Controls.Add(Me.Entertainment_AllowanceTextBox)
        Me.GroupBox3.Controls.Add(Security_and_SanitationLabel)
        Me.GroupBox3.Controls.Add(Me.Security_and_SanitationTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(342, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 262)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Allowances"
        '
        'ResponsibiltyTextBox
        '
        Me.ResponsibiltyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllowancesDataBindingSource, "Responsibilty", True))
        Me.ResponsibiltyTextBox.Location = New System.Drawing.Point(179, 26)
        Me.ResponsibiltyTextBox.Name = "ResponsibiltyTextBox"
        Me.ResponsibiltyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResponsibiltyTextBox.TabIndex = 3
        '
        'AllowancesDataBindingSource
        '
        Me.AllowancesDataBindingSource.DataMember = "AllowancesData"
        Me.AllowancesDataBindingSource.DataSource = Me.FinalDatabaseDataSet
        '
        'Off_CampusTextBox
        '
        Me.Off_CampusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllowancesDataBindingSource, "Off_Campus", True))
        Me.Off_CampusTextBox.Location = New System.Drawing.Point(179, 52)
        Me.Off_CampusTextBox.Name = "Off_CampusTextBox"
        Me.Off_CampusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Off_CampusTextBox.TabIndex = 5
        '
        'Rent_AllowanceTextBox
        '
        Me.Rent_AllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllowancesDataBindingSource, "Rent_Allowance", True))
        Me.Rent_AllowanceTextBox.Location = New System.Drawing.Point(179, 78)
        Me.Rent_AllowanceTextBox.Name = "Rent_AllowanceTextBox"
        Me.Rent_AllowanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Rent_AllowanceTextBox.TabIndex = 7
        '
        'Electricity_RebateTextBox
        '
        Me.Electricity_RebateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllowancesDataBindingSource, "Electricity_Rebate", True))
        Me.Electricity_RebateTextBox.Location = New System.Drawing.Point(179, 104)
        Me.Electricity_RebateTextBox.Name = "Electricity_RebateTextBox"
        Me.Electricity_RebateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Electricity_RebateTextBox.TabIndex = 9
        '
        'Vehicle_Maintenance_AllowanceTextBox
        '
        Me.Vehicle_Maintenance_AllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllowancesDataBindingSource, "Vehicle_Maintenance_Allowance", True))
        Me.Vehicle_Maintenance_AllowanceTextBox.Location = New System.Drawing.Point(179, 130)
        Me.Vehicle_Maintenance_AllowanceTextBox.Name = "Vehicle_Maintenance_AllowanceTextBox"
        Me.Vehicle_Maintenance_AllowanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vehicle_Maintenance_AllowanceTextBox.TabIndex = 11
        '
        'Market_PremiumTextBox
        '
        Me.Market_PremiumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllowancesDataBindingSource, "Market_Premium", True))
        Me.Market_PremiumTextBox.Location = New System.Drawing.Point(179, 156)
        Me.Market_PremiumTextBox.Name = "Market_PremiumTextBox"
        Me.Market_PremiumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Market_PremiumTextBox.TabIndex = 13
        '
        'Entertainment_AllowanceTextBox
        '
        Me.Entertainment_AllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllowancesDataBindingSource, "Entertainment_Allowance", True))
        Me.Entertainment_AllowanceTextBox.Location = New System.Drawing.Point(179, 182)
        Me.Entertainment_AllowanceTextBox.Name = "Entertainment_AllowanceTextBox"
        Me.Entertainment_AllowanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Entertainment_AllowanceTextBox.TabIndex = 15
        '
        'Security_and_SanitationTextBox
        '
        Me.Security_and_SanitationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllowancesDataBindingSource, "Security_and_Sanitation", True))
        Me.Security_and_SanitationTextBox.Location = New System.Drawing.Point(179, 208)
        Me.Security_and_SanitationTextBox.Name = "Security_and_SanitationTextBox"
        Me.Security_and_SanitationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Security_and_SanitationTextBox.TabIndex = 17
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Staff_numberLabel2)
        Me.GroupBox5.Controls.Add(Me.Staff_numberTextBox2)
        Me.GroupBox5.Controls.Add(IRS_taxLabel)
        Me.GroupBox5.Controls.Add(Me.IRS_taxTextBox)
        Me.GroupBox5.Controls.Add(Hospital_LevyLabel)
        Me.GroupBox5.Controls.Add(Me.Hospital_LevyTextBox)
        Me.GroupBox5.Controls.Add(Super_AnnuationLabel)
        Me.GroupBox5.Controls.Add(Me.Super_AnnuationTextBox)
        Me.GroupBox5.Controls.Add(SSNITLabel)
        Me.GroupBox5.Controls.Add(Me.SSNITTextBox)
        Me.GroupBox5.Controls.Add(WelfareLabel)
        Me.GroupBox5.Controls.Add(Me.WelfareTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(342, 311)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(297, 217)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Deductions"
        '
        'Staff_numberTextBox2
        '
        Me.Staff_numberTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeductionsDataBindingSource, "Staff_number", True))
        Me.Staff_numberTextBox2.Location = New System.Drawing.Point(110, 166)
        Me.Staff_numberTextBox2.Name = "Staff_numberTextBox2"
        Me.Staff_numberTextBox2.ReadOnly = True
        Me.Staff_numberTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.Staff_numberTextBox2.TabIndex = 14
        '
        'DeductionsDataBindingSource
        '
        Me.DeductionsDataBindingSource.DataMember = "DeductionsData"
        Me.DeductionsDataBindingSource.DataSource = Me.FinalDatabaseDataSet
        '
        'IRS_taxTextBox
        '
        Me.IRS_taxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeductionsDataBindingSource, "IRS_tax", True))
        Me.IRS_taxTextBox.Location = New System.Drawing.Point(110, 35)
        Me.IRS_taxTextBox.Name = "IRS_taxTextBox"
        Me.IRS_taxTextBox.ReadOnly = True
        Me.IRS_taxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IRS_taxTextBox.TabIndex = 3
        '
        'Hospital_LevyTextBox
        '
        Me.Hospital_LevyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeductionsDataBindingSource, "Hospital_Levy", True))
        Me.Hospital_LevyTextBox.Location = New System.Drawing.Point(110, 60)
        Me.Hospital_LevyTextBox.Name = "Hospital_LevyTextBox"
        Me.Hospital_LevyTextBox.ReadOnly = True
        Me.Hospital_LevyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hospital_LevyTextBox.TabIndex = 5
        '
        'Super_AnnuationTextBox
        '
        Me.Super_AnnuationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeductionsDataBindingSource, "Super_Annuation", True))
        Me.Super_AnnuationTextBox.Location = New System.Drawing.Point(110, 87)
        Me.Super_AnnuationTextBox.Name = "Super_AnnuationTextBox"
        Me.Super_AnnuationTextBox.ReadOnly = True
        Me.Super_AnnuationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Super_AnnuationTextBox.TabIndex = 9
        '
        'SSNITTextBox
        '
        Me.SSNITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeductionsDataBindingSource, "SSNIT", True))
        Me.SSNITTextBox.Location = New System.Drawing.Point(110, 113)
        Me.SSNITTextBox.Name = "SSNITTextBox"
        Me.SSNITTextBox.ReadOnly = True
        Me.SSNITTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SSNITTextBox.TabIndex = 11
        '
        'WelfareTextBox
        '
        Me.WelfareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeductionsDataBindingSource, "Welfare", True))
        Me.WelfareTextBox.Location = New System.Drawing.Point(110, 139)
        Me.WelfareTextBox.Name = "WelfareTextBox"
        Me.WelfareTextBox.ReadOnly = True
        Me.WelfareTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WelfareTextBox.TabIndex = 13
        '
        'AllowancesDataTableAdapter
        '
        Me.AllowancesDataTableAdapter.ClearBeforeFill = True
        '
        'DeductionsDataTableAdapter
        '
        Me.DeductionsDataTableAdapter.ClearBeforeFill = True
        '
        'GrossPayTextBox
        '
        Me.GrossPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "GrossPay", True))
        Me.GrossPayTextBox.Location = New System.Drawing.Point(452, 529)
        Me.GrossPayTextBox.Name = "GrossPayTextBox"
        Me.GrossPayTextBox.ReadOnly = True
        Me.GrossPayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GrossPayTextBox.TabIndex = 20
        '
        'NetPayTextBox
        '
        Me.NetPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDataBindingSource, "NetPay", True))
        Me.NetPayTextBox.Location = New System.Drawing.Point(452, 558)
        Me.NetPayTextBox.Name = "NetPayTextBox"
        Me.NetPayTextBox.ReadOnly = True
        Me.NetPayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NetPayTextBox.TabIndex = 21
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(251, 609)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(103, 43)
        Me.ExitButton.TabIndex = 24
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(142, 609)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(103, 43)
        Me.ResetButton.TabIndex = 23
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(33, 609)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(103, 43)
        Me.SaveButton.TabIndex = 22
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Staff_numberTextBox1
        '
        Me.Staff_numberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllowancesDataBindingSource, "Staff_number", True))
        Me.Staff_numberTextBox1.Location = New System.Drawing.Point(521, 17)
        Me.Staff_numberTextBox1.Name = "Staff_numberTextBox1"
        Me.Staff_numberTextBox1.ReadOnly = True
        Me.Staff_numberTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Staff_numberTextBox1.TabIndex = 25
        '
        'AddEmployee_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(693, 678)
        Me.Controls.Add(Staff_numberLabel1)
        Me.Controls.Add(Me.Staff_numberTextBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(NetPayLabel)
        Me.Controls.Add(Me.NetPayTextBox)
        Me.Controls.Add(GrossPayLabel)
        Me.Controls.Add(Me.GrossPayTextBox)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Staff_numberLabel)
        Me.Controls.Add(Me.Staff_numberTextBox)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddEmployee_"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEmployee"
        CType(Me.FinalDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AllowancesDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DeductionsDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FinalDatabaseDataSet As finalDatabaseDataSet
    Friend WithEvents EmployeeDataBindingSource As BindingSource
    Friend WithEvents EmployeeDataTableAdapter As finalDatabaseDataSetTableAdapters.EmployeeDataTableAdapter
    Friend WithEvents TableAdapterManager As finalDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Staff_numberTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TitleComboBox As ComboBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents Other_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents Phone_NumberMaskedTextBox As MaskedTextBox
    Friend WithEvents Home_addressTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Bank_BranchTextBox As TextBox
    Friend WithEvents Bank_ACTextBox As TextBox
    Friend WithEvents Basic_PayTextBox As TextBox
    Friend WithEvents Job_TitleTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents Staff_LevelComboBox As ComboBox
    Friend WithEvents AllowancesDataBindingSource As BindingSource
    Friend WithEvents AllowancesDataTableAdapter As finalDatabaseDataSetTableAdapters.AllowancesDataTableAdapter
    Friend WithEvents ResponsibiltyTextBox As TextBox
    Friend WithEvents Off_CampusTextBox As TextBox
    Friend WithEvents Rent_AllowanceTextBox As TextBox
    Friend WithEvents Electricity_RebateTextBox As TextBox
    Friend WithEvents Vehicle_Maintenance_AllowanceTextBox As TextBox
    Friend WithEvents Market_PremiumTextBox As TextBox
    Friend WithEvents Entertainment_AllowanceTextBox As TextBox
    Friend WithEvents Security_and_SanitationTextBox As TextBox
    Friend WithEvents DeductionsDataBindingSource As BindingSource
    Friend WithEvents DeductionsDataTableAdapter As finalDatabaseDataSetTableAdapters.DeductionsDataTableAdapter
    Friend WithEvents IRS_taxTextBox As TextBox
    Friend WithEvents Hospital_LevyTextBox As TextBox
    Friend WithEvents Super_AnnuationTextBox As TextBox
    Friend WithEvents SSNITTextBox As TextBox
    Friend WithEvents WelfareTextBox As TextBox
    Friend WithEvents GrossPayTextBox As TextBox
    Friend WithEvents NetPayTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Bank_NameComboBox As ComboBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
    Friend WithEvents Staff_numberTextBox1 As TextBox
    Friend WithEvents Staff_numberTextBox2 As TextBox
End Class
