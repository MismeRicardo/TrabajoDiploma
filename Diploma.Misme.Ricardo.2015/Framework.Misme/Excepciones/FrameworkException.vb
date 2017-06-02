Namespace Excepciones

    Public Class FrameworkException
        Inherits Exception

#Region " El cuerpo del FrameworkExeption"
        Public Sub New()

        End Sub

        Public Sub New(excepcionInterna As Exception)
            MyBase.New("", excepcionInterna)
        End Sub

        Public Overrides ReadOnly Property Message As String
            Get
                Return "Ha ocurrido un error en el framework"
            End Get
        End Property
#End Region
        
    End Class

End Namespace