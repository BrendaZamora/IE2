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
        Me.Id = New System.Windows.Forms.Label
        Me.Fecha = New System.Windows.Forms.Label
        Me.Asignatura = New System.Windows.Forms.Label
        Me.Docente = New System.Windows.Forms.Label
        Me.Vocal1 = New System.Windows.Forms.Label
        Me.Vocal2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Location = New System.Drawing.Point(27, 29)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(16, 13)
        Me.Id.TabIndex = 0
        Me.Id.Text = "Id"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Location = New System.Drawing.Point(27, 75)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Fecha.TabIndex = 1
        Me.Fecha.Text = "Fecha"
        '
        'Asignatura
        '
        Me.Asignatura.AutoSize = True
        Me.Asignatura.Location = New System.Drawing.Point(27, 116)
        Me.Asignatura.Name = "Asignatura"
        Me.Asignatura.Size = New System.Drawing.Size(57, 13)
        Me.Asignatura.TabIndex = 2
        Me.Asignatura.Text = "Asignatura"
        '
        'Docente
        '
        Me.Docente.AutoSize = True
        Me.Docente.Location = New System.Drawing.Point(27, 160)
        Me.Docente.Name = "Docente"
        Me.Docente.Size = New System.Drawing.Size(48, 13)
        Me.Docente.TabIndex = 3
        Me.Docente.Text = "Docente"
        '
        'Vocal1
        '
        Me.Vocal1.AutoSize = True
        Me.Vocal1.Location = New System.Drawing.Point(27, 198)
        Me.Vocal1.Name = "Vocal1"
        Me.Vocal1.Size = New System.Drawing.Size(40, 13)
        Me.Vocal1.TabIndex = 4
        Me.Vocal1.Text = "Vocal1"
        '
        'Vocal2
        '
        Me.Vocal2.AutoSize = True
        Me.Vocal2.Location = New System.Drawing.Point(27, 239)
        Me.Vocal2.Name = "Vocal2"
        Me.Vocal2.Size = New System.Drawing.Size(40, 13)
        Me.Vocal2.TabIndex = 5
        Me.Vocal2.Text = "Vocal2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(114, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(169, 20)
        Me.TextBox3.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Maria Soria ", "Pablo Mercado", "Sofia Perez", "Alberto Funes"})
        Me.ComboBox1.Location = New System.Drawing.Point(114, 160)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Maria Soria ", "Pablo Mercado", "Sofia Perez", "Alberto Funes"})
        Me.ComboBox2.Location = New System.Drawing.Point(114, 198)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox2.TabIndex = 12
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Maria Soria ", "Pablo Mercado", "Sofia Perez", "Alberto Funes"})
        Me.ComboBox3.Location = New System.Drawing.Point(114, 231)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox3.TabIndex = 13
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(87, 270)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(81, 33)
        Me.Aceptar.TabIndex = 14
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(191, 270)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(87, 33)
        Me.Cancelar.TabIndex = 15
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 305)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Vocal2)
        Me.Controls.Add(Me.Vocal1)
        Me.Controls.Add(Me.Docente)
        Me.Controls.Add(Me.Asignatura)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Id)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Id As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.Label
    Friend WithEvents Asignatura As System.Windows.Forms.Label
    Friend WithEvents Docente As System.Windows.Forms.Label
    Friend WithEvents Vocal1 As System.Windows.Forms.Label
    Friend WithEvents Vocal2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button

End Class
