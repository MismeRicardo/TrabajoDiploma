Imports Framework.Misme.Excepciones

Namespace Funciones

    Public Class Matematicas

#Region "Promedio(), calcula el promedio"
        'ParamArray cuando no sabes cuantos valores le vas a mandar
        Public Shared Function Promedio(ParamArray valores() As Double) As Double

            Dim acumulador As Double

            For Each valor In valores
                acumulador += valor

            Next

            Return (acumulador / valores.Length)

        End Function
#End Region
        
#Region "ObtenerPorcentaje(), devuelve el porcentaje"
        Public Shared Function ObtenerPorcentaje(valorEvaluar As Double, valorTotal As Double) As Double

            Return ((valorEvaluar * valorTotal) / 100)

        End Function
#End Region
       
#Region "ObtenerValorAleatorio(),te devuelve un numero aletorio "

        Private Shared proveedorRandom As New Random

        Public Shared Function ObtenerValorAleatorio(valorDesde As Double, valorHasta As Double) As Double

            If (valorDesde > valorHasta) Then
                Throw New FrameworkException()
            End If

            Return proveedorRandom.Next(valorDesde, valorHasta + 1)

        End Function

        'Finally ejecuta asi se haya producido una excepcion o un return
        ' sirve para la liberacion de recursos , puede haber un finally sin un catch

        Public Shared Function ObtenerValorAleatorio(valorDesde As Integer, valorHasta As Integer) As Integer

            Return ObtenerValorAleatorio(CDbl(valorDesde), CDbl(valorHasta))

        End Function

        'Public Sub CrearCarrera(nuevaCarrera As Carrera)

        '    'solo se pode identity si tiene una llavesita 
        '    Dim unaConexion As New ConexionSqlServer()

        '    unaConexion.ConexionIniciar("CARP-PC\SQLEXPRESS", "PreParcial")

        '    Dim parametros As New Dictionary(Of String, Object)

        '    parametros.Add("@NombreCarrera", nuevaCarrera.NombreCarrera)
        '    parametros.Add("@IdSede", nuevaCarrera.LaSede.IdSede)


        '    unaConexion.EjecutarSinResultado("Insert into Carrera values(@NombreCarrera,@IdSede)", parametros)

        '    unaConexion.ConexionFinalizar()


        'End Sub

#End Region

    End Class
End Namespace
