
Namespace Aplicaciones
  
    Public Class MiAplicacion
#Region "con el metodo NombreAplicacion() muestra el nombre de tu aplicacion"
        Public Shared Function NombreAplicacion() As String
            Dim NombreApp As String = My.Application.Info.Title
            Return NombreApp
        End Function

#End Region

#Region "con el metodo DirectorioAplicaicon() devuelve el directorio de la aplicacion"

        Public Shared Function DirectorioAplicacion() As String
            Dim ruta As String = My.Application.Info.DirectoryPath
            Return ruta
        End Function

#End Region


    End Class
End Namespace