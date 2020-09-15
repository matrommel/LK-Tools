Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text.RegularExpressions 'Need for checking the strings


Public Class frmIHK
    'Load window frmIHK
    Private Sub frmIHK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim grade(4) As Integer
        Dim maxPoints As Integer
        'Get default application settings

        If LKTool.maxPoints > 0.0 Then
            maxPoints = LKTool.maxPoints
        Else
            maxPoints = 1
        End If

        chk05Rounding.Checked = LKTool.Rounding05
        chkNoRounding.Checked = LKTool.NoRounding

        'Fill the scales with IHK %
        If LKTool.gradeTEMP(0) > 0 Then
            txtGrade1.Text = LKTool.gradeTEMP(0)
            txtGrade2.Text = LKTool.gradeTEMP(1)
            txtGrade3.Text = LKTool.gradeTEMP(2)
            txtGrade4.Text = LKTool.gradeTEMP(3)
            txtGrade5.Text = LKTool.gradeTEMP(4)
        Else
            txtGrade1.Text = LKTool.grade(0)
            txtGrade2.Text = LKTool.grade(1)
            txtGrade3.Text = LKTool.grade(2)
            txtGrade4.Text = LKTool.grade(3)
            txtGrade5.Text = LKTool.grade(4)
        End If
        txtMaxPoints.Text = maxPoints

        'Diagramm erstellen
        radPercent.Checked = True 'Standardmäßig wird Wert in Prozent angezeigt.
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If

    End Sub

    'Add/update the diagram
    Private Sub AddGradeGraph()
        GradeGraph.Series.Clear()
        '  PointGraph.Titles.Add("Notenskala")
        'Create a new series and add data points to it.
        Dim s As New Series
        Dim t As New Series
        Dim points As Single
        Dim i As Single

        points = CInt(txtMaxPoints.Text)

        If radPercent.Checked = True Then
            i = 100
        ElseIf radPoints.Checked = True Then
            i = points
        End If

        'actual Line 
        s.Points.AddXY("1", i)
        'Rounding: If exact calculation or no calculation is actived, this value is shown, else a 0.5 rounding is done.
        If chkNoRounding.Checked = True Or _
            chkNoRounding.Checked = False And chk05Rounding.Checked = False Then
            s.Points.AddXY("2", Math.Round(i * CInt(txtGrade1.Text) / 100, 1))
            s.Points.AddXY("3", Math.Round(i * CInt(txtGrade2.Text) / 100, 1))
            s.Points.AddXY("4", Math.Round(i * CInt(txtGrade3.Text) / 100, 1))
            s.Points.AddXY("5", Math.Round(i * CInt(txtGrade4.Text) / 100, 1))
            s.Points.AddXY("6", Math.Round(i * CInt(txtGrade5.Text) / 100, 1))
        Else
            s.Points.AddXY("2", ((Math.Round((i * CInt(txtGrade1.Text) / 100) * 2, MidpointRounding.AwayFromZero)) / 2))
            s.Points.AddXY("3", ((Math.Round((i * CInt(txtGrade2.Text) / 100) * 2, MidpointRounding.AwayFromZero)) / 2))
            s.Points.AddXY("4", ((Math.Round((i * CInt(txtGrade3.Text) / 100) * 2, MidpointRounding.AwayFromZero)) / 2))
            s.Points.AddXY("5", ((Math.Round((i * CInt(txtGrade4.Text) / 100) * 2, MidpointRounding.AwayFromZero)) / 2))
            s.Points.AddXY("6", ((Math.Round((i * CInt(txtGrade5.Text) / 100) * 2, MidpointRounding.AwayFromZero)) / 2))
        End If
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
        s.XValueType = ChartValueType.Int32
        s.YValueType = ChartValueType.Single
        s.LabelForeColor = Drawing.Color.Black
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

        If radPercent.Checked = True Then
            GradeGraph.ChartAreas(0).AxisY.Title = "Prozent"
        ElseIf radPoints.Checked = True Then
            GradeGraph.ChartAreas(0).AxisY.Title = "Punkte"
        End If

        GradeGraph.ChartAreas(0).AxisY.TitleAlignment = Drawing.StringAlignment.Far
        GradeGraph.ChartAreas(0).AxisY.TextOrientation = TextOrientation.Auto

        'Add the series to the Chart1 control.
        GradeGraph.Series.Add(t)
        GradeGraph.Series.Add(s)
    End Sub

    'Action for OK Button (confirm and validate)
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim lk As LKTool = New LKTool()
        Dim maxPoints As Single
        Dim check As Boolean
        Dim grade(4) As Integer
        Dim bgColor As Drawing.Color
        Dim i, j As System.Windows.Forms.Control

        'Define the default background color
        bgColor = Drawing.Color.Orange

        'Set check to false 
        check = False

        'Set background of textfield to white everytime the button is clicked
        txtMaxPoints.BackColor = Drawing.Color.White

        For myTempCount = 1 To 5
            i = GroupBox1.Controls("txtGrade" & myTempCount)
            i.BackColor = Drawing.Color.White
        Next

        'Check if output is defined
        If chk05Rounding.Checked = False And chkNoRounding.Checked = False Then
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Keine 'Ausgabe' ausgewählt"
        Else
            check = True
        End If

        If check = True Then
            'Call the function to check if value is numeric and > 0
            If checkNumericHigher0(txtMaxPoints.Text) = False Then
                txtMaxPoints.SelectAll()
                txtMaxPoints.BackColor = bgColor
                check = False
            End If

            If check = True Then
                'Loop through all txtGrade(i) and check if the sorting is correct.
                For myTempCount = 1 To 5
                    i = GroupBox1.Controls("txtGrade" & myTempCount)

                    If checkNumericHigher0(i.Text) = False Then
                        i.Select()
                        i.BackColor = bgColor
                        check = False
                        Exit For
                    End If
                Next
            End If
        End If

            'Call the function to check if percentage value is < 100
        If check = True Then
            For myTempCount = 1 To 5
                i = GroupBox1.Controls("txtGrade" & myTempCount)

                If checkUnder100Percent(i.Text) = False Then
                    i.Select()
                    i.BackColor = bgColor
                    check = False
                    Exit For
                End If
            Next
        End If

        If check = True Then
            'Loop through all txtGrade(i) and check if the sorting is correct.
            For myTempCount = 1 To 4
                i = GroupBox1.Controls("txtGrade" & myTempCount)
                j = GroupBox1.Controls("txtGrade" & myTempCount + 1)

                If i.Text <= j.Text Then
                    check = False
                    i.Select()
                    i.BackColor = bgColor
                    lblErrorText.Visible = True
                    lblErrorText.ForeColor = Drawing.Color.Red
                    lblErrorText.Text = "Note " & myTempCount & " muss größer als Note " & myTempCount + 1 & " sein."
                    Exit For
                End If
            Next
        End If

        'Close the window and start the calculating of the grades
        If check = True Then

            maxPoints = Convert.ToSingle(txtMaxPoints.Text)
            For myTempCount = 1 To 5
                i = GroupBox1.Controls("txtGrade" & myTempCount)
                grade(myTempCount - 1) = CInt(i.Text)
            Next


            'Overwrite the application settings
            For myTempCount = 0 To 4
                i = GroupBox1.Controls("txtGrade" & myTempCount)
                LKTool.gradeTEMP(myTempCount) = grade(myTempCount)
            Next
            LKTool.maxPoints = CSng(txtMaxPoints.Text)
            LKTool.Rounding05TEMP = chk05Rounding.Checked
            LKTool.NoRoundingTEMP = chkNoRounding.Checked
            lk.createIHK(maxPoints)
            Me.Close()

        End If
    End Sub

    'Action for CANCEL Button (confirm and validate)
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Action for DEFAULT Button (confirm and validate)
    Private Sub btnDefaultSettings_Click(sender As Object, e As EventArgs) Handles btnDefaultSettings.Click
        cleanErrorMessage()

        txtGrade1.Text = LKTool.grade(0)
        txtGrade2.Text = LKTool.grade(1)
        txtGrade3.Text = LKTool.grade(2)
        txtGrade4.Text = LKTool.grade(3)
        txtGrade5.Text = LKTool.grade(4)
        chk05Rounding.Checked = LKTool.Rounding05
        chkNoRounding.Checked = LKTool.NoRounding

        If CheckMissingValues() = True Then
            AddGradeGraph()
        Else
            radPercent.Checked = True
        End If
    End Sub

    'Update Graph if txtGrade changes
    Private Sub txtGrade1_TextChanged(sender As Object, e As EventArgs) Handles txtGrade1.LostFocus
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If

    End Sub

    'Update Graph if txtGrade changes
    Private Sub txtGrade2_TextChanged(sender As Object, e As EventArgs) Handles txtGrade2.LostFocus
          If CheckMissingValues() = True Then
            AddGradeGraph()
        End If

    End Sub

    'Update Graph if txtGrade changes
    Private Sub txtGrade3_TextChanged(sender As Object, e As EventArgs) Handles txtGrade3.LostFocus
          If CheckMissingValues() = True Then
            AddGradeGraph()
        End If

    End Sub

    'Update Graph if txtGrade changes
    Private Sub txtGrade4_TextChanged(sender As Object, e As EventArgs) Handles txtGrade4.LostFocus
           If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if txtGrade changes
    Private Sub txtGrade5_TextChanged(sender As Object, e As EventArgs) Handles txtGrade5.LostFocus
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if maxPoints changes
    Private Sub txtMaxPoints_TextChanged(sender As Object, e As EventArgs) Handles txtMaxPoints.LostFocus
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if radioButton changes
    Private Sub radPercent_CheckedChanged(sender As Object, e As EventArgs) Handles radPercent.CheckedChanged
        cleanErrorMessage()
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if radioButton changes
    Private Sub radPoints_CheckedChanged(sender As Object, e As EventArgs) Handles radPoints.CheckedChanged
        Dim inputtext As String
        Dim bgColor As Drawing.Color

        cleanErrorMessage()

        'Define the default background color
        bgColor = Drawing.Color.Orange
        inputtext = txtMaxPoints.Text

        If CheckMissingValues() = True Then
            AddGradeGraph()
        Else
            radPercent.Checked = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Auswahl nicht möglich, da Punktzahl fehlt."
        End If

    End Sub

    'Check if a value is missing
    Function CheckMissingValues()

        If txtMaxPoints.Text <= "0" Then
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Maximale Punktzahl muss größer 0 sein."
            Return False
        ElseIf IsNumeric(txtMaxPoints.Text) = False Then
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Maximale Punktzahl muss eine Zahl sein."
            Return False
        ElseIf Regex.IsMatch(txtGrade1.Text, "^[0-9]+$") And _
                Regex.IsMatch(txtGrade2.Text, "^[0-9]+$") And _
                Regex.IsMatch(txtGrade3.Text, "^[0-9]+$") And _
                Regex.IsMatch(txtGrade4.Text, "^[0-9]+$") And _
                Regex.IsMatch(txtGrade5.Text, "^[0-9]+$") And _
                Regex.IsMatch(txtMaxPoints.Text, "^[0-9]+$") Then
            cleanErrorMessage()
            Return True
        Else
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Es darf kein Wert fehlen."
            Return False
        End If
    End Function

    'Function Check if value is numeric and higher 0
    Private Function checkNumericHigher0(i As String)
        Dim check As Boolean = False

        If IsNumeric(i) = True Then
            If i > 0 Then
                check = True
            Else
                check = False
                lblErrorText.Visible = True
                lblErrorText.ForeColor = Drawing.Color.Red
                lblErrorText.Text = "Zahl muss größer 0 sein."
            End If
        ElseIf IsNumeric(i) = False Then
            check = False
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Bitte geben Sie eine positive Zahl ein."
        End If
        Return (check)

    End Function

    ' function for checking if the percentage is lower equal 100
    Private Function checkUnder100Percent(i As String)
        Dim check As Boolean = False

        If CInt(i) < 100 Then
            check = True
        Else
            check = False
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Wert muss zwischen 0 und 100 liegen"
        End If


        Return (check)
    End Function

    Private Function checkGradePosition(i As Integer, j As Integer)

        If i <= j Then
            lblErrorText.Visible = True
            lblErrorText.ForeColor = Drawing.Color.Red
            lblErrorText.Text = "Note " & i & " muss größer als Note " & j & " sein."
            Return (False)
        Else
            Return (True)
        End If

    End Function

    'Action if the linear Grade Button is clicked
    Private Sub btnGradelinear_Click(sender As Object, e As EventArgs) Handles btnGradelinear.Click
        cleanErrorMessage()

        txtGrade1.Text = 83
        txtGrade2.Text = 67
        txtGrade3.Text = 50
        txtGrade4.Text = 33
        txtGrade5.Text = 17

        If CheckMissingValues() = True Then
            AddGradeGraph()
        Else
            radPercent.Checked = True
        End If
    End Sub

    'Action if the degressiv Grade Button is clicked
    Private Sub btnGradehart_Click(sender As Object, e As EventArgs) Handles btnGradehart.Click
        cleanErrorMessage()

        txtGrade1.Text = 92
        txtGrade2.Text = 81
        txtGrade3.Text = 67
        txtGrade4.Text = 50
        txtGrade5.Text = 30

        If CheckMissingValues() = True Then
            AddGradeGraph()
        Else
            radPercent.Checked = True
        End If
    End Sub

    'Clean the error message
    Private Sub cleanErrorMessage()
        lblErrorText.Visible = False
        lblErrorText.ForeColor = Drawing.Color.White
    End Sub

    'Update Graph if the checkbox value changes
    Private Sub chk05Rounding_CheckedChanged(sender As Object, e As EventArgs) Handles chk05Rounding.CheckedChanged
        cleanErrorMessage()
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub

    'Update Graph if the checkbox value changes
    Private Sub chkNoRounding_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoRounding.CheckedChanged
        cleanErrorMessage()
        If CheckMissingValues() = True Then
            AddGradeGraph()
        End If
    End Sub


End Class