Public Class CE_Detalle_Ingreso
#Region "CAMPOS"
    Private _ID_DETALLE_INGRESO As Integer
    Private _FK_ID_INGRESO As CE_Ingreso
    Private _FK_ID_PRODUCTO As CE_Producto
    Private _CANTIDAD As Integer
    Private _PRECIO As Double
    Private _ELIM_LOGICO As Integer
    Private _FECHA_INS As DateTime
    Private _FECHA_UPD As DateTime
    Private _FECHA_DEL As DateTime
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

    Public Property ELIM_LOGICO As Integer
        Get
            Return _ELIM_LOGICO
        End Get
        Set(value As Integer)
            _ELIM_LOGICO = value
        End Set
    End Property

    Public Property FECHA_INS As Date
        Get
            Return _FECHA_INS
        End Get
        Set(value As Date)
            _FECHA_INS = value
        End Set
    End Property

    Public Property FECHA_UPD As Date
        Get
            Return _FECHA_UPD
        End Get
        Set(value As Date)
            _FECHA_UPD = value
        End Set
    End Property

    Public Property FECHA_DEL As Date
        Get
            Return _FECHA_DEL
        End Get
        Set(value As Date)
            _FECHA_DEL = value
        End Set
    End Property
#End Region
    Public Sub New()
    End Sub

    Public Sub New(ID_DETALLE_INGRESO As Integer, FK_ID_INGRESO As CE_Ingreso, FK_ID_PRODUCTO As CE_Producto,
                   CANTIDAD As Integer, PRECIO As Double, ELIM_LOGICO As Integer, FECHA_INS As Date,
                   FECHA_UPD As Date, FECHA_DEL As Date)
        _ID_DETALLE_INGRESO = ID_DETALLE_INGRESO
        _FK_ID_INGRESO = FK_ID_INGRESO
        _FK_ID_PRODUCTO = FK_ID_PRODUCTO
        _CANTIDAD = CANTIDAD
        _PRECIO = PRECIO
        _ELIM_LOGICO = ELIM_LOGICO
        _FECHA_INS = FECHA_INS
        _FECHA_UPD = FECHA_UPD
        _FECHA_DEL = FECHA_DEL
    End Sub
End Class
