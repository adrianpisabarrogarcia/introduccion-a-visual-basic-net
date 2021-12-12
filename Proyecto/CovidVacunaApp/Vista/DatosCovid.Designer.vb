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
        Me.bDescargarDatos = New System.Windows.Forms.Button()
        Me.bImportarDatos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bDescargarDatos
        '
        Me.bDescargarDatos.Location = New System.Drawing.Point(480, 23)
        Me.bDescargarDatos.Name = "bDescargarDatos"
        Me.bDescargarDatos.Size = New System.Drawing.Size(140, 40)
        Me.bDescargarDatos.TabIndex = 0
        Me.bDescargarDatos.Text = "Descargar datos"
        Me.bDescargarDatos.UseVisualStyleBackColor = True
        '
        'bImportarDatos
        '
        Me.bImportarDatos.Location = New System.Drawing.Point(638, 23)
        Me.bImportarDatos.Name = "bImportarDatos"
        Me.bImportarDatos.Size = New System.Drawing.Size(140, 40)
        Me.bImportarDatos.TabIndex = 1
        Me.bImportarDatos.Text = "Importar datos"
        Me.bImportarDatos.UseVisualStyleBackColor = True
        '
        'DatosCovid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bImportarDatos)
        Me.Controls.Add(Me.bDescargarDatos)
        Me.Name = "DatosCovid"
        Me.Text = "DatosCovid"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bDescargarDatos As Button
    Friend WithEvents bImportarDatos As Button
End Class
