'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Pagina
    Public Property IIDPAGINA As Integer
    Public Property MENSAJE As String
    Public Property ACCION As String
    Public Property CONTROLADOR As String
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property RolPagina As ICollection(Of RolPagina) = New HashSet(Of RolPagina)

End Class
