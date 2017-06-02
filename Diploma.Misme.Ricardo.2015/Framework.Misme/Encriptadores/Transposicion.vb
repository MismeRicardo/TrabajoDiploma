Namespace Encriptadores

    Public Class Transposicion

#Region "encriptar(), te encripta el texto dado"
        Public Function encriptar(palabra As String) As String

            Dim resultado As String = ""
            For Each s In palabra

                Dim elAscii As Integer = Asc(s) + 2

                resultado += Chr(elAscii).ToString()
            Next

            Return resultado

        End Function
#End Region

#Region "desencriptar(), te desencripta el texo dado"
        Public Function desencriptar(palabra As String) As String
            Dim resultado As String = ""
            For Each s In palabra

                Dim elAscii As Integer = Asc(s) - 2

                resultado += Chr(elAscii).ToString()
            Next

            Return resultado
        End Function
#End Region

    End Class

End Namespace
