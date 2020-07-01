Imports System.Data.SqlClient
Imports CapaEntidad

Public Class CD_Marca
    Private cnn As CD_Conexion = New CD_Conexion()
    Private leer As SqlDataReader
    Private tabla As DataTable = New DataTable()
    Private cmd As SqlCommand = New SqlCommand()

    Public Function D_MostrarMarca() As DataTable
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_MarcaMostrar"
        cmd.CommandType = CommandType.StoredProcedure
        leer = cmd.ExecuteReader()
        tabla.Load(leer)
        cnn.CerrarConexion()
        Return tabla
    End Function

    Public Sub D_InsertarMarca(enti As CE_Marca)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_MarcaInsertar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@DESCRIPCION", enti.DESCRIPCION)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub

    Public Sub D_EditarMarca(enti As CE_Marca)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_MarcaEditar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@DESCRIPCION", enti.DESCRIPCION)
        cmd.Parameters.AddWithValue("@ID_MARCA", enti.ID_MARCA)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub

    Public Sub D_EliminarMarca(enti As CE_Marca)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_MarcaEliminar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID_MARCA", enti.ID_MARCA)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub
End Class
