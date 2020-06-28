Imports System.Data.SqlClient
Imports CapaEntidad
Imports CapaDatos

Public Class CN_Cliente
    Private objetoCD As New CD_Cliente()

    Public Function N_MostrarCli() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = objetoCD.D_MostrarCliente
        Return tabla
    End Function

    Public Sub N_InsertarCli(enti As CE_Cliente)
        objetoCD.D_InsertarCliente(enti)
    End Sub

    Public Sub N_EditarCli(enti As CE_Cliente)
        objetoCD.D_EditarCliente(enti)
    End Sub

    Public Sub N_EliminarCli(enti As CE_Cliente)
        objetoCD.D_EliminarCliente(enti)
    End Sub
End Class
