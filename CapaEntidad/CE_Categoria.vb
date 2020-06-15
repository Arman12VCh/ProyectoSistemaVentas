Public Class CE_Categoria

#Region "CAMPOS"
    Private _ID_CATEGORIA As Integer
    Private _NOM_CATEGORIA As String
    Private _DESCRIPCION As String
    Private _ESTADO As Integer
#End Region

#Region "PROPIEDADES"
    Public Property ID_CATEGORIA() As Integer
        Get
            Return _ID_CATEGORIA
        End Get
        Set(value As Integer)
            _ID_CATEGORIA = value
        End Set
    End Property
    Public Property NOM_CATEGORIA() As String
        Get
            Return _NOM_CATEGORIA
        End Get
        Set(value As String)
            _NOM_CATEGORIA = value
        End Set
    End Property
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(value As String)
            _DESCRIPCION = value
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
    Public Sub New(ByVal ID_CATEGORIA As Integer, ByVal NOM_CATEGORIA As String, ByVal DESCRIPCION As String,
                   ByVal ESTADO As String)
        _ID_CATEGORIA = ID_CATEGORIA
        _NOM_CATEGORIA = NOM_CATEGORIA
        _DESCRIPCION = DESCRIPCION
        _ESTADO = ESTADO
    End Sub
End Class
