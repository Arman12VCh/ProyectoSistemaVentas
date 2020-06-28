Imports CapaEntidad
Imports CapaDatos
Imports CapaNegocio
Imports System.Data.SqlClient

Public Class frmCliente
    Inherits System.Web.UI.Page

    Private objetoCN As CN_Cliente = New CN_Cliente()
    Private objetoCE As CE_Cliente = New CE_Cliente()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            objetoCE.NOMBRE = txtNombre.Text
            objetoCE.APE_PATERNO = txtApePaterno.Text
            objetoCE.APE_MATERNO = txtApeMaterno.Text
            objetoCE.DNI = txtDNI.Text
            objetoCE.GENERO = txtGenero.Text
            objetoCE.TELEFONO = txtTelefono.Text
            objetoCE.DIRECCION = txtDireccion.Text
            objetoCE.EMAIL = txtEmail.Text
            objetoCN.N_InsertarCli(objetoCE)
            MsgBox("Se guardó correctamente")

        Catch ex As Exception
            MsgBox("No se pudo guardar los datos por: " & ex.Message)
        End Try
    End Sub

    Protected Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            objetoCE.NOMBRE = txtNombre.Text
            objetoCE.APE_PATERNO = txtApePaterno.Text
            objetoCE.APE_MATERNO = txtApeMaterno.Text
            objetoCE.DNI = txtDNI.Text
            objetoCE.GENERO = txtGenero.Text
            objetoCE.TELEFONO = txtTelefono.Text
            objetoCE.DIRECCION = txtDireccion.Text
            objetoCE.EMAIL = txtEmail.Text
            objetoCN.N_EditarCli(objetoCE)
            MsgBox("Se editó  correctamente")

        Catch ex As Exception
            MsgBox("No se pudo editar los datos por: " & ex.Message)
        End Try
    End Sub
End Class