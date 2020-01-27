Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text <> "0000" Then
            MsgBox("PASS INCORECT ! RESSAYER")
            TextBox2.Text = ""

        Else
            ACCUEIL.Show()
            Me.Visible = False

        End If

    End Sub
End Class
