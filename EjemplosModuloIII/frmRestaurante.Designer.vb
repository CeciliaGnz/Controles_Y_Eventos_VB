<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurante
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboArroces = New System.Windows.Forms.ComboBox()
        Me.cboMenestras = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCarnes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(499, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESTAURANTE EGPH"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboCarnes)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboMenestras)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboArroces)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(55, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 564)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ARROCES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboArroces
        '
        Me.cboArroces.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArroces.FormattingEnabled = True
        Me.cboArroces.Items.AddRange(New Object() {"Arroz Blanco: 0.90", "Arroz con Guandu:1.75", "Arroz con Vegetales:1.50", "Arroz con Curry:1.80"})
        Me.cboArroces.Location = New System.Drawing.Point(33, 88)
        Me.cboArroces.Name = "cboArroces"
        Me.cboArroces.Size = New System.Drawing.Size(409, 46)
        Me.cboArroces.TabIndex = 1
        '
        'cboMenestras
        '
        Me.cboMenestras.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMenestras.FormattingEnabled = True
        Me.cboMenestras.Location = New System.Drawing.Point(33, 247)
        Me.cboMenestras.Name = "cboMenestras"
        Me.cboMenestras.Size = New System.Drawing.Size(409, 46)
        Me.cboMenestras.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 42)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MENESTRAS"
        '
        'cboCarnes
        '
        Me.cboCarnes.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarnes.FormattingEnabled = True
        Me.cboCarnes.Location = New System.Drawing.Point(33, 418)
        Me.cboCarnes.Name = "cboCarnes"
        Me.cboCarnes.Size = New System.Drawing.Size(409, 46)
        Me.cboCarnes.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 42)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CARNES"
        '
        'frmRestaurante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1527, 778)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRestaurante"
        Me.Text = "frmRestaurante"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboCarnes As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboMenestras As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboArroces As ComboBox
    Friend WithEvents Label2 As Label
End Class
