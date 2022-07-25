<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IMPORTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECCIONAVANZADAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECCIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GESTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AUTOMATICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IMPORTARToolStripMenuItem, Me.SELECCIONAVANZADAToolStripMenuItem, Me.SELECCIONToolStripMenuItem, Me.GESTIONToolStripMenuItem, Me.AUTOMATICAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(494, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MercadoPublico2.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(67, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'IMPORTARToolStripMenuItem
        '
        Me.IMPORTARToolStripMenuItem.Image = Global.MercadoPublico2.My.Resources.Resources.importar
        Me.IMPORTARToolStripMenuItem.Name = "IMPORTARToolStripMenuItem"
        Me.IMPORTARToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.IMPORTARToolStripMenuItem.Text = "IMPORTAR"
        '
        'SELECCIONAVANZADAToolStripMenuItem
        '
        Me.SELECCIONAVANZADAToolStripMenuItem.Image = Global.MercadoPublico2.My.Resources.Resources.search_locate_find_icon_icons_com_67287
        Me.SELECCIONAVANZADAToolStripMenuItem.Name = "SELECCIONAVANZADAToolStripMenuItem"
        Me.SELECCIONAVANZADAToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.SELECCIONAVANZADAToolStripMenuItem.Text = "BUSQUEDA"
        '
        'SELECCIONToolStripMenuItem
        '
        Me.SELECCIONToolStripMenuItem.Image = Global.MercadoPublico2.My.Resources.Resources.Tick_Mark_Dark_icon_icons_com_69147
        Me.SELECCIONToolStripMenuItem.Name = "SELECCIONToolStripMenuItem"
        Me.SELECCIONToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.SELECCIONToolStripMenuItem.Text = "SELECCION"
        '
        'GESTIONToolStripMenuItem
        '
        Me.GESTIONToolStripMenuItem.Image = Global.MercadoPublico2.My.Resources.Resources.engranajes
        Me.GESTIONToolStripMenuItem.Name = "GESTIONToolStripMenuItem"
        Me.GESTIONToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.GESTIONToolStripMenuItem.Text = "GESTION"
        '
        'AUTOMATICAToolStripMenuItem
        '
        Me.AUTOMATICAToolStripMenuItem.Checked = True
        Me.AUTOMATICAToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AUTOMATICAToolStripMenuItem.Image = Global.MercadoPublico2.My.Resources.Resources.OK_32
        Me.AUTOMATICAToolStripMenuItem.Name = "AUTOMATICAToolStripMenuItem"
        Me.AUTOMATICAToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.AUTOMATICAToolStripMenuItem.Text = "POSTULADAS"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 262)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IMPORTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SELECCIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SELECCIONAVANZADAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GESTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AUTOMATICAToolStripMenuItem As ToolStripMenuItem
End Class
