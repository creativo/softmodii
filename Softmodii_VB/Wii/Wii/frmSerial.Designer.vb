<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerial))
        Me.btn_serial_aceptar = New System.Windows.Forms.Button
        Me.combo_serial = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btn_dvd = New System.Windows.Forms.Button
        Me.btn_usb = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_finalizar = New System.Windows.Forms.Button
        Me.lst_version = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_version_aceptar = New System.Windows.Forms.Button
        Me.lbl_titulo = New System.Windows.Forms.Label
        Me.txtbox_serial = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.box1 = New System.Windows.Forms.GroupBox
        Me.Box2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Box3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_carga_usb = New System.Windows.Forms.Label
        Me.lbl_carga_dvd = New System.Windows.Forms.Label
        Me.lbl_bootmii = New System.Windows.Forms.Label
        Me.lbl_region = New System.Windows.Forms.Label
        Me.lbl_texto_usb = New System.Windows.Forms.Label
        Me.lbl_texto_dvd = New System.Windows.Forms.Label
        Me.lbl_texto_bootmii = New System.Windows.Forms.Label
        Me.lbl_texto_region = New System.Windows.Forms.Label
        Me.lbl_datos_warning = New System.Windows.Forms.Label
        Me.box1.SuspendLayout()
        Me.Box2.SuspendLayout()
        Me.Box3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_serial_aceptar
        '
        Me.btn_serial_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_serial_aceptar.Location = New System.Drawing.Point(54, 79)
        Me.btn_serial_aceptar.Name = "btn_serial_aceptar"
        Me.btn_serial_aceptar.Size = New System.Drawing.Size(94, 22)
        Me.btn_serial_aceptar.TabIndex = 0
        Me.btn_serial_aceptar.Text = "Introducir"
        '
        'combo_serial
        '
        Me.combo_serial.BackColor = System.Drawing.Color.White
        Me.combo_serial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_serial.FormattingEnabled = True
        Me.combo_serial.Items.AddRange(New Object() {"LEH", "LU", "LEM", "LEF", "Otro"})
        Me.combo_serial.Location = New System.Drawing.Point(16, 37)
        Me.combo_serial.Name = "combo_serial"
        Me.combo_serial.Size = New System.Drawing.Size(49, 21)
        Me.combo_serial.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(51, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "1- Nº SERIE WII:"
        '
        'btn_dvd
        '
        Me.btn_dvd.BackColor = System.Drawing.SystemColors.Control
        Me.btn_dvd.BackgroundImage = Global.ismaelWii.My.Resources.Resources.dvdlogo
        Me.btn_dvd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_dvd.Enabled = False
        Me.btn_dvd.Location = New System.Drawing.Point(33, 33)
        Me.btn_dvd.Name = "btn_dvd"
        Me.btn_dvd.Size = New System.Drawing.Size(65, 49)
        Me.btn_dvd.TabIndex = 52
        Me.btn_dvd.UseVisualStyleBackColor = False
        '
        'btn_usb
        '
        Me.btn_usb.BackColor = System.Drawing.SystemColors.Control
        Me.btn_usb.BackgroundImage = Global.ismaelWii.My.Resources.Resources.usblogo
        Me.btn_usb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_usb.Enabled = False
        Me.btn_usb.Location = New System.Drawing.Point(119, 33)
        Me.btn_usb.Name = "btn_usb"
        Me.btn_usb.Size = New System.Drawing.Size(65, 49)
        Me.btn_usb.TabIndex = 53
        Me.btn_usb.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "2- MÉTODO CARGA:"
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_finalizar.Enabled = False
        Me.btn_finalizar.Location = New System.Drawing.Point(254, 233)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(171, 24)
        Me.btn_finalizar.TabIndex = 55
        Me.btn_finalizar.Text = "Seguir con Tutorial"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'lst_version
        '
        Me.lst_version.FormattingEnabled = True
        Me.lst_version.Items.AddRange(New Object() {"Menor (2.x)", "3.0E - 3.0U", "3.1E - 3.1U", "3.2E - 3.2U ", "3.3E - 3.3U", "3.4E - 3.4U", "4.0E - 4.0U", "4.1E - 4.1U", "4.2E - 4.2U", "4.3E - 4.3U"})
        Me.lst_version.Location = New System.Drawing.Point(54, 32)
        Me.lst_version.Name = "lst_version"
        Me.lst_version.Size = New System.Drawing.Size(104, 21)
        Me.lst_version.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "3- VERSIÓN DE WII:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 10)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Elige una de la lista."
        '
        'btn_version_aceptar
        '
        Me.btn_version_aceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_version_aceptar.Enabled = False
        Me.btn_version_aceptar.Location = New System.Drawing.Point(57, 79)
        Me.btn_version_aceptar.Name = "btn_version_aceptar"
        Me.btn_version_aceptar.Size = New System.Drawing.Size(101, 22)
        Me.btn_version_aceptar.TabIndex = 57
        Me.btn_version_aceptar.Text = "Introducir"
        Me.btn_version_aceptar.UseVisualStyleBackColor = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(94, 11)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(274, 16)
        Me.lbl_titulo.TabIndex = 60
        Me.lbl_titulo.Text = "Por favor, rellena los siguientes datos:"
        '
        'txtbox_serial
        '
        Me.txtbox_serial.Location = New System.Drawing.Point(85, 38)
        Me.txtbox_serial.Mask = "999999999"
        Me.txtbox_serial.Name = "txtbox_serial"
        Me.txtbox_serial.Size = New System.Drawing.Size(99, 20)
        Me.txtbox_serial.TabIndex = 61
        Me.txtbox_serial.Text = "000000000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 10)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Seleccionalo todo y borralo."
        '
        'box1
        '
        Me.box1.Controls.Add(Me.Label14)
        Me.box1.Controls.Add(Me.Label4)
        Me.box1.Controls.Add(Me.combo_serial)
        Me.box1.Controls.Add(Me.txtbox_serial)
        Me.box1.Controls.Add(Me.btn_serial_aceptar)
        Me.box1.Location = New System.Drawing.Point(12, 30)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(212, 107)
        Me.box1.TabIndex = 63
        Me.box1.TabStop = False
        '
        'Box2
        '
        Me.Box2.Controls.Add(Me.Label6)
        Me.Box2.Controls.Add(Me.Label1)
        Me.Box2.Controls.Add(Me.btn_dvd)
        Me.Box2.Controls.Add(Me.btn_usb)
        Me.Box2.Enabled = False
        Me.Box2.Location = New System.Drawing.Point(12, 150)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(212, 107)
        Me.Box2.TabIndex = 64
        Me.Box2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 24)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Cargar desde DVD o Pendrive/Disco Duro USB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Box3
        '
        Me.Box3.Controls.Add(Me.Label2)
        Me.Box3.Controls.Add(Me.lst_version)
        Me.Box3.Controls.Add(Me.Label3)
        Me.Box3.Controls.Add(Me.btn_version_aceptar)
        Me.Box3.Enabled = False
        Me.Box3.Location = New System.Drawing.Point(236, 30)
        Me.Box3.Name = "Box3"
        Me.Box3.Size = New System.Drawing.Size(212, 107)
        Me.Box3.TabIndex = 65
        Me.Box3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(230, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Nº Serie:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(291, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 36)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Míralo en parte inferior de la consola." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(230, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Método de carga:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(337, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 24)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "¿DVD o dispositivo USB?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(230, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Versión de Wii:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(329, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 12)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Ver en Configuración de Wii." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 329)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(427, 12)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Aviso: Los datos de tu consola no son enviados a ningún lugar, y serán eliminados" & _
            " al cerrar el programa." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(307, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "AYUDA:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_carga_usb)
        Me.GroupBox1.Controls.Add(Me.lbl_carga_dvd)
        Me.GroupBox1.Controls.Add(Me.lbl_bootmii)
        Me.GroupBox1.Controls.Add(Me.lbl_region)
        Me.GroupBox1.Controls.Add(Me.lbl_texto_usb)
        Me.GroupBox1.Controls.Add(Me.lbl_texto_dvd)
        Me.GroupBox1.Controls.Add(Me.lbl_texto_bootmii)
        Me.GroupBox1.Controls.Add(Me.lbl_texto_region)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 63)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de tu Wii:"
        '
        'lbl_carga_usb
        '
        Me.lbl_carga_usb.AutoSize = True
        Me.lbl_carga_usb.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_carga_usb.Location = New System.Drawing.Point(315, 44)
        Me.lbl_carga_usb.Name = "lbl_carga_usb"
        Me.lbl_carga_usb.Size = New System.Drawing.Size(0, 15)
        Me.lbl_carga_usb.TabIndex = 7
        '
        'lbl_carga_dvd
        '
        Me.lbl_carga_dvd.AutoSize = True
        Me.lbl_carga_dvd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_carga_dvd.Location = New System.Drawing.Point(316, 16)
        Me.lbl_carga_dvd.Name = "lbl_carga_dvd"
        Me.lbl_carga_dvd.Size = New System.Drawing.Size(0, 15)
        Me.lbl_carga_dvd.TabIndex = 6
        '
        'lbl_bootmii
        '
        Me.lbl_bootmii.AutoSize = True
        Me.lbl_bootmii.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bootmii.Location = New System.Drawing.Point(78, 44)
        Me.lbl_bootmii.Name = "lbl_bootmii"
        Me.lbl_bootmii.Size = New System.Drawing.Size(0, 15)
        Me.lbl_bootmii.TabIndex = 5
        '
        'lbl_region
        '
        Me.lbl_region.AutoSize = True
        Me.lbl_region.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_region.Location = New System.Drawing.Point(72, 16)
        Me.lbl_region.Name = "lbl_region"
        Me.lbl_region.Size = New System.Drawing.Size(0, 15)
        Me.lbl_region.TabIndex = 4
        '
        'lbl_texto_usb
        '
        Me.lbl_texto_usb.AutoSize = True
        Me.lbl_texto_usb.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_texto_usb.Location = New System.Drawing.Point(184, 44)
        Me.lbl_texto_usb.Name = "lbl_texto_usb"
        Me.lbl_texto_usb.Size = New System.Drawing.Size(118, 15)
        Me.lbl_texto_usb.TabIndex = 3
        Me.lbl_texto_usb.Text = "CARGA DESDE USB:"
        '
        'lbl_texto_dvd
        '
        Me.lbl_texto_dvd.AutoSize = True
        Me.lbl_texto_dvd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_texto_dvd.Location = New System.Drawing.Point(184, 16)
        Me.lbl_texto_dvd.Name = "lbl_texto_dvd"
        Me.lbl_texto_dvd.Size = New System.Drawing.Size(118, 15)
        Me.lbl_texto_dvd.TabIndex = 2
        Me.lbl_texto_dvd.Text = "CARGA DESDE DVD:"
        '
        'lbl_texto_bootmii
        '
        Me.lbl_texto_bootmii.AutoSize = True
        Me.lbl_texto_bootmii.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_texto_bootmii.Location = New System.Drawing.Point(13, 44)
        Me.lbl_texto_bootmii.Name = "lbl_texto_bootmii"
        Me.lbl_texto_bootmii.Size = New System.Drawing.Size(59, 15)
        Me.lbl_texto_bootmii.TabIndex = 1
        Me.lbl_texto_bootmii.Text = "BOOTMII:"
        '
        'lbl_texto_region
        '
        Me.lbl_texto_region.AutoSize = True
        Me.lbl_texto_region.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_texto_region.Location = New System.Drawing.Point(13, 16)
        Me.lbl_texto_region.Name = "lbl_texto_region"
        Me.lbl_texto_region.Size = New System.Drawing.Size(53, 15)
        Me.lbl_texto_region.TabIndex = 0
        Me.lbl_texto_region.Text = "REGIÓN:"
        '
        'lbl_datos_warning
        '
        Me.lbl_datos_warning.AutoSize = True
        Me.lbl_datos_warning.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datos_warning.Location = New System.Drawing.Point(10, 341)
        Me.lbl_datos_warning.Name = "lbl_datos_warning"
        Me.lbl_datos_warning.Size = New System.Drawing.Size(151, 12)
        Me.lbl_datos_warning.TabIndex = 75
        Me.lbl_datos_warning.Text = "Datos aproximados de gbatemp.net"
        '
        'frmSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(455, 358)
        Me.Controls.Add(Me.lbl_datos_warning)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Box3)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.box1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_finalizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSerial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Introducción de datos - Softmodii"
        Me.box1.ResumeLayout(False)
        Me.box1.PerformLayout()
        Me.Box2.ResumeLayout(False)
        Me.Box2.PerformLayout()
        Me.Box3.ResumeLayout(False)
        Me.Box3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_serial_aceptar As System.Windows.Forms.Button
    Friend WithEvents combo_serial As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_dvd As System.Windows.Forms.Button
    Friend WithEvents btn_usb As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_finalizar As System.Windows.Forms.Button
    Friend WithEvents lst_version As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_version_aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents txtbox_serial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents box1 As System.Windows.Forms.GroupBox
    Friend WithEvents Box2 As System.Windows.Forms.GroupBox
    Friend WithEvents Box3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_texto_usb As System.Windows.Forms.Label
    Friend WithEvents lbl_texto_dvd As System.Windows.Forms.Label
    Friend WithEvents lbl_texto_bootmii As System.Windows.Forms.Label
    Friend WithEvents lbl_texto_region As System.Windows.Forms.Label
    Friend WithEvents lbl_carga_usb As System.Windows.Forms.Label
    Friend WithEvents lbl_carga_dvd As System.Windows.Forms.Label
    Friend WithEvents lbl_bootmii As System.Windows.Forms.Label
    Friend WithEvents lbl_region As System.Windows.Forms.Label
    Friend WithEvents lbl_datos_warning As System.Windows.Forms.Label

End Class
