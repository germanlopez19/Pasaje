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

Partial Public Class Sucursal
    Public Property IIDSUCURSAL As Integer
    Public Property NOMBRE As String
    Public Property DIRECCION As String
    Public Property TELEFONO As String
    Public Property EMAIL As String
    Public Property FECHAAPERTURA As Nullable(Of Date)
    Public Property BHABILITADO As Nullable(Of Integer)

    Public Overridable Property Bus As ICollection(Of Bus) = New HashSet(Of Bus)

End Class
