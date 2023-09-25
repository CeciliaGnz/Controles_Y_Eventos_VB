<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImagen
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
        Me.cboImagen = New System.Windows.Forms.ComboBox()
        Me.pctImagen = New System.Windows.Forms.PictureBox()
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(560, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IMAGEN"
        '
        'cboImagen
        '
        Me.cboImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboImagen.FormattingEnabled = True
        Me.cboImagen.Items.AddRange(New Object() {"Perro", "Tiburon"})
        Me.cboImagen.Location = New System.Drawing.Point(48, 148)
        Me.cboImagen.Name = "cboImagen"
        Me.cboImagen.Size = New System.Drawing.Size(301, 50)
        Me.cboImagen.TabIndex = 1
        '
        'pctImagen
        '
        Me.pctImagen.Location = New System.Drawing.Point(538, 147)
        Me.pctImagen.Name = "pctImagen"
        Me.pctImagen.Size = New System.Drawing.Size(783, 429)
        Me.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctImagen.TabIndex = 2
        Me.pctImagen.TabStop = False
        '
        'frmImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 677)
        Me.Controls.Add(Me.pctImagen)
        Me.Controls.Add(Me.cboImagen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmImagen"
        Me.Text = "frmImagen"
        CType(Me.pctImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboImagen As ComboBox
    Friend WithEvents pctImagen As PictureBox
End Class
