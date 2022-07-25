Imports System.IO
Imports System.Net
Imports MercadoPublico2.Licit
Imports Newtonsoft.Json
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid.Interactivity
Imports Syncfusion.WinForms.GridCommon.ScrollAxis

Public Class Postulados
    Dim dt As New DataTable
    Dim newdt As New DataTable
    Dim url As String
    Dim resultado As String
    Dim nodos As Cabeceras
    Private Sub Postulados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLenarGrid()

        Dim oBJ As New Licitaciones.Procesos
        newdt = oBJ.TraeEstados()




        TryCast(Me.SfDataGrid1.Columns("ADJUDICACION"), GridComboBoxColumn).DataSource = newdt
        TryCast(Me.SfDataGrid1.Columns("ADJUDICACION"), GridComboBoxColumn).ValueMember = "ESTADO"
        TryCast(Me.SfDataGrid1.Columns("ADJUDICACION"), GridComboBoxColumn).DisplayMember = "DESCESTADO"


        Me.ProgressBarAdv1.ProgressStyle = ProgressBarStyles.Office2016DarkGray
    End Sub
    Private Sub LLenarGrid()

        Dim Obj As New Licitaciones.Procesos
        dt = Obj.TraePostuladas(4)
        SfDataGrid1.DataSource = dt
        GradientLabel1.Text = SfDataGrid1.RowCount & " Licitaciones"
    End Sub

    Private Sub SfDataGrid1_Click(sender As Object, e As EventArgs) Handles SfDataGrid1.Click

    End Sub

    Private Sub SfDataGrid1_CellComboBoxSelectionChanged(sender As Object, e As CellComboBoxSelectionChangedEventArgs) Handles SfDataGrid1.CellComboBoxSelectionChanged


        If e.GridColumn.MappingName = "ADJUDICACION" AndAlso e.SelectedIndex >= 0 Then

            If DirectCast(e.SelectedItem, System.Data.DataRowView).Row.ItemArray(2).ToString = "GANADA" Then

                Dim ID = SfDataGrid1.SelectedItem(1)
                Dim oBJ As New Licitaciones.Procesos
                oBJ.ActualizaEstado("ADJUDICACION", ID, 1)

            ElseIf DirectCast(e.SelectedItem, System.Data.DataRowView).Row.ItemArray(2).ToString = "PERDIDA" Then

                Dim ID = SfDataGrid1.SelectedItem(1)
                Dim oBJ As New Licitaciones.Procesos
                oBJ.ActualizaEstado("ADJUDICACION", ID, 0)

            End If
        End If

    End Sub

    Private Sub SfDataGrid1_QueryCellStyle(sender As Object, e As QueryCellStyleEventArgs) Handles SfDataGrid1.QueryCellStyle
        If e.Column.MappingName = "ADJUDICACION" Then
            If e.DisplayText = "GANADA" Then
                e.Style.BackColor = Color.Green
                e.Style.TextColor = Color.White
            ElseIf e.DisplayText = "PERDIDA" Then
                e.Style.BackColor = Color.Red
                e.Style.TextColor = Color.White

            End If

        ElseIf e.Column.MappingName = "DESCESTADO" Then
            If e.DisplayText = "Cerrada" Then
                e.Style.BackColor = Color.OrangeRed
                e.Style.TextColor = Color.White
            ElseIf e.DisplayText = "Publicada" Then
                e.Style.BackColor = Color.Green
                e.Style.TextColor = Color.White
            ElseIf e.DisplayText = "Adjudicada" Then
                e.Style.BackColor = Color.DodgerBlue
                e.Style.TextColor = Color.White
            ElseIf e.DisplayText = "Desierta" Then
                e.Style.BackColor = Color.Goldenrod
                e.Style.TextColor = Color.White
            End If
        End If
    End Sub

    Private Sub SfDataGrid1_CellClick(sender As Object, e As CellClickEventArgs) Handles SfDataGrid1.CellClick
        If e.DataRow.RowIndex > 1 Then


            Dim record = SelectionHelper.GetRecordAtRowIndex(Me.SfDataGrid1, e.DataRow.RowIndex)
            Dim url As String = DirectCast(record, System.Data.DataRowView).Row.ItemArray(7)
            Dim ID2 = DirectCast(record, System.Data.DataRowView).Row.ItemArray(1)


            If e.DataColumn.GridColumn.MappingName = "MONTOADJUDICADO" Then
                Dim MontoPesos = InputBox("INGRESE EL MONTO TOPE DE LA LICITACION", "LICITACIONES | CO-OL")
                If IsNumeric(MontoPesos) = True Then
                    If MontoPesos > 0 Then
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.ActualizaEstado("MONTOADJUDICADO", ID2, MontoPesos)
                        LLenarGrid()
                    Else
                        MsgBox("EL MONTO DEBE SER MAYOR A 0", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")
                    End If

                Else
                    MsgBox("DEBE INGRESAR UN VALOR NUMERICO", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")
                End If

            ElseIf e.DataColumn.GridColumn.MappingName = "RUTADJUDICADO" Then

            ElseIf e.DataColumn.GridColumn.MappingName = "FECHA_ADJUDICACION" Then

            ElseIf e.DataColumn.GridColumn.MappingName = "Link" Then
                Process.Start(url)
            ElseIf e.DataColumn.GridColumn.MappingName = "Cerrar" Then

                If MsgBox($"¿REALMENTE DESEA DAR POR CERRADA LA LICITACION {ID2}?", MsgBoxStyle.YesNo + vbQuestion, "CO-OL | LICITACIONES") = MsgBoxResult.Yes Then
                    Try
                        Dim Obj2 As New Licitaciones.Procesos
                        Obj2.Seleccionar(ID2, 5)
                        LLenarGrid()
                        MsgBox($"LICITACION {ID2} CERRADA EXITOSAMENTE", vbInformation + vbOKOnly, "CO-OL | LICITACIONES")
                    Catch ex As Exception

                    End Try


                End If
            End If
        End If

    End Sub

    Private Sub ValidaAdjudicacion()
        Dim records = SfDataGrid1.View.Records
        Dim Cont As Integer = 1

        For Each record In records
            Dim dataRowView = TryCast(record.Data, DataRowView)

            ProgressBarAdv1.Maximum = records.Count
            ProgressBarAdv1.Visible = True
            ProgressBarAdv1.Value = Cont

            If dataRowView IsNot Nothing Then
                Dim selectedValue = dataRowView.Row("NUMERO_ADQUISICION")

                Threading.Thread.Sleep(2000)

                Dim Request = WebRequest.Create($"https://api.mercadopublico.cl/servicios/v1/publico/licitaciones.json?codigo={selectedValue}&ticket=EED964E0-1B6D-401A-A720-61CE1BA50FFC")
                'Dim Request = WebRequest.Create($"https://api.mercadopublico.cl/servicios/v1/publico/licitaciones.json?codigo=537934-9-LE21&ticket=EED964E0-1B6D-401A-A720-61CE1BA50FFC")
                Dim Response As WebResponse
                Response = Request.GetResponse()
                Dim sr2 = New StreamReader(Response.GetResponseStream())
                resultado = sr2.ReadToEnd()
                nodos = JsonConvert.DeserializeObject(Of Cabeceras)(resultado)

                If IsNothing(nodos.Listado(0).Items.Listado(0).Adjudicacion) = False Then



                    Dim Obj1 As New Licitaciones.Procesos
                    Obj1.ActualizaDatos("RUTADJUDICADO", nodos.Listado(0).Items.Listado(0).Adjudicacion.RutProveedor, selectedValue)

                    Dim Obj2 As New Licitaciones.Procesos
                    Obj2.ActualizaDatos("MONTOADJUDICADO", nodos.Listado(0).Items.Listado(0).Adjudicacion.MontoUnitario, selectedValue)





                End If
                Dim Obj3 As New Licitaciones.Procesos
                Obj3.ActualizaEstado("ESTADOMP", selectedValue, nodos.Listado(0).CodigoEstado)

                Dim Ob4 As New Licitaciones.Procesos
                Ob4.ActualizaFechas("FECHA_ADJUDICACION", selectedValue, nodos.Listado(0).Fechas.FechaAdjudicacion)
            End If

            Cont = Cont + 1
        Next
        LLenarGrid()
    End Sub
    Private Sub ProgressBarAdv1_ValueChanged(sender As Object, e As ProgressBarValueChangedEventArgs) Handles ProgressBarAdv1.ValueChanged
        e.Text = "Value Changing...." + Me.ProgressBarAdv1.Value.ToString()

        e.Handled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ValidaAdjudicacion()
    End Sub

    Private Sub SfDataGrid1_ToolTipOpened(sender As Object, e As ToolTipOpenedEventArgs) Handles SfDataGrid1.ToolTipOpened
        If e.RowIndex > 1 AndAlso e.ColumnIndex = 9 Then
            e.ToolTipInfo.Items(0).Text = $"MONTO ADJUDICADO {e.DisplayText}"
        ElseIf e.RowIndex > 1 AndAlso e.ColumnIndex = 10 Then
            e.ToolTipInfo.Items(0).Text = $"RUT ADJUDICADO {e.DisplayText}"
        ElseIf e.RowIndex > 1 AndAlso e.ColumnIndex = 11 Then
            e.ToolTipInfo.Items(0).Text = $"FECHA ADJUDICADO {e.DisplayText}"
        ElseIf e.RowIndex > 1 AndAlso e.ColumnIndex = 12 Then
            e.ToolTipInfo.Items(0).Text = $"CERRAR LICITACION"
        End If
    End Sub
End Class