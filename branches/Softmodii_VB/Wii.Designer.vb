<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Softmodii
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Softmodii))
        Me.btn_help = New System.Windows.Forms.Button
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_back = New System.Windows.Forms.Button
        Me.pic_imagenes = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_print = New System.Windows.Forms.Button
        Me.prnDoc = New System.Drawing.Printing.PrintDocument
        Me.changeimage1 = New System.Windows.Forms.PictureBox
        Me.changeimage2 = New System.Windows.Forms.PictureBox
        Me.btn_links = New System.Windows.Forms.Button
        Me.changeimage3 = New System.Windows.Forms.PictureBox
        Me.controlador_imagenes = New System.Windows.Forms.Timer(Me.components)
        Me.btn_csd = New System.Windows.Forms.Button
        Me.lbl_mensajeinicio = New System.Windows.Forms.Label
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_load = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnchanges = New System.Windows.Forms.Button
        Me.btn_info = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtbox_big = New System.Windows.Forms.RichTextBox
        Me.btn_videos = New System.Windows.Forms.Button
        Me.tooltip_botones = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_update = New System.Windows.Forms.Button
        Me.lbl_titulo = New System.Windows.Forms.Label
        Me.menu_superior = New System.Windows.Forms.MenuStrip
        Me.IniciarTutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TutorialesExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComplementariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UsoDeHomebrewChannelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsoDeBootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExtraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarWiiDeFormaSeguraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.InstalarPriiloaderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarCIOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.WadManagerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PrevenirBricksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComprobarActualizacionesWiiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.PáginaEnGoogleCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PáginaEnFacebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TwitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PostEnEOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WikiDeAplicacionesEOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CanalYoutubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BetatestersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.pic_imagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.changeimage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.changeimage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.changeimage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_superior.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_help
        '
        Me.btn_help.BackColor = System.Drawing.Color.White
        Me.btn_help.BackgroundImage = Global.ismaelWii.My.Resources.Resources.help
        Me.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_help.Enabled = False
        Me.btn_help.Location = New System.Drawing.Point(7, 242)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(40, 40)
        Me.btn_help.TabIndex = 49
        Me.tooltip_botones.SetToolTip(Me.btn_help, "Ayuda")
        Me.btn_help.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.Control
        Me.btn_next.BackgroundImage = Global.ismaelWii.My.Resources.Resources.nextimage
        Me.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_next.Enabled = False
        Me.btn_next.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_next.Location = New System.Drawing.Point(650, 298)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(52, 36)
        Me.btn_next.TabIndex = 52
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_back.BackgroundImage = Global.ismaelWii.My.Resources.Resources.backimage
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.Enabled = False
        Me.btn_back.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_back.Location = New System.Drawing.Point(596, 298)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(52, 36)
        Me.btn_back.TabIndex = 53
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'pic_imagenes
        '
        Me.pic_imagenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_imagenes.Image = Global.ismaelWii.My.Resources.Resources.imageninicial
        Me.pic_imagenes.Location = New System.Drawing.Point(577, 37)
        Me.pic_imagenes.Name = "pic_imagenes"
        Me.pic_imagenes.Size = New System.Drawing.Size(295, 166)
        Me.pic_imagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_imagenes.TabIndex = 36
        Me.pic_imagenes.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 518)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 8)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.White
        Me.btn_print.BackgroundImage = Global.ismaelWii.My.Resources.Resources.print2
        Me.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_print.Enabled = False
        Me.btn_print.Location = New System.Drawing.Point(7, 201)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(40, 40)
        Me.btn_print.TabIndex = 59
        Me.tooltip_botones.SetToolTip(Me.btn_print, "Imprimir")
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'prnDoc
        '
        '
        'changeimage1
        '
        Me.changeimage1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.changeimage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.changeimage1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changeimage1.Image = Global.ismaelWii.My.Resources.Resources.blanco
        Me.changeimage1.Location = New System.Drawing.Point(596, 216)
        Me.changeimage1.Name = "changeimage1"
        Me.changeimage1.Size = New System.Drawing.Size(81, 75)
        Me.changeimage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.changeimage1.TabIndex = 66
        Me.changeimage1.TabStop = False
        '
        'changeimage2
        '
        Me.changeimage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.changeimage2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changeimage2.Location = New System.Drawing.Point(683, 216)
        Me.changeimage2.Name = "changeimage2"
        Me.changeimage2.Size = New System.Drawing.Size(81, 75)
        Me.changeimage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.changeimage2.TabIndex = 67
        Me.changeimage2.TabStop = False
        '
        'btn_links
        '
        Me.btn_links.BackColor = System.Drawing.Color.White
        Me.btn_links.BackgroundImage = Global.ismaelWii.My.Resources.Resources.link
        Me.btn_links.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_links.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_links.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_links.Location = New System.Drawing.Point(784, 298)
        Me.btn_links.Name = "btn_links"
        Me.btn_links.Size = New System.Drawing.Size(79, 36)
        Me.btn_links.TabIndex = 68
        Me.btn_links.UseVisualStyleBackColor = False
        '
        'changeimage3
        '
        Me.changeimage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.changeimage3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changeimage3.Location = New System.Drawing.Point(770, 216)
        Me.changeimage3.Name = "changeimage3"
        Me.changeimage3.Size = New System.Drawing.Size(81, 75)
        Me.changeimage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.changeimage3.TabIndex = 69
        Me.changeimage3.TabStop = False
        '
        'controlador_imagenes
        '
        Me.controlador_imagenes.Enabled = True
        '
        'btn_csd
        '
        Me.btn_csd.BackColor = System.Drawing.Color.White
        Me.btn_csd.BackgroundImage = Global.ismaelWii.My.Resources.Resources.csdlogo
        Me.btn_csd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_csd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_csd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_csd.Location = New System.Drawing.Point(708, 298)
        Me.btn_csd.Name = "btn_csd"
        Me.btn_csd.Size = New System.Drawing.Size(70, 36)
        Me.btn_csd.TabIndex = 71
        Me.btn_csd.UseVisualStyleBackColor = False
        '
        'lbl_mensajeinicio
        '
        Me.lbl_mensajeinicio.AutoSize = True
        Me.lbl_mensajeinicio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensajeinicio.Location = New System.Drawing.Point(592, 225)
        Me.lbl_mensajeinicio.Name = "lbl_mensajeinicio"
        Me.lbl_mensajeinicio.Size = New System.Drawing.Size(248, 57)
        Me.lbl_mensajeinicio.TabIndex = 72
        Me.lbl_mensajeinicio.Text = "Con Softmodii abrirás tu Wii" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al mundo del homebrew y de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la carga de backups fác" & _
            "ilmente." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.White
        Me.btn_save.BackgroundImage = Global.ismaelWii.My.Resources.Resources.guardar
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_save.Enabled = False
        Me.btn_save.Location = New System.Drawing.Point(7, 119)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(40, 40)
        Me.btn_save.TabIndex = 73
        Me.tooltip_botones.SetToolTip(Me.btn_save, "Guardar tutorial")
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_load
        '
        Me.btn_load.BackColor = System.Drawing.Color.White
        Me.btn_load.BackgroundImage = Global.ismaelWii.My.Resources.Resources.load
        Me.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_load.Location = New System.Drawing.Point(7, 160)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(40, 40)
        Me.btn_load.TabIndex = 74
        Me.tooltip_botones.SetToolTip(Me.btn_load, "Cargar tutorial")
        Me.btn_load.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(594, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Anterior"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(648, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Siguiente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(714, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Prep. SD"
        '
        'btnchanges
        '
        Me.btnchanges.AccessibleDescription = "Cambios"
        Me.btnchanges.AccessibleName = "Cambios"
        Me.btnchanges.BackColor = System.Drawing.Color.White
        Me.btnchanges.BackgroundImage = Global.ismaelWii.My.Resources.Resources.changes
        Me.btnchanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnchanges.Location = New System.Drawing.Point(7, 37)
        Me.btnchanges.Name = "btnchanges"
        Me.btnchanges.Size = New System.Drawing.Size(40, 40)
        Me.btnchanges.TabIndex = 92
        Me.btnchanges.Tag = "Cambios"
        Me.tooltip_botones.SetToolTip(Me.btnchanges, "Cambios")
        Me.btnchanges.UseVisualStyleBackColor = False
        '
        'btn_info
        '
        Me.btn_info.BackColor = System.Drawing.Color.White
        Me.btn_info.BackgroundImage = Global.ismaelWii.My.Resources.Resources.about
        Me.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_info.Location = New System.Drawing.Point(7, 329)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(40, 40)
        Me.btn_info.TabIndex = 84
        Me.tooltip_botones.SetToolTip(Me.btn_info, "Información del programa")
        Me.btn_info.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(794, 337)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Enlaces"
        '
        'txtbox_big
        '
        Me.txtbox_big.BackColor = System.Drawing.Color.LightCyan
        Me.txtbox_big.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_big.Location = New System.Drawing.Point(54, 37)
        Me.txtbox_big.Name = "txtbox_big"
        Me.txtbox_big.ReadOnly = True
        Me.txtbox_big.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtbox_big.Size = New System.Drawing.Size(517, 332)
        Me.txtbox_big.TabIndex = 87
        Me.txtbox_big.Text = ""
        '
        'btn_videos
        '
        Me.btn_videos.BackColor = System.Drawing.Color.White
        Me.btn_videos.BackgroundImage = Global.ismaelWii.My.Resources.Resources.youtubeicon
        Me.btn_videos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_videos.Location = New System.Drawing.Point(7, 78)
        Me.btn_videos.Name = "btn_videos"
        Me.btn_videos.Size = New System.Drawing.Size(40, 40)
        Me.btn_videos.TabIndex = 90
        Me.tooltip_botones.SetToolTip(Me.btn_videos, "Vídeos")
        Me.btn_videos.UseVisualStyleBackColor = False
        '
        'tooltip_botones
        '
        Me.tooltip_botones.AutoPopDelay = 5000
        Me.tooltip_botones.InitialDelay = 50
        Me.tooltip_botones.ReshowDelay = 100
        Me.tooltip_botones.ShowAlways = True
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.White
        Me.btn_update.BackgroundImage = Global.ismaelWii.My.Resources.Resources.update2
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_update.Location = New System.Drawing.Point(7, 288)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(40, 40)
        Me.btn_update.TabIndex = 95
        Me.tooltip_botones.SetToolTip(Me.btn_update, "Actualizar")
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.Black
        Me.lbl_titulo.Location = New System.Drawing.Point(577, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(152, 27)
        Me.lbl_titulo.TabIndex = 54
        Me.lbl_titulo.Text = "Softmodii 4.2"
        '
        'menu_superior
        '
        Me.menu_superior.BackColor = System.Drawing.Color.White
        Me.menu_superior.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarTutorialToolStripMenuItem, Me.TutorialesExtraToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.BetatestersToolStripMenuItem})
        Me.menu_superior.Location = New System.Drawing.Point(0, 0)
        Me.menu_superior.Name = "menu_superior"
        Me.menu_superior.Size = New System.Drawing.Size(873, 24)
        Me.menu_superior.TabIndex = 93
        Me.menu_superior.Text = "MenuStrip1"
        '
        'IniciarTutorialToolStripMenuItem
        '
        Me.IniciarTutorialToolStripMenuItem.Name = "IniciarTutorialToolStripMenuItem"
        Me.IniciarTutorialToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.IniciarTutorialToolStripMenuItem.Text = "Iniciar Tutorial"
        '
        'TutorialesExtraToolStripMenuItem
        '
        Me.TutorialesExtraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplementariosToolStripMenuItem1, Me.ExtraToolStripMenuItem1, Me.TToolStripMenuItem})
        Me.TutorialesExtraToolStripMenuItem.Name = "TutorialesExtraToolStripMenuItem"
        Me.TutorialesExtraToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.TutorialesExtraToolStripMenuItem.Text = "Tutoriales Extra"
        '
        'ComplementariosToolStripMenuItem1
        '
        Me.ComplementariosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsoDeHomebrewChannelToolStripMenuItem, Me.UsoDeBootToolStripMenuItem})
        Me.ComplementariosToolStripMenuItem1.Name = "ComplementariosToolStripMenuItem1"
        Me.ComplementariosToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.ComplementariosToolStripMenuItem1.Text = "Complementarios"
        '
        'UsoDeHomebrewChannelToolStripMenuItem
        '
        Me.UsoDeHomebrewChannelToolStripMenuItem.Name = "UsoDeHomebrewChannelToolStripMenuItem"
        Me.UsoDeHomebrewChannelToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.UsoDeHomebrewChannelToolStripMenuItem.Text = "Uso de Homebrew Channel"
        '
        'UsoDeBootToolStripMenuItem
        '
        Me.UsoDeBootToolStripMenuItem.Name = "UsoDeBootToolStripMenuItem"
        Me.UsoDeBootToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.UsoDeBootToolStripMenuItem.Text = "Uso de BootMii"
        '
        'ExtraToolStripMenuItem1
        '
        Me.ExtraToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarWiiDeFormaSeguraToolStripMenuItem1, Me.InstalarPriiloaderToolStripMenuItem1, Me.ActualizarCIOSToolStripMenuItem1, Me.WadManagerToolStripMenuItem1, Me.PrevenirBricksToolStripMenuItem1})
        Me.ExtraToolStripMenuItem1.Name = "ExtraToolStripMenuItem1"
        Me.ExtraToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.ExtraToolStripMenuItem1.Text = "Extra"
        '
        'ActualizarWiiDeFormaSeguraToolStripMenuItem1
        '
        Me.ActualizarWiiDeFormaSeguraToolStripMenuItem1.Name = "ActualizarWiiDeFormaSeguraToolStripMenuItem1"
        Me.ActualizarWiiDeFormaSeguraToolStripMenuItem1.Size = New System.Drawing.Size(235, 22)
        Me.ActualizarWiiDeFormaSeguraToolStripMenuItem1.Text = "Actualizar Wii de forma segura"
        '
        'InstalarPriiloaderToolStripMenuItem1
        '
        Me.InstalarPriiloaderToolStripMenuItem1.Name = "InstalarPriiloaderToolStripMenuItem1"
        Me.InstalarPriiloaderToolStripMenuItem1.Size = New System.Drawing.Size(235, 22)
        Me.InstalarPriiloaderToolStripMenuItem1.Text = "Instalar Priiloader"
        '
        'ActualizarCIOSToolStripMenuItem1
        '
        Me.ActualizarCIOSToolStripMenuItem1.Name = "ActualizarCIOSToolStripMenuItem1"
        Me.ActualizarCIOSToolStripMenuItem1.Size = New System.Drawing.Size(235, 22)
        Me.ActualizarCIOSToolStripMenuItem1.Text = "Actualizar cIOS"
        '
        'WadManagerToolStripMenuItem1
        '
        Me.WadManagerToolStripMenuItem1.Name = "WadManagerToolStripMenuItem1"
        Me.WadManagerToolStripMenuItem1.Size = New System.Drawing.Size(235, 22)
        Me.WadManagerToolStripMenuItem1.Text = "Wad Manager"
        '
        'PrevenirBricksToolStripMenuItem1
        '
        Me.PrevenirBricksToolStripMenuItem1.Name = "PrevenirBricksToolStripMenuItem1"
        Me.PrevenirBricksToolStripMenuItem1.Size = New System.Drawing.Size(235, 22)
        Me.PrevenirBricksToolStripMenuItem1.Text = "Prevenir Bricks"
        '
        'TToolStripMenuItem
        '
        Me.TToolStripMenuItem.Name = "TToolStripMenuItem"
        Me.TToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.TToolStripMenuItem.Text = "Diccionario Scene"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprobarActualizacionesWiiToolStripMenuItem, Me.ToolStripMenuItem2, Me.PáginaEnGoogleCodeToolStripMenuItem, Me.PáginaEnFacebookToolStripMenuItem, Me.TwitterToolStripMenuItem, Me.PostEnEOLToolStripMenuItem, Me.WikiDeAplicacionesEOLToolStripMenuItem, Me.CanalYoutubeToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ComprobarActualizacionesWiiToolStripMenuItem
        '
        Me.ComprobarActualizacionesWiiToolStripMenuItem.Name = "ComprobarActualizacionesWiiToolStripMenuItem"
        Me.ComprobarActualizacionesWiiToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ComprobarActualizacionesWiiToolStripMenuItem.Text = "Comprobar actualizaciones Wii"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(238, 22)
        Me.ToolStripMenuItem2.Text = "---"
        '
        'PáginaEnGoogleCodeToolStripMenuItem
        '
        Me.PáginaEnGoogleCodeToolStripMenuItem.Image = Global.ismaelWii.My.Resources.Resources.googlecode
        Me.PáginaEnGoogleCodeToolStripMenuItem.Name = "PáginaEnGoogleCodeToolStripMenuItem"
        Me.PáginaEnGoogleCodeToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.PáginaEnGoogleCodeToolStripMenuItem.Text = "Página en Google Code"
        '
        'PáginaEnFacebookToolStripMenuItem
        '
        Me.PáginaEnFacebookToolStripMenuItem.Image = Global.ismaelWii.My.Resources.Resources.facebook
        Me.PáginaEnFacebookToolStripMenuItem.Name = "PáginaEnFacebookToolStripMenuItem"
        Me.PáginaEnFacebookToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.PáginaEnFacebookToolStripMenuItem.Text = "Página en Facebook"
        '
        'TwitterToolStripMenuItem
        '
        Me.TwitterToolStripMenuItem.Image = Global.ismaelWii.My.Resources.Resources.twitter
        Me.TwitterToolStripMenuItem.Name = "TwitterToolStripMenuItem"
        Me.TwitterToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.TwitterToolStripMenuItem.Text = "Twitter"
        '
        'PostEnEOLToolStripMenuItem
        '
        Me.PostEnEOLToolStripMenuItem.Image = Global.ismaelWii.My.Resources.Resources.eol
        Me.PostEnEOLToolStripMenuItem.Name = "PostEnEOLToolStripMenuItem"
        Me.PostEnEOLToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.PostEnEOLToolStripMenuItem.Text = "Post en EOL"
        '
        'WikiDeAplicacionesEOLToolStripMenuItem
        '
        Me.WikiDeAplicacionesEOLToolStripMenuItem.Image = Global.ismaelWii.My.Resources.Resources.eol
        Me.WikiDeAplicacionesEOLToolStripMenuItem.Name = "WikiDeAplicacionesEOLToolStripMenuItem"
        Me.WikiDeAplicacionesEOLToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.WikiDeAplicacionesEOLToolStripMenuItem.Text = "Wiki de aplicaciones - EOL"
        '
        'CanalYoutubeToolStripMenuItem
        '
        Me.CanalYoutubeToolStripMenuItem.Image = Global.ismaelWii.My.Resources.Resources.youtube
        Me.CanalYoutubeToolStripMenuItem.Name = "CanalYoutubeToolStripMenuItem"
        Me.CanalYoutubeToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CanalYoutubeToolStripMenuItem.Text = "Canal Youtube"
        '
        'BetatestersToolStripMenuItem
        '
        Me.BetatestersToolStripMenuItem.Name = "BetatestersToolStripMenuItem"
        Me.BetatestersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.BetatestersToolStripMenuItem.Text = "Betatesters"
        Me.BetatestersToolStripMenuItem.Visible = False
        '
        'Softmodii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(873, 372)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btnchanges)
        Me.Controls.Add(Me.btn_videos)
        Me.Controls.Add(Me.txtbox_big)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_info)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lbl_mensajeinicio)
        Me.Controls.Add(Me.btn_csd)
        Me.Controls.Add(Me.changeimage3)
        Me.Controls.Add(Me.btn_links)
        Me.Controls.Add(Me.changeimage2)
        Me.Controls.Add(Me.changeimage1)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.pic_imagenes)
        Me.Controls.Add(Me.menu_superior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu_superior
        Me.MaximizeBox = False
        Me.Name = "Softmodii"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Softmodii 4.2"
        CType(Me.pic_imagenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.changeimage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.changeimage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.changeimage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_superior.ResumeLayout(False)
        Me.menu_superior.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_imagenes As System.Windows.Forms.PictureBox
    Friend WithEvents btn_help As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents prnDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents changeimage1 As System.Windows.Forms.PictureBox
    Friend WithEvents changeimage2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_links As System.Windows.Forms.Button
    Friend WithEvents changeimage3 As System.Windows.Forms.PictureBox
    Friend WithEvents controlador_imagenes As System.Windows.Forms.Timer
    Friend WithEvents btn_csd As System.Windows.Forms.Button
    Friend WithEvents lbl_mensajeinicio As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_load As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_info As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtbox_big As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_videos As System.Windows.Forms.Button
    Friend WithEvents btnchanges As System.Windows.Forms.Button
    Friend WithEvents tooltip_botones As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents menu_superior As System.Windows.Forms.MenuStrip
    Friend WithEvents IniciarTutorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprobarActualizacionesWiiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PáginaEnFacebookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TwitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostEnEOLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanalYoutubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BetatestersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutorialesExtraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplementariosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsoDeHomebrewChannelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsoDeBootToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtraToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarWiiDeFormaSeguraToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstalarPriiloaderToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarCIOSToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WadManagerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrevenirBricksToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents WikiDeAplicacionesEOLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PáginaEnGoogleCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
