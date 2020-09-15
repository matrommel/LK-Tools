Partial Class LKTool
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase


    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Erforderlich für die Unterstützung des Windows.Forms-Klassenkompositions-Designers
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'Dieser Aufruf ist für den Komponenten-Designer erforderlich.
        InitializeComponent()

    End Sub

    'Die Komponente überschreibt den Löschvorgang zum Bereinigen der Komponentenliste.
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

    'Wird vom Komponenten-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Komponenten-Designer erforderlich.
    'Das Bearbeiten ist mit dem Komponenten-Designer möglich.
    'Nehmen Sie keine Änderungen mit dem Code-Editor vor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.TabLKT = Me.Factory.CreateRibbonTab
        Me.grpState = Me.Factory.CreateRibbonGroup
        Me.grpObjekte = Me.Factory.CreateRibbonGroup
        Me.grpOverlayFunction = Me.Factory.CreateRibbonGroup
        Me.grpEinfuegen = Me.Factory.CreateRibbonGroup
        Me.Separator2 = Me.Factory.CreateRibbonSeparator
        Me.txtRows = Me.Factory.CreateRibbonEditBox
        Me.grpSchriftart = Me.Factory.CreateRibbonGroup
        Me.grpAusgabe = Me.Factory.CreateRibbonGroup
        Me.Separator3 = Me.Factory.CreateRibbonSeparator
        Me.chkSolution = Me.Factory.CreateRibbonCheckBox
        Me.chkNoSolution = Me.Factory.CreateRibbonCheckBox
        Me.chkPDFRevision = Me.Factory.CreateRibbonCheckBox
        Me.chkPrintHiddenText = Me.Factory.CreateRibbonCheckBox
        Me.grpInfo = Me.Factory.CreateRibbonGroup
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tglBtnCheck = Me.Factory.CreateRibbonToggleButton
        Me.btnShow = Me.Factory.CreateRibbonButton
        Me.btnHide = Me.Factory.CreateRibbonButton
        Me.btnOverlay = Me.Factory.CreateRibbonButton
        Me.btnShowOverlay = Me.Factory.CreateRibbonButton
        Me.btnHideOverlay = Me.Factory.CreateRibbonButton
        Me.btnHideOverlaySelection = Me.Factory.CreateRibbonButton
        Me.tglOverlayTransparency = Me.Factory.CreateRibbonToggleButton
        Me.tglPresentation = Me.Factory.CreateRibbonToggleButton
        Me.btnGrade = Me.Factory.CreateRibbonButton
        Me.btnRedTextbox = Me.Factory.CreateRibbonButton
        Me.btnGraphTemplate = Me.Factory.CreateRibbonButton
        Me.btnRuledTemplate = Me.Factory.CreateRibbonButton
        Me.btnExcercise = Me.Factory.CreateRibbonButton
        Me.btnExam = Me.Factory.CreateRibbonButton
        Me.btnMC = Me.Factory.CreateRibbonButton
        Me.btnTrueFalse = Me.Factory.CreateRibbonButton
        Me.btnFolderPath = Me.Factory.CreateRibbonButton
        Me.btnRevisionPage = Me.Factory.CreateRibbonButton
        Me.btnColoringBlack = Me.Factory.CreateRibbonButton
        Me.btnColoringText = Me.Factory.CreateRibbonButton
        Me.btnGetTextColor = Me.Factory.CreateRibbonButton
        Me.btnPDF = Me.Factory.CreateRibbonButton
        Me.btnExtendedPDF = Me.Factory.CreateRibbonButton
        Me.btnQuickPrint = Me.Factory.CreateRibbonButton
        Me.btnSettings = Me.Factory.CreateRibbonButton
        Me.TabLKT.SuspendLayout()
        Me.grpState.SuspendLayout()
        Me.grpObjekte.SuspendLayout()
        Me.grpOverlayFunction.SuspendLayout()
        Me.grpEinfuegen.SuspendLayout()
        Me.grpSchriftart.SuspendLayout()
        Me.grpAusgabe.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.FullOpen = True
        Me.ColorDialog1.ShowHelp = True
        '
        'ColorDialog2
        '
        Me.ColorDialog2.AnyColor = True
        Me.ColorDialog2.FullOpen = True
        Me.ColorDialog2.ShowHelp = True
        '
        'TabLKT
        '
        Me.TabLKT.Groups.Add(Me.grpState)
        Me.TabLKT.Groups.Add(Me.grpObjekte)
        Me.TabLKT.Groups.Add(Me.grpOverlayFunction)
        Me.TabLKT.Groups.Add(Me.grpEinfuegen)
        Me.TabLKT.Groups.Add(Me.grpSchriftart)
        Me.TabLKT.Groups.Add(Me.grpAusgabe)
        Me.TabLKT.Groups.Add(Me.grpInfo)
        Me.TabLKT.KeyTip = "<"
        Me.TabLKT.Label = "LKTools"
        Me.TabLKT.Name = "TabLKT"
        '
        'grpState
        '
        Me.grpState.Items.Add(Me.tglBtnCheck)
        Me.grpState.Label = "Status"
        Me.grpState.Name = "grpState"
        '
        'grpObjekte
        '
        Me.grpObjekte.Items.Add(Me.btnShow)
        Me.grpObjekte.Items.Add(Me.btnHide)
        Me.grpObjekte.KeyTip = "L"
        Me.grpObjekte.Label = "Lösung"
        Me.grpObjekte.Name = "grpObjekte"
        '
        'grpOverlayFunction
        '
        Me.grpOverlayFunction.Items.Add(Me.btnOverlay)
        Me.grpOverlayFunction.Items.Add(Me.btnShowOverlay)
        Me.grpOverlayFunction.Items.Add(Me.btnHideOverlay)
        Me.grpOverlayFunction.Items.Add(Me.btnHideOverlaySelection)
        Me.grpOverlayFunction.Items.Add(Me.tglOverlayTransparency)
        Me.grpOverlayFunction.Items.Add(Me.tglPresentation)
        Me.grpOverlayFunction.Label = "Präsentation"
        Me.grpOverlayFunction.Name = "grpOverlayFunction"
        '
        'grpEinfuegen
        '
        Me.grpEinfuegen.Items.Add(Me.btnGrade)
        Me.grpEinfuegen.Items.Add(Me.btnRedTextbox)
        Me.grpEinfuegen.Items.Add(Me.Separator2)
        Me.grpEinfuegen.Items.Add(Me.btnGraphTemplate)
        Me.grpEinfuegen.Items.Add(Me.btnRuledTemplate)
        Me.grpEinfuegen.Items.Add(Me.txtRows)
        Me.grpEinfuegen.Items.Add(Me.btnExcercise)
        Me.grpEinfuegen.Items.Add(Me.btnExam)
        Me.grpEinfuegen.Items.Add(Me.btnMC)
        Me.grpEinfuegen.Items.Add(Me.btnTrueFalse)
        Me.grpEinfuegen.Items.Add(Me.btnFolderPath)
        Me.grpEinfuegen.Items.Add(Me.btnRevisionPage)
        Me.grpEinfuegen.KeyTip = "O"
        Me.grpEinfuegen.Label = "Objekte"
        Me.grpEinfuegen.Name = "grpEinfuegen"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        '
        'txtRows
        '
        Me.txtRows.KeyTip = "5"
        Me.txtRows.Label = "Zeilen:"
        Me.txtRows.MaxLength = 2
        Me.txtRows.Name = "txtRows"
        Me.txtRows.ScreenTip = "Anzahl Zeilen"
        Me.txtRows.ShowImage = True
        Me.txtRows.SizeString = "300"
        Me.txtRows.SuperTip = "Tragen Sie die Anzahl der Zeilen ein, die das eingefügte Objekt (MC, Linierte Vor" &
    "lage etc.) haben soll. Falls kein Wert eingetragen ist, wird der Wert aus den ""E" &
    "instellungen"" verwendet. "
        Me.txtRows.Text = Nothing
        '
        'grpSchriftart
        '
        Me.grpSchriftart.Items.Add(Me.btnColoringBlack)
        Me.grpSchriftart.Items.Add(Me.btnColoringText)
        Me.grpSchriftart.Items.Add(Me.btnGetTextColor)
        Me.grpSchriftart.KeyTip = "S"
        Me.grpSchriftart.Label = "Schriftfarbe"
        Me.grpSchriftart.Name = "grpSchriftart"
        '
        'grpAusgabe
        '
        Me.grpAusgabe.Items.Add(Me.btnPDF)
        Me.grpAusgabe.Items.Add(Me.btnExtendedPDF)
        Me.grpAusgabe.Items.Add(Me.btnQuickPrint)
        Me.grpAusgabe.Items.Add(Me.Separator3)
        Me.grpAusgabe.Items.Add(Me.chkSolution)
        Me.grpAusgabe.Items.Add(Me.chkNoSolution)
        Me.grpAusgabe.Items.Add(Me.chkPDFRevision)
        Me.grpAusgabe.Items.Add(Me.chkPrintHiddenText)
        Me.grpAusgabe.KeyTip = "A"
        Me.grpAusgabe.Label = "Ausgabe"
        Me.grpAusgabe.Name = "grpAusgabe"
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        '
        'chkSolution
        '
        Me.chkSolution.Label = "Lösung"
        Me.chkSolution.Name = "chkSolution"
        Me.chkSolution.ScreenTip = "Lösung drucken"
        Me.chkSolution.SuperTip = "Setzen Sie diese Checkbox, um beim PDF oder Schnelldruck eine Lösung zu drucken."
        '
        'chkNoSolution
        '
        Me.chkNoSolution.Label = "Ohne Lösung"
        Me.chkNoSolution.Name = "chkNoSolution"
        Me.chkNoSolution.ScreenTip = "Ohne Lösung drucken"
        Me.chkNoSolution.SuperTip = "Setzen Sie diese Checkbox, um beim PDF oder Schnelldruck ein Dokument mit ausgebl" &
    "endeter Lösung zu drucken."
        '
        'chkPDFRevision
        '
        Me.chkPDFRevision.Label = "Revision"
        Me.chkPDFRevision.Name = "chkPDFRevision"
        Me.chkPDFRevision.ScreenTip = "Revision drucken?"
        Me.chkPDFRevision.SuperTip = "Entfernen Sie den Haken, damit die erste Seite (Revisionstabelle) nicht mehr im P" &
    "DF Export vorhanden ist."
        '
        'chkPrintHiddenText
        '
        Me.chkPrintHiddenText.Label = "ausgebl. Text"
        Me.chkPrintHiddenText.Name = "chkPrintHiddenText"
        Me.chkPrintHiddenText.ScreenTip = "ausgeblendeter Text drucken"
        Me.chkPrintHiddenText.SuperTip = "Wenn aktiv, dann wird ausgeblendeter Text gedruckt"
        Me.chkPrintHiddenText.Visible = False
        '
        'grpInfo
        '
        Me.grpInfo.Items.Add(Me.btnSettings)
        Me.grpInfo.KeyTip = "E"
        Me.grpInfo.Label = "Einstellungen"
        Me.grpInfo.Name = "grpInfo"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'tglBtnCheck
        '
        Me.tglBtnCheck.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.tglBtnCheck.Enabled = False
        Me.tglBtnCheck.Image = Global.LKTools.My.Resources.Resources.StatusAnnotations_Warning_32xLG_color
        Me.tglBtnCheck.Label = " "
        Me.tglBtnCheck.Name = "tglBtnCheck"
        Me.tglBtnCheck.ScreenTip = "Status"
        Me.tglBtnCheck.ShowImage = True
        Me.tglBtnCheck.SuperTip = "Aktiv, wenn Inhalte ausgeblendet sind. Achtung: Funktioniert nur, solange nur ein" &
    " Dokument geöffnet ist."
        '
        'btnShow
        '
        Me.btnShow.Image = Global.LKTools.My.Resources.Resources.eye_16xLG
        Me.btnShow.KeyTip = "E"
        Me.btnShow.Label = "Einblenden"
        Me.btnShow.Name = "btnShow"
        Me.btnShow.ScreenTip = "Einblenden"
        Me.btnShow.ShowImage = True
        Me.btnShow.SuperTip = "Einblenden von ausgeblendeten Texten und/oder Objekten."
        '
        'btnHide
        '
        Me.btnHide.Image = Global.LKTools.My.Resources.Resources.Virtual_32xLG
        Me.btnHide.KeyTip = "A"
        Me.btnHide.Label = "Ausblenden"
        Me.btnHide.Name = "btnHide"
        Me.btnHide.ScreenTip = "Ausblenden"
        Me.btnHide.ShowImage = True
        Me.btnHide.SuperTip = "Ausblenden von Texten und/oder Objekten in der festgelegten Farbe."
        '
        'btnOverlay
        '
        Me.btnOverlay.Image = Global.LKTools.My.Resources.Resources.Overlay
        Me.btnOverlay.KeyTip = "Ü"
        Me.btnOverlay.Label = "Objekt einfügen"
        Me.btnOverlay.Name = "btnOverlay"
        Me.btnOverlay.ScreenTip = "Überlagerung einfügen"
        Me.btnOverlay.ShowImage = True
        Me.btnOverlay.SuperTip = "Fügen Sie eine schwebendes Rechteck ein. Diese wird später ausgeblendet und kann " &
    "dafür genutzt werden Lösungen nach einander einzublenden."
        '
        'btnShowOverlay
        '
        Me.btnShowOverlay.Image = Global.LKTools.My.Resources.Resources.eye_16xLG
        Me.btnShowOverlay.KeyTip = "ÜE"
        Me.btnShowOverlay.Label = "Alle einblenden"
        Me.btnShowOverlay.Name = "btnShowOverlay"
        Me.btnShowOverlay.ScreenTip = "Alle Überlagerungen einblenden"
        Me.btnShowOverlay.ShowImage = True
        Me.btnShowOverlay.SuperTip = "Blenden Sie alle Überlagerungen ein."
        '
        'btnHideOverlay
        '
        Me.btnHideOverlay.Image = Global.LKTools.My.Resources.Resources.Virtual_32xLG
        Me.btnHideOverlay.KeyTip = "ÜA"
        Me.btnHideOverlay.Label = "Alle ausblenden"
        Me.btnHideOverlay.Name = "btnHideOverlay"
        Me.btnHideOverlay.ScreenTip = "Alle Überlagerung ausblenden"
        Me.btnHideOverlay.ShowImage = True
        Me.btnHideOverlay.SuperTip = "Blenden Sie alle Überlagerungen aus."
        '
        'btnHideOverlaySelection
        '
        Me.btnHideOverlaySelection.Image = Global.LKTools.My.Resources.Resources.Virtual_32xLG_2
        Me.btnHideOverlaySelection.KeyTip = "<"
        Me.btnHideOverlaySelection.Label = "Objekt ausblenden"
        Me.btnHideOverlaySelection.Name = "btnHideOverlaySelection"
        Me.btnHideOverlaySelection.ScreenTip = "Ausgewählte Überlagerung ausblenden"
        Me.btnHideOverlaySelection.ShowImage = True
        Me.btnHideOverlaySelection.SuperTip = "Blendet die ausgewählte Überlagerung aus"
        '
        'tglOverlayTransparency
        '
        Me.tglOverlayTransparency.Image = Global.LKTools.My.Resources.Resources.Overlay_Transparenz2
        Me.tglOverlayTransparency.Label = "Transparenz"
        Me.tglOverlayTransparency.Name = "tglOverlayTransparency"
        Me.tglOverlayTransparency.ScreenTip = "Aktiviert / deaktiviert Transparenz"
        Me.tglOverlayTransparency.ShowImage = True
        Me.tglOverlayTransparency.SuperTip = "Aktivieren bzw. deaktiiveren Sie die Transparenz der Überlagerungen."
        '
        'tglPresentation
        '
        Me.tglPresentation.Description = "Aktiviert/Deaktiviert die Rechtschreib und Grammatikprüfung und blendet die Absat" &
    "zmarke ein bzw. aus."
        Me.tglPresentation.Image = Global.LKTools.My.Resources.Resources.Monitor_Screen_32xLG
        Me.tglPresentation.Label = "Präsentation"
        Me.tglPresentation.Name = "tglPresentation"
        Me.tglPresentation.ScreenTip = "Präsentationsmodus"
        Me.tglPresentation.ShowImage = True
        Me.tglPresentation.SuperTip = "Aktiviert/Deaktiviert die Rechtschreib und Grammatikprüfung und blendet die Absat" &
    "zmarke ein bzw. aus."
        '
        'btnGrade
        '
        Me.btnGrade.Image = Global.LKTools.My.Resources.Resources.AddForm_369
        Me.btnGrade.KeyTip = "1"
        Me.btnGrade.Label = "Noten"
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.ScreenTip = "Notenskala"
        Me.btnGrade.ShowImage = True
        Me.btnGrade.SuperTip = "Fügen Sie eine Notenverteilung ein. Die Werte basieren auf den ""Einstellungen"" un" &
    "d können überschrieben werden."
        '
        'btnRedTextbox
        '
        Me.btnRedTextbox.Image = Global.LKTools.My.Resources.Resources.Textbox
        Me.btnRedTextbox.KeyTip = "2"
        Me.btnRedTextbox.Label = "Textbox"
        Me.btnRedTextbox.Name = "btnRedTextbox"
        Me.btnRedTextbox.ScreenTip = "Einfügen"
        Me.btnRedTextbox.ShowImage = True
        Me.btnRedTextbox.SuperTip = "Fügen Sie eine schwebende Textform ein. Diese wird später ausgeblendet."
        '
        'btnGraphTemplate
        '
        Me.btnGraphTemplate.Image = Global.LKTools.My.Resources.Resources.GraphTemplate
        Me.btnGraphTemplate.KeyTip = "3"
        Me.btnGraphTemplate.Label = "Kariert"
        Me.btnGraphTemplate.Name = "btnGraphTemplate"
        Me.btnGraphTemplate.ScreenTip = "Karierte Vorlage"
        Me.btnGraphTemplate.ShowImage = True
        Me.btnGraphTemplate.SuperTip = "Klicken Sie um ein kariertes Blatt einzufügen."
        '
        'btnRuledTemplate
        '
        Me.btnRuledTemplate.Image = Global.LKTools.My.Resources.Resources.RuledTemplate
        Me.btnRuledTemplate.KeyTip = "4"
        Me.btnRuledTemplate.Label = "Liniert"
        Me.btnRuledTemplate.Name = "btnRuledTemplate"
        Me.btnRuledTemplate.ScreenTip = "Linierte Vorlage"
        Me.btnRuledTemplate.ShowImage = True
        Me.btnRuledTemplate.SuperTip = "Klicken Sie um ein liniertes Blatt einzufügen."
        '
        'btnExcercise
        '
        Me.btnExcercise.Image = Global.LKTools.My.Resources.Resources.action_add_16xLG
        Me.btnExcercise.KeyTip = "6"
        Me.btnExcercise.Label = "Aufgabe"
        Me.btnExcercise.Name = "btnExcercise"
        Me.btnExcercise.ScreenTip = "Aufgabe-Vorlage"
        Me.btnExcercise.ShowImage = True
        Me.btnExcercise.SuperTip = "Fügen Sie eine Aufgabenvorlage ein. Diese besteht aus zwei Spalten und wird durch" &
    "nummeriert."
        '
        'btnExam
        '
        Me.btnExam.Image = Global.LKTools.My.Resources.Resources.Exam
        Me.btnExam.KeyTip = "7"
        Me.btnExam.Label = "P. Aufgabe"
        Me.btnExam.Name = "btnExam"
        Me.btnExam.ScreenTip = "Prüfungsaufgabe-Vorlage"
        Me.btnExam.ShowImage = True
        Me.btnExam.SuperTip = "Fügen Sie eine Prüfngsaufgaben-Vorlage ein. Diese besteht aus drei Spalten und wi" &
    "rd durchnummeriert. In der dritten Spalte können die vorgesehenen Punkte eingetr" &
    "agen werden."
        '
        'btnMC
        '
        Me.btnMC.Image = Global.LKTools.My.Resources.Resources.MC
        Me.btnMC.KeyTip = "8"
        Me.btnMC.Label = "MC"
        Me.btnMC.Name = "btnMC"
        Me.btnMC.ScreenTip = "MC (Multiple Choice) Aufgabe"
        Me.btnMC.ShowImage = True
        Me.btnMC.SuperTip = "Erstellen Sie eine Multiple Choice Aufgabe. "
        '
        'btnTrueFalse
        '
        Me.btnTrueFalse.Image = Global.LKTools.My.Resources.Resources.TrueFalse
        Me.btnTrueFalse.KeyTip = "9"
        Me.btnTrueFalse.Label = "Richtig/Falsch"
        Me.btnTrueFalse.Name = "btnTrueFalse"
        Me.btnTrueFalse.ScreenTip = "Richtig/Falsch Aufgabe"
        Me.btnTrueFalse.ShowImage = True
        Me.btnTrueFalse.SuperTip = "Erstellen Sie eine Richtig/Falsch Aufgabe. In den Einstellungen können Sie festle" &
    "gen, ob eine zusätzliche Begründungsspalte eingefügt werden soll."
        '
        'btnFolderPath
        '
        Me.btnFolderPath.Image = Global.LKTools.My.Resources.Resources.NavigationPath_6036
        Me.btnFolderPath.Label = "Pfad"
        Me.btnFolderPath.Name = "btnFolderPath"
        Me.btnFolderPath.ShowImage = True
        Me.btnFolderPath.SuperTip = "Fügen Sie eine Pfad Angabe ein."
        '
        'btnRevisionPage
        '
        Me.btnRevisionPage.Image = Global.LKTools.My.Resources.Resources.IntelliTrace
        Me.btnRevisionPage.Label = "Revision"
        Me.btnRevisionPage.Name = "btnRevisionPage"
        Me.btnRevisionPage.ScreenTip = "Revision einfügen"
        Me.btnRevisionPage.ShowImage = True
        Me.btnRevisionPage.SuperTip = "Fügen SIe eine Revisionsseite ein. Die Seite wird automatich an den Beginn eines " &
    "Dokumentes gehängt. Ist die Seite bereits vorhanden, dann wird die Tabelle erwei" &
    "tert."
        '
        'btnColoringBlack
        '
        Me.btnColoringBlack.Image = Global.LKTools.My.Resources.Resources.TextfarbeSchwarz
        Me.btnColoringBlack.KeyTip = "S"
        Me.btnColoringBlack.Label = "Schwarz"
        Me.btnColoringBlack.Name = "btnColoringBlack"
        Me.btnColoringBlack.ScreenTip = "Schwarz färben"
        Me.btnColoringBlack.ShowImage = True
        Me.btnColoringBlack.SuperTip = "Färbt markierten Text in schwarz."
        '
        'btnColoringText
        '
        Me.btnColoringText.Image = Global.LKTools.My.Resources.Resources.TextfarbeRot
        Me.btnColoringText.KeyTip = "F"
        Me.btnColoringText.Label = "Färben"
        Me.btnColoringText.Name = "btnColoringText"
        Me.btnColoringText.ScreenTip = "Färben"
        Me.btnColoringText.ShowImage = True
        Me.btnColoringText.SuperTip = "Färbt markierten Text in die ""Ausblend""-Farbe."
        '
        'btnGetTextColor
        '
        Me.btnGetTextColor.Image = Global.LKTools.My.Resources.Resources.ColorSelection
        Me.btnGetTextColor.KeyTip = "S"
        Me.btnGetTextColor.Label = "Auswählen"
        Me.btnGetTextColor.Name = "btnGetTextColor"
        Me.btnGetTextColor.ScreenTip = "Ausblendfarbe auswählen"
        Me.btnGetTextColor.ShowImage = True
        Me.btnGetTextColor.SuperTip = "Wählt die Farbe des markierten Textes aus."
        '
        'btnPDF
        '
        Me.btnPDF.Image = Global.LKTools.My.Resources.Resources.PrintDocumentControl_697
        Me.btnPDF.KeyTip = "P"
        Me.btnPDF.Label = "PDFs erstellen"
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.ScreenTip = "PDFs erstellen"
        Me.btnPDF.ShowImage = True
        Me.btnPDF.SuperTip = "Je nach Einstellungen, werden 2 PDF Dateien erstellt. Ein PDF mit ausgeblendeter " &
    "Lösung und ein PDF mit eingeblendeter Lösung. Der Ausgabeordner entspricht dem d" &
    "er Datei."
        '
        'btnExtendedPDF
        '
        Me.btnExtendedPDF.Image = Global.LKTools.My.Resources.Resources.PrintDocumentControl_697
        Me.btnExtendedPDF.Label = "erw. PDF Ausgabe"
        Me.btnExtendedPDF.Name = "btnExtendedPDF"
        Me.btnExtendedPDF.ScreenTip = "PDFs erstellen"
        Me.btnExtendedPDF.ShowImage = True
        Me.btnExtendedPDF.SuperTip = "Je nach Einstellungen, werden 2 PDF Dateien erstellt. Ein PDF mit ausgeblendeter " &
    "Lösung und ein PDF mit eingeblendeter Lösung. Der Ausgabeordner entspricht dem d" &
    "er Datei."
        '
        'btnQuickPrint
        '
        Me.btnQuickPrint.Image = Global.LKTools.My.Resources.Resources.Print_11009
        Me.btnQuickPrint.KeyTip = "Q"
        Me.btnQuickPrint.Label = "Schnelldruck"
        Me.btnQuickPrint.Name = "btnQuickPrint"
        Me.btnQuickPrint.ScreenTip = "Schnelldruck auf Standarddrucker"
        Me.btnQuickPrint.ShowImage = True
        Me.btnQuickPrint.SuperTip = "Drucken Sie, je nach Einstellung, ein Dokument mit ausgeblendeter Lösung und ein " &
    "Dokument mit eingeblendeter Lösung auf dem Standarddrucker aus."
        '
        'btnSettings
        '
        Me.btnSettings.Image = Global.LKTools.My.Resources.Resources.gear_32xLG
        Me.btnSettings.KeyTip = "X"
        Me.btnSettings.Label = "Einstellungen"
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.ScreenTip = "Einstellungen"
        Me.btnSettings.ShowImage = True
        Me.btnSettings.SuperTip = "Ändern Sie grundlegende Einstellungen von LKTools."
        '
        'LKTool
        '
        Me.Name = "LKTool"
        Me.RibbonType = "Microsoft.Word.Document"
        Me.Tabs.Add(Me.TabLKT)
        Me.TabLKT.ResumeLayout(False)
        Me.TabLKT.PerformLayout()
        Me.grpState.ResumeLayout(False)
        Me.grpState.PerformLayout()
        Me.grpObjekte.ResumeLayout(False)
        Me.grpObjekte.PerformLayout()
        Me.grpOverlayFunction.ResumeLayout(False)
        Me.grpOverlayFunction.PerformLayout()
        Me.grpEinfuegen.ResumeLayout(False)
        Me.grpEinfuegen.PerformLayout()
        Me.grpSchriftart.ResumeLayout(False)
        Me.grpSchriftart.PerformLayout()
        Me.grpAusgabe.ResumeLayout(False)
        Me.grpAusgabe.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkShapes As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents chkLines As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog2 As System.Windows.Forms.ColorDialog
    Friend WithEvents TabLKT As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents grpState As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents tglBtnCheck As Microsoft.Office.Tools.Ribbon.RibbonToggleButton
    Friend WithEvents grpObjekte As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnShow As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnHide As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpEinfuegen As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnGraphTemplate As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnRuledTemplate As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents txtRows As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents btnGrade As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnRedTextbox As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpSchriftart As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnColoringBlack As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnColoringText As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnGetTextColor As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpAusgabe As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnPDF As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnQuickPrint As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpInfo As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnSettings As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnExcercise As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnMC As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnTrueFalse As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnExam As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Separator3 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents Separator2 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Private WithEvents chkSolution As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Private WithEvents chkNoSolution As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents btnExtendedPDF As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnFolderPath As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents chkPrintHiddenText As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents btnRevisionPage As Tools.Ribbon.RibbonButton
    Private WithEvents chkPDFRevision As Tools.Ribbon.RibbonCheckBox
    Friend WithEvents btnOverlay As Tools.Ribbon.RibbonButton
    Friend WithEvents grpOverlayFunction As Tools.Ribbon.RibbonGroup
    Friend WithEvents btnShowOverlay As Tools.Ribbon.RibbonButton
    Friend WithEvents btnHideOverlay As Tools.Ribbon.RibbonButton
    Friend WithEvents btnHideOverlaySelection As Tools.Ribbon.RibbonButton
    Friend WithEvents tglOverlayTransparency As Tools.Ribbon.RibbonToggleButton
    Friend WithEvents tglPresentation As Tools.Ribbon.RibbonToggleButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As LKTool
        Get
            Return Me.GetRibbon(Of LKTool)()
        End Get
    End Property
End Class
