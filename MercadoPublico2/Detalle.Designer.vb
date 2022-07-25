<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Detalle
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalle))
        Me.ProgressBarAdv1 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
        CType(Me.ProgressBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarAdv1
        '
        Me.ProgressBarAdv1.BackMultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
        Me.ProgressBarAdv1.BackSegments = False
        Me.ProgressBarAdv1.CustomText = Nothing
        Me.ProgressBarAdv1.CustomWaitingRender = False
        Me.ProgressBarAdv1.ForegroundImage = Nothing
        Me.ProgressBarAdv1.Location = New System.Drawing.Point(36, 126)
        Me.ProgressBarAdv1.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
        Me.ProgressBarAdv1.Name = "ProgressBarAdv1"
        Me.ProgressBarAdv1.SegmentWidth = 12
        Me.ProgressBarAdv1.Size = New System.Drawing.Size(506, 39)
        Me.ProgressBarAdv1.TabIndex = 7
        Me.ProgressBarAdv1.Text = "ProgressBarAdv1"
        Me.ProgressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value
        Me.ProgressBarAdv1.Visible = False
        Me.ProgressBarAdv1.WaitingGradientWidth = 400
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 41)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "TRAER ACTIVAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(407, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 41)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "TRAER DE HOY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GradientLabel1
        '
        Me.GradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.LightCyan)
        Me.GradientLabel1.BeforeTouchSize = New System.Drawing.Size(321, 23)
        Me.GradientLabel1.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
            Or System.Windows.Forms.Border3DSide.Right) _
            Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
        Me.GradientLabel1.Location = New System.Drawing.Point(126, 76)
        Me.GradientLabel1.Name = "GradientLabel1"
        Me.GradientLabel1.Size = New System.Drawing.Size(321, 23)
        Me.GradientLabel1.TabIndex = 10
        Me.GradientLabel1.Text = "GradientLabel1"
        Me.GradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 191)
        Me.Controls.Add(Me.GradientLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBarAdv1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar"
        CType(Me.ProgressBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBarAdv1 As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
End Class
