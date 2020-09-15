Option Explicit On

Imports Microsoft.Office.Tools.Ribbon
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop.Word
Imports MSXML2
Imports System.IO
Imports System.IO.File
Imports System.Reflection
Imports System.Drawing
Imports System.Diagnostics
Imports System.Text.RegularExpressions 'Need for checking the
Imports System.Math


'Sync MABRDE

Public Class LKTool
    '#######################################################
    'LK-Tools - make lessons preperation more efficient
    '#######################################################
    'Created by: Matthias Rommel (based on original idea and macro from W. Henning)
    'Kontakt: software@info-rommel.de
    'Create date: 2017-02-17
    '########################################################

    'Globale Variablen Definieren

    '##Allgemein
    Public Shared LKToolsVersion As String 'Version is nchkMCAllignRighteed for updating the XML
    Public Shared ColorVisible As Long '= RGB(255, 0, 0) 'Defines the color that should be hidden
    Public Shared ColorHidden As Long '= RGB(255, 255, 254) 'Defines the color that should be hidden
    Public Shared ObjectTextColor As Long 'Farbe für Textobjekte
    Public Shared chkShape As Boolean 'defines if Shapes should be checked
    Public Shared chkLine As Boolean 'defines if Lines should be checked
    Public Shared chkUnderline As Boolean 'defines if Underlines should be checked
    Public Shared InformAboutHiddenObjects As Boolean 'Infofenster, über ausgeblendete Objekte
    Public Shared InformAboutHiddenObjectsTime As Integer 'Dauer der Anzeige in Sekunden

    '##Objekte --> Vorlagen
    'Several Buttons in tab objects
    Public Shared RedTextboxButton As Boolean 'defines if Button "linierte Vorlage" should be visible
    Public Shared RevisionPageButton As Boolean 'defines if Button "Revision Page" should be visible
    Public Shared chkRevisionPrint As Boolean 'defines if checkbox revision print is activated
    Public Shared ExcerciseButton As Boolean 'defines if Button "Aufgabe" should be visible
    Public Shared ExamButton As Boolean 'defines if Button "P. Aufgabe" should be visible
    '#### Ruled Template
    Public Shared RuledButton As Boolean 'defines if Button "linierte Vorlage" should be visible
    Public Shared RuledSpacing As Single ' Dim height As Single = 0.75 'cm 
    Public Shared RuledRows As Integer 'dim rows as integer 
    Public Shared RuledStyle As Integer 'Style of the template
    Public Shared RuledStyleWidth As Integer 'Style of the template width
    '#### Graph Template
    Public Shared GraphButton As Boolean 'defines if Button "karierte Vorlage" should be visible
    Public Shared GraphRows As Integer 'dim rows as integer 
    Public Shared Graphwidth As Single 'Dim cellwidth As Single = 0.5 'Default width cm 

    '##Objekte --> Aufgaben
    '#### MC Template
    Public Shared MCButton As Boolean 'defines if Button "MC Aufgabe" should be visible
    Public Shared MCRows As Integer  'defines the default number of MC rows
    Public Shared chkMCAllignRight As Boolean 'defines if MC checkbox is right or left of the text.
    '#### True/False Template
    Public Shared TrueFalseButton As Boolean 'defines if Button "Richtig/Falsch" should be visible
    Public Shared TrueFalseRows As Integer  'defines the default number of true/false rows
    Public Shared TrueFalseTrueDesc As String 'defines the description for true shown in the table header
    Public Shared TrueFalseFalseDesc As String 'defines the description for false shown in the table header
    Public Shared TrueFalseReason As Boolean 'defines if reasons should be visible or not
    Public Shared TrueFalseReasonDesc As String 'defines the description for reason shown in the table header
    '#### Add Solution Template
    Public Shared AddSolution As Boolean 'Defines if a textbox with an remark for an "Solution" should be insert automatically
    Public Shared SolutionDescription As String 'Defines the text of the textbox

    '##Objekte --> Noten
    Public Shared GradeButton As Boolean 'defines if Button "Noten" should be visible
    Public Shared grade(4) As Integer
    Public Shared gradeTEMP(4) As Integer
    Public Shared Rounding05 As Boolean
    Public Shared Rounding05TEMP As Boolean
    Public Shared NoRounding As Boolean
    Public Shared NoRoundingTEMP As Boolean
    Public Shared maxPoints As Single

    '##Objekte --> Pfad
    Public Shared PathButton As Boolean 'defines if Button "Path" should be visible
    Public Shared PathOption As Integer 'Defines how the path should be shown
    Public Shared PathNumberFolders As Integer 'Defines how the path should be shown
    Public Shared PathAddDocumentName As Boolean 'Defines if the document name should be exported

    '##Objekte --> Überlagerung
    Public Shared ShowOverlayFunction As Boolean 'defines if Button "Richtig/Falsch" should be visible
    Public Shared OverlayTransparency As Integer  'defines the default number of MC rows
    Public Shared ColorOverlay As Long '= RGB(255, 255, 254) 'Defines the color that should be hidden

    '##Ausgabe
    Public Shared QuickPrint As Boolean
    Public Shared PrintSolution As Boolean
    Public Shared PrintNoSolution As Boolean
    Public Shared pdfExportSettings As Integer
    Public Shared pdfSolutionText As String
    Public Shared pdfNoSolutionText As String
    Public Shared pdfSubFolderText As String
    Public Shared pdfPathText As String
    Public Shared ExtendedPDFButton As Boolean
    Public Shared ShowExtendedPDFSettings As Boolean
    Public Shared chkPDFExportEqual As Boolean
    Public Shared chkPDFMarkupsSolution As Boolean
    Public Shared chkPDFMarkupsNoSolution As Boolean
    Public Shared chkOpenPDFFolder As Boolean
    Public Shared chkDescriptionPositionSuffix As Boolean ' True is suffix should be used
    Public Shared chkPrintHiddenTextButton As Boolean 'Shows/Hide the chkPrintHiddenText Button

    '##Update
    Public Shared UpdateInterval As Integer
    Public Shared LastUpdate As Date

    'Get the default user application folder via ENVIRON("AppData")
    Public Shared myFolder As String = Environ("LOCALAPPDATA") & "\LKTools"  'C:\Users\TEST\AppData\Local
    Public Shared myFile As String = myFolder & "\LKTools_Settings.xml"

    Public Shared chkPrintSolutionTemp As Boolean
    Public Shared chkPrintNoSolutionTemp As Boolean

    Public Shared chkPDFRevisionTemp As Boolean

    'Load LKTools
    Private Sub LKTools_Load(sender As Object, e As Microsoft.Office.Tools.Ribbon.RibbonUIEventArgs) Handles MyBase.Load
        '#######################################################
        'While starting the add in, it is checked if Text or Shapes are already hidden. 
        'If so, then the toogle Button will be checked. If not the tooglebutton remains unchecked
        'The xml for the settings is created and loaded
        '########################################################

        If Not CreateObject("Scripting.FileSystemObject").FolderExists(LKTool.myFolder) Then
            CreateObject("Scripting.FileSystemObject").CreateFolder(LKTool.myFolder)
        End If
        If Not CreateObject("Scripting.FilesystemObject").FileExists(LKTool.myFile) Then
            Create_XML()
            'MsgBox("LKTools hat eine Einstellungsdatei wurde in " & LKTools.myFolder & " gespeichert.")
        End If

        Update_XML()
        LoadXML()

        'Set the output checkboxes after xml is loaded
        If LKTool.PrintSolution = True Then
            chkSolution.Checked = True
            chkPrintSolutionTemp = True
        Else
            chkSolution.Checked = False
            chkPrintSolutionTemp = False
        End If

        If LKTool.PrintNoSolution = True Then
            chkNoSolution.Checked = True
            chkPrintNoSolutionTemp = True
        Else
            chkNoSolution.Checked = False
            chkPrintNoSolutionTemp = False
        End If

        If LKTool.chkRevisionPrint = True Then
            chkPDFRevision.Checked = True
            chkPDFRevisionTemp = True
        Else
            chkPDFRevision.Checked = False
            chkPDFRevisionTemp = False
        End If

    End Sub

    'Function after document is loaded
    Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Check for updates
        Dim i As Integer

        i = DateDiff("d", LastUpdate, Now())
        'i = InputBox("Überschreibe " & i) ' für Testzwecke

        If i > UpdateInterval Then
            Check_Updates(0)
        End If

        'If the start screen is shown, the check is not executed
        If Globals.ThisAddIn.Application.Documents.Count >= 1 Then
            CheckHidden() 'Call the function and allow to show the infomessage if activated
            MessageHiddenObjects() 'Call the function and allow to show the infomessage if activated
        End If

        If Globals.ThisAddIn.Application.Options.PrintHiddenText = True Then
            chkPrintHiddenText.Checked = True
        Else
            chkPrintHiddenText.Checked = False
        End If


    End Sub

    'Write or delete Document properties "Status"
    Sub WritePropertiesStatus(Write As Boolean)
        'Setzen der Dokumenten Properties
        Dim properties As Microsoft.Office.Core.DocumentProperties

        'Festlegen der Dokument Properties Variable
        properties = DirectCast(Globals.ThisAddIn.Application.ActiveDocument.BuiltInDocumentProperties,
            Microsoft.Office.Core.DocumentProperties)

        ' Setzen des Dokumenten Status bzw. hinzufügen.
        If Write = True Then
            properties.Item("content status").Value = "ContentHidden"
        Else
            properties.Item("content status").Value = ""
        End If
    End Sub

    'Get Document properties "Status"
    Function GetPropertiesStatus()
        'Setzen der Dokumenten Properties
        Dim properties As Microsoft.Office.Core.DocumentProperties

        'Festlegen der Dokument Properties Variable
        properties = DirectCast(Globals.ThisAddIn.Application.ActiveDocument.BuiltInDocumentProperties,
            Microsoft.Office.Core.DocumentProperties)

        Return properties.Item("content status").Value
    End Function

    'Create the XML File
    Public Sub Create_XML()
        Dim objDom As MSXML2.DOMDocument60
        Dim objVersion As MSXML2.IXMLDOMProcessingInstruction
        Dim objRootElem As MSXML2.IXMLDOMElement
        Dim objMemberName As MSXML2.IXMLDOMElement

        objDom = New MSXML2.DOMDocument60

        'Set the XML Version
        objVersion = objDom.createProcessingInstruction("xml", "version=""1.0"" encoding=""utf-8""")
        objDom.appendChild(objVersion)

        ' Creates root element
        objRootElem = objDom.createElement("LKTools")
        objDom.appendChild(objRootElem)
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        'Globale Variablen Definieren
        'Allgmein
        objMemberName = objDom.createElement("LKToolsVersion")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = My.Application.Info.Version.ToString
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("ColorVisible")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "255" 'Saved as OLE Color
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("ColorHidden")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "16711679" 'Saved as OLE Color
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("ObjectTextColor")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "0" 'Saved as OLE Color
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("ShowInformation")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("HideShapes")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("HideLines")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("HideUnderline")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("InformAboutHiddenObjects")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("InformAboutHiddenObjectsTime")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "3"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        'Objekte --> Vorlagen
        objMemberName = objDom.createElement("RedTextboxButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("RevisionPageButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("chkRevisionPrint")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("ExcerciseButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("ExamButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        '##Graph Template
        objMemberName = objDom.createElement("GraphButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("GraphWidth")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "0,5"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("GraphRows")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "10"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        '##Ruled Template
        objMemberName = objDom.createElement("RuledButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("RuledSpacing")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "0,75"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("RuledRows")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "10"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("RuledStyle")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "1"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("RuledStyleWidth")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "4"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        'Objekte --> Aufgaben
        '##MC Template
        objMemberName = objDom.createElement("MCButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("MCRows")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "1"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("chkMCAllignRight")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        '##True False Template


        objMemberName = objDom.createElement("TrueFalseButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("TrueFalseRows")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "1"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("TrueFalseTrueDesc")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "Richtig"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("TrueFalseFalseDesc")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "Falsch"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("TrueFalseReason")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("TrueFalseReasonDesc")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "Begründung"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        '##Add Solution Template
        objMemberName = objDom.createElement("AddSolution")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("SolutionDescription")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "Lösungs- vorschlag"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        'Objekte --> Noten
        objMemberName = objDom.createElement("GradeButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("factorGrade1")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "92"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("factorGrade2")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "81"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("factorGrade3")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "67"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("factorGrade4")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "50"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("factorGrade5")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "30"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("GradeScaleRounding")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("GradeScaleExact")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        '## Objekte --> Überlagerung
        objMemberName = objDom.createElement("ShowOverlayFunction")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("ColorOverlay")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "15191472" 'Saved as OLE Color
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch


        objMemberName = objDom.createElement("OverlayTransparency")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "0"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        'Pfad
        objMemberName = objDom.createElement("PathButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("PathOption")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "1" '1 = Full Path 2 = rel Path 3 = No Path
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("PathNumberFolders")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "1"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("PathAddDocumentName")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        'Ausgabe
        objMemberName = objDom.createElement("QuickPrint")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("PrintSolution")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("PrintNoSolution")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("pdfExportSettings")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "1" '1 = Same Folder 2 = Subfolder 3 = Path
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("pdfSolutionText")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "_Lösung"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("pdfNoSolutionText")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "_Schüler"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("pdfSubFolderText")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "PDF"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("ExtendedPDFButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("ShowExtendedPDFSettings")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("chkPDFExportEqual")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("chkPDFMarkupsSolution")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("chkPDFMarkupsNoSolution")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("chkOpenPDFFolder")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("chkDescriptionPositionSuffix")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "True"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("chkPrintHiddenTextButton")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "False"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        'Get local document folder
        objMemberName = objDom.createElement("pdfPathText")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "c:" & Environ("HOMEPATH")
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        'Update
        objMemberName = objDom.createElement("UpdateInterval")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = "30"
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

        objMemberName = objDom.createElement("LastUpdate")
        objRootElem.appendChild(objMemberName)
        objMemberName.text = Now()
        objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch


        ' Saves XML data to disk.
        objDom.save(LKTool.myFile)
        objDom = Nothing

    End Sub

    'Update LKTools
    Public Sub Update_XML()
        Dim objDom As MSXML2.DOMDocument60
        Dim objRootElem As MSXML2.IXMLDOMElement
        Dim objMemberName As MSXML2.IXMLDOMElement
        Dim root As Object
        Dim point As MSXML2.IXMLDOMNode
        Dim UpdateXML As Boolean

        objDom = New MSXML2.DOMDocument60
        objDom.async = False 'Dokument wird erst vollständig geladen

        'Create all child elements if not exist
        If objDom.load(LKTool.myFile) Then
            ' get root element
            objRootElem = objDom.documentElement
            root = objDom.documentElement
            point = root.firstChild

            If point.selectSingleNode("//LKToolsVersion") Is Nothing Then
                objMemberName = objDom.createElement("LKToolsVersion")
                objRootElem.appendChild(objMemberName)
                objMemberName.text = My.Application.Info.Version.ToString
                objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                UpdateXML = True
                Show_Changelog() 'Show the new features on sourceforge page
            ElseIf point.selectSingleNode("//LKToolsVersion").text <> My.Application.Info.Version.ToString Then
                objMemberName = point.selectSingleNode("//LKToolsVersion")
                ' objDom.selectSingleNode("LKToolsVersion")
                'getElementsByTagName("LKToolsVersion")
                objMemberName.text = My.Application.Info.Version.ToString
                UpdateXML = True
                Show_Changelog() 'Show the new features on sourceforge page
            Else
                UpdateXML = False
            End If

            If UpdateXML = True Then

                'Globale Variablen Definieren
                'Allgemein
                If point.selectSingleNode("//ColorVisible") Is Nothing Then
                    objMemberName = objDom.createElement("ColorVisible")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "255" 'Saved as OLE Color
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//ColorHidden") Is Nothing Then
                    objMemberName = objDom.createElement("ColorHidden")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "16711679" 'Saved as OLE Color
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//ObjectTextColor") Is Nothing Then
                    objMemberName = objDom.createElement("ObjectTextColor")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "0" 'Saved as OLE Color
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//ShowInformation") Is Nothing Then
                    objMemberName = objDom.createElement("ShowInformation")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//HideShapes") Is Nothing Then
                    objMemberName = objDom.createElement("HideShapes")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//HideLines") Is Nothing Then
                    objMemberName = objDom.createElement("HideLines")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//HideUnderline") Is Nothing Then
                    objMemberName = objDom.createElement("HideUnderline")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//InformAboutHiddenObjects") Is Nothing Then
                    objMemberName = objDom.createElement("InformAboutHiddenObjects")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//InformAboutHiddenObjectsTime") Is Nothing Then
                    objMemberName = objDom.createElement("InformAboutHiddenObjectsTime")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "3"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                'Objekte --> Vorlagen
                If point.selectSingleNode("//RedTextboxButton") Is Nothing Then
                    objMemberName = objDom.createElement("RedTextboxButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//RevisionPageButton") Is Nothing Then
                    objMemberName = objDom.createElement("RevisionPageButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//chkRevisionPrint") Is Nothing Then
                    objMemberName = objDom.createElement("chkRevisionPrint")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//ExcerciseButton") Is Nothing Then
                    objMemberName = objDom.createElement("ExcerciseButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//ExamButton") Is Nothing Then
                    objMemberName = objDom.createElement("ExamButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                '## ruled template
                If point.selectSingleNode("//RuledButton") Is Nothing Then
                    objMemberName = objDom.createElement("RuledButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//RuledSpacing") Is Nothing Then
                    objMemberName = objDom.createElement("RuledSpacing")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "0,75"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//RuledRows") Is Nothing Then
                    objMemberName = objDom.createElement("RuledRows")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "10"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//RuledStyle") Is Nothing Then
                    objMemberName = objDom.createElement("RuledStyle")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "1"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//RuledStyleWidth") Is Nothing Then
                    objMemberName = objDom.createElement("RuledStyleWidth")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "4"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                '##graph Template
                If point.selectSingleNode("//GraphButton") Is Nothing Then
                    objMemberName = objDom.createElement("GraphButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//GraphWidth") Is Nothing Then
                    objMemberName = objDom.createElement("GraphWidth")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "0,5"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//GraphRows") Is Nothing Then
                    objMemberName = objDom.createElement("GraphRows")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "10"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                'Objekte --> Aufgaben
                '## MC
                If point.selectSingleNode("//MCButton") Is Nothing Then
                    objMemberName = objDom.createElement("MCButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//MCRows") Is Nothing Then
                    objMemberName = objDom.createElement("MCRows")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "1"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//chkMCAllignRight") Is Nothing Then
                    objMemberName = objDom.createElement("chkMCAllignRight")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                '## True/False
                If point.selectSingleNode("//TrueFalseButton") Is Nothing Then
                    objMemberName = objDom.createElement("TrueFalseButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//TrueFalseRows") Is Nothing Then
                    objMemberName = objDom.createElement("TrueFalseRows")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "1"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//TrueFalseTrueDesc") Is Nothing Then
                    objMemberName = objDom.createElement("TrueFalseTrueDesc")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "Richtig"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//TrueFalseFalseDesc") Is Nothing Then
                    objMemberName = objDom.createElement("TrueFalseFalseDesc")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "Falsch"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//TrueFalseReason") Is Nothing Then
                    objMemberName = objDom.createElement("TrueFalseReason")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//TrueFalseReasonDesc") Is Nothing Then
                    objMemberName = objDom.createElement("TrueFalseReasonDesc")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "Begründung"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If


                '## Add Solution
                If point.selectSingleNode("//AddSolution") Is Nothing Then
                    objMemberName = objDom.createElement("AddSolution")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//SolutionDescription") Is Nothing Then
                    objMemberName = objDom.createElement("SolutionDescription")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "Lösungs- vorschlag"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                'Objekte --> Noten
                If point.selectSingleNode("//GradeButton") Is Nothing Then
                    objMemberName = objDom.createElement("GradeButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//factorGrade1") Is Nothing Then
                    objMemberName = objDom.createElement("factorGrade1")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "92"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//factorGrade2") Is Nothing Then
                    objMemberName = objDom.createElement("factorGrade2")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "81"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//factorGrade3") Is Nothing Then
                    objMemberName = objDom.createElement("factorGrade3")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "67"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//factorGrade4") Is Nothing Then
                    objMemberName = objDom.createElement("factorGrade4")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "50"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//factorGrade5") Is Nothing Then
                    objMemberName = objDom.createElement("factorGrade5")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "30"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//GradeScaleRounding") Is Nothing Then
                    objMemberName = objDom.createElement("GradeScaleRounding")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//GradeScaleExact") Is Nothing Then
                    objMemberName = objDom.createElement("GradeScaleExact")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                'Objekte --> Pfad

                If point.selectSingleNode("//PathButton") Is Nothing Then
                    objMemberName = objDom.createElement("PathButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//PathOption") Is Nothing Then
                    objMemberName = objDom.createElement("PathOption")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "1" '1 = Same folder 2 = Subfolder 3 = Path
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//PathNumberFolders") Is Nothing Then
                    objMemberName = objDom.createElement("PathNumberFolders")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "1" '1 = Same folder 2 = Subfolder 3 = Path
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//PathAddDocumentName") Is Nothing Then
                    objMemberName = objDom.createElement("PathAddDocumentName")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                '## Objekte --> Präsentation
                If point.selectSingleNode("//ShowOverlayFunction") Is Nothing Then

                    objMemberName = objDom.createElement("ShowOverlayFunction")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch

                End If

                If point.selectSingleNode("//ColorOverlay") Is Nothing Then
                    objMemberName = objDom.createElement("ColorOverlay")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "15191472" 'Saved as OLE Color
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If


                If point.selectSingleNode("//OverlayTransparency") Is Nothing Then
                    objMemberName = objDom.createElement("OverlayTransparency")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "0"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                'Ausgabe
                If point.selectSingleNode("//QuickPrint") Is Nothing Then
                    objMemberName = objDom.createElement("QuickPrint")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//PrintSolution") Is Nothing Then
                    objMemberName = objDom.createElement("PrintSolution")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//PrintNoSolution") Is Nothing Then
                    objMemberName = objDom.createElement("PrintNoSolution")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//pdfExportSettings") Is Nothing Then
                    objMemberName = objDom.createElement("pdfExportSettings")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "1" '1 = Same folder 2 = Subfolder 3 = Path
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//pdfSolutionText") Is Nothing Then
                    objMemberName = objDom.createElement("pdfSolutionText")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "_Lösung"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//pdfNoSolutionText") Is Nothing Then
                    objMemberName = objDom.createElement("pdfNoSolutionText")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "_Schüler"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//pdfSubFolderText") Is Nothing Then
                    objMemberName = objDom.createElement("pdfSubFolderText")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "PDF"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If


                If point.selectSingleNode("//pdfPathText") Is Nothing Then
                    objMemberName = objDom.createElement("pdfPathText")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "c:" & Environ("HOMEPATH")
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//ExtendedPDFButton") Is Nothing Then
                    objMemberName = objDom.createElement("ExtendedPDFButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//ShowExtendedPDFSettings") Is Nothing Then
                    objMemberName = objDom.createElement("ShowExtendedPDFSettings")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//chkPDFExportEqual") Is Nothing Then
                    objMemberName = objDom.createElement("chkPDFExportEqual")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//chkPDFMarkupsSolution") Is Nothing Then
                    objMemberName = objDom.createElement("chkPDFMarkupsSolution")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//chkPDFMarkupsNoSolution") Is Nothing Then
                    objMemberName = objDom.createElement("chkPDFMarkupsNoSolution")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//chkOpenPDFFolder") Is Nothing Then
                    objMemberName = objDom.createElement("chkOpenPDFFolder")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//chkDescriptionPositionSuffix") Is Nothing Then
                    objMemberName = objDom.createElement("chkDescriptionPositionSuffix")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "True"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//chkPrintHiddenTextButton") Is Nothing Then
                    objMemberName = objDom.createElement("chkPrintHiddenTextButton")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "False"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If


                'Update
                If point.selectSingleNode("//UpdateInterval") Is Nothing Then
                    objMemberName = objDom.createElement("UpdateInterval")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = "30"
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If

                If point.selectSingleNode("//LastUpdate") Is Nothing Then
                    objMemberName = objDom.createElement("LastUpdate")
                    objRootElem.appendChild(objMemberName)
                    objMemberName.text = Now()
                    objRootElem.appendChild(objDom.createTextNode(vbCrLf)) 'Zeilenumbruch
                End If
            End If

            ' Saves XML data to disk.
            objDom.save(LKTool.myFile)
            objDom = Nothing
        End If

    End Sub

    'Read der XML Datei
    Public Sub LoadXML()
        Dim xDoc As MSXML2.DOMDocument60
        Dim strErrText As String
        Dim xPE As MSXML2.IXMLDOMParseError
        Dim root As Object
        Dim point As MSXML2.IXMLDOMNode

        xDoc = New MSXML2.DOMDocument60
        xDoc.async = False 'Dokument wird erst vollständig geladen

        If xDoc.load(LKTool.myFile) Then
            root = xDoc.documentElement
            point = root.firstChild

            'Globale Variablen Definieren
            'Allgemein
            LKToolsVersion = point.selectSingleNode("//LKToolsVersion").text
            ColorVisible = Val(point.selectSingleNode("//ColorVisible").text)
            ColorHidden = Val(point.selectSingleNode("//ColorHidden").text)
            ObjectTextColor = Val(point.selectSingleNode("//ObjectTextColor").text)
            chkShape = point.selectSingleNode("//HideShapes").text
            chkLine = point.selectSingleNode("//HideLines").text
            chkUnderline = point.selectSingleNode("//HideUnderline").text
            InformAboutHiddenObjects = point.selectSingleNode("//InformAboutHiddenObjects").text
            InformAboutHiddenObjectsTime = point.selectSingleNode("//InformAboutHiddenObjectsTime").text

            'Objekte --> Vorlagen
            RedTextboxButton = point.selectSingleNode("//RedTextboxButton").text
            RevisionPageButton = point.selectSingleNode("//RevisionPageButton").text
            chkRevisionPrint = point.selectSingleNode("//chkRevisionPrint").text
            ExcerciseButton = point.selectSingleNode("//ExcerciseButton").text
            ExamButton = point.selectSingleNode("//ExamButton").text

            '## Ruled Template
            RuledButton = point.selectSingleNode("//RuledButton").text
            RuledSpacing = CSng(point.selectSingleNode("//RuledSpacing").text)
            RuledRows = Int(point.selectSingleNode("//RuledRows").text)
            RuledStyle = Int(point.selectSingleNode("//RuledStyle").text)
            RuledStyleWidth = Int(point.selectSingleNode("//RuledStyleWidth").text)

            '## Graph Template
            GraphButton = point.selectSingleNode("//GraphButton").text
            GraphRows = Int(point.selectSingleNode("//GraphRows").text)
            Graphwidth = CSng(point.selectSingleNode("//GraphWidth").text)

            'Objekte --> Aufgaben
            '## MC
            MCButton = point.selectSingleNode("//MCButton").text
            MCRows = Int(point.selectSingleNode("//MCRows").text)
            chkMCAllignRight = point.selectSingleNode("//chkMCAllignRight").text

            '## True / False
            TrueFalseButton = point.selectSingleNode("//TrueFalseButton").text
            TrueFalseRows = Int(point.selectSingleNode("//TrueFalseRows").text)
            TrueFalseTrueDesc = point.selectSingleNode("//TrueFalseTrueDesc").text
            TrueFalseFalseDesc = point.selectSingleNode("//TrueFalseFalseDesc").text
            TrueFalseReason = point.selectSingleNode("//TrueFalseReason").text
            TrueFalseReasonDesc = point.selectSingleNode("//TrueFalseReasonDesc").text

            '## Add solution
            AddSolution = point.selectSingleNode("//AddSolution").text
            SolutionDescription = point.selectSingleNode("//SolutionDescription").text

            'Objekte --> Noten
            GradeButton = point.selectSingleNode("//GradeButton").text
            grade(0) = Int(point.selectSingleNode("//factorGrade1").text)
            grade(1) = Int(point.selectSingleNode("//factorGrade2").text)
            grade(2) = Int(point.selectSingleNode("//factorGrade3").text)
            grade(3) = Int(point.selectSingleNode("//factorGrade4").text)
            grade(4) = (point.selectSingleNode("//factorGrade5").text)
            Rounding05 = point.selectSingleNode("//GradeScaleRounding").text
            NoRounding = point.selectSingleNode("//GradeScaleExact").text

            'Objekte --> Pfad
            PathButton = point.selectSingleNode("//PathButton").text
            PathOption = point.selectSingleNode("//PathOption").text
            PathNumberFolders = point.selectSingleNode("//PathNumberFolders").text
            PathAddDocumentName = point.selectSingleNode("//PathAddDocumentName").text

            'Objekte --> Präsentation
            ShowOverlayFunction = point.selectSingleNode("//ShowOverlayFunction").text
            OverlayTransparency = Int(point.selectSingleNode("//OverlayTransparency").text)
            ColorOverlay = Val(point.selectSingleNode("//ColorOverlay").text)

            'Ausgabe
            QuickPrint = point.selectSingleNode("//QuickPrint").text
            PrintSolution = point.selectSingleNode("//PrintSolution").text
            PrintNoSolution = point.selectSingleNode("//PrintNoSolution").text
            pdfExportSettings = point.selectSingleNode("//pdfExportSettings").text
            pdfSolutionText = point.selectSingleNode("//pdfSolutionText").text
            pdfNoSolutionText = point.selectSingleNode("//pdfNoSolutionText").text
            pdfSubFolderText = point.selectSingleNode("//pdfSubFolderText").text
            pdfPathText = point.selectSingleNode("//pdfPathText").text
            ExtendedPDFButton = point.selectSingleNode("//ExtendedPDFButton").text
            ShowExtendedPDFSettings = point.selectSingleNode("//ShowExtendedPDFSettings").text
            chkPDFExportEqual = point.selectSingleNode("//chkPDFExportEqual").text
            chkPDFMarkupsSolution = point.selectSingleNode("//chkPDFMarkupsSolution").text
            chkPDFMarkupsNoSolution = point.selectSingleNode("//chkPDFMarkupsNoSolution").text
            chkOpenPDFFolder = point.selectSingleNode("//chkOpenPDFFolder").text
            chkDescriptionPositionSuffix = point.selectSingleNode("//chkDescriptionPositionSuffix").text
            chkPrintHiddenTextButton = point.selectSingleNode("//chkPrintHiddenTextButton").text

            'Update
            UpdateInterval = point.selectSingleNode("//UpdateInterval").text
            LastUpdate = CDate(point.selectSingleNode("//LastUpdate").text)

        Else
            ' Obtain the ParseError object
            xPE = xDoc.parseError
            With xPE
                strErrText = "LKTools XML Dokument konnte nicht geladen werden." & vbCrLf &
                  "Error #: " & .errorCode & ": " & xPE.reason &
                  "Line #: " & .line & vbCrLf &
                  "Line Position: " & .linepos & vbCrLf &
                  "Position In File: " & .filepos & vbCrLf &
                  "Source Text: " & .srcText & vbCrLf &
                  "Document URL: " & .url & vbCrLf &
                  vbCrLf &
                  "Lösung: " & vbCrLf &
                  "Lösche die XML Datei und starte MS Word erneut. Persönliche Einstellungen werden zurückgesetzt."
            End With
            MsgBox(strErrText, vbExclamation, "LKTools")
        End If

        showInsertButtons()
    End Sub

    'Action for button EINBLENDEN
    Private Sub btnShow_Click(sender As Object, e As RibbonControlEventArgs) Handles btnShow.Click
        '#######################################################
        'by M. Rommel and W. Henning (original idea)
        'Hide all red text and shapes having red background or outline.
        'Shapes are also hidden, if the text color is is not red
        '#######################################################
        ShowObjectsAndTexts()
    End Sub

    'Show the objects and texts
    Sub ShowObjectsAndTexts()
        Dim rngStory As Word.Range
        Dim pFindTxt As String
        Dim pReplaceTxt As String
        Dim lngJunk As Long
        Dim oShp As Word.Shape
        pFindTxt = ""
        Dim document As Word.Document
        Dim msoTrue = Office.MsoTriState.msoTrue
        Dim msoFalse = Office.MsoTriState.msoFalse
        Dim iShapeAmount As Integer 'Save Number of total shapes
        Dim iShapeCurrent As Integer 'save remaining number of shapes

        'Freeze screen
        Globals.ThisAddIn.Application.ScreenUpdating = False


        document = Globals.ThisAddIn.Application.ActiveDocument

        'Fix the skipped blank Header/Footer problem
        lngJunk = document.Sections(1).Headers(1).Range.StoryType
        'Iterate through all story types in the current document

        'Iterate through all story types in the current document
        For Each rngStory In document.StoryRanges
            'Iterate through all linked stories
            Do
                SearchAndReplaceInStoryLoesungEinblenden(rngStory, pFindTxt, pFindTxt)
                On Error Resume Next
                Select Case rngStory.StoryType
                    Case 1, 6, 7, 8, 9, 10, 11 'MARODE: add "1" for red shapes https://msdn.microsoft.com/de-de/library/office/ff844990.aspx
                        iShapeAmount = rngStory.ShapeRange.Count
                        iShapeCurrent = iShapeAmount
                        If rngStory.ShapeRange.Count > 0 Then
                            For Each oShp In rngStory.ShapeRange
                                If oShp.Visible = True Then
                                    If rngStory.Find.Font.Color = ColorHidden And oShp.TextFrame.HasText Then
                                        SearchAndReplaceInStoryLoesungEinblenden(oShp.TextFrame.TextRange,
                                                pFindTxt, pFindTxt)
                                    End If
                                End If
                            Next
                            For Each oShp In rngStory.ShapeRange
                                If oShp.Visible = False Then
                                    If oShp.Fill.ForeColor.RGB = ColorHidden And chkShape = True Then
                                        oShp.Fill.ForeColor.RGB = ColorVisible
                                        oShp.Visible = True
                                    ElseIf oShp.Line.ForeColor.RGB = ColorHidden And chkLine = True Then
                                        oShp.Line.ForeColor.RGB = ColorVisible
                                        oShp.Visible = True
                                    End If

                                    'Decrement the amount of shapes
                                    iShapeCurrent = iShapeCurrent - 1

                                    If iShapeCurrent Mod 10 = 0 Then
                                        'Call sub for showing progess bar.
                                        showProgressBar(iShapeCurrent, iShapeAmount, "Objekte einblenden")
                                    End If

                                End If
                            Next
                            '#######################################################
                            '#######################################################
                            '#######################################################

                        End If
                    Case Else
                        'Do Nothing
                End Select
                On Error GoTo 0
                'Get next linked story (if any)
                rngStory = rngStory.NextStoryRange
            Loop Until rngStory Is Nothing
        Next
        CheckHidden() 'Check if hidden elements exists


        'Freeze screen
        Globals.ThisAddIn.Application.ScreenUpdating = True

    End Sub

    'Action for button AUSBLENDEN
    Private Sub btnHide_Click(sender As Object, e As RibbonControlEventArgs) Handles btnHide.Click
        '#######################################################
        'by M. Rommel and W. Henning (original idea)
        'Show all red text and shapes having red background or outline.
        'Shapes are also hidden, if the text color is is not red
        '#######################################################
        HideObjectsAndTexts()

    End Sub

    'Hide the objects and texts
    Sub HideObjectsAndTexts()
        Dim rngStory As Word.Range
        Dim pFindTxt As String
        Dim pReplaceTxt As String
        Dim lngJunk As Long
        Dim oShp As Word.Shape
        pFindTxt = ""
        Dim document As Word.Document
        Dim msoTrue = Office.MsoTriState.msoTrue
        Dim msoFalse = Office.MsoTriState.msoFalse
        Dim iShapeAmount As Integer 'Save Number of total shapes
        Dim iShapeCurrent As Integer 'save remaining number of shapes

        document = Globals.ThisAddIn.Application.ActiveDocument


        'Freeze screen
        Globals.ThisAddIn.Application.ScreenUpdating = False

        If isDocumentExtensionDocx() = True Then
            HideOverlay()
        End If

        'Fix the skipped blank Header/Footer problem
        lngJunk = document.Sections(1).Headers(1).Range.StoryType
        'Iterate through all story types in the current document
        For Each rngStory In document.StoryRanges
            'Iterate through all linked stories
            Do
                SearchAndReplaceInStoryLoesungAusblenden(rngStory, pFindTxt, pFindTxt)
                On Error Resume Next
                Select Case rngStory.StoryType
                    Case 1, 6, 7, 8, 9, 10, 11   'add "1" for red shapes https://msdn.microsoft.com/de-de/library/office/ff844990.aspx
                        iShapeAmount = rngStory.ShapeRange.Count
                        iShapeCurrent = iShapeAmount
                        If rngStory.ShapeRange.Count > 0 Then
                            For Each oShp In rngStory.ShapeRange
                                If oShp.Visible = True Then
                                    '#######################################################
                                    'Hide all shapes having red background or outline.
                                    'Shapes are also hidden, if the text color is is not red
                                    '#######################################################
                                    If oShp.Fill.ForeColor.RGB = ColorVisible And chkShape = True Then
                                        oShp.Fill.ForeColor.RGB = ColorHidden
                                        oShp.Visible = False
                                    ElseIf oShp.Line.ForeColor.RGB = ColorVisible And chkLine = True Then
                                        oShp.Line.ForeColor.RGB = ColorHidden
                                        oShp.Visible = False
                                    End If
                                End If

                                'Decrement the amount of shapes
                                iShapeCurrent = iShapeCurrent - 1

                                If iShapeCurrent Mod 10 = 0 Then
                                    'Call sub for showing progess bar.
                                    showProgressBar(iShapeCurrent, iShapeAmount, "Objekte ausblenden")
                                End If
                            Next

                            For Each oShp In rngStory.ShapeRange
                                If oShp.Visible = True And rngStory.Find.Font.Color = ColorVisible And oShp.TextFrame.HasText Then
                                    SearchAndReplaceInStoryLoesungAusblenden(oShp.TextFrame.TextRange,
                                          pFindTxt, pFindTxt)
                                End If
                            Next
                        End If
                    Case Else
                        'Do Nothing
                End Select
                On Error GoTo 0
                'Get next linked story (if any)
                rngStory = rngStory.NextStoryRange
            Loop Until rngStory Is Nothing
        Next
        CheckHidden() 'Check if hidden elements exists


        'Freeze screen
        Globals.ThisAddIn.Application.ScreenUpdating = True

    End Sub

    'The toggle Button Icon to check hidden text or objects
    Private Sub tglBtnCheck_Click(sender As Object, e As RibbonControlEventArgs) Handles tglBtnCheck.Click
        '#######################################################
        ''If the button is clicked, the function Chechhidden() is executed
        '#######################################################
        CheckHidden()
    End Sub

    'Check if anything is hidden
    Private Sub CheckHidden()
        '#######################################################
        'This function checks if text, shapes or outline objects are hidden. 
        'If so, then the toogle Button will be checked. If not the tooglebutton remains unchecked
        '########################################################
        Dim rngStory As Word.Range
        Dim document As Word.Document
        Dim Found As Boolean = False

        document = Globals.ThisAddIn.Application.ActiveDocument
        rngStory = document.Content

        For Each rngStory In document.StoryRanges
            'Iterate through all linked stories
            Do
                rngStory.Find.ClearFormatting()
                rngStory.Find.Font.Color = ColorHidden
                With rngStory.Find
                    .Text = ""
                    .Replacement.Text = ""
                    .Forward = True
                    .Wrap = Word.WdFindWrap.wdFindContinue
                    .Format = True
                    .MatchCase = False
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                If rngStory.Find.Execute() = True Then 'If something is found, then set value "Found" to true
                    Found = True
                    Exit For
                Else
                    rngStory.Find.ClearFormatting()
                    rngStory.Find.Font.UnderlineColor = ColorHidden
                    With rngStory.Find
                        .Text = ""
                        .Replacement.Text = ""
                        .Forward = True
                        .Wrap = Word.WdFindWrap.wdFindContinue
                        .Format = True
                        .MatchCase = False
                        .MatchWholeWord = False
                        .MatchWildcards = False
                        .MatchSoundsLike = False
                        .MatchAllWordForms = False
                    End With
                    If rngStory.Find.Execute() = True Then 'If something is found, then set value "Found" to true
                        Found = True
                        Exit For
                    End If
                End If

                If Found = False Then
                    'Check if any hidden shape or line is found. If so, then set value "Found" to true
                    Select Case rngStory.StoryType
                        Case 1, 6, 7, 8, 9, 10, 11
                            If rngStory.ShapeRange.Count > 0 Then
                                For Each oShp In rngStory.ShapeRange
                                    If oShp.Fill.ForeColor.RGB = ColorHidden Then
                                        Found = True
                                        Exit For
                                    ElseIf oShp.Line.ForeColor.RGB = ColorHidden Then
                                        Found = True
                                        Exit For
                                    End If
                                Next
                            End If
                    End Select
                End If
                On Error Resume Next
                On Error GoTo 0
                'Get next linked story (if any)
                rngStory = rngStory.NextStoryRange
            Loop Until rngStory Is Nothing
        Next

        'If something was found then set toogle button to active
        If Found = True Then
            tglBtnCheck.Enabled = True
            tglBtnCheck.Checked = False

            ' Setzen des Dokumenten Status bzw. hinzufügen.
            WritePropertiesStatus(True)
        Else
            tglBtnCheck.Enabled = False
            tglBtnCheck.Checked = False

            ' Setzen des Dokumenten Status bzw. hinzufügen.
            WritePropertiesStatus(False)

        End If

    End Sub

    'Inform the user about hidden objects and close the form automatically after seconds
    Sub MessageHiddenObjects()
        Dim AckTime As Integer
        Dim InfoBox As Object

        If GetPropertiesStatus() = "ContentHidden" Then
            'Inform user about hidden objects if checkbox in settings is activated
            If LKTool.InformAboutHiddenObjects = True Then
                InfoBox = CreateObject("WScript.Shell")
                'Set the message box to close after 10 seconds
                AckTime = LKTool.InformAboutHiddenObjectsTime
                Select Case InfoBox.Popup("LKTools hat ausgeblendete Objekte gefunden.",
                AckTime, "LKTools", vbOKOnly + 48)
                    Case 1, -1
                        Exit Sub
                End Select
                ' MsgBox("Gefunden")
            End If
        End If
    End Sub

    'Add the graph template 
    Private Sub btnGraphTemplate_Click(sender As Object, e As RibbonControlEventArgs) Handles btnGraphTemplate.Click
        '#######################################################
        'Add graph paper template, that can be used in tests or on work sheets
        '#######################################################

        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim check As Boolean 'need for checking the entered value
        Dim columns As Integer 'The number of calculated columns that should be entered based on the width
        Dim spcAfter As Integer
        Dim spcbefore As Integer
        Dim fontSize As Integer
        Dim graphwidthPoints As Single
        Dim GraphRowsTemp As Single

        'Freeze screen
        Globals.ThisAddIn.Application.ScreenUpdating = False

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection

        'Recalculat cellwith from cm to points
        graphwidthPoints = Globals.ThisAddIn.Application.CentimetersToPoints(Graphwidth)

        'Calculate the number of columns based on table or document width
        columns = getDocWithForTables() / graphwidthPoints

        'If no number is entered, then 10 rows are created. Error if alphanumeric is entered
        If IsNumeric(txtRows.Text) Then
            GraphRowsTemp = CInt(txtRows.Text)
            txtRows.Text = GraphRowsTemp 'Updates the entered value if a comma seperated value was entered
            check = True
        Else
            If txtRows.Text = "" Then
                GraphRowsTemp = LKTool.GraphRows
                check = True
            Else
                MsgBox("Bitte geben Sie die Anzahl der Zeilen ein.", MsgBoxStyle.Information, "Zeilenanzahl")
                check = False
            End If
        End If

        'If the check was true, then the table is created
        If check = True Then
            document.Tables.Add(Range:=cursor.Range, NumRows:=GraphRowsTemp, NumColumns:=columns,
                                DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                                AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
            With cursor.Tables(1)
                .ApplyStyleHeadingRows = False
                .ApplyStyleLastRow = False
                .ApplyStyleFirstColumn = False
                .ApplyStyleLastColumn = False
                .ApplyStyleRowBands = False
                .ApplyStyleColumnBands = False
                .Borders.InsideColor = ObjectTextColor
                .Borders.OutsideColor = ObjectTextColor
                .Columns.Width = graphwidthPoints 'Width and Heigt are identical to get a square
                .Rows.Height = graphwidthPoints 'Width and Heigt are identical to get a square
            End With

            'Reminds the spaceAfter and Before and set it back after 
            spcAfter = cursor.Tables(1).Range.ParagraphFormat.SpaceAfter
            spcbefore = cursor.Tables(1).Range.ParagraphFormat.SpaceBefore
            fontSize = cursor.Tables(1).Range.Font.Size

            'no space after/before in the new created table
            cursor.Tables(1).Range.ParagraphFormat.SpaceAfter = 0
            cursor.Tables(1).Range.ParagraphFormat.SpaceBefore = 0
            cursor.Tables(1).Range.Font.Size = 3

            'Cursor is moved to end of the table
            cursor.MoveDown(Count:=GraphRowsTemp)

            'old space after/before value is used after the table was entered
            cursor.ParagraphFormat.SpaceAfter = spcAfter '
            cursor.ParagraphFormat.SpaceBefore = spcbefore
            cursor.Tables(1).Range.Font.Size = fontSize

        End If

        'Unfreeze Bildschirm
        Globals.ThisAddIn.Application.ScreenUpdating = True

    End Sub

    'add the ruled template
    Private Sub btnRuledTemplate_Click(sender As Object, e As RibbonControlEventArgs) Handles btnRuledTemplate.Click
        '#######################################################
        'Add ruled (lined) paper template, that can be used in tests or on work sheets
        '#######################################################

        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim check As Boolean 'need for checking the entered value
        Dim columns As Integer 'The number of calculated columns that should be entered based on the width
        Dim spcAfter As Integer
        Dim spcbefore As Integer
        Dim fontSize As Integer
        Dim ruledspacingPoints As Single
        Dim i As Integer
        Dim RuledRowsTemp As Integer

        'Freeze screen
        Globals.ThisAddIn.Application.ScreenUpdating = False

        'Recalculat heigt in cm to points
        ruledspacingPoints = Globals.ThisAddIn.Application.CentimetersToPoints(RuledSpacing)

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection

        'Define the number of columns based on table or document width
        columns = 1

        'If no number is entered, then 10 rows are created. Error if alphanumeric is entered
        If IsNumeric(txtRows.Text) Then
            RuledRowsTemp = CInt(txtRows.Text)
            txtRows.Text = RuledRowsTemp 'Updates the entered value if a comma seperated value was entered
            check = True
        Else
            If txtRows.Text = "" Then
                RuledRowsTemp = LKTool.RuledRows
                check = True
            Else
                MsgBox("Bitte geben Sie die Anzahl der Zeilen ein.", MsgBoxStyle.Information, "Zeilenanzahl")
                check = False
            End If
        End If

        'If the check was true, then the table is created
        If check = True Then
            document.Tables.Add(Range:=cursor.Range, NumRows:=RuledRowsTemp, NumColumns:=columns,
                                DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                                AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
            With cursor.Tables(1) '.Borders(Word.WdBorderType.wdBorderBottom).LineWidth = WdLineWidth.wdLineWidth050pt
                .ApplyStyleHeadingRows = False
                .ApplyStyleLastRow = False
                .ApplyStyleFirstColumn = False
                .ApplyStyleLastColumn = False
                .ApplyStyleRowBands = False
                .ApplyStyleColumnBands = False
                .Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone
                .Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleNone
                With .Borders(Word.WdBorderType.wdBorderBottom)
                    .LineStyle = LKTool.RuledStyle
                    .LineWidth = LKTool.RuledStyleWidth
                    .Color = LKTool.ObjectTextColor
                End With
                With .Borders(Word.WdBorderType.wdBorderHorizontal)
                    .LineStyle = LKTool.RuledStyle
                    .LineWidth = LKTool.RuledStyleWidth
                    .Color = LKTool.ObjectTextColor
                End With
                .Columns.Width = getDocWithForTables()
                .Rows.Height = ruledspacingPoints
                i = 1
                Do While i <= RuledRows
                    .Cell(i, 1).Range.Font.TextColor.RGB = ColorVisible
                    i = i + 1
                Loop
            End With

            'Reminds the spaceAfter and Before and set it back after 
            spcAfter = cursor.Tables(1).Range.ParagraphFormat.SpaceAfter
            spcbefore = cursor.Tables(1).Range.ParagraphFormat.SpaceBefore
            fontSize = cursor.Tables(1).Range.Font.Size

            'no space after/before in the new created table
            cursor.Tables(1).Range.ParagraphFormat.SpaceAfter = 0
            cursor.Tables(1).Range.ParagraphFormat.SpaceBefore = 0
            cursor.Tables(1).Range.Font.Size = 10

            'Cursor is moved to end of the table
            cursor.MoveDown(Count:=RuledRowsTemp)

            'old space after/before value is used after the table was entered
            cursor.ParagraphFormat.SpaceAfter = spcAfter '
            cursor.ParagraphFormat.SpaceBefore = spcbefore
            cursor.Tables(1).Range.Font.Size = fontSize
        End If


        'Freeze screen
        Globals.ThisAddIn.Application.ScreenUpdating = True

    End Sub

    'replace text hiddenColor with visibleColor
    Private Sub SearchAndReplaceInStoryLoesungEinblenden(ByVal rngStory As Word.Range,
        ByVal strSearch As String, ByVal strReplace As String)
        rngStory.Find.ClearFormatting()
        rngStory.Find.Font.Color = ColorHidden
        rngStory.Find.Replacement.ClearFormatting()
        rngStory.Find.Replacement.Font.Color = ColorVisible 'Convert to specified color
        With rngStory.Find
            .Text = ""
            .Replacement.Text = ""
            .Forward = True
            .Wrap = Word.WdFindWrap.wdFindContinue
            .Format = True
            .MatchCase = False
            .MatchWholeWord = False
            .MatchWildcards = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
            .Execute(Replace:=Word.WdReplace.wdReplaceAll)
        End With

        If chkUnderline = True Then
            rngStory.Find.ClearFormatting()
            rngStory.Find.Font.UnderlineColor = ColorHidden 'Convert to specified color
            rngStory.Find.Replacement.ClearFormatting()
            rngStory.Find.Replacement.Font.UnderlineColor = ColorVisible
            With rngStory.Find
                .Text = ""
                .Replacement.Text = ""
                .Forward = True
                .Wrap = Word.WdFindWrap.wdFindContinue
                .Format = True
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
                .Execute(Replace:=Word.WdReplace.wdReplaceAll)
            End With
        End If

        'Unfreeze Bildschirm
        Globals.ThisAddIn.Application.ScreenUpdating = True

    End Sub

    'replace text visibleColor with hiddenColor
    Private Sub SearchAndReplaceInStoryLoesungAusblenden(ByVal rngStory As Word.Range,
   ByVal strSearch As String, ByVal strReplace As String)

        rngStory.Find.ClearFormatting()
        rngStory.Find.Font.Color = ColorVisible 'Convert to specified color
        rngStory.Find.Replacement.ClearFormatting()
        rngStory.Find.Replacement.Font.Color = ColorHidden
        With rngStory.Find
            .Text = ""
            .Replacement.Text = ""
            .Forward = True
            .Wrap = Word.WdFindWrap.wdFindContinue
            .Format = True
            .MatchCase = False
            .MatchWholeWord = False
            .MatchWildcards = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
            .Execute(Replace:=Word.WdReplace.wdReplaceAll)
        End With

        If chkUnderline = True Then
            rngStory.Find.ClearFormatting()
            rngStory.Find.Font.UnderlineColor = ColorVisible 'Convert to specified color
            rngStory.Find.Replacement.ClearFormatting()
            rngStory.Find.Replacement.Font.UnderlineColor = ColorHidden
            With rngStory.Find
                .Text = ""
                .Replacement.Text = ""
                .Forward = True
                .Wrap = Word.WdFindWrap.wdFindContinue
                .Format = True
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
                .Execute(Replace:=Word.WdReplace.wdReplaceAll)
            End With
        End If
    End Sub


    'Open IHK window
    Private Sub btnIHK_Click(sender As Object, e As RibbonControlEventArgs) Handles btnGrade.Click

        Dim frmIHK = System.Windows.Forms.Application.OpenForms

        If isDocumentExtensionDocx() = True Then

            If frmIHK.OfType(Of frmIHK).Any Then
                frmIHK.Item("frmIHK").Activate()
            Else
                Dim frmIHK2 = New frmIHK()
                frmIHK2.Show()
            End If
        Else
            MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If
    End Sub

    'Create the grade scale
    Public Sub createIHK(ByVal maxPoints As Single)

        '#######################################################
        'Add IHK grade scale
        '#######################################################

        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim rows As Integer 'Define the number of default rows
        Dim columns As Integer 'The number of calculated columns that should be entered based on the width
        Dim cellwidth As Single = 0.5 'Default width cm
        Dim fromPoints As Single 'used to calculate the points per grade
        Dim x As Integer 'used as horizonal table index
        Dim y As Integer 'used as vertical table index
        Dim i As Integer 'used as counter
        Dim factor As Single 'used to calculate the grad
        Dim oShp As Word.Shape 'check if shape already exists.
        Dim leftCursor As Double 'for the cursor position to the left
        Dim topCursor As Double 'for the cursor position to the top

        'Freeze screen
        Globals.ThisAddIn.Application.ScreenUpdating = False

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection
        rows = 7 ' 1 header + 6 grades

        If LKTool.NoRoundingTEMP = True And LKTool.Rounding05TEMP = True Then
            columns = 5 'the grade + rounded from-till and exact from-till
        Else
            columns = 3 'the grade + rounded from-till and exact from-till
        End If

        'Check if IHK shape exist. If yes, then delete it first.
        For Each oShp In document.Shapes
            If oShp.Name = "IHK" Then
                document.Shapes("IHK").Delete()
            End If
        Next

        'Get current cursor position
        leftCursor = cursor.Information(Word.WdInformation.wdHorizontalPositionRelativeToPage) + 20
        topCursor = cursor.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)

        'Create a red rectangle
        If LKTool.NoRoundingTEMP = True And LKTool.Rounding05TEMP = True Then
            oShp = document.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, leftCursor, topCursor, 280, 122)
        Else
            oShp = document.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, leftCursor, topCursor, 180, 109)
        End If

        With oShp.Line
            .Visible = True 'Einblenden des Rahmens
            .ForeColor.RGB = ColorVisible 'Standardfarbe
            .Weight = 2 'Rahmendicke
        End With
        oShp.Fill.BackColor.RGB = WdColor.wdColorWhite
        oShp.Name = "IHK"

        'Insert a table to the red rectangle
        document.Tables.Add(Range:=oShp.TextFrame.TextRange, NumRows:=rows, NumColumns:=columns,
                            DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                            AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
        With oShp.TextFrame.TextRange
            With .ParagraphFormat
                .SpaceAfter = 0
                .SpaceBefore = 0
                .LineSpacingRule = WdLineSpacing.wdLineSpaceSingle
            End With
            With .Font
                .Size = 11
                .Bold = False
                .TextColor.RGB = ObjectTextColor
            End With
            With .Tables(1)
                .ApplyStyleHeadingRows = False
                .ApplyStyleLastRow = False
                .ApplyStyleFirstColumn = False
                .ApplyStyleLastColumn = False
                .ApplyStyleRowBands = False
                .ApplyStyleColumnBands = False
                .Borders.InsideColor = LKTool.ObjectTextColor
                .Borders.OutsideColor = LKTool.ObjectTextColor
                .Columns.Width = 50
                .Rows.Height = 10
            End With
        End With


        'Copy maxPoints in fromPoints
        fromPoints = maxPoints

        'Fill the table header with data
        With oShp.TextFrame.TextRange.Tables.Item(1)
            .Cell(1, 1).Range.Text = "Note"
            If LKTool.NoRoundingTEMP = True And LKTool.Rounding05TEMP = True Then
                .Cell(1, 2).Range.Text = "Von (gerundet)"
                .Cell(1, 3).Range.Text = "Bis (gerundet)"
                .Cell(1, 4).Range.Text = "Von (exakt)"
                .Cell(1, 5).Range.Text = "Bis (exakt)"
            Else
                .Cell(1, 2).Range.Text = "Von"
                .Cell(1, 3).Range.Text = "Bis"
            End If

        End With

        'Fill the table with data from the IHK grade scale
        x = 2 'Start in the second line
        i = 1

        Do While x <= 7
            y = 1
            Select Case x
                Case 2
                    factor = LKTool.gradeTEMP(0) / 100 'grade 1 
                Case 3
                    factor = LKTool.gradeTEMP(1) / 100 'grade 2 
                Case 4
                    factor = LKTool.gradeTEMP(2) / 100 'grade 3 
                Case 5
                    factor = LKTool.gradeTEMP(3) / 100 'grade 4 
                Case 6
                    factor = LKTool.gradeTEMP(4) / 100 'grade 5 
                Case Else
                    factor = 0    'grade 6 till 0%
            End Select

            Do While y <= columns
                With oShp.TextFrame.TextRange.Tables.Item(1).Cell(x, y).Range
                    If y = 1 Then
                        .Text = "Note " & i
                        i = i + 1
                    ElseIf y = 2 Then
                        If LKTool.Rounding05TEMP = True Then
                            .Text = ((Math.Round(fromPoints * 2, MidpointRounding.AwayFromZero)) / 2).ToString("0.0")
                            .ParagraphFormat.Alignment = WdAlignmentTabAlignment.wdRight
                        Else
                            If fromPoints = maxPoints Then
                                .Text = fromPoints.ToString("0.00")
                            Else
                                fromPoints = fromPoints + 0.5 - 0.01
                                .Text = fromPoints.ToString("0.00")
                            End If
                            .ParagraphFormat.Alignment = WdAlignmentTabAlignment.wdRight
                        End If

                    ElseIf y = 3 Then
                        If LKTool.Rounding05TEMP = True Then
                            .Text = ((Math.Round((maxPoints * factor) * 2, MidpointRounding.AwayFromZero)) / 2).ToString("0.0")
                            .ParagraphFormat.Alignment = WdAlignmentTabAlignment.wdRight
                            If LKTool.Rounding05TEMP = True And LKTool.NoRoundingTEMP = False Then
                                fromPoints = maxPoints * factor - 0.5
                            End If
                        Else
                            .Text = (maxPoints * factor).ToString("0.00")
                            .ParagraphFormat.Alignment = WdAlignmentTabAlignment.wdRight
                            fromPoints = maxPoints * factor - 0.5
                        End If
                    ElseIf y = 4 Then
                        If fromPoints = maxPoints Then
                            .Text = fromPoints.ToString("0.00")
                        Else
                            fromPoints = fromPoints + 0.5 - 0.01
                            .Text = fromPoints.ToString("0.00")
                        End If
                        .ParagraphFormat.Alignment = WdAlignmentTabAlignment.wdRight
                    ElseIf y = 5 Then
                        .Text = (maxPoints * factor).ToString("0.00")
                        .ParagraphFormat.Alignment = WdAlignmentTabAlignment.wdRight
                        fromPoints = maxPoints * factor - 0.5
                    Else
                        MsgBox("not specified", MsgBoxStyle.Critical, "LKTools")
                    End If
                    y = y + 1
                End With
            Loop
            x = x + 1
        Loop

        'Add solution if it is set to true in settings
        If AddSolution = True Then
            AddSolutions()
        End If

        'Unfreeze Bildschirm
        Globals.ThisAddIn.Application.ScreenUpdating = True

    End Sub

    'Add a textbox with a user specific text if defined in settings window
    Private Sub AddSolutions()
        'This functionality adds a red textbox with the word "Lösungs-vorschlag"
        Dim document As Word.Document
        Dim oShp As Word.Shape 'check if shape already exists.
        Dim check As Boolean = False
        Dim docWidth As Single 'Needed for calculating the correct with of the grid
        Dim docHeight As Single 'Needed for calculating the correct with of the grid

        document = Globals.ThisAddIn.Application.ActiveDocument

        'Check if "Lösungsvorschlag" shape exist. If yes, then no action
        For Each oShp In document.Shapes
            If oShp.Name = "Solution" Then
                check = True
            End If
        Next

        If check = False Then
            'Get docwith
            docWidth = document.PageSetup.PageWidth - document.PageSetup.RightMargin - 120
            docHeight = document.PageSetup.TopMargin - 40

            'Create a red rectangle
            oShp = document.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, docWidth, docHeight, 120, 65)
            oShp.RelativeHorizontalPosition = WdRelativeHorizontalPosition.wdRelativeHorizontalPositionPage
            oShp.RelativeVerticalPosition = WdRelativeVerticalPosition.wdRelativeVerticalPositionPage
            oShp.WrapFormat.Type = WdWrapType.wdWrapFront

            oShp.Name = "Solution"

            With oShp.Line
                .Visible = True 'Einblenden des Rahmens
                .ForeColor.RGB = ColorVisible 'Standardfarbe
                .Weight = 1 'Rahmendicke
            End With

            'Änderung des Textrandes
            With oShp.TextFrame
                .MarginBottom = 1
                .MarginLeft = 3
                .MarginRight = 1
                .AutoSize = True
                '.TypeParagraph     'Neue Zeile
            End With

            With oShp.TextFrame.TextRange
                .Text = SolutionDescription
                With .Font
                    .Size = 22
                    .Name = "Palatino"
                    .Bold = True
                    .TextColor.RGB = ObjectTextColor
                End With
            End With
        End If
    End Sub

    'Add a red textbox for quick and easy entries in ColorVisible
    Private Sub btnRedTextbox_Click(sender As Object, e As RibbonControlEventArgs) Handles btnRedTextbox.Click
        'Add a red textbox that can be hidden afterwards.
        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim oShp As Word.Shape 'check if shape already exists.
        Dim leftCursor As Single 'Needed for calculating the correct with of the grid
        Dim topCursor As Single 'Needed for calculating the correct with of the grid

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection

        'Add solution if it is set to true in settings
        If AddSolution = True Then
            AddSolutions()
        End If

        'Get current cursor position
        leftCursor = cursor.Information(Word.WdInformation.wdHorizontalPositionRelativeToPage) + 20
        topCursor = cursor.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)

        'Create a red rectangle
        oShp = document.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, leftCursor, topCursor, 120, 30)
        oShp.Select() 'Select the created textbox

        'Änderung des Textrandes
        With oShp.TextFrame
            .MarginTop = 1
            .MarginBottom = 1
            .MarginLeft = 3
            .MarginRight = 1
            '.TypeParagraph     'Neue Zeile
        End With

        With oShp.Line
            .Visible = True 'Einblenden des Rahmens
            .ForeColor.RGB = ColorVisible 'Standardfarbe
            .Weight = 3 'Rahmendicke

        End With
        oShp.Fill.BackColor.RGB = WdColor.wdColorWhite

        With oShp.TextFrame.TextRange
            .Text = ""
            With .Font
                .Size = 11
                .Name = "Times New Roman"
                .Bold = False
                .TextColor.RGB = ObjectTextColor
            End With
        End With

    End Sub

    'Open window frmsettings
    Private Sub btnSettings_Click(sender As Object, e As RibbonControlEventArgs) Handles btnSettings.Click
        Dim frmSettings = System.Windows.Forms.Application.OpenForms

        If frmSettings.OfType(Of frmSettings).Any Then
            frmSettings.Item("frmSettings").Activate()
        Else
            Dim frmSettings2 = New frmSettings()
            frmSettings2.Show()
        End If

    End Sub

    'Action for clicking the PDF Button
    Private Sub btnPDF_Click(sender As Object, e As RibbonControlEventArgs) Handles btnPDF.Click
        'Call the PDFExport
        Dim frmPDFExport = System.Windows.Forms.Application.OpenForms

        If ShowExtendedPDFSettings = True Then
            If frmPDFExport.OfType(Of frmPDFExport).Any Then
                frmPDFExport.Item("frmPDFExport").Activate()
            Else
                Dim frmPDFExport2 = New frmPDFExport()
                frmPDFExport2.Show()
            End If
        Else
            PDFExport(0, 0, 0,
                      LKTool.chkPDFMarkupsSolution,
                      0, 0, 0,
                      LKTool.chkPDFMarkupsNoSolution,
                      LKTool.chkOpenPDFFolder)
        End If

    End Sub

    'Action for clicking the QuickPrint Button
    Private Sub btnQuickPrint_Click(sender As Object, e As RibbonControlEventArgs) Handles btnQuickPrint.Click
        Dim document As Word.Document
        Dim check As Boolean
        Dim iCountHiddenOverlays As Integer = 0

        iCountHiddenOverlays = HideOverlay()

        document = Globals.ThisAddIn.Application.ActiveDocument

        If LKTool.chkPrintSolutionTemp = False And LKTool.chkPrintNoSolutionTemp = False Then
            MsgBox("Die Ausgabe ('Lösung' und oder 'Ohne Lösung') muss zunächst festgelegt werden.", vbInformation, "LKTools")
            check = False
        Else
            check = True
        End If

        If check = True Then
            If LKTool.chkPrintSolutionTemp = True Then
                PrintSolutionDefaultPrinter(document)
            End If

            If LKTool.chkPrintNoSolutionTemp = True Then
                PrintNoSolutionDefaultPrinter(document)
            End If
        Else
            'Nothing
        End If

        If iCountHiddenOverlays > 0 Then
            ShowOverlay()
        End If

    End Sub

    'Sub for exporting the pdf document
    Public Sub PDFExport(DocRangeSolution As Integer, StartNumSolution As Integer, EndNumSolution As Integer,
                         ShowMarkupsSolution As Boolean,
                         DocRangeNoSolution As Integer, StartNumNoSolution As Integer, EndNumNoSolution As Integer,
                         ShowMarkupsNoSolution As Boolean,
                         OpenPDFFolder As Boolean)
        Dim document As Word.Document
        Dim docPath As String
        Dim docFileNameOriginal As String
        Dim docFileNameWith As String = ""
        Dim docFileNameWithout As String = ""
        Dim check As Boolean = False
        Dim ContentHidden As Boolean
        Dim result As MsgBoxResult
        Dim wnd As Object
        Dim oShell As Object
        Dim iCountHiddenOverlays As Integer = 0

        'Hide all the overlay objects
        iCountHiddenOverlays = HideOverlay()

        oShell = CreateObject("Shell.Application")
        Dim FolderAlreadyOpen As Boolean

        document = Globals.ThisAddIn.Application.ActiveDocument
        docFileNameOriginal = document.Name

        docPath = document.Path

        If docPath = "" Then
            result = MsgBox("Sie müssen das Dokument zunächst speichern. Dokument jetzt speichern?",
                   MsgBoxStyle.Information + MsgBoxStyle.YesNo, "LKTools")
            If result = MsgBoxResult.Yes Then
                document.Save()
                docFileNameOriginal = document.Name
                docPath = document.Path
                check = True
            Else
                docFileNameOriginal = ""
                check = False
                Exit Sub
            End If
        Else
            check = True
        End If

        'Open FOlder if it is not open yet
        If check = True And OpenPDFFolder = True Then
            For Each wnd In oShell.Windows
                If wnd.Name = "Explorer" Then
                    If wnd.Document.Folder.Self.Path = docPath Then
                        FolderAlreadyOpen = True
                        'If folder is open, then show it
                        wnd.visible = True
                    End If
                End If
            Next wnd
            If FolderAlreadyOpen = False Then
                Process.Start("explorer.exe", docPath)
            End If
        End If

        If check = True Then
            'Get the file Name
            If Right(docFileNameOriginal, 5) = ".docx" Then
                docFileNameOriginal = Left(docFileNameOriginal, Len(docFileNameOriginal) - 5)
            ElseIf Right(docFileNameOriginal, 4) = ".doc" Then
                docFileNameOriginal = Left(docFileNameOriginal, Len(docFileNameOriginal) - 4)
            Else
                docFileNameOriginal = docFileNameOriginal
            End If

            'Get or define the document path based on the settings
            If LKTool.pdfExportSettings = 1 Then
                docPath = document.Path

                docFileNameWith = returnDocFileName(True, docPath, docFileNameOriginal)
                docFileNameWithout = returnDocFileName(False, docPath, docFileNameOriginal)

                'Wenn Suffix dann anders zusammenbauen
            ElseIf LKTool.pdfExportSettings = 2 Then
                'Check if subfolder exist. If not create it first
                docPath = document.Path & "\" & LKTool.pdfSubFolderText
                If Not CreateObject("Scripting.FileSystemObject").FolderExists(docPath) Then
                    CreateObject("Scripting.FileSystemObject").CreateFolder(docPath)
                End If
                docFileNameWith = returnDocFileName(True, docPath, docFileNameOriginal)
                docFileNameWithout = returnDocFileName(False, docPath, docFileNameOriginal)
            ElseIf LKTool.pdfExportSettings = 3 Then
                'Check if path exist. If not inform the user to change settings.

                'Rootdirectory fix delete the \

                If Right(LKTool.pdfPathText, 1) = "\" Then
                    docPath = Left(LKTool.pdfPathText, Len(LKTool.pdfPathText) - 1)
                Else
                    docPath = LKTool.pdfPathText
                End If

                If Not CreateObject("Scripting.FileSystemObject").FolderExists(docPath) Then
                    result = MsgBox("Pfad " & docPath & " existiert nicht. Wollen Sie das Verzeichnis der Datei verwenden?",
                           MsgBoxStyle.Critical + vbYesNo, "LKTools")
                    If result = MsgBoxResult.Yes Then
                        docPath = document.Path
                        'If suffix is checked, then build the string like this
                        docFileNameWith = returnDocFileName(True, docPath, docFileNameOriginal)
                        docFileNameWithout = returnDocFileName(False, docPath, docFileNameOriginal)
                    Else
                        check = False
                        Exit Sub
                    End If
                Else
                    'If suffix is checked, then build the string like this
                    docFileNameWith = returnDocFileName(True, docPath, docFileNameOriginal)
                    docFileNameWithout = returnDocFileName(False, docPath, docFileNameOriginal)
                End If
            Else
                docPath = document.Path 'if something went wrong use the current path.
            End If
        End If


        'check if the output option is activated
        If check = True Then
            If LKTool.chkPrintSolutionTemp = False And LKTool.chkPrintNoSolutionTemp = False Then
                MsgBox("Die Ausgabe ('Lösung' und oder 'Ohne Lösung') muss zunächst festgelegt werden.", MsgBoxStyle.Information, "LKTools")
                check = False
            Else
                check = True
            End If
        End If

        'Check if document content is hidden
        If GetPropertiesStatus() = "ContentHidden" Then
            ContentHidden = True
        Else
            ContentHidden = False
        End If

        If check = True Then
            If ContentHidden = True Then

                If LKTool.chkPrintNoSolutionTemp = True Then
                    savePDFdocument(docFileNameWith, docFileNameWithout, True,
                                DocRangeSolution, StartNumSolution, EndNumSolution,
                                ShowMarkupsSolution,
                                DocRangeNoSolution, StartNumNoSolution, EndNumNoSolution,
                                ShowMarkupsNoSolution)
                End If
                If LKTool.chkPrintSolutionTemp = True Then
                    ShowObjectsAndTexts()
                    savePDFdocument(docFileNameWith, docFileNameWithout, False,
                                    DocRangeSolution, StartNumSolution, EndNumSolution,
                                    ShowMarkupsSolution,
                                    DocRangeNoSolution, StartNumNoSolution, EndNumNoSolution,
                                    ShowMarkupsNoSolution)
                    HideObjectsAndTexts()
                End If
            ElseIf ContentHidden = False Then
                If LKTool.chkPrintSolutionTemp = True Then
                    savePDFdocument(docFileNameWith, docFileNameWithout, False,
                                    DocRangeSolution, StartNumSolution, EndNumSolution,
                                    ShowMarkupsSolution,
                                    DocRangeNoSolution, StartNumNoSolution, EndNumNoSolution,
                                    ShowMarkupsNoSolution)
                End If
                If LKTool.chkPrintNoSolutionTemp = True Then

                    HideObjectsAndTexts()
                    savePDFdocument(docFileNameWith, docFileNameWithout, True,
                                    DocRangeSolution, StartNumSolution, EndNumSolution,
                                    ShowMarkupsSolution,
                                    DocRangeNoSolution, StartNumNoSolution, EndNumNoSolution,
                                    ShowMarkupsNoSolution)
                    ShowObjectsAndTexts()
                End If
            End If
        End If

        If iCountHiddenOverlays > 0 Then
            ShowOverlay()
        End If


    End Sub


    Private Function returnDocFileName(printSolution As Boolean, docPath As String, docFileNameOriginal As String)
        Dim docFileNameNew As String

        If (printSolution = True) Then
            If (chkDescriptionPositionSuffix = True) Then
                docFileNameNew = docPath & "\" & docFileNameOriginal & LKTool.pdfSolutionText & ".pdf"
            Else
                docFileNameNew = docPath & "\" & LKTool.pdfSolutionText & docFileNameOriginal & ".pdf"
            End If
        Else
            If (chkDescriptionPositionSuffix = True) Then
                docFileNameNew = docPath & "\" & docFileNameOriginal & LKTool.pdfNoSolutionText & ".pdf"
            Else
                docFileNameNew = docPath & "\" & LKTool.pdfNoSolutionText & docFileNameOriginal & ".pdf"
            End If
        End If

        Return docFileNameNew
    End Function

    'Sub for exporting the pdf document
    Private Sub savePDFdocument(docFileNameWith As String, docFileNameWithout As String, Hidden As Boolean,
                                DocRangeSolution As Integer, StartNumSolution As Integer, EndNumSolution As Integer,
                                ShowMarkupsSolution As Boolean,
                                DocRangeNoSolution As Integer, StartNumNoSolution As Integer, EndNumNoSolution As Integer,
                                ShowMarkupsNoSolution As Boolean)

        Dim document As Word.Document
        Dim MarkupsSolution As Byte '0 = without markups, 7 = with markups
        Dim MarkupsNoSolution As Byte '0 = without markups, 7 = with markups
        Dim tempPrintHiddenText As Boolean 'saves the initial flag for printing the hidden text
        Dim cursor As Word.Selection



        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection

        If ShowMarkupsSolution = True Then
            MarkupsSolution = 7
        Else
            MarkupsSolution = 0
        End If

        If ShowMarkupsNoSolution = True Then
            MarkupsNoSolution = 7
        Else
            MarkupsNoSolution = 0
        End If

        'Saves the initial value to reset it later on again
        tempPrintHiddenText = Globals.ThisAddIn.Application.Options.PrintHiddenText


        If Hidden = True Then 'IF solution should be hidden
            Globals.ThisAddIn.Application.Options.PrintHiddenText = False 'Do never print hiddentext


            'if document revision should not be printed and no page from to is defined
            ' then the printing should start on page 2
            If LKTool.chkPDFRevisionTemp = False And DocRangeNoSolution = 0 And document.Bookmarks.Exists("RevisionTable") = True Then
                DocRangeNoSolution = 3
                StartNumNoSolution = 2
                EndNumNoSolution = cursor.Information(WdInformation.wdNumberOfPagesInDocument)

            End If


            document.ExportAsFixedFormat(
                OutputFileName:=docFileNameWithout,
                ExportFormat:=WdExportFormat.wdExportFormatPDF,
                OpenAfterExport:=False,
                OptimizeFor:=WdExportOptimizeFor.wdExportOptimizeForPrint,
                Range:=DocRangeNoSolution,
                From:=StartNumNoSolution,
                To:=EndNumNoSolution,
                Item:=MarkupsNoSolution,
                IncludeDocProps:=True,
                KeepIRM:=True,
                CreateBookmarks:=WdExportCreateBookmarks.wdExportCreateNoBookmarks,
                DocStructureTags:=True,
                BitmapMissingFonts:=True,
                UseISO19005_1:=False
            )

        Else 'With Solution visible
            Globals.ThisAddIn.Application.Options.PrintHiddenText = False 'Do always print hiddentext

            ' then the printing should start on page 2
            If LKTool.chkPDFRevisionTemp = False And DocRangeSolution = 0 And document.Bookmarks.Exists("RevisionTable") = True Then
                DocRangeSolution = 3
                StartNumSolution = 2
                EndNumSolution = cursor.Information(WdInformation.wdNumberOfPagesInDocument)
            End If


            document.ExportAsFixedFormat(
                OutputFileName:=docFileNameWith,
                ExportFormat:=WdExportFormat.wdExportFormatPDF,
                OpenAfterExport:=False,
                OptimizeFor:=WdExportOptimizeFor.wdExportOptimizeForPrint,
                Range:=DocRangeSolution,
                From:=StartNumSolution,
                To:=EndNumSolution,
                Item:=MarkupsSolution,
                IncludeDocProps:=True,
                KeepIRM:=True,
                CreateBookmarks:=WdExportCreateBookmarks.wdExportCreateNoBookmarks,
                DocStructureTags:=True,
                BitmapMissingFonts:=True,
                UseISO19005_1:=False
            )
        End If

        'Reset the initial printHiddenText value
        Globals.ThisAddIn.Application.Options.PrintHiddenText = tempPrintHiddenText

    End Sub

    'Action for Printing the Solution
    Private Sub PrintSolutionDefaultPrinter(document As Word.Document)
        'Festlegen der Dokument Properties Variable
        Dim ContentHidden As Boolean
        Dim properties As Microsoft.Office.Core.DocumentProperties
        Dim tempPrintHiddenText As Boolean 'saves the initial flag for printing the hidden text
        'Saves the initial value to reset it later on again
        tempPrintHiddenText = Globals.ThisAddIn.Application.Options.PrintHiddenText
        Globals.ThisAddIn.Application.Options.PrintHiddenText = True

        properties = DirectCast(Globals.ThisAddIn.Application.ActiveDocument.BuiltInDocumentProperties,
            Microsoft.Office.Core.DocumentProperties)

        'Check if document content is hidden
        If properties.Item("content status").Value = "ContentHidden" Then
            ContentHidden = True
        Else
            ContentHidden = False
        End If



        If ContentHidden = True Then
            ShowObjectsAndTexts()

            document.PrintOut()
            HideObjectsAndTexts()

        ElseIf ContentHidden = False Then
            document.PrintOut()
        End If

        Globals.ThisAddIn.Application.Options.PrintHiddenText = tempPrintHiddenText
    End Sub

    'Action for Printing without Solution
    Private Sub PrintNoSolutionDefaultPrinter(document As Word.Document)
        'Festlegen der Dokument Properties Variable
        Dim ContentHidden As Boolean
        Dim properties As Microsoft.Office.Core.DocumentProperties
        properties = DirectCast(Globals.ThisAddIn.Application.ActiveDocument.BuiltInDocumentProperties,
            Microsoft.Office.Core.DocumentProperties)
        Dim tempPrintHiddenText As Boolean 'saves the initial flag for printing the hidden text
        'Saves the initial value to reset it later on again
        tempPrintHiddenText = Globals.ThisAddIn.Application.Options.PrintHiddenText
        Globals.ThisAddIn.Application.Options.PrintHiddenText = False

        'Check if document content is hidden
        If properties.Item("content status").Value = "ContentHidden" Then
            ContentHidden = True
        Else
            ContentHidden = False
        End If

        HideOverlay()

        If ContentHidden = True Then

            document.PrintOut()
        ElseIf ContentHidden = False Then
            HideObjectsAndTexts()

            document.PrintOut()
            ShowObjectsAndTexts()
        End If

        Globals.ThisAddIn.Application.Options.PrintHiddenText = tempPrintHiddenText
    End Sub

    'Show the buttons or not
    Private Sub showInsertButtons()
        Dim check As Boolean

        If QuickPrint = True Then
            btnQuickPrint.Visible = True
        Else
            btnQuickPrint.Visible = False
        End If

        If ExcerciseButton = False And
            ExamButton = False And
            GraphButton = False And
            RuledButton = False And
            RedTextboxButton = False And
            RevisionPageButton = False And
            MCButton = False And
            TrueFalseButton = False And
            GradeButton = False Then
            grpEinfuegen.Visible = False
            check = False
        Else
            grpEinfuegen.Visible = True
            check = True
        End If

        If check = True Then
            If ExcerciseButton = True Then
                btnExcercise.Visible = True
            Else
                btnExcercise.Visible = False
            End If

            If ExamButton = True Then
                btnExam.Visible = True
            Else
                btnExam.Visible = False
            End If

            If GraphButton = True Then
                btnGraphTemplate.Visible = True
            Else
                btnGraphTemplate.Visible = False
            End If

            If RuledButton = True Then
                btnRuledTemplate.Visible = True
            Else
                btnRuledTemplate.Visible = False
            End If

            If RedTextboxButton = True Then
                btnRedTextbox.Visible = True
            Else
                btnRedTextbox.Visible = False
            End If


            If RevisionPageButton = True Then
                btnRevisionPage.Visible = True
                chkPDFRevision.Visible = True
            Else
                btnRevisionPage.Visible = False
                chkPDFRevision.Visible = False
            End If

            If RuledButton = False And
                GraphButton = False And
                MCButton = False And
                TrueFalseButton = False Then
                txtRows.Visible = False
            Else
                txtRows.Visible = True
            End If

            If MCButton = True Then
                btnMC.Visible = True
            Else
                btnMC.Visible = False
            End If

            If TrueFalseButton = True Then
                btnTrueFalse.Visible = True
            Else
                btnTrueFalse.Visible = False
            End If

            If GradeButton = True Then
                btnGrade.Visible = True
            Else
                btnGrade.Visible = False
            End If

            If LKTool.ExtendedPDFButton = True Then
                btnExtendedPDF.Visible = True
            Else
                btnExtendedPDF.Visible = False
            End If

            If LKTool.PathButton = True Then
                btnFolderPath.Visible = True
            Else
                btnFolderPath.Visible = False
            End If

            If LKTool.ShowOverlayFunction = True Then
                grpOverlayFunction.Visible = True
            Else
                grpOverlayFunction.Visible = False
            End If

            If LKTool.chkPrintHiddenTextButton = True Then
                chkPrintHiddenText.Visible = True
            Else
                chkPrintHiddenText.Visible = False
            End If

        End If
    End Sub

    'Action for Button "Auswählen" (Get the color of selected text)
    Private Sub btnGetTextColor_Click(sender As Object, e As RibbonControlEventArgs) Handles btnGetTextColor.Click
        Dim cursor As Word.Selection
        Dim color As Long
        Dim inselection As Boolean

        If isDocumentExtensionDocx() = True Then

            cursor = Globals.ThisAddIn.Application.Selection
            inselection = False

            If cursor.Type = WdSelectionType.wdSelectionNormal Then
                'Alpha Channel colors can't be used and selection must be avoided
                'Alpha Channel colors are defined e.g. in the header standard format templates
                If CheckAlphaColor(cursor.Font.TextColor.RGB) = False Then
                    color = cursor.Font.TextColor.RGB
                    LKTool.ColorVisible = color
                End If
            ElseIf cursor.Type = WdSelectionType.wdSelectionShape Then
                'Alpha Channel colors can't be used and selection must be avoided
                'Alpha Channel colors are defined e.g. in the header standard format templates
                If CheckAlphaColor(cursor.Font.TextColor.RGB) = False Then
                    color = cursor.ShapeRange.Line.ForeColor.RGB
                    LKTool.ColorVisible = color
                End If
            Else
                MsgBox("LKTools hat leider keine Auswahl gefunden.")
            End If

        Else
            MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If
    End Sub

    '#COnvert long to rgb
    Function CheckAlphaColor(i As Long)

        'Convert the number if it is negativ
        If i < 0 Then
            i = i * -1
        End If

        'Calculate the new number without the alpha Channel
        If (i \ 16777216) > 0 Then
            MsgBox("Die ausgewählte Farbe benutzt einen 'Alpha Kanal' und kann daher nicht als " &
                       "Ausblend-Farbe verwendet werden.")
            Return True
        Else
            Return False
        End If

        'Following code can be used for testing
        'Dim a, r, g, b As Integer
        'MsgBox("Zahl vorher " & i)
        'a = i \ 16777216
        'b = (i - a * 16777216) \ 65536
        'g = (i - a * 16777216 - b * 65536) \ 256
        'r = (i - a * 16777216 - b * 65536 - g * 256) \ 1
        'MsgBox("RGB" & r & ", " & g & ", " & b)

    End Function

    'Action for Button "Färben". Change the selected text to ColorVisible
    Private Sub btnColoringText_Click(sender As Object, e As RibbonControlEventArgs) Handles btnColoringText.Click
        Dim cursor As Word.Selection
        Dim result As MsgBoxResult
        Dim color As Long

        If isDocumentExtensionDocx() = True Then
            color = LKTool.ColorVisible
            cursor = Globals.ThisAddIn.Application.Selection

            If cursor.Type = WdSelectionType.wdSelectionNormal Or
                cursor.Type = WdSelectionType.wdSelectionFrame Or
                cursor.Type = WdSelectionType.wdSelectionIP Or
                cursor.Type = WdSelectionType.wdSelectionRow Or
                cursor.Type = WdSelectionType.wdSelectionColumn Or
                cursor.Type = WdSelectionType.wdSelectionBlock Then

                cursor.Font.TextColor.RGB = color

            ElseIf cursor.Type = WdSelectionType.wdSelectionShape Then
                With cursor.ShapeRange.Line
                    .Visible = True 'Einblenden des Rahmens
                    .ForeColor.RGB = color 'Standardfarbe
                    '.Weight = 3 'Rahmendicke
                End With
            ElseIf cursor.Type = WdSelectionType.wdSelectionInlineShape Then
                result = MsgBox("Objekte, die mit 'Text in Zeile' eingefügt sind, können nicht ausgbelendet werden. " & vbCrLf &
                       "Das Objekt kann automatisch umgewandelt werden. Dadurch verändert sich ggf. die Formatierung Ihres Dokumentes. " & vbCrLf &
                       vbCrLf &
                       "Soll das Objekt umgewandelt werden?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "LKTools")
                If result = MsgBoxResult.Yes Then
                    cursor.InlineShapes(1).ConvertToShape()
                    cursor.ShapeRange.WrapFormat.Type = WdWrapType.wdWrapFront
                    With cursor.ShapeRange.Line
                        .Visible = True 'Einblenden des Rahmens
                        .ForeColor.RGB = ColorVisible 'Standardfarbe
                        ' .Weight = 3 'Rahmendicke
                    End With
                End If
            Else
                MsgBox("LKTools hat leider keine Auswahl gefunden.", MsgBoxStyle.Information, "LKTools")
            End If

        Else
            MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If
    End Sub

    'Action for Button "Schwarz". Change the selected text to black color
    Private Sub btnColoringBlack_Click(sender As Object, e As RibbonControlEventArgs) Handles btnColoringBlack.Click
        Dim cursor As Word.Selection

        If isDocumentExtensionDocx() = True Then

            cursor = Globals.ThisAddIn.Application.Selection
            If cursor.Type = WdSelectionType.wdSelectionNormal Or
                cursor.Type = WdSelectionType.wdSelectionFrame Or
                cursor.Type = WdSelectionType.wdSelectionIP Or
                cursor.Type = WdSelectionType.wdSelectionRow Or
                cursor.Type = WdSelectionType.wdSelectionColumn Or
                cursor.Type = WdSelectionType.wdSelectionBlock Then
                cursor.Font.TextColor.RGB = "0"
            ElseIf cursor.Type = WdSelectionType.wdSelectionShape Then
                With cursor.ShapeRange.Line
                    .Visible = True 'Einblenden des Rahmens
                    .ForeColor.RGB = "0" 'Standardfarbe
                    '.Weight = 3 'Rahmendicke
                End With
            Else
                MsgBox("LKTools hat leider keine Auswahl gefunden.", MsgBoxStyle.Information, "LKTools")
            End If

        Else
            MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If
    End Sub

    'Sub check for updates
    Public Sub Check_Updates(i As Integer)
        Dim url As String
        Dim urlDownload As String
        Dim version As String
        Dim result As MsgBoxResult

        UpdateLastUpdate() 'update the last "update"-date in the XML
        version = String.Format(My.Application.Info.Version.ToString) 'Get the current LKTools Version

        url = "https://sourceforge.net/projects/lktools/files/LKTools%20V." & version & ".zip/download"
        urlDownload = "https://sourceforge.net/projects/lktools/files/latest/download"

        If Not URLExists(url) Then
            result = MsgBox("Ein Neues Update ist verfügbar. Möchten Sie es jetzt herunterladen?", vbYesNo, "LKTools")
            If result = vbYes Then
                System.Diagnostics.Process.Start(urlDownload)
            End If
        Else
            If i = 1 Then
                MsgBox("Kein Update verfügbar.", MsgBoxStyle.Information, "LKTools")
            End If
        End If
    End Sub

    'Sub show changelog
    Public Sub Show_Changelog()
        Dim frmchangelog = System.Windows.Forms.Application.OpenForms

        If frmchangelog.OfType(Of frmChangelog).Any Then
            frmchangelog.Item("frmchangelog").Activate()
        Else
            Dim frmchangelog2 = New frmChangelog()
            frmchangelog2.Show()
        End If
    End Sub

    'Function Check if URL is valid
    Function URLExists(ByVal sURL As String) As Boolean
        '// Testing a URL
        Dim oURL As New WinHttp.WinHttpRequest
        Dim result As String
        oURL.Option(6) = 0

        With oURL
            .Open("GET", sURL, False)
            .Send()
            result = .Status
        End With

        If result = "200" Then
            Return True
        Else
            Return False
        End If

        oURL = Nothing
    End Function

    'update the last Update Check date
    Sub UpdateLastUpdate()
        Dim xDoc As MSXML2.DOMDocument60
        Dim root As Object

        Dim point As MSXML2.IXMLDOMNode

        xDoc = New MSXML2.DOMDocument60
        xDoc.async = False 'Dokument wird erst vollständig geladen

        If xDoc.load(LKTool.myFile) Then
            root = xDoc.documentElement
            point = root.firstChild

            point.selectSingleNode("//LastUpdate").text = Now()
            xDoc.save(LKTool.myFile)
            xDoc = Nothing
        End If

    End Sub

    'Logfile ### Not implemented yet ###
    Private Sub logfile()
        Dim filename As String = Environ("LOCALAPPDATA") & "\LKTools" & "\LKTools.log"
        Dim sw As StreamWriter = AppendText(filename)

        sw.WriteLine(Now())
        sw.WriteLine("LKTools Version: " & My.Application.Info.Version.ToString)
        sw.WriteLine("OS Version: " & Environment.OSVersion.VersionString)
        sw.WriteLine("Office Version: " & Globals.ThisAddIn.Application.Build)
        sw.Close()
    End Sub

    'Create a table template for exercise
    Private Sub btnTable_Click(sender As Object, e As RibbonControlEventArgs) Handles btnExcercise.Click
        '#######################################################
        'Add table template, that can be used in tests or on work sheets
        '#######################################################

        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim columns As Integer 'The number of calculated columns that should be entered based on the width
        Dim mylt As ListTemplate
        Dim check As Boolean
        Dim i As Integer
        Dim RowsTemp As Integer

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection

        'Calculate the number of columns based on table or document width
        columns = 2

        'If no number is entered, then 1 row is created. Error if alphanumeric is entered
        If IsNumeric(txtRows.Text) Then
            RowsTemp = CInt(txtRows.Text)
            txtRows.Text = RowsTemp 'Updates the entered value if a comma seperated value was entered
            check = True
        Else
            If txtRows.Text = "" Then
                RowsTemp = 1
                check = True
            Else
                MsgBox("Bitte geben Sie die Anzahl der Zeilen ein.", MsgBoxStyle.Information, "LKTools")
                check = False
            End If
        End If

        If check = True Then
            'Define the list
            mylt = document.ListTemplates.Add(OutlineNumbered:=True)

            'Define the list levels
            With mylt.ListLevels(1)
                .NumberStyle = WdListNumberStyle.wdListNumberStyleArabic
                .NumberPosition = Globals.ThisAddIn.Application.InchesToPoints(0)
                .TextPosition = Globals.ThisAddIn.Application.InchesToPoints(0.2)
                .NumberFormat = "%1."
            End With

            'create the table
            document.Tables.Add(Range:=cursor.Range, NumRows:=RowsTemp, NumColumns:=columns,
                                DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                                AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
            With cursor.Tables(1)
                .AllowAutoFit = False
                .PreferredWidth = getDocWithForTables()
                .ApplyStyleHeadingRows = False
                .ApplyStyleLastRow = False
                .ApplyStyleFirstColumn = False
                .ApplyStyleLastColumn = False
                .ApplyStyleRowBands = False
                .ApplyStyleColumnBands = False
                .Borders.InsideColor = LKTool.ObjectTextColor
                .Borders.OutsideColor = LKTool.ObjectTextColor
                i = 1
                Do Until i > RowsTemp
                    .Cell(i, 1).Range.ListFormat.ApplyListTemplate(mylt)
                    .Cell(i, 1).Range.Font.Name = "ARIAL"
                    .Cell(i, 1).Range.Font.Size = 11
                    .Cell(i, 1).Width = 20
                    .Cell(i, 2).Width = getDocWithForTables() - .Cell(1, 1).Width
                    .Cell(i, 2).Borders(WdBorderType.wdBorderLeft).LineStyle = WdLineStyle.wdLineStyleNone
                    i = i + 1
                Loop
            End With

            'Cursor is moved to the first right column
            cursor.MoveRight(1)
        End If


    End Sub

    'Create a table for multiple choice exercise 
    Private Sub btnMC_Click(sender As Object, e As RibbonControlEventArgs) Handles btnMC.Click
        '#######################################################
        'Add multiple Choice template, that can be used in tests or on work sheets
        '#######################################################

        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim i As Integer = 1
        Dim columns As Integer 'The number of calculated columns that should be entered based on the width
        Dim docwidth As Single
        Dim mylt As ListTemplate
        Dim CheckboxAllignRight As Boolean
        Dim check As Boolean
        Dim RowsTemp As Integer

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection
        docwidth = getDocWithForTables()

        'Add solution if it is set to true in settings
        If AddSolution = True Then
            AddSolutions()
        End If

        'Calculate the number of columns based on table or document width
        columns = 2

        'If no number is entered, then 10 rows are created. Error if alphanumeric is entered
        If IsNumeric(txtRows.Text) Then
            RowsTemp = CInt(txtRows.Text)
            txtRows.Text = RowsTemp 'Updates the entered value if a comma seperated value was entered
            check = True
        Else
            If txtRows.Text = "" Then
                RowsTemp = CInt(LKTool.MCRows)
                check = True
            Else
                MsgBox("Bitte geben Sie die Anzahl der Zeilen ein.", MsgBoxStyle.Information, "LKTools")
                check = False
            End If
        End If

        If check = True Then

            'Define the list
            mylt = document.ListTemplates.Add(OutlineNumbered:=True)

            'Checkbox left or right
            CheckboxAllignRight = LKTool.chkMCAllignRight

            'Define the list levels
            With mylt.ListLevels(1)
                .NumberStyle = WdListNumberStyle.wdListNumberStyleLowercaseLetter
                .NumberPosition = Globals.ThisAddIn.Application.InchesToPoints(0)
                .TextPosition = Globals.ThisAddIn.Application.InchesToPoints(0.2)
                .NumberFormat = "%1)"
            End With

            'create the table
            document.Tables.Add(Range:=cursor.Range, NumRows:=RowsTemp, NumColumns:=columns,
                                DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                                AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
            With cursor.Tables(1) '.Cell(1, 2).Range.ParagraphFormat.CharacterUnitFirstLineIndent
                .PreferredWidth = getDocWithForTables()
                .AllowAutoFit = False
                .ApplyStyleHeadingRows = False
                .ApplyStyleLastRow = False
                .ApplyStyleFirstColumn = False
                .ApplyStyleLastColumn = False
                .ApplyStyleRowBands = False
                .ApplyStyleColumnBands = False
                .Borders.InsideColor = LKTool.ObjectTextColor
                .Borders.OutsideColor = LKTool.ObjectTextColor
                If CheckboxAllignRight = False Then
                    .Columns(1).Width = 20
                    .Columns(2).Width = docwidth - 40
                    i = 1
                    Do While i <= RowsTemp
                        With .Cell(i, 2)
                            .Range.ListFormat.ApplyListTemplate(mylt)
                            .Width = docwidth - 30
                        End With
                        With .Cell(i, 1)
                            .Range.Font.TextColor.RGB = ColorVisible
                            .Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
                        End With
                        i = i + 1
                    Loop
                Else
                    .Columns(2).Width = 20
                    .Columns(1).Width = docwidth - 40
                    i = 1
                    Do While i <= RowsTemp
                        With .Cell(i, 1)
                            .Range.ListFormat.ApplyListTemplate(mylt)
                            .Width = docwidth - 30
                        End With
                        With .Cell(i, 2)
                            .Range.Font.TextColor.RGB = ColorVisible
                            .Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
                        End With
                        i = i + 1
                    Loop
                End If
            End With

            'Cursor is moved to the first right column
            If CheckboxAllignRight = True Then
                cursor.MoveRight(1)
            End If
        End If
    End Sub

    'Create a table for true/false exercise
    Private Sub btnTrueFalse_Click(sender As Object, e As RibbonControlEventArgs) Handles btnTrueFalse.Click
        '#######################################################
        'Add true/false Choice template, that can be used in tests or on work sheets
        '#######################################################

        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim i As Integer = 2
        Dim j As Integer = 2
        Dim columns As Integer 'The number of calculated columns that should be entered based on the width
        Dim docwidth As Single
        Dim mylt As ListTemplate
        Dim check As Boolean
        Dim RowsTemp As Integer

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection
        docwidth = getDocWithForTables()

        'Add solution if it is set to true in settings
        If AddSolution = True Then
            AddSolutions()
        End If

        'Calculate the number of columns based on table or document width
        If LKTool.TrueFalseReason = True Then
            columns = 4
        Else
            columns = 3
        End If

        'If no number is entered, then 10 rows are created. Error if alphanumeric is entered
        If IsNumeric(txtRows.Text) Then
            RowsTemp = CInt(txtRows.Text) + 1
            txtRows.Text = RowsTemp - 1 'Updates the entered value if a comma seperated value was entered
            check = True
        Else
            If txtRows.Text = "" Then
                RowsTemp = CInt(LKTool.TrueFalseRows) + 1
                check = True
            Else
                MsgBox("Bitte geben Sie die Anzahl der Zeilen ein.", MsgBoxStyle.Information, "LKTools")
                check = False
            End If
        End If

        If check = True Then
            'Define the list
            mylt = document.ListTemplates.Add(OutlineNumbered:=True)

            'Define the list levels
            With mylt.ListLevels(1)
                .NumberStyle = WdListNumberStyle.wdListNumberStyleLowercaseLetter
                .NumberPosition = Globals.ThisAddIn.Application.InchesToPoints(0)
                .TextPosition = Globals.ThisAddIn.Application.InchesToPoints(0.2)
                .NumberFormat = "%1)"
            End With

            'create the table
            document.Tables.Add(Range:=cursor.Range, NumRows:=RowsTemp, NumColumns:=columns,
                                DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                                AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
            With cursor.Tables(1) '.Cell(1, 2).Range.Font.TextColor
                .PreferredWidth = docwidth
                .AllowAutoFit = False
                .ApplyStyleHeadingRows = False
                .ApplyStyleLastRow = False
                .ApplyStyleFirstColumn = False
                .ApplyStyleLastColumn = False
                .ApplyStyleRowBands = False
                .ApplyStyleColumnBands = False
                .Borders.InsideColor = LKTool.ObjectTextColor
                .Borders.OutsideColor = LKTool.ObjectTextColor
                If LKTool.TrueFalseReason = True Then
                    .Columns(2).Width = 50
                    .Columns(3).Width = 50
                    .Columns(4).Width = ((docwidth - .Columns(2).Width - .Columns(3).Width) / 2) - 10
                    .Columns(1).Width = docwidth - .Columns(2).Width - .Columns(3).Width - .Columns(4).Width
                    .Cell(1, 2).Range.Text = LKTool.TrueFalseTrueDesc
                    .Cell(1, 3).Range.Text = LKTool.TrueFalseFalseDesc
                    .Cell(1, 4).Range.Text = LKTool.TrueFalseReasonDesc
                Else
                    .Columns(2).Width = 50
                    .Columns(3).Width = 50
                    .Columns(1).Width = docwidth - .Columns(2).Width - .Columns(3).Width
                    .Cell(1, 2).Range.Text = LKTool.TrueFalseTrueDesc
                    .Cell(1, 3).Range.Text = LKTool.TrueFalseFalseDesc
                End If
                i = 2
                Do Until i > columns
                    .Cell(1, i).Range.Bold = True
                    .Cell(1, i).Range.Font.Name = "ARIAL"
                    .Cell(1, i).Range.Font.Size = 11
                    i = i + 1
                Loop
                j = 2
                Do Until j > RowsTemp
                    i = 2
                    Do Until i > columns
                        .Cell(j, i).Range.Font.TextColor.RGB = ColorVisible
                        i = i + 1
                    Loop
                    j = j + 1
                Loop
                j = 2
                Do Until j > RowsTemp
                    i = 2
                    Do Until i > columns
                        .Cell(j, i).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
                        .Cell(j, i).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
                        i = i + 1
                    Loop
                    .Cell(j, 1).Range.ListFormat.ApplyListTemplate(mylt)
                    j = j + 1
                Loop
            End With

            'Cursor is moved to correct position (workaround because movedown(1) doesn't work)
            My.Computer.Keyboard.SendKeys("{down}")
        End If
    End Sub

    'Create a table template for exams
    Private Sub btnExam_Click(sender As Object, e As RibbonControlEventArgs) Handles btnExam.Click
        '#######################################################
        'Add table template, that can be used in tests or on work sheets
        '#######################################################

        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim columns As Integer 'The number of calculated columns that should be entered based on the width
        Dim mylt As ListTemplate
        Dim check As Boolean
        Dim i As Integer
        Dim RowsTemp As Integer

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection

        'Calculate the number of columns based on table or document width
        columns = 3

        'If no number is entered, then 1 row is created. Error if alphanumeric is entered
        If IsNumeric(txtRows.Text) Then
            RowsTemp = CInt(txtRows.Text)
            txtRows.Text = RowsTemp 'Updates the entered value if a comma seperated value was entered
            check = True
        Else
            If txtRows.Text = "" Then
                RowsTemp = 1
                check = True
            Else
                MsgBox("Bitte geben Sie die Anzahl der Zeilen ein.", MsgBoxStyle.Information, "LKTools")
                check = False
            End If
        End If

        If check = True Then
            'Define the list
            mylt = document.ListTemplates.Add(OutlineNumbered:=True)

            'Add solution if activated
            If AddSolution = True Then
                AddSolutions()
            End If

            'Define the list levels
            With mylt.ListLevels(1)
                .NumberStyle = WdListNumberStyle.wdListNumberStyleArabic
                .NumberPosition = Globals.ThisAddIn.Application.InchesToPoints(0)
                .TextPosition = Globals.ThisAddIn.Application.InchesToPoints(0.2)
                .NumberFormat = "%1."
            End With

            'create the table
            document.Tables.Add(Range:=cursor.Range, NumRows:=RowsTemp, NumColumns:=columns,
                                DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                                AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
            With cursor.Tables(1)
                .PreferredWidth = getDocWithForTables()
                .AllowAutoFit = False
                .ApplyStyleHeadingRows = False
                .ApplyStyleLastRow = False
                .ApplyStyleFirstColumn = False
                .ApplyStyleLastColumn = False
                .ApplyStyleRowBands = False
                .ApplyStyleColumnBands = False
                .Borders.InsideColor = LKTool.ObjectTextColor
                .Borders.OutsideColor = LKTool.ObjectTextColor
                i = 1
                Do Until i > RowsTemp
                    .Cell(i, 1).Range.ListFormat.ApplyListTemplate(mylt)
                    .Cell(i, 1).Range.Font.Name = "ARIAL"
                    .Cell(i, 1).Range.Font.Size = 11
                    .Cell(i, 1).Width = 20
                    .Cell(i, 2).Width = getDocWithForTables() - .Cell(1, 1).Width
                    .Cell(i, 3).Range.Text = "/ X" 'the points can be entered here
                    .Cell(i, 3).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight
                    'Color the border
                    .Cell(i, 2).Borders(WdBorderType.wdBorderLeft).LineStyle = WdLineStyle.wdLineStyleNone
                    .Cell(i, 2).Borders(WdBorderType.wdBorderRight).LineStyle = WdLineStyle.wdLineStyleDouble
                    .Cell(i, 3).Borders(WdBorderType.wdBorderRight).LineStyle = WdLineStyle.wdLineStyleNone
                    i = i + 1
                Loop
            End With

            'Cursor is moved to the first right column
            cursor.MoveRight(1)
        End If
    End Sub

    'Get the width of the document or of the table depending on the cursor position
    Function getDocWithForTables()
        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim docwith As Single 'Needed for calculating the correct with of the grid

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection

        'Check if cursor is in table or not to get correct width
        If cursor.Information(Word.WdInformation.wdWithInTable) Then
            docwith = cursor.Cells(1).Width 'eine Zelle weniger, da Abstand zum Rand
        Else
            docwith = cursor.PageSetup.PageWidth - cursor.PageSetup.LeftMargin - cursor.PageSetup.RightMargin 'Seitegröße in inch wo cursor steht
        End If
        'Return the result
        Return docwith
    End Function

    'Function returns the number of characters for a string
    ' AKTUELL NICHT VERWENDET: Zielt auf die Berechnung der Spaltenbreite bei TRUE/FALSE Aufgaben mit 
    ' variabler Textlänge ab.
    Function getStringWidth(strWord As String)
        Dim lngNumberOfCharacters As Long
        lngNumberOfCharacters = Len(strWord)
        Return lngNumberOfCharacters
    End Function

    'Action for clicking the checkbox "Lösung"
    Private Sub chkSolution_Click(sender As Object, e As RibbonControlEventArgs) Handles chkSolution.Click

        'Change the chkPrintSolution global variable if checkbox changed
        If chkSolution.Checked = True Then
            LKTool.chkPrintSolutionTemp = True
        Else
            LKTool.chkPrintSolutionTemp = False
        End If

    End Sub

    'Action for clicking the checkbox "Ohne Lösung"
    Private Sub chkNoSolution_Click(sender As Object, e As RibbonControlEventArgs) Handles chkNoSolution.Click

        'Change the chkPrintNoSolution global variable if checkbox changed
        If chkNoSolution.Checked = True Then
            LKTool.chkPrintNoSolutionTemp = True
        Else
            LKTool.chkPrintNoSolutionTemp = False
        End If

    End Sub

    'action for clicking the button "Erweiterte PDF Ausgabe"
    Private Sub btnExtendedPDF_Click(sender As Object, e As RibbonControlEventArgs) Handles btnExtendedPDF.Click

        'Call the PDFExport
        Dim frmPDFExport = System.Windows.Forms.Application.OpenForms

        If frmPDFExport.OfType(Of frmPDFExport).Any Then
            frmPDFExport.Item("frmPDFExport").Activate()
        Else
            Dim frmPDFExport2 = New frmPDFExport()
            frmPDFExport2.Show()
        End If

    End Sub

    'Add a folder path to the cursor position
    Private Sub btnFolderPath_Click(sender As Object, e As RibbonControlEventArgs) Handles btnFolderPath.Click
        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim i As Integer
        Dim NumberOfParentFolders As Integer
        Dim docPath As String
        Dim docFileName As String
        Dim check As Boolean = False
        Dim result As MsgBoxResult

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection
        docFileName = document.Name
        docPath = document.Path

        If docPath = "" Then
            result = MsgBox("Sie müssen das Dokument zunächst speichern. Dokument jetzt speichern?",
                   MsgBoxStyle.Information + MsgBoxStyle.YesNo, "LKTools")
            If result = MsgBoxResult.Yes Then
                document.Save()
                docFileName = document.Name
                docPath = document.Path
                check = True
            Else
                docFileName = ""
                check = False
                Exit Sub
            End If
        Else
            check = True
        End If

        If LKTool.PathOption = 3 And LKTool.PathAddDocumentName = False Then
            MsgBox("Einfügen nicht möglich, da kein Pfad und kein Dokumentenname gemäß Einstellungen eingefügt werden soll.",
                   MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "LKTools")
        End If

        If LKTool.PathOption = 1 Then
            cursor.Text = document.Path
            cursor.MoveRight()
        ElseIf LKTool.PathOption = 2 Then
            NumberOfParentFolders = PathNumberFolders 'number of parent folder to be shown '1 = direkt folder
            'Get number of parent path folders
            If document.Path.Split("\").Length > NumberOfParentFolders Then
                i = NumberOfParentFolders - 1
            Else
                NumberOfParentFolders = document.Path.Split("\").Length
                i = NumberOfParentFolders - 1
            End If

            'cursor.Text = "..\"
            ' cursor.MoveRight()
            Do Until i < 0
                If i > 0 Then
                    '0 gibt direkt Pfad zurück 1 die noch höhere Ebene
                    cursor.Text = StrReverse(Split(StrReverse(document.Path), "\")(i)) & "\" '0 gibt direkt Pfad zurück 1 die noch höhere Ebene
                Else
                    cursor.Text = StrReverse(Split(StrReverse(document.Path), "\")(i))
                End If
                i = i - 1
                cursor.MoveRight()
            Loop

        ElseIf LKTool.PathOption = 3 Then
            'Nothing
        Else
            'Nothing
        End If

        'Add document name if defined and add "\" if the path is shown
        If LKTool.PathAddDocumentName = True And
            LKTool.PathOption = 3 Then
            cursor.Text = document.Name
        ElseIf LKTool.PathAddDocumentName = True Then
            cursor.Text = "\" & document.Name
        End If

    End Sub

    'Defines if hiddentext should be printed or not.
    Private Sub chkPrintHiddenText_Click(sender As Object, e As RibbonControlEventArgs) Handles chkPrintHiddenText.Click

        If chkPrintHiddenText.Checked = True Then
            Globals.ThisAddIn.Application.Options.PrintHiddenText = True
        Else
            Globals.ThisAddIn.Application.Options.PrintHiddenText = False
        End If

    End Sub

    'Check word document extension
    Function isDocumentExtensionDocx()
        Dim document As Word.Document
        Dim docPath As String
        Dim docFileName As String
        Dim check As Boolean = False
        Dim result As MsgBoxResult

        document = Globals.ThisAddIn.Application.ActiveDocument
        docFileName = document.Name
        docPath = document.Path

        If docPath = "" Then
            result = MsgBox("Sie müssen das Dokument zunächst speichern. Dokument jetzt speichern?",
                   MsgBoxStyle.Information + MsgBoxStyle.YesNo, "LKTools")
            If result = MsgBoxResult.Yes Then
                document.Save()
                docFileName = document.Name
                docPath = document.Path
                check = True
            Else
                docFileName = ""
                check = False
                Return False
            End If
        Else
            check = True
        End If

        If check = True And Right(docFileName, 5) = ".docx" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Show the perentage in StatusBar 
    Sub showProgressBar(iCurrent As Integer, iMax As Integer, strText As String)
        Dim dPercentage As Integer

        'Caclulate the percentage done after 5 objects
        dPercentage = 100 * (iMax - iCurrent) / iMax

        Globals.ThisAddIn.Application.StatusBar = String.Format("LKTools: {0} {1}%. Bitte warten.", strText, dPercentage)

    End Sub

    Private Sub btnRevision_Click(sender As Object, e As RibbonControlEventArgs) Handles btnRevisionPage.Click

        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim columnCommentWidth As Double
        Dim revisionTable As Table
        Dim i As Integer = 1 'x coordinate in table


        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection

        If isDocumentExtensionDocx() = True Then
            'Cursor is set to the absolute first Line
            cursor.GoTo(What:=WdGoToItem.wdGoToLine, Which:=WdGoToDirection.wdGoToAbsolute, Count:=1)

            'If revision table exists, then add new row and insert date. Else create the table.
            If document.Bookmarks.Exists("RevisionTable") Then
                With cursor.Range.Tables.Item(1)
                    .Rows.Add()
                    .Cell(.Rows.Count(), 2).Range.Text = Date.Today
                    .Cell(.Rows.Count(), 3).Range.Text = Globals.ThisAddIn.Application.UserInitials
                End With
                'Cursor is moved to last row
                cursor.MoveDown(Count:=cursor.Range.Tables.Item(1).Rows.Count() - 1)
            Else
                'Freeze screen
                '   Globals.ThisAddIn.Application.ScreenUpdating = False

                'Add the revision table with Date, Version, Authoer and Comment columns

                'Get the columnWidth of the comment columns
                columnCommentWidth = getDocWithForTables() - Globals.ThisAddIn.Application.CentimetersToPoints(6)

                ''Leerzeichen einfügen
                cursor.Range.InsertBefore(" ")




                'Insert a table at the first page of the document
                document.Tables.Add(Range:=cursor.Range, NumRows:=2, NumColumns:=4,
                            DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                            AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
                With cursor
                    With .Tables(1)
                        .ApplyStyleHeadingRows = True
                        .ApplyStyleLastRow = False
                        .ApplyStyleFirstColumn = False
                        .ApplyStyleLastColumn = False
                        .ApplyStyleRowBands = False
                        .ApplyStyleColumnBands = False
                        .Borders.InsideColor = LKTool.ObjectTextColor
                        .Borders.OutsideColor = LKTool.ObjectTextColor

                    End With
                    .Bookmarks.Add("RevisionTable")
                    With .Tables(1)
                        .Cell(1, 1).Range.Text = "Version"
                        .Cell(1, 1).Range.Style = document.Styles("Standard")
                        .Cell(1, 1).Column.Width = Globals.ThisAddIn.Application.CentimetersToPoints(2)
                        .Cell(1, 2).Range.Text = "Datum"
                        .Cell(1, 2).Range.Style = document.Styles("Standard")
                        .Cell(1, 2).Column.Width = Globals.ThisAddIn.Application.CentimetersToPoints(2)
                        .Cell(1, 3).Range.Text = "Autor"
                        .Cell(1, 3).Range.Style = document.Styles("Standard")
                        .Cell(1, 3).Column.Width = Globals.ThisAddIn.Application.CentimetersToPoints(2)
                        .Cell(1, 4).Range.Text = "Kommentar"
                        .Cell(1, 4).Range.Style = document.Styles("Standard")
                        .Cell(1, 4).Column.Width = columnCommentWidth
                        .Cell(2, 1).Range.Style = document.Styles("Standard")

                        .Cell(2, 2).Range.Text = Date.Today
                        .Cell(2, 2).Range.Style = document.Styles("Standard")
                        .Cell(2, 3).Range.Text = Globals.ThisAddIn.Application.UserInitials
                        .Cell(2, 3).Range.Style = document.Styles("Standard")
                        .Cell(2, 4).Range.Style = document.Styles("Standard")
                    End With
                End With


                revisionTable = cursor.Tables(1)


                Do While i <= 4

                    With revisionTable.Cell(1, i).Range
                        .Font.Bold = True
                        .Font.Italic = False
                        .Font.Color = WdColor.wdColorBlack
                        .Font.Name = "Verdana"
                        .Font.Size = 10
                        .ParagraphFormat.SpaceAfter = 0
                        .ParagraphFormat.SpaceBefore = 0
                        .ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle
                    End With

                    With revisionTable.Cell(2, i).Range
                        .Font.Bold = False
                        .Font.Italic = False
                        .Font.Color = WdColor.wdColorBlack
                        .Font.Name = "Verdana"
                        .Font.Size = 11
                        .ParagraphFormat.SpaceAfter = 0
                        .ParagraphFormat.SpaceBefore = 0
                        .ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle
                    End With

                    i = i + 1
                Loop

                'Cursor is moved after the table and a section break is done.
                cursor.MoveDown(Count:=2)
                cursor.InsertBreak(Type:=Word.WdBreakType.wdSectionBreakNextPage)


                'Search current Page Footer
                document.ActiveWindow.ActivePane.View.SeekView = WdSeekView.wdSeekCurrentPageFooter


                With cursor.HeaderFooter.PageNumbers
                    .NumberStyle = Word.WdPageNumberStyle.wdPageNumberStyleArabic
                    .HeadingLevelForChapter = 0
                    .IncludeChapterNumber = False
                    .ChapterPageSeparator = Word.WdSeparatorType.wdSeparatorHyphen
                    .RestartNumberingAtSection = True
                    .StartingNumber = 1
                End With


                'After section break go back to main window
                document.ActiveWindow.ActivePane.View.SeekView = WdSeekView.wdSeekMainDocument

                cursor.GoTo(What:=WdGoToItem.wdGoToLine, Which:=WdGoToDirection.wdGoToAbsolute, Count:=1)
                cursor.MoveDown(Count:=2)
                cursor.Range.Style = document.Styles("Standard")

                'Cursor is moved to second row
                cursor.MoveUp(Count:=1)

                'Freeze screen
                Globals.ThisAddIn.Application.ScreenUpdating = True

            End If

        Else
            MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If


    End Sub

    Private Sub AddFooter()

        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim iPages As Integer

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection


        'Go to next section and open the footer
        cursor.GoTo(What:=WdGoToItem.wdGoToPage, Which:=WdGoToDirection.wdGoToNext, Count:=1)

        'Insert a table in the footer
        document.Tables.Add(Range:=cursor.Range, NumRows:=1, NumColumns:=5,
                        DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                        AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
        With cursor
            With .ParagraphFormat
                .SpaceAfter = 0
                .SpaceBefore = 0
                .LineSpacingRule = WdLineSpacing.wdLineSpaceSingle
            End With
            With .Font
                .Size = 11
                .Bold = False
                .TextColor.RGB = ObjectTextColor
            End With
            With .Tables(1)
                .ApplyStyleHeadingRows = False
                .ApplyStyleLastRow = False
                .ApplyStyleFirstColumn = False
                .ApplyStyleLastColumn = False
                .ApplyStyleRowBands = False
                .ApplyStyleColumnBands = False
                .Borders.InsideLineStyle = WdLineStyle.wdLineStyleNone
                .Borders.OutsideLineStyle = WdLineStyle.wdLineStyleNone
            End With
            .Bookmarks.Add("FooterTable")
        End With

        With cursor.Tables(1)
            .Cell(1, 1).Range.Fields.Add(
                                            Range:=cursor.Range,
                                            Type:=WdFieldType.wdFieldEmpty,
                                            Text:="FILENAME   ",
                                            PreserveFormatting:=True)
            .Cell(1, 1).Column.Width = Globals.ThisAddIn.Application.CentimetersToPoints(6)
        End With

        cursor.MoveRight(Count:=1)

        With cursor.Tables(1)
            .Cell(1, 2).Range.Fields.Add(Range:=cursor.Range,
                                            Type:=WdFieldType.wdFieldEmpty,
                                            Text:="PAGE  \* Arabic ",
                                            PreserveFormatting:=True)
            .Cell(1, 2).Column.Width = Globals.ThisAddIn.Application.CentimetersToPoints(0.7)
            .Cell(1, 2).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
            .Cell(1, 3).Range.Text = "/"
            .Cell(1, 3).Column.Width = Globals.ThisAddIn.Application.CentimetersToPoints(0.3)
            .Cell(1, 4).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        End With

        cursor.MoveRight(Count:=3)

        With cursor.Tables(1)
            .Cell(1, 4).Range.Fields.Add(Range:=cursor.Range,
                                            Type:=WdFieldType.wdFieldEmpty,
                                           Text:="SECTIONPAGES  \* Arabic ",
                                            PreserveFormatting:=True)
            .Cell(1, 4).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft

            .Cell(1, 4).Column.Width = Globals.ThisAddIn.Application.CentimetersToPoints(0.7)
            .Cell(1, 5).Range.Text = " @IT-Team Fürth"
            .Cell(1, 5).Column.Width = Globals.ThisAddIn.Application.CentimetersToPoints(6)
            .Cell(1, 5).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight
        End With


        'Speicherung der Seitenzahl in iPages
        iPages = cursor.Range.Information(WdInformation.wdNumberOfPagesInDocument) - 1

    End Sub

    Private Sub chkPDFRevision_Click(sender As Object, e As RibbonControlEventArgs) Handles chkPDFRevision.Click

        'Change the chkPrintSolution global variable if checkbox changed
        If chkPDFRevision.Checked = True Then
            LKTool.chkPDFRevisionTemp = True
        Else
            LKTool.chkPDFRevisionTemp = False
        End If

    End Sub

    Private Sub btnOverlay_Click(sender As Object, e As RibbonControlEventArgs) Handles btnOverlay.Click

        'Add a blue textbox that can be hidden afterwards.
        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim oShp As Word.Shape 'check if shape already exists.
        Dim leftCursor As Single 'Needed for calculating the correct with of the grid
        Dim topCursor As Single 'Needed for calculating the correct with of the grid

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection

        If isDocumentExtensionDocx() = True Then

            If CheckMSWordCompatiblityMode(document) = True Then

                'Get current cursor position
                leftCursor = cursor.Information(Word.WdInformation.wdHorizontalPositionRelativeToPage) + 20
                topCursor = cursor.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)

                'Create a red rectangle
                oShp = document.Shapes.AddShape(WdRectangleType.wdShapeRectangle, leftCursor, topCursor, 100, 20)
                oShp.Select(cursor) 'Select the created textbox

                'a overlay object is identified by the title "Overlay"
                oShp.Title = "Overlay"

                convertOverlayObject(cursor)
            End If

        Else
                MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If


    End Sub

    'Show the overlay objects
    Sub ShowOverlay()
        Dim rngStory As Word.Range
        Dim oShp As Word.Shape
        Dim document As Word.Document
        Dim iShapeAmount As Integer 'Save Number of total shapes
        Dim iShapeCurrent As Integer 'save remaining number of shapes

        document = Globals.ThisAddIn.Application.ActiveDocument

        If CheckMSWordCompatiblityMode(document) = True Then

            'Freeze screen
            Globals.ThisAddIn.Application.ScreenUpdating = False


            'Iterate through all story types in the current document
            For Each rngStory In document.StoryRanges
                'Iterate through all linked stories
                Do
                    On Error Resume Next
                    Select Case rngStory.StoryType
                        Case 1 ' Documentation see https://msdn.microsoft.com/de-de/library/office/ff844990.aspx
                            iShapeAmount = rngStory.ShapeRange.Count
                            iShapeCurrent = iShapeAmount
                            If rngStory.ShapeRange.Count > 0 Then
                                For Each oShp In rngStory.ShapeRange
                                    If oShp.Visible = False Then
                                        If oShp.Title = "Overlay" Then
                                            oShp.Visible = True
                                        End If

                                        'Decrement the amount of shapes
                                        iShapeCurrent = iShapeCurrent - 1

                                        If iShapeCurrent Mod 10 = 0 Then
                                            'Call sub for showing progess bar.
                                            showProgressBar(iShapeCurrent, iShapeAmount, "Überlagerungen einblenden")
                                        End If

                                    End If
                                Next
                            End If
                        Case Else
                            'Do Nothing
                    End Select
                    On Error GoTo 0
                    'Get next linked story (if any)
                    rngStory = rngStory.NextStoryRange
                Loop Until rngStory Is Nothing
            Next

            'Freeze screen
            Globals.ThisAddIn.Application.ScreenUpdating = True
        End If
    End Sub

    Function CheckMSWordCompatiblityMode(document As Word.Document)
        Dim result As MsgBoxResult

        If document.CompatibilityMode < 15 Then
            result = MsgBox("Sie müssen das Dokument zunächst ohne Kompatiblitätsmodus speichern." _
                            & vbCrLf & "Dadurch können Formatierungen verändert werden." _
                            & vbCrLf & "Dokument jetzt speichern?",
                   MsgBoxStyle.Information + MsgBoxStyle.YesNo, "LKTools")
            If result = MsgBoxResult.Yes Then
                'document.Save()
                document.SaveAs2(CompatibilityMode:=WdCompatibilityMode.wdCurrent)
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    'Hide the overlay objects
    Function HideOverlay()
        Dim rngStory As Word.Range
        Dim oShp As Word.Shape
        Dim document As Word.Document
        Dim iShapeAmount As Integer 'Save Number of total shapes
        Dim iShapeCurrent As Integer 'save remaining number of shapes
        Dim iCountOverlayItems As Integer = 0 'save number of overlayed objects

        document = Globals.ThisAddIn.Application.ActiveDocument
        'docFileNameOriginal = document.Name
        '        docPath = document.Path

        document = Globals.ThisAddIn.Application.ActiveDocument
        'HideOverlay only works for MS Word CompatibilityMode higher 
        If CheckMSWordCompatiblityMode(document) = True Then

            'Freeze screen
            Globals.ThisAddIn.Application.ScreenUpdating = False

            'Iterate through all story types in the current document
            For Each rngStory In document.StoryRanges
                'Iterate through all linked stories
                If rngStory.StoryType = 1 Then
                    iShapeAmount = rngStory.ShapeRange.Count
                    iShapeCurrent = iShapeAmount
                    If rngStory.ShapeRange.Count > 0 Then
                        For Each oShp In rngStory.ShapeRange
                            If oShp.Visible = True Then
                                'Hide all shapes having title "Overlay
                                If oShp.Title = "Overlay" Then
                                    iCountOverlayItems = iCountOverlayItems + 1
                                    oShp.Visible = False
                                End If
                            End If

                            'Decrement the amount of shapes
                            iShapeCurrent = iShapeCurrent - 1

                            If iShapeCurrent Mod 10 = 0 Then
                                'Call sub for showing progess bar.
                                showProgressBar(iShapeCurrent, iShapeAmount, "Überlagerungen ausblenden")
                            End If
                        Next


                    End If
                End If

            Next

            'Unfreeze the screen updates
            Globals.ThisAddIn.Application.ScreenUpdating = True
        End If

        Return iCountOverlayItems

    End Function

    'Sub is executed if the user clicks on "Überlagerung" --> "Alle einblenden"
    Private Sub btnShowOverlay_Click(sender As Object, e As RibbonControlEventArgs) Handles btnShowOverlay.Click
        'Functionality only works for docx
        If isDocumentExtensionDocx() = True Then
            ShowOverlay()
            ShowObjectsAndTexts()
        Else
            MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If
    End Sub

    'Sub is executed if the user clicks on "Überlagerung" --> "Alle ausblenden"
    Private Sub btnHideOverlay_Click(sender As Object, e As RibbonControlEventArgs) Handles btnHideOverlay.Click
        'Functionality only works for docx
        If isDocumentExtensionDocx() = True Then
            HideOverlay()

        Else
            MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If
    End Sub

    'Sub is executed if the user clicks on "Überlagerung" --> "Objekt ausblenden"
    Private Sub btnHideOverlaySelection_Click(sender As Object, e As RibbonControlEventArgs) Handles btnHideOverlaySelection.Click
        Dim document As Word.Document
        Dim cursor As Word.Selection
        Dim result As MsgBoxResult

        document = Globals.ThisAddIn.Application.ActiveDocument
        cursor = Globals.ThisAddIn.Application.Selection



        'If no object was selected, then the procedure is stopped
        If cursor.Type = WdSelectionType.wdSelectionNormal Or
               cursor.Type = WdSelectionType.wdSelectionFrame Or
               cursor.Type = WdSelectionType.wdSelectionIP Or
               cursor.Type = WdSelectionType.wdSelectionRow Or
               cursor.Type = WdSelectionType.wdSelectionColumn Or
               cursor.Type = WdSelectionType.wdSelectionBlock Then

            result = MsgBox("Es wurde kein Objekt ausgewählt. " & vbCrLf &
                       "Objekt ausblenden daher nicht möglich.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "LKTools")
            Exit Sub
        End If

        'the functionality works only for docx documents
        If isDocumentExtensionDocx() = True Then

            If CheckMSWordCompatiblityMode(document) = True Then

                'If the selected object is type "Overlay" and a shape, then it should be hidden
                'if it is a shape but not 'Overlay" then the user can decide, wheather the object should be converted by LKTools
                'If the selected object is no shape but an inlineshape, the 
                If cursor.Type = WdSelectionType.wdSelectionShape Then
                    If cursor.ShapeRange.Title = "Overlay" Then
                        With cursor.ShapeRange
                            .Visible = False
                        End With

                    Else

                        result = MsgBox("Das ausgewählte Objekt ist keine Überlagerung. " & vbCrLf &
                              "Das Objekt kann automatisch umgewandelt werden. Dadurch verändert sich ggf. die Formatierung Ihres Dokumentes. " & vbCrLf &
                              vbCrLf &
                              "Soll das Objekt umgewandelt werden?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "LKTools")
                        If result = MsgBoxResult.Yes Then

                            convertOverlayObject(cursor)
                        End If
                    End If
                ElseIf cursor.Type = WdSelectionType.wdSelectionInlineShape Then

                    result = MsgBox("Das ausgewählte Objekt ist keine Überlagerung. " & vbCrLf &
                              "Das Objekt kann automatisch umgewandelt werden. Dadurch verändert sich ggf. die Formatierung Ihres Dokumentes. " & vbCrLf &
                              vbCrLf &
                              "Soll das Objekt umgewandelt werden?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "LKTools")
                    If result = MsgBoxResult.Yes Then

                        cursor.InlineShapes(1).ConvertToShape()
                        cursor.ShapeRange.WrapFormat.Type = WdWrapType.wdWrapFront

                        convertOverlayObject(cursor)
                    End If

                End If
            End If

        Else
                MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If

    End Sub


    'Converts a Shape to an "Overlay" Shape that can be hidden
    Sub convertOverlayObject(cursor As Word.Selection)

        If cursor.Type = WdSelectionType.wdSelectionInlineShape Then
            cursor.InlineShapes(1).ConvertToShape()
            cursor.ShapeRange.WrapFormat.Type = WdWrapType.wdWrapFront
        End If
        cursor.ShapeRange.Title = "Overlay"

        cursor.ShapeRange.Fill.ForeColor.RGB = LKTool.ColorOverlay
        cursor.ShapeRange.Fill.Transparency = LKTool.OverlayTransparency / 100
        With cursor.ShapeRange.Line
            .Visible = True 'Einblenden des Rahmens
            .ForeColor.RGB = ColorOverlay 'Standardfarbe
            .Weight = 3 'Rahmendicke
        End With


    End Sub

    'Function to switch on/off the overlay transparency 
    Private Sub tglOverlayTransparency_Click(sender As Object, e As RibbonControlEventArgs) Handles tglOverlayTransparency.Click
        'Functionality only works for docx
        If isDocumentExtensionDocx() = True Then

            If tglOverlayTransparency.Checked = True Then
                SetOverlayTransparency(LKTool.OverlayTransparency)
            Else
                SetOverlayTransparency(0)
            End If
        Else
            MsgBox("Sorry, diese Funktion ist nur für .docx Dokumente möglich.")
        End If
    End Sub

    'Procedure to set the overlay transparency
    Sub SetOverlayTransparency(value As Integer)
        Dim rngStory As Word.Range
        Dim oShp As Word.Shape
        Dim document As Word.Document
        Dim iShapeAmount As Integer 'Save Number of total shapes
        Dim iShapeCurrent As Integer 'save remaining number of shapes

        document = Globals.ThisAddIn.Application.ActiveDocument

        If CheckMSWordCompatiblityMode(document) = True Then


            'Freeze screen
            Globals.ThisAddIn.Application.ScreenUpdating = False

            'Iterate through all story types in the current document
            For Each rngStory In document.StoryRanges
                'Iterate through all linked stories
                If rngStory.StoryType = 1 Then
                    iShapeAmount = rngStory.ShapeRange.Count
                    iShapeCurrent = iShapeAmount
                    If rngStory.ShapeRange.Count > 0 Then
                        For Each oShp In rngStory.ShapeRange

                            If oShp.Title = "Overlay" Then
                                ''   oShp.Visible = False
                                oShp.Fill.Transparency = value / 100
                            End If

                            'Decrement the amount of shapes
                            iShapeCurrent = iShapeCurrent - 1

                            If iShapeCurrent Mod 10 = 0 Then
                                ''    'Call sub for showing progess bar.
                                showProgressBar(iShapeCurrent, iShapeAmount, "Überlagerungen ausblenden")
                            End If
                        Next
                    End If
                End If

            Next

            'Unfreeze the screen updates
            Globals.ThisAddIn.Application.ScreenUpdating = True

        End If

    End Sub

    'Toogle the presentation mode.
    Private Sub tglPresentation_Click(sender As Object, e As RibbonControlEventArgs) Handles tglPresentation.Click

        Dim document As Word.Document
        document = Globals.ThisAddIn.Application.ActiveDocument

        If tglPresentation.Checked = False Then
            Globals.ThisAddIn.Application.Options.CheckGrammarWithSpelling = True
            Globals.ThisAddIn.Application.Options.CheckGrammarAsYouType = True
            Globals.ThisAddIn.Application.Options.CheckSpellingAsYouType = True
            document.ActiveWindow.ActivePane.View.ShowAll = True 'Absatzmarke einblenden
        Else
            Globals.ThisAddIn.Application.Options.CheckGrammarWithSpelling = False
            Globals.ThisAddIn.Application.Options.CheckGrammarAsYouType = False
            Globals.ThisAddIn.Application.Options.CheckSpellingAsYouType = False
            document.ActiveWindow.ActivePane.View.ShowAll = False 'Absatzmarke ausblenden
        End If

        Globals.ThisAddIn.Application.ScreenRefresh()

    End Sub
End Class

