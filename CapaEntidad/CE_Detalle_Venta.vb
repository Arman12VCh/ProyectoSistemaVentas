Public Class CE_Detalle_Venta
#Region "CAMPOS"
    Private _ID_DETALLE_VENTA As Integer
    Private _FK_ID_VENTA As CE_Venta
    Private _FK_ID_PRODUCTO As CE_Producto
    Private _CANTIDAD As Integer
    Private _PRECIO As Double
    Private _DESCUENTO As Double
    Private _ESTADO As Integer
#End Region

#Region "PROPIEDADES"
    Public Property ID_DETALLE_VENTA() As Integer
        Get
            Return _ID_DETALLE_VENTA
        End Get
        Set(ByVal value As Integer)
            _ID_DETALLE_VENTA = value
        End Set
    End Property
    Public Property FK_ID_VENTA() As CE_Venta
        Get
            Return _FK_ID_VENTA
        End Get
        Set(ByVal value As CE_Venta)
            _FK_ID_VENTA = value
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
    Public Property DESCUENTO() As Double
        Get
            Return _DESCUENTO
        End Get
        Set(ByVal value As Double)
            _DESCUENTO = value
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
    Public Sub New(ByVal ID_DETALLE_VENTA As Integer, ByVal FK_ID_VENTA As CE_Venta,
                   ByVal FK_ID_PRODUCTO As CE_Producto, ByVal CANTIDAD As Integer, ByVal PRECIO As Double,
                   ByVal DESCUENTO As Double, ByVal ESTADO As Integer)
        _ID_DETALLE_VENTA = ID_DETALLE_VENTA
        _FK_ID_VENTA = FK_ID_VENTA
        _FK_ID_PRODUCTO = FK_ID_PRODUCTO
        _CANTIDAD = CANTIDAD
        _PRECIO = PRECIO
        _DESCUENTO = DESCUENTO
        _ESTADO = ESTADO
    End Sub
End Class
