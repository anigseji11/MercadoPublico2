Imports System.Data
Imports System.Data.SqlClient
Namespace Licitaciones
    Public Class Procesos

        Private Conexion As ConexionBD = New ConexionBD()
        Private Comando As SqlCommand = New SqlCommand()
        Private tabla As DataTable = New DataTable()
        Public registro As DataSet = New DataSet()
        Private Adaptador As SqlDataAdapter = New SqlDataAdapter()
        Private LeerFilas As SqlDataReader
        Private ejecuto As Boolean

        'Public Function CompruebaLicitacion(ByVal IDLicitacion As String, ByVal Descripcion As String) As DataTable

        '    Comando.Connection = Conexion.AbrirConexion()
        '    Comando.CommandText = "SELECT * FROM LICITACION_PUBLICADA WHERE NUMERO_ADQUISICION = @IDLicitacion AND DESCRIPCION_PRODUCTO_O_SERVICIO = @Descripcion"
        '    Comando.Parameters.AddWithValue("@IDLicitacion", IDLicitacion)
        '    Comando.Parameters.AddWithValue("@Descripcion", Descripcion)
        '    Comando.CommandType = CommandType.Text
        '    LeerFilas = Comando.ExecuteReader()
        '    tabla.Load(LeerFilas)
        '    LeerFilas.Close()
        '    Comando.Parameters.Clear()
        '    Conexion.CerrarConexion()
        '    Return tabla
        'End Function
        Public Function CompruebaLicitacion2(ByVal IDLicitacion As String) As DataTable

            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT * FROM LICITACION_PUBLICADA_2 WHERE NUMERO_ADQUISICION = @IDLicitacion"
            Comando.Parameters.AddWithValue("@IDLicitacion", IDLicitacion)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function

        'Public Function InsertarLicitacion(ByVal NUMERO_ADQUISICION As String, ByVal TIPO_ADQUISICION As String, ByVal NOMBRE_ADQUISICION As String, ByVal DESCRIPCION As String, ByVal ORGANISMO As String,
        '                                ByVal REGION_COMPRADORA As String, ByVal FECHA_PUBLICACION As DateTime, ByVal FECHA_CIERRE As DateTime, ByVal DESCRIPCION_PRODUCTO As String, ByVal CODIGO_ONU As String,
        '                                ByVal UNIDAD_MEDIDA As String, ByVal CANTIDAD As Integer, ByVal GENERICO As String, ByVal NIVEL1 As String, ByVal NIVEL2 As String, ByVal NIVEL3 As String) As Boolean
        '    Comando.Parameters.Clear()
        '    Comando.Connection = Conexion.AbrirConexion()
        '    Comando.CommandText = "INSERT INTO LICITACION_PUBLICADA ([NUMERO_ADQUISICION], [TIPO_ADQUISICION], [NOMBRE_ADQUISICION], [DESCRIPCION], [ORGANISMO], [REGION_COMPRADORA], [FECHA_PUBLICACION], [FECHA_CIERRE], [DESCRIPCION_PRODUCTO_O_SERVICIO], [CODIGO_ONU], [UNIDAD_MEDIDA], [CANTIDAD], [GENERICO], [NIVEL1], [NIVEL2], [NIVEL3]) 
        '                            VALUES(@NUMERO_ADQUISICION, @TIPO_ADQUISICION, @NOMBRE_ADQUISICION, @DESCRIPCION, @ORGANISMO, @REGION_COMPRADORA, @FECHA_PUBLICACION, @FECHA_CIERRE, @DESCRIPCION_PRODUCTO, @CODIGO_ONU, @UNIDAD_MEDIDA, @CANTIDAD, @GENERICO, @NIVEL1, @NIVEL2, @NIVEL3)"
        '    Comando.Parameters.AddWithValue("@NUMERO_ADQUISICION", NUMERO_ADQUISICION)
        '    Comando.Parameters.AddWithValue("@TIPO_ADQUISICION", TIPO_ADQUISICION)
        '    Comando.Parameters.AddWithValue("@NOMBRE_ADQUISICION", NOMBRE_ADQUISICION)
        '    Comando.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION)
        '    Comando.Parameters.AddWithValue("@ORGANISMO", ORGANISMO)
        '    Comando.Parameters.AddWithValue("@REGION_COMPRADORA", REGION_COMPRADORA)
        '    Comando.Parameters.AddWithValue("@FECHA_PUBLICACION", FECHA_PUBLICACION)
        '    Comando.Parameters.AddWithValue("@FECHA_CIERRE", FECHA_CIERRE)
        '    Comando.Parameters.AddWithValue("@DESCRIPCION_PRODUCTO", DESCRIPCION_PRODUCTO)
        '    Comando.Parameters.AddWithValue("@CODIGO_ONU", CODIGO_ONU)
        '    Comando.Parameters.AddWithValue("@UNIDAD_MEDIDA", UNIDAD_MEDIDA)
        '    Comando.Parameters.AddWithValue("@CANTIDAD", CANTIDAD)
        '    Comando.Parameters.AddWithValue("@GENERICO", GENERICO)
        '    Comando.Parameters.AddWithValue("@NIVEL1", NIVEL1)
        '    Comando.Parameters.AddWithValue("@NIVEL2", NIVEL2)
        '    Comando.Parameters.AddWithValue("@NIVEL3", NIVEL3)

        '    Comando.CommandType = CommandType.Text
        '    ejecuto = (Comando.ExecuteNonQuery > 0)
        '    Conexion.CerrarConexion()
        '    Return ejecuto
        'End Function

        Public Function InsertarLicitacion2(NUMERO_ADQUISICION As String, TIPO_ADQUISICION As String, NOMBRE_ADQUISICION As String, DESCRIPCION As String, ORGANISMO As String,
                                         REGION_COMPRADORA As String, FECHA_PUBLICACION As DateTime, FECHA_CIERRE As DateTime, FECHA_ADJUDICACION As DateTime, FECHA_INICIO As DateTime,
                                          FECHA_FINAL As DateTime, FECHA_PUBRESPUESTAS As DateTime, FECHA_APERTURA As DateTime, ESTADO As Integer) As Boolean

            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "INSERT INTO LICITACION_PUBLICADA_2 ([NUMERO_ADQUISICION], [TIPO_ADQUISICION], [NOMBRE_ADQUISICION], [DESCRIPCION], [ORGANISMO], [REGION_COMPRADORA], [FECHA_PUBLICACION], [FECHA_CIERRE], [FECHA_ADJUDICACION], [FECHA_INICIO], [FECHA_FINAL], [FECHA_PUBRESPUESTAS], [FECHA_APERTURA], [ESTADOMP], FECHA_IMPORTACION) 
                                    VALUES(@NUMERO_ADQUISICION, @TIPO_ADQUISICION, @NOMBRE_ADQUISICION, @DESCRIPCION, @ORGANISMO, @REGION_COMPRADORA, @FECHA_PUBLICACION, @FECHA_CIERRE, @FECHA_ADJUDICACION, @FECHA_INICIO, @FECHA_FINAL, @FECHA_PUBRESPUESTAS, @FECHA_APERTURA, @ESTADO, GETDATE())"
            Comando.Parameters.AddWithValue("@NUMERO_ADQUISICION", NUMERO_ADQUISICION)
            Comando.Parameters.AddWithValue("@TIPO_ADQUISICION", TIPO_ADQUISICION)
            Comando.Parameters.AddWithValue("@NOMBRE_ADQUISICION", NOMBRE_ADQUISICION)
            Comando.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION)
            Comando.Parameters.AddWithValue("@ORGANISMO", ORGANISMO)
            Comando.Parameters.AddWithValue("@REGION_COMPRADORA", REGION_COMPRADORA)
            Comando.Parameters.AddWithValue("@FECHA_PUBLICACION", FECHA_PUBLICACION)
            Comando.Parameters.AddWithValue("@FECHA_CIERRE", FECHA_CIERRE)
            Comando.Parameters.AddWithValue("@FECHA_ADJUDICACION", FECHA_ADJUDICACION)
            Comando.Parameters.AddWithValue("@FECHA_INICIO", FECHA_INICIO)
            Comando.Parameters.AddWithValue("@FECHA_FINAL", FECHA_FINAL)
            Comando.Parameters.AddWithValue("@FECHA_PUBRESPUESTAS", FECHA_PUBRESPUESTAS)
            Comando.Parameters.AddWithValue("@FECHA_APERTURA", FECHA_APERTURA)
            Comando.Parameters.AddWithValue("@ESTADO", ESTADO)


            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function
        Public Function InsertarDetalleLicitacion(ByVal NUMERO_ADQUISICION As String, ByVal DESCRIPCION_PRODUCTO As String, ByVal CODIGO_ONU As String,
                                        ByVal UNIDAD_MEDIDA As String, ByVal CANTIDAD As Integer, ByVal NOMBRE_PRODUCTO As String,
                                        ByVal CATEGORIA As String, ByVal CORRELATIVO As Integer) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "INSERT INTO DETALLE_LICITACION ([NUMERO_ADQUISICION], [DESCRIPCION_PRODUCTO_O_SERVICIO], [CODIGO_ONU], [UNIDAD_MEDIDA], [CANTIDAD], [NOMBRE_PRODUCTO], [CATEGORIA], [CORRELATIVO]) 
                                    VALUES(@NUMERO_ADQUISICION, @DESCRIPCION_PRODUCTO, @CODIGO_ONU, @UNIDAD_MEDIDA, @CANTIDAD, @NOMBRE_PRODUCTO, @CATEGORIA, @CORRELATIVO)"
            Comando.Parameters.AddWithValue("@NUMERO_ADQUISICION", NUMERO_ADQUISICION)
            Comando.Parameters.AddWithValue("@DESCRIPCION_PRODUCTO", DESCRIPCION_PRODUCTO)
            Comando.Parameters.AddWithValue("@CODIGO_ONU", CODIGO_ONU)
            Comando.Parameters.AddWithValue("@UNIDAD_MEDIDA", UNIDAD_MEDIDA)
            Comando.Parameters.AddWithValue("@CANTIDAD", CANTIDAD)
            Comando.Parameters.AddWithValue("@NOMBRE_PRODUCTO", NOMBRE_PRODUCTO)
            Comando.Parameters.AddWithValue("@CATEGORIA", CATEGORIA)
            Comando.Parameters.AddWithValue("@CORRELATIVO", CORRELATIVO)

            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function
        Public Function InsertarPalabra(ByVal Palabra As String) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "INSERT INTO PALABRAS_CLAVE(PALABRA) VALUES(@Palabra)"
            Comando.Parameters.AddWithValue("@Palabra", Palabra)
            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function

        Public Function EliminarPalabra(ByVal Palabra As String) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "DELETE FROM PALABRAS_CLAVE WHERE PALABRA = @Palabra"
            Comando.Parameters.AddWithValue("@Palabra", Palabra)
            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function
        Public Function PalabrasClave() As DataTable

            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT PALABRA FROM PALABRAS_CLAVE ORDER BY PALABRA ASC"
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function SelectSimple(Palabra As String) As DataTable

            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = $"SELECT REGISTRO_ID, ORGANISMO, NUMERO_ADQUISICION, NOMBRE_ADQUISICION, DESCRIPCION, DESCRIPCION_PRODUCTO_O_SERVICIO FROM LICITACION_PUBLICADA WHERE (UPPER(NOMBRE_ADQUISICION)) LIKE '%{Palabra}%' OR (UPPER(DESCRIPCION)) LIKE '%{Palabra}%' OR (UPPER(DESCRIPCION_PRODUCTO_O_SERVICIO)) LIKE '%{Palabra}%'"

            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function


        Public Function SelectAvanzado(consultas As String) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = consultas
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function

        Public Function Seleccionar(ByVal id As String, ByVal estado As Integer) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "UPDATE LICITACION_PUBLICADA_2 SET ESTADO = @estado where NUMERO_ADQUISICION = @id"
            Comando.Parameters.AddWithValue("@id", id)
            Comando.Parameters.AddWithValue("@estado", estado)
            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function
        Public Function Seleccionar2(ByVal id As String, estado2 As Integer) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "UPDATE LICITACION_PUBLICADA_2 SET ESTADO2 = @estado2 where NUMERO_ADQUISICION = @id"
            Comando.Parameters.AddWithValue("@id", id)
            Comando.Parameters.AddWithValue("@estado2", estado2)
            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function
        Public Function ComboEstado() As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT * FROM ESTADO"
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function

        Public Function TraeSeleccion(estado As Integer) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT NUMERO_ADQUISICION, NOMBRE_ADQUISICION, DESCRIPCION, ORGANISMO, 'https://www.mercadopublico.cl/Procurement/Modules/RFB/DetailsAcquisition.aspx?idLicitacion=' + NUMERO_ADQUISICION as Link FROM LICITACION_PUBLICADA_2 WHERE ESTADO = @estado group by NUMERO_ADQUISICION, NOMBRE_ADQUISICION, DESCRIPCION, ORGANISMO"
            Comando.Parameters.AddWithValue("@estado", estado)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function TraeSeleccionAvanzada(estado As Integer) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT REGISTRO_ID, NUMERO_ADQUISICION, NOMBRE_ADQUISICION, DESCRIPCION, ORGANISMO, FECHA_PUBLICACION, FECHA_CIERRE, 'https://www.mercadopublico.cl/Procurement/Modules/RFB/DetailsAcquisition.aspx?idLicitacion=' + NUMERO_ADQUISICION as Link, DATEDIFF(DAY, GETDATE(), FECHA_CIERRE) as Dias, VT, PLANO, COSTO, MONTO, GARANTIA FROM LICITACION_PUBLICADA_2 WHERE ESTADO = @estado"
            Comando.Parameters.AddWithValue("@estado", estado)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function TraePostuladas(estado As Integer) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT A.REGISTRO_ID, NUMERO_ADQUISICION, NOMBRE_ADQUISICION, DESCRIPCION, ORGANISMO, FECHA_PUBLICACION, FECHA_CIERRE, 'https://www.mercadopublico.cl/Procurement/Modules/RFB/DetailsAcquisition.aspx?idLicitacion=' + NUMERO_ADQUISICION as Link, ADJUDICACION, MONTOADJUDICADO, RUTADJUDICADO, FECHA_ADJUDICACION, B.DESCESTADO
                                    FROM LICITACION_PUBLICADA_2 A
                                    LEFT JOIN ESTADOSMP B ON A.ESTADOMP = B.ESTADO
                                    WHERE A.ESTADO = @estado"
            Comando.Parameters.AddWithValue("@estado", estado)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function TraeBusqueda() As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT * FROM BUSQUEDAS"
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function

        Public Function GuardarSQL(ByVal consulta As String) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "INSERT INTO BUSQUEDAS ([SQL]) VALUES (@consulta)"
            Comando.Parameters.AddWithValue("@consulta", consulta)
            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function

        Public Function GuardarPalabras(PALABRA As String, CONDICION As String, COLUMNA As String) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "AS_PALABRAS"
            Comando.Parameters.AddWithValue("@PALABRA", PALABRA)
            Comando.Parameters.AddWithValue("@CONDICION", CONDICION)
            Comando.Parameters.AddWithValue("@COLUMNA", COLUMNA)
            Comando.CommandType = CommandType.StoredProcedure
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function

        Public Function TraeDetalles(ByVal adquisicion As String) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            'Comando.CommandText = "select DESCRIPCION_PRODUCTO_O_SERVICIO from LICITACION_PUBLICADA where NUMERO_ADQUISICION = @adquisicion"
            Comando.CommandText = "select NOMBRE_PRODUCTO, CANTIDAD, DESCRIPCION_PRODUCTO_O_SERVICIO, UNIDAD_MEDIDA, CATEGORIA, CODIGO_ONU from DETALLE_LICITACION where NUMERO_ADQUISICION = @adquisicion"
            Comando.Parameters.AddWithValue("@adquisicion", adquisicion)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function

        Public Function TraePalabras(ByVal adquisicion As String) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            'Comando.CommandText = "select DESCRIPCION_PRODUCTO_O_SERVICIO from LICITACION_PUBLICADA where NUMERO_ADQUISICION = @adquisicion"
            Comando.CommandText = "select A.* 
                                    from PALABRAS_CLAVE A
                                    Left join BUSQUEDAS B ON A.BUSQUEDA_ID = B.REGISTRO_ID
                                    LEFT JOIN LICITACION_PUBLICADA C ON B.REGISTRO_ID = C.ESTADO2
                                    WHERE C.NUMERO_ADQUISICION = @adquisicion GROUP BY BUSQUEDA_ID, A.PALABRA, A.CONDICION, A.COLUMNA"
            Comando.Parameters.AddWithValue("@adquisicion", adquisicion)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function

        Public Function TraeSql(id As String) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT * FROM BUSQUEDAS WHERE REGISTRO_ID = @id"
            Comando.Parameters.AddWithValue("@id", id)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function EliminaSql(id As String) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "DELETE FROM BUSQUEDAS WHERE REGISTRO_ID = @id"
            Comando.Parameters.AddWithValue("@id", id)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function TraePalabrasSQL(ByVal ID As String) As DataTable
            Comando.Connection = Conexion.AbrirConexion()

            Comando.CommandText = "SELECT * FROM PALABRAS_CLAVE where BUSQUEDA_ID = @ID"
            Comando.Parameters.AddWithValue("@ID", ID)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function Descartados(ByVal adquisicion As String, Obseracion As String) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "INSERT INTO DESCARTADOS VALUES(@adquisicion, @Obseracion, GETDATE())"
            Comando.Parameters.AddWithValue("@adquisicion", adquisicion)
            Comando.Parameters.AddWithValue("@Obseracion", Obseracion)
            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function
        Public Function Postuladas(ByVal adquisicion As String) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "INSERT INTO POSTULADAS (NUMERO_ADQUISICION, FECHA_POSTULACION)  VALUES(@adquisicion, GETDATE())"
            Comando.Parameters.AddWithValue("@adquisicion", adquisicion)
            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function
        Public Function Actualizacion(ByVal Obs As String) As Boolean
            Comando.Parameters.Clear()
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "INSERT INTO ACTUALIZACION VALUES(GETDATE(), @Obs)"
            Comando.Parameters.AddWithValue("@Obs", Obs)
            Comando.CommandType = CommandType.Text
            ejecuto = (Comando.ExecuteNonQuery > 0)
            Conexion.CerrarConexion()
            Return ejecuto
        End Function
        Public Function Info() As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "  SELECT TOP 1 * FROM ACTUALIZACION ORDER BY FECHA_ACTUALIZACION DESC"
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function InfoVT(adquisicion As String) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "select * from LICITACION_PUBLICADA_2 where NUMERO_ADQUISICION = @adquisicion"
            Comando.Parameters.AddWithValue("@adquisicion", adquisicion)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function ActualizaEstado(columna As String, adquisicion As String, estado As Integer) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = $"update LICITACION_PUBLICADA_2 set {columna} = @estado where NUMERO_ADQUISICION = @adquisicion"
            Comando.Parameters.AddWithValue("@adquisicion", adquisicion)
            Comando.Parameters.AddWithValue("@estado", estado)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
        Public Function TraeEstados() As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT * FROM ADJUDICADO"
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function

        Public Function TraeParaComparar(estado As Integer) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = "SELECT * FROM LICITACION_PUBLICADA_2 WHERE ESTADO = @estado"
            Comando.Parameters.AddWithValue("@estado", estado)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function

        Public Function ActualizaFechas(columna As String, adquisicion As String, estado As DateTime) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = $"update LICITACION_PUBLICADA_2 set {columna} = @estado where NUMERO_ADQUISICION = @adquisicion"
            Comando.Parameters.AddWithValue("@adquisicion", adquisicion)
            Comando.Parameters.AddWithValue("@estado", estado)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function

        Public Function ActualizaDatos(columna As String, dato As String, adquisicion As String) As DataTable
            Comando.Connection = Conexion.AbrirConexion()
            Comando.CommandText = $"update LICITACION_PUBLICADA_2 set {columna} = @dato where NUMERO_ADQUISICION = @adquisicion"
            Comando.Parameters.AddWithValue("@adquisicion", adquisicion)
            Comando.Parameters.AddWithValue("@dato", dato)
            Comando.CommandType = CommandType.Text
            LeerFilas = Comando.ExecuteReader()
            tabla.Load(LeerFilas)
            LeerFilas.Close()
            Comando.Parameters.Clear()
            Conexion.CerrarConexion()
            Return tabla
        End Function
    End Class


End Namespace