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
        Me.lblntabla = New System.Windows.Forms.Label()
        Me.txtntabla = New System.Windows.Forms.TextBox()
        Me.btnprocesar = New System.Windows.Forms.Button()
        Me.IstTablas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblntabla
        '
        Me.lblntabla.AutoSize = True
        Me.lblntabla.Location = New System.Drawing.Point(23, 46)
        Me.lblntabla.Name = "lblntabla"
        Me.lblntabla.Size = New System.Drawing.Size(34, 13)
        Me.lblntabla.TabIndex = 0
        Me.lblntabla.Text = "Tabla"
        '
        'txtntabla
        '
        Me.txtntabla.Location = New System.Drawing.Point(63, 43)
        Me.txtntabla.Name = "txtntabla"
        Me.txtntabla.Size = New System.Drawing.Size(100, 20)
        Me.txtntabla.TabIndex = 1
        '
        'btnprocesar
        '
        Me.btnprocesar.Location = New System.Drawing.Point(63, 106)
        Me.btnprocesar.Name = "btnprocesar"
        Me.btnprocesar.Size = New System.Drawing.Size(100, 54)
        Me.btnprocesar.TabIndex = 2
        Me.btnprocesar.Text = "Generar tabla"
        Me.btnprocesar.UseVisualStyleBackColor = True
        '
        'IstTablas
        '
        Me.IstTablas.FormattingEnabled = True
        Me.IstTablas.Location = New System.Drawing.Point(207, 32)
        Me.IstTablas.Name = "IstTablas"
        Me.IstTablas.Size = New System.Drawing.Size(222, 147)
        Me.IstTablas.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IstTablas)
        Me.Controls.Add(Me.btnprocesar)
        Me.Controls.Add(Me.txtntabla)
        Me.Controls.Add(Me.lblntabla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblntabla As Label
    Friend WithEvents txtntabla As TextBox
    Friend WithEvents btnprocesar As Button
    Friend WithEvents IstTablas As ListBox
End Class
