Namespace Compresores
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Winrar
#Region "Comprimir() sirve para comprimir archivos con RAR"

        Public Shared Sub Comprimir()
            Process.Start("Winrar.exe", "")
        End Sub
#End Region

#Region "Descomprimir() descomprime archivos RAR"

        Public Shared Sub Descomprimir(dirreccionArchivoComprimido As String, directorioDestino As String)
            Process.Start("C:\Program Files\WinRAR\UnRar.exe", "x -y " + dirreccionArchivoComprimido + " " + directorioDestino)
        End Sub

#End Region

    End Class
End Namespace

