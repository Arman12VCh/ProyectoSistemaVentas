Public Class CE_Detalle_Ingreso
#Region "CAMPOS"
    Private _ID_DETALLE_INGRESO As Integer
    Private _FK_ID_INGRESO As CE_Ingreso
    Private _FK_ID_PRODUCTO As CE_Producto
    Private _CANTIDAD As Integer
    Private _PRECIO As Double
    Private _ESTADO As Integer
#End Region

#Region "PROPIEDADES"
    Public Property ID_DETALLE_INGRESO() As Integer
        Get
            Return _ID_DETALLE_INGRESO
        End Get
        Set(ByVal value As Integer)
            _ID_DETALLE_INGRESO = value
        End Set
    End Property

    Public Property FK_ID_INGRESO() As CE_Ingreso
        Get
            Return _FK_ID_INGRESO
        End Get
        Set(ByVal value As CE_Ingreso)
            _FK_ID_INGRESO = value
        End Set
    End Property

    Public Property FK_ID_PRODUCTO() As CE_Producto
        Get
            Return _FK_ID_PRODUCTO
        End Get
        Set(ByVal value As CE_Producto)
            _FK_ID_PRODUCTO = value
        End Set
    End Property

    Public Property CANTIDAD() As Integer
        Get
            Return _CANTIDAD
        End Get
        Set(ByVal value As Integer)
            _CANTIDAD = value
        End Set
    End Property

    Public Property PRECIO() As Double
        Get
            Return _PRECIO
        End Get
        Set(ByVal value As Double)
            _PRECIO = value
        End Set
    End Property

    Public Property ESTADO() As Integer
        Get
            Return _ESTADO
        End Get
        Set(ByVal value As Integer)
            _ESTADO = value
        End Set
    End Property
#End Region
    Public Sub New()
    End Sub

    Public Sub New(ByVal ID_DETALLE_INGRESO As Integer, ByVal FK_ID_INGRESO As CE_Ingreso,
                   ByVal FK_ID_PRODUCTO As CE_Producto, ByVal CANTIDAD As Integer, ByVal PRECIO As Double,
                   ByVal ESTADO As Integer)
        _ID_DETALLE_INGRESO = ID_DETALLE_INGRESO
        _FK_ID_INGRESO = FK_ID_INGRESO
        _FK_ID_PRODUCTO = FK_ID_PRODUCTO
        _CANTIDAD = CANTIDAD
        _PRECIO = PRECIO
        _ESTADO = ESTADO
    End Sub
End Class
