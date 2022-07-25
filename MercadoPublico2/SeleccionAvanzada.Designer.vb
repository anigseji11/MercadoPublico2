<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionAvanzada
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
        Dim GridTextColumn5 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn6 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn7 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn8 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim GridTextColumn9 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn10 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn11 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn12 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Me.ComboTipo = New System.Windows.Forms.ComboBox()
        Me.ComboCondicion = New System.Windows.Forms.ComboBox()
        Me.ComColumna = New System.Windows.Forms.ComboBox()
        Me.TextPalabra = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SfDataGrid1 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SQL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PALABRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONDICION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SfDataGrid2 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SfDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboTipo
        '
        Me.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipo.FormattingEnabled = True
        Me.ComboTipo.Items.AddRange(New Object() {"LIKE", "NOT LIKE"})
        Me.ComboTipo.Location = New System.Drawing.Point(12, 27)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.Size = New System.Drawing.Size(179, 21)
        Me.ComboTipo.TabIndex = 2
        '
        'ComboCondicion
        '
        Me.ComboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCondicion.FormattingEnabled = True
        Me.ComboCondicion.Items.AddRange(New Object() {"AND", "OR"})
        Me.ComboCondicion.Location = New System.Drawing.Point(12, 54)
        Me.ComboCondicion.Name = "ComboCondicion"
        Me.ComboCondicion.Size = New System.Drawing.Size(179, 21)
        Me.ComboCondicion.TabIndex = 5
        '
        'ComColumna
        '
        Me.ComColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComColumna.FormattingEnabled = True
        Me.ComColumna.Items.AddRange(New Object() {"NOMBRE_ADQUISICION", "DESCRIPCION", "DESCRIPCION_PRODUCTO_O_SERVICIO"})
        Me.ComColumna.Location = New System.Drawing.Point(12, 81)
        Me.ComColumna.Name = "ComColumna"
        Me.ComColumna.Size = New System.Drawing.Size(179, 21)
        Me.ComColumna.TabIndex = 4
        '
        'TextPalabra
        '
        Me.TextPalabra.Location = New System.Drawing.Point(12, 1)
        Me.TextPalabra.Name = "TextPalabra"
        Me.TextPalabra.Size = New System.Drawing.Size(179, 20)
        Me.TextPalabra.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(459, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(784, 80)
        Me.txtSearch.TabIndex = 7
        Me.txtSearch.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(456, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consulta SQL"
        '
        'SfDataGrid1
        '
        Me.SfDataGrid1.AccessibleName = "Table"
        GridTextColumn5.HeaderText = "ORGANISMO"
        GridTextColumn5.MappingName = "ORGANISMO"
        GridTextColumn5.MaximumWidth = 250.0R
        GridTextColumn5.MinimumWidth = 250.0R
        GridTextColumn5.ShowHeaderToolTip = True
        GridTextColumn5.ShowToolTip = True
        GridTextColumn6.HeaderText = "NUMERO_ADQUISICION"
        GridTextColumn6.MappingName = "NUMERO_ADQUISICION"
        GridTextColumn6.MaximumWidth = 200.0R
        GridTextColumn6.MinimumWidth = 200.0R
        GridTextColumn6.ShowToolTip = True
        GridTextColumn7.HeaderText = "NOMBRE_ADQUISICION"
        GridTextColumn7.MappingName = "NOMBRE_ADQUISICION"
        GridTextColumn7.MaximumWidth = 300.0R
        GridTextColumn7.MinimumWidth = 300.0R
        GridTextColumn7.ShowHeaderToolTip = True
        GridTextColumn7.ShowToolTip = True
        GridTextColumn8.HeaderText = "DESCRIPCION"
        GridTextColumn8.MappingName = "DESCRIPCION"
        GridTextColumn8.MaximumWidth = 500.0R
        GridTextColumn8.MinimumWidth = 500.0R
        GridTextColumn8.ShowHeaderToolTip = True
        GridTextColumn8.ShowToolTip = True
        Me.SfDataGrid1.Columns.Add(GridTextColumn5)
        Me.SfDataGrid1.Columns.Add(GridTextColumn6)
        Me.SfDataGrid1.Columns.Add(GridTextColumn7)
        Me.SfDataGrid1.Columns.Add(GridTextColumn8)
        Me.SfDataGrid1.Location = New System.Drawing.Point(459, 122)
        Me.SfDataGrid1.Name = "SfDataGrid1"
        Me.SfDataGrid1.Size = New System.Drawing.Size(1197, 298)
        Me.SfDataGrid1.TabIndex = 9
        Me.SfDataGrid1.Text = "SfDataGrid1"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.SQL})
        Me.DataGridView2.Location = New System.Drawing.Point(15, 332)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(324, 274)
        Me.DataGridView2.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "REGISTRO_ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'SQL
        '
        Me.SQL.DataPropertyName = "SQL"
        Me.SQL.HeaderText = "SQL"
        Me.SQL.Name = "SQL"
        Me.SQL.ReadOnly = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PALABRA, Me.TIPO, Me.Columna, Me.CONDICION})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(347, 218)
        Me.DataGridView1.TabIndex = 1
        '
        'PALABRA
        '
        Me.PALABRA.HeaderText = "PALABRA"
        Me.PALABRA.Name = "PALABRA"
        Me.PALABRA.ReadOnly = True
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        '
        'Columna
        '
        Me.Columna.HeaderText = "COLUMNA"
        Me.Columna.Name = "Columna"
        Me.Columna.ReadOnly = True
        '
        'CONDICION
        '
        Me.CONDICION.HeaderText = "CONDICION"
        Me.CONDICION.Name = "CONDICION"
        Me.CONDICION.ReadOnly = True
        '
        'SfDataGrid2
        '
        Me.SfDataGrid2.AccessibleName = "Table"
        Me.SfDataGrid2.AllowFiltering = True
        Me.SfDataGrid2.AllowResizingColumns = True
        Me.SfDataGrid2.AllowResizingHiddenColumns = True
        GridTextColumn9.AllowFiltering = True
        GridTextColumn9.AllowResizing = True
        GridTextColumn9.HeaderText = "CANTIDAD"
        GridTextColumn9.MappingName = "CANTIDAD"
        GridTextColumn10.AllowFiltering = True
        GridTextColumn10.AllowResizing = True
        GridTextColumn10.HeaderText = "DESCRIPCION_PRODUCTO_O_SERVICIO"
        GridTextColumn10.MappingName = "DESCRIPCION_PRODUCTO_O_SERVICIO"
        GridTextColumn10.MaximumWidth = 500.0R
        GridTextColumn10.MinimumWidth = 500.0R
        GridTextColumn10.ShowToolTip = True
        GridTextColumn11.AllowFiltering = True
        GridTextColumn11.AllowResizing = True
        GridTextColumn11.HeaderText = "GENERICO"
        GridTextColumn11.MappingName = "GENERICO"
        GridTextColumn11.MaximumWidth = 200.0R
        GridTextColumn11.MinimumWidth = 200.0R
        GridTextColumn11.ShowToolTip = True
        GridTextColumn12.AllowFiltering = True
        GridTextColumn12.AllowResizing = True
        GridTextColumn12.HeaderText = "UNIDAD_MEDIDA"
        GridTextColumn12.MappingName = "UNIDAD_MEDIDA"
        GridTextColumn12.MaximumWidth = 150.0R
        GridTextColumn12.MinimumWidth = 150.0R
        GridTextColumn12.ShowToolTip = True
        Me.SfDataGrid2.Columns.Add(GridTextColumn9)
        Me.SfDataGrid2.Columns.Add(GridTextColumn10)
        Me.SfDataGrid2.Columns.Add(GridTextColumn11)
        Me.SfDataGrid2.Columns.Add(GridTextColumn12)
        Me.SfDataGrid2.Location = New System.Drawing.Point(459, 426)
        Me.SfDataGrid2.Name = "SfDataGrid2"
        Me.SfDataGrid2.Size = New System.Drawing.Size(1197, 211)
        Me.SfDataGrid2.TabIndex = 12
        Me.SfDataGrid2.Text = "SfDataGrid2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1481, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.MercadoPublico2.My.Resources.Resources.limpiar___32
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(365, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 69)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Limpiar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.MercadoPublico2.My.Resources.Resources.comprobado___32
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(1249, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 73)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Seleccionar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.MercadoPublico2.My.Resources.Resources.mas___32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(227, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 68)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "AGREGAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.MercadoPublico2.My.Resources.Resources.pruebas___32
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(365, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 68)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Probar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.MercadoPublico2.My.Resources.Resources.anadir___32
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(365, 161)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 87)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Guardar SQL"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SeleccionAvanzada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 645)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.SfDataGrid2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.ComboCondicion)
        Me.Controls.Add(Me.SfDataGrid1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ComColumna)
        Me.Controls.Add(Me.TextPalabra)
        Me.Controls.Add(Me.ComboTipo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SeleccionAvanzada"
        Me.Text = "SeleccionAvanzada"
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SfDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboTipo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextPalabra As TextBox
    Friend WithEvents ComColumna As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SfDataGrid1 As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboCondicion As ComboBox
    Friend WithEvents PALABRA As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents Columna As DataGridViewTextBoxColumn
    Friend WithEvents CONDICION As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents SQL As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As RichTextBox
    Friend WithEvents SfDataGrid2 As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
End Class
