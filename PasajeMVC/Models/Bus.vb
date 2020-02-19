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

Partial Public Class Bus
    Public Property IIDBUS As Integer
    Public Property IIDSUCURSAL As Nullable(Of Integer)
    Public Property IIDTIPOBUS As Nullable(Of Integer)
    Public Property PLACA As String
    Public Property FECHACOMPRA As Nullable(Of Date)
    Public Property IIDMODELO As Nullable(Of Integer)
    Public Property NUMEROFILAS As Nullable(Of Integer)
    Public Property NUMEROCOLUMNAS As Nullable(Of Integer)
    Public Property BHABILITADO As Nullable(Of Integer)
    Public Property DESCRIPCION As String
    Public Property OBSERVACION As String
    Public Property IIDMARCA As Nullable(Of Integer)

    Public Overridable Property Marca As Marca
    Public Overridable Property Modelo As Modelo
    Public Overridable Property Sucursal As Sucursal
    Public Overridable Property TipoBus As TipoBus
    Public Overridable Property DETALLEVENTA As ICollection(Of DETALLEVENTA) = New HashSet(Of DETALLEVENTA)
    Public Overridable Property Viaje As ICollection(Of Viaje) = New HashSet(Of Viaje)

End Class