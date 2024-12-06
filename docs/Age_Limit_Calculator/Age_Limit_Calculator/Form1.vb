Public Class Form1
    Const AgeLimit As Integer = 18

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim ageInput As String = TextBox1.Text
        Dim intAge As Integer
        Dim isValidAge As Boolean = Integer.TryParse(ageInput, intAge)

        If Not isValidAge OrElse String.IsNullOrWhiteSpace(ageInput) Then
            MessageBox.Show("Please Enter A valid Age!")

        Else
            If intAge < AgeLimit Then
                MessageBox.Show("Your age is under the limit!")
            ElseIf intAge > AgeLimit + 20 Then
                MessageBox.Show("Your are too old!")
            Else
                MessageBox.Show("Your Age is whithin the acceptable range!")
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        End
    End Sub


End Class
