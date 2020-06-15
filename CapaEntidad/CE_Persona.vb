Public Class CE_Persona
#Region "CAMPOS"
    Private _ID_PERSONA As Integer
    Private _TIPO_PERSONA As String
    Private _NOM_PERSONA As String
    Private _TIPO_DOCUMENTO As String
    Private _NUM_DOCUMENTO As String
    Private _DIRECCION As String
    Private _TELEFONO As String
    Private _EMAIL As String
    Private _FECHA_CREACION As DateTime
    Private _ESTADO As Integer
#End Region
#Region "PROPIEDADES"
    Public Property ID_PERSONA() As Integer
        Get
            Return _ID_PERSONA
        End Get
        Set(value As Integer)
            _ID_PERSONA = value
        End Set
    End Property
    Public Property TIPO_PERSONA() As String
        Get
            Return _TIPO_PERSONA
        End Get
        Set(value As String)
            _TIPO_PERSONA = value
        End Set
    End Property
    Public Property NOM_PERSONA() As String
        Get
            Return _NOM_PERSONA
        End Get
        Set(value As String)
            _NOM_PERSONA = value
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
    Public Sub New(ByVal ID_PERSONA As Integer, ByVal TIPO_PERSONA As Integer, ByVal NOM_PERSONA As String,
                   ByVal TIPO_DOCUMENTO As String, ByVal NUM_DOCUMENTO As String, ByVal DIRECCION As String,
                   ByVal TELEFONO As String, ByVal EMAIL As String, ByVal FECHA_CREACION As DateTime,
                   ByVal ESTADO As Integer)
        _ID_PERSONA = ID_PERSONA
        _TIPO_PERSONA = TIPO_PERSONA
        _NOM_PERSONA = NOM_PERSONA
        _TIPO_DOCUMENTO = TIPO_DOCUMENTO
        _NUM_DOCUMENTO = NUM_DOCUMENTO
        _DIRECCION = DIRECCION
        _TELEFONO = TELEFONO
        _EMAIL = EMAIL
        _FECHA_CREACION = FECHA_CREACION
        _ESTADO = ESTADO
    End Sub
End Class
