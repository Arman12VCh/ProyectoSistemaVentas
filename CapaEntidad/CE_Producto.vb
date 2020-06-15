Public Class CE_Producto
#Region "CAMPOS"
    Private _ID_PRODUCTO As Integer
    Private _FK_ID_CATEGORIA As CE_Categoria
    Private _FK_ID_MARCA As CE_Marca
    Private _COD_PRODUCTO As String
    Private _NOM_PRODUCTO As String
    Private _PRECIO As Double
    Private _STOCK As Integer
    Private _DESCRIPCION As String
    Private _ESTADO As Integer
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
    Public Property COD_PRODUCTO() As String
        Get
            Return _COD_PRODUCTO
        End Get
        Set(value As String)
            _COD_PRODUCTO = value
        End Set
    End Property
    Public Property NOM_PRODUCTO() As String
        Get
            Return _NOM_PRODUCTO
        End Get
        Set(value As String)
            _NOM_PRODUCTO = value
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
    Public Sub New(ByVal ID_PRODUCTO As Integer, ByVal FK_ID_CATEGORIA As CE_Categoria,
                   ByVal FK_ID_MARCA As CE_Marca, ByVal COD_PRODUCTO As String, ByVal NOM_PRODUCTO As String,
                   ByVal PRECIO As Double, ByVal STOCK As Integer, ByVal DESCRIPCION As String,
                   ByVal ESTADO As Integer)
        _ID_PRODUCTO = ID_PRODUCTO
        _FK_ID_CATEGORIA = FK_ID_CATEGORIA
        _FK_ID_MARCA = FK_ID_MARCA
        _COD_PRODUCTO = COD_PRODUCTO
        _NOM_PRODUCTO = NOM_PRODUCTO
        _PRECIO = PRECIO
        _STOCK = STOCK
        _DESCRIPCION = DESCRIPCION
        _ESTADO = ESTADO
    End Sub
End Class
