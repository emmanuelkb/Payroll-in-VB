Imports System.Data.SqlClient

Public Class SearchForm
    Private connection As New SqlConnection("Server= ADMINRG-58B6RJF\SQLEXPRESS; Database =  finalDatabase; Integrated Security = true")
    Private TotalDeductions As Decimal
    Private GrossPayDecimal As Decimal

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub


    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        'Me.EmployeeDataBindingSource.Filter = "Staff_Number LIKE '" & StaffNumberTextBox.Text & "%'"
        'Me.EmployeeDataBindingSource.Filter = "Staff_Number = '" & StaffNumberTextBox.Text & "%'"

        'Reset before search??
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
        ResponsibiltyTextBox.Visible = True
        Off_CampusTextBox.Visible = True
        Rent_AllowanceTextBox.Visible = True
        Electricity_RebateTextBox.Visible = True
        Vehicle_Maintenance_AllowanceTextBox.Visible = True
        Market_PremiumTextBox.Visible = True
        Entertainment_AllowanceTextBox.Visible = True
        Security_and_SanitationTextBox.Visible = True
        GrossPayTextBox.ResetText()
        NetPayTextBox.ResetText()

        Dim command As New SqlCommand("select * from EmployeeData where Staff_number = @Staff_Number ", connection)
        Dim command1 As New SqlCommand("select * from AllowancesData where Staff_number = @Staff_Number ", connection)
        Dim command2 As New SqlCommand("select * from DeductionsData where Staff_number = @Staff_Number ", connection)

        command.Parameters.Add("@Staff_Number", SqlDbType.VarChar).Value = StaffNumberTextBox.Text
        command1.Parameters.Add("@Staff_Number", SqlDbType.VarChar).Value = StaffNumberTextBox.Text
        command2.Parameters.Add("@Staff_Number", SqlDbType.VarChar).Value = StaffNumberTextBox.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim adapter1 As New SqlDataAdapter(command1)
        Dim adapter2 As New SqlDataAdapter(command2)

        Dim table As New DataTable()
        Dim table1 As New DataTable()
        Dim table2 As New DataTable()

        adapter.Fill(table)
        adapter1.Fill(table1)
        adapter2.Fill(table2)

        If table.Rows.Count() > 0 Then

            TitleComboBox.SelectedText = table.Rows(0)(1).ToString()
            SurnameTextBox.SelectedText = table.Rows(0)(2).ToString()
            First_NameTextBox.SelectedText = table.Rows(0)(3).ToString()
            Other_NameTextBox.SelectedText = table.Rows(0)(4).ToString()
            GenderComboBox.SelectedText = table.Rows(0)(5).ToString()
            DOBDateTimePicker.Text = table.Rows(0)(6).ToString()
            Home_addressTextBox.SelectedText = table.Rows(0)(7).ToString()
            EmailTextBox.SelectedText = table.Rows(0)(8).ToString()
            Phone_NumberMaskedTextBox.SelectedText = table.Rows(0)(9).ToString()
            Staff_LevelComboBox.SelectedText = table.Rows(0)(10).ToString()
            DepartmentTextBox.SelectedText = table.Rows(0)(11).ToString()
            Job_TitleTextBox.SelectedText = table.Rows(0)(12).ToString()
            Date_JoinedDateTimePicker.Text = table.Rows(0)(13).ToString
            Basic_PayTextBox.SelectedText = table.Rows(0)(14).ToString()
            Bank_ACTextBox.SelectedText = table.Rows(0)(15).ToString()
            Bank_NameComboBox.SelectedText = table.Rows(0)(16).ToString()
            Bank_BranchTextBox.SelectedText = table.Rows(0)(17).ToString()
            GrossPayTextBox.SelectedText = table.Rows(0)(18).ToString()
            NetPayTextBox.SelectedText = table.Rows(0)(19).ToString()

            IRS_taxTextBox.SelectedText = table2.Rows(0)(1).ToString()
            Hospital_LevyTextBox.SelectedText = table2.Rows(0)(2).ToString()
            Super_AnnuationTextBox.SelectedText = table2.Rows(0)(4).ToString()
            SSNITTextBox.SelectedText = table2.Rows(0)(5).ToString()
            WelfareTextBox.SelectedText = table2.Rows(0)(6).ToString()

            ResponsibiltyTextBox.SelectedText = table1.Rows(0)(1).ToString()
            Off_CampusTextBox.SelectedText = table1.Rows(0)(2).ToString()
            Rent_AllowanceTextBox.SelectedText = table1.Rows(0)(3).ToString()
            Electricity_RebateTextBox.SelectedText = table1.Rows(0)(4).ToString()
            Vehicle_Maintenance_AllowanceTextBox.SelectedText = table1.Rows(0)(5).ToString()
            Market_PremiumTextBox.SelectedText = table1.Rows(0)(6).ToString()
            Entertainment_AllowanceTextBox.SelectedText = table1.Rows(0)(7).ToString()
            Security_and_SanitationTextBox.SelectedText = table1.Rows(0)(8).ToString()

        Else

            MessageBox.Show("NO DATA FOUND")

        End If

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
                Off_CampusTextBox.Visible = True
                Vehicle_Maintenance_AllowanceTextBox.Visible = True
                Market_PremiumTextBox.Visible = True
                Entertainment_AllowanceTextBox.Visible = True
                Hospital_LevyTextBox.Text = 20
                WelfareTextBox.Text = 20
                SSNITTextBox.Text = 25
        End Select

        Staff_numberTextBox.Text = StaffNumberTextBox.Text
        Staff_numberTextBox1.Text = StaffNumberTextBox.Text

    End Sub

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalDatabaseDataSet.DeductionsData' table. You can move, or remove it, as needed.
        Me.DeductionsDataTableAdapter.Fill(Me.FinalDatabaseDataSet.DeductionsData)
        'TODO: This line of code loads data into the 'FinalDatabaseDataSet.AllowancesData' table. You can move, or remove it, as needed.
        Me.AllowancesDataTableAdapter.Fill(Me.FinalDatabaseDataSet.AllowancesData)
        'TODO: This line of code loads data into the 'FinalDatabaseDataSet.EmployeeData' table. You can move, or remove it, as needed.
        Me.EmployeeDataTableAdapter.Fill(Me.FinalDatabaseDataSet.EmployeeData)


    End Sub

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
                Off_CampusTextBox.Visible = True
                Vehicle_Maintenance_AllowanceTextBox.Visible = True
                Market_PremiumTextBox.Visible = True
                Electricity_RebateTextBox.Visible = True
                Hospital_LevyTextBox.Text = 20
                WelfareTextBox.Text = 20
                SSNITTextBox.Text = 25
        End Select

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        Admin.Show()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Select Case Staff_LevelComboBox.Text
            Case "Junior Staff"
                ResponsibiltyTextBox.Clear()
                Electricity_RebateTextBox.Clear()
                Market_PremiumTextBox.Clear()
            Case "Senior Staff"
                Market_PremiumTextBox.Clear()
            Case "Senior Member"
                Rent_AllowanceTextBox.Clear()
                Entertainment_AllowanceTextBox.Clear()
                Security_and_SanitationTextBox.Clear()

        End Select

        Try
            Dim updateQuery1 As String = "Update AllowancesData SET Staff_number ='" & StaffNumberTextBox.Text & "' ,Responsibilty = '" & ResponsibiltyTextBox.Text & "',Off_Campus = '" & Off_CampusTextBox.Text & "',Rent_Allowance = '" & Rent_AllowanceTextBox.Text & "',Electricity_Rebate = '" & Electricity_RebateTextBox.Text & "',Vehicle_Maintenance_Allowance = '" & Vehicle_Maintenance_AllowanceTextBox.Text & "',Market_Premium = '" & Market_PremiumTextBox.Text & "',Entertainment_Allowance = '" & Entertainment_AllowanceTextBox.Text & "',Security_and_Sanitation = " & Security_and_SanitationTextBox.Text & " WHERE Staff_number =" & Staff_numberTextBox.Text & " "
            Dim updateQuery As String = "Update EmployeeData SET Staff_number ='" & StaffNumberTextBox.Text & "' ,Title = '" & TitleComboBox.Text & "' ,Surname = '" & SurnameTextBox.Text & "',First_Name = '" & First_NameTextBox.Text & "',Other_Name = '" & Other_NameTextBox.Text & "',Gender = '" & GenderComboBox.Text & "',DOB= '" & DOBDateTimePicker.Text & "',Home_address = '" & Home_addressTextBox.Text & "',Email = '" & EmailTextBox.Text & "',Phone_Number = '" & Phone_NumberMaskedTextBox.Text & "',Staff_Level = '" & Staff_LevelComboBox.Text & "',Department = '" & DepartmentTextBox.Text & "' ,Job_Title ='" & Job_TitleTextBox.Text & "' ,Date_Joined = '" & Date_JoinedDateTimePicker.Text & "' ,Basic_Pay = '" & Basic_PayTextBox.Text & "',Bank_AC = '" & Bank_ACTextBox.Text & "',Bank_Name = '" & Bank_NameComboBox.Text & "' ,Bank_Branch = '" & Bank_BranchTextBox.Text & "' ,GrossPay = '" & GrossPayTextBox.Text & "' ,NetPay = " & NetPayTextBox.Text & " WHERE Staff_number =" & StaffNumberTextBox.Text & " "
            Dim updateQuery2 As String = "Update DeductionsData  SET Staff_number ='" & StaffNumberTextBox.Text & "',IRS_tax = '" & IRS_taxTextBox.Text & "',Hospital_Levy = '" & Hospital_LevyTextBox.Text & "',Super_Annuation = '" & Super_AnnuationTextBox.Text & "',SSNIT =  '" & SSNITTextBox.Text & "',Welfare = " & WelfareTextBox.Text & " WHERE Staff_number =" & Staff_numberTextBox1.Text & " "


            ExecuteQuery(updateQuery)
            ExecuteQuery(updateQuery1)
            ExecuteQuery(updateQuery2)

            MessageBox.Show("Information Updated")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()

        End Try


        Me.Close()
        Admin.Show()

    End Sub

    Private Sub SearchForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        Try
            Super_AnnuationTextBox.Text = Basic_PayTextBox.Text * 0.25
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            Select Case Staff_LevelComboBox.Text
                Case "Junior Staff"
                    Dim BasicPayDecimal = Decimal.Parse(Basic_PayTextBox.Text, Globalization.NumberStyles.Currency)
                    'Dim ResponsibiityDecimal = Decimal.Parse(ResponsibiltyTextBox.Text, Globalization.NumberStyles.Currency)
                    Dim OffCampusDecimal = Decimal.Parse(Off_CampusTextBox.Text, Globalization.NumberStyles.Currency)
                    Dim RentAllowanceDecimal = Decimal.Parse(Rent_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                    'Dim ElectricityDecimal = Decimal.Parse(Electricity_RebateTextBox.Text, Globalization.NumberStyles.Currency)
                    Dim VehicleDecimal = Decimal.Parse(Vehicle_Maintenance_AllowanceTextBox.Text, Globalization.NumberStyles.Currency)
                    ' Dim MarketDecimal = Decimal.Parse(Market_PremiumTextBox.Text, Globalization.NumberStyles.Currency)
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



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

    Private Sub DOBDateTimePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim deleteQuery As String = "DELETE From EmployeeData Where Staff_number = " & StaffNumberTextBox.Text
        Dim deleteQuery1 As String = "DELETE From AllowancesData Where Staff_number = " & StaffNumberTextBox.Text
        Dim deleteQuery2 As String = "DELETE From DeductionsData Where Staff_number = " & StaffNumberTextBox.Text

        ExecuteQuery(deleteQuery1)
        ExecuteQuery(deleteQuery2)
        ExecuteQuery(deleteQuery)


        MessageBox.Show("User deleted")

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
        ResponsibiltyTextBox.Visible = True
        Off_CampusTextBox.Visible = True
        Rent_AllowanceTextBox.Visible = True
        Electricity_RebateTextBox.Visible = True
        Vehicle_Maintenance_AllowanceTextBox.Visible = True
        Market_PremiumTextBox.Visible = True
        Entertainment_AllowanceTextBox.Visible = True
        Security_and_SanitationTextBox.Visible = True
        GrossPayTextBox.ResetText()
        NetPayTextBox.ResetText()

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub SearchForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Admin.Show()

    End Sub
End Class