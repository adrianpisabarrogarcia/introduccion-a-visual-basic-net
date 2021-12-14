<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdicionDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EdicionDatos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.nDosisAdministradas = New System.Windows.Forms.NumericUpDown()
        Me.nDosisEntregadas = New System.Windows.Forms.NumericUpDown()
        Me.nDosisEntregadasModerna = New System.Windows.Forms.NumericUpDown()
        Me.nDosisEntregadasPfizer = New System.Windows.Forms.NumericUpDown()
        Me.nDosisEntregadasAstrazeneca = New System.Windows.Forms.NumericUpDown()
        Me.nDosisPautaCompleta = New System.Windows.Forms.NumericUpDown()
        Me.nPorcentajePoblacionAdministradas = New System.Windows.Forms.NumericUpDown()
        Me.nPorcentajePoblacionCompletas = New System.Windows.Forms.NumericUpDown()
        Me.nPorcentajeEntregadas = New System.Windows.Forms.NumericUpDown()
        Me.bEliminarRegistro = New System.Windows.Forms.Button()
        CType(Me.nDosisAdministradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nDosisEntregadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nDosisEntregadasModerna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nDosisEntregadasPfizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nDosisEntregadasAstrazeneca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nDosisPautaCompleta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nPorcentajePoblacionAdministradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nPorcentajePoblacionCompletas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nPorcentajeEntregadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha: "
        '
        'bSave
        '
        Me.bSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSave.ForeColor = System.Drawing.Color.ForestGreen
        Me.bSave.Location = New System.Drawing.Point(578, 315)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(216, 69)
        Me.bSave.TabIndex = 1
        Me.bSave.Text = "💾 Guardar"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dosis Administradas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dosis Entregadas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dosis Entregadas Moderna: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dosis Entregadas Pfizer: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Dosis Entregadas Astrazeneca: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Dosis Pauta Completada: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(575, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Porcentaje Entregadas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(85, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 36)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Comunidad: "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(285, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(381, 38)
        Me.TextBox1.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(575, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(289, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Porcentaje Población Administradas: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(575, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(259, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Porcentaje Población Completas:"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(216, 103)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(287, 22)
        Me.fecha.TabIndex = 13
        '
        'nDosisAdministradas
        '
        Me.nDosisAdministradas.Location = New System.Drawing.Point(300, 141)
        Me.nDosisAdministradas.Name = "nDosisAdministradas"
        Me.nDosisAdministradas.Size = New System.Drawing.Size(203, 22)
        Me.nDosisAdministradas.TabIndex = 14
        '
        'nDosisEntregadas
        '
        Me.nDosisEntregadas.Location = New System.Drawing.Point(300, 187)
        Me.nDosisEntregadas.Name = "nDosisEntregadas"
        Me.nDosisEntregadas.Size = New System.Drawing.Size(203, 22)
        Me.nDosisEntregadas.TabIndex = 15
        '
        'nDosisEntregadasModerna
        '
        Me.nDosisEntregadasModerna.Location = New System.Drawing.Point(300, 232)
        Me.nDosisEntregadasModerna.Name = "nDosisEntregadasModerna"
        Me.nDosisEntregadasModerna.Size = New System.Drawing.Size(203, 22)
        Me.nDosisEntregadasModerna.TabIndex = 16
        '
        'nDosisEntregadasPfizer
        '
        Me.nDosisEntregadasPfizer.Location = New System.Drawing.Point(300, 273)
        Me.nDosisEntregadasPfizer.Name = "nDosisEntregadasPfizer"
        Me.nDosisEntregadasPfizer.Size = New System.Drawing.Size(203, 22)
        Me.nDosisEntregadasPfizer.TabIndex = 17
        '
        'nDosisEntregadasAstrazeneca
        '
        Me.nDosisEntregadasAstrazeneca.Location = New System.Drawing.Point(300, 318)
        Me.nDosisEntregadasAstrazeneca.Name = "nDosisEntregadasAstrazeneca"
        Me.nDosisEntregadasAstrazeneca.Size = New System.Drawing.Size(203, 22)
        Me.nDosisEntregadasAstrazeneca.TabIndex = 18
        '
        'nDosisPautaCompleta
        '
        Me.nDosisPautaCompleta.Location = New System.Drawing.Point(300, 362)
        Me.nDosisPautaCompleta.Name = "nDosisPautaCompleta"
        Me.nDosisPautaCompleta.Size = New System.Drawing.Size(203, 22)
        Me.nDosisPautaCompleta.TabIndex = 19
        '
        'nPorcentajePoblacionAdministradas
        '
        Me.nPorcentajePoblacionAdministradas.Location = New System.Drawing.Point(828, 141)
        Me.nPorcentajePoblacionAdministradas.Name = "nPorcentajePoblacionAdministradas"
        Me.nPorcentajePoblacionAdministradas.Size = New System.Drawing.Size(203, 22)
        Me.nPorcentajePoblacionAdministradas.TabIndex = 20
        '
        'nPorcentajePoblacionCompletas
        '
        Me.nPorcentajePoblacionCompletas.Location = New System.Drawing.Point(828, 185)
        Me.nPorcentajePoblacionCompletas.Name = "nPorcentajePoblacionCompletas"
        Me.nPorcentajePoblacionCompletas.Size = New System.Drawing.Size(203, 22)
        Me.nPorcentajePoblacionCompletas.TabIndex = 21
        '
        'nPorcentajeEntregadas
        '
        Me.nPorcentajeEntregadas.Location = New System.Drawing.Point(828, 97)
        Me.nPorcentajeEntregadas.Name = "nPorcentajeEntregadas"
        Me.nPorcentajeEntregadas.Size = New System.Drawing.Size(203, 22)
        Me.nPorcentajeEntregadas.TabIndex = 22
        '
        'bEliminarRegistro
        '
        Me.bEliminarRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminarRegistro.ForeColor = System.Drawing.Color.Red
        Me.bEliminarRegistro.Location = New System.Drawing.Point(800, 315)
        Me.bEliminarRegistro.Name = "bEliminarRegistro"
        Me.bEliminarRegistro.Size = New System.Drawing.Size(216, 69)
        Me.bEliminarRegistro.TabIndex = 23
        Me.bEliminarRegistro.Text = "🗑 Eliminar registro"
        Me.bEliminarRegistro.UseVisualStyleBackColor = True
        '
        'EdicionDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 424)
        Me.Controls.Add(Me.bEliminarRegistro)
        Me.Controls.Add(Me.nPorcentajeEntregadas)
        Me.Controls.Add(Me.nPorcentajePoblacionCompletas)
        Me.Controls.Add(Me.nPorcentajePoblacionAdministradas)
        Me.Controls.Add(Me.nDosisPautaCompleta)
        Me.Controls.Add(Me.nDosisEntregadasAstrazeneca)
        Me.Controls.Add(Me.nDosisEntregadasPfizer)
        Me.Controls.Add(Me.nDosisEntregadasModerna)
        Me.Controls.Add(Me.nDosisEntregadas)
        Me.Controls.Add(Me.nDosisAdministradas)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EdicionDatos"
        Me.Text = "EdicionDatos"
        CType(Me.nDosisAdministradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nDosisEntregadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nDosisEntregadasModerna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nDosisEntregadasPfizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nDosisEntregadasAstrazeneca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nDosisPautaCompleta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nPorcentajePoblacionAdministradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nPorcentajePoblacionCompletas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nPorcentajeEntregadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents nDosisAdministradas As NumericUpDown
    Friend WithEvents nDosisEntregadas As NumericUpDown
    Friend WithEvents nDosisEntregadasModerna As NumericUpDown
    Friend WithEvents nDosisEntregadasPfizer As NumericUpDown
    Friend WithEvents nDosisEntregadasAstrazeneca As NumericUpDown
    Friend WithEvents nDosisPautaCompleta As NumericUpDown
    Friend WithEvents nPorcentajePoblacionAdministradas As NumericUpDown
    Friend WithEvents nPorcentajePoblacionCompletas As NumericUpDown
    Friend WithEvents nPorcentajeEntregadas As NumericUpDown
    Friend WithEvents bEliminarRegistro As Button
End Class
