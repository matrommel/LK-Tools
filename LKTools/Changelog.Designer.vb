<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangelog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangelog))
        Me.txtChangelog = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtChangelog
        '
        Me.txtChangelog.BackColor = System.Drawing.SystemColors.Window
        Me.txtChangelog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChangelog.Location = New System.Drawing.Point(0, 0)
        Me.txtChangelog.Name = "txtChangelog"
        Me.txtChangelog.ReadOnly = True
        Me.txtChangelog.Size = New System.Drawing.Size(1172, 702)
        Me.txtChangelog.TabIndex = 0
        Me.txtChangelog.Text = ""
        '
        'frmChangelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1172, 702)
        Me.Controls.Add(Me.txtChangelog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChangelog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LKTools Changelog"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtChangelog As System.Windows.Forms.RichTextBox
End Class
