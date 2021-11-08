<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AplicacionPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionarAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarAsignaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarNotasAAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.tbSegundoApellido = New System.Windows.Forms.TextBox()
        Me.bInsertar = New System.Windows.Forms.Button()
        Me.bEditar = New System.Windows.Forms.Button()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSegundoApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bMatricular = New System.Windows.Forms.Button()
        Me.clAsignaturas = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbDibujo = New System.Windows.Forms.TextBox()
        Me.bDibujo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbBiologia = New System.Windows.Forms.TextBox()
        Me.bBiologia = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbLenguaje = New System.Windows.Forms.TextBox()
        Me.bLenguaje = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbQuimica = New System.Windows.Forms.TextBox()
        Me.bQuimica = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbFisica = New System.Windows.Forms.TextBox()
        Me.bFisica = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMategmaticas = New System.Windows.Forms.TextBox()
        Me.bMatematicas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Empty
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarAlumnosToolStripMenuItem, Me.GestionarAsignaturasToolStripMenuItem, Me.InsertarNotasAAlumnosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1137, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionarAlumnosToolStripMenuItem
        '
        Me.GestionarAlumnosToolStripMenuItem.Name = "GestionarAlumnosToolStripMenuItem"
        Me.GestionarAlumnosToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.GestionarAlumnosToolStripMenuItem.Text = "Gestionar alumnos"
        '
        'GestionarAsignaturasToolStripMenuItem
        '
        Me.GestionarAsignaturasToolStripMenuItem.Name = "GestionarAsignaturasToolStripMenuItem"
        Me.GestionarAsignaturasToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.GestionarAsignaturasToolStripMenuItem.Text = "Gestionar asignaturas"
        '
        'InsertarNotasAAlumnosToolStripMenuItem
        '
        Me.InsertarNotasAAlumnosToolStripMenuItem.Name = "InsertarNotasAAlumnosToolStripMenuItem"
        Me.InsertarNotasAAlumnosToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.InsertarNotasAAlumnosToolStripMenuItem.Text = "Insertar notas a alumnos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Segundo apellido: "
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(230, 50)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(263, 27)
        Me.tbNombre.TabIndex = 5
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(230, 99)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(263, 27)
        Me.tbApellido.TabIndex = 6
        '
        'tbSegundoApellido
        '
        Me.tbSegundoApellido.Location = New System.Drawing.Point(230, 154)
        Me.tbSegundoApellido.Name = "tbSegundoApellido"
        Me.tbSegundoApellido.Size = New System.Drawing.Size(263, 27)
        Me.tbSegundoApellido.TabIndex = 7
        '
        'bInsertar
        '
        Me.bInsertar.Location = New System.Drawing.Point(855, 49)
        Me.bInsertar.Name = "bInsertar"
        Me.bInsertar.Size = New System.Drawing.Size(94, 29)
        Me.bInsertar.TabIndex = 8
        Me.bInsertar.Text = "🙍 Insertar"
        Me.bInsertar.UseVisualStyleBackColor = True
        '
        'bEditar
        '
        Me.bEditar.Location = New System.Drawing.Point(855, 98)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(94, 29)
        Me.bEditar.TabIndex = 9
        Me.bEditar.Text = "✏️ Editar"
        Me.bEditar.UseVisualStyleBackColor = True
        '
        'bBorrar
        '
        Me.bBorrar.Location = New System.Drawing.Point(855, 152)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(94, 29)
        Me.bBorrar.TabIndex = 10
        Me.bBorrar.Text = "🗑️ Borrar"
        Me.bBorrar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNombre, Me.cApellido, Me.cSegundoApellido})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1100, 237)
        Me.DataGridView1.TabIndex = 11
        '
        'cNombre
        '
        Me.cNombre.Frozen = True
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.MinimumWidth = 6
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
        Me.cNombre.Width = 93
        '
        'cApellido
        '
        Me.cApellido.Frozen = True
        Me.cApellido.HeaderText = "Apellido"
        Me.cApellido.MinimumWidth = 6
        Me.cApellido.Name = "cApellido"
        Me.cApellido.ReadOnly = True
        Me.cApellido.Width = 95
        '
        'cSegundoApellido
        '
        Me.cSegundoApellido.Frozen = True
        Me.cSegundoApellido.HeaderText = "Segundo Apellido"
        Me.cSegundoApellido.MinimumWidth = 6
        Me.cSegundoApellido.Name = "cSegundoApellido"
        Me.cSegundoApellido.ReadOnly = True
        Me.cSegundoApellido.Width = 145
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bBorrar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.bEditar)
        Me.GroupBox1.Controls.Add(Me.tbNombre)
        Me.GroupBox1.Controls.Add(Me.bInsertar)
        Me.GroupBox1.Controls.Add(Me.tbApellido)
        Me.GroupBox1.Controls.Add(Me.tbSegundoApellido)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1100, 234)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestionar alumnos/as:"
        Me.GroupBox1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.bMatricular)
        Me.GroupBox2.Controls.Add(Me.clAsignaturas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 557)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(563, 358)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Matricular en asignaturas a los alumnos/as:"
        '
        'bMatricular
        '
        Me.bMatricular.Location = New System.Drawing.Point(372, 287)
        Me.bMatricular.Name = "bMatricular"
        Me.bMatricular.Size = New System.Drawing.Size(121, 29)
        Me.bMatricular.TabIndex = 11
        Me.bMatricular.Text = "👨‍🎓 Matricular"
        Me.bMatricular.UseVisualStyleBackColor = True
        '
        'clAsignaturas
        '
        Me.clAsignaturas.FormattingEnabled = True
        Me.clAsignaturas.Items.AddRange(New Object() {"Matemáticas", "Física", "Química", "Lenguaje", "Biología", "Dibujo"})
        Me.clAsignaturas.Location = New System.Drawing.Point(62, 91)
        Me.clAsignaturas.Name = "clAsignaturas"
        Me.clAsignaturas.Size = New System.Drawing.Size(252, 136)
        Me.clAsignaturas.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Location = New System.Drawing.Point(581, 557)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(531, 358)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Introducir notas:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbDibujo)
        Me.Panel1.Controls.Add(Me.bDibujo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tbBiologia)
        Me.Panel1.Controls.Add(Me.bBiologia)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tbLenguaje)
        Me.Panel1.Controls.Add(Me.bLenguaje)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tbQuimica)
        Me.Panel1.Controls.Add(Me.bQuimica)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tbFisica)
        Me.Panel1.Controls.Add(Me.bFisica)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tbMategmaticas)
        Me.Panel1.Controls.Add(Me.bMatematicas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(26, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 303)
        Me.Panel1.TabIndex = 0
        '
        'tbDibujo
        '
        Me.tbDibujo.Location = New System.Drawing.Point(186, 252)
        Me.tbDibujo.Name = "tbDibujo"
        Me.tbDibujo.Size = New System.Drawing.Size(125, 27)
        Me.tbDibujo.TabIndex = 17
        '
        'bDibujo
        '
        Me.bDibujo.Location = New System.Drawing.Point(348, 250)
        Me.bDibujo.Name = "bDibujo"
        Me.bDibujo.Size = New System.Drawing.Size(94, 29)
        Me.bDibujo.TabIndex = 16
        Me.bDibujo.Text = "💾 Guardar"
        Me.bDibujo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Dibujo:"
        '
        'tbBiologia
        '
        Me.tbBiologia.Location = New System.Drawing.Point(186, 208)
        Me.tbBiologia.Name = "tbBiologia"
        Me.tbBiologia.Size = New System.Drawing.Size(125, 27)
        Me.tbBiologia.TabIndex = 14
        '
        'bBiologia
        '
        Me.bBiologia.Location = New System.Drawing.Point(348, 206)
        Me.bBiologia.Name = "bBiologia"
        Me.bBiologia.Size = New System.Drawing.Size(94, 29)
        Me.bBiologia.TabIndex = 13
        Me.bBiologia.Text = "💾 Guardar"
        Me.bBiologia.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Biología:"
        '
        'tbLenguaje
        '
        Me.tbLenguaje.Location = New System.Drawing.Point(186, 166)
        Me.tbLenguaje.Name = "tbLenguaje"
        Me.tbLenguaje.Size = New System.Drawing.Size(125, 27)
        Me.tbLenguaje.TabIndex = 11
        '
        'bLenguaje
        '
        Me.bLenguaje.Location = New System.Drawing.Point(348, 164)
        Me.bLenguaje.Name = "bLenguaje"
        Me.bLenguaje.Size = New System.Drawing.Size(94, 29)
        Me.bLenguaje.TabIndex = 10
        Me.bLenguaje.Text = "💾 Guardar"
        Me.bLenguaje.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Lenguaje:"
        '
        'tbQuimica
        '
        Me.tbQuimica.Location = New System.Drawing.Point(186, 125)
        Me.tbQuimica.Name = "tbQuimica"
        Me.tbQuimica.Size = New System.Drawing.Size(125, 27)
        Me.tbQuimica.TabIndex = 8
        '
        'bQuimica
        '
        Me.bQuimica.Location = New System.Drawing.Point(348, 123)
        Me.bQuimica.Name = "bQuimica"
        Me.bQuimica.Size = New System.Drawing.Size(94, 29)
        Me.bQuimica.TabIndex = 7
        Me.bQuimica.Text = "💾 Guardar"
        Me.bQuimica.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Química:"
        '
        'tbFisica
        '
        Me.tbFisica.Location = New System.Drawing.Point(186, 83)
        Me.tbFisica.Name = "tbFisica"
        Me.tbFisica.Size = New System.Drawing.Size(125, 27)
        Me.tbFisica.TabIndex = 5
        '
        'bFisica
        '
        Me.bFisica.Location = New System.Drawing.Point(348, 81)
        Me.bFisica.Name = "bFisica"
        Me.bFisica.Size = New System.Drawing.Size(94, 29)
        Me.bFisica.TabIndex = 4
        Me.bFisica.Text = "💾 Guardar"
        Me.bFisica.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Física:"
        '
        'tbMategmaticas
        '
        Me.tbMategmaticas.Location = New System.Drawing.Point(186, 44)
        Me.tbMategmaticas.Name = "tbMategmaticas"
        Me.tbMategmaticas.Size = New System.Drawing.Size(125, 27)
        Me.tbMategmaticas.TabIndex = 2
        '
        'bMatematicas
        '
        Me.bMatematicas.Location = New System.Drawing.Point(348, 42)
        Me.bMatematicas.Name = "bMatematicas"
        Me.bMatematicas.Size = New System.Drawing.Size(94, 29)
        Me.bMatematicas.TabIndex = 1
        Me.bMatematicas.Text = "💾 Guardar"
        Me.bMatematicas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Matemáticas:"
        '
        'AplicacionPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 938)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AplicacionPrincipal"
        Me.Text = "Clase 🧑‍🎓"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionarAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarAsignaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarNotasAAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbSegundoApellido As TextBox
    Friend WithEvents bInsertar As Button
    Friend WithEvents bEditar As Button
    Friend WithEvents bBorrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cNombre As DataGridViewTextBoxColumn
    Friend WithEvents cApellido As DataGridViewTextBoxColumn
    Friend WithEvents cSegundoApellido As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bMatricular As Button
    Friend WithEvents clAsignaturas As CheckedListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbDibujo As TextBox
    Friend WithEvents bDibujo As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbBiologia As TextBox
    Friend WithEvents bBiologia As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tbLenguaje As TextBox
    Friend WithEvents bLenguaje As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tbQuimica As TextBox
    Friend WithEvents bQuimica As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tbFisica As TextBox
    Friend WithEvents bFisica As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbMategmaticas As TextBox
    Friend WithEvents bMatematicas As Button
    Friend WithEvents Label4 As Label
End Class
