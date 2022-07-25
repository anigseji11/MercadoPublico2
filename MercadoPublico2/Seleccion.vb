Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid.Interactivity

Public Class Seleccion
    Dim newdt As New DataSet
    Dim dtGrid As New DataTable
    Private Sub Seleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.SfDataGrid1.GroupCaptionTextFormat = "{Key}"

        llenarGrid()

    End Sub

    Private Sub llenarGrid()
        Dim Obj As New Licitaciones.Procesos

        dtGrid = Obj.TraeSeleccion(1)
        dtGrid.Columns.Add("Seleccion")
        SfDataGrid1.DataSource = dtGrid
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Dim rspt = MsgBox($"¿ESTA SEGURO QUE DESEA DESCARTAR LAS LICITACIONES MARCADAS?", vbQuestion + vbYesNo, "CO-OL | LICITACIONES")
        If rspt = 6 Then

            Dim Observacion As String = InputBox("INGRESE EL MOTIVO PARA DESCARTAR", "MOTIVO", "", -1, -1)




            Dim Cont As Integer = 0
            If SfDataGrid1.RowCount > 1 Then
                If Observacion <> "" Then


                    Dim records = SfDataGrid1.View.Records
                    For Each record In records.ToList()
                        Dim dataRowView = TryCast(record.Data, DataRowView)

                        If dataRowView IsNot Nothing Then
                            Dim selectedValue = dataRowView.Row("NUMERO_ADQUISICION")
                            Dim selected = dataRowView.Row("Seleccion")

                            If selected.[GetType]() <> GetType(DBNull) AndAlso CBool(selected) Then


                                Dim obj As New Licitaciones.Procesos
                                obj.Seleccionar(selectedValue, 3)

                                Dim obj2 As New Licitaciones.Procesos
                                obj2.Descartados(selectedValue, Observacion)

                                Cont += 1
                                dataRowView.Delete()
                            End If
                        End If


                    Next

                    MsgBox($"SE HAN DESCARTADO {Cont} REGISTROS DE FORMA CORRECTA", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")

                    SfDataGrid1.Refresh()
                    SfDataGrid2.DataSource = Nothing
                    SfDataGrid2.Refresh()

                Else
                    MsgBox("DEBE INDICAR EL MOTIVO PARA DESCARTAR ESTA(S) LICITACIONE(S)", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")

                End If
            Else
                    MsgBox("DEBE ELEGIR AL MENOS UNA LINEA", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")


            End If


        End If


    End Sub


    Private Sub DesmarcarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesmarcarTodosToolStripMenuItem.Click
        Dim records = SfDataGrid1.View.Records
        For Each record In records.ToList()
            Dim dataRowView = TryCast(record.Data, DataRowView)
            If dataRowView IsNot Nothing Then
                Dim selected = dataRowView.Row("Seleccion")
                dataRowView.Row.Item(6) = False
            End If
        Next
    End Sub

    Private Sub SEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEToolStripMenuItem.Click
        Dim records = SfDataGrid1.View.Records
        For Each record In records.ToList()
            Dim dataRowView = TryCast(record.Data, DataRowView)
            If dataRowView IsNot Nothing Then
                Dim selected = dataRowView.Row("Seleccion")
                dataRowView.Row.Item(6) = True
            End If
        Next
    End Sub


    Private Sub SfDataGrid1_ToolTipOpening(ByVal sender As Object, ByVal e As ToolTipOpeningEventArgs) Handles SfDataGrid1.ToolTipOpening
        Dim str As String

        If e.Column.MappingName = "Ver" And e.RowIndex > 0 Then


            Dim num As String = DirectCast(e.Record, DataRowView).Row.ItemArray(0)


            Dim Obj As New Licitaciones.Procesos
            Dim dt As New DataTable
            dt = Obj.TraePalabras(num)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    str &= dt.Rows(i)("PALABRA") & " - " & dt.Rows(i)("CONDICION") & " - " & dt.Rows(i)("COLUMNA") & vbLf
                Next
            End If


            e.ToolTipInfo.Items(0).Text = str
            e.ToolTipInfo.MinWidth = 200
            e.ToolTipInfo.MaxWidth = 400


        End If

    End Sub

    Private Sub SfDataGrid1_CellButtonClick(sender As Object, e As CellButtonClickEventArgs) Handles SfDataGrid1.CellButtonClick
        Dim ID = SfDataGrid1.SelectedItem(0)
        Dim url = SfDataGrid1.SelectedItem(4)
        If SfDataGrid1.CurrentCell.Column.MappingName = "Seleccionar" Then
            Try
                Dim Obj As New Licitaciones.Procesos
                Obj.Seleccionar(ID, 2)


                Dim Obj2 As New Licitaciones.Procesos
                dtGrid = Obj2.TraeSeleccion(1)
                dtGrid.Columns.Add("Seleccion")


                SfDataGrid1.Refresh()
                llenarGrid()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf SfDataGrid1.CurrentCell.Column.MappingName = "Link" Then
            Process.Start(url)
        ElseIf SfDataGrid1.CurrentCell.Column.MappingName = "Ver" Then

        End If
    End Sub


    Private Sub SfDataGrid1_CellClick(sender As Object, e As CellClickEventArgs) Handles SfDataGrid1.CellClick
        'Dim ID2 = SfDataGrid1.SelectedItem(3)

        If e.DataRow.RowIndex > 1 Then
            Dim record = SelectionHelper.GetRecordAtRowIndex(Me.SfDataGrid1, e.DataRow.RowIndex)



            Dim ID2 = DirectCast(record, System.Data.DataRowView).Row.ItemArray(0)
            Dim Obj3 As New Licitaciones.Procesos

            dtGrid = Obj3.TraeDetalles(ID2)
            SfDataGrid2.DataSource = dtGrid
        End If




    End Sub

    Private Sub SfDataGrid1_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles SfDataGrid1.SelectionChanged

        If SfDataGrid1.SelectedIndex >= 0 Then
            Dim ID = SfDataGrid1.SelectedItem(0)

            Dim Obj3 As New Licitaciones.Procesos

            dtGrid = Obj3.TraeDetalles(ID)
            SfDataGrid2.DataSource = dtGrid
        End If


    End Sub

    Private Sub SfDataGrid1_Click(sender As Object, e As EventArgs) Handles SfDataGrid1.Click

    End Sub
End Class