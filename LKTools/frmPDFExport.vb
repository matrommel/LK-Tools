
Public Class frmPDFExport

    Private Sub frmPDFExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkPDFExportEqual.Checked = LKTool.chkPDFExportEqual
        chkMarkupsSolution.Checked = LKTool.chkPDFMarkupsSolution
        chkMarkupsNoSolution.Checked = LKTool.chkPDFMarkupsNoSolution
        chkOpenPDFFolder.Checked = LKTool.chkOpenPDFFolder


        'if the checkbox is activated, the groupfield is disabled
        If chkPDFExportEqual.Checked = True Then
            grpPDFExportNoSolution.Enabled = False
        Else
            grpPDFExportNoSolution.Enabled = True
        End If

        If isSelected() = True Then
            radSolutionSelectedPages.Enabled = True
            radNoSolutionSelectedPages.Enabled = True
        Else
            radSolutionSelectedPages.Enabled = False
            radNoSolutionSelectedPages.Enabled = False

        End If
    End Sub

    Private Sub chkPDFExportEqual_CheckedChanged(sender As Object, e As EventArgs) Handles chkPDFExportEqual.CheckedChanged

        'if the checkbox is activated, the groupfield is disabled
        'and the values of the solution is copied to the no solution group box
        If chkPDFExportEqual.Checked = True Then
            grpPDFExportNoSolution.Enabled = False
            txtPageFromNoSolution.Text = txtPageFromSolution.Text
            txtPageToNoSolution.Text = txtPageToSolution.Text
            chkMarkupsNoSolution.Checked = chkMarkupsSolution.Checked
        Else
            grpPDFExportNoSolution.Enabled = True
        End If

    End Sub

    'Function check if any selection is made and return true or false
    Private Function isSelected()
        'Check if selection is made
        Dim cursor As Word.Selection
        Dim isAnythingSelected As Boolean

        cursor = Globals.ThisAddIn.Application.Selection
        isAnythingSelected = False

        If cursor.Type = WdSelectionType.wdSelectionNormal Then
            isAnythingSelected = True
        End If

        Return isAnythingSelected


    End Function

    Private Sub chkMarkupsSolution_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarkupsSolution.CheckedChanged



        'Keep both values the same if checkbox equal is activated
        If chkPDFExportEqual.Checked = True Then
            If chkMarkupsSolution.Checked = True Then
                chkMarkupsNoSolution.Checked = True
            End If

            If chkMarkupsSolution.Checked = False Then
                chkMarkupsNoSolution.Checked = False
            End If
        End If
    End Sub


    Private Sub txtPageFromSolution_TextChanged(sender As Object, e As EventArgs) Handles txtPageFromSolution.TextChanged

        ActivateRadPages(False)

    End Sub

    Private Sub txtPageToSolution_TextChanged(sender As Object, e As EventArgs) Handles txtPageToSolution.TextChanged

        ActivateRadPages(False)

    End Sub

    Private Sub txtPageFromNoSolution_TextChanged(sender As Object, e As EventArgs) Handles txtPageFromNoSolution.TextChanged
        ActivateRadPages(True)
    End Sub

    Private Sub txtPageToNoSolution_TextChanged(sender As Object, e As EventArgs) Handles txtPageToNoSolution.TextChanged
        ActivateRadPages(True)
    End Sub

    Private Sub ActivateRadPages(isNoSolutionGroupBox As Boolean)
        'isnoSolution defines whether the left or right groupbox should be regarded.

        'Keep both values the same if checkbox equal is activated
        If chkPDFExportEqual.Checked = True Then
            txtPageFromNoSolution.Text = txtPageFromSolution.Text
        End If

        If isNoSolutionGroupBox = False Then

            If txtPageFromSolution.Text = "" And txtPageToSolution.Text = "" Then
                'NOthing
            Else
                radSolutionAllPages.Checked = False
                radSolutionCurrentPages.Checked = False
                radSolutionSelectedPages.Checked = False
                radSolutionRange.Checked = True
            End If
        Else
            If txtPageFromNoSolution.Text = "" And txtPageToNoSolution.Text = "" Then
                'NOthing
            Else
                radNoSolutionAllPages.Checked = False
                radNoSolutionCurrentPages.Checked = False
                radNoSolutionSelectedPages.Checked = False
                radNoSolutionRange.Checked = True
            End If
        End If


    End Sub


    Private Sub btnOKPDFExport_Click(sender As Object, e As EventArgs) Handles btnOKPDFExport.Click
        Dim lk As LKTool = New LKTool()
        Dim DocRangeSolution As Integer
        Dim DocRangeNoSolution As Integer
        Dim StartNumSolution As Integer 'print from Page
        Dim StartNumNoSolution As Integer 'print from Page
        Dim EndNumSolution As Integer 'Print till page
        Dim EndNumNoSolution As Integer 'Print till page
        Dim ShowMarkupsSolution As Boolean
        Dim ShowMarkupsNoSolution As Boolean
        Dim OpenPDFFolder As Boolean




        'Set defaults for StartNum and EndNum
        StartNumSolution = 0
        StartNumNoSolution = 0
        EndNumSolution = 0
        EndNumNoSolution = 0


        'Define the DocRange based on the radio button or entered from / to textfields for No Solution
        If radSolutionAllPages.Checked = True Then
            DocRangeSolution = 0 'wdExportAllDocument()
        ElseIf radSolutionSelectedPages.Checked = True Then
            DocRangeSolution = 1 'wdExportSelection()
        ElseIf radSolutionCurrentPages.Checked = True Then
            DocRangeSolution = 2 'wdExportCurrentPage()
        ElseIf radSolutionRange.Checked = True And
            IsNumeric(txtPageFromSolution.Text) And
            IsNumeric(txtPageToSolution.Text) Then
            DocRangeSolution = 3 'wdExportFromTo()
            StartNumSolution = Int(txtPageFromSolution.Text)
            EndNumSolution = Int(txtPageToSolution.Text)
        Else
            DocRangeSolution = 0 'Should never happen
        End If

        'Define if markups for Solution should be shown in output
        If chkMarkupsSolution.Checked = True Then
            ShowMarkupsSolution = True
        Else
            ShowMarkupsSolution = False
        End If

        'Define if markups for No Solution should be shown in output
        If chkMarkupsNoSolution.Checked = True Then
            ShowMarkupsNoSolution = True
        Else
            ShowMarkupsNoSolution = False
        End If

        'Define if Solution should be opened after export
        If chkOpenPDFFolder.Checked = True Then
            OpenPDFFolder = True
        Else
            OpenPDFFolder = False
        End If


        'If checkbox equal is actived, then solution = NoSolution
        If chkPDFExportEqual.Checked = True Then
            DocRangeNoSolution = DocRangeSolution
            StartNumSolution = StartNumNoSolution
            EndNumNoSolution = EndNumSolution
            ShowMarkupsNoSolution = ShowMarkupsSolution
        Else
            'Define the DocRange based on the radio button or entered from / to textfields for No Solution
            If radNoSolutionAllPages.Checked = True Then
                DocRangeNoSolution = 0 'wdExportAllDocument()
            ElseIf radNoSolutionSelectedPages.Checked = True Then
                DocRangeNoSolution = 1 'wdExportSelection()
            ElseIf radNoSolutionCurrentPages.Checked = True Then
                DocRangeNoSolution = 2 'wdExportCurrentPage()
            ElseIf radNoSolutionRange.Checked = True And
                IsNumeric(txtPageFromNoSolution.Text) And
                IsNumeric(txtPageToNoSolution.Text) Then
                DocRangeNoSolution = 3 'wdExportFromTo()
                StartNumNoSolution = Int(txtPageFromNoSolution.Text)
                EndNumNoSolution = Int(txtPageToNoSolution.Text)
            Else
                DocRangeNoSolution = 0 'Should never happen
            End If
        End If

        'Close the form
        Me.Close()

        'Call the PDF Export
        lk.PDFExport(DocRangeSolution, StartNumSolution, EndNumSolution, _
                    ShowMarkupsSolution, _
                    DocRangeNoSolution, StartNumNoSolution, EndNumNoSolution, _
                    ShowMarkupsNoSolution, _
                    OpenPDFFolder)

    End Sub

    Private Sub btnCancelPDFExport_Click(sender As Object, e As EventArgs) Handles btnCancelPDFExport.Click


        Me.Close()
    End Sub

    Private Sub radSolutionAllPages_CheckedChanged(sender As Object, e As EventArgs) Handles radSolutionAllPages.CheckedChanged
        'Clear the page from and till
        txtPageFromSolution.Text = ""
        txtPageToSolution.Text = ""

    End Sub

    Private Sub radSolutionCurrentPages_CheckedChanged(sender As Object, e As EventArgs) Handles radSolutionCurrentPages.CheckedChanged
        'Clear the page from and till
        txtPageFromSolution.Text = ""
        txtPageToSolution.Text = ""
    End Sub

    Private Sub radSolutionSelectedPages_CheckedChanged(sender As Object, e As EventArgs) Handles radSolutionSelectedPages.CheckedChanged
        'Clear the page from and till
        txtPageFromSolution.Text = ""
        txtPageToSolution.Text = ""
    End Sub

End Class