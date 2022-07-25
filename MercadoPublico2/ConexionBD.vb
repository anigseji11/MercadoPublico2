Imports System.Data
Imports System.Data.SqlClient
Namespace Licitaciones
    Public Class ConexionBD

        Private CadenaConexion As String = $"Data Source=192.168.0.10;Initial Catalog=LICITACIONES;Persist Security Info=True;User ID=sa;Password=Softland400; Connection Timeout=30000"
        Private Conexion As SqlConnection = New SqlConnection(CadenaConexion)



        Public Function AbrirConexion() As SqlConnection
            If Conexion.State = ConnectionState.Closed Then Conexion.Open()
            Return Conexion
        End Function

        Public Function CerrarConexion() As SqlConnection
            If Conexion.State = ConnectionState.Open Then Conexion.Close()
            Return Conexion
        End Function
    End Class
End Namespace