Public Class CE_Cliente
#Region "CAMPOS"
	Private _ID_CLIENTE As Integer
	Private _CODIGO As String
	Private _NOMBRE As String
	Private _APE_PATERNO As String
	Private _APE_MATERNO As String
	Private _DNI As String
	Private _GENERO As String
	Private _TELEFONO As String
	Private _DIRECCION As String
	Private _EMAIL As String
	Private _ESTADO As String
	Private _ELIM_LOGICO As Integer
	Private _FECHA_INS As DateTime
	Private _FECHA_UPD As DateTime
	Private _FECHA_DEL As DateTime
#End Region

#Region "PROPIEDADES"
	Public Property ID_CLIENTE As Integer
		Get
			Return _ID_CLIENTE
		End Get
		Set(value As Integer)
			_ID_CLIENTE = value
		End Set
	End Property
	Public Property CODIGO As String
		Get
			Return _CODIGO
		End Get
		Set(value As String)
			_CODIGO = value
		End Set
	End Property
	Public Property NOMBRE As String
		Get
			Return _NOMBRE
		End Get
		Set(value As String)
			_NOMBRE = value
		End Set
	End Property

	Public Property APE_PATERNO As String
		Get
			Return _APE_PATERNO
		End Get
		Set(value As String)
			_APE_PATERNO = value
		End Set
	End Property

	Public Property APE_MATERNO As String
		Get
			Return _APE_MATERNO
		End Get
		Set(value As String)
			_APE_MATERNO = value
		End Set
	End Property

	Public Property DNI As String
		Get
			Return _DNI
		End Get
		Set(value As String)
			_DNI = value
		End Set
	End Property

	Public Property GENERO As String
		Get
			Return _GENERO
		End Get
		Set(value As String)
			_GENERO = value
		End Set
	End Property

	Public Property TELEFONO As String
		Get
			Return _TELEFONO
		End Get
		Set(value As String)
			_TELEFONO = value
		End Set
	End Property

	Public Property DIRECCION As String
		Get
			Return _DIRECCION
		End Get
		Set(value As String)
			_DIRECCION = value
		End Set
	End Property

	Public Property EMAIL As String
		Get
			Return _EMAIL
		End Get
		Set(value As String)
			_EMAIL = value
		End Set
	End Property

	Public Property ESTADO As String
		Get
			Return _ESTADO
		End Get
		Set(value As String)
			_ESTADO = value
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

	Public Sub New(ID_CLIENTE As Integer, CODIGO As String, NOMBRE As String, APE_PATERNO As String,
				   APE_MATERNO As String, DNI As String, GENERO As String, TELEFONO As String,
				   DIRECCION As String, EMAIL As String, ESTADO As String, ELIM_LOGICO As Integer,
				   FECHA_INS As Date, FECHA_UPD As Date, FECHA_DEL As Date)
		_ID_CLIENTE = ID_CLIENTE
		_CODIGO = CODIGO
		_NOMBRE = NOMBRE
		_APE_PATERNO = APE_PATERNO
		_APE_MATERNO = APE_MATERNO
		_DNI = DNI
		_GENERO = GENERO
		_TELEFONO = TELEFONO
		_DIRECCION = DIRECCION
		_EMAIL = EMAIL
		_ESTADO = ESTADO
		_ELIM_LOGICO = ELIM_LOGICO
		_FECHA_INS = FECHA_INS
		_FECHA_UPD = FECHA_UPD
		_FECHA_DEL = FECHA_DEL
	End Sub
End Class
