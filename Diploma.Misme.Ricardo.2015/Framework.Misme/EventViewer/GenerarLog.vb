Namespace EventViewer
    Public Class GenerarLog


        Public Shared Sub LogInformacion(origen As String, mensaje As String)
            If Not EventLog.SourceExists(origen) Then
                EventLog.CreateEventSource(origen, "Mis Logs")
            End If
            EventLog.WriteEntry(origen, mensaje, EventLogEntryType.Information)

        End Sub

        Public Shared Sub LogCritico(origen As String, mensaje As String)
            If Not EventLog.SourceExists(origen) Then
                EventLog.CreateEventSource(origen, "Mis Logs")
            End If
            EventLog.WriteEntry(origen, mensaje, EventLogEntryType.Error)

        End Sub

        Public Shared Sub LogWarning(origen As String, mensaje As String)
            If Not EventLog.SourceExists(origen) Then
                EventLog.CreateEventSource(origen, "Mis Logs")
            End If
            EventLog.WriteEntry(origen, mensaje, EventLogEntryType.Warning)
        End Sub



    End Class
End Namespace