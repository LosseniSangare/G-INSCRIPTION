Public Class LISTE_ETUDIANT


    Private Sub NIVEAU_TXT_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListV.SelectedIndexChanged

        For Each element As ListViewItem In ListV.Items

            If element.Selected = True Then
                element.Checked = True

            ElseIf element.Selected = False Then
                element.Checked = False
            ElseIf element.Checked = True Then
                element.Selected = True
            ElseIf element.Checked = False Then
                element.Selected = False
            End If

        Next

    End Sub

    Private Sub LISTE_ETUDIANT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VALIDER_BT.Visible = False
        MENU1.Visible = False

        
        Dim an As String = 0

        ANNEE_TXT.Items.Clear()

        For i = 1960 To Year(Now)
            an = i & "-" & i + 1
            ANNEE_TXT.Items.Add(an)
        Next


        Try
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT *FROM filiere  "
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
            compt = 0
            CN.Open()
            cmd.Connection = CN
            cmd.CommandText = "SELECT *FROM grade "
            dr = cmd.ExecuteReader
            While dr.Read
                NIVEAU_TXT.Items.Add(dr.GetValue(0))
            End While
            CN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

  

    Private Sub NIVEAU_TXT_Click(sender As Object, e As EventArgs) Handles NIVEAU_TXT.Click
        ListV.Items.Clear()
    End Sub
    Private Sub NIVEAU_TXT_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles NIVEAU_TXT.SelectedIndexChanged
        Try

            Try
                CN.Open()
                cmd.Connection = CN
                cmd.CommandText = "SELECT *FROM classe WHERE specialite='" & SPECIALITE_BOX.SelectedItem & "' AND niveau= '" & NIVEAU_TXT.SelectedItem & "' "
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
                ListV.Items.Clear()
                CN.Open()
                compt = 0
                cmd.Connection = CN
                cmd.CommandText = "SELECT e.*,i.*,c.* FROM etudiant e,inscrire i,classe c WHERE e.nce_et = i.nce_et"
                cmd.CommandText &= " AND c.specialite='" & SPECIALITE_BOX.SelectedItem & "' AND c.id_class='" & code_class & "'"
                cmd.CommandText &= "AND niveau='" & NIVEAU_TXT.SelectedItem & "' AND annee='" & ANNEE_TXT.SelectedItem & "'"

                dr = cmd.ExecuteReader

                While dr.Read
                    compt = compt + 1

                End While
                CN.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            CN.Close()


            If compt = 0 Then
                MsgBox("CETTE LISTE EST VIDE")

            Else
                Try
                    ListV.Items.Clear()
                    CN.Open()
                    cmd.Connection = CN
                    cmd.CommandText = "SELECT e.*,i.*,c.* FROM etudiant e,inscrire i,classe c WHERE e.nce_et = i.nce_et AND c.id_class='" & code_class & "' AND annee='" & ANNEE_TXT.SelectedItem & "'"
                    dr = cmd.ExecuteReader

                    ListV.View = View.Details
                    ' ListV.BackColor = Color.AliceBlue
                    ListV.Alignment = ListViewAlignment.SnapToGrid
                    ListV.Columns.Add("     NOM", 250, HorizontalAlignment.Left)
                    ListV.Columns.Add("PRENOM", 270, HorizontalAlignment.Left)
                    ListV.Columns.Add(" FILIERE ", 200, HorizontalAlignment.Left)
                    ListV.Columns.Add("MATRICULE", 200, HorizontalAlignment.Left)
                    While dr.Read
                        Dim liv As New ListViewItem
                        liv.Text = "     " & dr.GetString("nom_etud")
                        ' liv.Checked = False
                        liv.SubItems.Add(dr.GetString("prenom_etud"))
                        liv.SubItems.Add(dr.GetString("specialite"))
                        liv.SubItems.Add(dr.GetString("nce_et"))
                        ListV.Items.Add(liv)


                    End While
                    CN.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                    CN.Close()

                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ACCUEIL.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VALIDER_BT.Click
        Try
            selectioner = 0
            For Each element As ListViewItem In ListV.Items
                If element.Selected = True Then
                    selectioner = selectioner + 1
                End If
            Next
            If selectioner = 0 Then
                MsgBox("AUCUN ELEMENT SELECTIONER")
            Else

                For Each element As ListViewItem In ListV.Items
                    If element.Selected = True Then


                        NCE = element.SubItems(3).Text


                        Try
                            CN.Open()
                            cmd.Connection = CN
                            cmd.CommandText = "SELECT *FROM classe WHERE  niveau='" & niveau & "' AND specialite='" & specialite & "'"
                            dr = cmd.ExecuteReader
                            While dr.Read
                                code_class = dr.GetValue(0)
                            End While
                            CN.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                            CN.Close()
                        End Try

                        annee = ANNEE_TXT.SelectedItem

                        For i = 0 To ANNEE_TXT.Items.Count - 1
                            If annee = ANNEE_TXT.Items(i) Then
                                annee_suivant = ANNEE_TXT.Items(i + 1)
                            End If
                        Next

                        Try

                            CN.Open()
                            NCE = element.SubItems(3).Text
                            cmd.Connection = CN
                            cmd.CommandText = "INSERT INTO inscrire(nce_et,id_class,annee) VALUE('" & NCE & "','" & code_class & "','" & annee_suivant & "')"
                            dr = cmd.ExecuteReader
                            MsgBox(element.SubItems(0).Text & " " & element.SubItems(1).Text & " ENREGISTRER AVEC SUCESS")
                            CN.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                            CN.Close()
                        End Try
                    End If
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ANNEE_TXT_Click(sender As Object, e As EventArgs) Handles ANNEE_TXT.Click
        SPECIALITE_BOX.Text = ""
        NIVEAU_TXT.Text = ""
        ListV.Items.Clear()


    End Sub

    Private Sub SPECIALITE_BOX_Click(sender As Object, e As EventArgs) Handles SPECIALITE_BOX.Click
        NIVEAU_TXT.Text = ""
        ListV.Items.Clear()


    End Sub


    Private Sub MI_Click(sender As Object, e As EventArgs) Handles MI.Click
        niveau = "LICENCE 1"
        specialite = "MATHS INFO"
        MENU1.Text = "L1 MATHS INFO"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub L3_INFO_Click(sender As Object, e As EventArgs) Handles L3_INFO.Click
        niveau = "LICENCE 3"
        specialite = "INFORMATIQUE"
        MENU1.Text = "L3 INFO"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub L2_INFO_Click(sender As Object, e As EventArgs) Handles L2_INFO.Click
        niveau = "LICENCE 2"
        specialite = "INFORMATIQUE"
        MENU1.Text = "L2 INFO"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub M1_GI_Click(sender As Object, e As EventArgs) Handles M1_GI.Click
        niveau = "MASTER 1"
        specialite = "GENIE INFORMATIQUE"
        MENU1.Text = "M1 GI"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub M2_GI_Click(sender As Object, e As EventArgs) Handles M2_GI.Click
        niveau = "MASTER 2"
        specialite = "GENIE INFORMATIQUE"
        MENU1.Text = "M2 GI"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub M1_MIAGE_Click(sender As Object, e As EventArgs) Handles M1_MIAGE.Click
        niveau = "MASTER 1"
        specialite = "M1 MIAGE"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub M2_MIAGE_Click(sender As Object, e As EventArgs) Handles M2_MIAGE.Click
        niveau = "MASTER 2"
        specialite = "MIAGE"
        MENU1.Text = "M2 MIAGE"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub


    Private Sub L1_PC_Click(sender As Object, e As EventArgs) Handles L1_PC.Click
        niveau = "LICENCE 1"
        specialite = "PHYSIQUE CHIMIE"
        MENU1.Text = "L1 PC"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub L2_MATHS_Click(sender As Object, e As EventArgs) Handles L2_MATHS.Click
        niveau = "LICENCE 2"
        specialite = "MATHEMATIQUES"
        MENU1.Text = "L2 MATHS"
        VALIDER_BT.Visible = True
        Button3.Visible = False
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
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub M1_PH_Click(sender As Object, e As EventArgs) Handles M1_PH.Click
        niveau = "MASTER 1"
        specialite = "PHYSIQUE"
        MENU1.Text = "M1 PHYSIQUE"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub
    Private Sub L3_CH_Click(sender As Object, e As EventArgs) Handles L3_CH.Click
        niveau = "LICENCE 3"
        specialite = "CHIMIE"
        MENU1.Text = "L3 CHIMIE"
        VALIDER_BT.Visible = True
        Button3.Visible = False
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
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub M2_PH_Click(sender As Object, e As EventArgs) Handles M2_PH.Click
        niveau = "MASTER 2"
        specialite = "PHYSIQUE"
        MENU1.Text = "M2 PHYSIQUE"
        VALIDER_BT.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MENU1.Visible = True
    End Sub


    Private Sub ANNEE_TXT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ANNEE_TXT.SelectedIndexChanged

    End Sub
End Class