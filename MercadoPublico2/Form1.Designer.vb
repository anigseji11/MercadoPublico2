<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtRutaXLS = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBarAdv1 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(963, 458)
        Me.DataGridView1.TabIndex = 0
        '
        'txtRutaXLS
        '
        Me.txtRutaXLS.Location = New System.Drawing.Point(12, 28)
        Me.txtRutaXLS.Name = "txtRutaXLS"
        Me.txtRutaXLS.Size = New System.Drawing.Size(506, 20)
        Me.txtRutaXLS.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(561, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 68)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(656, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 68)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(758, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'ProgressBarAdv1
        '
        Me.ProgressBarAdv1.BackMultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
        Me.ProgressBarAdv1.BackSegments = False
        Me.ProgressBarAdv1.CustomText = Nothing
        Me.ProgressBarAdv1.CustomWaitingRender = False
        Me.ProgressBarAdv1.ForegroundImage = Nothing
        Me.ProgressBarAdv1.Location = New System.Drawing.Point(12, 57)
        Me.ProgressBarAdv1.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
        Me.ProgressBarAdv1.Name = "ProgressBarAdv1"
        Me.ProgressBarAdv1.SegmentWidth = 12
        Me.ProgressBarAdv1.Size = New System.Drawing.Size(506, 23)
        Me.ProgressBarAdv1.TabIndex = 6
        Me.ProgressBarAdv1.Text = "ProgressBarAdv1"
        Me.ProgressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value
        Me.ProgressBarAdv1.Visible = False
        Me.ProgressBarAdv1.WaitingGradientWidth = 400
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 568)
        Me.Controls.Add(Me.ProgressBarAdv1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtRutaXLS)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtRutaXLS As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBarAdv1 As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
End Class
