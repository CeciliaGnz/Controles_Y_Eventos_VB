﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperaciones
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
        Me.txtValorA = New System.Windows.Forms.TextBox()
        Me.txtValorB = New System.Windows.Forms.TextBox()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbSuma = New System.Windows.Forms.RadioButton()
        Me.rdbResta = New System.Windows.Forms.RadioButton()
        Me.rdbMulti = New System.Windows.Forms.RadioButton()
        Me.rdbDivi = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(963, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese los valores y seleccione la Operación"
        '
        'txtValorA
        '
        Me.txtValorA.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorA.Location = New System.Drawing.Point(75, 146)
        Me.txtValorA.Name = "txtValorA"
        Me.txtValorA.Size = New System.Drawing.Size(172, 61)
        Me.txtValorA.TabIndex = 1
        '
        'txtValorB
        '
        Me.txtValorB.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorB.Location = New System.Drawing.Point(526, 146)
        Me.txtValorB.Name = "txtValorB"
        Me.txtValorB.Size = New System.Drawing.Size(172, 61)
        Me.txtValorB.TabIndex = 2
        '
        'txtRes
        '
        Me.txtRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRes.Location = New System.Drawing.Point(1041, 146)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ReadOnly = True
        Me.txtRes.Size = New System.Drawing.Size(172, 61)
        Me.txtRes.TabIndex = 3
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacion.Location = New System.Drawing.Point(344, 152)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(47, 51)
        Me.lblOperacion.TabIndex = 4
        Me.lblOperacion.Text = "?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(833, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 51)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "="
        '
        'rdbSuma
        '
        Me.rdbSuma.AutoSize = True
        Me.rdbSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSuma.Location = New System.Drawing.Point(68, 307)
        Me.rdbSuma.Name = "rdbSuma"
        Me.rdbSuma.Size = New System.Drawing.Size(140, 46)
        Me.rdbSuma.TabIndex = 6
        Me.rdbSuma.Text = "Suma"
        Me.rdbSuma.UseVisualStyleBackColor = True
        '
        'rdbResta
        '
        Me.rdbResta.AutoSize = True
        Me.rdbResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbResta.Location = New System.Drawing.Point(75, 394)
        Me.rdbResta.Name = "rdbResta"
        Me.rdbResta.Size = New System.Drawing.Size(142, 46)
        Me.rdbResta.TabIndex = 7
        Me.rdbResta.Text = "Resta"
        Me.rdbResta.UseVisualStyleBackColor = True
        '
        'rdbMulti
        '
        Me.rdbMulti.AutoSize = True
        Me.rdbMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMulti.Location = New System.Drawing.Point(68, 470)
        Me.rdbMulti.Name = "rdbMulti"
        Me.rdbMulti.Size = New System.Drawing.Size(277, 46)
        Me.rdbMulti.TabIndex = 8
        Me.rdbMulti.Text = "Multiplicación"
        Me.rdbMulti.UseVisualStyleBackColor = True
        '
        'rdbDivi
        '
        Me.rdbDivi.AutoSize = True
        Me.rdbDivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDivi.Location = New System.Drawing.Point(68, 547)
        Me.rdbDivi.Name = "rdbDivi"
        Me.rdbDivi.Size = New System.Drawing.Size(178, 46)
        Me.rdbDivi.TabIndex = 9
        Me.rdbDivi.Text = "División"
        Me.rdbDivi.UseVisualStyleBackColor = True
        '
        'frmOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 647)
        Me.Controls.Add(Me.rdbDivi)
        Me.Controls.Add(Me.rdbMulti)
        Me.Controls.Add(Me.rdbResta)
        Me.Controls.Add(Me.rdbSuma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOperacion)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.txtValorB)
        Me.Controls.Add(Me.txtValorA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOperaciones"
        Me.Text = "frmOperaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValorA As TextBox
    Friend WithEvents txtValorB As TextBox
    Friend WithEvents txtRes As TextBox
    Friend WithEvents lblOperacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdbSuma As RadioButton
    Friend WithEvents rdbResta As RadioButton
    Friend WithEvents rdbMulti As RadioButton
    Friend WithEvents rdbDivi As RadioButton
End Class
