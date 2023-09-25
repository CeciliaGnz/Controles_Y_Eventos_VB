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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudTope = New System.Windows.Forms.NumericUpDown()
        Me.dgvNumeros = New System.Windows.Forms.DataGridView()
        Me.dgvRecorrido = New System.Windows.Forms.DataGridView()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnRecorrer = New System.Windows.Forms.Button()
        CType(Me.nudTope, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecorrido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(651, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECORRIDO DE UNA MATRIZ"
        '
        'nudTope
        '
        Me.nudTope.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTope.Location = New System.Drawing.Point(651, 126)
        Me.nudTope.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudTope.Name = "nudTope"
        Me.nudTope.Size = New System.Drawing.Size(120, 41)
        Me.nudTope.TabIndex = 1
        '
        'dgvNumeros
        '
        Me.dgvNumeros.AllowUserToDeleteRows = False
        Me.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNumeros.Location = New System.Drawing.Point(27, 266)
        Me.dgvNumeros.Name = "dgvNumeros"
        Me.dgvNumeros.ReadOnly = True
        Me.dgvNumeros.RowHeadersWidth = 51
        Me.dgvNumeros.RowTemplate.Height = 24
        Me.dgvNumeros.Size = New System.Drawing.Size(654, 340)
        Me.dgvNumeros.TabIndex = 2
        '
        'dgvRecorrido
        '
        Me.dgvRecorrido.AllowUserToDeleteRows = False
        Me.dgvRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecorrido.Location = New System.Drawing.Point(741, 266)
        Me.dgvRecorrido.Name = "dgvRecorrido"
        Me.dgvRecorrido.ReadOnly = True
        Me.dgvRecorrido.RowHeadersWidth = 51
        Me.dgvRecorrido.RowTemplate.Height = 24
        Me.dgvRecorrido.Size = New System.Drawing.Size(654, 340)
        Me.dgvRecorrido.TabIndex = 3
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(454, 194)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(213, 51)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnRecorrer
        '
        Me.btnRecorrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecorrer.Location = New System.Drawing.Point(758, 194)
        Me.btnRecorrer.Name = "btnRecorrer"
        Me.btnRecorrer.Size = New System.Drawing.Size(213, 51)
        Me.btnRecorrer.TabIndex = 5
        Me.btnRecorrer.Text = "Recorrer"
        Me.btnRecorrer.UseVisualStyleBackColor = True
        '
        'frmRecorrido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1430, 687)
        Me.Controls.Add(Me.btnRecorrer)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dgvRecorrido)
        Me.Controls.Add(Me.dgvNumeros)
        Me.Controls.Add(Me.nudTope)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRecorrido"
        Me.Text = "frmRecorrido"
        CType(Me.nudTope, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecorrido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nudTope As NumericUpDown
    Friend WithEvents dgvNumeros As DataGridView
    Friend WithEvents dgvRecorrido As DataGridView
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnRecorrer As Button
End Class
