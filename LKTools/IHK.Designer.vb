<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIHK
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIHK))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtMaxPoints = New System.Windows.Forms.TextBox()
        Me.lblMaxPoints = New System.Windows.Forms.Label()
        Me.lblGrade1 = New System.Windows.Forms.Label()
        Me.txtGrade1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGrade2 = New System.Windows.Forms.TextBox()
        Me.lblGrade2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGrade3 = New System.Windows.Forms.TextBox()
        Me.lblGrade3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGrade4 = New System.Windows.Forms.TextBox()
        Me.lblGrade4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtGrade5 = New System.Windows.Forms.TextBox()
        Me.lblGrade5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblGrade6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblErrorText = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkNoRounding = New System.Windows.Forms.CheckBox()
        Me.chk05Rounding = New System.Windows.Forms.CheckBox()
        Me.btnDefaultSettings = New System.Windows.Forms.Button()
        Me.GradeGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.radPercent = New System.Windows.Forms.RadioButton()
        Me.radPoints = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGradehart = New System.Windows.Forms.Button()
        Me.btnGradelinear = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GradeGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.HelpProvider1.SetHelpString(Me.btnOK, resources.GetString("btnOK.HelpString"))
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.HelpProvider1.SetShowHelp(Me.btnOK, CType(resources.GetObject("btnOK.ShowHelp"), Boolean))
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnCancel, resources.GetString("btnCancel.HelpString"))
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.HelpProvider1.SetShowHelp(Me.btnCancel, CType(resources.GetObject("btnCancel.ShowHelp"), Boolean))
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtMaxPoints
        '
        Me.HelpProvider1.SetHelpString(Me.txtMaxPoints, resources.GetString("txtMaxPoints.HelpString"))
        resources.ApplyResources(Me.txtMaxPoints, "txtMaxPoints")
        Me.txtMaxPoints.Name = "txtMaxPoints"
        Me.HelpProvider1.SetShowHelp(Me.txtMaxPoints, CType(resources.GetObject("txtMaxPoints.ShowHelp"), Boolean))
        '
        'lblMaxPoints
        '
        resources.ApplyResources(Me.lblMaxPoints, "lblMaxPoints")
        Me.lblMaxPoints.Name = "lblMaxPoints"
        '
        'lblGrade1
        '
        resources.ApplyResources(Me.lblGrade1, "lblGrade1")
        Me.HelpProvider1.SetHelpString(Me.lblGrade1, resources.GetString("lblGrade1.HelpString"))
        Me.lblGrade1.Name = "lblGrade1"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade1, CType(resources.GetObject("lblGrade1.ShowHelp"), Boolean))
        '
        'txtGrade1
        '
        Me.txtGrade1.BackColor = System.Drawing.SystemColors.Window
        Me.HelpProvider1.SetHelpString(Me.txtGrade1, resources.GetString("txtGrade1.HelpString"))
        resources.ApplyResources(Me.txtGrade1, "txtGrade1")
        Me.txtGrade1.Name = "txtGrade1"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade1, CType(resources.GetObject("txtGrade1.ShowHelp"), Boolean))
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtGrade2
        '
        Me.HelpProvider1.SetHelpString(Me.txtGrade2, resources.GetString("txtGrade2.HelpString"))
        resources.ApplyResources(Me.txtGrade2, "txtGrade2")
        Me.txtGrade2.Name = "txtGrade2"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade2, CType(resources.GetObject("txtGrade2.ShowHelp"), Boolean))
        '
        'lblGrade2
        '
        resources.ApplyResources(Me.lblGrade2, "lblGrade2")
        Me.HelpProvider1.SetHelpString(Me.lblGrade2, resources.GetString("lblGrade2.HelpString"))
        Me.lblGrade2.Name = "lblGrade2"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade2, CType(resources.GetObject("lblGrade2.ShowHelp"), Boolean))
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtGrade3
        '
        Me.HelpProvider1.SetHelpString(Me.txtGrade3, resources.GetString("txtGrade3.HelpString"))
        resources.ApplyResources(Me.txtGrade3, "txtGrade3")
        Me.txtGrade3.Name = "txtGrade3"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade3, CType(resources.GetObject("txtGrade3.ShowHelp"), Boolean))
        '
        'lblGrade3
        '
        resources.ApplyResources(Me.lblGrade3, "lblGrade3")
        Me.HelpProvider1.SetHelpString(Me.lblGrade3, resources.GetString("lblGrade3.HelpString"))
        Me.lblGrade3.Name = "lblGrade3"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade3, CType(resources.GetObject("lblGrade3.ShowHelp"), Boolean))
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtGrade4
        '
        Me.HelpProvider1.SetHelpString(Me.txtGrade4, resources.GetString("txtGrade4.HelpString"))
        resources.ApplyResources(Me.txtGrade4, "txtGrade4")
        Me.txtGrade4.Name = "txtGrade4"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade4, CType(resources.GetObject("txtGrade4.ShowHelp"), Boolean))
        '
        'lblGrade4
        '
        resources.ApplyResources(Me.lblGrade4, "lblGrade4")
        Me.HelpProvider1.SetHelpString(Me.lblGrade4, resources.GetString("lblGrade4.HelpString"))
        Me.lblGrade4.Name = "lblGrade4"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade4, CType(resources.GetObject("lblGrade4.ShowHelp"), Boolean))
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'txtGrade5
        '
        Me.HelpProvider1.SetHelpString(Me.txtGrade5, resources.GetString("txtGrade5.HelpString"))
        resources.ApplyResources(Me.txtGrade5, "txtGrade5")
        Me.txtGrade5.Name = "txtGrade5"
        Me.HelpProvider1.SetShowHelp(Me.txtGrade5, CType(resources.GetObject("txtGrade5.ShowHelp"), Boolean))
        '
        'lblGrade5
        '
        resources.ApplyResources(Me.lblGrade5, "lblGrade5")
        Me.HelpProvider1.SetHelpString(Me.lblGrade5, resources.GetString("lblGrade5.HelpString"))
        Me.lblGrade5.Name = "lblGrade5"
        Me.HelpProvider1.SetShowHelp(Me.lblGrade5, CType(resources.GetObject("lblGrade5.ShowHelp"), Boolean))
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'lblGrade6
        '
        resources.ApplyResources(Me.lblGrade6, "lblGrade6")
        Me.lblGrade6.Name = "lblGrade6"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblErrorText
        '
        resources.ApplyResources(Me.lblErrorText, "lblErrorText")
        Me.lblErrorText.ForeColor = System.Drawing.Color.Red
        Me.lblErrorText.Name = "lblErrorText"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGrade1)
        Me.GroupBox1.Controls.Add(Me.lblGrade1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblGrade2)
        Me.GroupBox1.Controls.Add(Me.lblGrade6)
        Me.GroupBox1.Controls.Add(Me.txtGrade2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGrade5)
        Me.GroupBox1.Controls.Add(Me.lblGrade3)
        Me.GroupBox1.Controls.Add(Me.lblGrade5)
        Me.GroupBox1.Controls.Add(Me.txtGrade3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtGrade4)
        Me.GroupBox1.Controls.Add(Me.lblGrade4)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkNoRounding)
        Me.GroupBox2.Controls.Add(Me.chk05Rounding)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'chkNoRounding
        '
        resources.ApplyResources(Me.chkNoRounding, "chkNoRounding")
        Me.HelpProvider1.SetHelpString(Me.chkNoRounding, resources.GetString("chkNoRounding.HelpString"))
        Me.chkNoRounding.Name = "chkNoRounding"
        Me.HelpProvider1.SetShowHelp(Me.chkNoRounding, CType(resources.GetObject("chkNoRounding.ShowHelp"), Boolean))
        Me.chkNoRounding.UseVisualStyleBackColor = True
        '
        'chk05Rounding
        '
        resources.ApplyResources(Me.chk05Rounding, "chk05Rounding")
        Me.HelpProvider1.SetHelpString(Me.chk05Rounding, resources.GetString("chk05Rounding.HelpString"))
        Me.chk05Rounding.Name = "chk05Rounding"
        Me.HelpProvider1.SetShowHelp(Me.chk05Rounding, CType(resources.GetObject("chk05Rounding.ShowHelp"), Boolean))
        Me.chk05Rounding.UseVisualStyleBackColor = True
        '
        'btnDefaultSettings
        '
        Me.btnDefaultSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnDefaultSettings, resources.GetString("btnDefaultSettings.HelpString"))
        resources.ApplyResources(Me.btnDefaultSettings, "btnDefaultSettings")
        Me.btnDefaultSettings.Name = "btnDefaultSettings"
        Me.HelpProvider1.SetShowHelp(Me.btnDefaultSettings, CType(resources.GetObject("btnDefaultSettings.ShowHelp"), Boolean))
        Me.btnDefaultSettings.TabStop = False
        Me.btnDefaultSettings.UseVisualStyleBackColor = True
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
        Me.HelpProvider1.SetHelpString(Me.GradeGraph, resources.GetString("GradeGraph.HelpString"))
        resources.ApplyResources(Me.GradeGraph, "GradeGraph")
        Me.GradeGraph.Name = "GradeGraph"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Name = "Series1"
        Me.GradeGraph.Series.Add(Series1)
        Me.HelpProvider1.SetShowHelp(Me.GradeGraph, CType(resources.GetObject("GradeGraph.ShowHelp"), Boolean))
        '
        'radPercent
        '
        resources.ApplyResources(Me.radPercent, "radPercent")
        Me.HelpProvider1.SetHelpString(Me.radPercent, resources.GetString("radPercent.HelpString"))
        Me.radPercent.Name = "radPercent"
        Me.HelpProvider1.SetShowHelp(Me.radPercent, CType(resources.GetObject("radPercent.ShowHelp"), Boolean))
        Me.radPercent.TabStop = True
        Me.radPercent.UseVisualStyleBackColor = True
        '
        'radPoints
        '
        resources.ApplyResources(Me.radPoints, "radPoints")
        Me.HelpProvider1.SetHelpString(Me.radPoints, resources.GetString("radPoints.HelpString"))
        Me.radPoints.Name = "radPoints"
        Me.HelpProvider1.SetShowHelp(Me.radPoints, CType(resources.GetObject("radPoints.ShowHelp"), Boolean))
        Me.radPoints.TabStop = True
        Me.radPoints.UseVisualStyleBackColor = True
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.HelpProvider1.SetHelpString(Me.Label6, resources.GetString("Label6.HelpString"))
        Me.Label6.Name = "Label6"
        Me.HelpProvider1.SetShowHelp(Me.Label6, CType(resources.GetObject("Label6.ShowHelp"), Boolean))
        '
        'btnGradehart
        '
        Me.btnGradehart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnGradehart, resources.GetString("btnGradehart.HelpString"))
        resources.ApplyResources(Me.btnGradehart, "btnGradehart")
        Me.btnGradehart.Name = "btnGradehart"
        Me.HelpProvider1.SetShowHelp(Me.btnGradehart, CType(resources.GetObject("btnGradehart.ShowHelp"), Boolean))
        Me.btnGradehart.UseVisualStyleBackColor = True
        '
        'btnGradelinear
        '
        Me.btnGradelinear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnGradelinear, resources.GetString("btnGradelinear.HelpString"))
        resources.ApplyResources(Me.btnGradelinear, "btnGradelinear")
        Me.btnGradelinear.Name = "btnGradelinear"
        Me.HelpProvider1.SetShowHelp(Me.btnGradelinear, CType(resources.GetObject("btnGradelinear.ShowHelp"), Boolean))
        Me.btnGradelinear.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGradelinear)
        Me.GroupBox3.Controls.Add(Me.btnGradehart)
        Me.GroupBox3.Controls.Add(Me.btnDefaultSettings)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'HelpProvider1
        '
        resources.ApplyResources(Me.HelpProvider1, "HelpProvider1")
        '
        'frmIHK
        '
        Me.AcceptButton = Me.btnOK
        Me.AllowDrop = True
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.radPoints)
        Me.Controls.Add(Me.radPercent)
        Me.Controls.Add(Me.GradeGraph)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblErrorText)
        Me.Controls.Add(Me.lblMaxPoints)
        Me.Controls.Add(Me.txtMaxPoints)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIHK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GradeGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtMaxPoints As System.Windows.Forms.TextBox
    Friend WithEvents lblMaxPoints As System.Windows.Forms.Label
    Friend WithEvents lblGrade1 As System.Windows.Forms.Label
    Friend WithEvents txtGrade1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGrade2 As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGrade3 As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGrade4 As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtGrade5 As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblGrade6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblErrorText As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkNoRounding As System.Windows.Forms.CheckBox
    Friend WithEvents chk05Rounding As System.Windows.Forms.CheckBox
    Friend WithEvents btnDefaultSettings As System.Windows.Forms.Button
    Friend WithEvents GradeGraph As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents radPercent As System.Windows.Forms.RadioButton
    Friend WithEvents radPoints As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnGradehart As System.Windows.Forms.Button
    Friend WithEvents btnGradelinear As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
