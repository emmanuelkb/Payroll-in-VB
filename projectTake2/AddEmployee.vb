Public Class AddEmployee_



    Private TotalDeductions As Decimal
    Private GrossPayDecimal As Decimal


    Private Sub AddEmployee__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DeductionsDataTableAdapter.Fill(Me.FinalDatabaseDataSet.DeductionsData)
        Me.AllowancesDataTableAdapter.Fill(Me.FinalDatabaseDataSet.AllowancesData)
        Me.EmployeeDataTableAdapter.Fill(Me.FinalDatabaseDataSet.EmployeeData)
        Me.AllowancesDataBindingSource.AddNew()
        Me.DeductionsDataBindingSource.AddNew()
        Me.EmployeeDataBindingSource.AddNew()

        TitleComboBox.Select()

        Staff_numberTextBox.Text = Me.EmployeeDataBindingSource.Count
        Staff_numberTextBox1.Text = Me.AllowancesDataBindingSource.Count
        Staff_numberTextBox1.Visible = False
        Staff_numberTextBox2.Text = Me.DeductionsDataBindingSource.Count
        Staff_numberTextBox2.Visible = False



    End Sub

    Private Sub Staff_numberTextBox_TextChanged(sender As Object, e As EventArgs) Handles Staff_numberTextBox.TextChanged
    End Sub

    Private Sub TitleLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GenderLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try

            Me.Validate()
            Me.AllowancesDataBindingSource.EndEdit()
            Me.EmployeeDataBindingSource.EndEdit()
            Me.DeductionsDataBindingSource.EndEdit()

            EmployeeDataTableAdapter.Update(FinalDatabaseDataSet.EmployeeData)
            AllowancesDataTableAdapter.Update(FinalDatabaseDataSet.AllowancesData)
            DeductionsDataTableAdapter.Update(FinalDatabaseDataSet.DeductionsData)
            FinalDatabaseDataSet.AcceptChanges()

            MessageBox.Show("Employee Succesfully Added")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        TitleComboBox.Focus()
        TitleComboBox.ResetText()
        SurnameTextBox.Clear()
        First_NameTextBox.Clear()
        Other_NameTextBox.Clear()
        GenderComboBox.ResetText()
        DOBDateTimePicker.ResetText()
        Home_addressTextBox.Clear()
        EmailTextBox.Clear()
        Phone_NumberMaskedTextBox.Clear()
        Staff_LevelComboBox.ResetText()
        DepartmentTextBox.Clear()
        Job_TitleTextBox.Clear()
        Date_JoinedDateTimePicker.ResetText()
        Basic_PayTextBox.Clear()
        Bank_NameComboBox.ResetText()
        Bank_ACTextBox.Clear()
        Bank_BranchTextBox.Clear()
        ResponsibiltyTextBox.Clear()
        Off_CampusTextBox.Clear()
        Rent_AllowanceTextBox.Clear()
        Electricity_RebateTextBox.Clear()
        Vehicle_Maintenance_AllowanceTextBox.Clear()
        Market_PremiumTextBox.Clear()
        Entertainment_AllowanceTextBox.Clear()
        Security_and_SanitationTextBox.Clear()
        IRS_taxTextBox.Clear()
        Hospital_LevyTextBox.Clear()
        Super_AnnuationTextBox.ResetText()
        SSNITTextBox.Clear()
        WelfareTextBox.Clear()
        GrossPayTextBox.Clear()
        NetPayTextBox.Clear()
        ResponsibiltyTextBox.Visible = True
        Off_CampusTextBox.Visible = True
        Rent_AllowanceTextBox.Visible = True
        Electricity_RebateTextBox.Visible = True
        Vehicle_Maintenance_AllowanceTextBox.Visible = True
        Market_PremiumTextBox.Visible = True
        Entertainment_AllowanceTextBox.Visible = True
        Security_and_SanitationTextBox.Visible = True

    End Sub

    ' Private Sub Basic_PayTextBox_TextChanged(sender As Object, e As EventArgs) Handles Basic_PayTextBox.TextChanged
    'Try
    '       Super_AnnuationTextBox.Text = Basic_PayTextBox.Text * 0.25
    'Catch ex As Exception
    '       MsgBox(ex.Message)
    'End Try
    'End Sub

    Private Sub Staff_LevelComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Staff_LevelComboBox.SelectedIndexChanged
        Select Case Staff_LevelComboBox.Text
            Case "Junior Staff"
                ResponsibiltyTextBox.Visible = False
                Electricity_RebateTextBox.Visible = False
                Market_PremiumTextBox.Visible = False
                Off_CampusTextBox.Visible = True
                Rent_AllowanceTextBox.Visible = True
                Vehicle_Maintenance_AllowanceTextBox.Visible = True
                Entertainment_AllowanceTextBox.Visible = True
                Security_and_SanitationTextBox.Visible = True
                Hospital_LevyTextBox.Text = 5
                WelfareTextBox.Text = 10
                SSNITTextBox.Text = 25
            Case "Senior Staff"
                Market_PremiumTextBox.Visible = False
                ResponsibiltyTextBox.Visible = True
                Off_CampusTextBox.Visible = True
                Rent_AllowanceTextBox.Visible = True
                Electricity_RebateTextBox.Visible = True
                Vehicle_Maintenance_AllowanceTextBox.Visible = True
                Entertainment_AllowanceTextBox.Visible = True
                Security_and_SanitationTextBox.Visible = True
                Hospital_LevyTextBox.Text = 10
                WelfareTextBox.Text = 20
                SSNITTextBox.Text = 25
            Case "Senior Member"
                Rent_AllowanceTextBox.Visible = False
                Entertainment_AllowanceTextBox.Visible = False
                Security_and_SanitationTextBox.Visible = False
                ResponsibiltyTextBox.Visible = True
                Electricity_RebateTextBox.Visible = True
                Off_CampusTextBox.Visible = True
                Vehicle_Maintenance_AllowanceTextBox.Visible = True
                Market_PremiumTextBox.Visible = True
                Hospital_LevyTextBox.Text = 20
                WelfareTextBox.Text = 20
                SSNITTextBox.Text = 25
        End Select

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        Admin.Show()

    End Sub

    Private Sub AddEmployee__Click(sender As Object, e As EventArgs) Handles Me.Click
        Try
            Super_AnnuationTextBox.Text = Basic_PayTextBox.Text * 0.25
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        Select Case Staff_LevelComboBox.Text
            Case "Junior Staff"
                Dim BasicPayDecimal = Decimal.Parse(Basic_PayTextBox.Text, Globalization.NumberStyles.Currency)
                'Dim ResponsibiityDecimal = Decimal.Parse(ResponsibiltyTextBox.Text, Globalization.NumberStyles.Currency)
                Dim OffCampusDecimal = Decimal.Parse(Off_CampusTextBox.Text, Globalization.NumberStyles.Currency)
                Dim RentAllowanceDecimal = Decimal.Parse(Rent_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                'Dim ElectricityDecimal = Decimal.Parse(Electricity_RebateTextBox.Text, Globalization.NumberStyles.Currency)
                Dim VehicleDecimal = Decimal.Parse(Vehicle_Maintenance_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                'Dim MarketDecimal = Decimal.Parse(Market_PremiumTextBox.Text, Globalization.NumberStyles.Currency)
                Dim EntertainmentDecimal = Decimal.Parse(Entertainment_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                Dim SecurityandSanitationDecimal = Decimal.Parse(Security_and_SanitationTextBox.Text, Globalization.NumberStyles.Currency)

                GrossPayDecimal = Decimal.Parse(BasicPayDecimal + (OffCampusDecimal + RentAllowanceDecimal + VehicleDecimal + EntertainmentDecimal + SecurityandSanitationDecimal), Globalization.NumberStyles.Currency)
                GrossPayTextBox.Text = GrossPayDecimal.ToString

            Case "Senior Staff"
                Dim BasicPayDecimal = Decimal.Parse(Basic_PayTextBox.Text, Globalization.NumberStyles.Currency)
                Dim ResponsibiityDecimal = Decimal.Parse(ResponsibiltyTextBox.Text, Globalization.NumberStyles.Currency)
                Dim OffCampusDecimal = Decimal.Parse(Off_CampusTextBox.Text, Globalization.NumberStyles.Currency)
                Dim RentAllowanceDecimal = Decimal.Parse(Rent_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                Dim ElectricityDecimal = Decimal.Parse(Electricity_RebateTextBox.Text, Globalization.NumberStyles.Currency)
                Dim VehicleDecimal = Decimal.Parse(Vehicle_Maintenance_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                'Dim MarketDecimal = Decimal.Parse(Market_PremiumTextBox.Text, Globalization.NumberStyles.Currency)
                Dim EntertainmentDecimal = Decimal.Parse(Entertainment_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                Dim SecurityandSanitationDecimal = Decimal.Parse(Security_and_SanitationTextBox.Text, Globalization.NumberStyles.Currency)

                GrossPayDecimal = Decimal.Parse(BasicPayDecimal + (ResponsibiityDecimal + OffCampusDecimal + ElectricityDecimal + RentAllowanceDecimal + VehicleDecimal + EntertainmentDecimal + SecurityandSanitationDecimal), Globalization.NumberStyles.Currency)
                GrossPayTextBox.Text = GrossPayDecimal.ToString

            Case "Senior Member"
                Dim BasicPayDecimal = Decimal.Parse(Basic_PayTextBox.Text, Globalization.NumberStyles.Currency)
                Dim ResponsibiityDecimal = Decimal.Parse(ResponsibiltyTextBox.Text, Globalization.NumberStyles.Currency)
                Dim OffCampusDecimal = Decimal.Parse(Off_CampusTextBox.Text, Globalization.NumberStyles.Currency)
                'Dim RentAllowanceDecimal = Decimal.Parse(Rent_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                Dim ElectricityDecimal = Decimal.Parse(Electricity_RebateTextBox.Text, Globalization.NumberStyles.Currency)
                Dim VehicleDecimal = Decimal.Parse(Vehicle_Maintenance_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                Dim MarketDecimal = Decimal.Parse(Market_PremiumTextBox.Text, Globalization.NumberStyles.Currency)
                'Dim EntertainmentDecimal = Decimal.Parse(Entertainment_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                'Dim SecurityandSanitationDecimal = Decimal.Parse(Security_and_SanitationTextBox.Text, Globalization.NumberStyles.Currency)

                GrossPayDecimal = Decimal.Parse(BasicPayDecimal + (ResponsibiityDecimal + MarketDecimal + OffCampusDecimal + VehicleDecimal + ElectricityDecimal), Globalization.NumberStyles.Currency)
                GrossPayTextBox.Text = GrossPayDecimal.ToString
        End Select

        'CAlculating IRS tax
        Dim IRSdecimal As Decimal
        If GrossPayDecimal <= 3132 Then
            IRSdecimal = 0
            IRS_taxTextBox.Text = IRSdecimal

        ElseIf GrossPayDecimal <= 3972 Then
            IRSdecimal = ((GrossPayDecimal - 3132) * 0.05)
            IRS_taxTextBox.Text = IRSdecimal

        ElseIf GrossPayDecimal <= 5172 Then
            IRSdecimal = ((GrossPayDecimal - 3972) * 0.1) + (3972 * 0.05)
            IRS_taxTextBox.Text = IRSdecimal

        ElseIf GrossPayDecimal <= 38892 Then
            IRSdecimal = ((GrossPayDecimal - 5172) * 0.175) + (5172 * 0.1) + (3972 * 0.05)
            IRS_taxTextBox.Text = IRSdecimal

        ElseIf GrossPayDecimal > 38892 Then
            IRSdecimal = ((GrossPayDecimal - 38892) * 0.25) + (33720 * 0.175) + (1200 * 0.1) + (840 * 0.05)
            IRS_taxTextBox.Text = IRSdecimal
        End If

        ' Calculating Net Salary
        Try
            Dim HospitalDecimal = Decimal.Parse(Hospital_LevyTextBox.Text, Globalization.NumberStyles.Currency)
            Dim WelfareDecimal = Decimal.Parse(WelfareTextBox.Text, Globalization.NumberStyles.Currency)
            Dim SuperAnnuationDecimal = Decimal.Parse(Super_AnnuationTextBox.Text, Globalization.NumberStyles.Currency)
            Dim SSNITDecimal = Decimal.Parse(SSNITTextBox.Text, Globalization.NumberStyles.Currency)

            TotalDeductions = IRSdecimal + WelfareDecimal + HospitalDecimal + SuperAnnuationDecimal + SSNITDecimal
            Dim NetPay As Decimal = GrossPayDecimal - TotalDeductions
            NetPayTextBox.Text = NetPay.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Super_AnnuationTextBox_TextChanged(sender As Object, e As EventArgs) Handles Super_AnnuationTextBox.TextChanged

    End Sub

    Private Sub AddEmployee__Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Admin.Show()

    End Sub
End Class