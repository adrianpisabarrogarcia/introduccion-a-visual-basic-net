<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bCalcular = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.tbTotalFactura = New System.Windows.Forms.TextBox()
        Me.numTotalHoras = New System.Windows.Forms.NumericUpDown()
        Me.numTrabajadores = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbAluminio = New System.Windows.Forms.CheckBox()
        Me.cbHierro = New System.Windows.Forms.CheckBox()
        Me.cbCobre = New System.Windows.Forms.CheckBox()
        Me.cbLaton = New System.Windows.Forms.CheckBox()
        Me.rbContado = New System.Windows.Forms.RadioButton()
        Me.rbTresMeses = New System.Windows.Forms.RadioButton()
        Me.numAluminio = New System.Windows.Forms.NumericUpDown()
        Me.numHierro = New System.Windows.Forms.NumericUpDown()
        Me.numCobre = New System.Windows.Forms.NumericUpDown()
        Me.numLaton = New System.Windows.Forms.NumericUpDown()
        CType(Me.numTotalHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAluminio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHierro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCobre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLaton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total de horas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Materiales:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Location = New System.Drawing.Point(0, 519)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(395, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Modo de pago:"
        '
        'bCalcular
        '
        Me.bCalcular.Location = New System.Drawing.Point(128, 431)
        Me.bCalcular.Name = "bCalcular"
        Me.bCalcular.Size = New System.Drawing.Size(115, 71)
        Me.bCalcular.TabIndex = 5
        Me.bCalcular.Text = "Calcular"
        Me.bCalcular.UseVisualStyleBackColor = True
        '
        'bLimpiar
        '
        Me.bLimpiar.Location = New System.Drawing.Point(261, 431)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bLimpiar.Size = New System.Drawing.Size(115, 71)
        Me.bLimpiar.TabIndex = 6
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'tbTotalFactura
        '
        Me.tbTotalFactura.Enabled = False
        Me.tbTotalFactura.Location = New System.Drawing.Point(157, 58)
        Me.tbTotalFactura.Name = "tbTotalFactura"
        Me.tbTotalFactura.Size = New System.Drawing.Size(161, 20)
        Me.tbTotalFactura.TabIndex = 7
        '
        'numTotalHoras
        '
        Me.numTotalHoras.Location = New System.Drawing.Point(157, 101)
        Me.numTotalHoras.Name = "numTotalHoras"
        Me.numTotalHoras.Size = New System.Drawing.Size(120, 20)
        Me.numTotalHoras.TabIndex = 8
        '
        'numTrabajadores
        '
        Me.numTrabajadores.Location = New System.Drawing.Point(157, 132)
        Me.numTrabajadores.Name = "numTrabajadores"
        Me.numTrabajadores.Size = New System.Drawing.Size(120, 20)
        Me.numTrabajadores.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Num trabajadores:"
        '
        'cbAluminio
        '
        Me.cbAluminio.AutoSize = True
        Me.cbAluminio.Location = New System.Drawing.Point(88, 221)
        Me.cbAluminio.Name = "cbAluminio"
        Me.cbAluminio.Size = New System.Drawing.Size(65, 17)
        Me.cbAluminio.TabIndex = 11
        Me.cbAluminio.Text = "Aluminio"
        Me.cbAluminio.UseVisualStyleBackColor = True
        '
        'cbHierro
        '
        Me.cbHierro.AutoSize = True
        Me.cbHierro.Location = New System.Drawing.Point(88, 253)
        Me.cbHierro.Name = "cbHierro"
        Me.cbHierro.Size = New System.Drawing.Size(54, 17)
        Me.cbHierro.TabIndex = 12
        Me.cbHierro.Text = "Hierro"
        Me.cbHierro.UseVisualStyleBackColor = True
        '
        'cbCobre
        '
        Me.cbCobre.AutoSize = True
        Me.cbCobre.Location = New System.Drawing.Point(88, 285)
        Me.cbCobre.Name = "cbCobre"
        Me.cbCobre.Size = New System.Drawing.Size(54, 17)
        Me.cbCobre.TabIndex = 13
        Me.cbCobre.Text = "Cobre"
        Me.cbCobre.UseVisualStyleBackColor = True
        '
        'cbLaton
        '
        Me.cbLaton.AutoSize = True
        Me.cbLaton.Location = New System.Drawing.Point(86, 318)
        Me.cbLaton.Name = "cbLaton"
        Me.cbLaton.Size = New System.Drawing.Size(53, 17)
        Me.cbLaton.TabIndex = 14
        Me.cbLaton.Text = "Latón"
        Me.cbLaton.UseVisualStyleBackColor = True
        '
        'rbContado
        '
        Me.rbContado.AutoSize = True
        Me.rbContado.Location = New System.Drawing.Point(428, 238)
        Me.rbContado.Name = "rbContado"
        Me.rbContado.Size = New System.Drawing.Size(76, 17)
        Me.rbContado.TabIndex = 15
        Me.rbContado.TabStop = True
        Me.rbContado.Text = "Al contado"
        Me.rbContado.UseVisualStyleBackColor = True
        '
        'rbTresMeses
        '
        Me.rbTresMeses.AutoSize = True
        Me.rbTresMeses.Location = New System.Drawing.Point(428, 272)
        Me.rbTresMeses.Name = "rbTresMeses"
        Me.rbTresMeses.Size = New System.Drawing.Size(85, 17)
        Me.rbTresMeses.TabIndex = 16
        Me.rbTresMeses.TabStop = True
        Me.rbTresMeses.Text = "A tres meses"
        Me.rbTresMeses.UseVisualStyleBackColor = True
        '
        'numAluminio
        '
        Me.numAluminio.Cursor = System.Windows.Forms.Cursors.Default
        Me.numAluminio.DecimalPlaces = 2
        Me.numAluminio.Enabled = False
        Me.numAluminio.Location = New System.Drawing.Point(159, 218)
        Me.numAluminio.Minimum = New Decimal(New Integer() {325, 0, 0, 131072})
        Me.numAluminio.Name = "numAluminio"
        Me.numAluminio.Size = New System.Drawing.Size(120, 20)
        Me.numAluminio.TabIndex = 17
        Me.numAluminio.Value = New Decimal(New Integer() {325, 0, 0, 131072})
        Me.numAluminio.Visible = False
        '
        'numHierro
        '
        Me.numHierro.Cursor = System.Windows.Forms.Cursors.Default
        Me.numHierro.DecimalPlaces = 2
        Me.numHierro.Enabled = False
        Me.numHierro.Location = New System.Drawing.Point(157, 250)
        Me.numHierro.Minimum = New Decimal(New Integer() {231, 0, 0, 131072})
        Me.numHierro.Name = "numHierro"
        Me.numHierro.Size = New System.Drawing.Size(120, 20)
        Me.numHierro.TabIndex = 18
        Me.numHierro.Value = New Decimal(New Integer() {231, 0, 0, 131072})
        Me.numHierro.Visible = False
        '
        'numCobre
        '
        Me.numCobre.Cursor = System.Windows.Forms.Cursors.Default
        Me.numCobre.DecimalPlaces = 2
        Me.numCobre.Enabled = False
        Me.numCobre.Location = New System.Drawing.Point(157, 284)
        Me.numCobre.Minimum = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.numCobre.Name = "numCobre"
        Me.numCobre.Size = New System.Drawing.Size(120, 20)
        Me.numCobre.TabIndex = 19
        Me.numCobre.Value = New Decimal(New Integer() {1025, 0, 0, 131072})
        Me.numCobre.Visible = False
        '
        'numLaton
        '
        Me.numLaton.Cursor = System.Windows.Forms.Cursors.Default
        Me.numLaton.DecimalPlaces = 2
        Me.numLaton.Enabled = False
        Me.numLaton.Location = New System.Drawing.Point(157, 318)
        Me.numLaton.Minimum = New Decimal(New Integer() {325, 0, 0, 131072})
        Me.numLaton.Name = "numLaton"
        Me.numLaton.Size = New System.Drawing.Size(120, 20)
        Me.numLaton.TabIndex = 20
        Me.numLaton.ThousandsSeparator = True
        Me.numLaton.Value = New Decimal(New Integer() {811, 0, 0, 131072})
        Me.numLaton.Visible = False
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 532)
        Me.Controls.Add(Me.numLaton)
        Me.Controls.Add(Me.numCobre)
        Me.Controls.Add(Me.numHierro)
        Me.Controls.Add(Me.numAluminio)
        Me.Controls.Add(Me.rbTresMeses)
        Me.Controls.Add(Me.rbContado)
        Me.Controls.Add(Me.cbLaton)
        Me.Controls.Add(Me.cbCobre)
        Me.Controls.Add(Me.cbHierro)
        Me.Controls.Add(Me.cbAluminio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numTrabajadores)
        Me.Controls.Add(Me.numTotalHoras)
        Me.Controls.Add(Me.tbTotalFactura)
        Me.Controls.Add(Me.bLimpiar)
        Me.Controls.Add(Me.bCalcular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formulario"
        Me.Text = "Formulario"
        CType(Me.numTotalHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAluminio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHierro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCobre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLaton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bCalcular As Button
    Friend WithEvents bLimpiar As Button
    Friend WithEvents tbTotalFactura As TextBox
    Friend WithEvents numTotalHoras As NumericUpDown
    Friend WithEvents numTrabajadores As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents cbAluminio As CheckBox
    Friend WithEvents cbHierro As CheckBox
    Friend WithEvents cbCobre As CheckBox
    Friend WithEvents cbLaton As CheckBox
    Friend WithEvents rbContado As RadioButton
    Friend WithEvents rbTresMeses As RadioButton
    Friend WithEvents numAluminio As NumericUpDown
    Friend WithEvents numHierro As NumericUpDown
    Friend WithEvents numCobre As NumericUpDown
    Friend WithEvents numLaton As NumericUpDown
End Class
