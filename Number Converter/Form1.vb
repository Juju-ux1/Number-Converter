Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim input As String = txtInput.Text.Trim().ToLower()
        Dim numbers = New Dictionary(Of String, Integer) From {
            {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4},
            {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}, {"ten", 10}
        }
        Try
            Dim number As Integer = If(numbers.ContainsKey(input), numbers(input), Convert.ToInt32(input))
            lblResult.Text = "Converted number is: " & number
            lblResult.ForeColor = Color.Green
        Catch ex As Exception
            lblResult.Text = "Error: Invalid number or number word."
            lblResult.ForeColor = Color.Red
        End Try

    End Sub
End Class
