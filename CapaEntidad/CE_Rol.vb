Public Class CE_Rol
#Region "CAMPOS"
    Private _ID_ROL As Integer
    Private _NOM_ROL As String
    Private _DESCRIPCION As String
    Private _ESTADO As Integer
#End Region
#Region "PROPIEDADES"
    Public Property ID_ROL() As Integer
        Get
            Return _ID_ROL
        End Get
        Set(value As Integer)
            _ID_ROL = value
        End Set
    End Property
    Public Property NOM_ROL() As String
        Get
            Return _NOM_ROL
        End Get
        Set(value As String)
            _NOM_ROL = value
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
    Public Sub New(ByVal ID_ROL As Integer, ByVal NOM_ROL As String, ByVal DESCRIPCION As String,
                   ByVal ESTADO As String)
        _ID_ROL = ID_ROL
        _NOM_ROL = NOM_ROL
        _DESCRIPCION = DESCRIPCION
        _ESTADO = ESTADO
    End Sub
End Class
