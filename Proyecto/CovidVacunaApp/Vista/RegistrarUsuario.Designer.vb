<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarUsuario))
        Me.bRegistrarUsuario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bRegistrarUsuario
        '
        Me.bRegistrarUsuario.Location = New System.Drawing.Point(135, 247)
        Me.bRegistrarUsuario.Name = "bRegistrarUsuario"
        Me.bRegistrarUsuario.Size = New System.Drawing.Size(349, 43)
        Me.bRegistrarUsuario.TabIndex = 0
        Me.bRegistrarUsuario.Text = "Registrar usuario"
        Me.bRegistrarUsuario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre y Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contraseña:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(275, 57)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(338, 22)
        Me.tbNombre.TabIndex = 4
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(275, 107)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(338, 22)
        Me.tbUsuario.TabIndex = 5
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(275, 161)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(338, 22)
        Me.tbPassword.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Usuario:"
        '
        'bAtras
        '
        Me.bAtras.ForeColor = System.Drawing.Color.Brown
        Me.bAtras.Location = New System.Drawing.Point(490, 247)
        Me.bAtras.Name = "bAtras"
        Me.bAtras.Size = New System.Drawing.Size(123, 43)
        Me.bAtras.TabIndex = 8
        Me.bAtras.Text = "Atrás"
        Me.bAtras.UseVisualStyleBackColor = True
        '
        'RegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 327)
        Me.Controls.Add(Me.bAtras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bRegistrarUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "RegistrarUsuario"
        Me.Text = "Registro de Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bRegistrarUsuario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bAtras As Button
End Class
