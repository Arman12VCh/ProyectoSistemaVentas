Public Class CE_Venta
#Region "CAMPOS"
    Private _ID_VENTA As Integer
    Private _FK_ID_CLIENTE As CE_Persona
    Private _FK_ID_USUARIO As CE_Usuario
    Private _TIPO_COMPROBANTE As String
    Private _SERIE_COMPROBANTE As String
    Private _NUM_COMPROBANTE As String
    Private _FECHA_VENTA As DateTime
    Private _IMPUESTO As Double
    Private _TOTAL As Double
    Private _ESTADO As Integer
#End Region
#Region "PROPIEDADES"
    Public Property ID_VENTA() As Integer
        Get
            Return _ID_VENTA
        End Get
        Set(value As Integer)
            _ID_VENTA = value
        End Set
    End Property
    Public Property FK_ID_CLIENTE() As CE_Persona
        Get
            Return _FK_ID_CLIENTE
        End Get
        Set(value As CE_Persona)
            _FK_ID_CLIENTE = value
        End Set
    End Property
    Public Property FK_ID_USUARIO() As CE_Usuario
        Get
            Return _FK_ID_USUARIO
        End Get
        Set(value As CE_Usuario)
            _FK_ID_USUARIO = value
        End Set
    End Property
    Public Property TIPO_COMPROBANTE() As String
        Get
            Return _TIPO_COMPROBANTE
        End Get
        Set(value As String)
            _TIPO_COMPROBANTE = value
        End Set
    End Property
    Public Property SERIE_COMPROBANTE() As String
        Get
            Return _SERIE_COMPROBANTE
        End Get
        Set(value As String)
            _SERIE_COMPROBANTE = value
        End Set
    End Property
    Public Property NUM_COMPROBANTE() As String
        Get
            Return _NUM_COMPROBANTE
        End Get
        Set(value As String)
            _NUM_COMPROBANTE = value
        End Set
    End Property
    Public Property FECHA_VENTA() As DateTime
        Get
            Return _FECHA_VENTA
        End Get
        Set(value As DateTime)
            _FECHA_VENTA = value
        End Set
    End Property
    Public Property IMPUESTO() As Double
        Get
            Return _IMPUESTO
        End Get
        Set(value As Double)
            _IMPUESTO = value
        End Set
    End Property
    Public Property TOTAL() As Double
        Get
            Return _TOTAL
        End Get
        Set(value As Double)
            _TOTAL = value
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
    Public Sub New(ByVal ID_VENTA As Integer, ByVal FK_ID_CLIENTE As CE_Persona,
                   ByVal FK_ID_USUARIO As CE_Usuario, ByVal TIPO_COMPROBANTE As String,
                   ByVal SERIE_COMPROBANTE As String, ByVal NUM_COMPROBANTE As String,
                   ByVal FECHA_VENTA As DateTime, ByVal IMPUESTO As Double, ByVal TOTAL As Double,
                   ByVal ESTADO As Integer)
        _ID_VENTA = ID_VENTA
        _FK_ID_CLIENTE = FK_ID_CLIENTE
        _FK_ID_USUARIO = FK_ID_USUARIO
        _TIPO_COMPROBANTE = TIPO_COMPROBANTE
        _SERIE_COMPROBANTE = SERIE_COMPROBANTE
        _NUM_COMPROBANTE = NUM_COMPROBANTE
        _FECHA_VENTA = FECHA_VENTA
        _IMPUESTO = IMPUESTO
        _TOTAL = TOTAL
        _ESTADO = ESTADO
    End Sub
End Class
