Public Class CE_Usuario
#Region "CAMPOS"
    Private _ID_USUARIO As Integer
    Private _FK_ID_ROL As CE_Rol
    Private _FK_ID_PERSONA As CE_Persona
    Private _USUARIO As String
    Private _CONTRASEÑA As String
    Private _FOTO As Byte
    Private _ELIM_LOGICO As Integer
    Private _FECHA_INS As DateTime
    Private _FECHA_UPD As DateTime
    Private _FECHA_DEL As DateTime
#End Region
#Region "PROPIEDADES"
    Public Property ID_USUARIO As Integer
        Get
            Return _ID_USUARIO
        End Get
        Set(value As Integer)
            _ID_USUARIO = value
        End Set
    End Property

    Public Property FK_ID_ROL As CE_Rol
        Get
            Return _FK_ID_ROL
        End Get
        Set(value As CE_Rol)
            _FK_ID_ROL = value
        End Set
    End Property

    Public Property FK_ID_PERSONA As CE_Persona
        Get
            Return _FK_ID_PERSONA
        End Get
        Set(value As CE_Persona)
            _FK_ID_PERSONA = value
        End Set
    End Property

    Public Property USUARIO As String
        Get
            Return _USUARIO
        End Get
        Set(value As String)
            _USUARIO = value
        End Set
    End Property

    Public Property CONTRASEÑA As String
        Get
            Return _CONTRASEÑA
        End Get
        Set(value As String)
            _CONTRASEÑA = value
        End Set
    End Property

    Public Property FOTO As Byte
        Get
            Return _FOTO
        End Get
        Set(value As Byte)
            _FOTO = value
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

    Public Sub New(ID_USUARIO As Integer, FK_ID_ROL As CE_Rol, FK_ID_PERSONA As CE_Persona, USUARIO As String,
                   CONTRASEÑA As String, FOTO As Byte, ELIM_LOGICO As Integer, FECHA_INS As Date, FECHA_UPD As Date,
                   FECHA_DEL As Date)
        _ID_USUARIO = ID_USUARIO
        _FK_ID_ROL = FK_ID_ROL
        _FK_ID_PERSONA = FK_ID_PERSONA
        _USUARIO = USUARIO
        _CONTRASEÑA = CONTRASEÑA
        _FOTO = FOTO
        _ELIM_LOGICO = ELIM_LOGICO
        _FECHA_INS = FECHA_INS
        _FECHA_UPD = FECHA_UPD
        _FECHA_DEL = FECHA_DEL
    End Sub
End Class
