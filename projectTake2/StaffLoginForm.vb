Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient



Public Class StaffLoginForm

    Private connection As New SqlConnection("Server= ADMINRG-58B6RJF\SQLEXPRESS; Database =  finalDatabase; Integrated Security = true")

    'Private getReader As SqlDataReader



    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        Try
            'Dim query As String = "SELECT EmployeeData.Title, EmployeeData.Surname, EmployeeData.First_Name, EmployeeData.Other_Name, EmployeeData.Staff_number, EmployeeData.Department, EmployeeData.Bank_Name, EmployeeData.Bank_AC, EmployeeData.Bank_Branch, EmployeeData.Job_Title, EmployeeData.Basic_Pay, EmployeeData.GrossPay, EmployeeData.NetPay " &
            '     "DeductionsData.IRS_tax, DeductionsData.Hospital_Levy, DeductionsData.Super_Annuation, DeductionsData.SSNIT, DeductionsData.Welfare, AllowancesData.Responsibilty, AllowancesData.Off_Campus, AllowancesData.Rent_Allowance, AllowancesData.Electricity_Rebate, AllowancesData.Vehicle_Maintenance_ALlowance, AllowancesData.Market_Premium, AllowancesData.Entertainment_Allowance, AllowancesData.Security_and_Sanitation, FROM EmployeeData, AllowancesData, DeductionsData " &
            '    "WHERE EmployeeData.Staff_number = AllowancesData.Staff_number AND EmployeeData.Staff_number = DeductionsData.Staff_number AND EmployeeData.Staff_number ='" & Staff_numberTextBox.Text & "'"

            Dim query As String = "SELECT EmployeeData.Title, EmployeeData.Surname, " _
    + "EmployeeData.First_Name, EmployeeData.Other_Name, EmployeeData.Staff_number," _
    + "EmployeeData.Department, EmployeeData.Bank_Name, EmployeeData.Bank_AC, EmployeeData.Bank_Branch, " _
    + "EmployeeData.Job_Title, EmployeeData.Basic_Pay, EmployeeData.GrossPay, EmployeeData.NetPay," _
    + "DeductionsData.IRS_tax, DeductionsData.Hospital_Levy, DeductionsData.Super_Annuation, " _
    + "DeductionsData.SSNIT,DeductionsData.Welfare, AllowancesData.Responsibilty, AllowancesData.Off_Campus," _
    + "AllowancesData.Rent_Allowance, AllowancesData.Electricity_Rebate," _
    + "AllowancesData.Vehicle_Maintenance_Allowance, AllowancesData.Market_Premium, " _
    + "AllowancesData.Entertainment_Allowance, AllowancesData.Security_and_Sanitation " _
    + "FROM EmployeeData, AllowancesData, DeductionsData " _
    + "WHERE EmployeeData.Staff_number = AllowancesData.Staff_number AND " _
    + "EmployeeData.Staff_number = DeductionsData.Staff_number AND EmployeeData.Staff_number ='" & Staff_numberTextBox.Text & "'"

            'Using Staff Level to get Payslip
            Dim command1 As New SqlCommand("select * from EmployeeData where Staff_number = @Staff_Number ", connection)
            command1.Parameters.Add("@Staff_Number", SqlDbType.VarChar).Value = Staff_numberTextBox.Text
            Dim adapter As New SqlDataAdapter(command1)
            Dim table As New DataTable()
            adapter.Fill(table)
            ' If table.Rows.Count() > 0 Then
            Dim Staff_level = table.Rows(0)(10).ToString()
            'Else

            ' MessageBox.Show("NO DATA FOUND")

            'End If


            Using connection
                Dim command As New SqlCommand(query, connection)
                connection.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()





                If reader.Read = True Then
                    Select Case Staff_level
                        Case "Junior Staff"
                            payslipForm.MonthLabel.Text = Format(Date.Today, "MMMMMMMMMM,yyyy")
                            payslipForm.NameLabel.Text = (reader.Item("Surname").ToString) + " , " + (reader.Item("First_Name").ToString) + " " + (reader.Item("Other_Name").ToString)
                            payslipForm.Staff_noLabel.Text = (reader.Item("Staff_number").ToString)
                            payslipForm.Bank_BranchLabel.Text = (reader.Item("Bank_Branch").ToString)
                            payslipForm.Bank_ACLabel.Text = (reader.Item("Bank_AC").ToString)
                            payslipForm.BankNameLabel.Text = (reader.Item("Bank_Name").ToString)
                            payslipForm.DepartmentLabel.Text = (reader.Item("Department").ToString)
                            payslipForm.Job_TitleLabel.Text = (reader.Item("Job_Title").ToString)
                            payslipForm.BasicSalaryLabel.Text = (reader.Item("Basic_Pay").ToString)
                            payslipForm.BasicPayLabel.Text = (reader.Item("Basic_Pay").ToString)
                            payslipForm.GrossPayLabel.Text = (reader.Item("GrossPay").ToString)
                            payslipForm.NetPayLabel.Text = (reader.Item("NetPay").ToString)
                            payslipForm.IRS_TaxLabel.Text = (reader.Item("IRS_tax").ToString)
                            payslipForm.HospitalLabel.Text = (reader.Item("Hospital_Levy").ToString)
                            payslipForm.SuperAnnuationLabel.Text = (reader.Item("Super_Annuation").ToString)
                            payslipForm.SsnitLabel.Text = (reader.Item("SSNIT").ToString)
                            payslipForm.WelfareLabel.Text = (reader.Item("Welfare").ToString)
                            payslipForm.OffCampusLabel.Text = (reader.Item("Off_Campus").ToString)
                            payslipForm.RentLabel.Text = (reader.Item("Rent_Allowance").ToString)
                            payslipForm.VehicleLabel.Text = (reader.Item("Vehicle_Maintenance_Allowance").ToString)
                            payslipForm.EntertainmentLabel.Text = (reader.Item("Entertainment_Allowance").ToString)
                            payslipForm.SecurityLabel.Text = (reader.Item("Security_and_Sanitation").ToString)
                            'payslipForm.MarketLabel.Text = (reader.Item("Market_Premium").ToString)
                            'payslipForm.ElectricityLabel.Text = (reader.Item("Electricity_Rebate").ToString)
                            'payslipForm.ResponsibilityLabel.Text = (reader.Item("Responsibility").ToString)

                            payslipForm.Show()

                        Case "Senior Staff"
                            payslipForm1.MonthLabel.Text = Format(Date.Today, "MMMMMMMMMM,yyyy")
                            payslipForm1.NameLabel.Text = (reader.Item("Surname").ToString) + " , " + (reader.Item("First_Name").ToString) + " " + (reader.Item("Other_Name").ToString)
                            payslipForm1.Staff_noLabel.Text = (reader.Item("Staff_number").ToString)
                            payslipForm1.Bank_BranchLabel.Text = (reader.Item("Bank_Branch").ToString)
                            payslipForm1.Bank_ACLabel.Text = (reader.Item("Bank_AC").ToString)
                            payslipForm1.BankNameLabel.Text = (reader.Item("Bank_Name").ToString)
                            payslipForm1.DepartmentLabel.Text = (reader.Item("Department").ToString)
                            payslipForm1.Job_TitleLabel.Text = (reader.Item("Job_Title").ToString)
                            payslipForm1.BasicSalaryLabel.Text = (reader.Item("Basic_Pay").ToString)
                            payslipForm1.BasicPayLabel.Text = (reader.Item("Basic_Pay").ToString)
                            payslipForm1.GrossPayLabel.Text = (reader.Item("GrossPay").ToString)
                            payslipForm1.NetPayLabel.Text = (reader.Item("NetPay").ToString)
                            payslipForm1.IRS_TaxLabel.Text = (reader.Item("IRS_tax").ToString)
                            payslipForm1.HospitalLabel.Text = (reader.Item("Hospital_Levy").ToString)
                            payslipForm1.SuperAnnuationLabel.Text = (reader.Item("Super_Annuation").ToString)
                            payslipForm1.SsnitLabel.Text = (reader.Item("SSNIT").ToString)
                            payslipForm1.WelfareLabel.Text = (reader.Item("Welfare").ToString)
                            payslipForm1.OffCampusLabel.Text = (reader.Item("Off_Campus").ToString)
                            payslipForm1.RentLabel.Text = (reader.Item("Rent_Allowance").ToString)
                            payslipForm1.VehicleLabel.Text = (reader.Item("Vehicle_Maintenance_Allowance").ToString)
                            payslipForm1.EntertainmentLabel.Text = (reader.Item("Entertainment_Allowance").ToString)
                            payslipForm1.SecurityLabel.Text = (reader.Item("Security_and_Sanitation").ToString)
                            'payslipForm.MarketLabel.Text = (reader.Item("Market_Premium").ToString)
                            payslipForm1.ElectricityLabel.Text = (reader.Item("Electricity_Rebate").ToString)
                            payslipForm1.ResponsibilityLabel.Text = (reader.Item("Responsibilty").ToString)



                            payslipForm1.Show()

                        Case "Senior Member"
                            payslipForm2.MonthLabel.Text = Format(Date.Today, "MMMMMMMMMM,yyyy")
                            payslipForm2.NameLabel.Text = (reader.Item("Surname").ToString) + " , " + (reader.Item("First_Name").ToString) + " " + (reader.Item("Other_Name").ToString)
                            payslipForm2.Staff_noLabel.Text = (reader.Item("Staff_number").ToString)
                            payslipForm2.Bank_BranchLabel.Text = (reader.Item("Bank_Branch").ToString)
                            payslipForm2.Bank_ACLabel.Text = (reader.Item("Bank_AC").ToString)
                            payslipForm2.BankNameLabel.Text = (reader.Item("Bank_Name").ToString)
                            payslipForm2.DepartmentLabel.Text = (reader.Item("Department").ToString)
                            payslipForm2.Job_TitleLabel.Text = (reader.Item("Job_Title").ToString)
                            payslipForm2.BasicSalaryLabel.Text = (reader.Item("Basic_Pay").ToString)
                            payslipForm2.BasicPayLabel.Text = (reader.Item("Basic_Pay").ToString)
                            payslipForm2.GrossPayLabel.Text = (reader.Item("GrossPay").ToString)
                            payslipForm2.NetPayLabel.Text = (reader.Item("NetPay").ToString)
                            payslipForm2.IRS_TaxLabel.Text = (reader.Item("IRS_tax").ToString)
                            payslipForm2.HospitalLabel.Text = (reader.Item("Hospital_Levy").ToString)
                            payslipForm2.SuperAnnuationLabel.Text = (reader.Item("Super_Annuation").ToString)
                            payslipForm2.SsnitLabel.Text = (reader.Item("SSNIT").ToString)
                            payslipForm2.WelfareLabel.Text = (reader.Item("Welfare").ToString)
                            payslipForm2.OffCampusLabel.Text = (reader.Item("Off_Campus").ToString)
                            'payslipForm2.RentLabel.Text = (reader.Item("Rent_Allowance").ToString)
                            payslipForm2.VehicleLabel.Text = (reader.Item("Vehicle_Maintenance_Allowance").ToString)
                            'payslipForm2.EntertainmentLabel.Text = (reader.Item("Enetrtainment_Allowance").ToString)
                            'payslipForm2.SecurityLabel.Text = (reader.Item("Security_and_Sanitation").ToString)
                            payslipForm2.MarketLabel.Text = (reader.Item("Market_Premium").ToString)
                            payslipForm2.ElectricityLabel.Text = (reader.Item("Electricity_Rebate").ToString)
                            payslipForm2.ResponsibilityLabel.Text = (reader.Item("Responsibilty").ToString)



                            payslipForm2.Show()


                    End Select

                Else

                        MsgBox("Sorry no data found!", MsgBoxStyle.Information)
                        Staff_numberTextBox.Focus()


                End If

                reader.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub EmployeeDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinalDatabaseDataSet)

    End Sub

    Private Sub Staff_numberTextBox_TextChanged(sender As Object, e As EventArgs) Handles Staff_numberTextBox.TextChanged

    End Sub

    Private Sub StaffLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

