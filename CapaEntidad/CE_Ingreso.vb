Public Class CE_Ingreso
#Region "CAMPOS"
    Private _ID_INGRESO As Integer
    Private _FK_ID_PROVEEDOR As CE_Persona
    Private _FK_ID_USUARIO As CE_Usuario
    Private _TIPO_COMPROBANTE As String
    Private _SERIE_COMPROBANTE As String
    Private _NUM_COMPROBANTE As String
    Private _FECHA_INGRESO As String
    Private _IMPUESTO As Double
    Private _TOTAL_INGRESO As Double
    Private _ESTADO_INGRESO As Integer
#End Region

#Region "PROPIEDADES"
    Public Property ID_INGRESO() As Integer
        Get
            Return _ID_INGRESO
        End Get
        Set(ByVal value As Integer)
            _ID_INGRESO = value
        End Set
    End Property
    Public Property FK_ID_PROVEEDOR() As CE_Persona
        Get
            Return _FK_ID_PROVEEDOR
        End Get
        Set(ByVal value As CE_Persona)
            _FK_ID_PROVEEDOR = value
        End Set
    End Property
    Public Property FK_ID_USUARIO() As CE_Usuario
        Get
            Return _FK_ID_USUARIO
        End Get
        Set(ByVal value As CE_Usuario)
            _FK_ID_USUARIO = value
        End Set
    End Property
    Public Property TIPO_COMPROBANTE() As String
        Get
            Return _TIPO_COMPROBANTE
        End Get
        Set(ByVal value As String)
            _TIPO_COMPROBANTE = value
        End Set
    End Property
    Public Property SERIE_COMPROBANTE() As String
        Get
            Return _SERIE_COMPROBANTE
        End Get
        Set(ByVal value As String)
            _SERIE_COMPROBANTE = value
        End Set
    End Property
    Public Property NUM_COMPROBANTE() As String
        Get
            Return _NUM_COMPROBANTE
        End Get
        Set(ByVal value As String)
            _NUM_COMPROBANTE = value
        End Set
    End Property
    Public Property FECHA_INGRESO() As String
        Get
            Return _FECHA_INGRESO
        End Get
        Set(ByVal value As String)
            _FECHA_INGRESO = value
        End Set
    End Property
    Public Property IMPUESTO() As Double
        Get
            Return _IMPUESTO
        End Get
        Set(ByVal value As Double)
            _IMPUESTO = value
        End Set
    End Property
    Public Property TOTAL_INGRESO() As Double
        Get
            Return _TOTAL_INGRESO
        End Get
        Set(ByVal value As Double)
            _TOTAL_INGRESO = value
        End Set
    End Property
    Public Property ESTADO_INGRESO() As Integer
        Get
            Return _ESTADO_INGRESO
        End Get
        Set(ByVal value As Integer)
            _ESTADO_INGRESO = value
        End Set
    End Property
#End Region
    Public Sub New()
    End Sub
    Public Sub New(ByVal ID_INGRESO As Integer, ByVal FK_ID_PROVEEDOR As CE_Persona,
                   ByVal FK_ID_USUARIO As CE_Usuario, ByVal TIPO_COMPROBANTE As String,
                   ByVal SERIE_COMPROBANTE As String, ByVal NUM_COMPROBANTE As String,
                   ByVal FECHA_INGRESO As String, ByVal IMPUESTO As Double, ByVal TOTAL_INGRESO As Double,
                   ByVal ESTADO_INGRESO As Integer)
        _ID_INGRESO = ID_INGRESO
        _FK_ID_PROVEEDOR = FK_ID_PROVEEDOR
        _FK_ID_USUARIO = FK_ID_USUARIO
        _TIPO_COMPROBANTE = TIPO_COMPROBANTE
        _SERIE_COMPROBANTE = SERIE_COMPROBANTE
        _NUM_COMPROBANTE = NUM_COMPROBANTE
        _FECHA_INGRESO = FECHA_INGRESO
        _IMPUESTO = IMPUESTO
        _TOTAL_INGRESO = TOTAL_INGRESO
        _ESTADO_INGRESO = ESTADO_INGRESO
    End Sub
End Class
