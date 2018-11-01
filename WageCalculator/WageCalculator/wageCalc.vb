Public Class wageCalc
    Dim x As Integer
    Dim managerHrRate As Double = 23.06
    Private Sub txtBoxRole_TextChanged(sender As Object, e As EventArgs) Handles txtBoxRole.TextChanged
        If txtBoxRole.Text = "Managing Director" Then
            txtBoxWage.Text = "45,000"
            txtBoxTax.Text = "40"
        End If
        If txtBoxRole.Text = "Sales Assistance" Then
            txtBoxWage.Text = "22,000"
            txtBoxTax.Text = "20"
        End If
        If txtBoxRole.Text = "Receptionist" Then
            txtBoxWage.Text = "18,000"
            txtBoxTax.Text = "20"
        End If
        If txtBoxRole.Text = "Finance Staff" Then
            txtBoxWage.Text = "24,000"
            txtBoxTax.Text = "20"
        End If
        If txtBoxRole.Text = "" Then
            txtBoxWage.Text = "Please enter a job"
            txtBoxTax.Text = "Enter Job"
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        x = txtBoxOvertimeHrs.Text
        If txtBoxRole.Text = "Managing Director" Then
            txtBoxOvertimePay.Text = x + (managerHrRate * 2)
        End If
    End Sub
End Class