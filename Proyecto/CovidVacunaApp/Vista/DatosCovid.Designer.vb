<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosCovid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosCovid))
        Me.bDescargarDatos = New System.Windows.Forms.Button()
        Me.bImportarDatos = New System.Windows.Forms.Button()
        Me.dataGridCovid = New System.Windows.Forms.DataGridView()
        Me.cComunidades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.bCerrarSesion = New System.Windows.Forms.Button()
        Me.cComunidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDosisAdministradas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDosisEntregadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDosisEntregadasModerna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDosisEntregadasPfizer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDosisEntregadasAstrazeneca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDosisPautaCompletada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPorcentajeEntregadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPorcentajePoblacionAdministradas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPorcentajePoblacionCompletas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridCovid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bDescargarDatos
        '
        Me.bDescargarDatos.Location = New System.Drawing.Point(1112, 23)
        Me.bDescargarDatos.Name = "bDescargarDatos"
        Me.bDescargarDatos.Size = New System.Drawing.Size(166, 50)
        Me.bDescargarDatos.TabIndex = 0
        Me.bDescargarDatos.Text = "🌍 Descargar datos"
        Me.bDescargarDatos.UseVisualStyleBackColor = True
        '
        'bImportarDatos
        '
        Me.bImportarDatos.Location = New System.Drawing.Point(1304, 23)
        Me.bImportarDatos.Name = "bImportarDatos"
        Me.bImportarDatos.Size = New System.Drawing.Size(140, 50)
        Me.bImportarDatos.TabIndex = 1
        Me.bImportarDatos.Text = "📲 Importar datos"
        Me.bImportarDatos.UseVisualStyleBackColor = True
        '
        'dataGridCovid
        '
        Me.dataGridCovid.AllowUserToOrderColumns = True
        Me.dataGridCovid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridCovid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cComunidad, Me.cFecha, Me.cDosisAdministradas, Me.cDosisEntregadas, Me.cDosisEntregadasModerna, Me.cDosisEntregadasPfizer, Me.cDosisEntregadasAstrazeneca, Me.cDosisPautaCompletada, Me.cPorcentajeEntregadas, Me.cPorcentajePoblacionAdministradas, Me.cPorcentajePoblacionCompletas, Me.id})
        Me.dataGridCovid.Location = New System.Drawing.Point(21, 95)
        Me.dataGridCovid.Name = "dataGridCovid"
        Me.dataGridCovid.RowHeadersWidth = 51
        Me.dataGridCovid.RowTemplate.Height = 24
        Me.dataGridCovid.Size = New System.Drawing.Size(1439, 592)
        Me.dataGridCovid.TabIndex = 2
        '
        'cComunidades
        '
        Me.cComunidades.FormattingEnabled = True
        Me.cComunidades.Items.AddRange(New Object() {"Todas", "Andalucía", "Aragón", "Asturias", "Baleares", "Canarias", "Cantabria", "Castilla y Leon", "Castilla La Mancha", "Cataluña", "C. Valenciana", "Extremadura", "Galicia", "La Rioja", "Madrid", "Murcia", "Navarra", "País Vasco", "Ceuta", "Melilla", "Totales", "Fuerzas Armadas"})
        Me.cComunidades.Location = New System.Drawing.Point(148, 39)
        Me.cComunidades.Name = "cComunidades"
        Me.cComunidades.Size = New System.Drawing.Size(249, 24)
        Me.cComunidades.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Comunidad: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha: "
        '
        'bBuscar
        '
        Me.bBuscar.ForeColor = System.Drawing.Color.DarkGreen
        Me.bBuscar.Location = New System.Drawing.Point(766, 33)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(140, 40)
        Me.bBuscar.TabIndex = 6
        Me.bBuscar.Text = "🔎 Buscar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(482, 40)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(260, 22)
        Me.fecha.TabIndex = 7
        '
        'bCerrarSesion
        '
        Me.bCerrarSesion.Location = New System.Drawing.Point(1320, 719)
        Me.bCerrarSesion.Name = "bCerrarSesion"
        Me.bCerrarSesion.Size = New System.Drawing.Size(140, 40)
        Me.bCerrarSesion.TabIndex = 8
        Me.bCerrarSesion.Text = "Cerrar Sesión"
        Me.bCerrarSesion.UseVisualStyleBackColor = True
        '
        'cComunidad
        '
        Me.cComunidad.HeaderText = "Comunidad"
        Me.cComunidad.MinimumWidth = 6
        Me.cComunidad.Name = "cComunidad"
        Me.cComunidad.ReadOnly = True
        Me.cComunidad.Width = 125
        '
        'cFecha
        '
        Me.cFecha.HeaderText = "Fecha"
        Me.cFecha.MinimumWidth = 6
        Me.cFecha.Name = "cFecha"
        Me.cFecha.ReadOnly = True
        Me.cFecha.Width = 125
        '
        'cDosisAdministradas
        '
        Me.cDosisAdministradas.HeaderText = "Dosis Administradas"
        Me.cDosisAdministradas.MinimumWidth = 6
        Me.cDosisAdministradas.Name = "cDosisAdministradas"
        Me.cDosisAdministradas.ReadOnly = True
        Me.cDosisAdministradas.Width = 125
        '
        'cDosisEntregadas
        '
        Me.cDosisEntregadas.HeaderText = "Dosis Entregadas"
        Me.cDosisEntregadas.MinimumWidth = 6
        Me.cDosisEntregadas.Name = "cDosisEntregadas"
        Me.cDosisEntregadas.ReadOnly = True
        Me.cDosisEntregadas.Width = 125
        '
        'cDosisEntregadasModerna
        '
        Me.cDosisEntregadasModerna.HeaderText = "Dosis Entregadas Moderna"
        Me.cDosisEntregadasModerna.MinimumWidth = 6
        Me.cDosisEntregadasModerna.Name = "cDosisEntregadasModerna"
        Me.cDosisEntregadasModerna.ReadOnly = True
        Me.cDosisEntregadasModerna.Width = 125
        '
        'cDosisEntregadasPfizer
        '
        Me.cDosisEntregadasPfizer.HeaderText = "Dosis Entregadas Pfizer"
        Me.cDosisEntregadasPfizer.MinimumWidth = 6
        Me.cDosisEntregadasPfizer.Name = "cDosisEntregadasPfizer"
        Me.cDosisEntregadasPfizer.ReadOnly = True
        Me.cDosisEntregadasPfizer.Width = 125
        '
        'cDosisEntregadasAstrazeneca
        '
        Me.cDosisEntregadasAstrazeneca.HeaderText = "Dosis Entregadas Astrazeneca"
        Me.cDosisEntregadasAstrazeneca.MinimumWidth = 6
        Me.cDosisEntregadasAstrazeneca.Name = "cDosisEntregadasAstrazeneca"
        Me.cDosisEntregadasAstrazeneca.ReadOnly = True
        Me.cDosisEntregadasAstrazeneca.Width = 125
        '
        'cDosisPautaCompletada
        '
        Me.cDosisPautaCompletada.HeaderText = "Dosis Pauta Completada"
        Me.cDosisPautaCompletada.MinimumWidth = 6
        Me.cDosisPautaCompletada.Name = "cDosisPautaCompletada"
        Me.cDosisPautaCompletada.ReadOnly = True
        Me.cDosisPautaCompletada.Width = 125
        '
        'cPorcentajeEntregadas
        '
        Me.cPorcentajeEntregadas.HeaderText = "Porcentaje Entregadas"
        Me.cPorcentajeEntregadas.MinimumWidth = 6
        Me.cPorcentajeEntregadas.Name = "cPorcentajeEntregadas"
        Me.cPorcentajeEntregadas.ReadOnly = True
        Me.cPorcentajeEntregadas.Width = 125
        '
        'cPorcentajePoblacionAdministradas
        '
        Me.cPorcentajePoblacionAdministradas.HeaderText = "Porcentaje Poblacion Administradas"
        Me.cPorcentajePoblacionAdministradas.MinimumWidth = 6
        Me.cPorcentajePoblacionAdministradas.Name = "cPorcentajePoblacionAdministradas"
        Me.cPorcentajePoblacionAdministradas.ReadOnly = True
        Me.cPorcentajePoblacionAdministradas.Width = 125
        '
        'cPorcentajePoblacionCompletas
        '
        Me.cPorcentajePoblacionCompletas.HeaderText = "Porcentaje Poblacion Completas "
        Me.cPorcentajePoblacionCompletas.MinimumWidth = 6
        Me.cPorcentajePoblacionCompletas.Name = "cPorcentajePoblacionCompletas"
        Me.cPorcentajePoblacionCompletas.ReadOnly = True
        Me.cPorcentajePoblacionCompletas.Width = 125
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 125
        '
        'DatosCovid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 771)
        Me.Controls.Add(Me.bDescargarDatos)
        Me.Controls.Add(Me.bCerrarSesion)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cComunidades)
        Me.Controls.Add(Me.dataGridCovid)
        Me.Controls.Add(Me.bImportarDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatosCovid"
        Me.Text = "Datos Covid"
        CType(Me.dataGridCovid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bDescargarDatos As Button
    Friend WithEvents bImportarDatos As Button
    Friend WithEvents dataGridCovid As DataGridView
    Friend WithEvents cComunidades As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bBuscar As Button
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents bCerrarSesion As Button
    Friend WithEvents cComunidad As DataGridViewTextBoxColumn
    Friend WithEvents cFecha As DataGridViewTextBoxColumn
    Friend WithEvents cDosisAdministradas As DataGridViewTextBoxColumn
    Friend WithEvents cDosisEntregadas As DataGridViewTextBoxColumn
    Friend WithEvents cDosisEntregadasModerna As DataGridViewTextBoxColumn
    Friend WithEvents cDosisEntregadasPfizer As DataGridViewTextBoxColumn
    Friend WithEvents cDosisEntregadasAstrazeneca As DataGridViewTextBoxColumn
    Friend WithEvents cDosisPautaCompletada As DataGridViewTextBoxColumn
    Friend WithEvents cPorcentajeEntregadas As DataGridViewTextBoxColumn
    Friend WithEvents cPorcentajePoblacionAdministradas As DataGridViewTextBoxColumn
    Friend WithEvents cPorcentajePoblacionCompletas As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
End Class
