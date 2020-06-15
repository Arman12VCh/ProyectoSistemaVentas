Public Class CE_Marca
#Region "CAMPOS"
    Private _ID_MARCA As Integer
    Private _NOM_MARCA As String
    Private _ESTADO As String
#End Region
#Region "PROPIEDADES"
    Public Property ID_MARCA() As Integer
        Get
            Return _ID_MARCA
        End Get
        Set(value As Integer)
            _ID_MARCA = value
        End Set
    End Property
    Public Property NOM_MARCA() As Integer
        Get
            Return _NOM_MARCA
        End Get
        Set(value As Integer)
            _NOM_MARCA = value
        End Set
    End Property
    Public Property ESTADO() As Integer
        Get
            Return _ESTADO
        End Get
        Set(value As Integer)
            _ESTADO = value
        End Set
    End Property
#End Region
    Public Sub New()
    End Sub
    Public Sub New(ByVal ID_MARCA As Integer, ByVal NOM_MARCA As String, ByVal ESTADO As Integer)
        _ID_MARCA = ID_MARCA
        _NOM_MARCA = NOM_MARCA
        _ESTADO = ESTADO
    End Sub
End Class
