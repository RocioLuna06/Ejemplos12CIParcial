<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcceso
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
        Me.lnkRestablecer = New System.Windows.Forms.LinkLabel()
        Me.lnkRegistrarse = New System.Windows.Forms.LinkLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grbAcceso = New System.Windows.Forms.GroupBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtNombreUser = New System.Windows.Forms.TextBox()
        Me.lblNombreUser = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.grbAcceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnkRestablecer
        '
        Me.lnkRestablecer.AutoSize = True
        Me.lnkRestablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRestablecer.Location = New System.Drawing.Point(158, 392)
        Me.lnkRestablecer.Name = "lnkRestablecer"
        Me.lnkRestablecer.Size = New System.Drawing.Size(169, 16)
        Me.lnkRestablecer.TabIndex = 17
        Me.lnkRestablecer.TabStop = True
        Me.lnkRestablecer.Text = "¿Olvido su contraseña?"
        '
        'lnkRegistrarse
        '
        Me.lnkRegistrarse.AutoSize = True
        Me.lnkRegistrarse.BackColor = System.Drawing.Color.Transparent
        Me.lnkRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRegistrarse.Location = New System.Drawing.Point(198, 355)
        Me.lnkRegistrarse.Name = "lnkRegistrarse"
        Me.lnkRegistrarse.Size = New System.Drawing.Size(88, 16)
        Me.lnkRegistrarse.TabIndex = 16
        Me.lnkRegistrarse.TabStop = True
        Me.lnkRegistrarse.Text = "Registrarse"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.EJemplovBasic.My.Resources.Resources.delete1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(251, 275)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 52)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grbAcceso
        '
        Me.grbAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.grbAcceso.Controls.Add(Me.lblPassword)
        Me.grbAcceso.Controls.Add(Me.txtPassword)
        Me.grbAcceso.Controls.Add(Me.txtNombreUser)
        Me.grbAcceso.Controls.Add(Me.lblNombreUser)
        Me.grbAcceso.Location = New System.Drawing.Point(48, 80)
        Me.grbAcceso.Name = "grbAcceso"
        Me.grbAcceso.Size = New System.Drawing.Size(366, 164)
        Me.grbAcceso.TabIndex = 13
        Me.grbAcceso.TabStop = False
        Me.grbAcceso.Text = "Acceso"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(6, 108)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(107, 20)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Contraseña:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(179, 110)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(181, 20)
        Me.txtPassword.TabIndex = 5
        '
        'txtNombreUser
        '
        Me.txtNombreUser.Location = New System.Drawing.Point(179, 38)
        Me.txtNombreUser.Name = "txtNombreUser"
        Me.txtNombreUser.Size = New System.Drawing.Size(181, 20)
        Me.txtNombreUser.TabIndex = 4
        '
        'lblNombreUser
        '
        Me.lblNombreUser.AutoSize = True
        Me.lblNombreUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUser.Location = New System.Drawing.Point(6, 37)
        Me.lblNombreUser.Name = "lblNombreUser"
        Me.lblNombreUser.Size = New System.Drawing.Size(168, 20)
        Me.lblNombreUser.TabIndex = 2
        Me.lblNombreUser.Text = "Nombre de Usuario:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(104, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(242, 24)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = " Usuario de la Plataforma"
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.EJemplovBasic.My.Resources.Resources.apply
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.Location = New System.Drawing.Point(123, 275)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 52)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(459, 450)
        Me.Controls.Add(Me.lnkRestablecer)
        Me.Controls.Add(Me.lnkRegistrarse)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grbAcceso)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmAcceso"
        Me.Text = "frmAcceso"
        Me.grbAcceso.ResumeLayout(False)
        Me.grbAcceso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lnkRestablecer As LinkLabel
    Private WithEvents lnkRegistrarse As LinkLabel
    Private WithEvents btnAceptar As Button
    Private WithEvents btnCancelar As Button
    Private WithEvents grbAcceso As GroupBox
    Private WithEvents lblPassword As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtNombreUser As TextBox
    Private WithEvents lblNombreUser As Label
    Private WithEvents lblTitulo As Label
End Class
