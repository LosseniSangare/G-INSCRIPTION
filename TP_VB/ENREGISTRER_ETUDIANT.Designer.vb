<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ENREGISTRER_ETUDIANT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ENREGISTRER_ETUDIANT))
        Me.NOM_TXT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PRENOM_TXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ANNEE_TXT = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LIEU_TXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AA_BOX = New System.Windows.Forms.ComboBox()
        Me.MM_BOX = New System.Windows.Forms.ComboBox()
        Me.JJ_BOX = New System.Windows.Forms.ComboBox()
        Me.NCE_TXT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOM_TXT
        '
        Me.NOM_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOM_TXT.Location = New System.Drawing.Point(302, 175)
        Me.NOM_TXT.Multiline = True
        Me.NOM_TXT.Name = "NOM_TXT"
        Me.NOM_TXT.Size = New System.Drawing.Size(263, 24)
        Me.NOM_TXT.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(57, 175)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "NOM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(98, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(467, 39)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "ENREGISTRER ETUDIANT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(42, 365)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 24)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "ANNEE ACADEMIQUE"
        '
        'PRENOM_TXT
        '
        Me.PRENOM_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRENOM_TXT.Location = New System.Drawing.Point(302, 220)
        Me.PRENOM_TXT.Multiline = True
        Me.PRENOM_TXT.Name = "PRENOM_TXT"
        Me.PRENOM_TXT.Size = New System.Drawing.Size(263, 24)
        Me.PRENOM_TXT.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(52, 220)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 24)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "PRENOM"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENU1})
        Me.MenuStrip2.Location = New System.Drawing.Point(284, 432)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(215, 38)
        Me.MenuStrip2.TabIndex = 94
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MENU1
        '
        Me.MENU1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MENU1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI, Me.PC, Me.MATHS, Me.INFOS, Me.GI, Me.MIAGE, Me.PHYSIQUE, Me.CHIMIE})
        Me.MENU1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENU1.Name = "MENU1"
        Me.MENU1.Size = New System.Drawing.Size(207, 34)
        Me.MENU1.Text = "FILIERE ETUDIANT"
        '
        'MI
        '
        Me.MI.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MI.Name = "MI"
        Me.MI.Size = New System.Drawing.Size(269, 34)
        Me.MI.Text = "MATHS INFO"
        '
        'PC
        '
        Me.PC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PC.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L1_PC, Me.L2_PC})
        Me.PC.Name = "PC"
        Me.PC.Size = New System.Drawing.Size(269, 34)
        Me.PC.Text = "PHYSIQUE CHIMIE"
        '
        'L1_PC
        '
        Me.L1_PC.Name = "L1_PC"
        Me.L1_PC.Size = New System.Drawing.Size(187, 34)
        Me.L1_PC.Text = "LICENCE 1"
        '
        'L2_PC
        '
        Me.L2_PC.Name = "L2_PC"
        Me.L2_PC.Size = New System.Drawing.Size(187, 34)
        Me.L2_PC.Text = "LICENCE 2"
        '
        'MATHS
        '
        Me.MATHS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MATHS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L2_MATHS, Me.L3_MATHS})
        Me.MATHS.Name = "MATHS"
        Me.MATHS.Size = New System.Drawing.Size(269, 34)
        Me.MATHS.Text = "MATHS"
        '
        'L2_MATHS
        '
        Me.L2_MATHS.Name = "L2_MATHS"
        Me.L2_MATHS.Size = New System.Drawing.Size(187, 34)
        Me.L2_MATHS.Text = "LICENCE 2"
        '
        'L3_MATHS
        '
        Me.L3_MATHS.Name = "L3_MATHS"
        Me.L3_MATHS.Size = New System.Drawing.Size(187, 34)
        Me.L3_MATHS.Text = "LICENCE 3"
        '
        'INFOS
        '
        Me.INFOS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.INFOS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L2_INFO, Me.L3_INFO})
        Me.INFOS.Name = "INFOS"
        Me.INFOS.Size = New System.Drawing.Size(269, 34)
        Me.INFOS.Text = "INFOS"
        '
        'L2_INFO
        '
        Me.L2_INFO.Name = "L2_INFO"
        Me.L2_INFO.Size = New System.Drawing.Size(187, 34)
        Me.L2_INFO.Text = "LICENCE 2"
        '
        'L3_INFO
        '
        Me.L3_INFO.Name = "L3_INFO"
        Me.L3_INFO.Size = New System.Drawing.Size(187, 34)
        Me.L3_INFO.Text = "LICENCE 3"
        '
        'GI
        '
        Me.GI.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M1_GI, Me.M2_GI})
        Me.GI.Name = "GI"
        Me.GI.Size = New System.Drawing.Size(269, 34)
        Me.GI.Text = "GENIE INFO"
        '
        'M1_GI
        '
        Me.M1_GI.Name = "M1_GI"
        Me.M1_GI.Size = New System.Drawing.Size(188, 34)
        Me.M1_GI.Text = "MASTER 1"
        '
        'M2_GI
        '
        Me.M2_GI.Name = "M2_GI"
        Me.M2_GI.Size = New System.Drawing.Size(188, 34)
        Me.M2_GI.Text = "MASTER 2"
        '
        'MIAGE
        '
        Me.MIAGE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MIAGE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M1_MIAGE, Me.M2_MIAGE})
        Me.MIAGE.Name = "MIAGE"
        Me.MIAGE.Size = New System.Drawing.Size(269, 34)
        Me.MIAGE.Text = "MIAGE"
        '
        'M1_MIAGE
        '
        Me.M1_MIAGE.Name = "M1_MIAGE"
        Me.M1_MIAGE.Size = New System.Drawing.Size(188, 34)
        Me.M1_MIAGE.Text = "MASTER 1"
        '
        'M2_MIAGE
        '
        Me.M2_MIAGE.Name = "M2_MIAGE"
        Me.M2_MIAGE.Size = New System.Drawing.Size(188, 34)
        Me.M2_MIAGE.Text = "MASTER 2"
        '
        'PHYSIQUE
        '
        Me.PHYSIQUE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PHYSIQUE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L3_PH, Me.M1_PH, Me.M2_PH})
        Me.PHYSIQUE.Name = "PHYSIQUE"
        Me.PHYSIQUE.Size = New System.Drawing.Size(269, 34)
        Me.PHYSIQUE.Text = "PHYSIQUE"
        '
        'L3_PH
        '
        Me.L3_PH.Name = "L3_PH"
        Me.L3_PH.Size = New System.Drawing.Size(188, 34)
        Me.L3_PH.Text = "LICENCE 3"
        '
        'M1_PH
        '
        Me.M1_PH.Name = "M1_PH"
        Me.M1_PH.Size = New System.Drawing.Size(188, 34)
        Me.M1_PH.Text = "MASTER 1"
        '
        'M2_PH
        '
        Me.M2_PH.Name = "M2_PH"
        Me.M2_PH.Size = New System.Drawing.Size(188, 34)
        Me.M2_PH.Text = "MASTER 2"
        '
        'CHIMIE
        '
        Me.CHIMIE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CHIMIE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L3_CH, Me.M1_CH, Me.M2_CH})
        Me.CHIMIE.Name = "CHIMIE"
        Me.CHIMIE.Size = New System.Drawing.Size(269, 34)
        Me.CHIMIE.Text = "CHIMIE"
        '
        'L3_CH
        '
        Me.L3_CH.Name = "L3_CH"
        Me.L3_CH.Size = New System.Drawing.Size(188, 34)
        Me.L3_CH.Text = "LICENCE 3"
        '
        'M1_CH
        '
        Me.M1_CH.Name = "M1_CH"
        Me.M1_CH.Size = New System.Drawing.Size(188, 34)
        Me.M1_CH.Text = "MASTER 1"
        '
        'M2_CH
        '
        Me.M2_CH.Name = "M2_CH"
        Me.M2_CH.Size = New System.Drawing.Size(188, 34)
        Me.M2_CH.Text = "MASTER 2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(286, 508)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 41)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "ENREGISTRER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ANNEE_TXT
        '
        Me.ANNEE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ANNEE_TXT.FormattingEnabled = True
        Me.ANNEE_TXT.Items.AddRange(New Object() {"2005-2006", "2006-2007", "2007-2008", "2008-2009", "2009-2010", "2010-2011", "2011-2012", "2012-2013", "2013-2014", "2014-2015", "2015-2016", "2016-2017", "2017-2018"})
        Me.ANNEE_TXT.Location = New System.Drawing.Point(301, 365)
        Me.ANNEE_TXT.Name = "ANNEE_TXT"
        Me.ANNEE_TXT.Size = New System.Drawing.Size(263, 28)
        Me.ANNEE_TXT.TabIndex = 96
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 560)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(707, 556)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 46)
        Me.Button2.TabIndex = 97
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LIEU_TXT
        '
        Me.LIEU_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIEU_TXT.Location = New System.Drawing.Point(301, 319)
        Me.LIEU_TXT.Multiline = True
        Me.LIEU_TXT.Name = "LIEU_TXT"
        Me.LIEU_TXT.Size = New System.Drawing.Size(263, 29)
        Me.LIEU_TXT.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(44, 315)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 24)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "LIEU DE NAISSANVE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(44, 258)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 24)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "DATE DE NAISSANCE"
        '
        'AA_BOX
        '
        Me.AA_BOX.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AA_BOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AA_BOX.FormattingEnabled = True
        Me.AA_BOX.Items.AddRange(New Object() {""})
        Me.AA_BOX.Location = New System.Drawing.Point(471, 258)
        Me.AA_BOX.Name = "AA_BOX"
        Me.AA_BOX.Size = New System.Drawing.Size(94, 28)
        Me.AA_BOX.TabIndex = 102
        Me.AA_BOX.Text = "AA"
        '
        'MM_BOX
        '
        Me.MM_BOX.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MM_BOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MM_BOX.FormattingEnabled = True
        Me.MM_BOX.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.MM_BOX.Location = New System.Drawing.Point(380, 258)
        Me.MM_BOX.Name = "MM_BOX"
        Me.MM_BOX.Size = New System.Drawing.Size(55, 28)
        Me.MM_BOX.TabIndex = 103
        Me.MM_BOX.Text = "MM"
        '
        'JJ_BOX
        '
        Me.JJ_BOX.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.JJ_BOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JJ_BOX.FormattingEnabled = True
        Me.JJ_BOX.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.JJ_BOX.Location = New System.Drawing.Point(301, 258)
        Me.JJ_BOX.Name = "JJ_BOX"
        Me.JJ_BOX.Size = New System.Drawing.Size(44, 28)
        Me.JJ_BOX.TabIndex = 104
        Me.JJ_BOX.Text = "JJ"
        '
        'NCE_TXT
        '
        Me.NCE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NCE_TXT.Location = New System.Drawing.Point(302, 126)
        Me.NCE_TXT.Multiline = True
        Me.NCE_TXT.Name = "NCE_TXT"
        Me.NCE_TXT.Size = New System.Drawing.Size(263, 24)
        Me.NCE_TXT.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(57, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 24)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "NCE"
        '
        'ENREGISTRER_ETUDIANT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TP_VB.My.Resources.Resources.FOND3
        Me.ClientSize = New System.Drawing.Size(762, 598)
        Me.Controls.Add(Me.NCE_TXT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.JJ_BOX)
        Me.Controls.Add(Me.MM_BOX)
        Me.Controls.Add(Me.AA_BOX)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LIEU_TXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ANNEE_TXT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.PRENOM_TXT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NOM_TXT)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ENREGISTRER_ETUDIANT"
        Me.Text = "ENREGISTRER_ETUDIANT"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NOM_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PRENOM_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Protected WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ANNEE_TXT As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LIEU_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AA_BOX As System.Windows.Forms.ComboBox
    Friend WithEvents MM_BOX As System.Windows.Forms.ComboBox
    Friend WithEvents JJ_BOX As System.Windows.Forms.ComboBox
    Friend WithEvents NCE_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
