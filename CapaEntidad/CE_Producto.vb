Public Class CE_Producto
#Region "CAMPOS"
    Private _ID_PRODUCTO As Integer
    Private _FK_ID_CATEGORIA As CE_Categoria
    Private _FK_ID_MARCA As CE_Marca
    Private _CODIGO As String
    Private _DESCRIPCION As String
    Private _PRECIO As Double
    Private _STOCK As Integer
    Private _ELIM_LOGICO As Integer
    Private _FECHA_INS As DateTime
    Private _FECHA_UPD As DateTime
    Private _FECHA_DEL As DateTime
#End Region
#Region "PROOPIEDADES"
    Public Property ID_PRODUCTO() As Integer
        Get
            Return _ID_PRODUCTO
        End Get
        Set(value As Integer)
            _ID_PRODUCTO = value
        End Set
    End Property
    Public Property FK_ID_CATEGORIA() As CE_Categoria
        Get
            Return _FK_ID_CATEGORIA
        End Get
        Set(value As CE_Categoria)
            _FK_ID_CATEGORIA = value
        End Set
    End Property
    Public Property FK_ID_MARCA() As CE_Marca
        Get
            Return _FK_ID_MARCA
        End Get
        Set(value As CE_Marca)
            _FK_ID_MARCA = value
        End Set
    End Property
    Public Property CODIGO() As String
        Get
            Return _CODIGO
        End Get
        Set(value As String)
            _CODIGO = value
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
    Public Property PRECIO() As Double
        Get
            Return _PRECIO
        End Get
        Set(value As Double)
            _PRECIO = value
        End Set
    End Property
    Public Property STOCK() As Integer
        Get
            Return _STOCK
        End Get
        Set(value As Integer)
            _STOCK = value
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

    Public Sub New(ID_PRODUCTO As Integer, FK_ID_CATEGORIA As CE_Categoria, FK_ID_MARCA As CE_Marca, CODIGO As String,
                   DESCRIPCION As String, PRECIO As Double, STOCK As Integer, ELIM_LOGICO As Integer, FECHA_INS As Date,
                   FECHA_UPD As Date, FECHA_DEL As Date)
        _ID_PRODUCTO = ID_PRODUCTO
        _FK_ID_CATEGORIA = FK_ID_CATEGORIA
        _FK_ID_MARCA = FK_ID_MARCA
        _CODIGO = CODIGO
        _DESCRIPCION = DESCRIPCION
        _PRECIO = PRECIO
        _STOCK = STOCK
        _ELIM_LOGICO = ELIM_LOGICO
        _FECHA_INS = FECHA_INS
        _FECHA_UPD = FECHA_UPD
        _FECHA_DEL = FECHA_DEL
    End Sub
End Class
