Imports System.Resources

Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security

' Allgemeine Informationen über eine Assembly werden über die folgende 
' Attributgruppe gesteuert. Ändern Sie diese Attributwerte, um die Informationen zu ändern,
' die mit einer Assembly verknüpft sind.

' Die Werte der Assemblyattribute überprüfen

<Assembly: AssemblyTitle("LKTools")>
<Assembly: AssemblyDescription("Dieses Word Add-In erleichtert die Erstellung von Unterlagen, die im Rahmen der Schule benötigt werden.")>
<Assembly: AssemblyCompany("")> 
<Assembly: AssemblyProduct("LKTools")> 
<Assembly: AssemblyCopyright("Freeware / OpenSource")> 
<Assembly: AssemblyTrademark("")> 

' Durch Festlegen von ComVisible auf "false" werden die Typen in dieser Assembly unsichtbar 
' für COM-Komponenten. Wenn Sie auf einen Zugriffstyp in dieser Assembly aus 
' COM zugreifen müssen, legen Sie das ComVisible-Attribut für diesen Typ auf "true" fest.
<Assembly: ComVisible(False)> 

'Die folgende GUID ist für die ID der typelib, wenn dieses Projekt für COM verfügbar gemacht wird
<Assembly: Guid("e8d154ff-a946-48dc-9359-fe05db3421ee")>

' Versionsinformationen für eine Assembly bestehen aus den folgenden vier Werten:
'
'      Hauptversion
'      Nebenversion 
'      Buildnummer
'      Revision
'
' Sie können alle Werte angeben oder die standardmäßigen Build- und Revisionsnummern 
' übernehmen, indem Sie "*" eingeben:
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("0.4.14.0")>
<Assembly: AssemblyFileVersion("0.4.14.0")>

Friend Module DesignTimeConstants
    Public Const RibbonTypeSerializer As String = "Microsoft.VisualStudio.Tools.Office.Ribbon.Serialization.RibbonTypeCodeDomSerializer, Microsoft.VisualStudio.Tools.Office.Designer, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Public Const RibbonBaseTypeSerializer As String = "System.ComponentModel.Design.Serialization.TypeCodeDomSerializer, System.Design"
    Public Const RibbonDesigner As String = "Microsoft.VisualStudio.Tools.Office.Ribbon.Design.RibbonDesigner, Microsoft.VisualStudio.Tools.Office.Designer, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
End Module


