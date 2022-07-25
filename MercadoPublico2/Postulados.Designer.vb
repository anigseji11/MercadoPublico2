<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Postulados
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
        Dim GridComboBoxColumn1 As Syncfusion.WinForms.DataGrid.GridComboBoxColumn = New Syncfusion.WinForms.DataGrid.GridComboBoxColumn()
        Dim GridTextColumn8 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn9 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridTextColumn10 As Syncfusion.WinForms.DataGrid.GridTextColumn = New Syncfusion.WinForms.DataGrid.GridTextColumn()
        Dim GridButtonColumn2 As Syncfusion.WinForms.DataGrid.GridButtonColumn = New Syncfusion.WinForms.DataGrid.GridButtonColumn()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Postulados))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SfDataGrid1 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressBarAdv1 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProgressBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SfDataGrid1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1645, 623)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SfDataGrid1
        '
        Me.SfDataGrid1.AccessibleName = "Table"
        Me.SfDataGrid1.AllowFiltering = True
        GridTextColumn1.AllowFiltering = True
        GridTextColumn1.HeaderText = "ID"
        GridTextColumn1.MappingName = "REGISTRO_ID"
        GridTextColumn1.MaximumWidth = 50.0R
        GridTextColumn1.MinimumWidth = 50.0R
        GridTextColumn1.Visible = False
        GridTextColumn2.AllowFiltering = True
        GridTextColumn2.HeaderText = "NUMERO_ADQUISICION"
        GridTextColumn2.MappingName = "NUMERO_ADQUISICION"
        GridTextColumn3.AllowFiltering = True
        GridTextColumn3.HeaderText = "ORGANISMO"
        GridTextColumn3.ImmediateUpdateColumnFilter = True
        GridTextColumn3.MappingName = "ORGANISMO"
        GridTextColumn3.MaximumWidth = 300.0R
        GridTextColumn3.MinimumWidth = 300.0R
        GridTextColumn3.ShowHeaderToolTip = True
        GridTextColumn3.ShowToolTip = True
        GridTextColumn4.AllowFiltering = True
        GridTextColumn4.HeaderText = "NOMBRE_ADQUISICION"
        GridTextColumn4.MappingName = "NOMBRE_ADQUISICION"
        GridTextColumn4.MaximumWidth = 250.0R
        GridTextColumn4.MinimumWidth = 250.0R
        GridTextColumn4.ShowHeaderToolTip = True
        GridTextColumn4.ShowToolTip = True
        GridTextColumn5.AllowFiltering = True
        GridTextColumn5.HeaderText = "DESCRIPCION"
        GridTextColumn5.MappingName = "DESCRIPCION"
        GridTextColumn5.MaximumWidth = 250.0R
        GridTextColumn5.MinimumWidth = 250.0R
        GridTextColumn5.ShowHeaderToolTip = True
        GridTextColumn5.ShowToolTip = True
        GridTextColumn5.Visible = False
        GridTextColumn6.AllowFiltering = True
        GridTextColumn6.HeaderText = "FECHA_PUBLICACION"
        GridTextColumn6.MappingName = "FECHA_PUBLICACION"
        GridTextColumn6.MaximumWidth = 150.0R
        GridTextColumn6.MinimumWidth = 150.0R
        GridTextColumn6.ShowHeaderToolTip = True
        GridTextColumn6.ShowToolTip = True
        GridTextColumn7.AllowFiltering = True
        GridTextColumn7.HeaderText = "FECHA_CIERRE"
        GridTextColumn7.MappingName = "FECHA_CIERRE"
        GridTextColumn7.MaximumWidth = 150.0R
        GridTextColumn7.MinimumWidth = 150.0R
        GridTextColumn7.ShowHeaderToolTip = True
        GridTextColumn7.ShowToolTip = True
        GridButtonColumn1.AllowDefaultButtonText = True
        GridButtonColumn1.AllowFiltering = True
        GridButtonColumn1.ButtonSize = New System.Drawing.Size(0, 0)
        GridButtonColumn1.CellStyle.BackColor = System.Drawing.Color.White
        GridButtonColumn1.CellStyle.TextColor = System.Drawing.Color.White
        GridButtonColumn1.DefaultButtonText = ""
        GridButtonColumn1.FilterBehavior = Syncfusion.Data.FilterBehavior.StringTyped
        GridButtonColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        GridButtonColumn1.HeaderText = "#"
        GridButtonColumn1.Image = Global.MercadoPublico2.My.Resources.Resources.red_mundial__16
        GridButtonColumn1.ImageSize = New System.Drawing.Size(0, 0)
        GridButtonColumn1.MappingName = "Link"
        GridButtonColumn1.MaximumWidth = 500.0R
        GridButtonColumn1.ShowToolTip = True
        GridButtonColumn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        GridButtonColumn1.TextTrimming = System.Drawing.StringTrimming.None
        GridButtonColumn1.Width = 30.0R
        GridComboBoxColumn1.AllowDragging = True
        GridComboBoxColumn1.AllowFiltering = True
        GridComboBoxColumn1.AllowNull = True
        GridComboBoxColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        GridComboBoxColumn1.DisplayMember = "ID"
        GridComboBoxColumn1.HeaderText = "ADJUDICACION"
        GridComboBoxColumn1.MappingName = "ADJUDICACION"
        GridComboBoxColumn1.ShowFilterRowOptions = False
        GridComboBoxColumn1.ShowToolTip = True
        GridComboBoxColumn1.StaysOpenOnEdit = True
        GridComboBoxColumn1.ValueMember = "ESTADO"
        GridTextColumn8.AllowFiltering = True
        GridTextColumn8.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        GridTextColumn8.Format = "C0"
        GridTextColumn8.HeaderText = "$ ADJUDICADO"
        GridTextColumn8.MappingName = "MONTOADJUDICADO"
        GridTextColumn8.ShowHeaderToolTip = True
        GridTextColumn8.ShowToolTip = True
        GridTextColumn9.AllowFiltering = True
        GridTextColumn9.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        GridTextColumn9.HeaderText = "RUTADJUDICADO"
        GridTextColumn9.MappingName = "RUTADJUDICADO"
        GridTextColumn9.ShowToolTip = True
        GridTextColumn10.AllowFiltering = True
        GridTextColumn10.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        GridTextColumn10.HeaderText = "FECHA_ADJUDICACION"
        GridTextColumn10.MappingName = "FECHA_ADJUDICACION"
        GridTextColumn10.ShowToolTip = True
        GridButtonColumn2.AllowDefaultButtonText = False
        GridButtonColumn2.AllowFiltering = True
        GridButtonColumn2.ButtonSize = New System.Drawing.Size(0, 0)
        GridButtonColumn2.DefaultButtonText = ""
        GridButtonColumn2.HeaderText = "Cerrar"
        GridButtonColumn2.Image = Global.MercadoPublico2.My.Resources.Resources.Windows_16
        GridButtonColumn2.ImageSize = New System.Drawing.Size(0, 0)
        GridButtonColumn2.MappingName = "Cerrar"
        GridButtonColumn2.ShowToolTip = True
        GridButtonColumn2.Width = 50.0R
        Me.SfDataGrid1.Columns.Add(GridTextColumn1)
        Me.SfDataGrid1.Columns.Add(GridTextColumn2)
        Me.SfDataGrid1.Columns.Add(GridTextColumn3)
        Me.SfDataGrid1.Columns.Add(GridTextColumn4)
        Me.SfDataGrid1.Columns.Add(GridTextColumn5)
        Me.SfDataGrid1.Columns.Add(GridTextColumn6)
        Me.SfDataGrid1.Columns.Add(GridTextColumn7)
        Me.SfDataGrid1.Columns.Add(GridButtonColumn1)
        Me.SfDataGrid1.Columns.Add(GridComboBoxColumn1)
        Me.SfDataGrid1.Columns.Add(GridTextColumn8)
        Me.SfDataGrid1.Columns.Add(GridTextColumn9)
        Me.SfDataGrid1.Columns.Add(GridTextColumn10)
        Me.SfDataGrid1.Columns.Add(GridButtonColumn2)
        Me.SfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SfDataGrid1.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top
        Me.SfDataGrid1.Location = New System.Drawing.Point(3, 127)
        Me.SfDataGrid1.Name = "SfDataGrid1"
        Me.SfDataGrid1.Size = New System.Drawing.Size(1639, 493)
        Me.SfDataGrid1.Style.HeaderStyle.Font.Bold = True
        Me.SfDataGrid1.Style.HeaderStyle.Font.Size = 6.0!
        Me.SfDataGrid1.TabIndex = 4
        Me.SfDataGrid1.Text = "SfDataGrid1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GradientLabel1)
        Me.Panel1.Controls.Add(Me.ProgressBarAdv1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1639, 118)
        Me.Panel1.TabIndex = 0
        '
        'ProgressBarAdv1
        '
        Me.ProgressBarAdv1.BackMultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
        Me.ProgressBarAdv1.BackSegments = False
        Me.ProgressBarAdv1.CustomText = Nothing
        Me.ProgressBarAdv1.CustomWaitingRender = False
        Me.ProgressBarAdv1.ForegroundImage = Nothing
        Me.ProgressBarAdv1.Location = New System.Drawing.Point(783, 68)
        Me.ProgressBarAdv1.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
        Me.ProgressBarAdv1.Name = "ProgressBarAdv1"
        Me.ProgressBarAdv1.SegmentWidth = 12
        Me.ProgressBarAdv1.Size = New System.Drawing.Size(506, 39)
        Me.ProgressBarAdv1.TabIndex = 8
        Me.ProgressBarAdv1.Text = "ProgressBarAdv1"
        Me.ProgressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value
        Me.ProgressBarAdv1.Visible = False
        Me.ProgressBarAdv1.WaitingGradientWidth = 400
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1521, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Actualizar Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LICITACIONES POSTULADAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MercadoPublico2.My.Resources.Resources.OK_128
        Me.PictureBox1.Location = New System.Drawing.Point(-78, -41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GradientLabel1
        '
        Me.GradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.LightCyan)
        Me.GradientLabel1.BeforeTouchSize = New System.Drawing.Size(221, 23)
        Me.GradientLabel1.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
            Or System.Windows.Forms.Border3DSide.Right) _
            Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
        Me.GradientLabel1.Location = New System.Drawing.Point(169, 84)
        Me.GradientLabel1.Name = "GradientLabel1"
        Me.GradientLabel1.Size = New System.Drawing.Size(221, 23)
        Me.GradientLabel1.TabIndex = 9
        Me.GradientLabel1.Text = "GradientLabel1"
        Me.GradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Postulados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1645, 623)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Postulados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Postulados"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProgressBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SfDataGrid1 As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBarAdv1 As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
    Friend WithEvents GradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
End Class
