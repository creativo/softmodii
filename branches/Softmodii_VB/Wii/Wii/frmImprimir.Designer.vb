<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimir
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimir))
        Me.btn_print = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbox_print = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.White
        Me.btn_print.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_print.Location = New System.Drawing.Point(27, 88)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(277, 48)
        Me.btn_print.TabIndex = 0
        Me.btn_print.Text = "Imprimir"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tutorial a imprimir:"
        '
        'txtbox_print
        '
        Me.txtbox_print.Location = New System.Drawing.Point(109, 52)
        Me.txtbox_print.Name = "txtbox_print"
        Me.txtbox_print.ReadOnly = True
        Me.txtbox_print.Size = New System.Drawing.Size(195, 20)
        Me.txtbox_print.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Impresión de tutoriales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Asegúrate de tener la impresora totalmente configurada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y conectada al PC."
        '
        'frmImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(322, 180)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_print)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_print)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmImprimir"
        Me.Text = "Imprimir tutorial - Softmodii"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbox_print As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
