Imports System.Data.SqlClient
Imports CapaEntidad

Public Class CD_Cliente
    Private cnn As CD_Conexion = New CD_Conexion()
    Private leer As SqlDataReader
    Private tabla As DataTable = New DataTable()
    Private cmd As SqlCommand = New SqlCommand()

    Public Function D_MostrarCliente() As DataTable
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_ClienteMostrar"
        cmd.CommandType = CommandType.StoredProcedure
        leer = cmd.ExecuteReader()
        tabla.Load(leer)
        cnn.CerrarConexion()
        Return tabla
    End Function

    Public Sub D_InsertarCliente(enti As CE_Cliente)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_ClienteInsertar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@NOMBRE", enti.NOMBRE)
        cmd.Parameters.AddWithValue("@APE_PATERNO", enti.APE_PATERNO)
        cmd.Parameters.AddWithValue("@APE_MATERNO", enti.APE_MATERNO)
        cmd.Parameters.AddWithValue("@DNI", enti.DNI)
        cmd.Parameters.AddWithValue("@GENERO", enti.GENERO)
        cmd.Parameters.AddWithValue("@TELEFONO", enti.TELEFONO)
        cmd.Parameters.AddWithValue("@DIRECCION", enti.DIRECCION)
        cmd.Parameters.AddWithValue("@EMAIL", enti.EMAIL)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub

    Public Sub D_EditarCliente(enti As CE_Cliente)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_ClienteEditar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@NOMBRE", enti.NOMBRE)
        cmd.Parameters.AddWithValue("@APE_PATERNO", enti.APE_PATERNO)
        cmd.Parameters.AddWithValue("@APE_MATERNO", enti.APE_MATERNO)
        cmd.Parameters.AddWithValue("@DNI", enti.DNI)
        cmd.Parameters.AddWithValue("@GENERO", enti.GENERO)
        cmd.Parameters.AddWithValue("@TELEFONO", enti.TELEFONO)
        cmd.Parameters.AddWithValue("@DIRECCION", enti.DIRECCION)
        cmd.Parameters.AddWithValue("@EMAIL", enti.EMAIL)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub

    Public Sub D_EliminarCliente(enti As CE_Cliente)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_ClienteEliminar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID_CLIENTE", enti.ID_CLIENTE)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub
End Class
