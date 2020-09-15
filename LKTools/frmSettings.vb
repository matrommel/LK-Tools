Imports MSXML2
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text.RegularExpressions 'Need for checking the strings

Public Class frmSettings

    Dim errorMsg As String = "" 'Value is overwritten afterwards
    Dim bgColor As Drawing.Color = Drawing.Color.Orange


    'Load frmSettings
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '## Allgemein
        lblVisbleColorExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ColorVisible)
        lblHiddenColorExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ColorHidden)
        lblObjectTextColorExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ObjectTextColor)
        chkShapes.Checked = LKTool.chkShape
        chkLines.Checked = LKTool.chkLine
        chkUnderline.Checked = LKTool.chkUnderline

        'Information
        chkInformAboutHiddenObjects.Checked = LKTool.InformAboutHiddenObjects
        txtInformAboutHiddenObjectsTime.Text = LKTool.InformAboutHiddenObjectsTime

        '## Objekte --> Vorlagen
        'Several Buttons in tab objects
        chkRedTextbox.Checked = LKTool.RedTextboxButton
        chkRevisionPage.Checked = LKTool.RevisionPageButton
        chkRevisionPrint.Checked = LKTool.chkRevisionPrint
        chkExcerciseButton.Checked = LKTool.ExcerciseButton
        chkExamButton.Checked = LKTool.ExamButton

        '#### Ruled Template
        chkRuledButton.Checked = LKTool.RuledButton
        txtRuledSpacing.Text = LKTool.RuledSpacing
        txtRuledRows.Text = LKTool.RuledRows
        '###### Ruled Style
        If LKTool.RuledStyle = 1 Then
            radStyleLine.Checked = True
        ElseIf LKTool.RuledStyle = 2 Then
            radStyleDot.Checked = True
        ElseIf LKTool.RuledStyle = 4 Then
            radStyleDash.Checked = True
        Else
            radStyleLine.Checked = True
        End If
        '###### Ruled Style Width
        If LKTool.RuledStyleWidth = 4 Then
            radRuledStyleWidth50.Checked = True
        ElseIf LKTool.RuledStyleWidth = 6 Then
            radRuledStyleWidth75.Checked = True
        ElseIf LKTool.RuledStyleWidth = 8 Then
            radRuledStyleWidth100.Checked = True
        Else
            radRuledStyleWidth50.Checked = True
        End If

        '#### Graph Template
        chkGraphButton.Checked = LKTool.GraphButton
        txtGraphRows.Text = LKTool.GraphRows
        txtGraphWidth.Text = LKTool.Graphwidth

        '## Objekte --> Aufgaben
        '#### MC Template
        chkMCButton.Checked = LKTool.MCButton
        txtMCRows.Text = LKTool.MCRows
        chkMCAllignRight.Checked = LKTool.chkMCAllignRight

        '#### True/False Template
        chkTrueFalseButton.Checked = LKTool.TrueFalseButton
        txtTrueFalseRows.Text = LKTool.TrueFalseRows
        txtTrueFalseTrueDesc.Text = LKTool.TrueFalseTrueDesc
        txtTrueFalseFalseDesc.Text = LKTool.TrueFalseFalseDesc
        chkTrueFalseReason.Checked = LKTool.TrueFalseReason
        txtTrueFalseReasonDesc.Text = LKTool.TrueFalseReasonDesc

        '#### Add Solution Template
        chkAddSolution.Checked = LKTool.AddSolution
        txtSolutionDescription.Text = LKTool.SolutionDescription

        '## Objekte --> Noten
        chkGradeButton.Checked = LKTool.GradeButton
        txtGrade1.Text = CStr(LKTool.grade(0))
        txtGrade2.Text = CStr(LKTool.grade(1))
        txtGrade3.Text = CStr(LKTool.grade(2))
        txtGrade4.Text = CStr(LKTool.grade(3))
        txtGrade5.Text = CStr(LKTool.grade(4))
        chk05Rounding.Checked = LKTool.Rounding05
        chkNoRounding.Checked = LKTool.NoRounding

        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If

        '## Objekte --> Pfad
        chkPathButton.Checked = LKTool.PathButton
        '###### Path Option
        If LKTool.PathOption = 1 Then
            radFullPath.Checked = True
        ElseIf LKTool.PathOption = 2 Then
            radRelPath.Checked = True
        ElseIf LKTool.PathOption = 3 Then
            radNoPath.Checked = True
        Else
            radFullPath.Checked = True
            LKTool.PathOption = 1
        End If
        txtPathNumberFolders.Text = LKTool.PathNumberFolders
        chkPathAddDocumentName.Checked = LKTool.PathAddDocumentName

        '## Objekte --> Präsentation
        chkShowOverlayFunction.Checked = LKTool.ShowOverlayFunction
        lblOverlayExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ColorOverlay)
        txtOverlayTransparency.Text = LKTool.OverlayTransparency

        '## Ausgabe
        '#### Allgemein
        chkQuickPrint.Checked = LKTool.QuickPrint
        chkPrintSolution.Checked = LKTool.PrintSolution
        chkPrintNoSolution.Checked = LKTool.PrintNoSolution
        chkPrintHiddenTextFlag.Checked = LKTool.chkPrintHiddenTextButton


        '#### PDF Ausgabe
        '###### PDF Export RadioButton
        If LKTool.pdfExportSettings = 1 Then
            radPDFSameFolder.Checked = True
        ElseIf LKTool.pdfExportSettings = 2 Then
            radPDFSubfolder.Checked = True
        ElseIf LKTool.pdfExportSettings = 3 Then
            radPDFPath.Checked = True
        Else
            radPDFSameFolder.Checked = True
            LKTool.pdfExportSettings = 1
        End If



        '###### Solution description prefix or suffix
        If LKTool.chkDescriptionPositionSuffix = True Then ' 1 = prefix
            radDescriptionSuffix.Checked = True
        ElseIf LKTool.chkDescriptionPositionSuffix = False Then ' 2 = suffix
            radDescriptionPrefix.Checked = True
        Else
            radDescriptionSuffix.Checked = True
        End If


        txtPDFSolutionText.Text = LKTool.pdfSolutionText
        txtPDFNoSolutionText.Text = LKTool.pdfNoSolutionText
        txtpdfSubFolderText.Text = LKTool.pdfSubFolderText
        txtpdfPathText.Text = LKTool.pdfPathText

        '###### PDF Erweiterte Ausgabe
        chkExtendedPDFButton.Checked = LKTool.ExtendedPDFButton
        chkShowExtendedPDFSettings.Checked = LKTool.ShowExtendedPDFSettings
        chkPDFExportEqual.Checked = LKTool.chkPDFExportEqual
        chkMarkupsSolution.Checked = LKTool.chkPDFMarkupsSolution
        chkMarkupsNoSolution.Checked = LKTool.chkPDFMarkupsNoSolution
        chkOpenPDFFolder.Checked = LKTool.chkOpenPDFFolder

        '## Update
        If LKTool.UpdateInterval = 14 Then
            radUpdate14.Checked = True
        ElseIf LKTool.UpdateInterval = 1 Then
            radUpdateDaily.Checked = True
        ElseIf LKTool.UpdateInterval = 99999 Then
            radUpdateNever.Checked = True
        Else
            radUpdate30.Checked = True
        End If

        'Über LKTools
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        txtInfo.Text = "Bitte teilen Sie mir mit, falls Sie Fehler finden oder Erweiterungswünsche haben. " &
            "Über konstruktives Feedback freue ich mich sehr. " & Environment.NewLine &
            Environment.NewLine &
            "- Matthias Rommel - "



    End Sub

    'Action for CANCEL Button (close without saving)
    Private Sub btnCancelSettings_Click(sender As Object, e As EventArgs) Handles btnCancelSettings.Click
        Me.Close()
    End Sub

    'Action for OK Button (save settings, validate the data)
    Public Sub btnOKSettings_Click(sender As Object, e As EventArgs) Handles btnOKSettings.Click
        Dim check As Boolean = False
        Dim lk As LKTool = New LKTool()
        Dim i As System.Windows.Forms.Control

        'Set background of textfield to white everytime the button is clicked
        txtGraphWidth.BackColor = Drawing.Color.White
        txtGraphRows.BackColor = Drawing.Color.White
        txtRuledRows.BackColor = Drawing.Color.White
        txtRuledSpacing.BackColor = Drawing.Color.White
        txtMCRows.BackColor = Drawing.Color.White
        txtTrueFalseRows.BackColor = Drawing.Color.White
        txtTrueFalseTrueDesc.BackColor = Drawing.Color.White
        txtTrueFalseFalseDesc.BackColor = Drawing.Color.White
        txtTrueFalseReasonDesc.BackColor = Drawing.Color.White
        txtSolutionDescription.BackColor = Drawing.Color.White
        txtInformAboutHiddenObjectsTime.BackColor = Drawing.Color.White
        For myTempCount = 1 To 5
            i = grpNotenbereich.Controls("txtGrade" & myTempCount)
            i.BackColor = Drawing.Color.White
        Next
        txtPathNumberFolders.BackColor = Drawing.Color.White
        txtPDFSolutionText.BackColor = Drawing.Color.White
        txtPDFNoSolutionText.BackColor = Drawing.Color.White
        txtpdfSubFolderText.BackColor = Drawing.Color.White
        txtpdfPathText.BackColor = Drawing.Color.White
        txtOverlayTransparency.BackColor = Drawing.Color.White

        'Check entries
        If Check_GraphRows() = False _
            Or Check_GraphWidth() = False _
            Or Check_RuledRows() = False _
            Or Check_RuledSpacing() = False _
            Or Check_SolutionDescription() = False _
            Or Check_InformAboutHiddenObjectsTime() = False _
            Or Check_Grades() = False _
            Or Check_RelPathNumberFolders() = False _
            Or Check_PDFSolution() = False _
            Or Check_PDFNoSolution() = False _
            Or Check_PDFSubfolder() = False _
            Or Check_PDFPath() = False _
            Or Check_PDFExport() = False _
            Or Check_MCRows() = False _
            Or Check_TrueFalseRows() = False _
            Or Check_OverlayTransparency() = False _
            Or Check_TrueFalseTrueDesc() = False _
            Or Check_TrueFalseFalseDesc() = False _
            Or Check_TrueFalseReasonDesc() = False _
            Then
            'Nothing
        Else
            UpdateVariables()
            UpdateXML()
            Me.Close()

        End If
    End Sub

    'Validate OverlayTransparency is filled correct
    Private Function Check_OverlayTransparency()
        Dim check As Boolean = False

        If IsNumeric(txtOverlayTransparency.Text) Then
            If CSng(txtOverlayTransparency.Text) >= 0.0 And CSng(txtOverlayTransparency.Text) <= 100 Then
                check = True
            Else
                check = False
                errorMsg = "Zahl in <" & lblOverlayTransparency.Text & "> muss zwischen 0 und 100 liegen."
            End If
        Else
            check = False
            errorMsg = "Zahl in <" & lblOverlayTransparency.Text & "> fehlt."
        End If

        'Error message if Transparency is no number or less then 1
        If check = False Then
            txtOverlayTransparency.Select()
            txtOverlayTransparency.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if graphWidth is filled correct
    Private Function Check_GraphWidth()
        Dim check As Boolean = False

        If IsNumeric(txtGraphWidth.Text) Then
            If CSng(txtGraphWidth.Text) > 0.38 Then
                check = True
            Else
                check = False
                errorMsg = "Zahl in <" & lblGraphWidth.Text & "> muss größer 0,38 cm sein."
            End If
        Else
            check = False
            errorMsg = "Zahl in <" & lblGraphWidth.Text & "> fehlt."
        End If

        'Error message if GraphWidth is no number or less then 0
        If check = False Then
            txtGraphWidth.Select()
            txtGraphWidth.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if GraphRows is filled correct
    Private Function Check_GraphRows()
        Dim check As Boolean = False

        If IsNumeric(txtGraphRows.Text) Then
            If CSng(txtGraphRows.Text) >= 1.0 Then
                check = True
            Else
                check = False
                errorMsg = "Zahl in <" & lblGraphRows.Text & "> muss größer 1 sein."
            End If
        Else
            check = False
            errorMsg = "Zahl in <" & lblGraphRows.Text & "> fehlt."
        End If

        'Error message if GraphRows is no number or less then 1
        If check = False Then
            txtGraphRows.Select()
            txtGraphRows.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if RuledSpacing is filled correct
    Private Function Check_RuledSpacing()
        Dim check As Boolean = False

        If IsNumeric(txtRuledSpacing.Text) Then
            If CSng(txtRuledSpacing.Text) > 0.38 Then
                check = True
            Else
                check = False
                errorMsg = "Zahl in <" & lblRuledSpacing.Text & "> muss größer 0,38 cm sein."
            End If
        Else
            check = False
            errorMsg = "Zahl in <" & lblRuledSpacing.Text & "> fehlt."
        End If

        'Error message if RuledSpacing is no number or less then 0.38
        If check = False Then
            txtRuledSpacing.Select()
            txtRuledSpacing.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg

        End If
        Return check
    End Function

    'Validate if RuledRows is filled correct
    Private Function Check_RuledRows()
        Dim check As Boolean = False

        If IsNumeric(txtRuledRows.Text) Then
            If CSng(txtRuledRows.Text) >= 1.0 Then
                check = True
            Else
                check = False
                errorMsg = "Zahl in <" & lblRuledRows.Text & "> muss größer 1 sein."
            End If
        Else
            check = False
            errorMsg = "Zahl in <" & lblRuledRows.Text & "> fehlt."
        End If

        'Error message if RuledRows is no number or less then 1
        If check = False Then
            txtRuledRows.Select()
            txtRuledRows.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if MCRows is filled correct
    Private Function Check_MCRows()
        Dim check As Boolean = False

        If IsNumeric(txtMCRows.Text) Then
            If CSng(txtMCRows.Text) >= 1.0 Then
                check = True
            Else
                check = False
                errorMsg = "Zahl in <" & lblMCRows.Text & "> muss größer 1 sein."
            End If
        Else
            check = False
            errorMsg = "Zahl in <" & lblMCRows.Text & "> fehlt."
        End If

        'Error message if RuledRows is no number or less then 1
        If check = False Then
            txtMCRows.Select()
            txtMCRows.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if TrueFalseRows is filled correct
    Private Function Check_TrueFalseRows()
        Dim check As Boolean = False

        If IsNumeric(txtTrueFalseRows.Text) Then
            If CSng(txtTrueFalseRows.Text) >= 1.0 Then
                check = True
            Else
                check = False
                errorMsg = "Zahl in <" & lblTrueFalseRows.Text & "> muss größer 1 sein."
            End If
        Else
            check = False
            errorMsg = "Zahl in <" & lblTrueFalseRows.Text & "> fehlt."
        End If

        'Error message if RuledRows is no number or less then 1
        If check = False Then
            txtTrueFalseRows.Select()
            txtTrueFalseRows.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if TrueFalse True Description is filled correct if checkbox is active
    Private Function Check_TrueFalseTrueDesc()
        Dim check As Boolean = False

        If txtTrueFalseTrueDesc.Text = "" And _
            chkTrueFalseButton.Checked = True Then
            check = False
            errorMsg = "Text in <" & lblTrueFalseTrueDesc.Text & "> fehlt."
        Else
            check = True
        End If

        'Error message if SolutionDescription is empty
        If check = False Then
            txtTrueFalseTrueDesc.Select()
            txtTrueFalseTrueDesc.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if TrueFalse False Description is filled correct if checkbox is active
    Private Function Check_TrueFalseFalseDesc()
        Dim check As Boolean = False

        If txtTrueFalseFalseDesc.Text = "" And _
            chkTrueFalseButton.Checked = True Then
            check = False
            errorMsg = "Text in <" & lblTrueFalseFalseDesc.Text & "> fehlt."
        Else
            check = True
        End If

        'Error message if SolutionDescription is empty
        If check = False Then
            txtTrueFalseFalseDesc.Select()
            txtTrueFalseFalseDesc.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if TrueFalse Reason Description is filled correct if checkbox is active
    Private Function Check_TrueFalseReasonDesc()
        Dim check As Boolean = False

        If txtTrueFalseReasonDesc.Text = "" And _
            chkTrueFalseReason.Checked = True And _
            chkTrueFalseButton.Checked = True Then
            check = False
            errorMsg = "Text in <" & lblTrueFalseReasonDesc.Text & "> fehlt."
        Else
            check = True
        End If

        'Error message if SolutionDescription is empty
        If check = False Then
            txtTrueFalseReasonDesc.Select()
            txtTrueFalseReasonDesc.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if Solutiondescription is filled correct if checkbox is active
    Private Function Check_SolutionDescription()
        Dim check As Boolean = False

        If txtSolutionDescription.Text = "" And _
            chkAddSolution.Checked = True Then
            check = False
            errorMsg = "Text in <" & lblSolutionDescription.Text & "> fehlt."
        Else
            check = True
        End If

        'Error message if SolutionDescription is empty
        If check = False Then
            txtSolutionDescription.Select()
            txtSolutionDescription.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if Seconds for HiddenObjectsInformation is filled correct
    Private Function Check_InformAboutHiddenObjectsTime()
        Dim check As Boolean = False

        If IsNumeric(txtInformAboutHiddenObjectsTime.Text) Then
            If CSng(txtInformAboutHiddenObjectsTime.Text) >= 1 Then
                check = True
            Else
                check = False
                errorMsg = "Sekunde in <" & lblInformAboutHiddenObjectsTime.Text & "> muss größer 0 sein."
            End If
        Else
            check = False
            errorMsg = "Zahl in <" & lblInformAboutHiddenObjectsTime.Text & "> fehlt."
        End If

        'Error message if RuledRows is no number or less then 1
        If check = False Then
            txtInformAboutHiddenObjectsTime.Select()
            txtInformAboutHiddenObjectsTime.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if grades are filled correct
    Private Function Check_Grades()
        Dim check As Boolean = False
        Dim i, j As System.Windows.Forms.Control

        'Check if percentage is a number and between 0 and 100
        For myTempCount = 1 To 5
            i = grpNotenbereich.Controls("txtGrade" & myTempCount)

            If checkPercentageValue(i.Text) = False Then
                i.Select()
                i.BackColor = bgColor
                check = False
                Exit For
            Else
                check = True
            End If

        Next

        If check = True Then
            'Loop through all txtGrade(i) and check if the sorting is correct.
            For myTempCount = 1 To 4
                i = grpNotenbereich.Controls("txtGrade" & myTempCount)
                j = grpNotenbereich.Controls("txtGrade" & myTempCount + 1)

                If i.Text <= j.Text Then
                    check = False
                    i.Select()
                    i.BackColor = bgColor
                    lblErrorText.Visible = True
                    lblErrorText.ForeColor = Drawing.Color.Red
                    lblErrorText.Text = "Note " & myTempCount & " muss größer als Note " & myTempCount + 1 & " sein."
                    Exit For
                Else
                    check = True
                End If
            Next
        End If

        Return check
    End Function

    'Validate if number of relative Path is filled correct
    Private Function Check_RelPathNumberFolders()
        Dim check As Boolean = False

        If IsNumeric(txtPathNumberFolders.Text) Then
            If CSng(txtPathNumberFolders.Text) >= 1 Then
                check = True
            Else
                check = False
                errorMsg = "Zahl in <" & lblPathNumberFolders.Text & "> muss größer 0 sein."
            End If
        Else
            check = False
            errorMsg = "Zahl in <" & lblPathNumberFolders.Text & "> fehlt."
        End If
   

        'Error message if PDFNoSolutionText is empty
        If check = False Then
            txtPathNumberFolders.Select()
            txtPathNumberFolders.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if PDFSolutionText is filled correct
    Private Function Check_PDFSolution()
        Dim check As Boolean = False

        If txtPDFSolutionText.Text = "" And _
            chkPrintSolution.Checked = True Then
            check = False
            errorMsg = "Text in <" & lblPDFSolutionText.Text & "> fehlt."
        ElseIf FileNameIsOk(txtPDFSolutionText.Text) = False Then
            check = False
            errorMsg = "<" & lblPDFSolutionText.Text & "> enthält ungültige Zeichen."
        Else
            check = True
        End If

        'Error message if PDFSolutionText is empty
        If check = False Then
            txtPDFSolutionText.Select()
            txtPDFSolutionText.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if PDFNoSolutionText is filled correct
    Private Function Check_PDFNoSolution()
        Dim check As Boolean = False

        If txtPDFNoSolutionText.Text = "" And _
            chkPrintNoSolution.Checked = True Then
            check = False
            errorMsg = "Text in <" & lblPDFNoSolutionText.Text & "> fehlt."
        ElseIf FileNameIsOk(txtPDFNoSolutionText.Text) = False Then
            check = False
            errorMsg = "<" & lblPDFNoSolutionText.Text & "> enthält ungültige Zeichen."
        Else
            check = True
        End If

        'Error message if PDFNoSolutionText is empty
        If check = False Then
            txtPDFNoSolutionText.Select()
            txtPDFNoSolutionText.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if PDFSubfolder is filled correct
    Private Function Check_PDFSubfolder()
        Dim check As Boolean = False

        If txtpdfSubFolderText.Text = "" And _
            radPDFSubfolder.Checked = True Then
            check = False
            errorMsg = "Text in <" & lblPDFSubfolder.Text & "> fehlt."
        ElseIf FileNameIsOk(txtpdfSubFolderText.Text) = False And _
            radPDFSubfolder.Checked = True Then
            check = False
            errorMsg = "<" & lblPDFSubfolder.Text & "> enthält ungültige Zeichen."
        Else
            check = True
        End If

        'Error message if PDFNoSolutionText is empty
        If check = False Then
            txtpdfSubFolderText.Select()
            txtpdfSubFolderText.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if PDF Path is filled correct
    Private Function Check_PDFPath()
        Dim check As Boolean = False

        If txtpdfPathText.Text = "" And _
            radPDFPath.Checked = True Then
            check = False
            errorMsg = "Pfad fehlt."
        ElseIf Not CreateObject("Scripting.FileSystemObject").FolderExists(txtpdfPathText.Text) And _
            radPDFPath.Checked = True Then
            check = False
            MsgBox("Pfad existiert nicht. Bitte legen Sie diesen zunächst an oder wählen Sie einen anderen Pfad aus.", _
                   MsgBoxStyle.Information, "LKTools")
        Else
            check = True
        End If

        'Error message if PDFNoSolutionText is empty
        If check = False Then
            txtpdfPathText.Select()
            txtpdfPathText.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Validate if PDF Export document description is different
    Private Function Check_PDFExport()
        Dim check As Boolean = False

        If chkPrintSolution.Checked = True And chkPrintNoSolution.Checked = True Then
            If txtPDFSolutionText.Text = txtPDFNoSolutionText.Text Then
                check = False
                errorMsg = "Die Bezeichnung muss sich unterscheiden."
            Else
                check = True
            End If
        Else
            check = True
        End If

        'Error message if PDFNoSolutionText is empty
        If check = False Then
            txtPDFSolutionText.Select()
            txtPDFSolutionText.BackColor = bgColor
            txtPDFNoSolutionText.BackColor = bgColor
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = errorMsg
        End If
        Return check
    End Function

    'Update the global variables
    Private Sub UpdateVariables()
        '## Allgemein
        LKTool.ColorVisible = LKTool.ColorVisible
        LKTool.ColorHidden = LKTool.ColorHidden
        LKTool.chkShape = chkShapes.Checked
        LKTool.chkLine = chkLines.Checked
        LKTool.chkUnderline = chkUnderline.Checked
        LKTool.InformAboutHiddenObjects = chkInformAboutHiddenObjects.Checked
        LKTool.InformAboutHiddenObjectsTime = CInt(txtInformAboutHiddenObjectsTime.Text)

        '## Objekte --> Vorlagen
        'Several Buttons in tab objects
        LKTool.RedTextboxButton = chkRedTextbox.Checked
        LKTool.RevisionPageButton = chkRevisionPage.Checked
        LKTool.chkRevisionPrint = chkRevisionPrint.Checked
        LKTool.ExcerciseButton = chkExcerciseButton.Checked
        LKTool.ExamButton = chkExamButton.Checked

        '#### Ruled Template
        LKTool.RuledButton = chkRuledButton.Checked
        LKTool.RuledSpacing = CSng(txtRuledSpacing.Text)
        LKTool.RuledRows = CInt(txtRuledRows.Text)
        'Ruled Style
        If radStyleLine.Checked = True Then
            LKTool.RuledStyle = 1
        ElseIf radStyleDot.Checked = True Then
            LKTool.RuledStyle = 2
        ElseIf radStyleDash.Checked = True Then
            LKTool.RuledStyle = 4
        Else
            LKTool.RuledStyle = 1
        End If
        'Ruled Style Width
        If radRuledStyleWidth50.Checked = True Then
            LKTool.RuledStyleWidth = 4
        ElseIf radRuledStyleWidth75.Checked = True Then
            LKTool.RuledStyleWidth = 6
        ElseIf radRuledStyleWidth100.Checked = True Then
            LKTool.RuledStyleWidth = 8
        Else
            LKTool.RuledStyleWidth = 4
        End If

        '#### Graph Template
        LKTool.GraphButton = chkGraphButton.Checked
        LKTool.GraphRows = CInt(txtGraphRows.Text)
        LKTool.Graphwidth = CSng(txtGraphWidth.Text)

        '## Objekte --> Aufgaben
        '#### MC Template
        LKTool.MCButton = chkMCButton.Checked
        LKTool.MCRows = txtMCRows.Text
        LKTool.chkMCAllignRight = chkMCAllignRight.Checked

        '#### True/False Template
        LKTool.TrueFalseButton = chkTrueFalseButton.Checked
        LKTool.TrueFalseRows = txtTrueFalseRows.Text
        LKTool.TrueFalseTrueDesc = txtTrueFalseTrueDesc.Text
        LKTool.TrueFalseFalseDesc = txtTrueFalseFalseDesc.Text
        LKTool.TrueFalseReason = chkTrueFalseReason.Checked
        LKTool.TrueFalseReasonDesc = txtTrueFalseReasonDesc.Text

        '#### Add Solution Template
        LKTool.AddSolution = chkAddSolution.Checked
        LKTool.SolutionDescription = txtSolutionDescription.Text

        '## Objekte --> Noten
        LKTool.GradeButton = chkGradeButton.Checked
        LKTool.grade(0) = CInt(txtGrade1.Text)
        LKTool.grade(1) = CInt(txtGrade2.Text)
        LKTool.grade(2) = CInt(txtGrade3.Text)
        LKTool.grade(3) = CInt(txtGrade4.Text)
        LKTool.grade(4) = CInt(txtGrade5.Text)
        LKTool.Rounding05 = chk05Rounding.Checked
        LKTool.NoRounding = chkNoRounding.Checked

        '## Objekte --> Pfad
        LKTool.PathButton = chkPathButton.Checked
        '###### Path Option
        If radFullPath.Checked = True Then
            LKTool.PathOption = 1
        ElseIf radRelPath.Checked = True Then
            LKTool.PathOption = 2
        ElseIf radNoPath.Checked = True Then
            LKTool.PathOption = 3
        Else
            LKTool.PathOption = 1 'If something went wrong, the default is used
        End If
        LKTool.PathNumberFolders = txtPathNumberFolders.Text
        LKTool.PathAddDocumentName = chkPathAddDocumentName.Checked

        'Presentation Settings
        LKTool.ShowOverlayFunction = chkShowOverlayFunction.Checked
        LKTool.ColorOverlay = LKTool.ColorOverlay
        LKTool.OverlayTransparency = txtOverlayTransparency.Text
        LKTool.chkPrintHiddenTextButton = chkPrintHiddenTextFlag.Checked

        '## Ausgabe
        '#### Allgemein
        LKTool.QuickPrint = chkQuickPrint.Checked
        LKTool.PrintSolution = chkPrintSolution.Checked
        LKTool.PrintNoSolution = chkPrintNoSolution.Checked

        '#### PDF Export settings
        '###### PDF Export RadioButton
        If radPDFSameFolder.Checked = True Then
            LKTool.pdfExportSettings = 1
        ElseIf radPDFSubfolder.Checked = True Then
            LKTool.pdfExportSettings = 2
        ElseIf radPDFPath.Checked = True Then
            LKTool.pdfExportSettings = 3
        Else
            LKTool.pdfExportSettings = 1 'If something went wrong, the default is used
        End If

        'Position prefix or suffix
        If radDescriptionPrefix.Checked = True Then
            LKTool.chkDescriptionPositionSuffix = False
        ElseIf radDescriptionSuffix.Checked = True Then
            LKTool.chkDescriptionPositionSuffix = True
        Else
            LKTool.chkDescriptionPositionSuffix = True
        End If

        LKTool.pdfSolutionText = txtPDFSolutionText.Text
        LKTool.pdfNoSolutionText = txtPDFNoSolutionText.Text
        LKTool.pdfSubFolderText = txtpdfSubFolderText.Text
        LKTool.pdfPathText = txtpdfPathText.Text
        '###### PDF extended Export Settings
        LKTool.ExtendedPDFButton = chkExtendedPDFButton.Checked
        LKTool.ShowExtendedPDFSettings = chkShowExtendedPDFSettings.Checked
        LKTool.chkPDFExportEqual = chkPDFExportEqual.Checked
        LKTool.chkPDFMarkupsSolution = chkMarkupsSolution.Checked
        LKTool.chkPDFMarkupsNoSolution = chkMarkupsNoSolution.Checked
        LKTool.chkOpenPDFFolder = chkOpenPDFFolder.Checked


        '## Update
        If radUpdate14.Checked = True Then
            LKTool.UpdateInterval = 14
        ElseIf radUpdateDaily.Checked = True Then
            LKTool.UpdateInterval = 1
        ElseIf radUpdate30.Checked = True Then
            LKTool.UpdateInterval = 30
        ElseIf radUpdateNever.Checked = True Then
            LKTool.UpdateInterval = 99999
        End If

    End Sub

    'Update the XML with new values
    Private Sub UpdateXML()
        Dim xDoc As MSXML2.DOMDocument60
        Dim root As Object

        Dim point As MSXML2.IXMLDOMNode

        xDoc = New MSXML2.DOMDocument60
        xDoc.async = False 'Document must be completly loaded

        If xDoc.load(LKTool.myFile) Then
            root = xDoc.documentElement
            point = root.firstChild

            'Overwrite all values to get more performance, then checking each value
            '## Allgemein
            point.selectSingleNode("//LKToolsVersion").text = My.Application.Info.Version.ToString
            point.selectSingleNode("//ColorVisible").text = LKTool.ColorVisible
            point.selectSingleNode("//ColorHidden").text = LKTool.ColorHidden
            point.selectSingleNode("//ObjectTextColor").text = LKTool.ObjectTextColor
            point.selectSingleNode("//HideShapes").text = chkShapes.Checked
            point.selectSingleNode("//HideLines").text = chkLines.Checked
            point.selectSingleNode("//HideUnderline").text = chkLines.Checked
            point.selectSingleNode("//InformAboutHiddenObjects").text = chkInformAboutHiddenObjects.Checked
            point.selectSingleNode("//InformAboutHiddenObjectsTime").text = txtInformAboutHiddenObjectsTime.Text

            '## Objekte --> Vorlagen
            'Several Buttons in tab objects
            point.selectSingleNode("//RedTextboxButton").text = chkRedTextbox.Checked
            point.selectSingleNode("//RevisionPageButton").text = chkRevisionPage.Checked
            point.selectSingleNode("//chkRevisionPrint").text = chkRevisionPrint.Checked
            point.selectSingleNode("//ExcerciseButton").text = chkExcerciseButton.Checked
            point.selectSingleNode("//ExamButton").text = chkExamButton.Checked

            '#### Ruled Template
            point.selectSingleNode("//RuledButton").text = chkRuledButton.Checked
            point.selectSingleNode("//RuledSpacing").text = txtRuledSpacing.Text
            point.selectSingleNode("//RuledRows").text = txtRuledRows.Text
            point.selectSingleNode("//RuledStyle").text = LKTool.RuledStyle
            point.selectSingleNode("//RuledStyleWidth").text = LKTool.RuledStyleWidth

            '#### Graph Template
            point.selectSingleNode("//GraphButton").text = chkGraphButton.Checked
            point.selectSingleNode("//GraphRows").text = txtGraphRows.Text
            point.selectSingleNode("//GraphWidth").text = txtGraphWidth.Text

            '## Objekte --> Aufgaben
            '#### MC Template
            point.selectSingleNode("//MCButton").text = chkMCButton.Checked
            point.selectSingleNode("//MCRows").text = txtMCRows.Text
            point.selectSingleNode("//chkMCAllignRight").text = chkMCAllignRight.Checked

            '#### True/False Template
            point.selectSingleNode("//TrueFalseButton").text = chkTrueFalseButton.Checked
            point.selectSingleNode("//TrueFalseRows").text = txtTrueFalseRows.Text
            point.selectSingleNode("//TrueFalseTrueDesc").text = txtTrueFalseTrueDesc.Text
            point.selectSingleNode("//TrueFalseFalseDesc").text = txtTrueFalseFalseDesc.Text
            point.selectSingleNode("//TrueFalseReason").text = chkTrueFalseReason.Checked
            point.selectSingleNode("//TrueFalseReasonDesc").text = txtTrueFalseReasonDesc.Text


            '#### Add Solution Template
            point.selectSingleNode("//AddSolution").text = chkAddSolution.Checked
            point.selectSingleNode("//SolutionDescription").text = txtSolutionDescription.Text

            '## Objekte --> Noten
            point.selectSingleNode("//GradeButton").text = chkGradeButton.Checked
            point.selectSingleNode("//factorGrade1").text = txtGrade1.Text
            point.selectSingleNode("//factorGrade2").text = txtGrade2.Text
            point.selectSingleNode("//factorGrade3").text = txtGrade3.Text
            point.selectSingleNode("//factorGrade4").text = txtGrade4.Text
            point.selectSingleNode("//factorGrade5").text = txtGrade5.Text
            point.selectSingleNode("//GradeScaleRounding").text = chk05Rounding.Checked
            point.selectSingleNode("//GradeScaleExact").text = chkNoRounding.Checked

            '## Objekte --> Pfad
            point.selectSingleNode("//PathButton").text = chkPathButton.Checked
            point.selectSingleNode("//PathOption").text = LKTool.PathOption
            point.selectSingleNode("//PathNumberFolders").text = LKTool.PathNumberFolders
            point.selectSingleNode("//PathAddDocumentName").text = chkPathAddDocumentName.Checked

            '## Objekte --> Präsentation
            point.selectSingleNode("//ShowOverlayFunction").text = chkShowOverlayFunction.Checked
            point.selectSingleNode("//ColorOverlay").text = LKTool.ColorOverlay
            point.selectSingleNode("//OverlayTransparency").text = txtOverlayTransparency.Text

            '## Ausgabe
            point.selectSingleNode("//QuickPrint").text = chkQuickPrint.Checked
            point.selectSingleNode("//PrintSolution").text = chkPrintSolution.Checked
            point.selectSingleNode("//PrintNoSolution").text = chkPrintNoSolution.Checked
            point.selectSingleNode("//chkPrintHiddenTextButton").text = chkPrintHiddenTextFlag.Checked

            '#### PDF Ausgabe Allgemein
            point.selectSingleNode("//pdfExportSettings").text = LKTool.pdfExportSettings
            point.selectSingleNode("//pdfSolutionText").text = txtPDFSolutionText.Text
            point.selectSingleNode("//pdfNoSolutionText").text = txtPDFNoSolutionText.Text
            point.selectSingleNode("//pdfSubFolderText").text = txtpdfSubFolderText.Text
            point.selectSingleNode("//pdfPathText").text = txtpdfPathText.Text
            '##### PDF erweiterte Ausgabe
            point.selectSingleNode("//ExtendedPDFButton").text = chkExtendedPDFButton.Checked
            point.selectSingleNode("//ShowExtendedPDFSettings").text = chkShowExtendedPDFSettings.Checked
            point.selectSingleNode("//chkPDFExportEqual").text = chkPDFExportEqual.Checked
            point.selectSingleNode("//chkPDFMarkupsSolution").text = chkMarkupsSolution.Checked
            point.selectSingleNode("//chkPDFMarkupsNoSolution").text = chkMarkupsNoSolution.Checked
            point.selectSingleNode("//chkOpenPDFFolder").text = chkOpenPDFFolder.Checked

            '## Update
            point.selectSingleNode("//UpdateInterval").text = LKTool.UpdateInterval

            xDoc.save(LKTool.myFile)
            xDoc = Nothing
        End If
    End Sub

    'Show the color dialog window for ColorVisible
    Private Sub btnColorVisible_Click(sender As Object, e As EventArgs) Handles btnColorVisible.Click
        ColorDialog1.Color = System.Drawing.ColorTranslator.FromOle(LKTool.ColorVisible)
        ' Update the text box color if the user clicks OK 
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            LKTool.ColorVisible = System.Drawing.ColorTranslator.ToWin32(ColorDialog1.Color)
            lblVisbleColorExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ColorVisible)
        End If
    End Sub

    'Show the color dialog window for ColorHidden
    Private Sub btnColorHidden_Click(sender As Object, e As EventArgs) Handles btnColorHidden.Click
        ColorDialog1.Color = System.Drawing.ColorTranslator.FromOle(LKTool.ColorHidden)
        ' Update the text box color if the user clicks OK 
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            LKTool.ColorHidden = System.Drawing.ColorTranslator.ToWin32(ColorDialog1.Color)
            lblHiddenColorExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ColorHidden)
        End If
    End Sub

    'Show the color dialog window for objectTextColor
    Private Sub btnObjectTextColor_Click(sender As Object, e As EventArgs) Handles btnObjectTextColor.Click
        ColorDialog1.Color = System.Drawing.ColorTranslator.FromOle(LKTool.ObjectTextColor)
        ' Update the text box color if the user clicks OK 
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            LKTool.ObjectTextColor = System.Drawing.ColorTranslator.ToWin32(ColorDialog1.Color)
            lblObjectTextColorExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ObjectTextColor)
        End If
    End Sub

    'Default Button for ColorVisible 
    Private Sub btnColorVisibleDefault_Click(sender As Object, e As EventArgs) Handles btnColorVisibleDefault.Click
        LKTool.ColorVisible = "255"
        lblVisbleColorExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ColorVisible)
    End Sub

    'Default Button for ColorHidden
    Private Sub btnColorHiddenDefault_Click(sender As Object, e As EventArgs) Handles btnColorHiddenDefault.Click
        LKTool.ColorHidden = "16711679"
        lblHiddenColorExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ColorHidden)
    End Sub

    'Default Button for ObjectTextColor
    Private Sub btnObjectTextColorDefault_Click(sender As Object, e As EventArgs) Handles btnObjectTextColorDefault.Click
        LKTool.ObjectTextColor = "0"
        lblObjectTextColorExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ObjectTextColor)
    End Sub

    'Default Button for grade 1
    Private Sub btnGradeDefault1_Click(sender As Object, e As EventArgs) Handles btnGradeDefault1.Click
        txtGrade1.Text = "92"
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Default Button for grade 2
    Private Sub btnGradeDefault2_Click(sender As Object, e As EventArgs) Handles btnGradeDefault2.Click
        txtGrade2.Text = "81"
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Default Button for grade 3
    Private Sub btnGradeDefault3_Click(sender As Object, e As EventArgs) Handles btnGradeDefault3.Click
        txtGrade3.Text = "67"
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Default Button for grade 4
    Private Sub btnGradeDefault4_Click(sender As Object, e As EventArgs) Handles btnGradeDefault4.Click
        txtGrade4.Text = "50"
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Default Button for grade 5
    Private Sub btnGradeDefault5_Click(sender As Object, e As EventArgs) Handles btnGradeDefault5.Click
        txtGrade5.Text = "30"
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if txtGrade1 changes
    Private Sub txtGrade1_TextChanged(sender As Object, e As EventArgs) Handles txtGrade1.LostFocus
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if txtGrade2 changes
    Private Sub txtGrade2_TextChanged(sender As Object, e As EventArgs) Handles txtGrade2.LostFocus
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if txtGrade3 changes
    Private Sub txtGrade3_TextChanged(sender As Object, e As EventArgs) Handles txtGrade3.LostFocus
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if txtGrade4 changes
    Private Sub txtGrade4_TextChanged(sender As Object, e As EventArgs) Handles txtGrade4.LostFocus
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if txtGrade5 changes
    Private Sub txtGrade5_TextChanged(sender As Object, e As EventArgs) Handles txtGrade5.LostFocus
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Action for clicking the DEFAULT Button
    Private Sub btnDefaultSettings_Click(sender As Object, e As EventArgs) Handles btnDefaultSettings.Click
        Dim frmSettings As frmSettings = New frmSettings()

        'The window is closed
        Me.Close()

        'Default values are set
        '## Allgemein
        LKTool.ColorVisible = "255"
        LKTool.ColorHidden = "16711679"
        LKTool.ObjectTextColor = "0"
        LKTool.chkShape = "True"
        LKTool.chkLine = "True"
        LKTool.chkUnderline = "True"
        LKTool.InformAboutHiddenObjects = "True"
        LKTool.InformAboutHiddenObjectsTime = 3

        '## Objekte --> Vorlagen
        'Several Buttons in tab objects
        LKTool.RedTextboxButton = "True"
        LKTool.ExcerciseButton = "True"
        LKTool.ExamButton = "True"

        '#### Ruled Template
        LKTool.RuledButton = "True"
        LKTool.RuledSpacing = 0.75
        LKTool.RuledRows = 10

        '#### Graph Template
        LKTool.GraphButton = "True"
        LKTool.GraphRows = 10
        LKTool.Graphwidth = 0.5

        '## Objekte --> Aufgaben
        '#### MC Template
        LKTool.MCButton = "True"
        LKTool.MCRows = 1
        LKTool.chkMCAllignRight = "False"

        '#### True/False Template
        LKTool.TrueFalseButton = "True"
        LKTool.TrueFalseRows = 1
        LKTool.TrueFalseTrueDesc = "Richtig"
        LKTool.TrueFalseFalseDesc = "Falsch"
        LKTool.TrueFalseReason = "True"
        LKTool.TrueFalseReasonDesc = "Begründung"

        '#### Add Solution Template
        LKTool.AddSolution = "True"
        LKTool.SolutionDescription = "Lösungs-vorschlag"

        '## Objekte --> Noten
        LKTool.GradeButton = "True"
        LKTool.grade(0) = 92
        LKTool.grade(1) = 81
        LKTool.grade(2) = 67
        LKTool.grade(3) = 50
        LKTool.grade(4) = 30
        LKTool.Rounding05 = "True"
        LKTool.NoRounding = "True"

        '## Objekte --> Pfad
        LKTool.PathButton = "False"
        LKTool.PathOption = "1"
        LKTool.PathNumberFolders = "1"
        LKTool.PathAddDocumentName = "True"

        '## Ausgabe
        '#### Ausgabe Allgemein
        LKTool.QuickPrint = "True"
        LKTool.PrintSolution = "True"
        LKTool.PrintNoSolution = "True"
        LKTool.chkPrintHiddenTextButton = "False"

        '#### PDF Ausgabe
        LKTool.pdfExportSettings = 1
        LKTool.pdfSolutionText = "_Lösung"
        LKTool.pdfNoSolutionText = "_Schüler"
        LKTool.pdfPathText = "c:" & Environ("HOMEPATH")
        LKTool.pdfSubFolderText = "PDF"

        '#### PDF erweiterte Ausgabe
        LKTool.ExtendedPDFButton = False
        LKTool.ShowExtendedPDFSettings = False
        LKTool.chkPDFExportEqual = False
        LKTool.chkPDFMarkupsSolution = False
        LKTool.chkPDFMarkupsNoSolution = False
        LKTool.chkOpenPDFFolder = False

        '## Update
        LKTool.UpdateInterval = 30

        'The window is opened
        frmSettings.TopMost = True
        frmSettings.Show()

    End Sub

    'Action if e-mail is clicked
    Private Sub lblEMail_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblEMail.LinkClicked
        System.Diagnostics.Process.Start("mailto:software@info-rommel.de")
    End Sub

    'Action if webpage is clicked
    Private Sub lblWebPage_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblWebPage.LinkClicked
        System.Diagnostics.Process.Start("http://lktools.sourceforge.net")
    End Sub

    'Action if documentation is clicked
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://sourceforge.net/p/lktools/wiki/")
    End Sub

    'Action if Update is clicked
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim lk As LKTool = New LKTool()

        lk.Check_Updates(1) 'Jump to lktools.vb
    End Sub

    'Function to add or update the Grade Diagramm
    Private Sub AddGradeGraph()
        GradeGraph.Series.Clear()
        '  PointGraph.Titles.Add("Notenskala")
        'Create a new series and add data points to it.
        Dim s As New Series
        Dim t As New Series
        Dim i As Single = 100

        'actual Line
        s.Points.AddXY("1", i)
        s.Points.AddXY("2", Math.Round(i * CInt(txtGrade1.Text) / 100, 1))
        s.Points.AddXY("3", Math.Round(i * CInt(txtGrade2.Text) / 100, 1))
        s.Points.AddXY("4", Math.Round(i * CInt(txtGrade3.Text) / 100, 1))
        s.Points.AddXY("5", Math.Round(i * CInt(txtGrade4.Text) / 100, 1))
        s.Points.AddXY("6", Math.Round(i * CInt(txtGrade5.Text) / 100, 1))
        s.Points.AddXY("", 0)

        'Linear reference Line
        t.Points.AddXY("1", i)
        t.Points.AddXY("2", Math.Round(i / 6 * 5, 1))
        t.Points.AddXY("3", Math.Round(i / 6 * 4, 1))
        t.Points.AddXY("4", Math.Round(i / 6 * 3, 1))
        t.Points.AddXY("5", Math.Round(i / 6 * 2, 1))
        t.Points.AddXY("6", Math.Round(i / 6 * 1, 1))
        t.Points.AddXY("", 0)

        'Change to a line graph.
        s.ChartType = SeriesChartType.Line
        t.ChartType = SeriesChartType.Line
        'Grafische Anpassung des Diagramms
        s.IsValueShownAsLabel = True 'Anzeige der Prozentwerte über Kurve
        s.Color = Drawing.Color.Red
        t.Color = Drawing.Color.Gray
        s.BorderWidth = 6
        t.BorderWidth = 4
        t.BorderDashStyle = ChartDashStyle.Dot
        'Maximal 6 Einträge (Noten) auf der X Achse
        GradeGraph.ChartAreas(0).AxisX.Maximum = 6
        GradeGraph.ChartAreas(0).AxisX.IntervalOffset = -1
        GradeGraph.ChartAreas(0).AxisX.Title = "Note"

        'Maximal 100 % auf der X Achse
        GradeGraph.ChartAreas(0).AxisY.Maximum = i
        GradeGraph.ChartAreas(0).AxisY.Title = "Prozent"
        GradeGraph.ChartAreas(0).AxisY.TitleAlignment = Drawing.StringAlignment.Far
        GradeGraph.ChartAreas(0).AxisY.TextOrientation = TextOrientation.Auto

        'Add the series to the Chart1 control.
        GradeGraph.Series.Add(t)
        GradeGraph.Series.Add(s)
    End Sub

    'Action if the linear Grade Button is clicked
    Private Sub btnGradelinear_Click(sender As Object, e As EventArgs) Handles btnGradelinear.Click
        txtGrade1.Text = 83
        txtGrade2.Text = 67
        txtGrade3.Text = 50
        txtGrade4.Text = 33
        txtGrade5.Text = 17

        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Action if the degressiv Grade Button is clicked
    Private Sub btnGradehart_Click(sender As Object, e As EventArgs) Handles btnGradehart.Click
        txtGrade1.Text = 92
        txtGrade2.Text = 81
        txtGrade3.Text = 67
        txtGrade4.Text = 50
        txtGrade5.Text = 30

        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Show / Hide additional information if PDF Export is saved in same folder
    Private Sub radPDFSameFolder_CheckedChanged(sender As Object, e As EventArgs)
        lblPDFSubfolder.Visible = False
        txtpdfSubFolderText.Visible = False
        txtpdfPathText.Visible = False
        btnSavePath.Visible = False
    End Sub

    'Show / Hide additional information if PDF Export is saved in subfolder
    Private Sub radPDFSubfolder_CheckedChanged(sender As Object, e As EventArgs)
        lblPDFSubfolder.Visible = True
        txtpdfSubFolderText.Visible = True
        txtpdfPathText.Visible = False
        btnSavePath.Visible = False

    End Sub

    'Show / Hide additional information if PDF Export is saved fixed path
    Private Sub radPDFPath_CheckedChanged(sender As Object, e As EventArgs)
        lblPDFSubfolder.Visible = False
        txtpdfSubFolderText.Visible = False
        txtpdfPathText.Visible = True
        btnSavePath.Visible = True
    End Sub

    'Check for valid characters in file name or folder
    Private Function FileNameIsOk(ByVal fileName As String) As Boolean
        If Regex.IsMatch(fileName, "^[A-Za-z0-9äöüÄÖÜ\-_ ]+$") Then
            Return True
        Else
            Return False
        End If
    End Function

    'Define a fix path of the PDF Export
    Private Sub btnSavePath_Click(sender As Object, e As EventArgs)

        FolderBrowserDialog1.SelectedPath = LKTool.pdfPathText 'Select the current path as default path

        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtpdfPathText.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    'Check if a value is missing
    Function CheckMissingValues()

        If Regex.IsMatch(txtGrade1.Text, "^[0-9]+$") And _
            Regex.IsMatch(txtGrade2.Text, "^[0-9]+$") And _
            Regex.IsMatch(txtGrade3.Text, "^[0-9]+$") And _
            Regex.IsMatch(txtGrade4.Text, "^[0-9]+$") And _
            Regex.IsMatch(txtGrade5.Text, "^[0-9]+$") Then
            Return True
        Else
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Es darf kein Wert fehlen."
            Return False
        End If
    End Function

    'Function Check if value is numeric and higher 0
    Private Function checkPercentageValue(i As String)
        Dim check As Boolean = False

        If IsNumeric(i) = True Then
            If i > 0 And i < 100 Then
                check = True
            Else
                check = False
                lblErrorText.Visible = True
                lblErrorText.ForeColor = Drawing.Color.Red
                lblErrorText.Text = "Prozentwert muss zwischen 0 und 100 liegen."
            End If
        ElseIf IsNumeric(i) = False Then
            check = False
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Bitte geben Sie eine positive Zahl ein."
        End If
        Return (check)

    End Function

    'Show the changelog of new version
    Private Sub btnChangeLog_Click(sender As Object, e As EventArgs) Handles btnChangeLog.Click
        Dim frmchangelog = System.Windows.Forms.Application.OpenForms

        If frmchangelog.OfType(Of frmChangelog).Any Then
            frmchangelog.Item("frmchangelog").Activate()
        Else
            Dim frmchangelog2 = New frmChangelog()
            frmchangelog2.Show()
        End If

    End Sub

    Private Sub chkShowExtendedPDFSettings_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowExtendedPDFSettings.CheckedChanged
        Dim result As MsgBoxResult

        If chkExtendedPDFButton.Checked = True And chkShowExtendedPDFSettings.Checked = True Then
            result = MsgBox("Die Schaltfläche 'Erw. PDF Ausgabe' kann deaktiviert werden." & vbCrLf & _
                   vbCrLf & _
                   "Soll die Checkbox deaktiviert werden?", _
                   MsgBoxStyle.Information + MsgBoxStyle.YesNo, "LKTools")
            If result = MsgBoxResult.Yes Then
                chkExtendedPDFButton.Checked = False
            Else
                chkExtendedPDFButton.Checked = True
            End If

        End If

    End Sub

    Private Sub chkPDFExportEqual_CheckedChanged(sender As Object, e As EventArgs) Handles chkPDFExportEqual.CheckedChanged

        'if the checkbox is activated, the groupfield is disabled
        'and the values of the solution is copied to the no solution group box
        If chkPDFExportEqual.Checked = True Then
            grpPDFExportNoSolution.Enabled = False
            chkMarkupsNoSolution.Checked = chkMarkupsSolution.Checked
        Else
            grpPDFExportNoSolution.Enabled = True
        End If

    End Sub

    Private Sub chkMarkupsSolution_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarkupsSolution.CheckedChanged

        If chkPDFExportEqual.Checked = True Then
            chkMarkupsNoSolution.Checked = chkMarkupsSolution.Checked
        End If

    End Sub

    Private Sub radPDFSubfolder_CheckedChanged_1(sender As Object, e As EventArgs) Handles radPDFSubfolder.CheckedChanged

        If radPDFSubfolder.Checked = True Then
            txtpdfPathText.Visible = False
            btnSavePath.Visible = False
            txtpdfSubFolderText.Visible = True
            lblPDFSubfolder.Visible = True
        End If

    End Sub

    Private Sub radPDFPath_CheckedChanged_1(sender As Object, e As EventArgs) Handles radPDFPath.CheckedChanged

        If radPDFPath.Checked = True Then
            txtpdfSubFolderText.Visible = False
            lblPDFSubfolder.Visible = False
            txtpdfPathText.Visible = True
            btnSavePath.Visible = True
        End If
    End Sub

    Private Sub radPDFSameFolder_CheckedChanged_1(sender As Object, e As EventArgs) Handles radPDFSameFolder.CheckedChanged

        If radPDFSameFolder.Checked = True Then
            txtpdfSubFolderText.Visible = False
            lblPDFSubfolder.Visible = False
            txtpdfPathText.Visible = False
            btnSavePath.Visible = False
        End If

    End Sub


    Private Sub radRelPath_CheckedChanged(sender As Object, e As EventArgs) Handles radRelPath.CheckedChanged

        If radRelPath.Checked = True Then
            txtPathNumberFolders.Visible = True
            lblPathNumberFolders.Visible = True
        End If

    End Sub

    Private Sub radFullPath_CheckedChanged(sender As Object, e As EventArgs) Handles radFullPath.CheckedChanged

        If radFullPath.Checked = True Then
            txtPathNumberFolders.Visible = False
            lblPathNumberFolders.Visible = False
        End If
    End Sub

    Private Sub radNoPath_CheckedChanged(sender As Object, e As EventArgs) Handles radNoPath.CheckedChanged

        If radNoPath.Checked = True Then
            txtPathNumberFolders.Visible = False
            lblPathNumberFolders.Visible = False
        End If

    End Sub

    Private Sub btnColorOverlay_Click(sender As Object, e As EventArgs) Handles btnColorOverlay.Click
        ColorDialog1.Color = System.Drawing.ColorTranslator.FromOle(LKTool.ColorOverlay)
        ' Update the text box color if the user clicks OK 
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            LKTool.ColorOverlay = System.Drawing.ColorTranslator.ToWin32(ColorDialog1.Color)
            lblOverlayExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ColorOverlay)
        End If
    End Sub

    Private Sub btnOverlayDefault_Click(sender As Object, e As EventArgs) Handles btnOverlayDefault.Click
        LKTool.ColorOverlay = "15191472"
        lblOverlayExample.ForeColor = System.Drawing.ColorTranslator.FromOle(LKTool.ColorOverlay)
    End Sub
End Class