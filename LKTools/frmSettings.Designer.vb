<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim LKTabs As System.Windows.Forms.TabControl
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtInformAboutHiddenObjectsTime = New System.Windows.Forms.TextBox()
        Me.lblInformAboutHiddenObjectsTime = New System.Windows.Forms.Label()
        Me.chkInformAboutHiddenObjects = New System.Windows.Forms.CheckBox()
        Me.grpAllgemein = New System.Windows.Forms.GroupBox()
        Me.chkUnderline = New System.Windows.Forms.CheckBox()
        Me.btnObjectTextColorDefault = New System.Windows.Forms.Button()
        Me.lblObjectTextColorExample = New System.Windows.Forms.Label()
        Me.btnObjectTextColor = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnColorHiddenDefault = New System.Windows.Forms.Button()
        Me.btnColorVisibleDefault = New System.Windows.Forms.Button()
        Me.chkLines = New System.Windows.Forms.CheckBox()
        Me.chkShapes = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHiddenColorExample = New System.Windows.Forms.Label()
        Me.btnColorVisible = New System.Windows.Forms.Button()
        Me.btnColorHidden = New System.Windows.Forms.Button()
        Me.lblVisbleColorExample = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabObjects = New System.Windows.Forms.TabPage()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tabInsert = New System.Windows.Forms.TabControl()
        Me.tabTemplates = New System.Windows.Forms.TabPage()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.chkRevisionPrint = New System.Windows.Forms.CheckBox()
        Me.chkRevisionPage = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkRedTextbox = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.chkExamButton = New System.Windows.Forms.CheckBox()
        Me.grpkarierteVorlage = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.chkGraphButton = New System.Windows.Forms.CheckBox()
        Me.lblGraphRows = New System.Windows.Forms.Label()
        Me.txtGraphRows = New System.Windows.Forms.TextBox()
        Me.txtGraphWidth = New System.Windows.Forms.TextBox()
        Me.lblGraphWidth = New System.Windows.Forms.Label()
        Me.grpLinierteVorlage = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.radRuledStyleWidth100 = New System.Windows.Forms.RadioButton()
        Me.radRuledStyleWidth50 = New System.Windows.Forms.RadioButton()
        Me.radRuledStyleWidth75 = New System.Windows.Forms.RadioButton()
        Me.chkRuledButton = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.radStyleDash = New System.Windows.Forms.RadioButton()
        Me.radStyleDot = New System.Windows.Forms.RadioButton()
        Me.radStyleLine = New System.Windows.Forms.RadioButton()
        Me.txtRuledSpacing = New System.Windows.Forms.TextBox()
        Me.lblRuledSpacing = New System.Windows.Forms.Label()
        Me.lblRuledRows = New System.Windows.Forms.Label()
        Me.txtRuledRows = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkExcerciseButton = New System.Windows.Forms.CheckBox()
        Me.tabExcercises = New System.Windows.Forms.TabPage()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.grpMC = New System.Windows.Forms.GroupBox()
        Me.chkMCAllignRight = New System.Windows.Forms.CheckBox()
        Me.chkMCButton = New System.Windows.Forms.CheckBox()
        Me.lblMCRows = New System.Windows.Forms.Label()
        Me.txtMCRows = New System.Windows.Forms.TextBox()
        Me.grpTrueFalse = New System.Windows.Forms.GroupBox()
        Me.lblTrueFalseReasonDesc = New System.Windows.Forms.Label()
        Me.chkTrueFalseButton = New System.Windows.Forms.CheckBox()
        Me.txtTrueFalseReasonDesc = New System.Windows.Forms.TextBox()
        Me.chkTrueFalseReason = New System.Windows.Forms.CheckBox()
        Me.lblTrueFalseFalseDesc = New System.Windows.Forms.Label()
        Me.txtTrueFalseFalseDesc = New System.Windows.Forms.TextBox()
        Me.lblTrueFalseTrueDesc = New System.Windows.Forms.Label()
        Me.txtTrueFalseTrueDesc = New System.Windows.Forms.TextBox()
        Me.lblTrueFalseRows = New System.Windows.Forms.Label()
        Me.txtTrueFalseRows = New System.Windows.Forms.TextBox()
        Me.grpLoesungshinweis = New System.Windows.Forms.GroupBox()
        Me.chkAddSolution = New System.Windows.Forms.CheckBox()
        Me.lblSolutionDescription = New System.Windows.Forms.Label()
        Me.txtSolutionDescription = New System.Windows.Forms.TextBox()
        Me.tabGrades = New System.Windows.Forms.TabPage()
        Me.chkGradeButton = New System.Windows.Forms.CheckBox()
        Me.grpNotenbereich = New System.Windows.Forms.GroupBox()
        Me.txtGrade5 = New System.Windows.Forms.TextBox()
        Me.lblGrade1 = New System.Windows.Forms.Label()
        Me.lblGrade2 = New System.Windows.Forms.Label()
        Me.lblGrade3 = New System.Windows.Forms.Label()
        Me.txtGrade4 = New System.Windows.Forms.TextBox()
        Me.lblGrade4 = New System.Windows.Forms.Label()
        Me.txtGrade3 = New System.Windows.Forms.TextBox()
        Me.lblGrade5 = New System.Windows.Forms.Label()
        Me.txtGrade2 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtGrade1 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.grpAusgabe = New System.Windows.Forms.GroupBox()
        Me.chkNoRounding = New System.Windows.Forms.CheckBox()
        Me.chk05Rounding = New System.Windows.Forms.CheckBox()
        Me.grpIHKStandard = New System.Windows.Forms.GroupBox()
        Me.btnGradeDefault2 = New System.Windows.Forms.Button()
        Me.btnGradeDefault5 = New System.Windows.Forms.Button()
        Me.btnGradeDefault1 = New System.Windows.Forms.Button()
        Me.btnGradeDefault3 = New System.Windows.Forms.Button()
        Me.btnGradeDefault4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGradelinear = New System.Windows.Forms.Button()
        Me.btnGradehart = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GradeGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.tabPath = New System.Windows.Forms.TabPage()
        Me.grpPath = New System.Windows.Forms.GroupBox()
        Me.radNoPath = New System.Windows.Forms.RadioButton()
        Me.chkPathAddDocumentName = New System.Windows.Forms.CheckBox()
        Me.txtPathNumberFolders = New System.Windows.Forms.TextBox()
        Me.lblPathNumberFolders = New System.Windows.Forms.Label()
        Me.radRelPath = New System.Windows.Forms.RadioButton()
        Me.radFullPath = New System.Windows.Forms.RadioButton()
        Me.chkPathButton = New System.Windows.Forms.CheckBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.tabPresentation = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOverlayTransparency = New System.Windows.Forms.TextBox()
        Me.lblOverlayTransparency = New System.Windows.Forms.Label()
        Me.chkShowOverlayFunction = New System.Windows.Forms.CheckBox()
        Me.btnOverlayDefault = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnColorOverlay = New System.Windows.Forms.Button()
        Me.lblOverlayExample = New System.Windows.Forms.Label()
        Me.tabExport = New System.Windows.Forms.TabPage()
        Me.tabExportDetail = New System.Windows.Forms.TabControl()
        Me.tabExportGeneral = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkPrintHiddenTextFlag = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkPrintNoSolution = New System.Windows.Forms.CheckBox()
        Me.chkPrintSolution = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpQuickPrint = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkQuickPrint = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.tabExportPDF = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkOpenPDFFolder = New System.Windows.Forms.CheckBox()
        Me.chkExtendedPDFButton = New System.Windows.Forms.CheckBox()
        Me.grpPDFExportSolution = New System.Windows.Forms.GroupBox()
        Me.chkMarkupsSolution = New System.Windows.Forms.CheckBox()
        Me.grpPDFExportNoSolution = New System.Windows.Forms.GroupBox()
        Me.chkMarkupsNoSolution = New System.Windows.Forms.CheckBox()
        Me.chkPDFExportEqual = New System.Windows.Forms.CheckBox()
        Me.chkShowExtendedPDFSettings = New System.Windows.Forms.CheckBox()
        Me.grpAusgabeSettings = New System.Windows.Forms.GroupBox()
        Me.grpPosition = New System.Windows.Forms.GroupBox()
        Me.radDescriptionSuffix = New System.Windows.Forms.RadioButton()
        Me.radDescriptionPrefix = New System.Windows.Forms.RadioButton()
        Me.txtpdfSubFolderText = New System.Windows.Forms.TextBox()
        Me.lblPDFSubfolder = New System.Windows.Forms.Label()
        Me.radPDFSubfolder = New System.Windows.Forms.RadioButton()
        Me.radPDFPath = New System.Windows.Forms.RadioButton()
        Me.radPDFSameFolder = New System.Windows.Forms.RadioButton()
        Me.txtpdfPathText = New System.Windows.Forms.TextBox()
        Me.btnSavePath = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPDFSolutionText = New System.Windows.Forms.Label()
        Me.txtPDFSolutionText = New System.Windows.Forms.TextBox()
        Me.lblPDFNoSolutionText = New System.Windows.Forms.Label()
        Me.txtPDFNoSolutionText = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.tabUpdate = New System.Windows.Forms.TabPage()
        Me.btnChangeLog = New System.Windows.Forms.Button()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.radUpdateDaily = New System.Windows.Forms.RadioButton()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.radUpdate30 = New System.Windows.Forms.RadioButton()
        Me.radUpdate14 = New System.Windows.Forms.RadioButton()
        Me.radUpdateNever = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tabAboutMe = New System.Windows.Forms.TabPage()
        Me.txtDatenschutz = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKontakt = New System.Windows.Forms.Label()
        Me.lblWebPage = New System.Windows.Forms.LinkLabel()
        Me.lblEMail = New System.Windows.Forms.LinkLabel()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnDefaultSettings = New System.Windows.Forms.Button()
        Me.lblErrorText = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btnOKSettings = New System.Windows.Forms.Button()
        Me.btnCancelSettings = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        LKTabs = New System.Windows.Forms.TabControl()
        LKTabs.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.grpAllgemein.SuspendLayout()
        Me.tabObjects.SuspendLayout()
        Me.tabInsert.SuspendLayout()
        Me.tabTemplates.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.grpkarierteVorlage.SuspendLayout()
        Me.grpLinierteVorlage.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.tabExcercises.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMC.SuspendLayout()
        Me.grpTrueFalse.SuspendLayout()
        Me.grpLoesungshinweis.SuspendLayout()
        Me.tabGrades.SuspendLayout()
        Me.grpNotenbereich.SuspendLayout()
        Me.grpAusgabe.SuspendLayout()
        Me.grpIHKStandard.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GradeGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPath.SuspendLayout()
        Me.grpPath.SuspendLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPresentation.SuspendLayout()
        Me.tabExport.SuspendLayout()
        Me.tabExportDetail.SuspendLayout()
        Me.tabExportGeneral.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.grpQuickPrint.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabExportPDF.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpPDFExportSolution.SuspendLayout()
        Me.grpPDFExportNoSolution.SuspendLayout()
        Me.grpAusgabeSettings.SuspendLayout()
        Me.grpPosition.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUpdate.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAboutMe.SuspendLayout()
        Me.SuspendLayout()
        '
        'LKTabs
        '
        LKTabs.Controls.Add(Me.tabSettings)
        LKTabs.Controls.Add(Me.tabObjects)
        LKTabs.Controls.Add(Me.tabExport)
        LKTabs.Controls.Add(Me.tabUpdate)
        LKTabs.Controls.Add(Me.tabAboutMe)
        LKTabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(LKTabs, "")
        LKTabs.Location = New System.Drawing.Point(5, 5)
        LKTabs.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        LKTabs.Multiline = True
        LKTabs.Name = "LKTabs"
        LKTabs.SelectedIndex = 0
        Me.HelpProvider1.SetShowHelp(LKTabs, True)
        LKTabs.Size = New System.Drawing.Size(524, 370)
        LKTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        LKTabs.TabIndex = 0
        '
        'tabSettings
        '
        Me.tabSettings.AutoScroll = True
        Me.tabSettings.BackColor = System.Drawing.SystemColors.Control
        Me.tabSettings.Controls.Add(Me.PictureBox13)
        Me.tabSettings.Controls.Add(Me.PictureBox12)
        Me.tabSettings.Controls.Add(Me.GroupBox4)
        Me.tabSettings.Controls.Add(Me.grpAllgemein)
        Me.HelpProvider1.SetHelpString(Me.tabSettings, "Legen Sie grundlegende Einstellungen fest.")
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.tabSettings, False)
        Me.tabSettings.Size = New System.Drawing.Size(516, 340)
        Me.tabSettings.TabIndex = 0
        Me.tabSettings.Text = "Allgemein"
        Me.tabSettings.ToolTipText = "Allgemeine Einstellungen"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Image = Global.LKTools.My.Resources.Resources.StatusAnnotations_Warning_32xLG_color
        Me.PictureBox13.Location = New System.Drawing.Point(5, 178)
        Me.PictureBox13.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 47
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Image = Global.LKTools.My.Resources.Resources.gear_32xLG
        Me.PictureBox12.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 46
        Me.PictureBox12.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtInformAboutHiddenObjectsTime)
        Me.GroupBox4.Controls.Add(Me.lblInformAboutHiddenObjectsTime)
        Me.GroupBox4.Controls.Add(Me.chkInformAboutHiddenObjects)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 178)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox4.Size = New System.Drawing.Size(426, 84)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Information"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 36)
        Me.Label19.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(228, 13)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "(Nur möglich, wenn ein Dokument geöffnet ist.)"
        '
        'txtInformAboutHiddenObjectsTime
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtInformAboutHiddenObjectsTime, "ausblenden")
        Me.HelpProvider1.SetHelpNavigator(Me.txtInformAboutHiddenObjectsTime, System.Windows.Forms.HelpNavigator.Find)
        Me.HelpProvider1.SetHelpString(Me.txtInformAboutHiddenObjectsTime, "Legen Sie die Dauer in Sekunden fest, wie lange Sie über ausgeblendete Objekte in" &
        "formiert werden möchten. Das Fenster schließt dann automatisch. Manuell kann das" &
        " Fenster jederzeit geschlossen werden.")
        Me.txtInformAboutHiddenObjectsTime.Location = New System.Drawing.Point(125, 58)
        Me.txtInformAboutHiddenObjectsTime.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtInformAboutHiddenObjectsTime.Name = "txtInformAboutHiddenObjectsTime"
        Me.HelpProvider1.SetShowHelp(Me.txtInformAboutHiddenObjectsTime, True)
        Me.txtInformAboutHiddenObjectsTime.Size = New System.Drawing.Size(32, 20)
        Me.txtInformAboutHiddenObjectsTime.TabIndex = 33
        Me.txtInformAboutHiddenObjectsTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInformAboutHiddenObjectsTime
        '
        Me.lblInformAboutHiddenObjectsTime.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblInformAboutHiddenObjectsTime, "Legen Sie die Dauer in Sekunden fest, wie lange Sie über ausgeblendete Objekte in" &
        "formiert werden möchten. Das Fenster schließt dann automatisch. Manuell kann das" &
        " Fenster jederzeit geschlossen werden.")
        Me.lblInformAboutHiddenObjectsTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInformAboutHiddenObjectsTime.Location = New System.Drawing.Point(20, 59)
        Me.lblInformAboutHiddenObjectsTime.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblInformAboutHiddenObjectsTime.Name = "lblInformAboutHiddenObjectsTime"
        Me.HelpProvider1.SetShowHelp(Me.lblInformAboutHiddenObjectsTime, True)
        Me.lblInformAboutHiddenObjectsTime.Size = New System.Drawing.Size(102, 13)
        Me.lblInformAboutHiddenObjectsTime.TabIndex = 29
        Me.lblInformAboutHiddenObjectsTime.Text = "Dauer in Sekunden:"
        '
        'chkInformAboutHiddenObjects
        '
        Me.chkInformAboutHiddenObjects.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkInformAboutHiddenObjects, "Sie können sich über ausgeblendete Objekte beim Start von MS Word informieren. Di" &
        "es funktioniert nicht, wenn mehrere Dokumente gleichzeitig geöffnet sind.")
        Me.chkInformAboutHiddenObjects.Location = New System.Drawing.Point(9, 20)
        Me.chkInformAboutHiddenObjects.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkInformAboutHiddenObjects.Name = "chkInformAboutHiddenObjects"
        Me.HelpProvider1.SetShowHelp(Me.chkInformAboutHiddenObjects, True)
        Me.chkInformAboutHiddenObjects.Size = New System.Drawing.Size(266, 17)
        Me.chkInformAboutHiddenObjects.TabIndex = 0
        Me.chkInformAboutHiddenObjects.Text = "Über ausgeblendete Objekte beim Start informieren"
        Me.chkInformAboutHiddenObjects.UseVisualStyleBackColor = True
        '
        'grpAllgemein
        '
        Me.grpAllgemein.BackColor = System.Drawing.SystemColors.Control
        Me.grpAllgemein.Controls.Add(Me.chkUnderline)
        Me.grpAllgemein.Controls.Add(Me.btnObjectTextColorDefault)
        Me.grpAllgemein.Controls.Add(Me.lblObjectTextColorExample)
        Me.grpAllgemein.Controls.Add(Me.btnObjectTextColor)
        Me.grpAllgemein.Controls.Add(Me.Label4)
        Me.grpAllgemein.Controls.Add(Me.btnColorHiddenDefault)
        Me.grpAllgemein.Controls.Add(Me.btnColorVisibleDefault)
        Me.grpAllgemein.Controls.Add(Me.chkLines)
        Me.grpAllgemein.Controls.Add(Me.chkShapes)
        Me.grpAllgemein.Controls.Add(Me.Label1)
        Me.grpAllgemein.Controls.Add(Me.lblHiddenColorExample)
        Me.grpAllgemein.Controls.Add(Me.btnColorVisible)
        Me.grpAllgemein.Controls.Add(Me.btnColorHidden)
        Me.grpAllgemein.Controls.Add(Me.lblVisbleColorExample)
        Me.grpAllgemein.Controls.Add(Me.Label10)
        Me.grpAllgemein.Location = New System.Drawing.Point(20, 8)
        Me.grpAllgemein.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpAllgemein.Name = "grpAllgemein"
        Me.grpAllgemein.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpAllgemein.Size = New System.Drawing.Size(426, 157)
        Me.grpAllgemein.TabIndex = 18
        Me.grpAllgemein.TabStop = False
        Me.grpAllgemein.Text = "Allgemein"
        '
        'chkUnderline
        '
        Me.chkUnderline.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkUnderline, "Legen Sie fest, ob Unterstriche in der Lösungsfarbe ausgeblendet werden sollen.")
        Me.chkUnderline.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkUnderline.Location = New System.Drawing.Point(11, 132)
        Me.chkUnderline.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkUnderline.Name = "chkUnderline"
        Me.HelpProvider1.SetShowHelp(Me.chkUnderline, True)
        Me.chkUnderline.Size = New System.Drawing.Size(171, 17)
        Me.chkUnderline.TabIndex = 9
        Me.chkUnderline.Text = "Unterstreichungen ausblenden"
        Me.chkUnderline.UseVisualStyleBackColor = True
        '
        'btnObjectTextColorDefault
        '
        Me.HelpProvider1.SetHelpString(Me.btnObjectTextColorDefault, "Setzen die Farbe auf die LKTools Standardfarbe ""Schwarz"" zurück")
        Me.btnObjectTextColorDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnObjectTextColorDefault.Location = New System.Drawing.Point(327, 70)
        Me.btnObjectTextColorDefault.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnObjectTextColorDefault.Name = "btnObjectTextColorDefault"
        Me.HelpProvider1.SetShowHelp(Me.btnObjectTextColorDefault, True)
        Me.btnObjectTextColorDefault.Size = New System.Drawing.Size(77, 22)
        Me.btnObjectTextColorDefault.TabIndex = 6
        Me.btnObjectTextColorDefault.Text = "Standard"
        Me.btnObjectTextColorDefault.UseVisualStyleBackColor = True
        '
        'lblObjectTextColorExample
        '
        Me.lblObjectTextColorExample.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblObjectTextColorExample, "Vorschau, der ausgewählten Farbe")
        Me.lblObjectTextColorExample.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObjectTextColorExample.Location = New System.Drawing.Point(199, 73)
        Me.lblObjectTextColorExample.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblObjectTextColorExample.Name = "lblObjectTextColorExample"
        Me.HelpProvider1.SetShowHelp(Me.lblObjectTextColorExample, True)
        Me.lblObjectTextColorExample.Size = New System.Drawing.Size(114, 13)
        Me.lblObjectTextColorExample.TabIndex = 26
        Me.lblObjectTextColorExample.Text = "Dies ist ein Beispieltext"
        '
        'btnObjectTextColor
        '
        Me.btnObjectTextColor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnObjectTextColor.Location = New System.Drawing.Point(118, 70)
        Me.btnObjectTextColor.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnObjectTextColor.Name = "btnObjectTextColor"
        Me.btnObjectTextColor.Size = New System.Drawing.Size(72, 22)
        Me.btnObjectTextColor.TabIndex = 3
        Me.btnObjectTextColor.Text = "Auswahl"
        Me.btnObjectTextColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnObjectTextColor.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.Label4, "Textfarben werden u.a. beim Notenblatt und beim Lösungsvorschlag verwendet.")
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(9, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.HelpProvider1.SetShowHelp(Me.Label4, True)
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Textfarbe:"
        '
        'btnColorHiddenDefault
        '
        Me.HelpProvider1.SetHelpString(Me.btnColorHiddenDefault, "Setzen die Farbe auf die LKTools Standardfarbe ""Weiß"" zurück")
        Me.btnColorHiddenDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnColorHiddenDefault.Location = New System.Drawing.Point(327, 45)
        Me.btnColorHiddenDefault.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnColorHiddenDefault.Name = "btnColorHiddenDefault"
        Me.HelpProvider1.SetShowHelp(Me.btnColorHiddenDefault, True)
        Me.btnColorHiddenDefault.Size = New System.Drawing.Size(77, 22)
        Me.btnColorHiddenDefault.TabIndex = 5
        Me.btnColorHiddenDefault.Text = "Standard"
        Me.btnColorHiddenDefault.UseVisualStyleBackColor = True
        '
        'btnColorVisibleDefault
        '
        Me.HelpProvider1.SetHelpString(Me.btnColorVisibleDefault, "Setzen die Farbe auf die LKTools Standardfarbe ""Rot"" zurück")
        Me.btnColorVisibleDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnColorVisibleDefault.Location = New System.Drawing.Point(327, 22)
        Me.btnColorVisibleDefault.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnColorVisibleDefault.Name = "btnColorVisibleDefault"
        Me.HelpProvider1.SetShowHelp(Me.btnColorVisibleDefault, True)
        Me.btnColorVisibleDefault.Size = New System.Drawing.Size(77, 22)
        Me.btnColorVisibleDefault.TabIndex = 4
        Me.btnColorVisibleDefault.Text = "Standard"
        Me.btnColorVisibleDefault.UseVisualStyleBackColor = True
        '
        'chkLines
        '
        Me.chkLines.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkLines, "Legen Sie fest, ob auch Objekte ausgeblendet werden sollen, wenn diese mit der Lö" &
        "sungsfarbe umrandet sind. Notwendig für Bilder, SmartArts etc.")
        Me.chkLines.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkLines.Location = New System.Drawing.Point(11, 114)
        Me.chkLines.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkLines.Name = "chkLines"
        Me.HelpProvider1.SetShowHelp(Me.chkLines, True)
        Me.chkLines.Size = New System.Drawing.Size(189, 17)
        Me.chkLines.TabIndex = 8
        Me.chkLines.Text = "Pfeile und Außenlinien ausblenden"
        Me.chkLines.UseVisualStyleBackColor = True
        '
        'chkShapes
        '
        Me.chkShapes.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkShapes, "Legen Sie fest, ob auch Objekte ausgeblendet werden sollen, wenn diese mit der Lö" &
        "sungsfarbe gefüllt sind.")
        Me.chkShapes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkShapes.Location = New System.Drawing.Point(11, 96)
        Me.chkShapes.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkShapes.Name = "chkShapes"
        Me.HelpProvider1.SetShowHelp(Me.chkShapes, True)
        Me.chkShapes.Size = New System.Drawing.Size(119, 17)
        Me.chkShapes.TabIndex = 7
        Me.chkShapes.Text = "Formen ausblenden"
        Me.chkShapes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.Label1, "")
        Me.HelpProvider1.SetHelpString(Me.Label1, "Wählen Sie die Farbe aus, die in der Lösung eingeblendet sein soll.")
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.HelpProvider1.SetShowHelp(Me.Label1, True)
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Farbe eingeblendet:"
        '
        'lblHiddenColorExample
        '
        Me.lblHiddenColorExample.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblHiddenColorExample, "Vorschau, der ausgewählten Farbe")
        Me.lblHiddenColorExample.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHiddenColorExample.Location = New System.Drawing.Point(199, 50)
        Me.lblHiddenColorExample.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblHiddenColorExample.Name = "lblHiddenColorExample"
        Me.HelpProvider1.SetShowHelp(Me.lblHiddenColorExample, True)
        Me.lblHiddenColorExample.Size = New System.Drawing.Size(114, 13)
        Me.lblHiddenColorExample.TabIndex = 14
        Me.lblHiddenColorExample.Text = "Dies ist ein Beispieltext"
        '
        'btnColorVisible
        '
        Me.HelpProvider1.SetHelpString(Me.btnColorVisible, "Wählen Sie die Farbe aus, die in der Lösung eingebelndet sein soll")
        Me.btnColorVisible.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnColorVisible.Location = New System.Drawing.Point(118, 22)
        Me.btnColorVisible.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnColorVisible.Name = "btnColorVisible"
        Me.HelpProvider1.SetShowHelp(Me.btnColorVisible, True)
        Me.btnColorVisible.Size = New System.Drawing.Size(72, 22)
        Me.btnColorVisible.TabIndex = 1
        Me.btnColorVisible.Text = "Auswahl"
        Me.btnColorVisible.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnColorVisible.UseVisualStyleBackColor = True
        '
        'btnColorHidden
        '
        Me.btnColorHidden.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnColorHidden.Location = New System.Drawing.Point(118, 45)
        Me.btnColorHidden.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnColorHidden.Name = "btnColorHidden"
        Me.btnColorHidden.Size = New System.Drawing.Size(72, 22)
        Me.btnColorHidden.TabIndex = 2
        Me.btnColorHidden.Text = "Auswahl"
        Me.btnColorHidden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnColorHidden.UseVisualStyleBackColor = True
        '
        'lblVisbleColorExample
        '
        Me.lblVisbleColorExample.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblVisbleColorExample, "Vorschau, der ausgewählten Farbe")
        Me.lblVisbleColorExample.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVisbleColorExample.Location = New System.Drawing.Point(199, 26)
        Me.lblVisbleColorExample.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblVisbleColorExample.Name = "lblVisbleColorExample"
        Me.HelpProvider1.SetShowHelp(Me.lblVisbleColorExample, True)
        Me.lblVisbleColorExample.Size = New System.Drawing.Size(114, 13)
        Me.lblVisbleColorExample.TabIndex = 5
        Me.lblVisbleColorExample.Text = "Dies ist ein Beispieltext"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.Label10, "Wählen Sie die Farbe aus, wie ausgblendeteter Text dargestellt werden soll.")
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(9, 50)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.HelpProvider1.SetShowHelp(Me.Label10, True)
        Me.Label10.Size = New System.Drawing.Size(104, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Farbe ausgeblendet:"
        '
        'tabObjects
        '
        Me.tabObjects.BackColor = System.Drawing.SystemColors.Control
        Me.tabObjects.Controls.Add(Me.Label28)
        Me.tabObjects.Controls.Add(Me.tabInsert)
        Me.HelpProvider1.SetHelpString(Me.tabObjects, "Legen Sie fest, welche Objekte Sie einfügen wollen und wie diese standardmäßig ei" &
        "ngefügt werden sollen.")
        Me.tabObjects.Location = New System.Drawing.Point(4, 22)
        Me.tabObjects.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabObjects.Name = "tabObjects"
        Me.HelpProvider1.SetShowHelp(Me.tabObjects, False)
        Me.tabObjects.Size = New System.Drawing.Size(516, 340)
        Me.tabObjects.TabIndex = 5
        Me.tabObjects.Text = "Objekte"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(12, 325)
        Me.Label28.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(381, 13)
        Me.Label28.TabIndex = 42
        Me.Label28.Text = "*Die Anzeige der Buttons wird erst nach einem Neustart von MS Word wirksam."
        '
        'tabInsert
        '
        Me.tabInsert.Controls.Add(Me.tabTemplates)
        Me.tabInsert.Controls.Add(Me.tabExcercises)
        Me.tabInsert.Controls.Add(Me.tabGrades)
        Me.tabInsert.Controls.Add(Me.tabPath)
        Me.tabInsert.Controls.Add(Me.tabPresentation)
        Me.tabInsert.Location = New System.Drawing.Point(5, 3)
        Me.tabInsert.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabInsert.Name = "tabInsert"
        Me.tabInsert.SelectedIndex = 0
        Me.tabInsert.Size = New System.Drawing.Size(509, 321)
        Me.tabInsert.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabInsert.TabIndex = 40
        '
        'tabTemplates
        '
        Me.tabTemplates.BackColor = System.Drawing.SystemColors.Control
        Me.tabTemplates.Controls.Add(Me.PictureBox16)
        Me.tabTemplates.Controls.Add(Me.GroupBox10)
        Me.tabTemplates.Controls.Add(Me.PictureBox1)
        Me.tabTemplates.Controls.Add(Me.PictureBox11)
        Me.tabTemplates.Controls.Add(Me.PictureBox10)
        Me.tabTemplates.Controls.Add(Me.GroupBox5)
        Me.tabTemplates.Controls.Add(Me.PictureBox3)
        Me.tabTemplates.Controls.Add(Me.PictureBox2)
        Me.tabTemplates.Controls.Add(Me.GroupBox9)
        Me.tabTemplates.Controls.Add(Me.grpkarierteVorlage)
        Me.tabTemplates.Controls.Add(Me.grpLinierteVorlage)
        Me.tabTemplates.Controls.Add(Me.GroupBox8)
        Me.HelpProvider1.SetHelpString(Me.tabTemplates, "Legen Sie Vorlagen fest und blenden Sie die Schaltflächen ein- oder aus.")
        Me.tabTemplates.Location = New System.Drawing.Point(4, 22)
        Me.tabTemplates.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabTemplates.Name = "tabTemplates"
        Me.tabTemplates.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.tabTemplates, True)
        Me.tabTemplates.Size = New System.Drawing.Size(501, 295)
        Me.tabTemplates.TabIndex = 0
        Me.tabTemplates.Text = "Vorlagen"
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.ErrorImage = Global.LKTools.My.Resources.Resources.IntelliTrace
        Me.PictureBox16.Image = Global.LKTools.My.Resources.Resources.IntelliTrace
        Me.PictureBox16.Location = New System.Drawing.Point(207, 8)
        Me.PictureBox16.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 49
        Me.PictureBox16.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.chkRevisionPrint)
        Me.GroupBox10.Controls.Add(Me.chkRevisionPage)
        Me.HelpProvider1.SetHelpString(Me.GroupBox10, "Auf der ersten Seite wird eine Tabelle mit Revisionshistorie eingefügt")
        Me.GroupBox10.Location = New System.Drawing.Point(222, 8)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.GroupBox10, True)
        Me.GroupBox10.Size = New System.Drawing.Size(199, 43)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Revisionshistorie"
        '
        'chkRevisionPrint
        '
        Me.chkRevisionPrint.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkRevisionPrint, "Legen Sie fest, ob die Revisionsseite standardmäßig gedruckt werden soll. Dies gi" &
        "lt sowohl für als auch mit Lösung. Haken hat nur Auswirkung auf mit LKTools erst" &
        "ellte Revisionsseiten.")
        Me.chkRevisionPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRevisionPrint.Location = New System.Drawing.Point(95, 20)
        Me.chkRevisionPrint.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkRevisionPrint.Name = "chkRevisionPrint"
        Me.HelpProvider1.SetShowHelp(Me.chkRevisionPrint, True)
        Me.chkRevisionPrint.Size = New System.Drawing.Size(105, 17)
        Me.chkRevisionPrint.TabIndex = 2
        Me.chkRevisionPrint.Text = "In PDF anzeigen"
        Me.chkRevisionPrint.UseVisualStyleBackColor = True
        '
        'chkRevisionPage
        '
        Me.chkRevisionPage.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkRevisionPage, resources.GetString("chkRevisionPage.HelpString"))
        Me.chkRevisionPage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRevisionPage.Location = New System.Drawing.Point(6, 20)
        Me.chkRevisionPage.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkRevisionPage.Name = "chkRevisionPage"
        Me.HelpProvider1.SetShowHelp(Me.chkRevisionPage, True)
        Me.chkRevisionPage.Size = New System.Drawing.Size(74, 17)
        Me.chkRevisionPage.TabIndex = 1
        Me.chkRevisionPage.Text = "Anzeigen*"
        Me.chkRevisionPage.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LKTools.My.Resources.Resources.GraphTemplate
        Me.PictureBox1.Location = New System.Drawing.Point(4, 102)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = Global.LKTools.My.Resources.Resources.action_add_16xLG
        Me.PictureBox11.Location = New System.Drawing.Point(4, 58)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 47
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = Global.LKTools.My.Resources.Resources.Textbox
        Me.PictureBox10.Location = New System.Drawing.Point(4, 8)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 46
        Me.PictureBox10.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkRedTextbox)
        Me.HelpProvider1.SetHelpString(Me.GroupBox5, "Eine ""Textbox"" in der entsprechenden Farbe kann mit einem Klick eingefügt werden " &
        "um Lösungen einzutragen. Zum Beispiel über die karierte Vorlage.")
        Me.GroupBox5.Location = New System.Drawing.Point(20, 8)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.GroupBox5, True)
        Me.GroupBox5.Size = New System.Drawing.Size(172, 43)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Textbox"
        '
        'chkRedTextbox
        '
        Me.chkRedTextbox.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkRedTextbox, resources.GetString("chkRedTextbox.HelpString"))
        Me.chkRedTextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRedTextbox.Location = New System.Drawing.Point(6, 20)
        Me.chkRedTextbox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkRedTextbox.Name = "chkRedTextbox"
        Me.HelpProvider1.SetShowHelp(Me.chkRedTextbox, True)
        Me.chkRedTextbox.Size = New System.Drawing.Size(74, 17)
        Me.chkRedTextbox.TabIndex = 1
        Me.chkRedTextbox.Text = "Anzeigen*"
        Me.chkRedTextbox.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.LKTools.My.Resources.Resources.RuledTemplate
        Me.PictureBox3.Location = New System.Drawing.Point(4, 178)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.LKTools.My.Resources.Resources.Exam
        Me.PictureBox2.Location = New System.Drawing.Point(207, 58)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.chkExamButton)
        Me.HelpProvider1.SetHelpString(Me.GroupBox9, "Eine ""P. Aufgabe"" ist eine Tabelle mit drei Spalten, deren erste Spalte automatis" &
        "ch hochzählt. Die letzte Spalte dient der Angabe der Punktzahl sowie der Möglich" &
        "keit Korrekturkommentare einzutragen.")
        Me.GroupBox9.Location = New System.Drawing.Point(222, 58)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.GroupBox9, True)
        Me.GroupBox9.Size = New System.Drawing.Size(199, 41)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Prüfungsaufgabe"
        '
        'chkExamButton
        '
        Me.chkExamButton.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkExamButton, "Legen Sie fest, ob die Schaltfläche ""P. Aufgabe"" im Ribbon LKTools angezeigt werd" &
        "en soll. Änderung ist erst nach einem Neustart von MS Word sichtbar.")
        Me.chkExamButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkExamButton.Location = New System.Drawing.Point(6, 20)
        Me.chkExamButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkExamButton.Name = "chkExamButton"
        Me.HelpProvider1.SetShowHelp(Me.chkExamButton, True)
        Me.chkExamButton.Size = New System.Drawing.Size(74, 17)
        Me.chkExamButton.TabIndex = 3
        Me.chkExamButton.Text = "Anzeigen*"
        Me.chkExamButton.UseVisualStyleBackColor = True
        '
        'grpkarierteVorlage
        '
        Me.grpkarierteVorlage.Controls.Add(Me.Label24)
        Me.grpkarierteVorlage.Controls.Add(Me.chkGraphButton)
        Me.grpkarierteVorlage.Controls.Add(Me.lblGraphRows)
        Me.grpkarierteVorlage.Controls.Add(Me.txtGraphRows)
        Me.grpkarierteVorlage.Controls.Add(Me.txtGraphWidth)
        Me.grpkarierteVorlage.Controls.Add(Me.lblGraphWidth)
        Me.HelpProvider1.SetHelpString(Me.grpkarierteVorlage, "Eine karierte Vorlage ist ideal für mathematische Berechnungen.")
        Me.grpkarierteVorlage.Location = New System.Drawing.Point(20, 102)
        Me.grpkarierteVorlage.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpkarierteVorlage.Name = "grpkarierteVorlage"
        Me.grpkarierteVorlage.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.grpkarierteVorlage, True)
        Me.grpkarierteVorlage.Size = New System.Drawing.Size(402, 68)
        Me.grpkarierteVorlage.TabIndex = 4
        Me.grpkarierteVorlage.TabStop = False
        Me.grpkarierteVorlage.Text = "karierte Vorlage"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(192, 18)
        Me.Label24.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(21, 13)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "cm"
        '
        'chkGraphButton
        '
        Me.chkGraphButton.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkGraphButton, "Legen Sie fest, ob die Schaltfläche ""Kariert"" im Ribbon LKTools angezeigt werden " &
        "soll. Änderung ist erst nach einem Neustart von MS Word sichtbar.")
        Me.chkGraphButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkGraphButton.Location = New System.Drawing.Point(6, 16)
        Me.chkGraphButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkGraphButton.Name = "chkGraphButton"
        Me.HelpProvider1.SetShowHelp(Me.chkGraphButton, True)
        Me.chkGraphButton.Size = New System.Drawing.Size(74, 17)
        Me.chkGraphButton.TabIndex = 4
        Me.chkGraphButton.Text = "Anzeigen*"
        Me.chkGraphButton.UseVisualStyleBackColor = True
        '
        'lblGraphRows
        '
        Me.lblGraphRows.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblGraphRows, "Legen Sie fest, wieviele Zeilen die karierte Vorlage standardmäßig haben soll. Di" &
        "eser Wert ist später überschreibbar.")
        Me.lblGraphRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGraphRows.Location = New System.Drawing.Point(82, 42)
        Me.lblGraphRows.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGraphRows.Name = "lblGraphRows"
        Me.HelpProvider1.SetShowHelp(Me.lblGraphRows, True)
        Me.lblGraphRows.Size = New System.Drawing.Size(74, 13)
        Me.lblGraphRows.TabIndex = 32
        Me.lblGraphRows.Text = "Anzahl Zeilen:"
        '
        'txtGraphRows
        '
        Me.HelpProvider1.SetHelpString(Me.txtGraphRows, "Legen Sie fest, wieviele Zeilen die karierte Vorlage standardmäßig haben soll. Di" &
        "eser Wert ist später überschreibbar.")
        Me.txtGraphRows.Location = New System.Drawing.Point(158, 39)
        Me.txtGraphRows.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtGraphRows.Name = "txtGraphRows"
        Me.HelpProvider1.SetShowHelp(Me.txtGraphRows, True)
        Me.txtGraphRows.Size = New System.Drawing.Size(32, 20)
        Me.txtGraphRows.TabIndex = 6
        Me.txtGraphRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGraphWidth
        '
        Me.HelpProvider1.SetHelpString(Me.txtGraphWidth, "Legen Sie fest, wie groß eine Zelle sein soll. Minimale Größe ist 0,38 cm.")
        Me.txtGraphWidth.Location = New System.Drawing.Point(158, 15)
        Me.txtGraphWidth.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtGraphWidth.Name = "txtGraphWidth"
        Me.HelpProvider1.SetShowHelp(Me.txtGraphWidth, True)
        Me.txtGraphWidth.Size = New System.Drawing.Size(32, 20)
        Me.txtGraphWidth.TabIndex = 5
        Me.txtGraphWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGraphWidth
        '
        Me.lblGraphWidth.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblGraphWidth, "Legen Sie fest, wie groß eine Zelle sein soll. Minimale Größe ist 0,38 cm.")
        Me.lblGraphWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGraphWidth.Location = New System.Drawing.Point(82, 17)
        Me.lblGraphWidth.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGraphWidth.Name = "lblGraphWidth"
        Me.HelpProvider1.SetShowHelp(Me.lblGraphWidth, True)
        Me.lblGraphWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblGraphWidth.TabIndex = 29
        Me.lblGraphWidth.Text = "Zellengröße:"
        '
        'grpLinierteVorlage
        '
        Me.grpLinierteVorlage.Controls.Add(Me.GroupBox6)
        Me.grpLinierteVorlage.Controls.Add(Me.chkRuledButton)
        Me.grpLinierteVorlage.Controls.Add(Me.Label17)
        Me.grpLinierteVorlage.Controls.Add(Me.GroupBox11)
        Me.grpLinierteVorlage.Controls.Add(Me.txtRuledSpacing)
        Me.grpLinierteVorlage.Controls.Add(Me.lblRuledSpacing)
        Me.grpLinierteVorlage.Controls.Add(Me.lblRuledRows)
        Me.grpLinierteVorlage.Controls.Add(Me.txtRuledRows)
        Me.HelpProvider1.SetHelpString(Me.grpLinierteVorlage, "Eine linierte Vorlage dient als Schreibhilfe für Lösungen und kann einen Lösungsv" &
        "orschlag enthalten.")
        Me.grpLinierteVorlage.Location = New System.Drawing.Point(20, 178)
        Me.grpLinierteVorlage.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpLinierteVorlage.Name = "grpLinierteVorlage"
        Me.grpLinierteVorlage.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.grpLinierteVorlage, True)
        Me.grpLinierteVorlage.Size = New System.Drawing.Size(402, 101)
        Me.grpLinierteVorlage.TabIndex = 5
        Me.grpLinierteVorlage.TabStop = False
        Me.grpLinierteVorlage.Text = "linierte Vorlage"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.radRuledStyleWidth100)
        Me.GroupBox6.Controls.Add(Me.radRuledStyleWidth50)
        Me.GroupBox6.Controls.Add(Me.radRuledStyleWidth75)
        Me.HelpProvider1.SetHelpString(Me.GroupBox6, "Wählen Sie aus, ob der Typ der linierte Vorlage dünn, normal oder dick angezeigt " &
        "werden soll.")
        Me.GroupBox6.Location = New System.Drawing.Point(307, 17)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.GroupBox6, True)
        Me.GroupBox6.Size = New System.Drawing.Size(74, 77)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Breite"
        '
        'radRuledStyleWidth100
        '
        Me.radRuledStyleWidth100.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radRuledStyleWidth100, "Die Linie ist dicker. Dies eignet sich für den Typ ""Punkte"".")
        Me.radRuledStyleWidth100.Image = Global.LKTools.My.Resources.Resources.WidthThick1
        Me.radRuledStyleWidth100.Location = New System.Drawing.Point(6, 56)
        Me.radRuledStyleWidth100.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radRuledStyleWidth100.Name = "radRuledStyleWidth100"
        Me.HelpProvider1.SetShowHelp(Me.radRuledStyleWidth100, True)
        Me.radRuledStyleWidth100.Size = New System.Drawing.Size(62, 16)
        Me.radRuledStyleWidth100.TabIndex = 15
        Me.radRuledStyleWidth100.UseVisualStyleBackColor = True
        '
        'radRuledStyleWidth50
        '
        Me.radRuledStyleWidth50.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radRuledStyleWidth50, "Die Linie ist dünn. Dies eignet sich für Typ ""Linie"".")
        Me.radRuledStyleWidth50.Image = Global.LKTools.My.Resources.Resources.WidthSmall1
        Me.radRuledStyleWidth50.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.radRuledStyleWidth50.Location = New System.Drawing.Point(6, 21)
        Me.radRuledStyleWidth50.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radRuledStyleWidth50.Name = "radRuledStyleWidth50"
        Me.HelpProvider1.SetShowHelp(Me.radRuledStyleWidth50, True)
        Me.radRuledStyleWidth50.Size = New System.Drawing.Size(62, 16)
        Me.radRuledStyleWidth50.TabIndex = 13
        Me.radRuledStyleWidth50.UseVisualStyleBackColor = True
        '
        'radRuledStyleWidth75
        '
        Me.radRuledStyleWidth75.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radRuledStyleWidth75, "Die Linie ist normal breit.")
        Me.radRuledStyleWidth75.Image = Global.LKTools.My.Resources.Resources.WidthNormal
        Me.radRuledStyleWidth75.Location = New System.Drawing.Point(6, 39)
        Me.radRuledStyleWidth75.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radRuledStyleWidth75.Name = "radRuledStyleWidth75"
        Me.HelpProvider1.SetShowHelp(Me.radRuledStyleWidth75, True)
        Me.radRuledStyleWidth75.Size = New System.Drawing.Size(62, 16)
        Me.radRuledStyleWidth75.TabIndex = 14
        Me.radRuledStyleWidth75.UseVisualStyleBackColor = True
        '
        'chkRuledButton
        '
        Me.chkRuledButton.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkRuledButton, "Legen Sie fest, ob die Schaltfläche ""Liniert"" im Ribbon LKTools angezeigt werden " &
        "soll. Änderung ist erst nach einem Neustart von MS Word sichtbar.")
        Me.chkRuledButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRuledButton.Location = New System.Drawing.Point(6, 20)
        Me.chkRuledButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkRuledButton.Name = "chkRuledButton"
        Me.HelpProvider1.SetShowHelp(Me.chkRuledButton, True)
        Me.chkRuledButton.Size = New System.Drawing.Size(74, 17)
        Me.chkRuledButton.TabIndex = 7
        Me.chkRuledButton.Text = "Anzeigen*"
        Me.chkRuledButton.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(192, 20)
        Me.Label17.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "cm"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.radStyleDash)
        Me.GroupBox11.Controls.Add(Me.radStyleDot)
        Me.GroupBox11.Controls.Add(Me.radStyleLine)
        Me.GroupBox11.Location = New System.Drawing.Point(224, 17)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox11.Size = New System.Drawing.Size(77, 77)
        Me.GroupBox11.TabIndex = 10
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Typ"
        '
        'radStyleDash
        '
        Me.radStyleDash.AccessibleName = "radStyleDash"
        Me.radStyleDash.AutoSize = True
        Me.radStyleDash.Image = Global.LKTools.My.Resources.Resources.WidthDash1
        Me.radStyleDash.Location = New System.Drawing.Point(6, 56)
        Me.radStyleDash.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radStyleDash.Name = "radStyleDash"
        Me.radStyleDash.Size = New System.Drawing.Size(62, 16)
        Me.radStyleDash.TabIndex = 12
        Me.radStyleDash.UseVisualStyleBackColor = True
        '
        'radStyleDot
        '
        Me.radStyleDot.AccessibleName = "radStyleDot"
        Me.radStyleDot.AutoSize = True
        Me.radStyleDot.Image = Global.LKTools.My.Resources.Resources.WidthDots1
        Me.radStyleDot.Location = New System.Drawing.Point(6, 39)
        Me.radStyleDot.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radStyleDot.Name = "radStyleDot"
        Me.radStyleDot.Size = New System.Drawing.Size(62, 16)
        Me.radStyleDot.TabIndex = 11
        Me.radStyleDot.UseVisualStyleBackColor = True
        '
        'radStyleLine
        '
        Me.radStyleLine.AccessibleName = "radStyleLine"
        Me.radStyleLine.AutoSize = True
        Me.radStyleLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.radStyleLine.Image = Global.LKTools.My.Resources.Resources.WidthNormal
        Me.radStyleLine.Location = New System.Drawing.Point(6, 21)
        Me.radStyleLine.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radStyleLine.Name = "radStyleLine"
        Me.radStyleLine.Size = New System.Drawing.Size(62, 16)
        Me.radStyleLine.TabIndex = 10
        Me.radStyleLine.UseVisualStyleBackColor = True
        '
        'txtRuledSpacing
        '
        Me.HelpProvider1.SetHelpString(Me.txtRuledSpacing, "Legen Sie den Zeilenabstand der eingefügten Zeilen in cm fest.")
        Me.txtRuledSpacing.Location = New System.Drawing.Point(160, 17)
        Me.txtRuledSpacing.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtRuledSpacing.Name = "txtRuledSpacing"
        Me.HelpProvider1.SetShowHelp(Me.txtRuledSpacing, True)
        Me.txtRuledSpacing.Size = New System.Drawing.Size(32, 20)
        Me.txtRuledSpacing.TabIndex = 8
        Me.txtRuledSpacing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRuledSpacing
        '
        Me.lblRuledSpacing.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblRuledSpacing, "Legen Sie den Zeilenabstand der eingefügten Zeilen in cm fest.")
        Me.lblRuledSpacing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRuledSpacing.Location = New System.Drawing.Point(82, 20)
        Me.lblRuledSpacing.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRuledSpacing.Name = "lblRuledSpacing"
        Me.HelpProvider1.SetShowHelp(Me.lblRuledSpacing, True)
        Me.lblRuledSpacing.Size = New System.Drawing.Size(77, 13)
        Me.lblRuledSpacing.TabIndex = 29
        Me.lblRuledSpacing.Text = "Zeilenabstand:"
        '
        'lblRuledRows
        '
        Me.lblRuledRows.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblRuledRows, "Legen Sie fest, wieviele Zeilen die linierte Vorlage standardmäßig haben soll. Di" &
        "eser Wert ist später überschreibbar.")
        Me.lblRuledRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRuledRows.Location = New System.Drawing.Point(82, 45)
        Me.lblRuledRows.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRuledRows.Name = "lblRuledRows"
        Me.HelpProvider1.SetShowHelp(Me.lblRuledRows, True)
        Me.lblRuledRows.Size = New System.Drawing.Size(74, 13)
        Me.lblRuledRows.TabIndex = 0
        Me.lblRuledRows.Text = "Anzahl Zeilen:"
        '
        'txtRuledRows
        '
        Me.HelpProvider1.SetHelpString(Me.txtRuledRows, "Legen Sie fest, wieviele Zeilen die linierte Vorlage standardmäßig haben soll. Di" &
        "eser Wert ist später überschreibbar.")
        Me.txtRuledRows.Location = New System.Drawing.Point(160, 43)
        Me.txtRuledRows.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtRuledRows.Name = "txtRuledRows"
        Me.HelpProvider1.SetShowHelp(Me.txtRuledRows, True)
        Me.txtRuledRows.Size = New System.Drawing.Size(32, 20)
        Me.txtRuledRows.TabIndex = 9
        Me.txtRuledRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkExcerciseButton)
        Me.HelpProvider1.SetHelpString(Me.GroupBox8, "Eine ""Aufgabe"" ist eine Tabelle mit zwei Spalten, deren erste Spalte automatisch " &
        "hochzählt.")
        Me.GroupBox8.Location = New System.Drawing.Point(20, 56)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.GroupBox8, True)
        Me.GroupBox8.Size = New System.Drawing.Size(172, 43)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Aufgabe"
        '
        'chkExcerciseButton
        '
        Me.chkExcerciseButton.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkExcerciseButton, "Legen Sie fest, ob die Schaltfläche ""Aufgabe"" im Ribbon LKTools angezeigt werden " &
        "soll. Änderung ist erst nach einem Neustart von MS Word sichtbar.")
        Me.chkExcerciseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkExcerciseButton.Location = New System.Drawing.Point(6, 20)
        Me.chkExcerciseButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkExcerciseButton.Name = "chkExcerciseButton"
        Me.HelpProvider1.SetShowHelp(Me.chkExcerciseButton, True)
        Me.chkExcerciseButton.Size = New System.Drawing.Size(74, 17)
        Me.chkExcerciseButton.TabIndex = 2
        Me.chkExcerciseButton.Text = "Anzeigen*"
        Me.chkExcerciseButton.UseVisualStyleBackColor = True
        '
        'tabExcercises
        '
        Me.tabExcercises.BackColor = System.Drawing.SystemColors.Control
        Me.tabExcercises.Controls.Add(Me.PictureBox6)
        Me.tabExcercises.Controls.Add(Me.PictureBox5)
        Me.tabExcercises.Controls.Add(Me.grpMC)
        Me.tabExcercises.Controls.Add(Me.grpTrueFalse)
        Me.tabExcercises.Controls.Add(Me.grpLoesungshinweis)
        Me.HelpProvider1.SetHelpString(Me.tabExcercises, "Legen Sie Aufgaben fest und blenden Sie die Schaltflächen ein- oder aus.")
        Me.tabExcercises.Location = New System.Drawing.Point(4, 22)
        Me.tabExcercises.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabExcercises.Name = "tabExcercises"
        Me.tabExcercises.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.tabExcercises, True)
        Me.tabExcercises.Size = New System.Drawing.Size(501, 295)
        Me.tabExcercises.TabIndex = 1
        Me.tabExcercises.Text = "Aufgaben"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.LKTools.My.Resources.Resources.TrueFalse
        Me.PictureBox6.Location = New System.Drawing.Point(4, 78)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 43
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.LKTools.My.Resources.Resources.MC
        Me.PictureBox5.Location = New System.Drawing.Point(4, 8)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 42
        Me.PictureBox5.TabStop = False
        '
        'grpMC
        '
        Me.grpMC.Controls.Add(Me.chkMCAllignRight)
        Me.grpMC.Controls.Add(Me.chkMCButton)
        Me.grpMC.Controls.Add(Me.lblMCRows)
        Me.grpMC.Controls.Add(Me.txtMCRows)
        Me.HelpProvider1.SetHelpString(Me.grpMC, "Fügen Sie MC (Multiple Choice) Aufgaben hinzu.")
        Me.grpMC.Location = New System.Drawing.Point(20, 8)
        Me.grpMC.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpMC.Name = "grpMC"
        Me.grpMC.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.grpMC, True)
        Me.grpMC.Size = New System.Drawing.Size(357, 62)
        Me.grpMC.TabIndex = 1
        Me.grpMC.TabStop = False
        Me.grpMC.Text = "MC (Multiple Choice)"
        '
        'chkMCAllignRight
        '
        Me.chkMCAllignRight.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkMCAllignRight, "Legen Sie fest, ob die Lösungs-Checkbox rechts oder links von dem Text stehen sol" &
        "l.")
        Me.chkMCAllignRight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkMCAllignRight.Location = New System.Drawing.Point(6, 44)
        Me.chkMCAllignRight.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkMCAllignRight.Name = "chkMCAllignRight"
        Me.HelpProvider1.SetShowHelp(Me.chkMCAllignRight, True)
        Me.chkMCAllignRight.Size = New System.Drawing.Size(112, 17)
        Me.chkMCAllignRight.TabIndex = 2
        Me.chkMCAllignRight.Text = "Checkbox rechts?"
        Me.chkMCAllignRight.UseVisualStyleBackColor = True
        '
        'chkMCButton
        '
        Me.chkMCButton.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkMCButton, "Legen Sie fest, ob die Schaltfläche ""MC"" im Ribbon LKTools angezeigt werden soll." &
        " Änderung ist erst nach einem Neustart von MS Word sichtbar.")
        Me.chkMCButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkMCButton.Location = New System.Drawing.Point(6, 20)
        Me.chkMCButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkMCButton.Name = "chkMCButton"
        Me.HelpProvider1.SetShowHelp(Me.chkMCButton, True)
        Me.chkMCButton.Size = New System.Drawing.Size(74, 17)
        Me.chkMCButton.TabIndex = 1
        Me.chkMCButton.Text = "Anzeigen*"
        Me.chkMCButton.UseVisualStyleBackColor = True
        '
        'lblMCRows
        '
        Me.lblMCRows.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblMCRows, resources.GetString("lblMCRows.HelpString"))
        Me.lblMCRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMCRows.Location = New System.Drawing.Point(143, 21)
        Me.lblMCRows.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMCRows.Name = "lblMCRows"
        Me.HelpProvider1.SetShowHelp(Me.lblMCRows, True)
        Me.lblMCRows.Size = New System.Drawing.Size(74, 13)
        Me.lblMCRows.TabIndex = 34
        Me.lblMCRows.Text = "Anzahl Zeilen:"
        '
        'txtMCRows
        '
        Me.HelpProvider1.SetHelpString(Me.txtMCRows, resources.GetString("txtMCRows.HelpString"))
        Me.txtMCRows.Location = New System.Drawing.Point(224, 19)
        Me.txtMCRows.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtMCRows.Name = "txtMCRows"
        Me.HelpProvider1.SetShowHelp(Me.txtMCRows, True)
        Me.txtMCRows.Size = New System.Drawing.Size(32, 20)
        Me.txtMCRows.TabIndex = 3
        Me.txtMCRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpTrueFalse
        '
        Me.grpTrueFalse.Controls.Add(Me.lblTrueFalseReasonDesc)
        Me.grpTrueFalse.Controls.Add(Me.chkTrueFalseButton)
        Me.grpTrueFalse.Controls.Add(Me.txtTrueFalseReasonDesc)
        Me.grpTrueFalse.Controls.Add(Me.chkTrueFalseReason)
        Me.grpTrueFalse.Controls.Add(Me.lblTrueFalseFalseDesc)
        Me.grpTrueFalse.Controls.Add(Me.txtTrueFalseFalseDesc)
        Me.grpTrueFalse.Controls.Add(Me.lblTrueFalseTrueDesc)
        Me.grpTrueFalse.Controls.Add(Me.txtTrueFalseTrueDesc)
        Me.grpTrueFalse.Controls.Add(Me.lblTrueFalseRows)
        Me.grpTrueFalse.Controls.Add(Me.txtTrueFalseRows)
        Me.HelpProvider1.SetHelpString(Me.grpTrueFalse, "Erstellen Sie Richtig/Falsch Aufgaben zum ankreuzen und optional mit Begründung.")
        Me.grpTrueFalse.Location = New System.Drawing.Point(20, 78)
        Me.grpTrueFalse.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpTrueFalse.Name = "grpTrueFalse"
        Me.grpTrueFalse.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.grpTrueFalse, True)
        Me.grpTrueFalse.Size = New System.Drawing.Size(357, 127)
        Me.grpTrueFalse.TabIndex = 2
        Me.grpTrueFalse.TabStop = False
        Me.grpTrueFalse.Text = "Richtig/Falsch Aufgabe"
        '
        'lblTrueFalseReasonDesc
        '
        Me.lblTrueFalseReasonDesc.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblTrueFalseReasonDesc, "Sie können die Standard-Bezeichnung der Spalte ""Begründung"" anpassen.")
        Me.lblTrueFalseReasonDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrueFalseReasonDesc.Location = New System.Drawing.Point(143, 100)
        Me.lblTrueFalseReasonDesc.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTrueFalseReasonDesc.Name = "lblTrueFalseReasonDesc"
        Me.HelpProvider1.SetShowHelp(Me.lblTrueFalseReasonDesc, True)
        Me.lblTrueFalseReasonDesc.Size = New System.Drawing.Size(72, 13)
        Me.lblTrueFalseReasonDesc.TabIndex = 40
        Me.lblTrueFalseReasonDesc.Text = "Bezeichnung:"
        '
        'chkTrueFalseButton
        '
        Me.chkTrueFalseButton.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkTrueFalseButton, "Legen Sie fest, ob die Schaltfläche ""Richtig/Falsch"" im Ribbon LKTools angezeigt " &
        "werden soll. Änderung ist erst nach einem Neustart von MS Word sichtbar.")
        Me.chkTrueFalseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkTrueFalseButton.Location = New System.Drawing.Point(6, 20)
        Me.chkTrueFalseButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkTrueFalseButton.Name = "chkTrueFalseButton"
        Me.HelpProvider1.SetShowHelp(Me.chkTrueFalseButton, True)
        Me.chkTrueFalseButton.Size = New System.Drawing.Size(74, 17)
        Me.chkTrueFalseButton.TabIndex = 1
        Me.chkTrueFalseButton.Text = "Anzeigen*"
        Me.chkTrueFalseButton.UseVisualStyleBackColor = True
        '
        'txtTrueFalseReasonDesc
        '
        Me.HelpProvider1.SetHelpString(Me.txtTrueFalseReasonDesc, "Sie können die Standard-Bezeichnung der Spalte ""Begründung"" anpassen.")
        Me.txtTrueFalseReasonDesc.Location = New System.Drawing.Point(224, 99)
        Me.txtTrueFalseReasonDesc.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtTrueFalseReasonDesc.Name = "txtTrueFalseReasonDesc"
        Me.HelpProvider1.SetShowHelp(Me.txtTrueFalseReasonDesc, True)
        Me.txtTrueFalseReasonDesc.Size = New System.Drawing.Size(107, 20)
        Me.txtTrueFalseReasonDesc.TabIndex = 6
        '
        'chkTrueFalseReason
        '
        Me.chkTrueFalseReason.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkTrueFalseReason, "Legen Sie fest, ob eine Spalte für eine ""Begründung"" eingefügt werden soll.")
        Me.chkTrueFalseReason.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkTrueFalseReason.Location = New System.Drawing.Point(6, 100)
        Me.chkTrueFalseReason.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkTrueFalseReason.Name = "chkTrueFalseReason"
        Me.HelpProvider1.SetShowHelp(Me.chkTrueFalseReason, True)
        Me.chkTrueFalseReason.Size = New System.Drawing.Size(128, 17)
        Me.chkTrueFalseReason.TabIndex = 5
        Me.chkTrueFalseReason.Text = "Begründung einfügen"
        Me.chkTrueFalseReason.UseVisualStyleBackColor = True
        '
        'lblTrueFalseFalseDesc
        '
        Me.lblTrueFalseFalseDesc.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblTrueFalseFalseDesc, "Sie können die Standard-Bezeichnung der Spalte ""Falsch"" anpassen.")
        Me.lblTrueFalseFalseDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrueFalseFalseDesc.Location = New System.Drawing.Point(143, 71)
        Me.lblTrueFalseFalseDesc.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTrueFalseFalseDesc.Name = "lblTrueFalseFalseDesc"
        Me.HelpProvider1.SetShowHelp(Me.lblTrueFalseFalseDesc, True)
        Me.lblTrueFalseFalseDesc.Size = New System.Drawing.Size(75, 13)
        Me.lblTrueFalseFalseDesc.TabIndex = 37
        Me.lblTrueFalseFalseDesc.Text = "Bez. ""Falsch"":"
        '
        'txtTrueFalseFalseDesc
        '
        Me.HelpProvider1.SetHelpString(Me.txtTrueFalseFalseDesc, "Sie können die Standard-Bezeichnung der Spalte ""Falsch"" anpassen.")
        Me.txtTrueFalseFalseDesc.Location = New System.Drawing.Point(224, 69)
        Me.txtTrueFalseFalseDesc.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtTrueFalseFalseDesc.Name = "txtTrueFalseFalseDesc"
        Me.HelpProvider1.SetShowHelp(Me.txtTrueFalseFalseDesc, True)
        Me.txtTrueFalseFalseDesc.Size = New System.Drawing.Size(107, 20)
        Me.txtTrueFalseFalseDesc.TabIndex = 4
        '
        'lblTrueFalseTrueDesc
        '
        Me.lblTrueFalseTrueDesc.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblTrueFalseTrueDesc, "Sie können die Standard-Bezeichnung der Spalte ""Richtig"" anpassen.")
        Me.lblTrueFalseTrueDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrueFalseTrueDesc.Location = New System.Drawing.Point(143, 46)
        Me.lblTrueFalseTrueDesc.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTrueFalseTrueDesc.Name = "lblTrueFalseTrueDesc"
        Me.HelpProvider1.SetShowHelp(Me.lblTrueFalseTrueDesc, True)
        Me.lblTrueFalseTrueDesc.Size = New System.Drawing.Size(77, 13)
        Me.lblTrueFalseTrueDesc.TabIndex = 35
        Me.lblTrueFalseTrueDesc.Text = "Bez. ""Richtig"":"
        '
        'txtTrueFalseTrueDesc
        '
        Me.HelpProvider1.SetHelpString(Me.txtTrueFalseTrueDesc, "Sie können die Standard-Bezeichnung der Spalte ""Richtig"" anpassen.")
        Me.txtTrueFalseTrueDesc.Location = New System.Drawing.Point(224, 45)
        Me.txtTrueFalseTrueDesc.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtTrueFalseTrueDesc.Name = "txtTrueFalseTrueDesc"
        Me.HelpProvider1.SetShowHelp(Me.txtTrueFalseTrueDesc, True)
        Me.txtTrueFalseTrueDesc.Size = New System.Drawing.Size(107, 20)
        Me.txtTrueFalseTrueDesc.TabIndex = 3
        '
        'lblTrueFalseRows
        '
        Me.lblTrueFalseRows.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblTrueFalseRows, resources.GetString("lblTrueFalseRows.HelpString"))
        Me.lblTrueFalseRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrueFalseRows.Location = New System.Drawing.Point(143, 23)
        Me.lblTrueFalseRows.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTrueFalseRows.Name = "lblTrueFalseRows"
        Me.HelpProvider1.SetShowHelp(Me.lblTrueFalseRows, True)
        Me.lblTrueFalseRows.Size = New System.Drawing.Size(74, 13)
        Me.lblTrueFalseRows.TabIndex = 32
        Me.lblTrueFalseRows.Text = "Anzahl Zeilen:"
        '
        'txtTrueFalseRows
        '
        Me.HelpProvider1.SetHelpString(Me.txtTrueFalseRows, resources.GetString("txtTrueFalseRows.HelpString"))
        Me.txtTrueFalseRows.Location = New System.Drawing.Point(224, 22)
        Me.txtTrueFalseRows.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtTrueFalseRows.Name = "txtTrueFalseRows"
        Me.HelpProvider1.SetShowHelp(Me.txtTrueFalseRows, True)
        Me.txtTrueFalseRows.Size = New System.Drawing.Size(32, 20)
        Me.txtTrueFalseRows.TabIndex = 2
        Me.txtTrueFalseRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpLoesungshinweis
        '
        Me.grpLoesungshinweis.Controls.Add(Me.chkAddSolution)
        Me.grpLoesungshinweis.Controls.Add(Me.lblSolutionDescription)
        Me.grpLoesungshinweis.Controls.Add(Me.txtSolutionDescription)
        Me.HelpProvider1.SetHelpString(Me.grpLoesungshinweis, resources.GetString("grpLoesungshinweis.HelpString"))
        Me.grpLoesungshinweis.Location = New System.Drawing.Point(20, 214)
        Me.grpLoesungshinweis.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpLoesungshinweis.Name = "grpLoesungshinweis"
        Me.grpLoesungshinweis.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.grpLoesungshinweis, True)
        Me.grpLoesungshinweis.Size = New System.Drawing.Size(357, 57)
        Me.grpLoesungshinweis.TabIndex = 3
        Me.grpLoesungshinweis.TabStop = False
        Me.grpLoesungshinweis.Text = "Hinweis Lösungsvorschlag"
        '
        'chkAddSolution
        '
        Me.chkAddSolution.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkAddSolution, "Legen Sie fest, ob eine Textbox eingefügt werden soll, die darauf hinweist, dass " &
        "es sich bei der gedruckten Version um die Lösung handelt. ")
        Me.chkAddSolution.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkAddSolution.Location = New System.Drawing.Point(6, 20)
        Me.chkAddSolution.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkAddSolution.Name = "chkAddSolution"
        Me.HelpProvider1.SetShowHelp(Me.chkAddSolution, True)
        Me.chkAddSolution.Size = New System.Drawing.Size(127, 17)
        Me.chkAddSolution.TabIndex = 1
        Me.chkAddSolution.Text = "automatisch einfügen"
        Me.chkAddSolution.UseVisualStyleBackColor = True
        '
        'lblSolutionDescription
        '
        Me.lblSolutionDescription.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblSolutionDescription, "Sie können die Standard-Bezeichnung des Lösungsvorschlags anpassen. Verwenden Sie" &
        " einen ""- "" um einen Zeilenumbruch zu erzwingen.")
        Me.lblSolutionDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSolutionDescription.Location = New System.Drawing.Point(143, 20)
        Me.lblSolutionDescription.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblSolutionDescription.Name = "lblSolutionDescription"
        Me.HelpProvider1.SetShowHelp(Me.lblSolutionDescription, True)
        Me.lblSolutionDescription.Size = New System.Drawing.Size(72, 13)
        Me.lblSolutionDescription.TabIndex = 22
        Me.lblSolutionDescription.Text = "Bezeichnung:"
        '
        'txtSolutionDescription
        '
        Me.txtSolutionDescription.AcceptsTab = True
        Me.HelpProvider1.SetHelpString(Me.txtSolutionDescription, "Sie können die Standard-Bezeichnung des Lösungsvorschlags anpassen. Verwenden Sie" &
        " einen ""- "" um einen Zeilenumbruch zu erzwingen.")
        Me.txtSolutionDescription.Location = New System.Drawing.Point(224, 19)
        Me.txtSolutionDescription.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtSolutionDescription.MaxLength = 40
        Me.txtSolutionDescription.Name = "txtSolutionDescription"
        Me.HelpProvider1.SetShowHelp(Me.txtSolutionDescription, True)
        Me.txtSolutionDescription.Size = New System.Drawing.Size(107, 20)
        Me.txtSolutionDescription.TabIndex = 2
        '
        'tabGrades
        '
        Me.tabGrades.BackColor = System.Drawing.SystemColors.Control
        Me.tabGrades.Controls.Add(Me.chkGradeButton)
        Me.tabGrades.Controls.Add(Me.grpNotenbereich)
        Me.tabGrades.Controls.Add(Me.grpAusgabe)
        Me.tabGrades.Controls.Add(Me.grpIHKStandard)
        Me.tabGrades.Controls.Add(Me.GroupBox3)
        Me.tabGrades.Controls.Add(Me.Label16)
        Me.tabGrades.Controls.Add(Me.GradeGraph)
        Me.tabGrades.Controls.Add(Me.PictureBox7)
        Me.HelpProvider1.SetHelpString(Me.tabGrades, "Legen Sie die Standard-Notenskala fest oder blenden Sie die Schaltflächen ein- od" &
        "er aus.")
        Me.tabGrades.Location = New System.Drawing.Point(4, 22)
        Me.tabGrades.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabGrades.Name = "tabGrades"
        Me.HelpProvider1.SetShowHelp(Me.tabGrades, True)
        Me.tabGrades.Size = New System.Drawing.Size(501, 295)
        Me.tabGrades.TabIndex = 2
        Me.tabGrades.Text = "Notensklala"
        '
        'chkGradeButton
        '
        Me.chkGradeButton.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkGradeButton, "Legen Sie fest, ob die Schaltfläche ""Noten"" im Ribbon LKTools angezeigt werden so" &
        "ll. Änderung ist erst nach einem Neustart von MS Word sichtbar.")
        Me.chkGradeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkGradeButton.Location = New System.Drawing.Point(28, 8)
        Me.chkGradeButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkGradeButton.Name = "chkGradeButton"
        Me.HelpProvider1.SetShowHelp(Me.chkGradeButton, True)
        Me.chkGradeButton.Size = New System.Drawing.Size(74, 17)
        Me.chkGradeButton.TabIndex = 1
        Me.chkGradeButton.Text = "Anzeigen*"
        Me.chkGradeButton.UseVisualStyleBackColor = True
        '
        'grpNotenbereich
        '
        Me.grpNotenbereich.Controls.Add(Me.txtGrade5)
        Me.grpNotenbereich.Controls.Add(Me.lblGrade1)
        Me.grpNotenbereich.Controls.Add(Me.lblGrade2)
        Me.grpNotenbereich.Controls.Add(Me.lblGrade3)
        Me.grpNotenbereich.Controls.Add(Me.txtGrade4)
        Me.grpNotenbereich.Controls.Add(Me.lblGrade4)
        Me.grpNotenbereich.Controls.Add(Me.txtGrade3)
        Me.grpNotenbereich.Controls.Add(Me.lblGrade5)
        Me.grpNotenbereich.Controls.Add(Me.txtGrade2)
        Me.grpNotenbereich.Controls.Add(Me.Label30)
        Me.grpNotenbereich.Controls.Add(Me.txtGrade1)
        Me.grpNotenbereich.Controls.Add(Me.Label31)
        Me.grpNotenbereich.Controls.Add(Me.Label34)
        Me.grpNotenbereich.Controls.Add(Me.Label33)
        Me.grpNotenbereich.Controls.Add(Me.Label32)
        Me.grpNotenbereich.Location = New System.Drawing.Point(19, 36)
        Me.grpNotenbereich.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpNotenbereich.Name = "grpNotenbereich"
        Me.grpNotenbereich.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpNotenbereich.Size = New System.Drawing.Size(140, 158)
        Me.grpNotenbereich.TabIndex = 1
        Me.grpNotenbereich.TabStop = False
        Me.grpNotenbereich.Text = "Notenbereich"
        '
        'txtGrade5
        '
        Me.HelpProvider1.SetHelpString(Me.txtGrade5, "Geben Sie an, bis wieviel Prozent die Note 5 vergeben werden soll. Wert muss nied" &
        "riger als die besseren Noten sein.")
        Me.txtGrade5.Location = New System.Drawing.Point(76, 113)
        Me.txtGrade5.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtGrade5.Name = "txtGrade5"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade5, True)
        Me.txtGrade5.Size = New System.Drawing.Size(32, 20)
        Me.txtGrade5.TabIndex = 16
        Me.txtGrade5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGrade1
        '
        Me.lblGrade1.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblGrade1, "Geben Sie an, bis wieviel Prozent die Note 1 vergeben werden soll.")
        Me.lblGrade1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrade1.Location = New System.Drawing.Point(8, 19)
        Me.lblGrade1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGrade1.Name = "lblGrade1"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade1, True)
        Me.lblGrade1.Size = New System.Drawing.Size(58, 13)
        Me.lblGrade1.TabIndex = 0
        Me.lblGrade1.Text = "Note 1 bis:"
        '
        'lblGrade2
        '
        Me.lblGrade2.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblGrade2, "Geben Sie an, bis wieviel Prozent die Note 2 vergeben werden soll. Wert muss nied" &
        "riger als die besseren Noten sein.")
        Me.lblGrade2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrade2.Location = New System.Drawing.Point(8, 43)
        Me.lblGrade2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGrade2.Name = "lblGrade2"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade2, True)
        Me.lblGrade2.Size = New System.Drawing.Size(58, 13)
        Me.lblGrade2.TabIndex = 1
        Me.lblGrade2.Text = "Note 2 bis:"
        '
        'lblGrade3
        '
        Me.lblGrade3.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblGrade3, "Geben Sie an, bis wieviel Prozent die Note 3 vergeben werden soll. Wert muss nied" &
        "riger als die besseren Noten sein.")
        Me.lblGrade3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrade3.Location = New System.Drawing.Point(8, 68)
        Me.lblGrade3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGrade3.Name = "lblGrade3"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade3, True)
        Me.lblGrade3.Size = New System.Drawing.Size(58, 13)
        Me.lblGrade3.TabIndex = 2
        Me.lblGrade3.Text = "Note 3 bis:"
        '
        'txtGrade4
        '
        Me.HelpProvider1.SetHelpString(Me.txtGrade4, "Geben Sie an, bis wieviel Prozent die Note 4 vergeben werden soll. Wert muss nied" &
        "riger als die besseren Noten sein.")
        Me.txtGrade4.Location = New System.Drawing.Point(77, 89)
        Me.txtGrade4.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtGrade4.Name = "txtGrade4"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade4, True)
        Me.txtGrade4.Size = New System.Drawing.Size(32, 20)
        Me.txtGrade4.TabIndex = 15
        Me.txtGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGrade4
        '
        Me.lblGrade4.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblGrade4, "Geben Sie an, bis wieviel Prozent die Note 4 vergeben werden soll. Wert muss nied" &
        "riger als die besseren Noten sein.")
        Me.lblGrade4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrade4.Location = New System.Drawing.Point(8, 91)
        Me.lblGrade4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGrade4.Name = "lblGrade4"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade4, True)
        Me.lblGrade4.Size = New System.Drawing.Size(58, 13)
        Me.lblGrade4.TabIndex = 3
        Me.lblGrade4.Text = "Note 4 bis:"
        '
        'txtGrade3
        '
        Me.HelpProvider1.SetHelpString(Me.txtGrade3, "Geben Sie an, bis wieviel Prozent die Note 3 vergeben werden soll. Wert muss nied" &
        "riger als die besseren Noten sein.")
        Me.txtGrade3.Location = New System.Drawing.Point(77, 65)
        Me.txtGrade3.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtGrade3.Name = "txtGrade3"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade3, True)
        Me.txtGrade3.Size = New System.Drawing.Size(32, 20)
        Me.txtGrade3.TabIndex = 14
        Me.txtGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGrade5
        '
        Me.lblGrade5.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblGrade5, "Geben Sie an, bis wieviel Prozent die Note 5 vergeben werden soll. Wert muss nied" &
        "riger als die besseren Noten sein.")
        Me.lblGrade5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrade5.Location = New System.Drawing.Point(8, 115)
        Me.lblGrade5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGrade5.Name = "lblGrade5"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade5, True)
        Me.lblGrade5.Size = New System.Drawing.Size(58, 13)
        Me.lblGrade5.TabIndex = 4
        Me.lblGrade5.Text = "Note 5 bis:"
        '
        'txtGrade2
        '
        Me.HelpProvider1.SetHelpString(Me.txtGrade2, "Geben Sie an, bis wieviel Prozent die Note 2 vergeben werden soll. Wert muss nied" &
        "riger als die besseren Noten sein.")
        Me.txtGrade2.Location = New System.Drawing.Point(77, 40)
        Me.txtGrade2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtGrade2.Name = "txtGrade2"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade2, True)
        Me.txtGrade2.Size = New System.Drawing.Size(32, 20)
        Me.txtGrade2.TabIndex = 13
        Me.txtGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(109, 18)
        Me.Label30.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(15, 13)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "%"
        '
        'txtGrade1
        '
        Me.HelpProvider1.SetHelpString(Me.txtGrade1, "Geben Sie an, bis wieviel Prozent die Note 1 vergeben werden soll.")
        Me.txtGrade1.Location = New System.Drawing.Point(77, 16)
        Me.txtGrade1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtGrade1.Name = "txtGrade1"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade1, True)
        Me.txtGrade1.Size = New System.Drawing.Size(32, 20)
        Me.txtGrade1.TabIndex = 12
        Me.txtGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(109, 42)
        Me.Label31.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(15, 13)
        Me.Label31.TabIndex = 6
        Me.Label31.Text = "%"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(109, 115)
        Me.Label34.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(15, 13)
        Me.Label34.TabIndex = 9
        Me.Label34.Text = "%"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(109, 67)
        Me.Label33.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(15, 13)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "%"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(109, 90)
        Me.Label32.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(15, 13)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "%"
        '
        'grpAusgabe
        '
        Me.grpAusgabe.Controls.Add(Me.chkNoRounding)
        Me.grpAusgabe.Controls.Add(Me.chk05Rounding)
        Me.grpAusgabe.Location = New System.Drawing.Point(19, 207)
        Me.grpAusgabe.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpAusgabe.Name = "grpAusgabe"
        Me.grpAusgabe.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpAusgabe.Size = New System.Drawing.Size(140, 78)
        Me.grpAusgabe.TabIndex = 3
        Me.grpAusgabe.TabStop = False
        Me.grpAusgabe.Text = "Ausgabe"
        '
        'chkNoRounding
        '
        Me.chkNoRounding.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkNoRounding, "Legen Sie fest, ob standardmäßig eine exakte Berechnung (2 Nachkommastellen) ausg" &
        "egeben werden soll. Der Wert ist beim Einfügen der Noten überschreibbar.")
        Me.chkNoRounding.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkNoRounding.Location = New System.Drawing.Point(9, 40)
        Me.chkNoRounding.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkNoRounding.Name = "chkNoRounding"
        Me.HelpProvider1.SetShowHelp(Me.chkNoRounding, True)
        Me.chkNoRounding.Size = New System.Drawing.Size(119, 17)
        Me.chkNoRounding.TabIndex = 2
        Me.chkNoRounding.Text = "exakte Berechnung"
        Me.chkNoRounding.UseVisualStyleBackColor = True
        '
        'chk05Rounding
        '
        Me.chk05Rounding.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chk05Rounding, "Legen Sie fest, ob standardmäßig auf 0,5 % gerundet ausgegeben werden soll. Der W" &
        "ert ist beim Einfügen der Noten überschreibbar.")
        Me.chk05Rounding.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chk05Rounding.Location = New System.Drawing.Point(9, 17)
        Me.chk05Rounding.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chk05Rounding.Name = "chk05Rounding"
        Me.HelpProvider1.SetShowHelp(Me.chk05Rounding, True)
        Me.chk05Rounding.Size = New System.Drawing.Size(95, 17)
        Me.chk05Rounding.TabIndex = 1
        Me.chk05Rounding.Text = "auf 0,5 runden"
        Me.chk05Rounding.UseVisualStyleBackColor = True
        '
        'grpIHKStandard
        '
        Me.grpIHKStandard.Controls.Add(Me.btnGradeDefault2)
        Me.grpIHKStandard.Controls.Add(Me.btnGradeDefault5)
        Me.grpIHKStandard.Controls.Add(Me.btnGradeDefault1)
        Me.grpIHKStandard.Controls.Add(Me.btnGradeDefault3)
        Me.grpIHKStandard.Controls.Add(Me.btnGradeDefault4)
        Me.grpIHKStandard.Location = New System.Drawing.Point(166, 36)
        Me.grpIHKStandard.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpIHKStandard.Name = "grpIHKStandard"
        Me.grpIHKStandard.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpIHKStandard.Size = New System.Drawing.Size(100, 158)
        Me.grpIHKStandard.TabIndex = 2
        Me.grpIHKStandard.TabStop = False
        Me.grpIHKStandard.Text = "Standard IHK"
        '
        'btnGradeDefault2
        '
        Me.HelpProvider1.SetHelpString(Me.btnGradeDefault2, "Legt den Notenbereich der Note 2 auf 81 % fest. Dies entspricht dem Notenschlüsse" &
        "l der IHK.")
        Me.btnGradeDefault2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGradeDefault2.Location = New System.Drawing.Point(8, 37)
        Me.btnGradeDefault2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnGradeDefault2.Name = "btnGradeDefault2"
        Me.HelpProvider1.SetShowHelp(Me.btnGradeDefault2, True)
        Me.btnGradeDefault2.Size = New System.Drawing.Size(78, 22)
        Me.btnGradeDefault2.TabIndex = 18
        Me.btnGradeDefault2.Text = "81 %"
        Me.btnGradeDefault2.UseVisualStyleBackColor = True
        '
        'btnGradeDefault5
        '
        Me.HelpProvider1.SetHelpString(Me.btnGradeDefault5, "Legt den Notenbereich der Note 5 auf 30 % fest. Dies entspricht dem Notenschlüsse" &
        "l der IHK.")
        Me.btnGradeDefault5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGradeDefault5.Location = New System.Drawing.Point(8, 112)
        Me.btnGradeDefault5.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnGradeDefault5.Name = "btnGradeDefault5"
        Me.HelpProvider1.SetShowHelp(Me.btnGradeDefault5, True)
        Me.btnGradeDefault5.Size = New System.Drawing.Size(78, 22)
        Me.btnGradeDefault5.TabIndex = 21
        Me.btnGradeDefault5.Text = "30 %"
        Me.btnGradeDefault5.UseVisualStyleBackColor = True
        '
        'btnGradeDefault1
        '
        Me.HelpProvider1.SetHelpString(Me.btnGradeDefault1, "Legt den Notenbereich der Note 1 auf 92 % fest. Dies entspricht dem Notenschlüsse" &
        "l der IHK.")
        Me.btnGradeDefault1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGradeDefault1.Location = New System.Drawing.Point(8, 13)
        Me.btnGradeDefault1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnGradeDefault1.Name = "btnGradeDefault1"
        Me.HelpProvider1.SetShowHelp(Me.btnGradeDefault1, True)
        Me.btnGradeDefault1.Size = New System.Drawing.Size(78, 22)
        Me.btnGradeDefault1.TabIndex = 17
        Me.btnGradeDefault1.Text = "92 %"
        Me.btnGradeDefault1.UseVisualStyleBackColor = True
        '
        'btnGradeDefault3
        '
        Me.HelpProvider1.SetHelpString(Me.btnGradeDefault3, "Legt den Notenbereich der Note 3 auf 67 % fest. Dies entspricht dem Notenschlüsse" &
        "l der IHK.")
        Me.btnGradeDefault3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGradeDefault3.Location = New System.Drawing.Point(8, 61)
        Me.btnGradeDefault3.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnGradeDefault3.Name = "btnGradeDefault3"
        Me.HelpProvider1.SetShowHelp(Me.btnGradeDefault3, True)
        Me.btnGradeDefault3.Size = New System.Drawing.Size(78, 22)
        Me.btnGradeDefault3.TabIndex = 19
        Me.btnGradeDefault3.Text = "67 %"
        Me.btnGradeDefault3.UseVisualStyleBackColor = True
        '
        'btnGradeDefault4
        '
        Me.HelpProvider1.SetHelpString(Me.btnGradeDefault4, "Legt den Notenbereich der Note 4 auf 50 % fest. Dies entspricht dem Notenschlüsse" &
        "l der IHK.")
        Me.btnGradeDefault4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGradeDefault4.Location = New System.Drawing.Point(8, 87)
        Me.btnGradeDefault4.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnGradeDefault4.Name = "btnGradeDefault4"
        Me.HelpProvider1.SetShowHelp(Me.btnGradeDefault4, True)
        Me.btnGradeDefault4.Size = New System.Drawing.Size(78, 22)
        Me.btnGradeDefault4.TabIndex = 20
        Me.btnGradeDefault4.Text = "50 %"
        Me.btnGradeDefault4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGradelinear)
        Me.GroupBox3.Controls.Add(Me.btnGradehart)
        Me.GroupBox3.Location = New System.Drawing.Point(166, 207)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox3.Size = New System.Drawing.Size(100, 78)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Notenverteilung"
        '
        'btnGradelinear
        '
        Me.btnGradelinear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnGradelinear, "Gleichmäßige Verteilung der % Werte bzw. der Punkte auf alle Notenbereiche.")
        Me.btnGradelinear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGradelinear.Location = New System.Drawing.Point(10, 20)
        Me.btnGradelinear.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnGradelinear.Name = "btnGradelinear"
        Me.HelpProvider1.SetShowHelp(Me.btnGradelinear, True)
        Me.btnGradelinear.Size = New System.Drawing.Size(76, 22)
        Me.btnGradelinear.TabIndex = 1
        Me.btnGradelinear.Text = "linear"
        Me.btnGradelinear.UseVisualStyleBackColor = True
        '
        'btnGradehart
        '
        Me.btnGradehart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnGradehart, "Die Verteilung der Noten erfolgt degressiv. Dies entspricht dem IHK Standard.")
        Me.btnGradehart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGradehart.Location = New System.Drawing.Point(10, 48)
        Me.btnGradehart.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnGradehart.Name = "btnGradehart"
        Me.HelpProvider1.SetShowHelp(Me.btnGradehart, True)
        Me.btnGradehart.Size = New System.Drawing.Size(76, 22)
        Me.btnGradehart.TabIndex = 2
        Me.btnGradehart.Text = "degressiv"
        Me.btnGradehart.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.Label16, "Die Visualisierung dient der Veranschaulichung der Notenbereiche.")
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(281, 10)
        Me.Label16.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label16.Name = "Label16"
        Me.HelpProvider1.SetShowHelp(Me.Label16, True)
        Me.Label16.Size = New System.Drawing.Size(142, 13)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Visualisierung der Verteilung:"
        '
        'GradeGraph
        '
        ChartArea1.AxisX.IntervalOffset = 1.0R
        ChartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.IsStartedFromZero = False
        ChartArea1.AxisX.Maximum = 6.0R
        ChartArea1.AxisX.Minimum = 1.0R
        ChartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisY.MajorGrid.Interval = 0R
        ChartArea1.CursorX.IntervalOffset = 1.0R
        ChartArea1.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.CursorX.LineWidth = 4
        ChartArea1.Name = "ChartArea1"
        Me.GradeGraph.ChartAreas.Add(ChartArea1)
        Me.HelpProvider1.SetHelpString(Me.GradeGraph, "Anzeige der Notenverteilung in Prozent. Änderung der Noten wirken sich direkt auf" &
        " die Anzeige aus.")
        Me.GradeGraph.Location = New System.Drawing.Point(281, 40)
        Me.GradeGraph.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GradeGraph.Name = "GradeGraph"
        Me.GradeGraph.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Name = "Series1"
        Me.GradeGraph.Series.Add(Series1)
        Me.HelpProvider1.SetShowHelp(Me.GradeGraph, True)
        Me.GradeGraph.Size = New System.Drawing.Size(188, 174)
        Me.GradeGraph.TabIndex = 51
        Me.GradeGraph.Text = "Grafische Darstellung"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.LKTools.My.Resources.Resources.AddForm_369
        Me.PictureBox7.Location = New System.Drawing.Point(4, 8)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 54
        Me.PictureBox7.TabStop = False
        '
        'tabPath
        '
        Me.tabPath.BackColor = System.Drawing.SystemColors.Control
        Me.tabPath.Controls.Add(Me.grpPath)
        Me.tabPath.Controls.Add(Me.PictureBox15)
        Me.HelpProvider1.SetHelpString(Me.tabPath, "Legen Sie fest, wie Sie den Pfad des Dokumentes einfügen möchten.")
        Me.tabPath.Location = New System.Drawing.Point(4, 22)
        Me.tabPath.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabPath.Name = "tabPath"
        Me.HelpProvider1.SetShowHelp(Me.tabPath, True)
        Me.tabPath.Size = New System.Drawing.Size(501, 295)
        Me.tabPath.TabIndex = 3
        Me.tabPath.Text = "Pfad"
        '
        'grpPath
        '
        Me.grpPath.Controls.Add(Me.radNoPath)
        Me.grpPath.Controls.Add(Me.chkPathAddDocumentName)
        Me.grpPath.Controls.Add(Me.txtPathNumberFolders)
        Me.grpPath.Controls.Add(Me.lblPathNumberFolders)
        Me.grpPath.Controls.Add(Me.radRelPath)
        Me.grpPath.Controls.Add(Me.radFullPath)
        Me.grpPath.Controls.Add(Me.chkPathButton)
        Me.HelpProvider1.SetHelpString(Me.grpPath, "Erstellen Sie Richtig/Falsch Aufgaben zum ankreuzen und optional mit Begründung.")
        Me.grpPath.Location = New System.Drawing.Point(20, 8)
        Me.grpPath.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpPath.Name = "grpPath"
        Me.grpPath.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.grpPath, True)
        Me.grpPath.Size = New System.Drawing.Size(471, 143)
        Me.grpPath.TabIndex = 57
        Me.grpPath.TabStop = False
        Me.grpPath.Text = "Pfad Optionen"
        '
        'radNoPath
        '
        Me.radNoPath.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radNoPath, "Es wird kein Pfad eingefügt.")
        Me.radNoPath.Location = New System.Drawing.Point(6, 88)
        Me.radNoPath.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radNoPath.Name = "radNoPath"
        Me.HelpProvider1.SetShowHelp(Me.radNoPath, True)
        Me.radNoPath.Size = New System.Drawing.Size(70, 17)
        Me.radNoPath.TabIndex = 45
        Me.radNoPath.TabStop = True
        Me.radNoPath.Text = "kein Pfad"
        Me.radNoPath.UseVisualStyleBackColor = True
        '
        'chkPathAddDocumentName
        '
        Me.chkPathAddDocumentName.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkPathAddDocumentName, "Die Dokumentenbezeichnung wird eingefügt.")
        Me.chkPathAddDocumentName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkPathAddDocumentName.Location = New System.Drawing.Point(6, 116)
        Me.chkPathAddDocumentName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkPathAddDocumentName.Name = "chkPathAddDocumentName"
        Me.HelpProvider1.SetShowHelp(Me.chkPathAddDocumentName, True)
        Me.chkPathAddDocumentName.Size = New System.Drawing.Size(158, 17)
        Me.chkPathAddDocumentName.TabIndex = 44
        Me.chkPathAddDocumentName.Text = "Dok. Bezeichnung einfügen"
        Me.chkPathAddDocumentName.UseVisualStyleBackColor = True
        '
        'txtPathNumberFolders
        '
        Me.txtPathNumberFolders.AcceptsTab = True
        Me.HelpProvider1.SetHelpString(Me.txtPathNumberFolders, "Die Anzahl der übergeordneten Ordner muss hier festgelegt werden, wenn ein relati" &
        "ver Pfad eingefügt werden muss. ")
        Me.txtPathNumberFolders.Location = New System.Drawing.Point(206, 64)
        Me.txtPathNumberFolders.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtPathNumberFolders.MaxLength = 40
        Me.txtPathNumberFolders.Name = "txtPathNumberFolders"
        Me.HelpProvider1.SetShowHelp(Me.txtPathNumberFolders, True)
        Me.txtPathNumberFolders.Size = New System.Drawing.Size(48, 20)
        Me.txtPathNumberFolders.TabIndex = 43
        '
        'lblPathNumberFolders
        '
        Me.lblPathNumberFolders.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblPathNumberFolders, "Legt die Anzahl der übergeordneten Ordner bei einem relativen Pfad fest.")
        Me.lblPathNumberFolders.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPathNumberFolders.Location = New System.Drawing.Point(117, 66)
        Me.lblPathNumberFolders.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPathNumberFolders.Name = "lblPathNumberFolders"
        Me.HelpProvider1.SetShowHelp(Me.lblPathNumberFolders, True)
        Me.lblPathNumberFolders.Size = New System.Drawing.Size(82, 13)
        Me.lblPathNumberFolders.TabIndex = 42
        Me.lblPathNumberFolders.Text = "Anzahl Ebenen:"
        '
        'radRelPath
        '
        Me.radRelPath.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radRelPath, "Ein relativer Pfad wird eingefügt. Bsp: ../Dokumente")
        Me.radRelPath.Location = New System.Drawing.Point(6, 65)
        Me.radRelPath.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radRelPath.Name = "radRelPath"
        Me.HelpProvider1.SetShowHelp(Me.radRelPath, True)
        Me.radRelPath.Size = New System.Drawing.Size(87, 17)
        Me.radRelPath.TabIndex = 41
        Me.radRelPath.TabStop = True
        Me.radRelPath.Text = "relativer Pfad"
        Me.radRelPath.UseVisualStyleBackColor = True
        '
        'radFullPath
        '
        Me.radFullPath.AutoSize = True
        Me.radFullPath.Checked = True
        Me.HelpProvider1.SetHelpString(Me.radFullPath, "Der vollständige Pfad wird eingefügt.")
        Me.radFullPath.Location = New System.Drawing.Point(6, 43)
        Me.radFullPath.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radFullPath.Name = "radFullPath"
        Me.HelpProvider1.SetShowHelp(Me.radFullPath, True)
        Me.radFullPath.Size = New System.Drawing.Size(110, 17)
        Me.radFullPath.TabIndex = 40
        Me.radFullPath.TabStop = True
        Me.radFullPath.Text = "Vollständiger Pfad"
        Me.radFullPath.UseVisualStyleBackColor = True
        '
        'chkPathButton
        '
        Me.chkPathButton.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkPathButton, "Legen Sie fest, ob die Schaltfläche ""Pfad"" im Ribbon LKTools angezeigt werden sol" &
        "l. Änderung ist erst nach einem Neustart von MS Word sichtbar.")
        Me.chkPathButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkPathButton.Location = New System.Drawing.Point(6, 20)
        Me.chkPathButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkPathButton.Name = "chkPathButton"
        Me.HelpProvider1.SetShowHelp(Me.chkPathButton, True)
        Me.chkPathButton.Size = New System.Drawing.Size(74, 17)
        Me.chkPathButton.TabIndex = 1
        Me.chkPathButton.Text = "Anzeigen*"
        Me.chkPathButton.UseVisualStyleBackColor = True
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.Image = Global.LKTools.My.Resources.Resources.NavigationPath_6036
        Me.PictureBox15.Location = New System.Drawing.Point(4, 8)
        Me.PictureBox15.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 56
        Me.PictureBox15.TabStop = False
        '
        'tabPresentation
        '
        Me.tabPresentation.AutoScroll = True
        Me.tabPresentation.Controls.Add(Me.Label12)
        Me.tabPresentation.Controls.Add(Me.txtOverlayTransparency)
        Me.tabPresentation.Controls.Add(Me.lblOverlayTransparency)
        Me.tabPresentation.Controls.Add(Me.chkShowOverlayFunction)
        Me.tabPresentation.Controls.Add(Me.btnOverlayDefault)
        Me.tabPresentation.Controls.Add(Me.Label3)
        Me.tabPresentation.Controls.Add(Me.btnColorOverlay)
        Me.tabPresentation.Controls.Add(Me.lblOverlayExample)
        Me.HelpProvider1.SetHelpString(Me.tabPresentation, "Legen Sie hier Einstellungen zur Überlagerungsfunktion fest.")
        Me.tabPresentation.Location = New System.Drawing.Point(4, 22)
        Me.tabPresentation.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabPresentation.Name = "tabPresentation"
        Me.HelpProvider1.SetShowHelp(Me.tabPresentation, True)
        Me.tabPresentation.Size = New System.Drawing.Size(501, 295)
        Me.tabPresentation.TabIndex = 4
        Me.tabPresentation.Text = "Präsentation"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.Label12, "")
        Me.HelpProvider1.SetHelpString(Me.Label12, "Legen Sie die Transparenz der Überlagerung fest.")
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(195, 79)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.HelpProvider1.SetShowHelp(Me.Label12, True)
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "%"
        '
        'txtOverlayTransparency
        '
        Me.HelpProvider1.SetHelpString(Me.txtOverlayTransparency, "Legen Sie fest, wie groß eine Zelle sein soll. Minimale Größe ist 0,38 cm.")
        Me.txtOverlayTransparency.Location = New System.Drawing.Point(162, 76)
        Me.txtOverlayTransparency.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtOverlayTransparency.Name = "txtOverlayTransparency"
        Me.HelpProvider1.SetShowHelp(Me.txtOverlayTransparency, True)
        Me.txtOverlayTransparency.Size = New System.Drawing.Size(32, 20)
        Me.txtOverlayTransparency.TabIndex = 12
        Me.txtOverlayTransparency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOverlayTransparency
        '
        Me.lblOverlayTransparency.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.lblOverlayTransparency, "")
        Me.HelpProvider1.SetHelpString(Me.lblOverlayTransparency, "Legen Sie die Transparenz der Überlagerung fest.")
        Me.lblOverlayTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOverlayTransparency.Location = New System.Drawing.Point(11, 78)
        Me.lblOverlayTransparency.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOverlayTransparency.Name = "lblOverlayTransparency"
        Me.HelpProvider1.SetShowHelp(Me.lblOverlayTransparency, True)
        Me.lblOverlayTransparency.Size = New System.Drawing.Size(91, 13)
        Me.lblOverlayTransparency.TabIndex = 11
        Me.lblOverlayTransparency.Text = "Transparenz in %:"
        '
        'chkShowOverlayFunction
        '
        Me.chkShowOverlayFunction.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkShowOverlayFunction, "Legen Sie fest, ob die Schaltflächen ""Überlagerung"" im Ribbon LKTools angezeigt w" &
        "erden soll. Änderung ist erst nach einem Neustart von MS Word sichtbar.")
        Me.chkShowOverlayFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkShowOverlayFunction.Location = New System.Drawing.Point(13, 10)
        Me.chkShowOverlayFunction.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkShowOverlayFunction.Name = "chkShowOverlayFunction"
        Me.HelpProvider1.SetShowHelp(Me.chkShowOverlayFunction, True)
        Me.chkShowOverlayFunction.Size = New System.Drawing.Size(74, 17)
        Me.chkShowOverlayFunction.TabIndex = 10
        Me.chkShowOverlayFunction.Text = "Anzeigen*"
        Me.chkShowOverlayFunction.UseVisualStyleBackColor = True
        '
        'btnOverlayDefault
        '
        Me.HelpProvider1.SetHelpString(Me.btnOverlayDefault, "Setzen die Farbe auf die LKTools Standardfarbe zurück")
        Me.btnOverlayDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOverlayDefault.Location = New System.Drawing.Point(329, 41)
        Me.btnOverlayDefault.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnOverlayDefault.Name = "btnOverlayDefault"
        Me.HelpProvider1.SetShowHelp(Me.btnOverlayDefault, True)
        Me.btnOverlayDefault.Size = New System.Drawing.Size(77, 22)
        Me.btnOverlayDefault.TabIndex = 8
        Me.btnOverlayDefault.Text = "Standard"
        Me.btnOverlayDefault.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.Label3, "")
        Me.HelpProvider1.SetHelpString(Me.Label3, "Wählen Sie die Farbe aus, in denen Überlagerungen eingerahmt sein sollen.")
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(11, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.HelpProvider1.SetShowHelp(Me.Label3, True)
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Farbe überlagern:"
        '
        'btnColorOverlay
        '
        Me.HelpProvider1.SetHelpString(Me.btnColorOverlay, "Wählen Sie die Farbe aus, in denen Überlagerungen eingerahmt sein sollen.")
        Me.btnColorOverlay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnColorOverlay.Location = New System.Drawing.Point(120, 41)
        Me.btnColorOverlay.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnColorOverlay.Name = "btnColorOverlay"
        Me.HelpProvider1.SetShowHelp(Me.btnColorOverlay, True)
        Me.btnColorOverlay.Size = New System.Drawing.Size(72, 22)
        Me.btnColorOverlay.TabIndex = 7
        Me.btnColorOverlay.Text = "Auswahl"
        Me.btnColorOverlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnColorOverlay.UseVisualStyleBackColor = True
        '
        'lblOverlayExample
        '
        Me.lblOverlayExample.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblOverlayExample, "Vorschau, der ausgewählten Farbe")
        Me.lblOverlayExample.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOverlayExample.Location = New System.Drawing.Point(201, 45)
        Me.lblOverlayExample.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOverlayExample.Name = "lblOverlayExample"
        Me.HelpProvider1.SetShowHelp(Me.lblOverlayExample, True)
        Me.lblOverlayExample.Size = New System.Drawing.Size(114, 13)
        Me.lblOverlayExample.TabIndex = 9
        Me.lblOverlayExample.Text = "Dies ist ein Beispieltext"
        '
        'tabExport
        '
        Me.tabExport.AutoScroll = True
        Me.tabExport.BackColor = System.Drawing.SystemColors.Control
        Me.tabExport.Controls.Add(Me.tabExportDetail)
        Me.HelpProvider1.SetHelpString(Me.tabExport, "Legen Sie Einstellungen für den Export (Druck, PDF) fest.")
        Me.tabExport.Location = New System.Drawing.Point(4, 22)
        Me.tabExport.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabExport.Name = "tabExport"
        Me.tabExport.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.tabExport, False)
        Me.tabExport.Size = New System.Drawing.Size(516, 344)
        Me.tabExport.TabIndex = 2
        Me.tabExport.Text = "Ausgabe"
        Me.tabExport.ToolTipText = "Festlegung der Ausgabe"
        '
        'tabExportDetail
        '
        Me.tabExportDetail.Controls.Add(Me.tabExportGeneral)
        Me.tabExportDetail.Controls.Add(Me.tabExportPDF)
        Me.tabExportDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabExportDetail.Location = New System.Drawing.Point(1, 1)
        Me.tabExportDetail.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabExportDetail.Name = "tabExportDetail"
        Me.tabExportDetail.SelectedIndex = 0
        Me.tabExportDetail.Size = New System.Drawing.Size(514, 342)
        Me.tabExportDetail.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabExportDetail.TabIndex = 46
        '
        'tabExportGeneral
        '
        Me.tabExportGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.tabExportGeneral.Controls.Add(Me.GroupBox12)
        Me.tabExportGeneral.Controls.Add(Me.GroupBox1)
        Me.tabExportGeneral.Controls.Add(Me.GroupBox7)
        Me.tabExportGeneral.Controls.Add(Me.grpQuickPrint)
        Me.tabExportGeneral.Controls.Add(Me.PictureBox8)
        Me.tabExportGeneral.Controls.Add(Me.PictureBox4)
        Me.tabExportGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabExportGeneral.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabExportGeneral.Name = "tabExportGeneral"
        Me.tabExportGeneral.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabExportGeneral.Size = New System.Drawing.Size(506, 312)
        Me.tabExportGeneral.TabIndex = 0
        Me.tabExportGeneral.Text = "Allgemein"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox12.Controls.Add(Me.Label20)
        Me.GroupBox12.Controls.Add(Me.chkPrintHiddenTextFlag)
        Me.GroupBox12.Controls.Add(Me.Label21)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(23, 186)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox12.Size = New System.Drawing.Size(478, 67)
        Me.GroupBox12.TabIndex = 6
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Ausgeblendeter Text"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(33, 47)
        Me.Label20.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "(Neustart notwendig)"
        '
        'chkPrintHiddenTextFlag
        '
        Me.chkPrintHiddenTextFlag.AutoSize = True
        Me.HelpProvider1.SetHelpNavigator(Me.chkPrintHiddenTextFlag, System.Windows.Forms.HelpNavigator.Topic)
        Me.chkPrintHiddenTextFlag.Location = New System.Drawing.Point(19, 33)
        Me.chkPrintHiddenTextFlag.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkPrintHiddenTextFlag.Name = "chkPrintHiddenTextFlag"
        Me.HelpProvider1.SetShowHelp(Me.chkPrintHiddenTextFlag, True)
        Me.chkPrintHiddenTextFlag.Size = New System.Drawing.Size(170, 17)
        Me.chkPrintHiddenTextFlag.TabIndex = 1
        Me.chkPrintHiddenTextFlag.Text = "ausgebl. Text Button anzeigen"
        Me.chkPrintHiddenTextFlag.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 14)
        Me.Label21.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(270, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Legt fest, ob ausgeblendeter Text gedruckt werden soll."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.chkPrintNoSolution)
        Me.GroupBox1.Controls.Add(Me.chkPrintSolution)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox1.Size = New System.Drawing.Size(476, 93)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Allgemein"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 23)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(449, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Checkbox dient nur als Standardwert. Entscheidend sind die Checkboxen im Ribbon L" &
    "KTools."
        '
        'chkPrintNoSolution
        '
        Me.chkPrintNoSolution.AutoSize = True
        Me.chkPrintNoSolution.BackColor = System.Drawing.SystemColors.Control
        Me.HelpProvider1.SetHelpString(Me.chkPrintNoSolution, "Legen Sie fest, ob ein PDF-Dokument mit ausgblendeten Lösungen erstellt werden so" &
        "ll.")
        Me.chkPrintNoSolution.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkPrintNoSolution.Location = New System.Drawing.Point(17, 69)
        Me.chkPrintNoSolution.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkPrintNoSolution.Name = "chkPrintNoSolution"
        Me.HelpProvider1.SetShowHelp(Me.chkPrintNoSolution, True)
        Me.chkPrintNoSolution.Size = New System.Drawing.Size(280, 17)
        Me.chkPrintNoSolution.TabIndex = 8
        Me.chkPrintNoSolution.Text = "ausgeblendete Lösung drucken (Neustart erforderlich)"
        Me.chkPrintNoSolution.UseVisualStyleBackColor = False
        '
        'chkPrintSolution
        '
        Me.chkPrintSolution.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkPrintSolution, "Legen Sie fest, ob ein Lösungs-PDF-Dokument erstellt werden soll.")
        Me.chkPrintSolution.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkPrintSolution.Location = New System.Drawing.Point(17, 47)
        Me.chkPrintSolution.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkPrintSolution.Name = "chkPrintSolution"
        Me.HelpProvider1.SetShowHelp(Me.chkPrintSolution, True)
        Me.chkPrintSolution.Size = New System.Drawing.Size(277, 17)
        Me.chkPrintSolution.TabIndex = 7
        Me.chkPrintSolution.Text = "eingeblendete Lösung drucken (Neustart erforderlich)"
        Me.chkPrintSolution.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.CheckBox1)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(23, 107)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox7.Size = New System.Drawing.Size(478, 67)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Schnelldruck"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "(Neustart notwendig)"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(19, 33)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(168, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Schnelldruck-Button anzeigen"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 14)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(384, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Ausgabe erfolgt auf dem Standarddrucker mit den Standard-Druckeinstellungen."
        '
        'grpQuickPrint
        '
        Me.grpQuickPrint.BackColor = System.Drawing.SystemColors.Control
        Me.grpQuickPrint.Controls.Add(Me.Label14)
        Me.grpQuickPrint.Controls.Add(Me.chkQuickPrint)
        Me.grpQuickPrint.Controls.Add(Me.Label8)
        Me.grpQuickPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.grpQuickPrint, "Sie können per Knopfdruck die Lösung bzw. die ausgeblendete Lösung an Ihrem Stand" &
        "arddrucker ausdrucken. Es werden die Standardeinstellungen Ihres Druckers verwen" &
        "det.")
        Me.grpQuickPrint.Location = New System.Drawing.Point(23, 107)
        Me.grpQuickPrint.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpQuickPrint.Name = "grpQuickPrint"
        Me.grpQuickPrint.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.grpQuickPrint, True)
        Me.grpQuickPrint.Size = New System.Drawing.Size(478, 67)
        Me.grpQuickPrint.TabIndex = 3
        Me.grpQuickPrint.TabStop = False
        Me.grpQuickPrint.Text = "Schnelldruck"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 47)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "(Neustart notwendig)"
        '
        'chkQuickPrint
        '
        Me.chkQuickPrint.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkQuickPrint, "Legen Sie fest, ob die Schaltfläche angezeigt werden soll.")
        Me.chkQuickPrint.Location = New System.Drawing.Point(19, 33)
        Me.chkQuickPrint.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkQuickPrint.Name = "chkQuickPrint"
        Me.HelpProvider1.SetShowHelp(Me.chkQuickPrint, True)
        Me.chkQuickPrint.Size = New System.Drawing.Size(168, 17)
        Me.chkQuickPrint.TabIndex = 1
        Me.chkQuickPrint.Text = "Schnelldruck-Button anzeigen"
        Me.chkQuickPrint.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 14)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(384, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Ausgabe erfolgt auf dem Standarddrucker mit den Standard-Druckeinstellungen."
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.LKTools.My.Resources.Resources.Print_11009
        Me.PictureBox8.Location = New System.Drawing.Point(9, 107)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 42
        Me.PictureBox8.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.LKTools.My.Resources.Resources.gear_32xLG
        Me.PictureBox4.Location = New System.Drawing.Point(11, 6)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 45
        Me.PictureBox4.TabStop = False
        '
        'tabExportPDF
        '
        Me.tabExportPDF.BackColor = System.Drawing.SystemColors.Control
        Me.tabExportPDF.Controls.Add(Me.GroupBox2)
        Me.tabExportPDF.Controls.Add(Me.grpAusgabeSettings)
        Me.tabExportPDF.Controls.Add(Me.PictureBox9)
        Me.tabExportPDF.Location = New System.Drawing.Point(4, 22)
        Me.tabExportPDF.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabExportPDF.Name = "tabExportPDF"
        Me.tabExportPDF.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabExportPDF.Size = New System.Drawing.Size(506, 316)
        Me.tabExportPDF.TabIndex = 1
        Me.tabExportPDF.Text = "PDF"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkOpenPDFFolder)
        Me.GroupBox2.Controls.Add(Me.chkExtendedPDFButton)
        Me.GroupBox2.Controls.Add(Me.grpPDFExportSolution)
        Me.GroupBox2.Controls.Add(Me.grpPDFExportNoSolution)
        Me.GroupBox2.Controls.Add(Me.chkPDFExportEqual)
        Me.GroupBox2.Controls.Add(Me.chkShowExtendedPDFSettings)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 150)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox2.Size = New System.Drawing.Size(475, 160)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Erweiterte PDF Export Einstellungen"
        '
        'chkOpenPDFFolder
        '
        Me.chkOpenPDFFolder.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkOpenPDFFolder, "Legen Sie fest, ob der Ausgabe-Ordner nach der Erstellung geöffnet werden soll.")
        Me.chkOpenPDFFolder.Location = New System.Drawing.Point(24, 65)
        Me.chkOpenPDFFolder.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkOpenPDFFolder.Name = "chkOpenPDFFolder"
        Me.HelpProvider1.SetShowHelp(Me.chkOpenPDFFolder, True)
        Me.chkOpenPDFFolder.Size = New System.Drawing.Size(209, 17)
        Me.chkOpenPDFFolder.TabIndex = 49
        Me.chkOpenPDFFolder.Text = "Ausgabe-Ordner nach Export anzeigen"
        Me.chkOpenPDFFolder.UseVisualStyleBackColor = True
        '
        'chkExtendedPDFButton
        '
        Me.chkExtendedPDFButton.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkExtendedPDFButton, resources.GetString("chkExtendedPDFButton.HelpString"))
        Me.chkExtendedPDFButton.Location = New System.Drawing.Point(24, 20)
        Me.chkExtendedPDFButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkExtendedPDFButton.Name = "chkExtendedPDFButton"
        Me.HelpProvider1.SetShowHelp(Me.chkExtendedPDFButton, True)
        Me.chkExtendedPDFButton.Size = New System.Drawing.Size(327, 17)
        Me.chkExtendedPDFButton.TabIndex = 48
        Me.chkExtendedPDFButton.Text = "Checkbox ""Erw. PDF Ausgabe"" anzeigen (Neustart erforderlich)"
        Me.chkExtendedPDFButton.UseVisualStyleBackColor = True
        '
        'grpPDFExportSolution
        '
        Me.grpPDFExportSolution.Controls.Add(Me.chkMarkupsSolution)
        Me.grpPDFExportSolution.Location = New System.Drawing.Point(37, 109)
        Me.grpPDFExportSolution.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpPDFExportSolution.Name = "grpPDFExportSolution"
        Me.grpPDFExportSolution.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpPDFExportSolution.Size = New System.Drawing.Size(150, 48)
        Me.grpPDFExportSolution.TabIndex = 45
        Me.grpPDFExportSolution.TabStop = False
        Me.grpPDFExportSolution.Text = "Mit Lösung"
        '
        'chkMarkupsSolution
        '
        Me.chkMarkupsSolution.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkMarkupsSolution, "Legen Sie fest, ob die Lösung Kommentare enthalten soll.")
        Me.chkMarkupsSolution.Location = New System.Drawing.Point(11, 22)
        Me.chkMarkupsSolution.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkMarkupsSolution.Name = "chkMarkupsSolution"
        Me.HelpProvider1.SetShowHelp(Me.chkMarkupsSolution, True)
        Me.chkMarkupsSolution.Size = New System.Drawing.Size(127, 17)
        Me.chkMarkupsSolution.TabIndex = 2
        Me.chkMarkupsSolution.Text = "Kommentare drucken"
        Me.chkMarkupsSolution.UseVisualStyleBackColor = True
        '
        'grpPDFExportNoSolution
        '
        Me.grpPDFExportNoSolution.Controls.Add(Me.chkMarkupsNoSolution)
        Me.grpPDFExportNoSolution.Location = New System.Drawing.Point(207, 109)
        Me.grpPDFExportNoSolution.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpPDFExportNoSolution.Name = "grpPDFExportNoSolution"
        Me.grpPDFExportNoSolution.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpPDFExportNoSolution.Size = New System.Drawing.Size(150, 48)
        Me.grpPDFExportNoSolution.TabIndex = 46
        Me.grpPDFExportNoSolution.TabStop = False
        Me.grpPDFExportNoSolution.Text = "Ohne Lösung"
        '
        'chkMarkupsNoSolution
        '
        Me.chkMarkupsNoSolution.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkMarkupsNoSolution, "Legen Sie fest, ob die ""Ohne Lösung"" Kommentare enthalten soll.")
        Me.chkMarkupsNoSolution.Location = New System.Drawing.Point(11, 22)
        Me.chkMarkupsNoSolution.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkMarkupsNoSolution.Name = "chkMarkupsNoSolution"
        Me.HelpProvider1.SetShowHelp(Me.chkMarkupsNoSolution, True)
        Me.chkMarkupsNoSolution.Size = New System.Drawing.Size(127, 17)
        Me.chkMarkupsNoSolution.TabIndex = 2
        Me.chkMarkupsNoSolution.Text = "Kommentare drucken"
        Me.chkMarkupsNoSolution.UseVisualStyleBackColor = True
        '
        'chkPDFExportEqual
        '
        Me.chkPDFExportEqual.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkPDFExportEqual, "Legen Sie fest, ob die Einstellungen für ""Lösung"" und ""Ohne Lösung"" identisch sei" &
        "n sollen.")
        Me.chkPDFExportEqual.Location = New System.Drawing.Point(24, 87)
        Me.chkPDFExportEqual.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkPDFExportEqual.Name = "chkPDFExportEqual"
        Me.HelpProvider1.SetShowHelp(Me.chkPDFExportEqual, True)
        Me.chkPDFExportEqual.Size = New System.Drawing.Size(345, 17)
        Me.chkPDFExportEqual.TabIndex = 44
        Me.chkPDFExportEqual.Text = "Gleiche Einstellungen für ""Lösung"" und ""Ohne Lösung"" verwenden"
        Me.chkPDFExportEqual.UseVisualStyleBackColor = True
        '
        'chkShowExtendedPDFSettings
        '
        Me.chkShowExtendedPDFSettings.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkShowExtendedPDFSettings, "Klicken Sie, falls Sie immer die erweiterten PDF Ausgabe Einstellungen öffnen möc" &
        "hten.")
        Me.chkShowExtendedPDFSettings.Location = New System.Drawing.Point(24, 43)
        Me.chkShowExtendedPDFSettings.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkShowExtendedPDFSettings.Name = "chkShowExtendedPDFSettings"
        Me.HelpProvider1.SetShowHelp(Me.chkShowExtendedPDFSettings, True)
        Me.chkShowExtendedPDFSettings.Size = New System.Drawing.Size(199, 17)
        Me.chkShowExtendedPDFSettings.TabIndex = 47
        Me.chkShowExtendedPDFSettings.Text = "Erweiterte Einstellung immer aufrufen"
        Me.chkShowExtendedPDFSettings.UseVisualStyleBackColor = True
        '
        'grpAusgabeSettings
        '
        Me.grpAusgabeSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpAusgabeSettings.BackColor = System.Drawing.SystemColors.Control
        Me.grpAusgabeSettings.Controls.Add(Me.grpPosition)
        Me.grpAusgabeSettings.Controls.Add(Me.txtpdfSubFolderText)
        Me.grpAusgabeSettings.Controls.Add(Me.lblPDFSubfolder)
        Me.grpAusgabeSettings.Controls.Add(Me.radPDFSubfolder)
        Me.grpAusgabeSettings.Controls.Add(Me.radPDFPath)
        Me.grpAusgabeSettings.Controls.Add(Me.radPDFSameFolder)
        Me.grpAusgabeSettings.Controls.Add(Me.txtpdfPathText)
        Me.grpAusgabeSettings.Controls.Add(Me.btnSavePath)
        Me.grpAusgabeSettings.Controls.Add(Me.Label7)
        Me.grpAusgabeSettings.Controls.Add(Me.Label6)
        Me.grpAusgabeSettings.Controls.Add(Me.lblPDFSolutionText)
        Me.grpAusgabeSettings.Controls.Add(Me.txtPDFSolutionText)
        Me.grpAusgabeSettings.Controls.Add(Me.lblPDFNoSolutionText)
        Me.grpAusgabeSettings.Controls.Add(Me.txtPDFNoSolutionText)
        Me.HelpProvider1.SetHelpString(Me.grpAusgabeSettings, "Sie können per Knopfdruck ein oder zwei PDFs erstellen. Voraussetzung ist, dass d" &
        "as Dokument zuvor gespeichert wurde. Die PDFs werden im selben Ordner wie das Wo" &
        "rd Dokument gespeichert.")
        Me.grpAusgabeSettings.Location = New System.Drawing.Point(23, 10)
        Me.grpAusgabeSettings.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpAusgabeSettings.Name = "grpAusgabeSettings"
        Me.grpAusgabeSettings.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.grpAusgabeSettings, True)
        Me.grpAusgabeSettings.Size = New System.Drawing.Size(476, 138)
        Me.grpAusgabeSettings.TabIndex = 49
        Me.grpAusgabeSettings.TabStop = False
        Me.grpAusgabeSettings.Text = "PDFs erstellen"
        '
        'grpPosition
        '
        Me.grpPosition.Controls.Add(Me.radDescriptionSuffix)
        Me.grpPosition.Controls.Add(Me.radDescriptionPrefix)
        Me.grpPosition.Location = New System.Drawing.Point(120, 83)
        Me.grpPosition.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpPosition.Name = "grpPosition"
        Me.grpPosition.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpPosition.Size = New System.Drawing.Size(67, 53)
        Me.grpPosition.TabIndex = 40
        Me.grpPosition.TabStop = False
        Me.grpPosition.Text = "Position"
        '
        'radDescriptionSuffix
        '
        Me.radDescriptionSuffix.AccessibleName = ""
        Me.radDescriptionSuffix.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radDescriptionSuffix, "Ist dieses Feld aktiv, dann wird die eingetragene Bezeichnung nach dem Dateinamen" &
        " geschrieben.")
        Me.radDescriptionSuffix.Location = New System.Drawing.Point(10, 33)
        Me.radDescriptionSuffix.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radDescriptionSuffix.Name = "radDescriptionSuffix"
        Me.HelpProvider1.SetShowHelp(Me.radDescriptionSuffix, True)
        Me.radDescriptionSuffix.Size = New System.Drawing.Size(51, 17)
        Me.radDescriptionSuffix.TabIndex = 42
        Me.radDescriptionSuffix.TabStop = True
        Me.radDescriptionSuffix.Text = "Suffix"
        Me.radDescriptionSuffix.UseVisualStyleBackColor = True
        '
        'radDescriptionPrefix
        '
        Me.radDescriptionPrefix.AccessibleName = ""
        Me.radDescriptionPrefix.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radDescriptionPrefix, "Ist dieses Feld aktiv, dann wird die eingetragene Bezeichnung vor dem Dateinamen " &
        "geschrieben.")
        Me.radDescriptionPrefix.Location = New System.Drawing.Point(10, 15)
        Me.radDescriptionPrefix.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radDescriptionPrefix.Name = "radDescriptionPrefix"
        Me.HelpProvider1.SetShowHelp(Me.radDescriptionPrefix, True)
        Me.radDescriptionPrefix.Size = New System.Drawing.Size(51, 17)
        Me.radDescriptionPrefix.TabIndex = 41
        Me.radDescriptionPrefix.TabStop = True
        Me.radDescriptionPrefix.Text = "Präfix"
        Me.radDescriptionPrefix.UseVisualStyleBackColor = True
        '
        'txtpdfSubFolderText
        '
        Me.txtpdfSubFolderText.AcceptsTab = True
        Me.HelpProvider1.SetHelpString(Me.txtpdfSubFolderText, "Die Bezeichnung des Unterordners.")
        Me.txtpdfSubFolderText.Location = New System.Drawing.Point(266, 41)
        Me.txtpdfSubFolderText.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtpdfSubFolderText.MaxLength = 40
        Me.txtpdfSubFolderText.Name = "txtpdfSubFolderText"
        Me.HelpProvider1.SetShowHelp(Me.txtpdfSubFolderText, True)
        Me.txtpdfSubFolderText.Size = New System.Drawing.Size(158, 20)
        Me.txtpdfSubFolderText.TabIndex = 39
        '
        'lblPDFSubfolder
        '
        Me.lblPDFSubfolder.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblPDFSubfolder, "Die Bezeichnung wird dem PDF mit ausgeblendeter Lösung angehängt. ")
        Me.lblPDFSubfolder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPDFSubfolder.Location = New System.Drawing.Point(117, 42)
        Me.lblPDFSubfolder.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPDFSubfolder.Name = "lblPDFSubfolder"
        Me.HelpProvider1.SetShowHelp(Me.lblPDFSubfolder, True)
        Me.lblPDFSubfolder.Size = New System.Drawing.Size(131, 13)
        Me.lblPDFSubfolder.TabIndex = 38
        Me.lblPDFSubfolder.Text = "Bezeichnung Unterordner:"
        '
        'radPDFSubfolder
        '
        Me.radPDFSubfolder.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radPDFSubfolder, "Klicken Sie hier, falls die PDFs in einem Unterordner des Datei Speicherorts gesp" &
        "eichert werden sollen.")
        Me.radPDFSubfolder.Location = New System.Drawing.Point(16, 41)
        Me.radPDFSubfolder.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radPDFSubfolder.Name = "radPDFSubfolder"
        Me.HelpProvider1.SetShowHelp(Me.radPDFSubfolder, True)
        Me.radPDFSubfolder.Size = New System.Drawing.Size(81, 17)
        Me.radPDFSubfolder.TabIndex = 36
        Me.radPDFSubfolder.TabStop = True
        Me.radPDFSubfolder.Text = "Unterordner"
        Me.radPDFSubfolder.UseVisualStyleBackColor = True
        '
        'radPDFPath
        '
        Me.radPDFPath.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radPDFPath, "Klicken Sie hier, falls die PDFs in einem bestimmten Verzeichnis (z. B. Wechselda" &
        "tenträger) gespeichert werden sollen.")
        Me.radPDFPath.Location = New System.Drawing.Point(16, 61)
        Me.radPDFPath.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radPDFPath.Name = "radPDFPath"
        Me.HelpProvider1.SetShowHelp(Me.radPDFPath, True)
        Me.radPDFPath.Size = New System.Drawing.Size(47, 17)
        Me.radPDFPath.TabIndex = 37
        Me.radPDFPath.TabStop = True
        Me.radPDFPath.Text = "Pfad"
        Me.radPDFPath.UseVisualStyleBackColor = True
        '
        'radPDFSameFolder
        '
        Me.radPDFSameFolder.AutoSize = True
        Me.radPDFSameFolder.Checked = True
        Me.HelpProvider1.SetHelpString(Me.radPDFSameFolder, "Klicken Sie hier, falls die PDFs im gleichen Ordner wie die Datei erstellt werden" &
        " sollen.")
        Me.radPDFSameFolder.Location = New System.Drawing.Point(16, 19)
        Me.radPDFSameFolder.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radPDFSameFolder.Name = "radPDFSameFolder"
        Me.HelpProvider1.SetShowHelp(Me.radPDFSameFolder, True)
        Me.radPDFSameFolder.Size = New System.Drawing.Size(99, 17)
        Me.radPDFSameFolder.TabIndex = 35
        Me.radPDFSameFolder.TabStop = True
        Me.radPDFSameFolder.Text = "Gleicher Ordner"
        Me.radPDFSameFolder.UseVisualStyleBackColor = True
        '
        'txtpdfPathText
        '
        Me.HelpProvider1.SetHelpString(Me.txtpdfPathText, "Legen Sie Hier den Pfadnamen manuell fest oder klicken Sie auf das Ordner Symbol." &
        "")
        Me.txtpdfPathText.Location = New System.Drawing.Point(120, 61)
        Me.txtpdfPathText.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtpdfPathText.Name = "txtpdfPathText"
        Me.HelpProvider1.SetShowHelp(Me.txtpdfPathText, True)
        Me.txtpdfPathText.Size = New System.Drawing.Size(304, 20)
        Me.txtpdfPathText.TabIndex = 33
        '
        'btnSavePath
        '
        Me.btnSavePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSavePath.FlatAppearance.BorderSize = 0
        Me.btnSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePath.Image = Global.LKTools.My.Resources.Resources.folder_Closed_32xLG
        Me.btnSavePath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSavePath.Location = New System.Drawing.Point(426, 61)
        Me.btnSavePath.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnSavePath.Name = "btnSavePath"
        Me.btnSavePath.Size = New System.Drawing.Size(29, 17)
        Me.btnSavePath.TabIndex = 32
        Me.btnSavePath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSavePath.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(424, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = ".pdf"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(424, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = ".pdf"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPDFSolutionText
        '
        Me.lblPDFSolutionText.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblPDFSolutionText, "Die Bezeichnung wird dem Lösungs-PDF angehängt. ")
        Me.lblPDFSolutionText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPDFSolutionText.Location = New System.Drawing.Point(190, 93)
        Me.lblPDFSolutionText.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPDFSolutionText.Name = "lblPDFSolutionText"
        Me.HelpProvider1.SetShowHelp(Me.lblPDFSolutionText, True)
        Me.lblPDFSolutionText.Size = New System.Drawing.Size(110, 13)
        Me.lblPDFSolutionText.TabIndex = 26
        Me.lblPDFSolutionText.Text = "Bezeichnung Lösung:"
        '
        'txtPDFSolutionText
        '
        Me.txtPDFSolutionText.AcceptsTab = True
        Me.HelpProvider1.SetHelpString(Me.txtPDFSolutionText, "Die Bezeichnung wird dem Lösungs-PDF angehängt. ")
        Me.txtPDFSolutionText.Location = New System.Drawing.Point(330, 90)
        Me.txtPDFSolutionText.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtPDFSolutionText.MaxLength = 40
        Me.txtPDFSolutionText.Name = "txtPDFSolutionText"
        Me.HelpProvider1.SetShowHelp(Me.txtPDFSolutionText, True)
        Me.txtPDFSolutionText.Size = New System.Drawing.Size(94, 20)
        Me.txtPDFSolutionText.TabIndex = 9
        '
        'lblPDFNoSolutionText
        '
        Me.lblPDFNoSolutionText.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblPDFNoSolutionText, "Die Bezeichnung wird dem PDF mit ausgeblendeter Lösung angehängt. ")
        Me.lblPDFNoSolutionText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPDFNoSolutionText.Location = New System.Drawing.Point(190, 114)
        Me.lblPDFNoSolutionText.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPDFNoSolutionText.Name = "lblPDFNoSolutionText"
        Me.HelpProvider1.SetShowHelp(Me.lblPDFNoSolutionText, True)
        Me.lblPDFNoSolutionText.Size = New System.Drawing.Size(137, 13)
        Me.lblPDFNoSolutionText.TabIndex = 24
        Me.lblPDFNoSolutionText.Text = "Bezeichnung ohne Lösung:"
        '
        'txtPDFNoSolutionText
        '
        Me.txtPDFNoSolutionText.AcceptsTab = True
        Me.HelpProvider1.SetHelpString(Me.txtPDFNoSolutionText, "Die Bezeichnung wird dem PDF mit ausgeblendeter Lösung angehängt. ")
        Me.txtPDFNoSolutionText.Location = New System.Drawing.Point(330, 112)
        Me.txtPDFNoSolutionText.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtPDFNoSolutionText.MaxLength = 40
        Me.txtPDFNoSolutionText.Name = "txtPDFNoSolutionText"
        Me.HelpProvider1.SetShowHelp(Me.txtPDFNoSolutionText, True)
        Me.txtPDFNoSolutionText.Size = New System.Drawing.Size(94, 20)
        Me.txtPDFNoSolutionText.TabIndex = 10
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.LKTools.My.Resources.Resources.PrintDocumentControl_697
        Me.PictureBox9.Location = New System.Drawing.Point(8, 10)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 50
        Me.PictureBox9.TabStop = False
        '
        'tabUpdate
        '
        Me.tabUpdate.AutoScroll = True
        Me.tabUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.tabUpdate.Controls.Add(Me.btnChangeLog)
        Me.tabUpdate.Controls.Add(Me.PictureBox14)
        Me.tabUpdate.Controls.Add(Me.radUpdateDaily)
        Me.tabUpdate.Controls.Add(Me.btnUpdate)
        Me.tabUpdate.Controls.Add(Me.radUpdate30)
        Me.tabUpdate.Controls.Add(Me.radUpdate14)
        Me.tabUpdate.Controls.Add(Me.radUpdateNever)
        Me.tabUpdate.Controls.Add(Me.Label15)
        Me.HelpProvider1.SetHelpString(Me.tabUpdate, "Legen Sie fest, ob LKTools nach Updates suchen soll. (Internetverbindung notwendi" &
        "g)")
        Me.tabUpdate.Location = New System.Drawing.Point(4, 22)
        Me.tabUpdate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabUpdate.Name = "tabUpdate"
        Me.tabUpdate.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.tabUpdate, False)
        Me.tabUpdate.Size = New System.Drawing.Size(516, 340)
        Me.tabUpdate.TabIndex = 3
        Me.tabUpdate.Text = "Update"
        Me.tabUpdate.ToolTipText = "Aktualisierungsinformation"
        '
        'btnChangeLog
        '
        Me.btnChangeLog.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnChangeLog, "Klicken Sie hier, um manuell zu prüfen, ob ein Update vorliegt.")
        Me.btnChangeLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnChangeLog.Location = New System.Drawing.Point(32, 143)
        Me.btnChangeLog.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnChangeLog.Name = "btnChangeLog"
        Me.HelpProvider1.SetShowHelp(Me.btnChangeLog, True)
        Me.btnChangeLog.Size = New System.Drawing.Size(119, 22)
        Me.btnChangeLog.TabIndex = 47
        Me.btnChangeLog.Text = "Änderungsprotokoll"
        Me.btnChangeLog.UseVisualStyleBackColor = True
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Image = Global.LKTools.My.Resources.Resources.Synchronize_16xLG
        Me.PictureBox14.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox14.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 46
        Me.PictureBox14.TabStop = False
        '
        'radUpdateDaily
        '
        Me.radUpdateDaily.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radUpdateDaily, "Legen Sie fest, ob und wie oft LKTools beim Start von MS Word nach Updates suchen" &
        " soll. ")
        Me.radUpdateDaily.Location = New System.Drawing.Point(32, 52)
        Me.radUpdateDaily.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radUpdateDaily.Name = "radUpdateDaily"
        Me.HelpProvider1.SetShowHelp(Me.radUpdateDaily, True)
        Me.radUpdateDaily.Size = New System.Drawing.Size(56, 17)
        Me.radUpdateDaily.TabIndex = 2
        Me.radUpdateDaily.TabStop = True
        Me.radUpdateDaily.Text = "täglich"
        Me.radUpdateDaily.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnUpdate, "Klicken Sie hier, um manuell zu prüfen, ob ein Update vorliegt.")
        Me.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnUpdate.Location = New System.Drawing.Point(32, 112)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.HelpProvider1.SetShowHelp(Me.btnUpdate, True)
        Me.btnUpdate.Size = New System.Drawing.Size(119, 22)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'radUpdate30
        '
        Me.radUpdate30.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radUpdate30, "Legen Sie fest, ob und wie oft LKTools beim Start von MS Word nach Updates suchen" &
        " soll. ")
        Me.radUpdate30.Location = New System.Drawing.Point(32, 89)
        Me.radUpdate30.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radUpdate30.Name = "radUpdate30"
        Me.HelpProvider1.SetShowHelp(Me.radUpdate30, True)
        Me.radUpdate30.Size = New System.Drawing.Size(65, 17)
        Me.radUpdate30.TabIndex = 4
        Me.radUpdate30.TabStop = True
        Me.radUpdate30.Text = "30 Tage"
        Me.radUpdate30.UseVisualStyleBackColor = True
        '
        'radUpdate14
        '
        Me.radUpdate14.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radUpdate14, "Legen Sie fest, ob und wie oft LKTools beim Start von MS Word nach Updates suchen" &
        " soll. ")
        Me.radUpdate14.Location = New System.Drawing.Point(32, 71)
        Me.radUpdate14.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radUpdate14.Name = "radUpdate14"
        Me.HelpProvider1.SetShowHelp(Me.radUpdate14, True)
        Me.radUpdate14.Size = New System.Drawing.Size(65, 17)
        Me.radUpdate14.TabIndex = 3
        Me.radUpdate14.TabStop = True
        Me.radUpdate14.Text = "14 Tage"
        Me.radUpdate14.UseVisualStyleBackColor = True
        '
        'radUpdateNever
        '
        Me.radUpdateNever.AutoSize = True
        Me.radUpdateNever.Checked = True
        Me.HelpProvider1.SetHelpString(Me.radUpdateNever, "Legen Sie fest, ob und wie oft LKTools beim Start von MS Word nach Updates suchen" &
        " soll. ")
        Me.radUpdateNever.Location = New System.Drawing.Point(32, 33)
        Me.radUpdateNever.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radUpdateNever.Name = "radUpdateNever"
        Me.HelpProvider1.SetShowHelp(Me.radUpdateNever, True)
        Me.radUpdateNever.Size = New System.Drawing.Size(41, 17)
        Me.radUpdateNever.TabIndex = 1
        Me.radUpdateNever.TabStop = True
        Me.radUpdateNever.Text = "Nie"
        Me.radUpdateNever.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 9)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(297, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Legen Sie fest, ob Sie über Updates informiert werden wollen."
        '
        'tabAboutMe
        '
        Me.tabAboutMe.AutoScroll = True
        Me.tabAboutMe.BackColor = System.Drawing.SystemColors.Control
        Me.tabAboutMe.Controls.Add(Me.txtDatenschutz)
        Me.tabAboutMe.Controls.Add(Me.Label9)
        Me.tabAboutMe.Controls.Add(Me.Label18)
        Me.tabAboutMe.Controls.Add(Me.txtInfo)
        Me.tabAboutMe.Controls.Add(Me.LinkLabel1)
        Me.tabAboutMe.Controls.Add(Me.Label2)
        Me.tabAboutMe.Controls.Add(Me.lblKontakt)
        Me.tabAboutMe.Controls.Add(Me.lblWebPage)
        Me.tabAboutMe.Controls.Add(Me.lblEMail)
        Me.tabAboutMe.Controls.Add(Me.LabelVersion)
        Me.tabAboutMe.Controls.Add(Me.LabelCopyright)
        Me.tabAboutMe.Controls.Add(Me.LabelProductName)
        Me.HelpProvider1.SetHelpString(Me.tabAboutMe, "Informationen über LKTools.")
        Me.tabAboutMe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tabAboutMe.Location = New System.Drawing.Point(4, 22)
        Me.tabAboutMe.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tabAboutMe.Name = "tabAboutMe"
        Me.tabAboutMe.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.HelpProvider1.SetShowHelp(Me.tabAboutMe, False)
        Me.tabAboutMe.Size = New System.Drawing.Size(516, 340)
        Me.tabAboutMe.TabIndex = 1
        Me.tabAboutMe.Text = "Über LKTools"
        Me.tabAboutMe.ToolTipText = "Informationen über LKTools"
        '
        'txtDatenschutz
        '
        Me.txtDatenschutz.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDatenschutz.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtDatenschutz.Location = New System.Drawing.Point(21, 306)
        Me.txtDatenschutz.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtDatenschutz.Multiline = True
        Me.txtDatenschutz.Name = "txtDatenschutz"
        Me.txtDatenschutz.ReadOnly = True
        Me.txtDatenschutz.Size = New System.Drawing.Size(484, 33)
        Me.txtDatenschutz.TabIndex = 21
        Me.txtDatenschutz.Text = "Seitens LKTools werden keine personenbezogenen Daten erfasst, ausgewertet oder we" &
    "itergegeben. Auf der sourceforge Webseite wird die Anzahl der Downloads mit Land" &
    " und Betriebssystem ausgewertet."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(19, 291)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Datenschutz:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(19, 200)
        Me.Label18.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Sonstiges:"
        '
        'txtInfo
        '
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtInfo.Location = New System.Drawing.Point(20, 215)
        Me.txtInfo.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(388, 75)
        Me.txtInfo.TabIndex = 18
        Me.txtInfo.Text = "Hier steht der Text"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.LinkLabel1, "Klicken Sie hier, um auf Dokumentation von LKTools zu öffnen.")
        Me.LinkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabel1.Location = New System.Drawing.Point(19, 171)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.HelpProvider1.SetShowHelp(Me.LinkLabel1, True)
        Me.LinkLabel1.Size = New System.Drawing.Size(188, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "sourceforge.net/p/lktools/wiki/Home/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(19, 155)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Dokumentation:"
        '
        'lblKontakt
        '
        Me.lblKontakt.AutoSize = True
        Me.lblKontakt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblKontakt.Location = New System.Drawing.Point(19, 84)
        Me.lblKontakt.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblKontakt.Name = "lblKontakt"
        Me.lblKontakt.Size = New System.Drawing.Size(47, 13)
        Me.lblKontakt.TabIndex = 15
        Me.lblKontakt.Text = "Kontakt:"
        '
        'lblWebPage
        '
        Me.lblWebPage.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblWebPage, "Klicken Sie hier, um auf die Webseite von LKTools zu gelangen.")
        Me.lblWebPage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWebPage.Location = New System.Drawing.Point(19, 122)
        Me.lblWebPage.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblWebPage.Name = "lblWebPage"
        Me.HelpProvider1.SetShowHelp(Me.lblWebPage, True)
        Me.lblWebPage.Size = New System.Drawing.Size(114, 13)
        Me.lblWebPage.TabIndex = 14
        Me.lblWebPage.TabStop = True
        Me.lblWebPage.Text = "lktools.sourceforge.net"
        '
        'lblEMail
        '
        Me.lblEMail.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblEMail, "Klicken Sie hier, um LKTools eine E-Mail zu schreiben.")
        Me.lblEMail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEMail.Location = New System.Drawing.Point(19, 103)
        Me.lblEMail.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblEMail.Name = "lblEMail"
        Me.HelpProvider1.SetShowHelp(Me.lblEMail, True)
        Me.lblEMail.Size = New System.Drawing.Size(126, 13)
        Me.lblEMail.TabIndex = 13
        Me.lblEMail.TabStop = True
        Me.lblEMail.Text = "software@info-rommel.de"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.LabelVersion, "Die aktuelle Version von LKTools.")
        Me.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelVersion.Location = New System.Drawing.Point(19, 31)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LabelVersion.Name = "LabelVersion"
        Me.HelpProvider1.SetShowHelp(Me.LabelVersion, True)
        Me.LabelVersion.Size = New System.Drawing.Size(68, 13)
        Me.LabelVersion.TabIndex = 12
        Me.LabelVersion.Text = "LabelVersion"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCopyright.Location = New System.Drawing.Point(19, 52)
        Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(77, 13)
        Me.LabelCopyright.TabIndex = 11
        Me.LabelCopyright.Text = "LabelCopyright"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.LabelProductName, "Die Bezeichnung der Software.")
        Me.LabelProductName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelProductName.Location = New System.Drawing.Point(19, 9)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LabelProductName.Name = "LabelProductName"
        Me.HelpProvider1.SetShowHelp(Me.LabelProductName, True)
        Me.LabelProductName.Size = New System.Drawing.Size(98, 13)
        Me.LabelProductName.TabIndex = 9
        Me.LabelProductName.Text = "LabelProductName"
        '
        'btnDefaultSettings
        '
        Me.btnDefaultSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnDefaultSettings, "Setzen Sie alle Werte zurück.")
        Me.btnDefaultSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDefaultSettings.Location = New System.Drawing.Point(15, 391)
        Me.btnDefaultSettings.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnDefaultSettings.Name = "btnDefaultSettings"
        Me.HelpProvider1.SetShowHelp(Me.btnDefaultSettings, True)
        Me.btnDefaultSettings.Size = New System.Drawing.Size(86, 22)
        Me.btnDefaultSettings.TabIndex = 7
        Me.btnDefaultSettings.TabStop = False
        Me.btnDefaultSettings.Text = "Standard"
        Me.btnDefaultSettings.UseVisualStyleBackColor = True
        '
        'lblErrorText
        '
        Me.lblErrorText.AutoSize = True
        Me.lblErrorText.ForeColor = System.Drawing.Color.Red
        Me.HelpProvider1.SetHelpString(Me.lblErrorText, "Hier werden Fehlermeldungen angezeigt, falls die Einstellungen nicht korrekt sind" &
        ".")
        Me.lblErrorText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblErrorText.Location = New System.Drawing.Point(108, 391)
        Me.lblErrorText.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblErrorText.Name = "lblErrorText"
        Me.HelpProvider1.SetShowHelp(Me.lblErrorText, True)
        Me.lblErrorText.Size = New System.Drawing.Size(60, 13)
        Me.lblErrorText.TabIndex = 24
        Me.lblErrorText.Text = "lblErrorText"
        Me.lblErrorText.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "https://sourceforge.net/p/lktools/wiki/V.0.3.0/"
        '
        'btnOKSettings
        '
        Me.btnOKSettings.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.HelpProvider1.SetHelpString(Me.btnOKSettings, "Klicken Sie hier, um die Einstellungen zu übernehmen.")
        Me.btnOKSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOKSettings.Location = New System.Drawing.Point(364, 391)
        Me.btnOKSettings.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnOKSettings.Name = "btnOKSettings"
        Me.HelpProvider1.SetShowHelp(Me.btnOKSettings, True)
        Me.btnOKSettings.Size = New System.Drawing.Size(76, 22)
        Me.btnOKSettings.TabIndex = 20
        Me.btnOKSettings.Text = "OK"
        Me.btnOKSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOKSettings.UseVisualStyleBackColor = True
        '
        'btnCancelSettings
        '
        Me.btnCancelSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnCancelSettings, "Ihre Änderungen werden nicht übernommen.")
        Me.btnCancelSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelSettings.Location = New System.Drawing.Point(449, 391)
        Me.btnCancelSettings.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnCancelSettings.Name = "btnCancelSettings"
        Me.HelpProvider1.SetShowHelp(Me.btnCancelSettings, True)
        Me.btnCancelSettings.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelSettings.TabIndex = 21
        Me.btnCancelSettings.Text = "Abbrechen"
        Me.btnCancelSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelSettings.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnOKSettings
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CancelButton = Me.btnCancelSettings
        Me.ClientSize = New System.Drawing.Size(547, 442)
        Me.Controls.Add(Me.lblErrorText)
        Me.Controls.Add(Me.btnCancelSettings)
        Me.Controls.Add(Me.btnOKSettings)
        Me.Controls.Add(LKTabs)
        Me.Controls.Add(Me.btnDefaultSettings)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LKTools Einstellungen"
        LKTabs.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpAllgemein.ResumeLayout(False)
        Me.grpAllgemein.PerformLayout()
        Me.tabObjects.ResumeLayout(False)
        Me.tabObjects.PerformLayout()
        Me.tabInsert.ResumeLayout(False)
        Me.tabTemplates.ResumeLayout(False)
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.grpkarierteVorlage.ResumeLayout(False)
        Me.grpkarierteVorlage.PerformLayout()
        Me.grpLinierteVorlage.ResumeLayout(False)
        Me.grpLinierteVorlage.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.tabExcercises.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMC.ResumeLayout(False)
        Me.grpMC.PerformLayout()
        Me.grpTrueFalse.ResumeLayout(False)
        Me.grpTrueFalse.PerformLayout()
        Me.grpLoesungshinweis.ResumeLayout(False)
        Me.grpLoesungshinweis.PerformLayout()
        Me.tabGrades.ResumeLayout(False)
        Me.tabGrades.PerformLayout()
        Me.grpNotenbereich.ResumeLayout(False)
        Me.grpNotenbereich.PerformLayout()
        Me.grpAusgabe.ResumeLayout(False)
        Me.grpAusgabe.PerformLayout()
        Me.grpIHKStandard.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GradeGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPath.ResumeLayout(False)
        Me.grpPath.ResumeLayout(False)
        Me.grpPath.PerformLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPresentation.ResumeLayout(False)
        Me.tabPresentation.PerformLayout()
        Me.tabExport.ResumeLayout(False)
        Me.tabExportDetail.ResumeLayout(False)
        Me.tabExportGeneral.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.grpQuickPrint.ResumeLayout(False)
        Me.grpQuickPrint.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabExportPDF.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpPDFExportSolution.ResumeLayout(False)
        Me.grpPDFExportSolution.PerformLayout()
        Me.grpPDFExportNoSolution.ResumeLayout(False)
        Me.grpPDFExportNoSolution.PerformLayout()
        Me.grpAusgabeSettings.ResumeLayout(False)
        Me.grpAusgabeSettings.PerformLayout()
        Me.grpPosition.ResumeLayout(False)
        Me.grpPosition.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUpdate.ResumeLayout(False)
        Me.tabUpdate.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAboutMe.ResumeLayout(False)
        Me.tabAboutMe.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelSettings As System.Windows.Forms.Button
    Friend WithEvents btnOKSettings As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents btnDefaultSettings As System.Windows.Forms.Button
    Friend WithEvents lblErrorText As System.Windows.Forms.Label
    Friend WithEvents tabAboutMe As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblKontakt As System.Windows.Forms.Label
    Friend WithEvents lblWebPage As System.Windows.Forms.LinkLabel
    Friend WithEvents lblEMail As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents tabUpdate As System.Windows.Forms.TabPage
    Friend WithEvents radUpdateDaily As System.Windows.Forms.RadioButton
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents radUpdate30 As System.Windows.Forms.RadioButton
    Friend WithEvents radUpdate14 As System.Windows.Forms.RadioButton
    Friend WithEvents radUpdateNever As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tabExport As System.Windows.Forms.TabPage
    Friend WithEvents grpQuickPrint As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkQuickPrint As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkPrintNoSolution As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrintSolution As System.Windows.Forms.CheckBox
    Friend WithEvents tabObjects As System.Windows.Forms.TabPage
    Friend WithEvents tabInsert As System.Windows.Forms.TabControl
    Friend WithEvents tabTemplates As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents chkExamButton As System.Windows.Forms.CheckBox
    Friend WithEvents grpkarierteVorlage As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents chkGraphButton As System.Windows.Forms.CheckBox
    Friend WithEvents lblGraphRows As System.Windows.Forms.Label
    Friend WithEvents txtGraphRows As System.Windows.Forms.TextBox
    Friend WithEvents txtGraphWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblGraphWidth As System.Windows.Forms.Label
    Friend WithEvents grpLinierteVorlage As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents radRuledStyleWidth100 As System.Windows.Forms.RadioButton
    Friend WithEvents radRuledStyleWidth50 As System.Windows.Forms.RadioButton
    Friend WithEvents radRuledStyleWidth75 As System.Windows.Forms.RadioButton
    Friend WithEvents chkRuledButton As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRuledSpacing As System.Windows.Forms.TextBox
    Friend WithEvents lblRuledSpacing As System.Windows.Forms.Label
    Friend WithEvents lblRuledRows As System.Windows.Forms.Label
    Friend WithEvents txtRuledRows As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents chkExcerciseButton As System.Windows.Forms.CheckBox
    Friend WithEvents tabExcercises As System.Windows.Forms.TabPage
    Friend WithEvents grpMC As System.Windows.Forms.GroupBox
    Friend WithEvents chkMCAllignRight As System.Windows.Forms.CheckBox
    Friend WithEvents chkMCButton As System.Windows.Forms.CheckBox
    Friend WithEvents lblMCRows As System.Windows.Forms.Label
    Friend WithEvents txtMCRows As System.Windows.Forms.TextBox
    Friend WithEvents grpTrueFalse As System.Windows.Forms.GroupBox
    Friend WithEvents lblTrueFalseReasonDesc As System.Windows.Forms.Label
    Friend WithEvents chkTrueFalseButton As System.Windows.Forms.CheckBox
    Friend WithEvents txtTrueFalseReasonDesc As System.Windows.Forms.TextBox
    Friend WithEvents chkTrueFalseReason As System.Windows.Forms.CheckBox
    Friend WithEvents lblTrueFalseFalseDesc As System.Windows.Forms.Label
    Friend WithEvents txtTrueFalseFalseDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblTrueFalseTrueDesc As System.Windows.Forms.Label
    Friend WithEvents txtTrueFalseTrueDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblTrueFalseRows As System.Windows.Forms.Label
    Friend WithEvents txtTrueFalseRows As System.Windows.Forms.TextBox
    Friend WithEvents grpLoesungshinweis As System.Windows.Forms.GroupBox
    Friend WithEvents chkAddSolution As System.Windows.Forms.CheckBox
    Friend WithEvents lblSolutionDescription As System.Windows.Forms.Label
    Friend WithEvents txtSolutionDescription As System.Windows.Forms.TextBox
    Friend WithEvents tabGrades As System.Windows.Forms.TabPage
    Friend WithEvents grpNotenbereich As System.Windows.Forms.GroupBox
    Friend WithEvents txtGrade5 As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade1 As System.Windows.Forms.Label
    Friend WithEvents lblGrade2 As System.Windows.Forms.Label
    Friend WithEvents lblGrade3 As System.Windows.Forms.Label
    Friend WithEvents txtGrade4 As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade4 As System.Windows.Forms.Label
    Friend WithEvents txtGrade3 As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade5 As System.Windows.Forms.Label
    Friend WithEvents txtGrade2 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtGrade1 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents grpAusgabe As System.Windows.Forms.GroupBox
    Friend WithEvents chkNoRounding As System.Windows.Forms.CheckBox
    Friend WithEvents chk05Rounding As System.Windows.Forms.CheckBox
    Friend WithEvents grpIHKStandard As System.Windows.Forms.GroupBox
    Friend WithEvents btnGradeDefault2 As System.Windows.Forms.Button
    Friend WithEvents btnGradeDefault5 As System.Windows.Forms.Button
    Friend WithEvents btnGradeDefault1 As System.Windows.Forms.Button
    Friend WithEvents btnGradeDefault3 As System.Windows.Forms.Button
    Friend WithEvents btnGradeDefault4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGradelinear As System.Windows.Forms.Button
    Friend WithEvents btnGradehart As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GradeGraph As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents tabSettings As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInformAboutHiddenObjectsTime As System.Windows.Forms.TextBox
    Friend WithEvents lblInformAboutHiddenObjectsTime As System.Windows.Forms.Label
    Friend WithEvents chkInformAboutHiddenObjects As System.Windows.Forms.CheckBox
    Friend WithEvents grpAllgemein As System.Windows.Forms.GroupBox
    Friend WithEvents chkUnderline As System.Windows.Forms.CheckBox
    Friend WithEvents btnObjectTextColorDefault As System.Windows.Forms.Button
    Friend WithEvents lblObjectTextColorExample As System.Windows.Forms.Label
    Friend WithEvents btnObjectTextColor As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnColorHiddenDefault As System.Windows.Forms.Button
    Friend WithEvents btnColorVisibleDefault As System.Windows.Forms.Button
    Friend WithEvents chkLines As System.Windows.Forms.CheckBox
    Friend WithEvents chkShapes As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHiddenColorExample As System.Windows.Forms.Label
    Friend WithEvents btnColorVisible As System.Windows.Forms.Button
    Friend WithEvents btnColorHidden As System.Windows.Forms.Button
    Friend WithEvents lblVisbleColorExample As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents chkGradeButton As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRedTextbox As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnChangeLog As System.Windows.Forms.Button
    Friend WithEvents tabExportDetail As System.Windows.Forms.TabControl
    Friend WithEvents tabExportGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabExportPDF As System.Windows.Forms.TabPage
    Friend WithEvents chkPDFExportEqual As System.Windows.Forms.CheckBox
    Friend WithEvents grpPDFExportNoSolution As System.Windows.Forms.GroupBox
    Friend WithEvents chkMarkupsNoSolution As System.Windows.Forms.CheckBox
    Friend WithEvents grpPDFExportSolution As System.Windows.Forms.GroupBox
    Friend WithEvents chkMarkupsSolution As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowExtendedPDFSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkExtendedPDFButton As System.Windows.Forms.CheckBox
    Friend WithEvents grpAusgabeSettings As System.Windows.Forms.GroupBox
    Friend WithEvents txtpdfSubFolderText As System.Windows.Forms.TextBox
    Friend WithEvents lblPDFSubfolder As System.Windows.Forms.Label
    Friend WithEvents radPDFSubfolder As System.Windows.Forms.RadioButton
    Friend WithEvents radPDFPath As System.Windows.Forms.RadioButton
    Friend WithEvents radPDFSameFolder As System.Windows.Forms.RadioButton
    Friend WithEvents txtpdfPathText As System.Windows.Forms.TextBox
    Friend WithEvents btnSavePath As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPDFSolutionText As System.Windows.Forms.Label
    Friend WithEvents txtPDFSolutionText As System.Windows.Forms.TextBox
    Friend WithEvents lblPDFNoSolutionText As System.Windows.Forms.Label
    Friend WithEvents txtPDFNoSolutionText As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkOpenPDFFolder As System.Windows.Forms.CheckBox
    Friend WithEvents tabPath As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents grpPath As System.Windows.Forms.GroupBox
    Friend WithEvents txtPathNumberFolders As System.Windows.Forms.TextBox
    Friend WithEvents lblPathNumberFolders As System.Windows.Forms.Label
    Friend WithEvents radRelPath As System.Windows.Forms.RadioButton
    Friend WithEvents radFullPath As System.Windows.Forms.RadioButton
    Friend WithEvents chkPathButton As System.Windows.Forms.CheckBox
    Friend WithEvents chkPathAddDocumentName As System.Windows.Forms.CheckBox
    Friend WithEvents radNoPath As System.Windows.Forms.RadioButton
    Friend WithEvents txtDatenschutz As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRevisionPage As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents chkRevisionPrint As System.Windows.Forms.CheckBox
    Friend WithEvents grpPosition As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents radStyleDash As System.Windows.Forms.RadioButton
    Friend WithEvents radStyleDot As System.Windows.Forms.RadioButton
    Friend WithEvents radStyleLine As System.Windows.Forms.RadioButton
    Friend WithEvents radDescriptionPrefix As System.Windows.Forms.RadioButton
    Friend WithEvents radDescriptionSuffix As System.Windows.Forms.RadioButton
    Friend WithEvents tabPresentation As System.Windows.Forms.TabPage
    Friend WithEvents btnOverlayDefault As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnColorOverlay As System.Windows.Forms.Button
    Friend WithEvents lblOverlayExample As System.Windows.Forms.Label
    Friend WithEvents chkShowOverlayFunction As System.Windows.Forms.CheckBox
    Friend WithEvents lblOverlayTransparency As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtOverlayTransparency As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chkPrintHiddenTextFlag As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
