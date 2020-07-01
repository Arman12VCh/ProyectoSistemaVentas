Imports CapaEntidad
Imports CapaDatos

Public Class CN_Marca
    Private objetoCD_Marca As New CD_Marca()

    Public Function N_MostrarMarca() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = objetoCD_Marca.D_MostrarMarca
        Return tabla
    End Function

    Public Sub N_InsertarMarca(enti As CE_Marca)
        objetoCD_Marca.D_InsertarMarca(enti)
    End Sub

    Public Sub N_EditarCli(enti As CE_Marca)
        objetoCD_Marca.D_EditarMarca(enti)
    End Sub

    Public Sub N_EliminarCli(enti As CE_Marca)
        objetoCD_Marca.D_EliminarMarca(enti)
    End Sub
End Class
