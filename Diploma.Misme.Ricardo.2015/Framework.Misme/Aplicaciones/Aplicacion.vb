Namespace Aplicaciones
    
    Public Class Aplicacion

#Region "LanzarAplicacion(), abre una aplicacion"
        Public Shared Sub LanzarAplicacion(nombre As String)

            System.Diagnostics.Process.Start(nombre)
        End Sub
#End Region


#Region "CerrarAplicacion() , cierra una aplicacion"

        Public Shared Sub CerrarAplicacion(nombreAplicacion As String)

            Dim proc = Process.GetProcessesByName(nombreAplicacion)
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

        End Sub

#End Region

    End Class
End Namespace
