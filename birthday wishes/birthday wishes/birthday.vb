Public Class birthday

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'print happy birthday song to listbox
        lstOut.Items.Add("Happy Birthday to you,")
        lstOut.Items.Add("Happy Birthday to you,")
        lstOut.Items.Add("Happy Birthday dear, " & txtName.Text & "!")
        lstOut.Items.Add("Happy Birthday to you!")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear txtName value
        txtName.Clear()
        lstOut.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'exits the program for the user
        Application.Exit()

    End Sub

End Class
