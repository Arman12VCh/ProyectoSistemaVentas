Imports CapaEntidad
Imports System.Data.SqlClient

Public Class CD_Usuario
    Private conexion As SqlConnection = New SqlConnection()
    Private comando As SqlCommand = New SqlCommand()
    Private prm As SqlParameter = New SqlParameter()

    Public Function D_MostrarUsuario(ByVal cadenaConexion As String, ByVal entidad As CE_Usuario) As DataTable
        Try
            conexion.ConnectionString = cadenaConexion
            comando.Connection = conexion
            comando.CommandText = "SelUsuario"
            comando.CommandType = CommandType.StoredProcedure

            prm = comando.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100)
            prm.Direction = ParameterDirection.Input
            prm.Value = entidad.USUARIO

            prm = comando.Parameters.Add("@CONTRASEÑA", SqlDbType.VarBinary)
            prm.Direction = ParameterDirection.Input
            prm.Value = entidad.CONTRASEÑA

            'Dim da As SqlDataAdapter(comando)
            'Dim ds As DataSet
            'conexion.Open()
            'da.fill(ds, "Usuario")
            'conexion.Close()
            'Return ds.Tables("Usuario")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
