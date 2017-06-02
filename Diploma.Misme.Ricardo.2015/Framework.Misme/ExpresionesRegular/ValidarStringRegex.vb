Imports System.Text.RegularExpressions


Namespace ExpresionesRegular

    Public Class ValidarStringRegex

        Public Shared Function CadenaVacia(cadenaDeTexto As String) As Boolean

            Dim respuesta = Regex.IsMatch(cadenaDeTexto, "^([a-zA-Z][0-9]{1,})$")

            Return respuesta

        

        End Function

        Public Shared Function CadenaSoloNumero(cadenaDeTexto As String) As Boolean

            Dim respuesta = Regex.IsMatch(cadenaDeTexto, "^([0-9]{1,})$")
            Return respuesta

        End Function

        Public Shared Function CadenaSoloLetras(cadenaDeTexto As String) As Boolean

            Dim respuesta = Regex.IsMatch(cadenaDeTexto, "^([a-zA-Z]{1,})$")
            Return respuesta

        End Function


        Public Shared Function CantidadCaracteres(cadena As String, minimo As Integer, maximo As Integer) As Boolean

            Dim r As Boolean

            Return r = Regex.IsMatch(cadena, "\d{" & minimo.ToString & "," & maximo.ToString & "}")
        End Function

        Public Shared Function CantidadCaracteres(cadena As String, minimo As Integer) As Boolean
            Dim r = Regex.IsMatch(cadena, "\d{" & minimo.ToString & ",}")

            Return r
        End Function

    End Class

End Namespace