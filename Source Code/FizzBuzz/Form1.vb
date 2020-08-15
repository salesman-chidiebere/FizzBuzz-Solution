Public Class Form1

    Dim output As Integer
    Dim i As Integer
    Dim n As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fizzbuzz()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If CheckBox1.Checked Then
            fizzbuzz()
        End If

    End Sub

    Public Sub fizzbuzz()
        ListBox1.Items.Clear()

        If IsNumeric(TextBox1.Text) Then
            If CInt(TextBox1.Text) < 200000 And CInt(TextBox1.Text) > 0 Then
                n = TextBox1.Text
                i = 1
                Do Until i > n
                    If (i Mod 3) <> 0 And (i Mod 5) <> 0 Then
                        ListBox1.Items.Add(i)
                    ElseIf (i Mod 3) = 0 And (i Mod 5) <> 0 Then
                        ListBox1.Items.Add("Fizz")
                    ElseIf (i Mod 3) <> 0 And (i Mod 5) = 0 Then
                        ListBox1.Items.Add("Buzz")
                    ElseIf (i Mod 3) = 0 And (i Mod 5) = 0 Then
                        ListBox1.Items.Add("FizzBuzz")
                    End If

                    i += 1
                Loop
            Else
                MsgBox("Constraint =  n < 0 < (2 x 10^5)" & vbCrLf & vbCrLf & "Please enter a number between 1 to 200000")
            End If
        Else
            MsgBox("Please enter a numeric number")
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Constraint =  n < 0 < (2 x 10^5)")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            fizzbuzz()
        End If
    End Sub
End Class
