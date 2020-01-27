Public Class ENREGISTRER_CLASSE

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SElECT * FROM CLASSE"
            dr = cmd.ExecuteReader
            While dr.Read
                If NIVEAU_TXT.SelectedItem = dr.GetValue(1) And SPECIALITE_BOX.Text = dr.GetValue(2) Then
                    MsgBox("DESOLE CETTE CLASSE EXIST DEJA !")
                    existe = True
                End If
            End While

            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()
        End Try

        If existe = False Then

            Try
                CN.Open()
                cmd.Connection = CN
                cmd.CommandText = "INSERT INTO classe(niveau,specialite) VALUE('" & NIVEAU_TXT.SelectedItem & "','" & SPECIALITE_BOX.Text & "')"
                dr = cmd.ExecuteReader
                MsgBox("CLASSE ENREGISTRER AVEC SUCCES !!!")
                SPECIALITE_BOX.Text = ""
                NIVEAU_TXT.Text = ""
                CN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                CN.Close()

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        ACCUEIL.Show()

    End Sub

    Private Sub ENREGISTRER_CLASSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT * FROM filiere"
            dr = cmd.ExecuteReader
            While dr.Read
                SPECIALITE_BOX.Items.Add(dr.GetValue(0))
            End While
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try

        Try
            CN.Open()
            cmd1.Connection = CN
            cmd1.CommandText = "SELECT *FROM grade"
            dr1 = cmd1.ExecuteReader
            While dr1.Read
                NIVEAU_TXT.Items.Add(dr1.GetValue(0))
            End While
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()
        End Try


    End Sub
End Class