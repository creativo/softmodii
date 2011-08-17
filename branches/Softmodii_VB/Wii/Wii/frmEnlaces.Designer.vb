<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnlaces
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnlaces))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.combo_exploits = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.combo_otros = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.combo_extras = New System.Windows.Forms.ComboBox
        Me.btn_extras = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(182, 45)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(117, 17)
        Me.LinkLabel1.TabIndex = 40
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "-HackMii Installer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(347, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 22)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = " Exploits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 22)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "HackMii"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 22)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Extras"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 22)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Otros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Enlaces"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 91)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Aquí encontraras las " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "descargas necesarias para" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "poder seguir el tutorial." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La d" & _
            "escarga de este " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "material es legal, ya que " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "es gratuíto y facilitado por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los" & _
            " mismos autores."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ismaelWii.My.Resources.Resources.link
        Me.PictureBox1.Location = New System.Drawing.Point(33, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 38)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'combo_exploits
        '
        Me.combo_exploits.BackColor = System.Drawing.Color.White
        Me.combo_exploits.DisplayMember = "1"
        Me.combo_exploits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_exploits.FormattingEnabled = True
        Me.combo_exploits.ItemHeight = 13
        Me.combo_exploits.Items.AddRange(New Object() {"LetterBomb", "BannerBomb", "-------------------", "Return of the Jodi", "BatHax (Batman)", "Yu-Gi-Owned!", "Indiana PWNS!", "Smash Stack USA", "Smash Stack EUR Save", "Smash Stack EUR No Save", "Yu-Gi-Vah! (USA)", "Exploit Tales of S. EUR", "Exploit Tales of S. USA"})
        Me.combo_exploits.Location = New System.Drawing.Point(321, 41)
        Me.combo_exploits.Name = "combo_exploits"
        Me.combo_exploits.Size = New System.Drawing.Size(139, 21)
        Me.combo_exploits.TabIndex = 75
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(332, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 28)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Descargar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'combo_otros
        '
        Me.combo_otros.BackColor = System.Drawing.Color.White
        Me.combo_otros.DisplayMember = "1"
        Me.combo_otros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_otros.FormattingEnabled = True
        Me.combo_otros.ItemHeight = 13
        Me.combo_otros.Items.AddRange(New Object() {"cIOS38 rev17", "cIOS rev19", "cIOS Hermes", "Wad Manager GUI", "Nus Downloader", "7ZIP (Descompresor)"})
        Me.combo_otros.Location = New System.Drawing.Point(321, 138)
        Me.combo_otros.Name = "combo_otros"
        Me.combo_otros.Size = New System.Drawing.Size(139, 21)
        Me.combo_otros.TabIndex = 77
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 28)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Descargar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'combo_extras
        '
        Me.combo_extras.BackColor = System.Drawing.Color.White
        Me.combo_extras.DisplayMember = "1"
        Me.combo_extras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_extras.FormattingEnabled = True
        Me.combo_extras.ItemHeight = 13
        Me.combo_extras.Items.AddRange(New Object() {"Priiloader", "Pimp My Wii", "Wii Backup Mngr.", "ImgBurn"})
        Me.combo_extras.Location = New System.Drawing.Point(160, 138)
        Me.combo_extras.Name = "combo_extras"
        Me.combo_extras.Size = New System.Drawing.Size(139, 21)
        Me.combo_extras.TabIndex = 79
        '
        'btn_extras
        '
        Me.btn_extras.Location = New System.Drawing.Point(169, 165)
        Me.btn_extras.Name = "btn_extras"
        Me.btn_extras.Size = New System.Drawing.Size(118, 28)
        Me.btn_extras.TabIndex = 80
        Me.btn_extras.Text = "Descargar"
        Me.btn_extras.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(189, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(261, 26)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Para seleccionar un link, abre la lista correspondiente " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y pulsa ""Descargar""."
        '
        'frmEnlaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(474, 256)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_extras)
        Me.Controls.Add(Me.combo_extras)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.combo_otros)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.combo_exploits)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEnlaces"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enlaces"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents combo_exploits As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents combo_otros As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents combo_extras As System.Windows.Forms.ComboBox
    Friend WithEvents btn_extras As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
