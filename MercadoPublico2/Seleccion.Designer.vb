<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Seleccion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridCheckBoxColumn1 As Syncfusion.WinForms.DataGrid.GridCheckBoxColumn = New Syncfusion.WinForms.DataGrid.GridCheckBoxColumn()
        Dim GridTextColumn1 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn2 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn3 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn4 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridButtonColumn1 As Syncfusion.WinForms.DataGrid.GridButtonColumn = New Syncfusion.WinForms.DataGrid.GridButtonColumn()
        Dim GridButtonColumn2 As Syncfusion.WinForms.DataGrid.GridButtonColumn = New Syncfusion.WinForms.DataGrid.GridButtonColumn()
        Dim GridButtonColumn3 As Syncfusion.WinForms.DataGrid.GridButtonColumn = New Syncfusion.WinForms.DataGrid.GridButtonColumn()
        Dim GridTextColumn5 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn6 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn7 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SfDataGrid1 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.ContextMenuStripEx1 = New Syncfusion.Windows.Forms.Tools.ContextMenuStripEx()
        Me.SEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesmarcarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SfDataGrid2 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SfDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.SfDataGrid1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1630, 466)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccionados"
        '
        'SfDataGrid1
        '
        Me.SfDataGrid1.AccessibleName = "Table"
        Me.SfDataGrid1.AllowFiltering = True
        Me.SfDataGrid1.AllowResizingColumns = True
        Me.SfDataGrid1.AllowResizingHiddenColumns = True
        GridCheckBoxColumn1.AllowFiltering = True
        GridCheckBoxColumn1.AllowResizing = True
        GridCheckBoxColumn1.HeaderText = "#"
        GridCheckBoxColumn1.MappingName = "Seleccion"
        GridCheckBoxColumn1.MaximumWidth = 50.0R
        GridCheckBoxColumn1.MinimumWidth = 50.0R
        GridTextColumn1.AllowFiltering = True
        GridTextColumn1.AllowResizing = True
        GridTextColumn1.HeaderText = "ORGANISMO"
        GridTextColumn1.MappingName = "ORGANISMO"
        GridTextColumn1.MinimumWidth = 200.0R
        GridTextColumn1.ShowHeaderToolTip = True
        GridTextColumn1.ShowToolTip = True
        GridTextColumn2.AllowFiltering = True
        GridTextColumn2.AllowResizing = True
        GridTextColumn2.HeaderText = "NUMERO"
        GridTextColumn2.MappingName = "NUMERO_ADQUISICION"
        GridTextColumn3.AllowFiltering = True
        GridTextColumn3.AllowResizing = True
        GridTextColumn3.HeaderText = "NOMBRE_ADQUISICION"
        GridTextColumn3.ImmediateUpdateColumnFilter = True
        GridTextColumn3.MappingName = "NOMBRE_ADQUISICION"
        GridTextColumn3.MinimumWidth = 350.0R
        GridTextColumn3.ShowHeaderToolTip = True
        GridTextColumn3.ShowToolTip = True
        GridTextColumn4.AllowFiltering = True
        GridTextColumn4.AllowResizing = True
        GridTextColumn4.HeaderText = "DESCRIPCION"
        GridTextColumn4.ImmediateUpdateColumnFilter = True
        GridTextColumn4.MappingName = "DESCRIPCION"
        GridTextColumn4.MinimumWidth = 350.0R
        GridTextColumn4.ShowHeaderToolTip = True
        GridTextColumn4.ShowToolTip = True
        GridButtonColumn1.AllowDefaultButtonText = True
        GridButtonColumn1.AllowFiltering = True
        GridButtonColumn1.AllowResizing = True
        GridButtonColumn1.ButtonSize = New System.Drawing.Size(0, 0)
        GridButtonColumn1.DefaultButtonText = ""
        GridButtonColumn1.HeaderText = "#"
        GridButtonColumn1.Image = Global.MercadoPublico2.My.Resources.Resources.red_mundial__16
        GridButtonColumn1.ImageSize = New System.Drawing.Size(0, 0)
        GridButtonColumn1.MappingName = "Link"
        GridButtonColumn1.MaximumWidth = 35.0R
        GridButtonColumn1.MinimumWidth = 35.0R
        GridButtonColumn1.NullDisplayText = " "
        GridButtonColumn1.ShowHeaderToolTip = True
        GridButtonColumn1.ShowToolTip = True
        GridButtonColumn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        GridButtonColumn2.AllowDefaultButtonText = False
        GridButtonColumn2.AllowFiltering = True
        GridButtonColumn2.AllowResizing = True
        GridButtonColumn2.ButtonSize = New System.Drawing.Size(0, 0)
        GridButtonColumn2.DefaultButtonText = ""
        GridButtonColumn2.HeaderText = "Seleccionar"
        GridButtonColumn2.Image = Global.MercadoPublico2.My.Resources.Resources.Tick_Mark_Dark_icon_icons1
        GridButtonColumn2.ImageSize = New System.Drawing.Size(0, 0)
        GridButtonColumn2.MappingName = "Seleccionar"
        GridButtonColumn2.MaximumWidth = 35.0R
        GridButtonColumn2.MinimumWidth = 35.0R
        GridButtonColumn2.ShowToolTip = True
        GridButtonColumn3.AllowDefaultButtonText = False
        GridButtonColumn3.AllowFiltering = True
        GridButtonColumn3.AllowResizing = True
        GridButtonColumn3.ButtonSize = New System.Drawing.Size(0, 0)
        GridButtonColumn3.DefaultButtonText = ""
        GridButtonColumn3.HeaderText = "#"
        GridButtonColumn3.Image = Global.MercadoPublico2.My.Resources.Resources.OJo
        GridButtonColumn3.ImageSize = New System.Drawing.Size(0, 0)
        GridButtonColumn3.MappingName = "Ver"
        GridButtonColumn3.ShowToolTip = True
        Me.SfDataGrid1.Columns.Add(GridCheckBoxColumn1)
        Me.SfDataGrid1.Columns.Add(GridTextColumn1)
        Me.SfDataGrid1.Columns.Add(GridTextColumn2)
        Me.SfDataGrid1.Columns.Add(GridTextColumn3)
        Me.SfDataGrid1.Columns.Add(GridTextColumn4)
        Me.SfDataGrid1.Columns.Add(GridButtonColumn1)
        Me.SfDataGrid1.Columns.Add(GridButtonColumn2)
        Me.SfDataGrid1.Columns.Add(GridButtonColumn3)
        Me.SfDataGrid1.ContextMenuStrip = Me.ContextMenuStripEx1
        Me.SfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SfDataGrid1.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top
        Me.SfDataGrid1.Location = New System.Drawing.Point(3, 16)
        Me.SfDataGrid1.Name = "SfDataGrid1"
        Me.SfDataGrid1.ShowGroupDropArea = True
        Me.SfDataGrid1.Size = New System.Drawing.Size(1624, 447)
        Me.SfDataGrid1.TabIndex = 1
        Me.SfDataGrid1.Text = "SfDataGrid1"
        '
        'ContextMenuStripEx1
        '
        Me.ContextMenuStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEToolStripMenuItem, Me.DesmarcarTodosToolStripMenuItem})
        Me.ContextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ContextMenuStripEx1.Name = "ContextMenuStripEx1"
        Me.ContextMenuStripEx1.Size = New System.Drawing.Size(165, 48)
        Me.ContextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.[Default]
        Me.ContextMenuStripEx1.ThemeName = "Default"
        '
        'SEToolStripMenuItem
        '
        Me.SEToolStripMenuItem.Image = Global.MercadoPublico2.My.Resources.Resources.Tick_Mark_Dark_icon_icons_com_69147
        Me.SEToolStripMenuItem.Name = "SEToolStripMenuItem"
        Me.SEToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SEToolStripMenuItem.Text = "Marcar Todos"
        '
        'DesmarcarTodosToolStripMenuItem
        '
        Me.DesmarcarTodosToolStripMenuItem.Image = Global.MercadoPublico2.My.Resources.Resources.Close_Icon_Dark_icon_icons_com_69143
        Me.DesmarcarTodosToolStripMenuItem.Name = "DesmarcarTodosToolStripMenuItem"
        Me.DesmarcarTodosToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DesmarcarTodosToolStripMenuItem.Text = "Desmarcar Todos"
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.MercadoPublico2.My.Resources.Resources.borrar_32
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1190, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 51)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Descartar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SfDataGrid2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 561)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1630, 288)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionados"
        '
        'SfDataGrid2
        '
        Me.SfDataGrid2.AccessibleName = "Table"
        Me.SfDataGrid2.AllowFiltering = True
        Me.SfDataGrid2.AllowResizingColumns = True
        Me.SfDataGrid2.AllowResizingHiddenColumns = True
        GridTextColumn5.AllowFiltering = True
        GridTextColumn5.AllowResizing = True
        GridTextColumn5.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        GridTextColumn5.HeaderText = "CANTIDAD"
        GridTextColumn5.MappingName = "CANTIDAD"
        GridTextColumn6.AllowFiltering = True
        GridTextColumn6.AllowResizing = True
        GridTextColumn6.HeaderText = "DESCRIPCION_PRODUCTO_O_SERVICIO"
        GridTextColumn6.MappingName = "DESCRIPCION_PRODUCTO_O_SERVICIO"
        GridTextColumn6.ShowToolTip = True
        GridTextColumn6.Width = 500.0R
        GridTextColumn7.AllowFiltering = True
        GridTextColumn7.AllowResizing = True
        GridTextColumn7.HeaderText = "UNIDAD_MEDIDA"
        GridTextColumn7.MappingName = "UNIDAD_MEDIDA"
        GridTextColumn7.Width = 150.0R
        Me.SfDataGrid2.Columns.Add(GridTextColumn5)
        Me.SfDataGrid2.Columns.Add(GridTextColumn6)
        Me.SfDataGrid2.Columns.Add(GridTextColumn7)
        Me.SfDataGrid2.ContextMenuStrip = Me.ContextMenuStripEx1
        Me.SfDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SfDataGrid2.Location = New System.Drawing.Point(3, 16)
        Me.SfDataGrid2.Name = "SfDataGrid2"
        Me.SfDataGrid2.ShowGroupDropArea = True
        Me.SfDataGrid2.Size = New System.Drawing.Size(1624, 269)
        Me.SfDataGrid2.TabIndex = 1
        Me.SfDataGrid2.Text = "SfDataGrid2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MercadoPublico2.My.Resources.Resources.Tick_Mark_Dark_icon_icons_com_69147
        Me.PictureBox1.Location = New System.Drawing.Point(-92, -90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SELECCION / DESCARTE DE LICITACIONES"
        '
        'Seleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Seleccion"
        Me.Text = "Seleccion"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SfDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents SfDataGrid1 As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents ContextMenuStripEx1 As Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
    Friend WithEvents SEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesmarcarTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SfDataGrid2 As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
