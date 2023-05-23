<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiempo
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.BtnMostrarHora = New System.Windows.Forms.Button()
        Me.BtnDetenerTiempo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrHora
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora:"
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHora.Location = New System.Drawing.Point(184, 32)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(72, 24)
        Me.lbHora.TabIndex = 1
        Me.lbHora.Text = "Label2"
        '
        'BtnMostrarHora
        '
        Me.BtnMostrarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrarHora.Location = New System.Drawing.Point(34, 100)
        Me.BtnMostrarHora.Name = "BtnMostrarHora"
        Me.BtnMostrarHora.Size = New System.Drawing.Size(115, 54)
        Me.BtnMostrarHora.TabIndex = 2
        Me.BtnMostrarHora.Text = "Mostrar Hora"
        Me.BtnMostrarHora.UseVisualStyleBackColor = True
        '
        'BtnDetenerTiempo
        '
        Me.BtnDetenerTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetenerTiempo.Location = New System.Drawing.Point(202, 100)
        Me.BtnDetenerTiempo.Name = "BtnDetenerTiempo"
        Me.BtnDetenerTiempo.Size = New System.Drawing.Size(119, 54)
        Me.BtnDetenerTiempo.TabIndex = 3
        Me.BtnDetenerTiempo.Text = "Detener Tiempo"
        Me.BtnDetenerTiempo.UseVisualStyleBackColor = True
        '
        'frmTiempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(383, 211)
        Me.Controls.Add(Me.BtnDetenerTiempo)
        Me.Controls.Add(Me.BtnMostrarHora)
        Me.Controls.Add(Me.lbHora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTiempo"
        Me.Text = "frmTiempo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrHora As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lbHora As Label
    Friend WithEvents BtnMostrarHora As Button
    Friend WithEvents BtnDetenerTiempo As Button
End Class
