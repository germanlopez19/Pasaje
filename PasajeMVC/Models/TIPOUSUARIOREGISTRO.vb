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

Partial Public Class TIPOUSUARIOREGISTRO
    Public Property TIPOUSUARIO As String
    Public Property NOMBRE As String

    Public Overridable Property Cliente As ICollection(Of Cliente) = New HashSet(Of Cliente)
    Public Overridable Property Empleado As ICollection(Of Empleado) = New HashSet(Of Empleado)
    Public Overridable Property Usuario As ICollection(Of Usuario) = New HashSet(Of Usuario)

End Class
