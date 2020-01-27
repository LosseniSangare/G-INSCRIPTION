Public Class INSCRIPTION

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub INSCRIPTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT * FROM etudiant"
            dr = cmd.ExecuteReader
            While dr.Read
                NOM_BOX.Items.Add(dr.GetValue(1))
            End While
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try




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
            NIVEAU_BOX.Items.Clear()

            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT * FROM grade"
            dr = cmd.ExecuteReader
            While dr.Read
                NIVEAU_BOX.Items.Add(dr.GetValue(0))
            End While
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try

        Dim an As String = 0

        For i = 1960 To Year(Now) + 3
            an = i & "-" & i + 1
            ANNEE_TXT.Items.Add(an)
        Next
        'Try
        '    CN.Open()
        '    cmd.Connection = CN
        '    cmd.CommandText = "SELECT * FROM annee_univ"
        '    dr = cmd.ExecuteReader
        '    While dr.Read
        '        ANNEE_TXT.Items.Add(dr.GetValue(0))
        '    End While
        '    CN.Close()

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    CN.Close()

        'End Try



    End Sub


    Private Sub NOM_BOX_Click(sender As Object, e As EventArgs) Handles NOM_BOX.Click
        PRENOMS_BOX.Text = ""
        PRENOMS_BOX.Items.Clear()


    End Sub






    Private Sub NOM_BOX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NOM_BOX.SelectedIndexChanged
        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT * FROM etudiant WHERE nom_etud='" & NOM_BOX.SelectedItem & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                PRENOMS_BOX.Items.Add(dr.GetValue(2))
            End While
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try
    End Sub

    Private Sub SPECIALITE_BOX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SPECIALITE_BOX.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT * FROM classe WHERE specialite='" & SPECIALITE_BOX.SelectedItem & "' AND niveau='" & NIVEAU_BOX.SelectedItem & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                code_class = dr.GetValue(0)
            End While
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try


        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT * FROM etudiant WHERE nom_etud='" & NOM_BOX.SelectedItem & "' AND prenom_etud='" & PRENOMS_BOX.SelectedItem & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                code_et = dr.GetValue(0)
            End While
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try



        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "INSERT INTO inscrire(nce_et,id_class,annee) VALUE ('" & code_et & "','" & code_class & "','" & ANNEE_TXT.SelectedItem & "')"
            dr = cmd.ExecuteReader
            MsgBox(NOM_BOX.Text & " " & PRENOMS_BOX.Text & " ENREGISTRE AVEC SUCCES !!!")
            While dr.Read
                code_class = dr.GetValue(0)
            End While

            ANNEE_TXT.Text = ""
            NOM_BOX.Text = ""
            PRENOMS_BOX.Text = ""
            SPECIALITE_BOX.Text = ""
            NIVEAU_BOX.Text = ""
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try


    End Sub

    Private Sub ANNEE_TXT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ANNEE_TXT.SelectedIndexChanged

    End Sub

    Private Sub PRENOMS_BOX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PRENOMS_BOX.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ACCUEIL.Show()
        Me.Close()

    End Sub
End Class