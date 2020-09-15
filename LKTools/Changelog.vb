Public Class frmChangelog

    'show the changelog in a textbox
    Private Sub frmChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim content As String = My.Resources.Changelog

        'Change the Title of the form
        Me.Text = My.Application.Info.ProductName & _
            " Änderungsprotokoll " & _
            "( V." & String.Format(My.Application.Info.Version.ToString) & ")"

        'Update the txtbox with the changelog.txt content
        txtChangelog.Text = content
    End Sub
End Class