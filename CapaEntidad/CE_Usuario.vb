Public Class CE_Usuario
#Region "CAMPOS"
    Private _ID_USUARIO As Integer
    Private _FK_ID_ROL As CE_Rol
    Private _USUARIO As String
    Private _CONTRASEÑA As String
    Private _TIPO_DOCUMENTO As String
    Private _NUM_DOCUMENTO As String
    Private _DIRECCION As String
    Private _TELEFONO As String
    Private _EMAIL As String
    Private _FECHA_CREACION As DateTime
    Private _ESTADO As Integer
#End Region
#Region "PROPIEDADES"
    Public Property ID_USUARIO() As Integer
        Get
            Return _ID_USUARIO
        End Get
        Set(ByVal value As Integer)
            _ID_USUARIO = value
        End Set
    End Property

    Public Property FK_ID_ROL() As CE_Rol
        Get
            Return _FK_ID_ROL
        End Get
        Set(ByVal value As CE_Rol)
            _FK_ID_ROL = value
        End Set
    End Property

    Public Property USUARIO() As String
        Get
            Return _USUARIO
        End Get
        Set(ByVal value As String)
            _USUARIO = value
        End Set
    End Property

    Public Property CONTRASEÑA() As String
        Get
            Return _CONTRASEÑA
        End Get
        Set(ByVal value As String)
            _CONTRASEÑA = value
        End Set
    End Property

    Public Property TIPO_DOCUMENTO() As String
        Get
            Return _TIPO_DOCUMENTO
        End Get
        Set(value As String)
            _TIPO_DOCUMENTO = value
        End Set
    End Property
    Public Property NUM_DOCUMENTO() As String
        Get
            Return _NUM_DOCUMENTO
        End Get
        Set(value As String)
            _NUM_DOCUMENTO = value
        End Set
    End Property
    Public Property DIRECCION() As String
        Get
            Return _DIRECCION
        End Get
        Set(value As String)
            _DIRECCION = value
        End Set
    End Property
    Public Property TELEFONO() As String
        Get
            Return _TELEFONO
        End Get
        Set(value As String)
            _TELEFONO = value
        End Set
    End Property
    Public Property EMAIL() As String
        Get
            Return _EMAIL
        End Get
        Set(value As String)
            _EMAIL = value
        End Set
    End Property
    Public Property FECHA_CREACION() As DateTime
        Get
            Return _FECHA_CREACION
        End Get
        Set(value As DateTime)
            _FECHA_CREACION = value
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
    Public Sub New(ByVal ID_USUARIO As Integer, ByVal FK_ID_ROL As CE_Rol, ByVal USUARIO As String,
                   ByVal CONTRASEÑA As String, ByVal TIPO_DOCUMENTO As String, ByVal NUM_DOCUMENTO As String,
                   ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal EMAIL As String,
                   ByVal FECHA_CREACION As DateTime, ByVal ESTADO As Integer)
        _ID_USUARIO = ID_USUARIO
        _FK_ID_ROL = FK_ID_ROL
        _USUARIO = USUARIO
        _CONTRASEÑA = CONTRASEÑA
        _TIPO_DOCUMENTO = TIPO_DOCUMENTO
        _NUM_DOCUMENTO = NUM_DOCUMENTO
        _DIRECCION = DIRECCION
        _TELEFONO = TELEFONO
        _EMAIL = EMAIL
        _FECHA_CREACION = FECHA_CREACION
        _ESTADO = ESTADO
    End Sub
End Class
