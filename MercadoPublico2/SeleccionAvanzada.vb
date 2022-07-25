Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid.Interactivity

Public Class SeleccionAvanzada
    Dim newdt As New DataTable
    Dim dtGrid As New DataTable

    Private Sub SeleccionAvanzada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        newdt.Columns.Add("ORGANISMO")
        newdt.Columns.Add("NUMERO_ADQUISICION")
        newdt.Columns.Add("NOMBRE_ADQUISICION")
        newdt.Columns.Add("DESCRIPCION")


        ListBusquedas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextPalabra.Text <> "" And ComboTipo.Text <> "" And ComColumna.Text <> "" Then
            Dim values As Object() = New Object() {TextPalabra.Text, ComboTipo.Text, ComColumna.Text}
            DataGridView1.Rows.Add(values)
        Else
            MsgBox("DEBE ESCRIBIR UNA PALABRA O ELEGIR TIPO", vbCritical + vbQuestion, "CO-OL | LICITACIONES")
        End If

        If DataGridView1.Rows.Count > 0 Then
            Dim consulta As String = $"SELECT ORGANISMO, NUMERO_ADQUISICION, NOMBRE_ADQUISICION, DESCRIPCION FROM AS_LICITACION_PUBLICADA WHERE ("

            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If i > 0 Then
                    If DataGridView1(1, i).Value = "LIKE" Then
                        'consulta &= $" AND (UPPER({DataGridView1(2, i).Value})) LIKE '%{DataGridView1(0, i).Value}%' "
                        consulta &= $" {ComboCondicion.Text} UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE({DataGridView1(2, i).Value}, 'ó', 'o'), 'á', 'a'), 'í', 'i'), 'é', 'e'), 'ú', 'u')) like '%{DataGridView1(0, i).Value}%' "
                    ElseIf DataGridView1(1, i).Value = "NOT LIKE" Then
                        'consulta &= $" AND (UPPER({DataGridView1(2, i).Value})) NOT LIKE '%{DataGridView1(0, i).Value}%' "
                        consulta &= $" {ComboCondicion.Text} UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE({DataGridView1(2, i).Value}, 'ó', 'o'), 'á', 'a'), 'í', 'i'), 'é', 'e'), 'ú', 'u')) NOT LIKE '%{DataGridView1(0, i).Value}%'"
                    End If
                Else
                    If DataGridView1(1, i).Value = "LIKE" Then
                        'consulta &= $"(UPPER({DataGridView1(2, i).Value})) LIKE '%{DataGridView1(0, i).Value}%' "
                        consulta &= $" UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE({DataGridView1(2, i).Value}, 'ó', 'o'), 'á', 'a'), 'í', 'i'), 'é', 'e'), 'ú', 'u')) LIKE '%{DataGridView1(0, i).Value}%' "
                    ElseIf DataGridView1(1, i).Value = "NOT LIKE" Then
                        'consulta &= $"(UPPER({DataGridView1(2, i).Value})) NOT LIKE '%{DataGridView1(0, i).Value}%' "
                        consulta &= $" UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE({DataGridView1(2, i).Value}, 'ó', 'o'), 'á', 'a'), 'í', 'i'), 'é', 'e'), 'ú', 'u')) NOT LIKE '%{DataGridView1(0, i).Value}%' "
                    End If
                End If


            Next
            consulta &= ") AND (ESTADO IS NULL) GROUP BY ORGANISMO, NUMERO_ADQUISICION, NOMBRE_ADQUISICION, DESCRIPCION"
            txtSearch.Text = consulta



        Else
            MsgBox("DEBE TENER AL MENOS UNA PALABRA", vbCritical + vbQuestion, "CO-OL | LICITACIONES")
        End If
    End Sub
    Private Sub ListBusquedas()
        Dim Obj As New Licitaciones.Procesos
        Dim dt As New DataTable
        dt = Obj.TraeBusqueda()


        DataGridView2.DataSource = dt

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If DataGridView1.Rows.Count > 0 Then
            'Dim consulta As String = $"SELECT REGISTRO_ID, ORGANISMO, NUMERO_ADQUISICION, NOMBRE_ADQUISICION, DESCRIPCION, DESCRIPCION_PRODUCTO_O_SERVICIO FROM LICITACION_PUBLICADA WHERE ("

            'For i As Integer = 0 To DataGridView1.Rows.Count - 1
            '    If i > 0 Then
            '        If DataGridView1(1, i).Value = "LIKE" Then
            '            'consulta &= $" AND (UPPER({DataGridView1(2, i).Value})) LIKE '%{DataGridView1(0, i).Value}%' "
            '            consulta &= $" {ComboCondicion.Text} UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE({DataGridView1(2, i).Value}, 'ó', 'o'), 'á', 'a'), 'í', 'i'), 'é', 'e'), 'ú', 'u')) like '%{DataGridView1(0, i).Value}%' "
            '        ElseIf DataGridView1(1, i).Value = "NOT LIKE" Then
            '            'consulta &= $" AND (UPPER({DataGridView1(2, i).Value})) NOT LIKE '%{DataGridView1(0, i).Value}%' "
            '            consulta &= $" {ComboCondicion.Text} UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE({DataGridView1(2, i).Value}, 'ó', 'o'), 'á', 'a'), 'í', 'i'), 'é', 'e'), 'ú', 'u')) NOT LIKE '%{DataGridView1(0, i).Value}%'"
            '        End If
            '    Else
            '        If DataGridView1(1, i).Value = "LIKE" Then
            '            'consulta &= $"(UPPER({DataGridView1(2, i).Value})) LIKE '%{DataGridView1(0, i).Value}%' "
            '            consulta &= $" UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE({DataGridView1(2, i).Value}, 'ó', 'o'), 'á', 'a'), 'í', 'i'), 'é', 'e'), 'ú', 'u')) LIKE '%{DataGridView1(0, i).Value}%' "
            '        ElseIf DataGridView1(1, i).Value = "NOT LIKE" Then
            '            'consulta &= $"(UPPER({DataGridView1(2, i).Value})) NOT LIKE '%{DataGridView1(0, i).Value}%' "
            '            consulta &= $" UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE({DataGridView1(2, i).Value}, 'ó', 'o'), 'á', 'a'), 'í', 'i'), 'é', 'e'), 'ú', 'u')) NOT LIKE '%{DataGridView1(0, i).Value}%' "
            '        End If
            '    End If


            'Next
            'consulta &= ") AND ESTADO IS NULL"
            'txtSearch.Text = consulta


            Dim Obj As New Licitaciones.Procesos
            Dim DT As New DataTable
            DT = Obj.SelectAvanzado(txtSearch.Text)

            DT.Columns.Add("Seleccion")
            SfDataGrid1.DataSource = DT

            Label2.Text = DT.Rows.Count & " registros"
        Else
            MsgBox("DEBE TENER AL MENOS UNA PALABRA", vbCritical + vbQuestion, "CO-OL | LICITACIONES")
        End If




    End Sub





    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim currentRow As DataGridViewRow = Me.DataGridView1.CurrentRow
            If MsgBox("¿REALMENTE DESEA ELIMINAR ESTA LINEA?", MsgBoxStyle.YesNo + vbQuestion, "CO-OL | LICITACIONES") = MsgBoxResult.Yes Then
                Me.DataGridView1.Rows.Remove(currentRow)


            End If

        End If
    End Sub

    Private Sub Buscar()
        Dim startindex As Integer = 0
        Dim start As Integer = 0


        If txtSearch.Text.Length > 0 Then
            startindex = FindMyText(txtSearch.Text.Trim(), start, txtSearch.Text.Length)
        End If

        ' If string was found in the RichTextBox, highlight it
        If startindex >= 0 Then
            ' Set the highlight color as red
            txtSearch.SelectionColor = Color.Red
            ' Find the end index. End Index = number of characters in textbox
            Dim endindex As Integer = txtSearch.Text.Length
            ' Highlight the search string
            txtSearch.Select(startindex, endindex)
            ' mark the start position after the position of
            ' last search string
            start = startindex + endindex
        End If
    End Sub

    Public Function FindMyText(ByVal txtToSearch As String, ByVal searchStart As Integer, ByVal searchEnd As Integer) As Integer
        Dim indexOfSearchText As Integer = 0
        ' Unselect the previously searched string
        If searchStart > 0 AndAlso searchEnd > 0 AndAlso indexOfSearchText >= 0 Then
            txtSearch.Undo()
        End If

        ' Set the return value to -1 by default.
        Dim retVal As Integer = -1

        ' A valid starting index should be specified.
        ' if indexOfSearchText = -1, the end of search
        If searchStart >= 0 AndAlso indexOfSearchText >= 0 Then
            ' A valid ending index
            If searchEnd > searchStart OrElse searchEnd = -1 Then
                ' Find the position of search string in RichTextBox
                indexOfSearchText = txtSearch.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None)
                ' Determine whether the text was found in richTextBox1.
                If indexOfSearchText <> -1 Then
                    ' Return the index to the specified search text.
                    retVal = indexOfSearchText
                End If
            End If
        End If
        Return retVal
    End Function



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            Dim obj As New Licitaciones.Procesos
            obj.GuardarSQL(txtSearch.Text)
            ListBusquedas()
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim obj2 As New Licitaciones.Procesos
                obj2.GuardarPalabras(DataGridView1(0, i).Value, DataGridView1(1, i).Value, DataGridView1(2, i).Value)

            Next
        Catch ex As Exception
            MsgBox($"PROBLEMAS AL GUARDAR. {ex.Message}", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")
        End Try


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim Cont As Integer = 0
        newdt.Clear()

        If DataGridView2.Rows.Count > 0 Then

            For i As Integer = 0 To DataGridView2.Rows.Count - 1

                Try
                    Dim Obj As New Licitaciones.Procesos
                    Dim DT As New DataTable
                    DT = Obj.SelectAvanzado(DataGridView2(1, i).Value)

                    For x As Integer = 0 To DT.Rows.Count - 1

                        'Dim values As Object() = New Object() {False, DT.Rows(x)("REGISTRO_ID"), DT.Rows(x)("ORGANISMO"), DT.Rows(x)("NUMERO_ADQUISICION"), DT.Rows(x)("NOMBRE_ADQUISICION"), DT.Rows(x)("DESCRIPCION"), DT.Rows(x)("DESCRIPCION_PRODUCTO_O_SERVICIO")}


                        newdt.Rows.Add(DT.Rows(x)("ORGANISMO"), DT.Rows(x)("NUMERO_ADQUISICION"), DT.Rows(x)("NOMBRE_ADQUISICION"), DT.Rows(x)("DESCRIPCION"))
                        Dim obj2 As New Licitaciones.Procesos
                        Dim obj3 As New Licitaciones.Procesos
                        obj2.Seleccionar(DT.Rows(x)("NUMERO_ADQUISICION"), 1)
                        obj3.Seleccionar2(DT.Rows(x)("NUMERO_ADQUISICION"), DataGridView2(0, i).Value)
                        Cont += 1

                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Next
            MsgBox($"SE AGREGARON {Cont} REGISTROS NUEVOS", vbInformation + vbQuestion, "CO-OL | LICITACIONES")
            SfDataGrid1.DataSource = newdt
        Else
            MsgBox("DEBE TENER AL MENOS UNA PALABRA", vbCritical + vbQuestion, "CO-OL | LICITACIONES")
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            Dim Obj As New Licitaciones.Procesos
            Dim dt As New DataTable
            dt = Obj.TraeSql(DataGridView2(0, e.RowIndex).Value)

            If dt.Rows.Count > 0 Then
                txtSearch.Text = dt.Rows(0)("SQL").ToString
            End If


            Dim Obj2 As New Licitaciones.Procesos
            Dim dt2 As New DataTable
            dt2 = Obj2.TraePalabrasSQL(dt.Rows(0)("REGISTRO_ID").ToString)

            DataGridView1.Rows.Clear()

            If dt2.Rows.Count > 0 Then
                For i As Integer = 0 To dt2.Rows.Count - 1
                    DataGridView1.Rows.Add(dt2.Rows(i)("PALABRA"), dt2.Rows(i)("CONDICION"), dt2.Rows(i)("COLUMNA"))
                Next
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView2.KeyDown

        If e.KeyCode = Keys.Delete Then
            Dim currentRow As DataGridViewRow = Me.DataGridView2.CurrentRow
            If MsgBox("¿REALMENTE DESEA ELIMINAR ESTE SQL?", MsgBoxStyle.YesNo + vbQuestion, "CO-OL | LICITACIONES") = MsgBoxResult.Yes Then
                Dim Obj As New Licitaciones.Procesos
                Obj.EliminaSql(DataGridView2(0, currentRow.Index).Value)
                ListBusquedas()

            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows.RemoveAt(0)
        Next

        DataGridView1.Refresh()
        txtSearch.Text = ""
    End Sub

    Private Sub SfDataGrid1_Click(sender As Object, e As EventArgs) Handles SfDataGrid1.Click

    End Sub

    Private Sub SfDataGrid1_CellClick(sender As Object, e As CellClickEventArgs) Handles SfDataGrid1.CellClick
        If e.DataRow.RowIndex > 1 Then
            Dim record = SelectionHelper.GetRecordAtRowIndex(Me.SfDataGrid1, e.DataRow.RowIndex)

            Dim ID2 = DirectCast(record, System.Data.DataRowView).Row.ItemArray(1)
            Dim Obj3 As New Licitaciones.Procesos

            dtGrid = Obj3.TraeDetalles(ID2)
            SfDataGrid2.DataSource = dtGrid
        End If
    End Sub

    Private Sub SfDataGrid1_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles SfDataGrid1.SelectionChanged
        Dim ID = SfDataGrid1.SelectedItem(1)

        Dim Obj3 As New Licitaciones.Procesos

        dtGrid = Obj3.TraeDetalles(ID)
        SfDataGrid2.DataSource = dtGrid
    End Sub
End Class