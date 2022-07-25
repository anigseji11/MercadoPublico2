<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridTextColumn1 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn2 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn3 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn4 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn5 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn6 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn7 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridButtonColumn1 As Syncfusion.WinForms.DataGrid.GridButtonColumn = New Syncfusion.WinForms.DataGrid.GridButtonColumn()
        Dim GridButtonColumn2 As Syncfusion.WinForms.DataGrid.GridButtonColumn = New Syncfusion.WinForms.DataGrid.GridButtonColumn()
        Dim GridButtonColumn3 As Syncfusion.WinForms.DataGrid.GridButtonColumn = New Syncfusion.WinForms.DataGrid.GridButtonColumn()
        Dim GridTextColumn8 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridButtonColumn4 As Syncfusion.WinForms.DataGrid.GridButtonColumn = New Syncfusion.WinForms.DataGrid.GridButtonColumn()
        Dim GridTextColumn9 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn10 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn11 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn12 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn13 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn14 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn15 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn16 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn17 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn18 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn19 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion))
        Me.SfDataGrid1 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SfDataGrid2 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.GradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SfDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SfDataGrid1
        '
        Me.SfDataGrid1.AccessibleName = "Table"
        Me.SfDataGrid1.AllowEditing = False
        Me.SfDataGrid1.AllowFiltering = True
        Me.SfDataGrid1.AllowResizingColumns = True
        GridTextColumn1.AllowEditing = False
        GridTextColumn1.AllowFiltering = True
        GridTextColumn1.AllowResizing = True
        GridTextColumn1.HeaderText = "ID"
        GridTextColumn1.MappingName = "REGISTRO_ID"
        GridTextColumn1.MaximumWidth = 50.0R
        GridTextColumn1.MinimumWidth = 50.0R
        GridTextColumn1.Visible = False
        GridTextColumn2.AllowEditing = False
        GridTextColumn2.AllowFiltering = True
        GridTextColumn2.AllowResizing = True
        GridTextColumn2.HeaderText = "NUMERO_ADQUISICION"
        GridTextColumn2.MappingName = "NUMERO_ADQUISICION"
        GridTextColumn3.AllowEditing = False
        GridTextColumn3.AllowFiltering = True
        GridTextColumn3.AllowResizing = True
        GridTextColumn3.HeaderText = "ORGANISMO"
        GridTextColumn3.ImmediateUpdateColumnFilter = True
        GridTextColumn3.MappingName = "ORGANISMO"
        GridTextColumn3.ShowHeaderToolTip = True
        GridTextColumn3.ShowToolTip = True
        GridTextColumn3.Width = 300.0R
        GridTextColumn4.AllowEditing = False
        GridTextColumn4.AllowFiltering = True
        GridTextColumn4.AllowResizing = True
        GridTextColumn4.HeaderText = "NOMBRE_ADQUISICION"
        GridTextColumn4.MappingName = "NOMBRE_ADQUISICION"
        GridTextColumn4.ShowHeaderToolTip = True
        GridTextColumn4.ShowToolTip = True
        GridTextColumn4.Width = 250.0R
        GridTextColumn5.AllowEditing = False
        GridTextColumn5.AllowFiltering = True
        GridTextColumn5.AllowResizing = True
        GridTextColumn5.HeaderText = "DESCRIPCION"
        GridTextColumn5.MappingName = "DESCRIPCION"
        GridTextColumn5.ShowHeaderToolTip = True
        GridTextColumn5.ShowToolTip = True
        GridTextColumn5.Visible = False
        GridTextColumn5.Width = 250.0R
        GridTextColumn6.AllowEditing = False
        GridTextColumn6.AllowFiltering = True
        GridTextColumn6.AllowResizing = True
        GridTextColumn6.HeaderText = "FECHA_PUBLICACION"
        GridTextColumn6.MappingName = "FECHA_PUBLICACION"
        GridTextColumn6.MaximumWidth = 150.0R
        GridTextColumn6.MinimumWidth = 150.0R
        GridTextColumn6.ShowHeaderToolTip = True
        GridTextColumn6.ShowToolTip = True
        GridTextColumn7.AllowEditing = False
        GridTextColumn7.AllowFiltering = True
        GridTextColumn7.AllowResizing = True
        GridTextColumn7.HeaderText = "FECHA_CIERRE"
        GridTextColumn7.MappingName = "FECHA_CIERRE"
        GridTextColumn7.MaximumWidth = 150.0R
        GridTextColumn7.MinimumWidth = 150.0R
        GridTextColumn7.ShowHeaderToolTip = True
        GridTextColumn7.ShowToolTip = True
        GridButtonColumn1.AllowDefaultButtonText = False
        GridButtonColumn1.AllowEditing = False
        GridButtonColumn1.AllowFiltering = True
        GridButtonColumn1.AllowResizing = True
        GridButtonColumn1.ButtonSize = New System.Drawing.Size(0, 0)
        GridButtonColumn1.CellStyle.BackColor = System.Drawing.Color.White
        GridButtonColumn1.DefaultButtonText = ""
        GridButtonColumn1.HeaderText = "#"
        GridButtonColumn1.Image = Global.MercadoPublico2.My.Resources.Resources.Mail_16
        GridButtonColumn1.ImageSize = New System.Drawing.Size(0, 0)
        GridButtonColumn1.MappingName = "Enviar"
        GridButtonColumn1.MaximumWidth = 30.0R
        GridButtonColumn1.MinimumWidth = 30.0R
        GridButtonColumn2.AllowDefaultButtonText = True
        GridButtonColumn2.AllowEditing = False
        GridButtonColumn2.AllowFiltering = True
        GridButtonColumn2.AllowResizing = True
        GridButtonColumn2.ButtonSize = New System.Drawing.Size(0, 0)
        GridButtonColumn2.CellStyle.BackColor = System.Drawing.Color.White
        GridButtonColumn2.CellStyle.TextColor = System.Drawing.Color.White
        GridButtonColumn2.DefaultButtonText = ""
        GridButtonColumn2.FilterBehavior = Syncfusion.Data.FilterBehavior.StringTyped
        GridButtonColumn2.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        GridButtonColumn2.HeaderText = "#"
        GridButtonColumn2.Image = Global.MercadoPublico2.My.Resources.Resources.red_mundial__16
        GridButtonColumn2.ImageSize = New System.Drawing.Size(0, 0)
        GridButtonColumn2.MappingName = "Link"
        GridButtonColumn2.MaximumWidth = 30.0R
        GridButtonColumn2.MinimumWidth = 30.0R
        GridButtonColumn2.ShowToolTip = True
        GridButtonColumn2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        GridButtonColumn2.TextTrimming = System.Drawing.StringTrimming.None
        GridButtonColumn3.AllowDefaultButtonText = False
        GridButtonColumn3.AllowEditing = False
        GridButtonColumn3.AllowFiltering = True
        GridButtonColumn3.AllowResizing = True
        GridButtonColumn3.ButtonSize = New System.Drawing.Size(0, 0)
        GridButtonColumn3.DefaultButtonText = ""
        GridButtonColumn3.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        GridButtonColumn3.HeaderText = "#"
        GridButtonColumn3.Image = Global.MercadoPublico2.My.Resources.Resources.borrar___copia
        GridButtonColumn3.ImageSize = New System.Drawing.Size(0, 0)
        GridButtonColumn3.MappingName = "Eliminar"
        GridButtonColumn3.MaximumWidth = 30.0R
        GridButtonColumn3.MinimumWidth = 30.0R
        GridButtonColumn3.ShowToolTip = True
        GridTextColumn8.AllowEditing = False
        GridTextColumn8.AllowFiltering = True
        GridTextColumn8.AllowResizing = True
        GridTextColumn8.HeaderText = "#"
        GridTextColumn8.MappingName = "Dias"
        GridTextColumn8.MaximumWidth = 30.0R
        GridTextColumn8.MinimumWidth = 30.0R
        GridTextColumn8.ShowToolTip = True
        GridButtonColumn4.AllowDefaultButtonText = False
        GridButtonColumn4.AllowEditing = False
        GridButtonColumn4.AllowFiltering = True
        GridButtonColumn4.AllowResizing = True
        GridButtonColumn4.ButtonSize = New System.Drawing.Size(0, 0)
        GridButtonColumn4.CellStyle.BackColor = System.Drawing.Color.White
        GridButtonColumn4.DefaultButtonText = ""
        GridButtonColumn4.HeaderStyle.BackColor = System.Drawing.Color.White
        GridButtonColumn4.HeaderText = "#"
        GridButtonColumn4.Image = Global.MercadoPublico2.My.Resources.Resources.OK_16
        GridButtonColumn4.ImageSize = New System.Drawing.Size(0, 0)
        GridButtonColumn4.MappingName = "Postular"
        GridButtonColumn4.MaximumWidth = 30.0R
        GridButtonColumn4.MinimumWidth = 30.0R
        GridButtonColumn4.ShowToolTip = True
        GridTextColumn9.AllowEditing = False
        GridTextColumn9.AllowFiltering = True
        GridTextColumn9.AllowResizing = True
        GridTextColumn9.CellStyle.Font.Facename = "Segoe UI"
        GridTextColumn9.CellStyle.Font.Size = 7.0!
        GridTextColumn9.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        GridTextColumn9.HeaderText = "VT"
        GridTextColumn9.MappingName = "VT"
        GridTextColumn9.ShowToolTip = True
        GridTextColumn10.AllowEditing = False
        GridTextColumn10.AllowFiltering = True
        GridTextColumn10.AllowResizing = True
        GridTextColumn10.CellStyle.Font.Facename = "Segoe UI"
        GridTextColumn10.CellStyle.Font.Size = 7.0!
        GridTextColumn10.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        GridTextColumn10.HeaderText = "PLANO"
        GridTextColumn10.MappingName = "PLANO"
        GridTextColumn10.ShowToolTip = True
        GridTextColumn11.AllowEditing = False
        GridTextColumn11.AllowFiltering = True
        GridTextColumn11.AllowResizing = True
        GridTextColumn11.CellStyle.Font.Facename = "Segoe UI"
        GridTextColumn11.CellStyle.Font.Size = 7.0!
        GridTextColumn11.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        GridTextColumn11.HeaderText = "COSTO"
        GridTextColumn11.MappingName = "COSTO"
        GridTextColumn11.ShowToolTip = True
        GridTextColumn12.AllowEditing = False
        GridTextColumn12.AllowFiltering = True
        GridTextColumn12.AllowResizing = True
        GridTextColumn12.CellStyle.Font.Bold = True
        GridTextColumn12.CellStyle.Font.Facename = "Segoe UI"
        GridTextColumn12.CellStyle.Font.Size = 7.0!
        GridTextColumn12.Format = "C0"
        GridTextColumn12.HeaderText = "MONTO"
        GridTextColumn12.MappingName = "MONTO"
        GridTextColumn12.ShowToolTip = True
        GridTextColumn13.AllowEditing = False
        GridTextColumn13.AllowFiltering = True
        GridTextColumn13.AllowResizing = True
        GridTextColumn13.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        GridTextColumn13.HeaderText = "GARANTIA"
        GridTextColumn13.MappingName = "GARANTIA"
        GridTextColumn13.ShowToolTip = True
        Me.SfDataGrid1.Columns.Add(GridTextColumn1)
        Me.SfDataGrid1.Columns.Add(GridTextColumn2)
        Me.SfDataGrid1.Columns.Add(GridTextColumn3)
        Me.SfDataGrid1.Columns.Add(GridTextColumn4)
        Me.SfDataGrid1.Columns.Add(GridTextColumn5)
        Me.SfDataGrid1.Columns.Add(GridTextColumn6)
        Me.SfDataGrid1.Columns.Add(GridTextColumn7)
        Me.SfDataGrid1.Columns.Add(GridButtonColumn1)
        Me.SfDataGrid1.Columns.Add(GridButtonColumn2)
        Me.SfDataGrid1.Columns.Add(GridButtonColumn3)
        Me.SfDataGrid1.Columns.Add(GridTextColumn8)
        Me.SfDataGrid1.Columns.Add(GridButtonColumn4)
        Me.SfDataGrid1.Columns.Add(GridTextColumn9)
        Me.SfDataGrid1.Columns.Add(GridTextColumn10)
        Me.SfDataGrid1.Columns.Add(GridTextColumn11)
        Me.SfDataGrid1.Columns.Add(GridTextColumn12)
        Me.SfDataGrid1.Columns.Add(GridTextColumn13)
        Me.SfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SfDataGrid1.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top
        Me.SfDataGrid1.Location = New System.Drawing.Point(3, 3)
        Me.SfDataGrid1.Name = "SfDataGrid1"
        Me.SfDataGrid1.ShowRowHeader = True
        Me.SfDataGrid1.Size = New System.Drawing.Size(1620, 295)
        Me.SfDataGrid1.TabIndex = 0
        Me.SfDataGrid1.Text = "SfDataGrid1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GESTION DE LICITACIONES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MercadoPublico2.My.Resources.Resources.engranajes
        Me.PictureBox1.Location = New System.Drawing.Point(-56, -62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SfDataGrid2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SfDataGrid1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 126)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1626, 502)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'SfDataGrid2
        '
        Me.SfDataGrid2.AccessibleName = "Table"
        Me.SfDataGrid2.AllowFiltering = True
        Me.SfDataGrid2.AllowResizingColumns = True
        Me.SfDataGrid2.AllowResizingHiddenColumns = True
        GridTextColumn14.AllowFiltering = True
        GridTextColumn14.AllowResizing = True
        GridTextColumn14.HeaderText = "CANTIDAD"
        GridTextColumn14.MappingName = "CANTIDAD"
        GridTextColumn15.AllowFiltering = True
        GridTextColumn15.AllowResizing = True
        GridTextColumn15.HeaderText = "DESCRIPCION_PRODUCTO_O_SERVICIO"
        GridTextColumn15.MappingName = "DESCRIPCION_PRODUCTO_O_SERVICIO"
        GridTextColumn15.Width = 500.0R
        GridTextColumn16.AllowFiltering = True
        GridTextColumn16.AllowResizing = True
        GridTextColumn16.HeaderText = "NOMBRE_PRODUCTO"
        GridTextColumn16.MappingName = "NOMBRE_PRODUCTO"
        GridTextColumn16.Width = 200.0R
        GridTextColumn17.AllowFiltering = True
        GridTextColumn17.AllowResizing = True
        GridTextColumn17.HeaderText = "UNIDAD_MEDIDA"
        GridTextColumn17.MappingName = "UNIDAD_MEDIDA"
        GridTextColumn17.MaximumWidth = 150.0R
        GridTextColumn17.MinimumWidth = 150.0R
        GridTextColumn18.AllowFiltering = True
        GridTextColumn18.AllowResizing = True
        GridTextColumn18.HeaderText = "CATEGORIA"
        GridTextColumn18.MappingName = "CATEGORIA"
        GridTextColumn19.AllowFiltering = True
        GridTextColumn19.AllowResizing = True
        GridTextColumn19.HeaderText = "CODIGO_ONU"
        GridTextColumn19.MappingName = "CODIGO_ONU"
        Me.SfDataGrid2.Columns.Add(GridTextColumn14)
        Me.SfDataGrid2.Columns.Add(GridTextColumn15)
        Me.SfDataGrid2.Columns.Add(GridTextColumn16)
        Me.SfDataGrid2.Columns.Add(GridTextColumn17)
        Me.SfDataGrid2.Columns.Add(GridTextColumn18)
        Me.SfDataGrid2.Columns.Add(GridTextColumn19)
        Me.SfDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SfDataGrid2.Location = New System.Drawing.Point(3, 304)
        Me.SfDataGrid2.Name = "SfDataGrid2"
        Me.SfDataGrid2.Size = New System.Drawing.Size(1620, 195)
        Me.SfDataGrid2.TabIndex = 2
        Me.SfDataGrid2.Text = "SfDataGrid2"
        '
        'GradientLabel1
        '
        Me.GradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.LightCyan)
        Me.GradientLabel1.BeforeTouchSize = New System.Drawing.Size(390, 21)
        Me.GradientLabel1.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
            Or System.Windows.Forms.Border3DSide.Right) _
            Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
        Me.GradientLabel1.Location = New System.Drawing.Point(1235, 99)
        Me.GradientLabel1.Name = "GradientLabel1"
        Me.GradientLabel1.Size = New System.Drawing.Size(390, 21)
        Me.GradientLabel1.TabIndex = 4
        Me.GradientLabel1.Text = "GradientLabel1"
        Me.GradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1542, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 50)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Actualizar Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1640, 640)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GradientLabel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion"
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SfDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SfDataGrid1 As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SfDataGrid2 As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents GradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
    Friend WithEvents Button1 As Button
End Class
