Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports MercadoPublico2.Licit
Imports Newtonsoft.Json
Imports Syncfusion.Data
Imports Syncfusion.WinForms.Core.Enums
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid.Interactivity
Imports Syncfusion.WinForms.DataGrid.Styles

Public Class Gestion
    Dim dt As New DataTable
    Dim dtGrid As New DataTable
    Dim resultado As String
    Dim nodos As Cabeceras
    Dim Cuerpo As String

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()
        Dim sortColumnDescription As New SortColumnDescription()
        sortColumnDescription.ColumnName = "Dias"
        sortColumnDescription.SortDirection = ListSortDirection.Ascending
        Me.SfDataGrid1.SortColumnDescriptions.Add(sortColumnDescription)


        Me.SfDataGrid1.Columns("FECHA_PUBLICACION").CellStyle.Interior = New Syncfusion.WinForms.Core.BrushInfo(GradientStyle.Horizontal, ColorTranslator.FromHtml("#5aff8d"), ColorTranslator.FromHtml("#12cb74"))
        Me.SfDataGrid1.Columns("FECHA_CIERRE").CellStyle.Interior = New Syncfusion.WinForms.Core.BrushInfo(GradientStyle.Horizontal, ColorTranslator.FromHtml("#FFDF80"), ColorTranslator.FromHtml("#FFA925"))
        'Me.SfDataGrid1.Columns("MONTO").CellStyle.Interior = New Syncfusion.WinForms.Core.BrushInfo(GradientStyle.Horizontal, ColorTranslator.FromHtml("#f77891"), ColorTranslator.FromHtml("#ff5862"))
        Me.SfDataGrid1.Columns("MONTO").CellStyle.Interior = New Syncfusion.WinForms.Core.BrushInfo(GradientStyle.Horizontal, ColorTranslator.FromHtml("#FFDF80"), ColorTranslator.FromHtml("#FFA925"))

        Me.SfDataGrid1.Style.CurrentCellStyle.BackColor = SystemColors.Highlight
        Me.SfDataGrid1.Style.CurrentCellStyle.TextColor = Color.White
        Me.SfDataGrid1.Style.CurrentCellStyle.BorderColor = Color.Red
        Me.SfDataGrid1.Style.CurrentCellStyle.BorderThickness = GridBorderWeight.Thick

    End Sub

    Private Sub LlenarGrid()
        Dim Obj As New Licitaciones.Procesos

        dt = Obj.TraeSeleccionAvanzada(2)

        SfDataGrid1.DataSource = dt






        GradientLabel1.Text = SfDataGrid1.RowCount - 2 & " REGISTROS EN TOTAL"
    End Sub



    Private Sub SfDataGrid1_CellButtonClick(sender As Object, e As CellButtonClickEventArgs) Handles SfDataGrid1.CellButtonClick
        Numero = SfDataGrid1.SelectedItem(1)
        Dim url As String = SfDataGrid1.SelectedItem(7)
        Dim ID As String = SfDataGrid1.SelectedItem(0)

        If SfDataGrid1.CurrentCell.Column.MappingName = "Ver" Then

        ElseIf SfDataGrid1.CurrentCell.Column.MappingName = "Link" Then
            Process.Start(url)
        ElseIf SfDataGrid1.CurrentCell.Column.MappingName = "Eliminar" Then
            Dim rspt = MsgBox($"¿ESTA SEGURO QUE DESEA DESCARTAR LA LICITACION {Numero}?", vbQuestion + vbYesNo, "CO-OL | TRANSPORTES")
            If rspt = 6 Then

                Dim Observacion As String = InputBox("INGRESE EL MOTIVO PARA DESCARTAR", "MOTIVO", "", -1, -1)

                If Observacion <> "" Then


                    Dim obj As New Licitaciones.Procesos
                    obj.Seleccionar(Numero, 3)

                    Dim obj2 As New Licitaciones.Procesos
                    obj2.Descartados(Numero, Observacion)

                    LlenarGrid()

                Else
                    MsgBox("DEBE INDICAR EL MOTIVO PARA DESCARTAR ESTA(S) LICITACIONE(S)", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")

                End If

            End If


        ElseIf SfDataGrid1.CurrentCell.Column.MappingName = "Postular" Then
            Dim rspt = MsgBox($"¿ESTA SEGURO QUE DESEA DAR POR POSTULADA LA LICITACION {Numero} DE {SfDataGrid1.SelectedItem(4)}?", vbQuestion + vbYesNo, "CO-OL | TRANSPORTES")
            If rspt = 6 Then
                Dim obj As New Licitaciones.Procesos
                obj.Seleccionar(Numero, 4)

                Dim obj2 As New Licitaciones.Procesos
                obj2.Postuladas(Numero)

                LlenarGrid()

            End If


        End If
        SfDataGrid1.ClearSelection()
    End Sub

    Private Sub SfDataGrid1_CellClick(sender As Object, e As CellClickEventArgs) Handles SfDataGrid1.CellClick
        If e.DataRow.RowIndex > 1 Then


            Dim record = SelectionHelper.GetRecordAtRowIndex(Me.SfDataGrid1, e.DataRow.RowIndex)

            Dim ID2 = DirectCast(record, System.Data.DataRowView).Row.ItemArray(1)
            Dim Obj3 As New Licitaciones.Procesos

            dtGrid = Obj3.TraeDetalles(ID2)
            SfDataGrid2.DataSource = dtGrid

            If e.DataColumn.GridColumn.MappingName = "VT" Then

                Dim rspt = MsgBox($"¿DESEA CAMBIAR EL ESTADO DE LA LICITACION?", vbQuestion + vbYesNo, "CO-OL | TRANSPORTES")
                If rspt = 6 Then
                    Dim Obj As New Licitaciones.Procesos
                    Dim dt As New DataTable
                    dt = Obj.InfoVT(ID2)

                    If IsDBNull(dt.Rows(0)("VT")) = True Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("VT", ID2, 1)
                    ElseIf dt.Rows(0)("VT") = 1 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("VT", ID2, 2)
                    ElseIf dt.Rows(0)("VT") = 2 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("VT", ID2, 3)
                    ElseIf dt.Rows(0)("VT") = 3 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("VT", ID2, 1)
                    End If
                    LlenarGrid()
                End If
            ElseIf e.DataColumn.GridColumn.MappingName = "PLANO" Then
                Dim rspt = MsgBox($"¿DESEA CAMBIAR EL ESTADO DE LA LICITACION?", vbQuestion + vbYesNo, "CO-OL | TRANSPORTES")
                If rspt = 6 Then
                    Dim Obj As New Licitaciones.Procesos
                    Dim dt As New DataTable
                    dt = Obj.InfoVT(ID2)

                    If IsDBNull(dt.Rows(0)("PLANO")) = True Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("PLANO", ID2, 1)
                    ElseIf dt.Rows(0)("PLANO") = 1 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("PLANO", ID2, 2)
                    ElseIf dt.Rows(0)("PLANO") = 2 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("PLANO", ID2, 3)
                    ElseIf dt.Rows(0)("PLANO") = 3 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("PLANO", ID2, 1)
                    End If
                    LlenarGrid()
                End If

            ElseIf e.DataColumn.GridColumn.MappingName = "COSTO" Then
                Dim rspt = MsgBox($"¿DESEA CAMBIAR EL ESTADO DE LA LICITACION?", vbQuestion + vbYesNo, "CO-OL | TRANSPORTES")
                If rspt = 6 Then
                    Dim Obj As New Licitaciones.Procesos
                    Dim dt As New DataTable
                    dt = Obj.InfoVT(ID2)

                    If IsDBNull(dt.Rows(0)("COSTO")) = True Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("COSTO", ID2, 1)
                    ElseIf dt.Rows(0)("COSTO") = 1 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("COSTO", ID2, 2)
                    ElseIf dt.Rows(0)("COSTO") = 2 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("COSTO", ID2, 3)
                    ElseIf dt.Rows(0)("COSTO") = 3 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("COSTO", ID2, 1)
                    End If
                    LlenarGrid()
                End If

            ElseIf e.DataColumn.GridColumn.MappingName = "MONTO" Then
                Dim MontoPesos = InputBox("INGRESE EL MONTO TOPE DE LA LICITACION", "LICITACIONES | CO-OL")
                If IsNumeric(MontoPesos) = True Then
                    If MontoPesos > 0 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("MONTO", ID2, MontoPesos)
                        LlenarGrid()
                    Else
                        MsgBox("EL MONTO DEBE SER MAYOR A 0", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")
                    End If

                Else
                    MsgBox("DEBE INGRESAR UN VALOR NUMERICO", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")
                End If


            ElseIf e.DataColumn.GridColumn.MappingName = "GARANTIA" Then
                Dim rspt = MsgBox($"¿DESEA CAMBIAR EL ESTADO DE LA LICITACION?", vbQuestion + vbYesNo, "CO-OL | TRANSPORTES")
                If rspt = 6 Then
                    Dim Obj As New Licitaciones.Procesos
                    Dim dt As New DataTable
                    dt = Obj.InfoVT(ID2)

                    If IsDBNull(dt.Rows(0)("GARANTIA")) = True Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("GARANTIA", ID2, 1)
                    ElseIf dt.Rows(0)("GARANTIA") = 1 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("GARANTIA", ID2, 2)
                    ElseIf dt.Rows(0)("GARANTIA") = 2 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("GARANTIA", ID2, 3)
                    ElseIf dt.Rows(0)("GARANTIA") = 3 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("GARANTIA", ID2, 1)
                    End If
                    LlenarGrid()
                End If
            ElseIf e.DataColumn.GridColumn.MappingName = "Enviar" Then

                HTML(ID2)




            End If
            'SfDataGrid1.Refresh()
            'SfDataGrid1.ClearSelection()
        End If
    End Sub

    Private Sub SfDataGrid1_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles SfDataGrid1.SelectionChanged
        If SfDataGrid1.SelectedIndex >= 0 Then
            Dim ID = SfDataGrid1.SelectedItem(1)
            Dim Obj3 As New Licitaciones.Procesos
            dtGrid = Obj3.TraeDetalles(ID)
            SfDataGrid2.DataSource = dtGrid


        End If
    End Sub

    Private Sub SfDataGrid1_QueryCellStyle(sender As Object, e As QueryCellStyleEventArgs) Handles SfDataGrid1.QueryCellStyle
        If e.Column.MappingName = "VT" Then
            If e.DisplayText = "" Then
                e.Style.BackColor = Color.Red
                e.Style.TextColor = Color.Red
            ElseIf e.DisplayText = "1" Then
                e.Style.BackColor = Color.Yellow
                e.Style.TextColor = Color.Black
                e.DisplayText = "en proceso"
            ElseIf e.DisplayText = "2" Then
                e.Style.BackColor = Color.Green
                e.Style.TextColor = Color.White
                e.DisplayText = "listo"
            ElseIf e.DisplayText = "3" Then
                e.Style.BackColor = Color.Black
                e.Style.TextColor = Color.White
                e.DisplayText = "no aplica"
            End If
        ElseIf e.Column.MappingName = "PLANO" Then

            If e.DisplayText = "" Then
                e.Style.BackColor = Color.Red
                e.Style.TextColor = Color.Red
            ElseIf e.DisplayText = "1" Then
                e.Style.BackColor = Color.Yellow
                e.Style.TextColor = Color.Black
                e.DisplayText = "en proceso"
            ElseIf e.DisplayText = "2" Then
                e.Style.BackColor = Color.Green
                e.Style.TextColor = Color.White
                e.DisplayText = "listo"
            ElseIf e.DisplayText = "3" Then
                e.Style.BackColor = Color.Black
                e.Style.TextColor = Color.White
                e.DisplayText = "no aplica"
            End If
        ElseIf e.Column.MappingName = "COSTO" Then

            If e.DisplayText = "" Then
                e.Style.BackColor = Color.Red
                e.Style.TextColor = Color.Red
            ElseIf e.DisplayText = "1" Then
                e.Style.BackColor = Color.Yellow
                e.Style.TextColor = Color.Black
                e.DisplayText = "en proceso"
            ElseIf e.DisplayText = "2" Then
                e.Style.BackColor = Color.Green
                e.Style.TextColor = Color.White
                e.DisplayText = "listo"
            ElseIf e.DisplayText = "3" Then
                e.Style.BackColor = Color.Black
                e.Style.TextColor = Color.White
                e.DisplayText = "no aplica"
            End If
        ElseIf e.Column.MappingName = "GARANTIA" Then

            If e.DisplayText = "" Then
                e.Style.BackColor = Color.Red
                e.Style.TextColor = Color.Red
            ElseIf e.DisplayText = "1" Then
                e.Style.BackColor = Color.Yellow
                e.Style.TextColor = Color.Black
                e.DisplayText = "en proceso"
            ElseIf e.DisplayText = "2" Then
                e.Style.BackColor = Color.Green
                e.Style.TextColor = Color.White
                e.DisplayText = "listo"
            ElseIf e.DisplayText = "3" Then
                e.Style.BackColor = Color.Black
                e.Style.TextColor = Color.White
                e.DisplayText = "no aplica"
            End If


        End If


    End Sub

    Private Sub SfDataGrid1_Click(sender As Object, e As EventArgs) Handles SfDataGrid1.Click

    End Sub

    Private Sub SfDataGrid1_ToolTipOpened(sender As Object, e As ToolTipOpenedEventArgs) Handles SfDataGrid1.ToolTipOpened
        If e.RowIndex > 1 AndAlso e.Column.MappingName = "VT" Then
            e.ToolTipInfo.Items(0).Text = $"VISITA TECNICA"
        ElseIf e.RowIndex > 1 AndAlso e.Column.MappingName = "PLANO" Then
            e.ToolTipInfo.Items(0).Text = $"PLANO {e.DisplayText}"
        ElseIf e.RowIndex > 1 AndAlso e.Column.MappingName = "COSTO" Then
            e.ToolTipInfo.Items(0).Text = $"COSTEO {e.DisplayText}"
        ElseIf e.RowIndex > 1 AndAlso e.Column.MappingName = "MONTO" Then
            e.ToolTipInfo.Items(0).Text = $"MONTO {e.DisplayText}"
        ElseIf e.RowIndex > 1 AndAlso e.Column.MappingName = "GARANTIA" Then
            e.ToolTipInfo.Items(0).Text = $"GARANTIA {e.DisplayText}"
        ElseIf e.RowIndex > 1 AndAlso e.Column.MappingName = "Link" Then
            e.ToolTipInfo.Items(0).Text = e.DisplayText
        ElseIf e.RowIndex > 1 AndAlso e.Column.MappingName = "Eliminar" Then
            e.ToolTipInfo.Items(0).Text = $"DESCARTAR LICITACION"
        ElseIf e.RowIndex > 1 AndAlso e.Column.MappingName = "Dias" Then
            e.ToolTipInfo.Items(0).Text = $"DIAS PARA QUE CIERRE LA LICITACION"
        ElseIf e.RowIndex > 1 AndAlso e.Column.MappingName = "Postular" Then
            e.ToolTipInfo.Items(0).Text = $"POSTULAR"

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Obj As New Licitaciones.Procesos
        Dim dt As New DataTable
        dt = Obj.TraeParaComparar(2)

        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1

                Threading.Thread.Sleep(2000)
                Dim Request = WebRequest.Create($"https://api.mercadopublico.cl/servicios/v1/publico/licitaciones.json?codigo={dt.Rows(i)("NUMERO_ADQUISICION")}&ticket=EED964E0-1B6D-401A-A720-61CE1BA50FFC")
                Dim Response As WebResponse
                Response = Request.GetResponse()
                Dim sr2 = New StreamReader(Response.GetResponseStream())
                resultado = sr2.ReadToEnd()
                nodos = JsonConvert.DeserializeObject(Of Cabeceras)(resultado)

                'VERIFICA CAMBIO EN LA FECHA DE INICIO
                If IsDBNull(dt.Rows(i)("FECHA_INICIO")) = False Then
                    If DateTime.Compare(nodos.Listado(0).Fechas.FechaInicio, dt.Rows(i)("FECHA_INICIO")) Then
                        Dim Ob2 As New Licitaciones.Procesos
                        Ob2.ActualizaFechas("FECHA_INICIO", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaInicio)
                        Correo(dt.Rows(i)("FECHA_INICIO").ToString, nodos.Listado(0).Fechas.FechaInicio, "FECHA DE INICIO", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                    End If

                ElseIf IsDBNull(dt.Rows(i)("FECHA_INICIO")) = True Then
                    Dim Ob2 As New Licitaciones.Procesos
                    Ob2.ActualizaFechas("FECHA_INICIO", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaInicio)
                    Correo(dt.Rows(i)("FECHA_INICIO").ToString, nodos.Listado(0).Fechas.FechaInicio, "FECHA DE INICIO", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                End If

                'VERIFICA CAMBIO EN LA FECHA FINAL
                If IsDBNull(dt.Rows(i)("FECHA_FINAL")) = False Then
                    If DateTime.Compare(nodos.Listado(0).Fechas.FechaFinal, dt.Rows(i)("FECHA_FINAL")) Then
                        Dim Ob2 As New Licitaciones.Procesos
                        Ob2.ActualizaFechas("FECHA_FINAL", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaFinal)
                        Correo(dt.Rows(i)("FECHA_FINAL").ToString, nodos.Listado(0).Fechas.FechaFinal, "FECHA FINAL PREGUNTAS", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                    End If

                ElseIf IsDBNull(dt.Rows(i)("FECHA_FINAL")) = True Then
                    Dim Ob2 As New Licitaciones.Procesos
                    Ob2.ActualizaFechas("FECHA_FINAL", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaFinal)
                    Correo(dt.Rows(i)("FECHA_FINAL").ToString, nodos.Listado(0).Fechas.FechaFinal, "FECHA FINAL PREGUNTAS", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                End If

                'VERIFICA CAMBIO EN LA FECHA PUBLICACION DE RESPUESTAS
                If IsDBNull(dt.Rows(i)("FECHA_PUBRESPUESTAS")) = False Then
                    If DateTime.Compare(nodos.Listado(0).Fechas.FechaPubRespuestas, dt.Rows(i)("FECHA_PUBRESPUESTAS")) Then
                        Dim Ob2 As New Licitaciones.Procesos
                        Ob2.ActualizaFechas("FECHA_PUBRESPUESTAS", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaPubRespuestas)
                        Correo(dt.Rows(i)("FECHA_PUBRESPUESTAS").ToString, nodos.Listado(0).Fechas.FechaPubRespuestas, "FECHA PUBLICACION DE RESPUESTAS", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                    End If

                ElseIf IsDBNull(dt.Rows(i)("FECHA_PUBRESPUESTAS")) = True Then
                    Dim Ob2 As New Licitaciones.Procesos
                    Ob2.ActualizaFechas("FECHA_PUBRESPUESTAS", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaPubRespuestas)
                    Correo(dt.Rows(i)("FECHA_PUBRESPUESTAS").ToString, nodos.Listado(0).Fechas.FechaPubRespuestas, "FECHA PUBLICACION DE RESPUESTAS", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                End If

                'VERIFICA CAMBIO EN LA FECHA APERTURA
                If IsDBNull(dt.Rows(i)("FECHA_APERTURA")) = False Then
                    If DateTime.Compare(nodos.Listado(0).Fechas.FechaActoAperturaTecnica, dt.Rows(i)("FECHA_APERTURA")) Then
                        Dim Ob2 As New Licitaciones.Procesos
                        Ob2.ActualizaFechas("FECHA_APERTURA", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaActoAperturaTecnica)
                        Correo(dt.Rows(i)("FECHA_APERTURA").ToString, nodos.Listado(0).Fechas.FechaActoAperturaTecnica, "FECHA APERTURA ELECTRONICA", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                    End If

                ElseIf IsDBNull(dt.Rows(i)("FECHA_APERTURA")) = True Then
                    Dim Ob2 As New Licitaciones.Procesos
                    Ob2.ActualizaFechas("FECHA_APERTURA", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaActoAperturaTecnica)
                    Correo(dt.Rows(i)("FECHA_APERTURA").ToString, nodos.Listado(0).Fechas.FechaActoAperturaTecnica, "FECHA APERTURA ELECTRONICA", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                End If

                'VERIFICA CAMBIO EN LA FECHA ADJUDICACION
                If IsDBNull(dt.Rows(i)("FECHA_ADJUDICACION")) = False Then
                    If DateTime.Compare(nodos.Listado(0).Fechas.FechaActoAperturaTecnica, dt.Rows(i)("FECHA_ADJUDICACION")) Then
                        Dim Ob2 As New Licitaciones.Procesos
                        Ob2.ActualizaFechas("FECHA_ADJUDICACION", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaActoAperturaTecnica)
                        Correo(dt.Rows(i)("FECHA_ADJUDICACION").ToString, nodos.Listado(0).Fechas.FechaActoAperturaTecnica, "FECHA ADJUDICACION", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                    End If

                ElseIf IsDBNull(dt.Rows(i)("FECHA_ADJUDICACION")) = True Then
                    Dim Ob2 As New Licitaciones.Procesos
                    Ob2.ActualizaFechas("FECHA_ADJUDICACION", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).Fechas.FechaActoAperturaTecnica)
                    Correo(dt.Rows(i)("FECHA_ADJUDICACION").ToString, nodos.Listado(0).Fechas.FechaActoAperturaTecnica, "FECHA ADJUDICACION", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                End If

                'VERIFICA CAMBIO EN EL ESTADO
                If IsDBNull(dt.Rows(i)("ESTADOMP")) = False Then

                    If dt.Rows(i)("ESTADOMP").ToString <> nodos.Listado(0).CodigoEstado Then
                        Dim Ob2 As New Licitaciones.Procesos
                        Ob2.ActualizaEstado("ESTADOMP", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).CodigoEstado)
                        Correo(dt.Rows(i)("ESTADOMP").ToString, nodos.Listado(0).Estado, "ESTADO LICITACION", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                    End If

                ElseIf IsDBNull(dt.Rows(i)("ESTADOMP")) = True Then
                    Dim Ob2 As New Licitaciones.Procesos
                    Ob2.ActualizaEstado("ESTADOMP", dt.Rows(i)("NUMERO_ADQUISICION").ToString, nodos.Listado(0).CodigoEstado)
                    Correo(dt.Rows(i)("ESTADOMP").ToString, nodos.Listado(0).Estado, "ESTADO LICITACION", dt.Rows(i)("NUMERO_ADQUISICION").ToString, dt.Rows(i)("ORGANISMO").ToString)
                End If



            Next
        End If





    End Sub

    Private Sub Correo(FECHAANTIGUA As String, FECHANUEVA As String, COMENTARIO As String, ID As String, ORGANISMO As String)
        Dim part1 As String
        part1 = $"<!DOCTYPE html>
<html lang='en'>
<script src='https://code.jquery.com/jquery-3.5.1.slim.min.js'
    integrity='sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj'
    crossorigin='anonymous'></script>
<script src='https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js'
    integrity='sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo'
    crossorigin='anonymous'></script>
<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js'
    integrity='sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI'
    crossorigin='anonymous'></script>
<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css'
    integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>

<head>
    <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1'>

    <title>Licitaciones | CO-OL </title>

    <meta name='description' content='Source code generated using layoutit.com'>
    <meta name='author' content='LayoutIt!'>

    <link href='css/bootstrap.min.css' rel='stylesheet'>
    <link href='css/style.css' rel='stylesheet'>

</head>

<body>
    <br></br>
    <div class='container-fluid'>
        <div class='row'>
            <div class='col-md-12'>
                <div class='jumbotron'>
                    <h3 class='display-6'>Nuevo Cambio {COMENTARIO} Licitacion {ID} de {ORGANISMO}</h3>
                    <div class='row'>
                        <div class='col-12 col-sm-12 col-md-1 col-lg-1 col-xl-1'>
                            <p><span class='badge badge-info'>{COMENTARIO} ORIGINAL :</span></p>
                        </div>
                        <div class='col-12 col-sm-12 col-md-1 col-lg-1 col-xl-1'>
                            <p><span class='badge badge-Default'>  {FECHAANTIGUA}  </span></p>
                        </div>
                        <div class='col-12 col-sm-12 col-md-1 col-lg-1 col-xl-1'>
                            <p><span class='badge badge-info'> NUEVA {COMENTARIO}  :</span></p>
                        </div>
                        <div class='col-12 col-sm-12 col-md-1 col-lg-1 col-xl-1'>
                            <p><span class='badge badge-Default'>  {FECHANUEVA}  </span></p>
                        </div>
                    </div>

                  
                </div>
            </div>
        </div>
    </div>


     <script src='js/jquery.min.js'></script>
    <script src='js/bootstrap.min.js'></script>
    <script src='js/scripts.js'></script>
</body>

</html>"
        Cuerpo = part1



        Dim correo As New MailMessage

        correo.From = New MailAddress("licitaciones@co-ol.cl")
        correo.To.Add("asegura@co-ol.cl")
        correo.To.Add("aconchac@co-ol.cl")
        correo.To.Add("jnunez@co-ol.cl")
        correo.To.Add("lsanchez@co-ol.cl")
        correo.To.Add("amaisto@co-ol.cl")
        correo.Subject = $"CAMBIO DE {COMENTARIO} - {ID}"
        correo.Body = Cuerpo
        correo.IsBodyHtml = True
        correo.Priority = MailPriority.High

        Dim smtp As New SmtpClient()

        smtp.Host = "mail.co-ol.cl"
        smtp.Port = 587
        smtp.Credentials = New System.Net.NetworkCredential("transportes@co-ol.cl", "Asd55889987001403")
        smtp.EnableSsl = True

        Try
            smtp.Send(correo)
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try

    End Sub

    Private Sub SfDataGrid1_DrawCell(sender As Object, e As DrawCellEventArgs) Handles SfDataGrid1.DrawCell

        'e.DataRow.IsSelectedRow.ToString()



        'If SfDataGrid1.ShowRowHeader AndAlso e.RowIndex <> 0 Then


        '    If e.ColumnIndex = 0 Then
        '        If e.RowIndex > 1 Then


        '            e.Handled = True
        '            e.Graphics.FillRectangle(New SolidBrush(SfDataGrid1.Style.RowHeaderStyle.BackColor), e.Bounds)
        '            e.Graphics.DrawImage(New Bitmap(Image.FromFile("Resources\adjudicada.png")), e.Bounds)
        '            'e.Graphics.DrawImage(New Bitmap(Image.FromFile("C:\Users\Andres Segura\source\repos\MercadoPublico2\MercadoPublico2\Resources\cerrada.png")), e.Bounds)
        '            Dim borderPen As Pen = New Pen(ColorTranslator.FromHtml("#CCCCCC"))
        '            e.Graphics.DrawLine(borderPen, e.Bounds.Left, e.Bounds.Bottom, e.Bounds.Right, e.Bounds.Bottom)
        '        End If
        '    End If
        'End If
    End Sub
    Public Sub HTML(ADQUISICION As String)

        Threading.Thread.Sleep(2000)
        Dim Request = WebRequest.Create($"https://api.mercadopublico.cl/servicios/v1/publico/licitaciones.json?codigo={ADQUISICION}&ticket=EED964E0-1B6D-401A-A720-61CE1BA50FFC")
        Dim Response As WebResponse
        Response = Request.GetResponse()
        Dim sr2 = New StreamReader(Response.GetResponseStream())
        resultado = sr2.ReadToEnd()
        nodos = JsonConvert.DeserializeObject(Of Cabeceras)(resultado)


        Dim Parte1 As String = $"<!DOCTYPE html>
                                    <html lang='en'>
                                    <head>
  <title>Licitaciones | CO-OL</title>
  <meta charset='utf-8'>
  <meta name='viewport' content='width=device-width, initial-scale=1'>
  <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css'>
  <script src='https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js'></script>
  <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js'></script>
</head>
<body>

  <div class='jumbotron text-center'>
    <h3>{nodos.Listado(0).Comprador.NombreOrganismo} | {nodos.Listado(0).Comprador.RutUnidad}</h3>
    <p><a href='https://www.mercadopublico.cl/Procurement/Modules/RFB/DetailsAcquisition.aspx?idLicitacion={nodos.Listado(0).CodigoExterno}'>{nodos.Listado(0).CodigoExterno}</a></p>  
  </div>

  <div class='container'>
    <div class='row'>
      <div class='col-sm-2'>
        <H5 style='font-weight: bold;'>PUBLICACIÓN</H5>
        <p>{nodos.Listado(0).Fechas.FechaPublicacion}</p>
      </div>
      <div class='col-sm-2'>
        <H5 style='font-weight: bold;'>CIERRE</H5>
        <p>{nodos.Listado(0).Fechas.FechaCierre}</p>
      </div>
      <div class='col-sm-2'>
        <H5 style='font-weight: bold;'>ADJUDICACIÓN</H5>        
        <p>{nodos.Listado(0).Fechas.FechaAdjudicacion}</p>
      </div>
      <div class='col-sm-2'>
        <H5 style='font-weight: bold;'>INICIO PREG.</H5>
        <p>{nodos.Listado(0).Fechas.FechaInicio}</p>
      </div>
        <div class='col-sm-2'>
        <H5 style='font-weight: bold;'>FECHA FIN PREG.</H5>        
        <p>{nodos.Listado(0).Fechas.FechaFinal}</p>
      </div>
      <div class='col-sm-2'>
        <H5 style='font-weight: bold;'>PUB. RESPUESTAS.</H5>
        <p>{nodos.Listado(0).Fechas.FechaPubRespuestas}</p>
      </div>
      
    </div>
  </div>
<br>
<br>

<div class='container'>
 
  <table class='table'>
    <thead>
      <tr>
        <th>Linea</th>
        <th>Cantidad</th>
        <th>Especificación del Comprador</th>
        <th>Producto o Servicio a Contratar</th>
      </tr>
    </thead>
    <tbody>"

        Dim Parte2 As String
        If nodos.Listado(0).Items.Listado(0).Cantidad >= 0 Then
            For x As Integer = 0 To nodos.Listado(0).Items.Cantidad - 1
                Parte2 = Parte2 & $"<tr>
                                        <td>{nodos.Listado(0).Items.Listado(x).Correlativo}</td>
                                        <td>{nodos.Listado(0).Items.Listado(x).Cantidad}</td>
                                        <td>{nodos.Listado(0).Items.Listado(x).Descripcion}</td>
                                         <td>{nodos.Listado(0).Items.Listado(x).NombreProducto}</td>
                                          <td>{nodos.Listado(0).Items.Listado(x).UnidadMedida}</td>
                                        </tr>"
            Next
        End If





        Dim Parte3 As string = "</tbody>
  </table>
</div>



</body>
</html>"


        Dim correo As New MailMessage

        correo.From = New MailAddress("licitaciones@co-ol.cl")
        correo.To.Add("asegura@co-ol.cl")
        correo.To.Add("aconchac@co-ol.cl")
        correo.To.Add("jnunez@co-ol.cl")
        correo.To.Add("lsanchez@co-ol.cl")
        correo.To.Add("amaisto@co-ol.cl")
        correo.Subject = $"SE HA RECOMENDADO UNA LICITACION {nodos.Listado(0).CodigoExterno} | {nodos.Listado(0).Comprador.NombreOrganismo}"
        correo.Body = Parte1 & Parte2 & Parte3
        correo.IsBodyHtml = True
        correo.Priority = MailPriority.High

        Dim smtp As New SmtpClient()

        smtp.Host = "mail.co-ol.cl"
        smtp.Port = 587
        smtp.Credentials = New System.Net.NetworkCredential("transportes@co-ol.cl", "Asd55889987001403")
        smtp.EnableSsl = True

        Try
            smtp.Send(correo)
            MsgBox("CORREO ENVIADO EXITOSAMENTE", vbInformation + vbOKOnly, "LICITACIONES | CO-OL")
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub


End Class