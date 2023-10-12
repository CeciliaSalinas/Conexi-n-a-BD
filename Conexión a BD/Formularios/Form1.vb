'utilizamos el espacio de nombre y poder utilizar esos objetos del espacio de nombres
Imports System.Data.Sql
Imports System.Data.Sq
Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click

        'Abrir conexión declarando una nueva clase publica de tipo clselibreriasql en el archivo útiles
        Try
            MsgBox("Conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
