<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.bRegistrarse = New System.Windows.Forms.Button()
        Me.bAcceder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bRegistrarse
        '
        Me.bRegistrarse.Location = New System.Drawing.Point(248, 180)
        Me.bRegistrarse.Name = "bRegistrarse"
        Me.bRegistrarse.Size = New System.Drawing.Size(117, 36)
        Me.bRegistrarse.TabIndex = 0
        Me.bRegistrarse.Text = "✏ Registrarte"
        Me.bRegistrarse.UseVisualStyleBackColor = True
        '
        'bAcceder
        '
        Me.bAcceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAcceder.ForeColor = System.Drawing.Color.ForestGreen
        Me.bAcceder.Location = New System.Drawing.Point(381, 180)
        Me.bAcceder.Name = "bAcceder"
        Me.bAcceder.Size = New System.Drawing.Size(117, 36)
        Me.bAcceder.TabIndex = 1
        Me.bAcceder.Text = "🔑 Acceder"
        Me.bAcceder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(316, 68)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(256, 22)
        Me.tbUser.TabIndex = 4
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(316, 122)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(256, 22)
        Me.tbPassword.TabIndex = 5
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 254)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bAcceder)
        Me.Controls.Add(Me.bRegistrarse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InicioSesion"
        Me.Text = "Inicio de Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bRegistrarse As Button
    Friend WithEvents bAcceder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUser As TextBox
    Friend WithEvents tbPassword As TextBox
End Class
