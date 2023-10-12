Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ClsPersonaFisica
    Inherits ClsLibreriaSql

    'SE CREAN LOS ATRIBUTOS DE LA CLASE EN BASE A LOS CAMPOS DE LA TABLA QUE VOY A USAR
    Private idpersona As Integer
    Private nombre As String
    Private apellido As String
    Private sexo As String
    Private nacionalidad As String

    'SE CREA EL METODO CONSTRUCTOR DE ESTA CLASE, Y DENTRO DE LOS () PONEMOS LOS PARÁMETROS
    'CUANDO EL PARÁMETRO ES AUTOINCREMENTAL NO SE PONE COMO PARÁMETRO
    Public Sub New(nom As String, ape As String, sx As String, nac As String)
        'ESTADO INICIAL DE LOS PARAMETROS
        nombre = nom
        apellido = ape
        sexo = sx
        nacionalidad = nac

    End Sub

    'CREAMOS UN CONSTRUCTOR VACIO, PARA CREAR UN OBJETO DE TIPO PERSONAFISICA SIN ASIGANR UN ESTADO INICIAL A LOS PARAMETROS
    Public Sub New()

    End Sub

    Public Property nomPersona As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property apePersona As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property sxPersona As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value
        End Set
    End Property

    Public Property nacPersona As String
        Get
            Return nacionalidad
        End Get
        Set(value As String)
            nacionalidad = value
        End Set
    End Property

    'CREAMOS EL PRIMER METODO O FUNCION CRUD -> INSERT 
    'FUNCTION, PORQUE ME DEVUELVE UN VALOR DENTRO DE LOS () INSERTAR LOS PARÁMETROS
    Public Function insertarPersona(pf As ClsPersonaFisica) As Boolean

        SQL = "INSERT INTO [Sistema].[dbo].[PersonasFisicas]
           ([Nombre]
           ,[Apellido]
           ,[Sexo]
           ,[Nacionalidad]
     VALUES
    ('" & pf.nomPersona & "', '" & pf.apePersona & "','" & pf.sxPersona & "','" & pf.nacPersona & "',)"

    End Function

End Class
