Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports MercadoPublico2.Licit
Imports MercadoPublico2.Class1
Imports Syncfusion.Windows.Forms.Tools

Public Class Detalle
    Dim url As String
    Dim resultado As String
    Dim resultado2 As String
    Dim nodos As Cabeceras
    Dim nodos2 As Cabeceras

    Private Sub Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProgressBarAdv1.ProgressStyle = ProgressBarStyles.Office2016Colorful

        Me.ProgressBarAdv1.Value = 0

        Dim Obj As New Licitaciones.Procesos
        Dim dt As New DataTable
        dt = Obj.Info()

        If dt.Rows.Count > 0 Then
            GradientLabel1.Text = $"Ultima actualizacion : {dt.Rows(0)("FECHA_ACTUALIZACION")}({dt.Rows(0)("TIPO")})"
        End If

        'TraeLicitacionesHoy()
        'Gethttp()
    End Sub

    Public Sub Gethttp()
        Dim Request = WebRequest.Create("Http://api.mercadopublico.cl/servicios/v1/publico/licitaciones.json?codigo={Numero}&ticket=F8537A18-6766-4DEF-9E59-426B4FEE2844")
        Dim Response = Request.GetResponse()
        Dim sr = New StreamReader(Response.GetResponseStream())

        resultado = sr.ReadToEnd()


        Try
            Dim nodos As Cabeceras = JsonConvert.DeserializeObject(Of Cabeceras)(resultado)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical + vbOKOnly, "LICITACIONES | CO-OL")
        End Try


    End Sub

    Public Sub TraeLicitacionesHoy()

        Dim Cont As Integer = 0

        Dim Request = WebRequest.Create(url)
        Dim Response As WebResponse
        Try
            Response = Request.GetResponse()
            Dim sr = New StreamReader(Response.GetResponseStream())

            resultado = sr.ReadToEnd()

        Catch ex As Exception

        End Try

        If IsNothing(Response) = False Then


            Try
                nodos = JsonConvert.DeserializeObject(Of Cabeceras)(resultado)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical + vbOKOnly, "LICITACIONES | CO-OL")
            End Try

        End If

        For i As Integer = 0 To nodos.Cantidad - 1

            ProgressBarAdv1.Maximum = nodos.Cantidad
            ProgressBarAdv1.Visible = True
            ProgressBarAdv1.Value = i

            If nodos.Listado(i).CodigoExterno <> "" Then

                Dim Obj As New Licitaciones.Procesos
                Dim dt As New DataTable
                dt = Obj.CompruebaLicitacion2(nodos.Listado(i).CodigoExterno)

                If dt.Rows.Count = 0 Then
                    Threading.Thread.Sleep(2000)
                    Dim Request2 = WebRequest.Create($"https://api.mercadopublico.cl/servicios/v1/publico/licitaciones.json?codigo={nodos.Listado(i).CodigoExterno}&ticket=EED964E0-1B6D-401A-A720-61CE1BA50FFC")
                    'Dim Request2 = WebRequest.Create("https://api.mercadopublico.cl/servicios/v1/publico/licitaciones.json?codigo=1079967-75-L121&ticket=EED964E0-1B6D-401A-A720-61CE1BA50FFC")
                    Dim Response2 As WebResponse

                    Try
                        Response2 = Request2.GetResponse()
                        Dim sr2 = New StreamReader(Response2.GetResponseStream())
                        resultado2 = sr2.ReadToEnd()

                    Catch ex As Exception

                    End Try

                    If IsNothing(Response2) = False Then
                        Try
                            nodos2 = JsonConvert.DeserializeObject(Of Cabeceras)(resultado2)
                        Catch ex As Exception
                            MsgBox(ex.Message, vbCritical + vbOKOnly, "LICITACIONES | CO-OL")
                        End Try

                        Dim FechaCierre As DateTime
                        If IsNothing(nodos2.Listado(0).Fechas.FechaCierre) = True Then
                            FechaCierre = "2100-02-01 12:00:00.000"
                        Else
                            FechaCierre = nodos2.Listado(0).Fechas.FechaCierre
                        End If

                        Dim FechaAdjudicacion As DateTime
                        If IsNothing(nodos2.Listado(0).Fechas.FechaAdjudicacion) = True Then
                            FechaAdjudicacion = "2100-02-01 12:00:00.000"
                        Else
                            FechaAdjudicacion = nodos2.Listado(0).Fechas.FechaCierre
                        End If

                        Dim FechaInicio As DateTime
                        If IsNothing(nodos2.Listado(0).Fechas.FechaAdjudicacion) = True Then
                            FechaInicio = "2100-02-01 12:00:00.000"
                        Else
                            FechaInicio = nodos2.Listado(0).Fechas.FechaInicio
                        End If

                        Dim FechaFinal As DateTime
                        If IsNothing(nodos2.Listado(0).Fechas.FechaAdjudicacion) = True Then
                            FechaFinal = "2100-02-01 12:00:00.000"
                        Else
                            FechaFinal = nodos2.Listado(0).Fechas.FechaFinal
                        End If

                        Dim FechaPubRespuestas As DateTime
                        If IsNothing(nodos2.Listado(0).Fechas.FechaAdjudicacion) = True Then
                            FechaPubRespuestas = "2100-02-01 12:00:00.000"
                        Else
                            FechaPubRespuestas = nodos2.Listado(0).Fechas.FechaPubRespuestas
                        End If

                        Dim FechaActoAperturaTecnica As DateTime
                        If IsNothing(nodos2.Listado(0).Fechas.FechaAdjudicacion) = True Then
                            FechaActoAperturaTecnica = "2100-02-01 12:00:00.000"
                        Else
                            FechaActoAperturaTecnica = nodos2.Listado(0).Fechas.FechaActoAperturaTecnica
                        End If



                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.InsertarLicitacion2(nodos.Listado(i).CodigoExterno, nodos2.Listado(0).Tipo, nodos2.Listado(0).Nombre, nodos2.Listado(0).Descripcion, nodos2.Listado(0).Comprador.NombreOrganismo, nodos2.Listado(0).Comprador.RegionUnidad,
                                                nodos2.Listado(0).Fechas.FechaPublicacion.Value, FechaCierre, FechaAdjudicacion, FechaInicio, FechaFinal,
                                                FechaPubRespuestas, FechaActoAperturaTecnica, nodos2.Listado(0).CodigoEstado)

                        Cont = Cont + 1

                        If nodos2.Listado(0).Items.Listado(0).Cantidad >= 0 Then
                            For x As Integer = 0 To nodos2.Listado(0).Items.Cantidad - 1
                                Dim Obj3 As New Licitaciones.Procesos
                                Obj3.InsertarDetalleLicitacion(nodos.Listado(i).CodigoExterno, nodos2.Listado(0).Items.Listado(x).Descripcion, nodos2.Listado(0).Items.Listado(x).CodigoProducto, nodos2.Listado(0).Items.Listado(x).UnidadMedida,
                                                               nodos2.Listado(0).Items.Listado(x).Cantidad, nodos2.Listado(0).Items.Listado(x).NombreProducto, nodos2.Listado(0).Items.Listado(x).Categoria, nodos2.Listado(0).Items.Listado(x).Correlativo)
                            Next
                        End If


                    End If


                End If
            End If


        Next
        Timer1.Enabled = False
        MsgBox($"SE HAN AGREGADO {Cont} REGISTROS NUEVOS", vbInformation + vbOKOnly, "LICITACIONES | CO-OL")
        ProgressBarAdv1.Visible = False
        Me.Close()




    End Sub



    Private Sub ProgressBarAdv1_ValueChanged(sender As Object, e As ProgressBarValueChangedEventArgs) Handles ProgressBarAdv1.ValueChanged
        e.Text = "Value Changing...." + Me.ProgressBarAdv1.Value.ToString()

        e.Handled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        url = "http://api.mercadopublico.cl/servicios/v1/publico/licitaciones.json?estado=activas&ticket=EED964E0-1B6D-401A-A720-61CE1BA50FFC"
        Dim Obj As New Licitaciones.Procesos
        Obj.Actualizacion("ACTIVAS")
        TraeLicitacionesHoy()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        url = $"http://api.mercadopublico.cl/servicios/v1/publico/licitaciones.json?fecha={Date.Now.ToString("ddMMyyyy")}&estado=Publicada&ticket=EED964E0-1B6D-401A-A720-61CE1BA50FFC"
        Dim Obj As New Licitaciones.Procesos
        Obj.Actualizacion("HOY")
        TraeLicitacionesHoy()
    End Sub
End Class