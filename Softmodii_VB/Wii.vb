Public Class Softmodii
    Public proceso As String
    '-------------------Nº DE VERSIÓN DE SOFTMODII 
    Public version As Integer = 4203
    '--------------------N1 DE VERSIÓN DE CSD
    Public csd_version As Integer = 9999
    '-------------------INFORMACIÓN PARA INFORME
    Public inf_wanin_cios As String = "cIOS d2X v7-Final"
    Public inf_hermes_cios As String = "cIOS 222v5(base 38) ,223v5 (base37), 224v5 (base 57), 202v5 (base 57)"
    Public inf_homebrew_channel As String = "versión 1.0.8"
    Public inf_ios36 As String = "IOS236 (Trucha sign, ES_Identify, NAND access)"
    Public inf_bootmii As String = "beta 6 v1.3"
    Public inf_cfg As String = "v58 222"
    Public inf_uloader As String = "versión 5.1E"
    Public inf_priiloader As String = "NO INSTALADO"
    Public inf_softmodii As String = "versión 4.2"
    '-------------------------------------------
    'VARIABLES GLOBALES
    Public StringToPrint As String 'Contiene texto a imprimir

    Public reg 'Región de la consola
    Public boot2 As Boolean 'True si puede instalar Bootmii en boot2
    Public cargadvd As Boolean 'True si puede cargar por DVD


    Public dvd As Boolean 'Si carga por DVD
    Public usb As Boolean 'Si carga por USB
    Public ver 'Versión de la consola
    Public especial As Boolean


    Public currentdir As String 'Directorio actual
    Public softmodii_online As String 'Versión de softmodii en el servidor
    Public csd_online 'Versión de CSD en el servidor

    Public tutos_online 'Versión de tutoriales en el servidor

    Public tutos_version 'Versión de tutoriales actual

    Public wiiversion As String 'Versión de Wii en Internet, contiene texto
    Public exploit As String 'Exploit usado
    Public exploit_comprobar As Boolean 'Si se está comprobando el exploit

    Public tutoarchivo 'Guarda el tutorial en una variable, para poder cargarlo luego.
    Public dia 'día actual
    Public mes 'mes actual
    Public ruta_update 'Ruta de donde descarga archivo de actualización

    Dim obj_FSO = CreateObject("Scripting.FileSystemObject") 'Objeto para crear archivos


    Public Sub Preparar_Tuto_Extra() 'Desactiva botones, cambia proceso para poder usar un tutorial extra.

        btn_next.Enabled = False
        btn_back.Enabled = False
        proceso = "Tuto_extra"
        btn_load.Enabled = True
        btn_save.Enabled = True
        btn_print.Enabled = True
        lbl_mensajeinicio.Visible = True
        lbl_mensajeinicio.Text = "Con Softmodii abrirás tu Wii " & Chr(13) & "al mundo del Homebrew y de" & Chr(13) & "la carga de backups fácilmente"
        changeimage1.Image = My.Resources.blanco
        changeimage2.Image = My.Resources.blanco
        changeimage3.Image = My.Resources.blanco


    End Sub
    'FUNCIÓN DE MENSAJE CON SI O NO.
    Public Function DialogoSiNo(ByVal mensaje, ByVal titulo) As Integer
        Return MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel, _
           Nothing)
    End Function

    'FUNCIÓN QUE PREGUNTA SI CARGAR TUTORIAL EXTRA.
    Public Function Confirmar_Tuto_extra() As Integer
        Return DialogoSiNo("Si tienes algún tutorial abierto se perderá si no lo has guardado." & Chr(13) & "¿Deseas continuar?", "¿Cargar tutorial extra?")
       

    End Function
    Public Function cargar_tuto(ByVal tutorial) As Integer
        'Esta es la función principal que se encarga de preparar y cargar todos los tutoriales.
        txtbox_big.Clear()
        If tutorial = "bootmii" Then
            btn_back.Enabled = True
            proceso = "bootmii"
            lbl_titulo.Text = "BootMii"
            pic_imagenes.Image = My.Resources.hbc31
            txtbox_big.LoadFile("data/bootmii.smi")
            tutoarchivo = "data/bootmii.smi"
        ElseIf tutorial = "cios43-33" Then
            proceso = "cios43-33"
            lbl_titulo.Text = "Instalación de cIOS"
            pic_imagenes.Image = My.Resources.cios
            tutoarchivo = "data/cios43-33.smi"
            txtbox_big.LoadFile("data/cios43-33.smi")
        ElseIf tutorial = "cios32" Then
            proceso = "cios32"
            lbl_titulo.Text = "Instalando cIOS"
            txtbox_big.LoadFile("data/cios32.smi")
            pic_imagenes.Image = My.Resources.cios
            tutoarchivo = "data/cios32.smi"
        ElseIf tutorial = "hbc42" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc42.smi"
            txtbox_big.LoadFile("data\hbc42.smi")
            pic_imagenes.Image = My.Resources.hbc11
        ElseIf tutorial = "hbc41" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc41.smi"
            txtbox_big.LoadFile("data\hbc41.smi")
        ElseIf tutorial = "hbc43_letterbomb" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc43_letterbomb.smi"
            txtbox_big.LoadFile("data\hbc43_letterbomb.smi")
        ElseIf tutorial = "hbc43_lego" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc43_lego.smi"
            txtbox_big.LoadFile("data\hbc43_lego.smi")
        ElseIf tutorial = "hbc43_ssbb_usa" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc43_ssbb.smi"
            txtbox_big.LoadFile("data\hbc43_ssbb.smi")
        ElseIf tutorial = "hbc43_ssbb_eur" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc43_ssbb_pal.smi"
            txtbox_big.LoadFile("data\hbc43_ssbb_pal.smi")
        ElseIf tutorial = "hbc43_ygh" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc43_ygh.smi"
            txtbox_big.LoadFile("data\hbc43_ygh.smi")
        ElseIf tutorial = "hbc43_ygh_usa" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc43_ygh_usa.smi"
            txtbox_big.LoadFile("data\hbc43_ygh_usa.smi")
        ElseIf tutorial = "hbc43_batman" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc43_batman.smi"
            txtbox_big.LoadFile("data\hbc43_batman.smi")
        ElseIf tutorial = "hbc43_jodi" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc43_jodi.smi"
            txtbox_big.LoadFile("data\hbc43_jodi.smi")
        ElseIf tutorial = "hbc43_tales" Then
            lbl_titulo.Text = "Homebrew Channel"
            btn_back.Enabled = False
            proceso = "hbc"
            tutoarchivo = "data/hbc43_tales.smi"
            txtbox_big.LoadFile("data\hbc43_tales.smi")
        ElseIf tutorial = "dvd" Then
            proceso = "dvd"
            lbl_titulo.Text = "Cargar desde DVD"
            tutoarchivo = "data/dvdloader.smi"
            txtbox_big.Clear()
            txtbox_big.LoadFile("data/dvdloader.smi")
            pic_imagenes.Image = My.Resources.dvd12
        ElseIf tutorial = "usb" Then
            proceso = "usb"
            lbl_titulo.Text = "Carga desde USB"
            tutoarchivo = "data/usbloader.smi"
            pic_imagenes.Image = My.Resources.usb1
            txtbox_big.Clear()
            txtbox_big.LoadFile("data/usbloader.smi")
        ElseIf tutorial = "grabar" Then
            tutoarchivo = "data/burn.smi"
            lbl_titulo.Text = "Grabación de juegos"
            proceso = "grabar"
            pic_imagenes.Image = My.Resources.burn1
            txtbox_big.Clear()
            txtbox_big.LoadFile("data/burn.smi")
        ElseIf tutorial = "ex_pimp" Then
            txtbox_big.LoadFile("data\pimpmywii.smi")
            proceso = "ex_pimp"
            lbl_titulo.Text = "Actualizando Wii"
            pic_imagenes.Image = My.Resources.update
            changeimage1.Image = My.Resources.blanco
            changeimage2.Image = My.Resources.blanco
            changeimage3.Image = My.Resources.blanco
            lbl_mensajeinicio.Visible = True
            lbl_mensajeinicio.Text = "Con Pimp my Wii actualizas" & Chr(13) & "tu Wii de forma segura."
        ElseIf tutorial = "ex_priiloader" Then
            tutoarchivo = "data/priiloader.smi"
            txtbox_big.LoadFile("data/priiloader.smi")
            pic_imagenes.Image = My.Resources.priiloader1
            proceso = "ex_priiloader"
            lbl_titulo.Text = "Priiloader"
            inf_priiloader = "versión 0.4"
            lbl_mensajeinicio.Visible = False
        ElseIf tutorial = "ex_wadmanager" Then
            tutoarchivo = "data/wadmanager.smi"
            txtbox_big.LoadFile("data/wadmanager.smi")
            proceso = "ex_wadmanager"
            pic_imagenes.Image = My.Resources.wad1
            lbl_mensajeinicio.Visible = False
            lbl_titulo.Text = "Wad Manager"
        ElseIf tutorial = "ex_warnings" Then
            txtbox_big.LoadFile("data/warnings.smi")
            tutoarchivo = "data/warnings.smi"
            proceso = "ex_warnings"
            lbl_titulo.Text = "Precauciones sobre Bricks"
            pic_imagenes.Image = My.Resources.brick
            changeimage1.Image = My.Resources.blanco
            changeimage2.Image = My.Resources.blanco
            changeimage3.Image = My.Resources.blanco
            lbl_mensajeinicio.Visible = True
            lbl_mensajeinicio.Text = "Información importante sobre" & Chr(13) & "cómo evitar bricks"
        ElseIf tutorial = "reiniciar" Then
            btn_print.Enabled = False
            ver = "00"
            dvd = "false"
            usb = "false"
            proceso = "inicio"
            btn_back.Enabled = False
            btn_help.Enabled = False
            btn_next.Enabled = False
            lbl_mensajeinicio.Visible = True
            pic_imagenes.Image = My.Resources.imageninicial
            lbl_mensajeinicio.Text = "Con Softmodii abrirás tu Wii " & Chr(13) & "al mundo del Homebrew y de" & Chr(13) & "la carga de backups fácilmente"
            changeimage1.Image = My.Resources.blanco
            changeimage2.Image = My.Resources.blanco
            changeimage3.Image = My.Resources.blanco
            btn_save.Enabled = False
            btn_load.Enabled = True
        End If

    End Function





    Private Sub Main()

    End Sub





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'BORRA VERSIONES ANTIGUAS DE SOFTMODII Y CSD
        If My.Computer.FileSystem.FileExists("softmodii_old.exe") Then
            My.Computer.FileSystem.DeleteFile("softmodii_old.exe")

        ElseIf My.Computer.FileSystem.FileExists("csd_data_old.msi") Then
            My.Computer.FileSystem.DeleteFile("csd_data_old.msi")

        End If


        'CARGO VERSIONES DEL PROGRAMA DESDE ARCHIVO DE VERSION
        Dim Archivo_version As Object
        Archivo_version = obj_FSO.OpenTextFile("data/version_data.dat", 1)
        csd_version = Archivo_version.readline
        tutos_version = Archivo_version.readline
        ruta_update = Archivo_version.readline
        Archivo_version.close()
        'CARGO TUTORIAL DE INICIO
        txtbox_big.LoadFile("data/inicio.smi")



        ''FELICITACIÓN DE NAVIDAD
        mes = Today.Month
        dia = Today.Day
        If mes = 12 And dia >= 20 Then
            pic_imagenes.Image = My.Resources.iniciochristmas
        ElseIf mes = 1 And dia <= 6 Then
            pic_imagenes.Image = My.Resources.iniciochristmas
        End If


    End Sub




    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.bootmii.org/download")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://bannerbomb.qoid.us")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.megaupload.com/?d=CEVIIP95")
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.megaupload.com/?d=FYFDPEV7")
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.elotrolado.net/hilo_trucha-bug-restorer-v1-11_1354937")
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.megaupload.com/?d=D2CJEJA3")
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.megaupload.com/?d=21796PM6")

    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.elotrolado.net/hilo_hilo-oficial-pimp-my-wii-1-31_1297134")

    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://wii.gx-mod.com/modules/mydownloads/visit.php?lid=689")
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAbout.Show()
    End Sub


    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.mediafire.com/download.php?uyijocmhzie")
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.mediafire.com/?zjtgjewi2yy")
    End Sub

    Private Sub LinkLabel13_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.digital-digest.com/software/download.php?sid=470&ssid=0&did=1")

    End Sub

    Private Sub LinkLabel14_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.megaupload.com/?d=4YIK0415")
    End Sub


    Private Sub LinkLabel4_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.megaupload.com/?d=JH3YYJ9D")
    End Sub



    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://cfg-loader.googlecode.com/files/Cfg_USB_Loader_50.zip")
    End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.4shared.com/file/174365329/4ab28a1a/WiiBackupManager031beta2.html")

    End Sub


    Private Sub Button8_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_help.Click
        frmAyuda.Show()
    End Sub






    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        txtbox_big.Clear() 'Borro el texto para que la barra se desplace

        If proceso = "hbc" Then  'Pasar a BootMii desde HBC
            cargar_tuto("bootmii")


            'Pasar desde bootmii a cIOS según la versión
        ElseIf proceso = "bootmii" And ver = 43 Then ' Si vienes de BootMii y tienes 4.2, ir a cios 4.3

            cargar_tuto("cios43-33")

        ElseIf proceso = "bootmii" And ver = 42 Then 'También vas a cIOS 4.3 porque los tutoriales son los mismos.

            cargar_tuto("cios43-33")

        ElseIf proceso = "bootmii" And ver < 42 And ver > 32 Then

            cargar_tuto("cios43-33")

        ElseIf proceso = "bootmii" And ver = 32 Then 'Cargas el cIOS 3.2
            cargar_tuto("cios32")



        ElseIf proceso = "cios43-33" Or proceso = "cios32" Then 'Cambiar desde proceso de CIOS a DVD o USB
            If dvd = True Then
                cargar_tuto("dvd")
            ElseIf usb = True Then
                cargar_tuto("usb")
            End If




        ElseIf proceso = "dvd" Then 'Si está en proceso de DVD, mostrar proceso de grabar
            cargar_tuto("grabar")

        ElseIf proceso = "grabar" Then 'Si está en GRABAR, preguntar si quiere tutorial extendido.
            If DialogoSiNo("Ya has acabado el tutorial. Puedes cargar backups sin problemas." & Chr(13) & "De todas formas, es recomendable hacer el tutorial extendido" & Chr(13) & "Son los siguientes tutoriales:" & Chr(13) & "-Actualizar Wii de forma segura" & Chr(13) & "-Instalar Priiloader (Antibricks) " & Chr(13) & "Uso de WadManager" & Chr(13) & "-Precauciones ante bricks" & Chr(13) & Chr(13) & "¿Deseas realizar estos tutoriales?", "Tutoriales Extra") = DialogResult.OK Then
                cargar_tuto("ex_pimp")
            Else
                frmFinal.Show()
            End If

        ElseIf proceso = "usb" Then 'Si está en USB, preguntar si quiere tutorial extendido.
            If DialogoSiNo("Ya has acabado el tutorial. Puedes cargar backups sin problemas." & Chr(13) & "De todas formas, es recomendable hacer el tutorial extendido" & Chr(13) & "Son los siguientes tutoriales:" & Chr(13) & "-Actualizar Wii de forma segura" & Chr(13) & "-Instalar Priiloader (Antibricks) " & Chr(13) & "-Uso de WadManager" & Chr(13) & "-Precauciones ante bricks" & Chr(13) & Chr(13) & "¿Deseas realizar estos tutoriales?", "Tutoriales Extra") = DialogResult.OK Then
                cargar_tuto("ex_pimp")
            Else
                frmFinal.Show()
            End If


            'Tutoriales extra
        ElseIf proceso = "ex_pimp" Then
            cargar_tuto("ex_priiloader")

        ElseIf proceso = "ex_priiloader" Then
            cargar_tuto("ex_wadmanager")

        ElseIf proceso = "ex_wadmanager" Then
            cargar_tuto("ex_warnings")

        ElseIf proceso = "ex_warnings" Then
            frmFinal.Show()

        End If
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("http://www.elotrolado.net/hilo_softmodii-2-3-1-aplicacion-ideal-para-novatos_1357121")
    End Sub

    Private Sub Back1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        txtbox_big.Clear() 'Borro el texto para que la barra se desplace.

        'Si estás en bootmii
        If proceso = "bootmii" Then
            If ver = 42 Then
                cargar_tuto("hbc42")
            ElseIf ver < 42 And ver > 20 Then
                cargar_tuto("hbc41")
            ElseIf ver = 43 Then
                cargar_tuto("hbc43_letterbomb")
                If ver = 43 And exploit = "lego" Then
                    cargar_tuto("hbc43_lego")
                ElseIf ver = 43 And exploit = "ssbb" And reg = "usa" Then
                    cargar_tuto("hbc43_ssbb_usa")
                ElseIf ver = 43 And exploit = "ssbb" And reg = "eur" Then
                    cargar_tuto("hbc43_ssbb_eur")
                ElseIf ver = 43 And exploit = "ygh" And reg = "eur" Then
                    cargar_tuto("hbc43_ygh")
                ElseIf ver = 43 And exploit = "ygh" And reg = "usa" Then
                    cargar_tuto("hbc43_ygh_usa")
                ElseIf ver = 43 And exploit = "batman" Then
                    cargar_tuto("hbc43_batman")
                ElseIf ver = 43 And exploit = "jodi" Then
                    cargar_tuto("hbc43_jodi")
                ElseIf ver = 43 And exploit = "tales" Then
                    cargar_tuto("hbc43_tales")
                End If
            End If


        End If

            'Si estás en cios
            If proceso = "cios43-33" Or proceso = "cios42" Or proceso = "cios41" Or proceso = "cios32" Then

                cargar_tuto("bootmii")

            End If

            'Si estás en DVD, ir hacia cIOS
            If proceso = "dvd" Then
                If ver = "43" Then
                    cargar_tuto("cios43-33")
                ElseIf ver = "42" Then
                    cargar_tuto("cios43-33")
                ElseIf ver <= 41 And ver > 32 Then
                    cargar_tuto("cios43-33")
                ElseIf ver = 32 Then
                    cargar_tuto("cios32")
                End If
            End If

            'Si estás en USB, ir hacia cIOS
            If proceso = "usb" Then
                If ver = "43" Then
                    cargar_tuto("cios43-33")
                ElseIf ver = "42" Then
                    cargar_tuto("cios43-33")
                ElseIf ver <= 41 And ver > 32 Then
                    cargar_tuto("cios43-33")
                ElseIf ver = 32 Then
                    cargar_tuto("cios32")
                End If
            End If



            'Si estás en GRABAR, ir hacia DVD
            If proceso = "grabar" Then

                cargar_tuto("dvd")

                'TUTORIALES EXTRA
            ElseIf proceso = "ex_pimp" Then
                cargar_tuto("ex_pimp")
                MsgBox("Si quieres volver al tutorial simple, empieza un nuevo tutorial")
            ElseIf proceso = "ex_priiloader" Then
                cargar_tuto("ex_pimp")

            ElseIf proceso = "ex_wadmanager" Then
                cargar_tuto("ex_priiloader")

            ElseIf proceso = "ex_warnings" Then
                cargar_tuto("ex_wadmanager")



            End If
    End Sub



    Private Sub LinkLabel12_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.megaupload.com/?d=5K84D7PD")
    End Sub

    Private Sub LinkLabel14_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://wiibrew.org/w/images/8/8c/AnyTitle_Deleter_HBC.zip")
    End Sub




    Private Sub menu_cboot2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        especial = True

        If ver = "42" Then
            txtbox_big.Clear()
            txtbox_big.LoadFile("data/cios42.smi")
        Else
            txtbox_big.Clear()
            txtbox_big.LoadFile("data/cios41.smi")
        End If
        lbl_titulo.Text = "Instalando cIOS"

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        frmImprimir.Show()

        frmImprimir.txtbox_print.Text = lbl_titulo.Text

    End Sub

    Private Sub prnDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prnDoc.PrintPage

        Dim numChars As Integer

        Dim numLines As Integer

        Dim stringForPage As String

        Dim strFormat As New StringFormat()

        Dim PrintFont As Font

        PrintFont = txtbox_big.Font

        Dim rectDraw As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)

        Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))

        strFormat.Trimming = StringTrimming.Word

        e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, numChars, numLines)

        stringForPage = StringToPrint.Substring(0, numChars)

        e.Graphics.DrawString(stringForPage, PrintFont, Brushes.Black, rectDraw, strFormat)

        If numChars < StringToPrint.Length Then

            StringToPrint = StringToPrint.Substring(numChars)

            e.HasMorePages = True

        Else

            e.HasMorePages = False

        End If
    End Sub



    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDebug.Show()
    End Sub

    Private Sub mas_imagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If proceso = "hbc" Or proceso = "bootios" Or proceso = "boot2" Then


        Else : MsgBox("Este tutorial no tiene más imágenes")
        End If
    End Sub



    Private Sub AcercaDeToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAbout.Show()
    End Sub

    Private Sub CódigosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDebug.Show()

    End Sub

    Private Sub ActualizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("http://www.elotrolado.net/hilo_softmodii-2-3-1-aplicacion-ideal-para-novatos_1357121")
    End Sub





    Private Sub changeimage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changeimage1.Click
        If proceso = "hbc" Then
            pic_imagenes.Image = My.Resources.hbc11
        ElseIf proceso = "cios43-33" Then
            pic_imagenes.Image = My.Resources.cios
        ElseIf proceso = "cios32" Then
            pic_imagenes.Image = My.Resources.cios
        ElseIf proceso = "bootmii" Then
            pic_imagenes.Image = My.Resources.hbc31

        ElseIf proceso = "grabar" Then
            pic_imagenes.Image = My.Resources.burn1
        ElseIf proceso = "dvd" Then
            pic_imagenes.Image = My.Resources.dvd12
        ElseIf proceso = "usb" Then
            pic_imagenes.Image = My.Resources.usb1
        ElseIf proceso = "ex_priiloader" Then
            pic_imagenes.Image = My.Resources.priiloader1
        ElseIf proceso = "ex_cios" Then
            pic_imagenes.Image = My.Resources.updatecios1
        ElseIf proceso = "ex_wadmanager" Then
            pic_imagenes.Image = My.Resources.wad1
        End If




    End Sub

    Private Sub changeimage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changeimage2.Click
        If proceso = "hbc" Then
            pic_imagenes.Image = My.Resources.hbc31
        ElseIf proceso = "cios43-33" Then
            pic_imagenes.Image = My.Resources.cios2

        ElseIf proceso = "cios32" Then
            pic_imagenes.Image = My.Resources.cios2
        ElseIf proceso = "bootmii" Then
            pic_imagenes.Image = My.Resources.hbc21

        ElseIf proceso = "grabar" Then
            pic_imagenes.Image = My.Resources.burn2
        ElseIf proceso = "dvd" Then
            pic_imagenes.Image = My.Resources.dvd3
        ElseIf proceso = "usb" Then
            pic_imagenes.Image = My.Resources.usb3
        ElseIf proceso = "ex_priiloader" Then
            pic_imagenes.Image = My.Resources.priiloader2
        ElseIf proceso = "ex_cios" Then
            pic_imagenes.Image = My.Resources.updatecios31
        ElseIf proceso = "ex_wadmanager" Then
            pic_imagenes.Image = My.Resources.wad2

        End If

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changeimage3.Click
        If proceso = "hbc" Then
            pic_imagenes.Image = My.Resources.hbc21
        ElseIf proceso = "cios43-33" Then
            pic_imagenes.Image = My.Resources.cios3

        ElseIf proceso = "cios32" Then
            pic_imagenes.Image = My.Resources.cios3
        ElseIf proceso = "bootmii" Then
            pic_imagenes.Image = My.Resources.bootm1

        ElseIf proceso = "grabar" Then
            pic_imagenes.Image = My.Resources.burn3
        ElseIf proceso = "dvd" Then
            pic_imagenes.Image = My.Resources.DVD21
        ElseIf proceso = "usb" Then
            pic_imagenes.Image = My.Resources.usb2
        ElseIf proceso = "ex_priiloader" Then
            pic_imagenes.Image = My.Resources.priiloader3
        ElseIf proceso = "ex_cios" Then
            pic_imagenes.Image = My.Resources.updatecios2
        ElseIf proceso = "ex_wadmanager" Then
            pic_imagenes.Image = My.Resources.wad3
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles controlador_imagenes.Tick
        If proceso = "hbc" Then
            changeimage1.Image = My.Resources.minihbc1
            changeimage2.Image = My.Resources.minihbc3
            changeimage3.Image = My.Resources.minihbc2

        ElseIf proceso = "cios43-33" Then
            changeimage1.Image = My.Resources.minicios
            changeimage2.Image = My.Resources.minicios2
            changeimage3.Image = My.Resources.minicios3

        ElseIf proceso = "cios32" Then
            changeimage1.Image = My.Resources.minicios
            changeimage2.Image = My.Resources.minicios2
            changeimage3.Image = My.Resources.minicios3
        ElseIf proceso = "bootmii" Then
            changeimage1.Image = My.Resources.minihbc3
            changeimage2.Image = My.Resources.minihbc2
            changeimage3.Image = My.Resources.minibootm1

        ElseIf proceso = "grabar" Then
            changeimage1.Image = My.Resources.miniburn1
            changeimage2.Image = My.Resources.miniburn2
            changeimage3.Image = My.Resources.miniburn3
        ElseIf proceso = "dvd" Then
            changeimage1.Image = My.Resources.minidvd1
            changeimage3.Image = My.Resources.minibootm1
            changeimage2.Image = My.Resources.minidvd3
        ElseIf proceso = "usb" Then
            changeimage1.Image = My.Resources.miniusb1

            changeimage3.Image = My.Resources.miniusb2
            changeimage2.Image = My.Resources.miniusb3
        ElseIf proceso = "inicio" Then
            changeimage1.Image = My.Resources.blanco

            changeimage3.Image = My.Resources.blanco
            changeimage2.Image = My.Resources.blanco



        ElseIf proceso = "ex_priiloader" Then
            changeimage1.Image = My.Resources.priiloader1
            changeimage2.Image = My.Resources.priiloader2
            changeimage3.Image = My.Resources.priiloader3
        ElseIf proceso = "ex_cios" Then
            changeimage1.Image = My.Resources.updatecios1
            changeimage2.Image = My.Resources.minibootm1
            changeimage3.Image = My.Resources.minibootm1
        ElseIf proceso = "ex_wadmanager" Then
            changeimage1.Image = My.Resources.wad1
            changeimage2.Image = My.Resources.wad2
            changeimage3.Image = My.Resources.wad3



        End If

    End Sub

    Private Sub Links_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_links.Click
        frmEnlaces.Show()

    End Sub
    Private Sub changeimage1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles changeimage1.MouseEnter

        changeimage1.Top = changeimage1.Top - 10 'le resto la mitad del aumento para que quede centrado
        changeimage1.Left = changeimage1.Left - 10 'tanto en la separacion con el borde de arriba "Top"
        changeimage1.Width = changeimage1.Width + 10 ' como del borde de la izquierda "left"
        changeimage1.Height = changeimage1.Height + 10 'aumentamos la anchura "width" y la altura "height"
    End Sub

    Private Sub changeimage1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles changeimage1.MouseLeave
        changeimage1.Top = changeimage1.Top + 10 'Al salir el raton de la imagen hacemos el proceso contrario para
        changeimage1.Left = changeimage1.Left + 10 'devolver la imagen a su tamaño original
        changeimage1.Width = changeimage1.Width - 10 ' ten en cuenta que se ha ensanchado lo mismo de ancho que de alto
        changeimage1.Height = changeimage1.Height - 10 ' y la imagen se puede achatar para hacerlo bien hay que hacerlo con
        ' respetando las proporciones
    End Sub
    Private Sub changeimage2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles changeimage2.MouseEnter

        changeimage2.Top = changeimage2.Top - 10 'le resto la mitad del aumento para que quede centrado
        changeimage2.Left = changeimage2.Left - 10 'tanto en la separacion con el borde de arriba "Top"
        changeimage2.Width = changeimage2.Width + 10 ' como del borde de la izquierda "left"
        changeimage2.Height = changeimage2.Height + 10 'aumentamos la anchura "width" y la altura "height"
    End Sub

    Private Sub changeimage2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles changeimage2.MouseLeave
        changeimage2.Top = changeimage2.Top + 10 'le resto la mitad del aumento para que quede centrado
        changeimage2.Left = changeimage2.Left + 10 'tanto en la separacion con el borde de arriba "Top"
        changeimage2.Width = changeimage2.Width - 10 ' ten en cuenta que se ha ensanchado lo mismo de ancho que de alto
        changeimage2.Height = changeimage2.Height - 10 ' y la imagen se puede achatar para hacerlo bien hay que hacerlo con
        ' respetando las proporciones
    End Sub
    Private Sub changeimage3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles changeimage3.MouseEnter

        changeimage3.Top = changeimage3.Top - 10 'le resto la mitad del aumento para que quede centrado
        changeimage3.Left = changeimage3.Left - 10 'tanto en la separacion con el borde de arriba "Top"
        changeimage3.Width = changeimage3.Width + 10 ' como del borde de la izquierda "left"
        changeimage3.Height = changeimage3.Height + 10 'aumentamos la anchura "width" y la altura "height"
    End Sub

    Private Sub changeimage3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles changeimage3.MouseLeave
        changeimage3.Top = changeimage3.Top + 10 'le resto la mitad del aumento para que quede centrado
        changeimage3.Left = changeimage3.Left + 10 'tanto en la separacion con el borde de arriba "Top"
        changeimage3.Width = changeimage3.Width - 10 ' ten en cuenta que se ha ensanchado lo mismo de ancho que de alto
        changeimage3.Height = changeimage3.Height - 10 ' y la imagen se puede achatar para hacerlo bien hay que hacerlo con
        ' respetando las proporciones
    End Sub



    Private Sub Button2_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_csd.Click

        If proceso = "cios42" Or proceso = "cios41" Or proceso = "cios40" Or proceso = "cios34" Or proceso = "cios33" Or proceso = "cios32" Or proceso = "cios43-33" Then



            On Error Resume Next


            System.Diagnostics.Process.Start("csd_data.msi")
        Else
            MsgBox("Usar exclusivamente en tutorial de cIOS")
        End If





    End Sub




    Private Sub CargarEstadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If My.Settings.cabecera = "" Then
            MsgBox("No hay ningún tutorial guardado.")
        Else
            MsgBox("Se ha cargado el siguiente archivo" & Chr(13) & "-" + My.Settings.cabecera)


            usb = My.Settings.usb
            dvd = My.Settings.dvd
            boot2 = My.Settings.boot2
            proceso = My.Settings.proceso
            lbl_titulo.Text = My.Settings.label1
            txtbox_big.Clear()
            txtbox_big.Text = My.Settings.textbox1
            If My.Settings.next1 = True Then
                btn_next.Enabled = True
            Else
                btn_next.Enabled = False
            End If
            If My.Settings.back1 = True Then
                btn_back.Enabled = True
            Else
                btn_back.Enabled = False
            End If
        End If





    End Sub




    Private Sub Button2_Click_7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If My.Computer.FileSystem.FileExists("softmodiiviejo.exe") Then
            My.Computer.FileSystem.DeleteFile("softmodiiviejo.exe")
        End If

    End Sub



    Private Sub CargarEstadoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ActualizarSoftmodiiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub





    Private Sub ComprobarActualizacionWiiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Network.DownloadFile _
            ("http://dl.dropbox.com/u/3565590/Softmodii/wiiversion.txt", _
             "wiiversion.txt", " ", " ", showUI:=True, connectionTimeout:=500, overwrite:=True)
        wiiversion = My.Computer.FileSystem.ReadAllText("wiiversion.txt")
        MsgBox(wiiversion)
    End Sub



    Private Sub ArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Extendido_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case proceso
            Case "ex_cios"

                txtbox_big.Text = "Ex_cios"

        End Select
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        frmGuardar.Show()
        frmGuardar.TextBox1.Text = "Archivo de las " + TimeOfDay

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load.Click
        If My.Settings.cabecera = "" Then
            MsgBox("No hay ningún tutorial guardado.")
        Else
            frmCargar.Show()
            frmCargar.TextBox1.Text = My.Settings.cabecera

        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If proceso = "ex_pimp" Then
            lbl_titulo.Text = "Actualizando Wii a 4.1"

            pic_imagenes.Image = My.Resources.update
            changeimage1.Image = My.Resources.blanco
            changeimage2.Image = My.Resources.blanco
            changeimage3.Image = My.Resources.blanco
            lbl_mensajeinicio.Visible = True
            lbl_mensajeinicio.Text = "Con Pimp my Wii actualizas" & Chr(13) & "tu Wii de forma segura."
        ElseIf proceso = "ex_priiloader" Then
            lbl_titulo.Text = "Priiloader"

            inf_priiloader = "versión 0.4"
            lbl_mensajeinicio.Visible = False
        ElseIf proceso = "ex_wadmanager" Then
            lbl_titulo.Text = "Wad Manager"

        ElseIf proceso = "ex_warnings" Then
            lbl_titulo.Text = "Precauciones sobre bricks"

            pic_imagenes.Image = My.Resources.brick
            changeimage1.Image = My.Resources.blanco
            changeimage2.Image = My.Resources.blanco
            changeimage3.Image = My.Resources.blanco
            lbl_mensajeinicio.Visible = True
            lbl_mensajeinicio.Text = "Información importante sobre" & Chr(13) & "cómo evitar bricks"


        End If
    End Sub


    Private Sub MonitorDeActividadBetatestersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDebug.Show()
    End Sub




    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_info.Click
        frmAbout.Show()
    End Sub



    Private Sub btnchanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchanges.Click
        frmCambios.Show()
        frmCambios.txtbox_changes.LoadFile("data\cambios.smi")
    End Sub


    Private Sub CargarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If My.Settings.cabecera = "" Then
            MsgBox("No hay ningún tutorial guardado.")
        Else
            frmCargar.Show()
            frmCargar.TextBox1.Text = My.Settings.cabecera

        End If
    End Sub



    Private Sub IniciarTutorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarTutorialToolStripMenuItem.Click
        frmSerial.Show()
    End Sub



    Private Sub BetatestersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BetatestersToolStripMenuItem.Click
        frmDebug.Show()
    End Sub



    Private Sub PáginaEnFacebookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PáginaEnFacebookToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.facebook.com/pages/Softmodii/156318617738389")
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwitterToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.twitter.com/softmodii")
    End Sub

    Private Sub CanalYoutubeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanalYoutubeToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.youtube.com/softmodiieol")
    End Sub

    Private Sub PostEnEOLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostEnEOLToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.elotrolado.net/hilo_softmodii_1357121")
    End Sub

    Private Sub UsoDeHomebrewChannelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsoDeHomebrewChannelToolStripMenuItem.Click
        'Mensaje que pregunta si se quiere abrir el tutorial extra.
        If Confirmar_Tuto_extra() = DialogResult.OK Then

            Preparar_Tuto_Extra()
            txtbox_big.LoadFile("data\organizacion_hbc.smi") 'Cargo datos del tutorial.
            pic_imagenes.Image = My.Resources.organizacion_hbc_img
            lbl_titulo.Text = "Organización HBC"
            proceso = "tutorial_extra"

        End If
    End Sub

    Private Sub UsoDeBootToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsoDeBootToolStripMenuItem.Click
        'Mensaje que pregunta si se quiere abrir el tutorial extra.
        If Confirmar_Tuto_extra() = DialogResult.OK Then

            Preparar_Tuto_Extra()
            txtbox_big.LoadFile("data\bootmiiuse.smi") 'Cargo datos del tutorial.
            pic_imagenes.Image = My.Resources.bootmiiuse
            lbl_titulo.Text = "Uso de Bootmii"
            proceso = "tutorial_extra"

        End If

    End Sub



    Private Sub ActualizarWiiDeFormaSeguraToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarWiiDeFormaSeguraToolStripMenuItem1.Click

        If Confirmar_Tuto_extra() = DialogResult.OK Then

            Preparar_Tuto_Extra()
            txtbox_big.LoadFile("data\pimpmywii.smi")
            lbl_titulo.Text = "Actualizando Wii"
            pic_imagenes.Image = My.Resources.update
        End If

    End Sub


    Private Sub InstalarPriiloaderToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstalarPriiloaderToolStripMenuItem1.Click

        If Confirmar_Tuto_extra() = DialogResult.OK Then
            lbl_titulo.Text = "Instalar Priiloader"
            txtbox_big.LoadFile("data\priiloader_extra.smi")
            pic_imagenes.Image = My.Resources.priiloader2
        End If

    End Sub

    Private Sub ActualizarCIOSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarCIOSToolStripMenuItem1.Click
        If Confirmar_Tuto_extra() = DialogResult.OK Then
            lbl_titulo.Text = "Actualizar cIOSx"
            txtbox_big.LoadFile("data\updatecios.smi")
            pic_imagenes.Image = My.Resources.updatecios1
        End If


    End Sub

    Private Sub WadManagerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WadManagerToolStripMenuItem1.Click
        If Confirmar_Tuto_extra() = DialogResult.OK Then
            lbl_titulo.Text = "Wad Manager"
            txtbox_big.LoadFile("data\wadmanager.smi")
            pic_imagenes.Image = My.Resources.wad1
        End If

    End Sub

    Private Sub PrevenirBricksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrevenirBricksToolStripMenuItem1.Click
        If Confirmar_Tuto_extra() = DialogResult.OK Then
            lbl_titulo.Text = "Prevenir Bricks"
            txtbox_big.LoadFile("data\warnings.smi")
            pic_imagenes.Image = My.Resources.brick
        End If
    End Sub

    Private Sub btn_videos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_videos.Click
        If DialogoSiNo("Se abrirá una página en tu navegador" & Chr(13) & "¿Deseas continuar?", "Abrir enlace externo") = DialogResult.OK Then
            System.Diagnostics.Process.Start("http://www.youtube.com/softmodiieol")
        End If

    End Sub


    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        currentdir = My.Computer.FileSystem.CurrentDirectory 'defino currentdir


        'Descargar el archivo update_data.dat que tiene información sobre actualización.
        frmUpdating.Show()
        frmUpdating.Label1.Text = "Descargando información de actualización..."
        My.Computer.Network.DownloadFile _
                    (ruta_update, _
                     "data/update_data.dat", " ", " ", showUI:=True, connectionTimeout:=500, overwrite:=True)



        'Defino archivo y objeto
        Dim Archivo_tutos_act As Object


        'Abro el archivo
        Archivo_tutos_act = obj_FSO.OpenTextFile("data/update_data.dat", 1)

        Dim lineas_totales = Archivo_tutos_act.readline 'Meramente orientativo, para mostrar en pantalla.
        Dim smii_online = Archivo_tutos_act.readline 'Cargo versión Softmodii online

        Dim csd_data_online = Archivo_tutos_act.readline 'Cargo versión CSD online
        Dim tutoriales_online = Archivo_tutos_act.readline 'Cargo versión tutoriales online
        Dim ruta_softmodii = Archivo_tutos_act.readline 'Guardo la ruta de descarga de softmodii
        Dim ruta_csd_data = Archivo_tutos_act.readline 'Guardo la ruta de descarga de CSD

        'Variables a usar en la actualización
        Dim softmodii_actualizado = False
        Dim csd_data_actualizado = False
        Dim tutoriales_actualizado = False


        'ACTUALIZACIÓN DE CSD (csd_data.msi)----------------------------------------------

        If csd_version < csd_data_online Then
            'Renombrar el actual archivo csd_data.msi a csd_data_old.msi
            My.Computer.FileSystem.RenameFile("csd_data.msi", "csd_data_old.msi")

            'Mostrar diálogo de actualización
            frmUpdating.Show()
            frmUpdating.Label1.Text = "Descargando CSD v." & csd_data_online & "..."

            'Descargar el nuevo csd_data.msi
            My.Computer.Network.DownloadFile _
                    (ruta_csd_data, _
                     "csd_data.msi", " ", " ", showUI:=True, connectionTimeout:=500, overwrite:=True)

            'Borrar csd_data_old.msi
            My.Computer.FileSystem.DeleteFile("csd_data_old.msi")

            csd_data_actualizado = True 'Marco que se ha actualizado CSD

        End If



        'ACTUALIZACIÓN DE TUTORIALES (/data)----------------------------------------------

        If tutos_version < tutoriales_online Then
            'Mostrar diálogo actualización
            frmUpdating.Show()
            frmUpdating.progress.Maximum = lineas_totales 'Establezco longitud de barra de progreso

            'Empiezo a analizar el archivo y a descargar
            For contador As Integer = 1 To lineas_totales

                Dim web_path = Archivo_tutos_act.readline() 'Leo dirección web de descarga del tutorial
                Dim local_path = Archivo_tutos_act.readline() 'Leo ruta local donde guardarlo

                If web_path = "END" Or local_path = "END" Then 'Si se ha detectado el final del archivo
                    contador = lineas_totales + 1 'Se sale del for forzando
                Else 'Si no, a descargar
                    frmUpdating.Label1.Text = "Descargando tutorial " & contador & " de " & lineas_totales

                    My.Computer.Network.DownloadFile _
                            (web_path, _
                             local_path, " ", " ", showUI:=True, connectionTimeout:=500, overwrite:=True)
                End If
                frmUpdating.progress.Value = contador 'Avanzo la barra de progreso
            Next

            Archivo_tutos_act.close()
            tutoriales_actualizado = True 'Marco los tutoriales como actualizados
        End If


        'ACTUALIZACIÓN DE SOFTMODII (softmodii.exe)---------------------------------------------

        If version < smii_online Then
            'Renombrar el actual archivo softmodii.exe a softmodii_old.exe
            My.Computer.FileSystem.RenameFile("softmodii.exe", "softmodii_old.exe")

            'Mostrar diálogo de actualización
            frmUpdating.Show()
            frmUpdating.Label1.Text = "Descargando Softmodii ejecutable v." & smii_online & "..."

            'Descargar el nuevo softmodii.exe
            My.Computer.Network.DownloadFile _
              (ruta_softmodii, _
               "softmodii.exe", " ", " ", showUI:=True, connectionTimeout:=500, overwrite:=True)

            softmodii_actualizado = True 'Marco que se ha actualizado Softmodii

        End If

        'Cambiar la versión actual por la nueva
        My.Computer.FileSystem.DeleteFile("data/version_data.dat") 'Se borra archivo
        Dim Archivo_version = obj_FSO.CreateTextFile("data/version_data.dat", True) 'Se crea
        Archivo_version.WriteLine(csd_data_online) 'Se escriben las versiones de csd y tutoriales
        Archivo_version.WriteLine(tutoriales_online)
        Archivo_version.WriteLine(ruta_update)
        Archivo_version.close() 'Se cierra el archivo


        'Mensaje de que se ha actualizado correctamente
        If tutoriales_actualizado = True Or csd_data_actualizado = True Or softmodii_actualizado = True Then
            MsgBox("Se ha actualizado correctamente")
            btn_update.Enabled = False

            If softmodii_actualizado = True Then

                Me.Close()
            End If
        Else
            MsgBox("No hay actualizaciones disponibles")
        End If

        'Restauro valor inicial de variables
        softmodii_actualizado = False
        csd_data_actualizado = False
        tutoriales_actualizado = False


        frmUpdating.Close()
    End Sub


    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.FileSystem.DeleteFile("data/version_data.dat")
        Dim Archivo_version = obj_FSO.CreateTextFile("data/version_data.dat", True)
        Archivo_version.WriteLine(4124) 'Se escriben las versiones de csd y tutoriales
        Archivo_version.WriteLine(4125)
        Archivo_version.close()

    End Sub

    Private Sub Button2_Click_9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.FileSystem.DeleteFile("data/version_data.dat") 'Se borra archivo
        Dim Archivo_version = obj_FSO.CreateTextFile("data/version_data.dat", True) 'Se crea
        Archivo_version.WriteLine(333) 'Se escriben las versiones de csd y tutoriales
        Archivo_version.WriteLine(222)
        Archivo_version.WriteLine(ruta_update)
    End Sub

    Private Sub lbl_mensajeinicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_mensajeinicio.Click

    End Sub

    Private Sub ComprobarActualizacionesWiiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprobarActualizacionesWiiToolStripMenuItem.Click
        My.Computer.Network.DownloadFile _
            ("http://dl.dropbox.com/u/3565590/Softmodii/wiiversion.txt", _
             "wiiversion.txt", " ", " ", showUI:=True, connectionTimeout:=500, overwrite:=True)
        wiiversion = My.Computer.FileSystem.ReadAllText("wiiversion.txt")
        MsgBox(wiiversion)
    End Sub

    Private Sub TToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TToolStripMenuItem.Click
        frmVocabulario.Show()
    End Sub

    Private Sub WikiDeAplicacionesEOLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WikiDeAplicacionesEOLToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.elotrolado.net/wiki/Aplicaciones_Wii_nuevo")
    End Sub

    Private Sub PáginaEnGoogleCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PáginaEnGoogleCodeToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://code.google.com/p/softmodii-eol/")
    End Sub

    Private Sub menu_superior_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles menu_superior.ItemClicked

    End Sub
End Class



