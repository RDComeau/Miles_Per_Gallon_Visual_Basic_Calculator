Public Class frmMilesPerGallon
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears the texts
        txtGallons.Clear()
        txtMiles.Clear()
        'This clears the lblMpg2 when the clear button is pressed. 
        lblMpg2.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This closes the form.
        Me.Close()
    End Sub

    Private Sub btnCalMpg_Click(sender As Object, e As EventArgs) Handles btnCalMpg.Click
        'My variables
        Dim Miles As Single
        Dim Gallons As Single
        Dim MPG As Single

        Try
            'Conversion from text to Single
            Miles = CSng(txtMiles.Text)
            Gallons = CSng(txtGallons.Text)
            'Dividing variable Dim Miles and Dim Gallons to get Dim MPG
            MPG = Miles / Gallons

            ' "N2" is for rounding to the second decimal place. This also converts the Single to a String.
            'lblMpg2.Text will now display the Miles per Gallons on the Form.
            lblMpg2.Text = MPG.ToString("N2")
        Catch
            'Dispaly an error message.
            lblStatus.Text = "Error: Enter a nonzero" & " numeric value."
        End Try
    End Sub

End Class
