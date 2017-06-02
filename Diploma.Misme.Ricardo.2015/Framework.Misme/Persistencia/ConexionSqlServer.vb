Imports System.Data.SqlClient
Imports System.Reflection

Namespace Persistencia

    Public Class ConexionSqlServer
        Implements IConexion

#Region "Variables para la Conexion y la Transaccion          _sqlConnection - _unaTransaccion"

        Private _sqlConnection As SqlConnection
        Private _unaTransaccion As SqlTransaction

#End Region
       
#Region "Metodo para finalizar la Conexion       ConexionFinalizar()"

        Public Sub ConexionFinalizar() Implements IConexion.ConexionFinalizar

            _sqlConnection.Close()

        End Sub
#End Region

#Region "Metodo para Iniciar la Conexion       ConexionIniciar()"

        Public Sub ConexionIniciar(servidor As String, catalogo As String) Implements IConexion.ConexionIniciar

            Dim connectionString As String = ObtenerConnectionString(servidor, catalogo)

            _sqlConnection = New SqlConnection(connectionString)

            _sqlConnection.Open()

        End Sub
#End Region

#Region "Metodo para Realizar una consulta de tipo Escalar   EjecutarEscalar()"

        Public Function EjecutarEscalar(consulta As String, parametros As Dictionary(Of String, Object)) As Object Implements IConexion.EjecutarEscalar

            Dim unComando As New SqlCommand()

            '1) La conexion abierta.
            unComando.Connection = _sqlConnection
            unComando.Transaction = _unaTransaccion

            '2) Texto de la consulta.
            unComando.CommandText = consulta

            For Each p In parametros
                unComando.Parameters.AddWithValue(p.Key, p.Value)
            Next

            '3) Tipo de consulta.
            unComando.CommandType = CommandType.Text

            '4) Ejecutar y esperar el resultado.
            Return unComando.ExecuteScalar()

        End Function

#End Region

#Region "Metodo para Realizar un Insert , Delete o Update     EjecutarSinResultado()"

        Public Sub EjecutarSinResultado(consulta As String, parametros As Dictionary(Of String, Object)) Implements IConexion.EjecutarSinResultado

            Dim unComando As New SqlCommand()

            '1) La conexion abierta.
            unComando.Connection = _sqlConnection
            unComando.Transaction = _unaTransaccion

            '2) Texto de la consulta.
            unComando.CommandText = consulta

            For Each p In parametros
                unComando.Parameters.AddWithValue(p.Key, p.Value)
            Next

            '3) Tipo de consulta.
            unComando.CommandType = CommandType.Text

            '4) Ejecutar y esperar el resultado.
            unComando.ExecuteNonQuery()

        End Sub

#End Region

#Region "Metodo para Relizar una consulta de tipo Tupla   EjecutarTupla()"

        Public Function EjecutarTupla(Of T As {New, IConexionEjecutarResultado})(consulta As String, parametros As Dictionary(Of String, Object)) As List(Of T) Implements IConexion.EjecutarTupla

            Dim unComando As New SqlCommand()

            '1) La conexion abierta.
            unComando.Connection = _sqlConnection
            unComando.Transaction = _unaTransaccion

            '2) Texto de la consulta.
            unComando.CommandText = consulta

            For Each p In parametros
                unComando.Parameters.AddWithValue(p.Key, p.Value)
            Next

            '3) Tipo de consulta.
            unComando.CommandType = CommandType.Text

            '4) Ejecutar y esperar el resultado.
            Dim resultadoDataReader = unComando.ExecuteReader()

            Dim resultadoFinal As New List(Of T)

            Do While resultadoDataReader.Read()

                Dim resultadoObjeto As New T

                For i = 0 To resultadoDataReader.FieldCount - 1

                    Dim nombreColumna As String = resultadoDataReader.GetName(i)
                    Dim valorColumna As Object = resultadoDataReader(i)

                    Dim pi As PropertyInfo = resultadoObjeto.GetType().GetProperty(nombreColumna)
                    pi.SetValue(resultadoObjeto, valorColumna)

                Next

                resultadoFinal.Add(resultadoObjeto)
            Loop

            resultadoDataReader.Close()

            Return resultadoFinal

        End Function

#End Region

#Region "Metodo para Aceptar la Transaccion       TransaccionAceptar()"
        Public Sub TransaccionAceptar() Implements IConexion.TransaccionAceptar

            _unaTransaccion.Commit()

        End Sub
#End Region

#Region "Metodo para Cancelar la Transcaccion      TransaccionCancelar()"
        Public Sub TransaccionCancelar() Implements IConexion.TransaccionCancelar

            _unaTransaccion.Rollback()

        End Sub
#End Region

#Region "Metodo para Iniciar la Transaccion     TransaccionIniciar()"
        Public Sub TransaccionIniciar() Implements IConexion.TransaccionIniciar

            _unaTransaccion = _sqlConnection.BeginTransaction()

        End Sub
#End Region

#Region "Metodo para obtener el String del Connection      ObtenerConnectionString()"
        Private Function ObtenerConnectionString(servidor As String, catalogo As String) As String

            Return "Server=" + servidor + ";Database=" + catalogo + ";Trusted_Connection=True;"

        End Function
#End Region

    End Class
End Namespace

