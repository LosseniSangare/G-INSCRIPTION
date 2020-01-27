<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTE_ETUDIANT
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LISTE_ETUDIANT))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ANNEE_TXT = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SPECIALITE_BOX = New System.Windows.Forms.ComboBox()
        Me.NIVEAU_TXT = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VALIDER_BT = New System.Windows.Forms.Button()
        Me.ListV = New System.Windows.Forms.ListView()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MENU1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI = New System.Windows.Forms.ToolStripMenuItem()
        Me.PC = New System.Windows.Forms.ToolStripMenuItem()
        Me.L1_PC = New System.Windows.Forms.ToolStripMenuItem()
        Me.L2_PC = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATHS = New System.Windows.Forms.ToolStripMenuItem()
        Me.L2_MATHS = New System.Windows.Forms.ToolStripMenuItem()
        Me.L3_MATHS = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.L2_INFO = New System.Windows.Forms.ToolStripMenuItem()
        Me.L3_INFO = New System.Windows.Forms.ToolStripMenuItem()
        Me.GI = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1_GI = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2_GI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIAGE = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1_MIAGE = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2_MIAGE = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHYSIQUE = New System.Windows.Forms.ToolStripMenuItem()
        Me.L3_PH = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1_PH = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2_PH = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHIMIE = New System.Windows.Forms.ToolStripMenuItem()
        Me.L3_CH = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1_CH = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2_CH = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(246, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(415, 39)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "LISTE DES ETUDIANTS"
        Me.Label4.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 528)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(906, 524)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 46)
        Me.Button2.TabIndex = 108
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.UseWaitCursor = True
        '
        'ANNEE_TXT
        '
        Me.ANNEE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ANNEE_TXT.FormattingEnabled = True
        Me.ANNEE_TXT.Items.AddRange(New Object() {"2005-2006", "2006-2007", "2007-2008", "2008-2009", "2009-2010", "2010-2011", "2011-2012", "2012-2013", "2013-2014", "2014-2015", "2015-2016", "2016-2017", "2017-2018"})
        Me.ANNEE_TXT.Location = New System.Drawing.Point(107, 82)
        Me.ANNEE_TXT.Name = "ANNEE_TXT"
        Me.ANNEE_TXT.Size = New System.Drawing.Size(145, 28)
        Me.ANNEE_TXT.TabIndex = 114
        Me.ANNEE_TXT.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "ANNEE"
        Me.Label2.UseWaitCursor = True
        '
        'SPECIALITE_BOX
        '
        Me.SPECIALITE_BOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SPECIALITE_BOX.FormattingEnabled = True
        Me.SPECIALITE_BOX.Location = New System.Drawing.Point(434, 86)
        Me.SPECIALITE_BOX.Name = "SPECIALITE_BOX"
        Me.SPECIALITE_BOX.Size = New System.Drawing.Size(174, 28)
        Me.SPECIALITE_BOX.TabIndex = 118
        Me.SPECIALITE_BOX.UseWaitCursor = True
        '
        'NIVEAU_TXT
        '
        Me.NIVEAU_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIVEAU_TXT.FormattingEnabled = True
        Me.NIVEAU_TXT.Location = New System.Drawing.Point(778, 87)
        Me.NIVEAU_TXT.Name = "NIVEAU_TXT"
        Me.NIVEAU_TXT.Size = New System.Drawing.Size(175, 28)
        Me.NIVEAU_TXT.TabIndex = 117
        Me.NIVEAU_TXT.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Aqua
        Me.Label6.Location = New System.Drawing.Point(281, 87)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 24)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "SPECIALITE"
        Me.Label6.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Aqua
        Me.Label5.Location = New System.Drawing.Point(686, 91)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "NIVEAU"
        Me.Label5.UseWaitCursor = True
        '
        'VALIDER_BT
        '
        Me.VALIDER_BT.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.VALIDER_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VALIDER_BT.ForeColor = System.Drawing.Color.Black
        Me.VALIDER_BT.Location = New System.Drawing.Point(583, 486)
        Me.VALIDER_BT.Name = "VALIDER_BT"
        Me.VALIDER_BT.Size = New System.Drawing.Size(129, 50)
        Me.VALIDER_BT.TabIndex = 119
        Me.VALIDER_BT.Text = "VALIDER"
        Me.VALIDER_BT.UseVisualStyleBackColor = False
        Me.VALIDER_BT.UseWaitCursor = True
        '
        'ListV
        '
        Me.ListV.BackgroundImage = Global.TP_VB.My.Resources.Resources.papier
        Me.ListV.CheckBoxes = True
        Me.ListV.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ListV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListV.FullRowSelect = True
        Me.ListV.GridLines = True
        Me.ListV.Location = New System.Drawing.Point(37, 165)
        Me.ListV.Name = "ListV"
        Me.ListV.Size = New System.Drawing.Size(892, 294)
        Me.ListV.TabIndex = 112
        Me.ListV.UseCompatibleStateImageBehavior = False
        Me.ListV.UseWaitCursor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENU1})
        Me.MenuStrip2.Location = New System.Drawing.Point(385, 486)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(195, 33)
        Me.MenuStrip2.TabIndex = 120
        Me.MenuStrip2.Text = "MenuStrip2"
        Me.MenuStrip2.UseWaitCursor = True
        '
        'MENU1
        '
        Me.MENU1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MENU1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI, Me.PC, Me.MATHS, Me.INFOS, Me.GI, Me.MIAGE, Me.PHYSIQUE, Me.CHIMIE})
        Me.MENU1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENU1.Name = "MENU1"
        Me.MENU1.Size = New System.Drawing.Size(187, 29)
        Me.MENU1.Text = "FILIERE ETUDIANT"
        '
        'MI
        '
        Me.MI.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MI.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MI.Name = "MI"
        Me.MI.Size = New System.Drawing.Size(250, 30)
        Me.MI.Text = "MATHS INFO"
        '
        'PC
        '
        Me.PC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PC.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L1_PC, Me.L2_PC})
        Me.PC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC.Name = "PC"
        Me.PC.Size = New System.Drawing.Size(250, 30)
        Me.PC.Text = "PHYSIQUE CHIMIE"
        '
        'L1_PC
        '
        Me.L1_PC.Name = "L1_PC"
        Me.L1_PC.Size = New System.Drawing.Size(175, 30)
        Me.L1_PC.Text = "LICENCE 1"
        '
        'L2_PC
        '
        Me.L2_PC.Name = "L2_PC"
        Me.L2_PC.Size = New System.Drawing.Size(175, 30)
        Me.L2_PC.Text = "LICENCE 2"
        '
        'MATHS
        '
        Me.MATHS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MATHS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L2_MATHS, Me.L3_MATHS})
        Me.MATHS.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MATHS.Name = "MATHS"
        Me.MATHS.Size = New System.Drawing.Size(250, 30)
        Me.MATHS.Text = "MATHS"
        '
        'L2_MATHS
        '
        Me.L2_MATHS.Name = "L2_MATHS"
        Me.L2_MATHS.Size = New System.Drawing.Size(175, 30)
        Me.L2_MATHS.Text = "LICENCE 2"
        '
        'L3_MATHS
        '
        Me.L3_MATHS.Name = "L3_MATHS"
        Me.L3_MATHS.Size = New System.Drawing.Size(175, 30)
        Me.L3_MATHS.Text = "LICENCE 3"
        '
        'INFOS
        '
        Me.INFOS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.INFOS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L2_INFO, Me.L3_INFO})
        Me.INFOS.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INFOS.Name = "INFOS"
        Me.INFOS.Size = New System.Drawing.Size(250, 30)
        Me.INFOS.Text = "INFOS"
        '
        'L2_INFO
        '
        Me.L2_INFO.Name = "L2_INFO"
        Me.L2_INFO.Size = New System.Drawing.Size(175, 30)
        Me.L2_INFO.Text = "LICENCE 2"
        '
        'L3_INFO
        '
        Me.L3_INFO.Name = "L3_INFO"
        Me.L3_INFO.Size = New System.Drawing.Size(175, 30)
        Me.L3_INFO.Text = "LICENCE 3"
        '
        'GI
        '
        Me.GI.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M1_GI, Me.M2_GI})
        Me.GI.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GI.Name = "GI"
        Me.GI.Size = New System.Drawing.Size(250, 30)
        Me.GI.Text = "GENIE INFO"
        '
        'M1_GI
        '
        Me.M1_GI.Name = "M1_GI"
        Me.M1_GI.Size = New System.Drawing.Size(175, 30)
        Me.M1_GI.Text = "MASTER 1"
        '
        'M2_GI
        '
        Me.M2_GI.Name = "M2_GI"
        Me.M2_GI.Size = New System.Drawing.Size(175, 30)
        Me.M2_GI.Text = "MASTER 2"
        '
        'MIAGE
        '
        Me.MIAGE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MIAGE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M1_MIAGE, Me.M2_MIAGE})
        Me.MIAGE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MIAGE.Name = "MIAGE"
        Me.MIAGE.Size = New System.Drawing.Size(250, 30)
        Me.MIAGE.Text = "MIAGE"
        '
        'M1_MIAGE
        '
        Me.M1_MIAGE.Name = "M1_MIAGE"
        Me.M1_MIAGE.Size = New System.Drawing.Size(175, 30)
        Me.M1_MIAGE.Text = "MASTER 1"
        '
        'M2_MIAGE
        '
        Me.M2_MIAGE.Name = "M2_MIAGE"
        Me.M2_MIAGE.Size = New System.Drawing.Size(175, 30)
        Me.M2_MIAGE.Text = "MASTER 2"
        '
        'PHYSIQUE
        '
        Me.PHYSIQUE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PHYSIQUE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L3_PH, Me.M1_PH, Me.M2_PH})
        Me.PHYSIQUE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHYSIQUE.Name = "PHYSIQUE"
        Me.PHYSIQUE.Size = New System.Drawing.Size(250, 30)
        Me.PHYSIQUE.Text = "PHYSIQUE"
        '
        'L3_PH
        '
        Me.L3_PH.Name = "L3_PH"
        Me.L3_PH.Size = New System.Drawing.Size(175, 30)
        Me.L3_PH.Text = "LICENCE 3"
        '
        'M1_PH
        '
        Me.M1_PH.Name = "M1_PH"
        Me.M1_PH.Size = New System.Drawing.Size(175, 30)
        Me.M1_PH.Text = "MASTER 1"
        '
        'M2_PH
        '
        Me.M2_PH.Name = "M2_PH"
        Me.M2_PH.Size = New System.Drawing.Size(175, 30)
        Me.M2_PH.Text = "MASTER 2"
        '
        'CHIMIE
        '
        Me.CHIMIE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CHIMIE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L3_CH, Me.M1_CH, Me.M2_CH})
        Me.CHIMIE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHIMIE.Name = "CHIMIE"
        Me.CHIMIE.Size = New System.Drawing.Size(250, 30)
        Me.CHIMIE.Text = "CHIMIE"
        '
        'L3_CH
        '
        Me.L3_CH.Name = "L3_CH"
        Me.L3_CH.Size = New System.Drawing.Size(175, 30)
        Me.L3_CH.Text = "LICENCE 3"
        '
        'M1_CH
        '
        Me.M1_CH.Name = "M1_CH"
        Me.M1_CH.Size = New System.Drawing.Size(175, 30)
        Me.M1_CH.Text = "MASTER 1"
        '
        'M2_CH
        '
        Me.M2_CH.Name = "M2_CH"
        Me.M2_CH.Size = New System.Drawing.Size(175, 30)
        Me.M2_CH.Text = "MASTER 2"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(253, 486)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 50)
        Me.Button3.TabIndex = 121
        Me.Button3.Text = "FAIRE PASSER"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.UseWaitCursor = True
        '
        'LISTE_ETUDIANT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TP_VB.My.Resources.Resources.FOND3
        Me.ClientSize = New System.Drawing.Size(965, 569)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.VALIDER_BT)
        Me.Controls.Add(Me.SPECIALITE_BOX)
        Me.Controls.Add(Me.NIVEAU_TXT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ANNEE_TXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListV)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Name = "LISTE_ETUDIANT"
        Me.Text = "LISTE_ETUDIANT"
        Me.UseWaitCursor = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ANNEE_TXT As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SPECIALITE_BOX As System.Windows.Forms.ComboBox
    Friend WithEvents NIVEAU_TXT As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Protected WithEvents VALIDER_BT As System.Windows.Forms.Button
    Friend WithEvents ListV As System.Windows.Forms.ListView
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents MENU1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L1_PC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L2_PC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MATHS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L2_MATHS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L3_MATHS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INFOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L2_INFO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L3_INFO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1_GI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2_GI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MIAGE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1_MIAGE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2_MIAGE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PHYSIQUE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L3_PH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1_PH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2_PH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHIMIE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents L3_CH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M1_CH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2_CH As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents Button3 As System.Windows.Forms.Button
End Class
