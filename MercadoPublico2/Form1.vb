Imports System.Data.OleDb
Imports Syncfusion.Windows.Forms.Tools

Imports MercadoPublico2.Variables
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ProgressBarAdv1.ProgressStyle = ProgressBarStyles.Office2016Colorful

        Me.ProgressBarAdv1.Value = 0


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog
        openFileDialog1.InitialDirectory = "C:\"
        openFileDialog1.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm"


        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            txtRutaXLS.Text = openFileDialog1.FileName


            Dim cadconex As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtRutaXLS.Text.Trim & ";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"""
            Dim cn As New OleDbConnection(cadconex)
            Dim cmd As New OleDbCommand
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable

            cmd.Connection = cn
            cmd.CommandText = "select * from [Excel_Licitacion_Publicada$]"
            cmd.CommandType = CommandType.Text

            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = 6
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ProgressBarAdv1.Maximum = DataGridView1.Rows.Count - 1
        ProgressBarAdv1.Visible = True
        Label1.Visible = True
        Cursor = Cursors.WaitCursor

        Dim Cont As Integer = 0
        Dim Cont2 As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            ProgressBarAdv1.Value = i
            Label1.Text = $"{i} de {DataGridView1.Rows.Count - 1} registros"
            Dim Obj As New Licitaciones.Procesos
            Dim dt As New DataTable
            If IsDBNull(DataGridView1(0, i).Value) = False And IsNothing(DataGridView1(0, i).Value) = False Then

                If IsDBNull(DataGridView1(0, i).Value) = True Then var1 = "" Else var1 = DataGridView1(0, i).Value
                If IsDBNull(DataGridView1(1, i).Value) = True Then var2 = "" Else var2 = DataGridView1(1, i).Value
                If IsDBNull(DataGridView1(3, i).Value) = True Then var3 = "" Else var3 = DataGridView1(3, i).Value
                If IsDBNull(DataGridView1(4, i).Value) = True Then var4 = "" Else var4 = DataGridView1(4, i).Value
                If IsDBNull(DataGridView1(5, i).Value) = True Then var5 = "" Else var5 = DataGridView1(5, i).Value
                If IsDBNull(DataGridView1(6, i).Value) = True Then var6 = "" Else var6 = DataGridView1(6, i).Value
                If IsDBNull(DataGridView1(8, i).Value) = True Then IsDBNull(var7) Else var7 = DataGridView1(8, i).Value
                If IsDBNull(DataGridView1(9, i).Value) = True Then IsDBNull(var8) Else var8 = DataGridView1(9, i).Value
                If IsDBNull(DataGridView1(10, i).Value) = True Then var9 = "" Else var9 = DataGridView1(10, i).Value
                If IsDBNull(DataGridView1(11, i).Value) = True Then var10 = "" Else var10 = DataGridView1(11, i).Value
                If IsDBNull(DataGridView1(12, i).Value) = True Then var11 = "" Else var11 = DataGridView1(12, i).Value
                If IsDBNull(DataGridView1(13, i).Value) = True Then var12 = "" Else var12 = DataGridView1(13, i).Value
                If IsDBNull(DataGridView1(14, i).Value) = True Then var13 = "" Else var13 = DataGridView1(14, i).Value
                If IsDBNull(DataGridView1(15, i).Value) = True Then var14 = "" Else var14 = DataGridView1(15, i).Value
                If IsDBNull(DataGridView1(16, i).Value) = True Then var15 = "" Else var15 = DataGridView1(16, i).Value
                If IsDBNull(DataGridView1(17, i).Value) = True Then var16 = "" Else var16 = DataGridView1(17, i).Value


                'dt = Obj.CompruebaLicitacion(var1, var9)


                If dt.Rows.Count = 0 Then
                    Try
                        Dim Obj2 As New Licitaciones.Procesos
                        'Obj2.InsertarLicitacion(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11, var12, var13, var14, var15, var16)
                        Cont = Cont + 1
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If


            End If

        Next

        Cursor = Cursors.Default
        If Cont2 > 0 Then MsgBox($"EXISTE {Cont2} REGISTROS SIN DESCRIPCION DE PRODUCTO QUE NO SE AGREGARON", vbCritical + vbOKOnly, "LICITACIONES | CO-OL")
        MsgBox($"SE AGREGARON {Cont} REGISTROS NUEVOS CORRECTAMENTE", vbInformation + vbOKOnly, "LICITACIONES | CO-OL")

        ProgressBarAdv1.Visible = False
    End Sub

    Private Sub progressBarAdv1_ValueChanged(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.ProgressBarValueChangedEventArgs)

        e.Text = "Value Changing...." + Me.ProgressBarAdv1.Value.ToString()

        e.Handled = True

    End Sub
End Class