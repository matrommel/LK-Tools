<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDFExport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPDFExport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkMarkupsSolution = New System.Windows.Forms.CheckBox()
        Me.grpPDFExportSolution = New System.Windows.Forms.GroupBox()
        Me.radSolutionRange = New System.Windows.Forms.RadioButton()
        Me.radSolutionSelectedPages = New System.Windows.Forms.RadioButton()
        Me.radSolutionCurrentPages = New System.Windows.Forms.RadioButton()
        Me.radSolutionAllPages = New System.Windows.Forms.RadioButton()
        Me.txtPageToSolution = New System.Windows.Forms.TextBox()
        Me.txtPageFromSolution = New System.Windows.Forms.TextBox()
        Me.grpPDFExportNoSolution = New System.Windows.Forms.GroupBox()
        Me.radNoSolutionRange = New System.Windows.Forms.RadioButton()
        Me.radNoSolutionSelectedPages = New System.Windows.Forms.RadioButton()
        Me.radNoSolutionCurrentPages = New System.Windows.Forms.RadioButton()
        Me.radNoSolutionAllPages = New System.Windows.Forms.RadioButton()
        Me.txtPageToNoSolution = New System.Windows.Forms.TextBox()
        Me.txtPageFromNoSolution = New System.Windows.Forms.TextBox()
        Me.chkMarkupsNoSolution = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelPDFExport = New System.Windows.Forms.Button()
        Me.btnOKPDFExport = New System.Windows.Forms.Button()
        Me.chkPDFExportEqual = New System.Windows.Forms.CheckBox()
        Me.chkOpenPDFFolder = New System.Windows.Forms.CheckBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.grpPDFExportSolution.SuspendLayout()
        Me.grpPDFExportNoSolution.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seite"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "bis"
        '
        'chkMarkupsSolution
        '
        Me.chkMarkupsSolution.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkMarkupsSolution, "Legen Sie fest, ob die ""Lösung"" Kommentare enthalten soll.")
        Me.chkMarkupsSolution.Location = New System.Drawing.Point(11, 110)
        Me.chkMarkupsSolution.Margin = New System.Windows.Forms.Padding(1)
        Me.chkMarkupsSolution.Name = "chkMarkupsSolution"
        Me.HelpProvider1.SetShowHelp(Me.chkMarkupsSolution, True)
        Me.chkMarkupsSolution.Size = New System.Drawing.Size(127, 17)
        Me.chkMarkupsSolution.TabIndex = 2
        Me.chkMarkupsSolution.Text = "Kommentare drucken"
        Me.chkMarkupsSolution.UseVisualStyleBackColor = True
        '
        'grpPDFExportSolution
        '
        Me.grpPDFExportSolution.Controls.Add(Me.radSolutionRange)
        Me.grpPDFExportSolution.Controls.Add(Me.radSolutionSelectedPages)
        Me.grpPDFExportSolution.Controls.Add(Me.radSolutionCurrentPages)
        Me.grpPDFExportSolution.Controls.Add(Me.radSolutionAllPages)
        Me.grpPDFExportSolution.Controls.Add(Me.txtPageToSolution)
        Me.grpPDFExportSolution.Controls.Add(Me.txtPageFromSolution)
        Me.grpPDFExportSolution.Controls.Add(Me.Label1)
        Me.grpPDFExportSolution.Controls.Add(Me.Label2)
        Me.grpPDFExportSolution.Controls.Add(Me.chkMarkupsSolution)
        Me.grpPDFExportSolution.Location = New System.Drawing.Point(9, 58)
        Me.grpPDFExportSolution.Margin = New System.Windows.Forms.Padding(1)
        Me.grpPDFExportSolution.Name = "grpPDFExportSolution"
        Me.grpPDFExportSolution.Padding = New System.Windows.Forms.Padding(1)
        Me.grpPDFExportSolution.Size = New System.Drawing.Size(168, 139)
        Me.grpPDFExportSolution.TabIndex = 7
        Me.grpPDFExportSolution.TabStop = False
        Me.grpPDFExportSolution.Text = "Mit Lösung"
        '
        'radSolutionRange
        '
        Me.radSolutionRange.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radSolutionRange, "Legen Sie den ""von"" Seitenbereich der ""Lösung"" fest.")
        Me.radSolutionRange.Location = New System.Drawing.Point(11, 83)
        Me.radSolutionRange.Margin = New System.Windows.Forms.Padding(1)
        Me.radSolutionRange.Name = "radSolutionRange"
        Me.HelpProvider1.SetShowHelp(Me.radSolutionRange, True)
        Me.radSolutionRange.Size = New System.Drawing.Size(49, 17)
        Me.radSolutionRange.TabIndex = 29
        Me.radSolutionRange.TabStop = True
        Me.radSolutionRange.Text = "Seite"
        Me.radSolutionRange.UseVisualStyleBackColor = True
        '
        'radSolutionSelectedPages
        '
        Me.radSolutionSelectedPages.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radSolutionSelectedPages, "Wählen Sie diese Funktion aus um nur die aktuelle Auswahl der ""Lösung"" zu drucken" &
        ". Die Auswahl ist Inaktiv, falls nichts ausgewählt worden ist.")
        Me.radSolutionSelectedPages.Location = New System.Drawing.Point(11, 61)
        Me.radSolutionSelectedPages.Margin = New System.Windows.Forms.Padding(1)
        Me.radSolutionSelectedPages.Name = "radSolutionSelectedPages"
        Me.HelpProvider1.SetShowHelp(Me.radSolutionSelectedPages, True)
        Me.radSolutionSelectedPages.Size = New System.Drawing.Size(85, 17)
        Me.radSolutionSelectedPages.TabIndex = 28
        Me.radSolutionSelectedPages.TabStop = True
        Me.radSolutionSelectedPages.Text = "Nur Auswahl"
        Me.radSolutionSelectedPages.UseVisualStyleBackColor = True
        '
        'radSolutionCurrentPages
        '
        Me.radSolutionCurrentPages.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radSolutionCurrentPages, "Wählen Sie diese Funktion aus um nur die aktuelle Seiten der ""Lösung"" zu drucken." &
        "")
        Me.radSolutionCurrentPages.Location = New System.Drawing.Point(11, 39)
        Me.radSolutionCurrentPages.Margin = New System.Windows.Forms.Padding(1)
        Me.radSolutionCurrentPages.Name = "radSolutionCurrentPages"
        Me.HelpProvider1.SetShowHelp(Me.radSolutionCurrentPages, True)
        Me.radSolutionCurrentPages.Size = New System.Drawing.Size(109, 17)
        Me.radSolutionCurrentPages.TabIndex = 27
        Me.radSolutionCurrentPages.TabStop = True
        Me.radSolutionCurrentPages.Text = "Nur aktuelle Seite"
        Me.radSolutionCurrentPages.UseVisualStyleBackColor = True
        '
        'radSolutionAllPages
        '
        Me.radSolutionAllPages.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radSolutionAllPages, "Wählen Sie diese Funktion aus um alle Seiten der ""Lösung"" zu drucken.")
        Me.radSolutionAllPages.Location = New System.Drawing.Point(11, 20)
        Me.radSolutionAllPages.Margin = New System.Windows.Forms.Padding(1)
        Me.radSolutionAllPages.Name = "radSolutionAllPages"
        Me.HelpProvider1.SetShowHelp(Me.radSolutionAllPages, True)
        Me.radSolutionAllPages.Size = New System.Drawing.Size(75, 17)
        Me.radSolutionAllPages.TabIndex = 26
        Me.radSolutionAllPages.TabStop = True
        Me.radSolutionAllPages.Text = "Alle Seiten"
        Me.radSolutionAllPages.UseVisualStyleBackColor = True
        '
        'txtPageToSolution
        '
        Me.txtPageToSolution.BackColor = System.Drawing.SystemColors.Window
        Me.HelpProvider1.SetHelpString(Me.txtPageToSolution, "Legen Sie den ""bis"" Seitenbereich der ""Lösung"" fest.")
        Me.txtPageToSolution.Location = New System.Drawing.Point(122, 84)
        Me.txtPageToSolution.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPageToSolution.Name = "txtPageToSolution"
        Me.HelpProvider1.SetShowHelp(Me.txtPageToSolution, True)
        Me.txtPageToSolution.Size = New System.Drawing.Size(34, 20)
        Me.txtPageToSolution.TabIndex = 25
        Me.txtPageToSolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPageFromSolution
        '
        Me.txtPageFromSolution.BackColor = System.Drawing.SystemColors.Window
        Me.HelpProvider1.SetHelpString(Me.txtPageFromSolution, "Legen Sie den ""von"" Seitenbereich der ""Lösung"" fest.")
        Me.txtPageFromSolution.Location = New System.Drawing.Point(61, 84)
        Me.txtPageFromSolution.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPageFromSolution.Name = "txtPageFromSolution"
        Me.HelpProvider1.SetShowHelp(Me.txtPageFromSolution, True)
        Me.txtPageFromSolution.Size = New System.Drawing.Size(34, 20)
        Me.txtPageFromSolution.TabIndex = 24
        Me.txtPageFromSolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpPDFExportNoSolution
        '
        Me.grpPDFExportNoSolution.Controls.Add(Me.radNoSolutionRange)
        Me.grpPDFExportNoSolution.Controls.Add(Me.radNoSolutionSelectedPages)
        Me.grpPDFExportNoSolution.Controls.Add(Me.radNoSolutionCurrentPages)
        Me.grpPDFExportNoSolution.Controls.Add(Me.radNoSolutionAllPages)
        Me.grpPDFExportNoSolution.Controls.Add(Me.txtPageToNoSolution)
        Me.grpPDFExportNoSolution.Controls.Add(Me.txtPageFromNoSolution)
        Me.grpPDFExportNoSolution.Controls.Add(Me.chkMarkupsNoSolution)
        Me.grpPDFExportNoSolution.Controls.Add(Me.Label4)
        Me.grpPDFExportNoSolution.Location = New System.Drawing.Point(198, 58)
        Me.grpPDFExportNoSolution.Margin = New System.Windows.Forms.Padding(1)
        Me.grpPDFExportNoSolution.Name = "grpPDFExportNoSolution"
        Me.grpPDFExportNoSolution.Padding = New System.Windows.Forms.Padding(1)
        Me.grpPDFExportNoSolution.Size = New System.Drawing.Size(180, 139)
        Me.grpPDFExportNoSolution.TabIndex = 8
        Me.grpPDFExportNoSolution.TabStop = False
        Me.grpPDFExportNoSolution.Text = "Ohne Lösung"
        '
        'radNoSolutionRange
        '
        Me.radNoSolutionRange.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radNoSolutionRange, "Legen Sie den ""von"" Seitenbereich der ""Lösung"" fest.")
        Me.radNoSolutionRange.Location = New System.Drawing.Point(11, 83)
        Me.radNoSolutionRange.Margin = New System.Windows.Forms.Padding(1)
        Me.radNoSolutionRange.Name = "radNoSolutionRange"
        Me.HelpProvider1.SetShowHelp(Me.radNoSolutionRange, True)
        Me.radNoSolutionRange.Size = New System.Drawing.Size(49, 17)
        Me.radNoSolutionRange.TabIndex = 33
        Me.radNoSolutionRange.TabStop = True
        Me.radNoSolutionRange.Text = "Seite"
        Me.radNoSolutionRange.UseVisualStyleBackColor = True
        '
        'radNoSolutionSelectedPages
        '
        Me.radNoSolutionSelectedPages.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radNoSolutionSelectedPages, "Wählen Sie diese Funktion aus um nur die aktuelle Auswahl der ""Ohne Lösung"" zu dr" &
        "ucken. Die Auswahl ist Inaktiv, falls nichts ausgewählt worden ist.")
        Me.radNoSolutionSelectedPages.Location = New System.Drawing.Point(11, 61)
        Me.radNoSolutionSelectedPages.Margin = New System.Windows.Forms.Padding(1)
        Me.radNoSolutionSelectedPages.Name = "radNoSolutionSelectedPages"
        Me.HelpProvider1.SetShowHelp(Me.radNoSolutionSelectedPages, True)
        Me.radNoSolutionSelectedPages.Size = New System.Drawing.Size(85, 17)
        Me.radNoSolutionSelectedPages.TabIndex = 32
        Me.radNoSolutionSelectedPages.TabStop = True
        Me.radNoSolutionSelectedPages.Text = "Nur Auswahl"
        Me.radNoSolutionSelectedPages.UseVisualStyleBackColor = True
        '
        'radNoSolutionCurrentPages
        '
        Me.radNoSolutionCurrentPages.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radNoSolutionCurrentPages, "Wählen Sie diese Funktion aus um nur die aktuelle Seiten der ""Ohne Lösung"" zu dru" &
        "cken.")
        Me.radNoSolutionCurrentPages.Location = New System.Drawing.Point(11, 39)
        Me.radNoSolutionCurrentPages.Margin = New System.Windows.Forms.Padding(1)
        Me.radNoSolutionCurrentPages.Name = "radNoSolutionCurrentPages"
        Me.HelpProvider1.SetShowHelp(Me.radNoSolutionCurrentPages, True)
        Me.radNoSolutionCurrentPages.Size = New System.Drawing.Size(109, 17)
        Me.radNoSolutionCurrentPages.TabIndex = 31
        Me.radNoSolutionCurrentPages.TabStop = True
        Me.radNoSolutionCurrentPages.Text = "Nur aktuelle Seite"
        Me.radNoSolutionCurrentPages.UseVisualStyleBackColor = True
        '
        'radNoSolutionAllPages
        '
        Me.radNoSolutionAllPages.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.radNoSolutionAllPages, "Wählen Sie diese Funktion aus um alle Seiten der ""Ohne Lösung"" zu drucken.")
        Me.radNoSolutionAllPages.Location = New System.Drawing.Point(11, 20)
        Me.radNoSolutionAllPages.Margin = New System.Windows.Forms.Padding(1)
        Me.radNoSolutionAllPages.Name = "radNoSolutionAllPages"
        Me.HelpProvider1.SetShowHelp(Me.radNoSolutionAllPages, True)
        Me.radNoSolutionAllPages.Size = New System.Drawing.Size(75, 17)
        Me.radNoSolutionAllPages.TabIndex = 30
        Me.radNoSolutionAllPages.TabStop = True
        Me.radNoSolutionAllPages.Text = "Alle Seiten"
        Me.radNoSolutionAllPages.UseVisualStyleBackColor = True
        '
        'txtPageToNoSolution
        '
        Me.txtPageToNoSolution.BackColor = System.Drawing.SystemColors.Window
        Me.HelpProvider1.SetHelpString(Me.txtPageToNoSolution, "Legen Sie den ""bis"" Seitenbereich der ""Ohne Lösung"" fest.")
        Me.txtPageToNoSolution.Location = New System.Drawing.Point(122, 84)
        Me.txtPageToNoSolution.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPageToNoSolution.Name = "txtPageToNoSolution"
        Me.HelpProvider1.SetShowHelp(Me.txtPageToNoSolution, True)
        Me.txtPageToNoSolution.Size = New System.Drawing.Size(34, 20)
        Me.txtPageToNoSolution.TabIndex = 29
        Me.txtPageToNoSolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPageFromNoSolution
        '
        Me.txtPageFromNoSolution.BackColor = System.Drawing.SystemColors.Window
        Me.HelpProvider1.SetHelpString(Me.txtPageFromNoSolution, "Legen Sie den ""von"" Seitenbereich der ""Ohne Lösung"" fest.")
        Me.txtPageFromNoSolution.Location = New System.Drawing.Point(61, 84)
        Me.txtPageFromNoSolution.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPageFromNoSolution.Name = "txtPageFromNoSolution"
        Me.HelpProvider1.SetShowHelp(Me.txtPageFromNoSolution, True)
        Me.txtPageFromNoSolution.Size = New System.Drawing.Size(34, 20)
        Me.txtPageFromNoSolution.TabIndex = 28
        Me.txtPageFromNoSolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkMarkupsNoSolution
        '
        Me.chkMarkupsNoSolution.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkMarkupsNoSolution, "Legen Sie fest, ob die ""Ohne Lösung"" Kommentare enthalten soll.")
        Me.chkMarkupsNoSolution.Location = New System.Drawing.Point(11, 110)
        Me.chkMarkupsNoSolution.Margin = New System.Windows.Forms.Padding(1)
        Me.chkMarkupsNoSolution.Name = "chkMarkupsNoSolution"
        Me.HelpProvider1.SetShowHelp(Me.chkMarkupsNoSolution, True)
        Me.chkMarkupsNoSolution.Size = New System.Drawing.Size(127, 17)
        Me.chkMarkupsNoSolution.TabIndex = 2
        Me.chkMarkupsNoSolution.Text = "Kommentare drucken"
        Me.chkMarkupsNoSolution.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "bis"
        '
        'btnCancelPDFExport
        '
        Me.btnCancelPDFExport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btnCancelPDFExport, "Schließt das Dialogfenster")
        Me.btnCancelPDFExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelPDFExport.Location = New System.Drawing.Point(302, 209)
        Me.btnCancelPDFExport.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelPDFExport.Name = "btnCancelPDFExport"
        Me.HelpProvider1.SetShowHelp(Me.btnCancelPDFExport, True)
        Me.btnCancelPDFExport.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelPDFExport.TabIndex = 23
        Me.btnCancelPDFExport.Text = "Abbrechen"
        Me.btnCancelPDFExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelPDFExport.UseVisualStyleBackColor = True
        '
        'btnOKPDFExport
        '
        Me.btnOKPDFExport.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.HelpProvider1.SetHelpString(Me.btnOKPDFExport, "Startet den PDF Export.")
        Me.btnOKPDFExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOKPDFExport.Location = New System.Drawing.Point(218, 209)
        Me.btnOKPDFExport.Margin = New System.Windows.Forms.Padding(1)
        Me.btnOKPDFExport.Name = "btnOKPDFExport"
        Me.HelpProvider1.SetShowHelp(Me.btnOKPDFExport, True)
        Me.btnOKPDFExport.Size = New System.Drawing.Size(76, 22)
        Me.btnOKPDFExport.TabIndex = 22
        Me.btnOKPDFExport.Text = "OK"
        Me.btnOKPDFExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOKPDFExport.UseVisualStyleBackColor = True
        '
        'chkPDFExportEqual
        '
        Me.chkPDFExportEqual.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkPDFExportEqual, "Legen Sie fest, ob die Einstellungen für ""Lösung"" und ""Ohne Lösung"" identisch sei" &
        "n sollen.")
        Me.chkPDFExportEqual.Location = New System.Drawing.Point(18, 35)
        Me.chkPDFExportEqual.Margin = New System.Windows.Forms.Padding(1)
        Me.chkPDFExportEqual.Name = "chkPDFExportEqual"
        Me.HelpProvider1.SetShowHelp(Me.chkPDFExportEqual, True)
        Me.chkPDFExportEqual.Size = New System.Drawing.Size(184, 17)
        Me.chkPDFExportEqual.TabIndex = 6
        Me.chkPDFExportEqual.Text = "Gleiche Einstellungen verwenden"
        Me.chkPDFExportEqual.UseVisualStyleBackColor = True
        '
        'chkOpenPDFFolder
        '
        Me.chkOpenPDFFolder.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkOpenPDFFolder, "Legen Sie fest, ob der Ausgabe-Ordner nach der Erstellung geöffnet werden soll.")
        Me.chkOpenPDFFolder.Location = New System.Drawing.Point(18, 12)
        Me.chkOpenPDFFolder.Margin = New System.Windows.Forms.Padding(1)
        Me.chkOpenPDFFolder.Name = "chkOpenPDFFolder"
        Me.HelpProvider1.SetShowHelp(Me.chkOpenPDFFolder, True)
        Me.chkOpenPDFFolder.Size = New System.Drawing.Size(209, 17)
        Me.chkOpenPDFFolder.TabIndex = 24
        Me.chkOpenPDFFolder.Text = "Ausgabe-Ordner nach Export anzeigen"
        Me.chkOpenPDFFolder.UseVisualStyleBackColor = True
        '
        'frmPDFExport
        '
        Me.AcceptButton = Me.btnOKPDFExport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelPDFExport
        Me.ClientSize = New System.Drawing.Size(397, 249)
        Me.Controls.Add(Me.chkOpenPDFFolder)
        Me.Controls.Add(Me.chkPDFExportEqual)
        Me.Controls.Add(Me.btnCancelPDFExport)
        Me.Controls.Add(Me.btnOKPDFExport)
        Me.Controls.Add(Me.grpPDFExportNoSolution)
        Me.Controls.Add(Me.grpPDFExportSolution)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPDFExport"
        Me.Text = "PDF Export Einstellungen"
        Me.grpPDFExportSolution.ResumeLayout(False)
        Me.grpPDFExportSolution.PerformLayout()
        Me.grpPDFExportNoSolution.ResumeLayout(False)
        Me.grpPDFExportNoSolution.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkMarkupsSolution As System.Windows.Forms.CheckBox
    Friend WithEvents grpPDFExportSolution As System.Windows.Forms.GroupBox
    Friend WithEvents grpPDFExportNoSolution As System.Windows.Forms.GroupBox
    Friend WithEvents chkMarkupsNoSolution As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelPDFExport As System.Windows.Forms.Button
    Friend WithEvents btnOKPDFExport As System.Windows.Forms.Button
    Friend WithEvents chkPDFExportEqual As System.Windows.Forms.CheckBox
    Friend WithEvents txtPageToSolution As System.Windows.Forms.TextBox
    Friend WithEvents txtPageFromSolution As System.Windows.Forms.TextBox
    Friend WithEvents txtPageToNoSolution As System.Windows.Forms.TextBox
    Friend WithEvents txtPageFromNoSolution As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents radSolutionSelectedPages As System.Windows.Forms.RadioButton
    Friend WithEvents radSolutionCurrentPages As System.Windows.Forms.RadioButton
    Friend WithEvents radSolutionAllPages As System.Windows.Forms.RadioButton
    Friend WithEvents radNoSolutionSelectedPages As System.Windows.Forms.RadioButton
    Friend WithEvents radNoSolutionCurrentPages As System.Windows.Forms.RadioButton
    Friend WithEvents radNoSolutionAllPages As System.Windows.Forms.RadioButton
    Friend WithEvents chkOpenPDFFolder As System.Windows.Forms.CheckBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents radSolutionRange As System.Windows.Forms.RadioButton
    Friend WithEvents radNoSolutionRange As System.Windows.Forms.RadioButton
End Class
