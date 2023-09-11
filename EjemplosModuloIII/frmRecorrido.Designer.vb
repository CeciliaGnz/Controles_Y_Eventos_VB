<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecorrido
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
        Me.btnRecorrido = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.dgvRecorrido = New System.Windows.Forms.DataGridView()
        Me.dgvNumeros = New System.Windows.Forms.DataGridView()
        Me.nudTope = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvRecorrido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTope, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRecorrido
        '
        Me.btnRecorrido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecorrido.Location = New System.Drawing.Point(461, 99)
        Me.btnRecorrido.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecorrido.Name = "btnRecorrido"
        Me.btnRecorrido.Size = New System.Drawing.Size(158, 36)
        Me.btnRecorrido.TabIndex = 11
        Me.btnRecorrido.Text = "Recorrido"
        Me.btnRecorrido.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(182, 99)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(158, 36)
        Me.btnGenerar.TabIndex = 10
        Me.btnGenerar.Text = "Generar "
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'dgvRecorrido
        '
        Me.dgvRecorrido.AllowUserToDeleteRows = False
        Me.dgvRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecorrido.Location = New System.Drawing.Point(461, 157)
        Me.dgvRecorrido.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRecorrido.Name = "dgvRecorrido"
        Me.dgvRecorrido.ReadOnly = True
        Me.dgvRecorrido.RowHeadersWidth = 51
        Me.dgvRecorrido.RowTemplate.Height = 24
        Me.dgvRecorrido.Size = New System.Drawing.Size(338, 260)
        Me.dgvRecorrido.TabIndex = 9
        '
        'dgvNumeros
        '
        Me.dgvNumeros.AllowUserToDeleteRows = False
        Me.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNumeros.Location = New System.Drawing.Point(48, 157)
        Me.dgvNumeros.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvNumeros.Name = "dgvNumeros"
        Me.dgvNumeros.ReadOnly = True
        Me.dgvNumeros.RowHeadersWidth = 51
        Me.dgvNumeros.RowTemplate.Height = 24
        Me.dgvNumeros.Size = New System.Drawing.Size(338, 260)
        Me.dgvNumeros.TabIndex = 8
        '
        'nudTope
        '
        Me.nudTope.Location = New System.Drawing.Point(356, 69)
        Me.nudTope.Margin = New System.Windows.Forms.Padding(2)
        Me.nudTope.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudTope.Name = "nudTope"
        Me.nudTope.Size = New System.Drawing.Size(90, 20)
        Me.nudTope.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Recorrido de Una Matriz"
        '
        'frmRecorrido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 536)
        Me.Controls.Add(Me.btnRecorrido)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dgvRecorrido)
        Me.Controls.Add(Me.dgvNumeros)
        Me.Controls.Add(Me.nudTope)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRecorrido"
        Me.Text = "frmRecorrido"
        CType(Me.dgvRecorrido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTope, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRecorrido As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents dgvRecorrido As DataGridView
    Friend WithEvents dgvNumeros As DataGridView
    Friend WithEvents nudTope As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
