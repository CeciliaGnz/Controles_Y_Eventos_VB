﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.mnust = New System.Windows.Forms.MenuStrip()
        Me.MatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestauranteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnust.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnust
        '
        Me.mnust.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnust.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnust.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatrizToolStripMenuItem, Me.OperaciónToolStripMenuItem, Me.ImagenToolStripMenuItem, Me.RestauranteToolStripMenuItem})
        Me.mnust.Location = New System.Drawing.Point(0, 0)
        Me.mnust.Name = "mnust"
        Me.mnust.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnust.Size = New System.Drawing.Size(790, 49)
        Me.mnust.TabIndex = 1
        Me.mnust.Text = "MenuStrip1"
        '
        'MatrizToolStripMenuItem
        '
        Me.MatrizToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatrizToolStripMenuItem.Name = "MatrizToolStripMenuItem"
        Me.MatrizToolStripMenuItem.Size = New System.Drawing.Size(122, 45)
        Me.MatrizToolStripMenuItem.Text = "Matriz"
        '
        'OperaciónToolStripMenuItem
        '
        Me.OperaciónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperaciónToolStripMenuItem.Name = "OperaciónToolStripMenuItem"
        Me.OperaciónToolStripMenuItem.Size = New System.Drawing.Size(175, 45)
        Me.OperaciónToolStripMenuItem.Text = "Operación"
        '
        'ImagenToolStripMenuItem
        '
        Me.ImagenToolStripMenuItem.Name = "ImagenToolStripMenuItem"
        Me.ImagenToolStripMenuItem.Size = New System.Drawing.Size(136, 45)
        Me.ImagenToolStripMenuItem.Text = "Imagen"
        '
        'RestauranteToolStripMenuItem
        '
        Me.RestauranteToolStripMenuItem.Name = "RestauranteToolStripMenuItem"
        Me.RestauranteToolStripMenuItem.Size = New System.Drawing.Size(198, 45)
        Me.RestauranteToolStripMenuItem.Text = "Restaurante"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 458)
        Me.Controls.Add(Me.mnust)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnust
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMenu"
        Me.Text = "Menú"
        Me.mnust.ResumeLayout(False)
        Me.mnust.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnust As MenuStrip
    Friend WithEvents MatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestauranteToolStripMenuItem As ToolStripMenuItem
End Class
