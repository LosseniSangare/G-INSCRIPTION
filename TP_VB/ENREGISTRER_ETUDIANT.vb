
Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Public Class ENREGISTRER_ETUDIANT

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim date_nais As String = JJ_BOX.SelectedItem & "/" & MM_BOX.SelectedItem & "/" & AA_BOX.SelectedItem
            CN.Open()
            cmd1.Connection = CN
            cmd1.CommandText = "INSERT INTO etudiant(nce_et,nom_etud,prenom_etud,date_nais,lieu_nais) VALUES('" & NCE_TXT.Text & "','" & NOM_TXT.Text & "', '" & PRENOM_TXT.Text & "','" & date_nais & "','" & LIEU_TXT.Text & "')"
            dr1 = cmd1.ExecuteReader
            CN.Close()


            Try
                CN.Open()
                cmd.Connection = CN
                cmd.CommandText = "SELECT * FROM classe WHERE niveau='" & niveau & "' AND specialite ='" & specialite & "'  "
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
                cmd.CommandText = "INSERT INTO inscrire(nce_et,id_class,annee) VALUES('" & NCE_TXT.Text & "', '" & code_class & "','" & ANNEE_TXT.SelectedItem & "')"
                dr = cmd.ExecuteReader

                MsgBox("ETUDIANT " & NOM_TXT.Text & " ENREDISTRE AVEC SUCCES!!!")
                CN.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                CN.Close()
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()
        End Try

     


    End Sub

    Private Sub MI_Click(sender As Object, e As EventArgs) Handles MI.Click
        niveau = "LICENCE 1"
        specialite = "MATHS INFO"
        MENU1.Text = "L1 MATHS INFO"
    End Sub

    Private Sub L3_INFO_Click(sender As Object, e As EventArgs) Handles L3_INFO.Click
        niveau = "LICENCE 3"
        specialite = "INFORMATIQUE"
        MENU1.Text = "L3 INFO"
    End Sub

    Private Sub L2_INFO_Click(sender As Object, e As EventArgs) Handles L2_INFO.Click
        niveau = "LICENCE 2"
        specialite = "INFORMATIQUE"
        MENU1.Text = "L2 INFO"
    End Sub

    Private Sub M1_GI_Click(sender As Object, e As EventArgs) Handles M1_GI.Click
        niveau = "MASTER 1"
        specialite = "GENIE INFORMATIQUE"
        MENU1.Text = "M1 GI"
    End Sub

    Private Sub M2_GI_Click(sender As Object, e As EventArgs) Handles M2_GI.Click
        niveau = "MASTER 2"
        specialite = "GENIE INFORMATIQUE"
        MENU1.Text = "M2 GI"
    End Sub

    Private Sub M1_MIAGE_Click(sender As Object, e As EventArgs) Handles M1_MIAGE.Click
        niveau = "MASTER 1"
        specialite = "M1 MIAGE"
    End Sub

    Private Sub M2_MIAGE_Click(sender As Object, e As EventArgs) Handles M2_MIAGE.Click
        niveau = "MASTER 2"
        specialite = "MIAGE"
        MENU1.Text = "M2 MIAGE"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()
        ACCUEIL.Show()

    End Sub

    Private Sub L1_PC_Click(sender As Object, e As EventArgs) Handles L1_PC.Click
        niveau = "LICENCE 1"
        specialite = "PHYSIQUE CHIMIE"
        MENU1.Text = "L1 PC"
    End Sub

    Private Sub L2_MATHS_Click(sender As Object, e As EventArgs) Handles L2_MATHS.Click
        niveau = "LICENCE 2"
        specialite = "MATHEMATIQUES"
        MENU1.Text = "L2 MATHS"
    End Sub

    Private Sub L3_MATHS_Click(sender As Object, e As EventArgs) Handles L3_MATHS.Click
        niveau = "LICENCE 3"
        specialite = "MATHEMATIQUES"
        MENU1.Text = "L2 MATHS"
    End Sub

    Private Sub PC_Click(sender As Object, e As EventArgs) Handles PC.Click
  
    End Sub

    Private Sub L3_PH_Click(sender As Object, e As EventArgs) Handles L3_PH.Click
        niveau = "LICENCE 3"
        specialite = "PHYSIQUE"
        MENU1.Text = "L2 PHYSIQUE"
    End Sub

    Private Sub M1_PH_Click(sender As Object, e As EventArgs) Handles M1_PH.Click
        niveau = "MASTER 1"
        specialite = "PHYSIQUE"
        MENU1.Text = "M1 PHYSIQUE"
    End Sub

    Private Sub ENREGISTRER_ETUDIANT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1960 To Year(Now) + 3
            AA_BOX.Items.Add(i)
        Next
    End Sub

    Private Sub L3_CH_Click(sender As Object, e As EventArgs) Handles L3_CH.Click
        niveau = "LICENCE 3"
        specialite = "CHIMIE"
        MENU1.Text = "L3 CHIMIE"
    End Sub

    Private Sub M1_CH_Click(sender As Object, e As EventArgs) Handles M1_CH.Click
        niveau = "MASTER 1"
        specialite = "CHIMIE"
        MENU1.Text = "M1 CHIMIE"
    End Sub

    Private Sub M2_CH_Click(sender As Object, e As EventArgs) Handles M2_CH.Click
        niveau = "MASTER 2"
        specialite = "CHIMIE"
        MENU1.Text = "M2 CHIMIE"
    End Sub

    Private Sub M2_PH_Click(sender As Object, e As EventArgs) Handles M2_PH.Click
        niveau = "MASTER 2"
        specialite = "PHYSIQUE"
        MENU1.Text = "M2 PHYSIQUE"
    End Sub


End Class