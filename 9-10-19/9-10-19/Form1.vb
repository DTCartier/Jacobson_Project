'Program: Calculates Sales
'Date: 9-10-19
'Programmer : Darryl Carter

Public Class frmJacobsonPro
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'Calculates the sale tax times the user input.
    Private Sub btnCalculation_Click(sender As Object, e As EventArgs) Handles btnCalculation.Click
        Dim sale, saleTax As Double

        Double.TryParse(txtSaleAmount.Text, sale)
        saleTax = 0.07
        lblTax.Text = sale * saleTax
        'the result is sent to display
        lblTotalDueOutput.Text = (sale * saleTax) + sale

    End Sub
End Class
