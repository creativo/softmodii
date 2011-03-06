Imports System.Windows.Forms





Public Class frmSerial

    Public reg
    Public pass As Boolean
    Public tmpBoot2 As Boolean = False
    Public tmpdvd As Boolean
    Public bootdate As Boolean = False
    





    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_serial_aceptar.Click

        pass = True ' Controla el paso para que muestre o no los datos.

        If txtbox_serial.Text = "_________" Then
            MsgBox("Numero incorrecto")
        End If

        Val(txtbox_serial.Text) ' Paso a número el resultado de TextBox2


        If txtbox_serial.Text = 0 Then  'Si es 0, numero incorrecto.
            MsgBox("Numero incorrecto")
            pass = False 'No puede pasar
        End If


        If txtbox_serial.Text <= 99999999 Then  'Si es de 8 cifras o menor, número incorrecto.
            MsgBox("Numero incorrecto")
            pass = False 'No puede pasar
        End If


        Select Case combo_serial.SelectedIndex 'Primero compruebo que la selección de región sea correcta.
            Case 0
                reg = "eur"
            Case 1
                reg = "usa"
            Case 2
                reg = "negra"
            Case 3
                reg = "negra"
            Case 4
                reg = "negra"
            Case -1
                MsgBox("Por favor, completa todos los campos")

        End Select

        If reg = "usa" And pass = True Then 'Caso de región USf
            'compruebo DVD USA
            If txtbox_serial.Text <= 109999999 And txtbox_serial.Text >= 100000000 Then
                'LU10, casi 80% con nuevo lector. 'Compatibles con Boot2
                tmpdvd = False '
                tmpBoot2 = True



            ElseIf txtbox_serial.Text <= 399999999 And txtbox_serial.Text >= 110000000 Then
                'LU 11 hasta LU40, 50 % de posibilidades.. Boot2 mas adelante
                tmpdvd = True



            ElseIf txtbox_serial.Text >= 40000000 Then
                'Más de LU40, no puede DVD.
                tmpdvd = False

            End If

            'COMPRUEBO BOOT2 USA
            If txtbox_serial.Text >= 110000000 And txtbox_serial.Text <= 119999999 Then
                tmpBoot2 = False ' LU11-12, incomp.



            ElseIf txtbox_serial.Text >= 300000000 And txtbox_serial.Text <= 349999999 Then
                tmpBoot2 = True  'LU30-LU35, compat.


            ElseIf txtbox_serial.Text >= 350000000 And txtbox_serial.Text <= 390000000 Then
                tmpBoot2 = False 'LU35-LU40, incomp.


            ElseIf txtbox_serial.Text >= 500000000 And txtbox_serial.Text <= 579999999 Then
                tmpBoot2 = True 'LU50-LU58, comp.



            ElseIf txtbox_serial.Text >= 580000000 Then
                tmpBoot2 = False 'LU58-LU58+, incomp.


            End If
        End If




        'Comprobación de región EUR
        If reg = "eur" And pass = True Then

            ''COMPRUEBO EUR
            If txtbox_serial.Text <= 199999999 And txtbox_serial.Text >= 100000000 Then
                ' Si Serial es menor que LEH20, entonces es correcto.
                tmpBoot2 = True
                tmpdvd = True







            ElseIf txtbox_serial.Text >= 200000000 And txtbox_serial.Text < 280000000 And pass = True Then
                'Si serial está entre LEH20 Y 28, no se puede boot2.

                tmpBoot2 = False
                tmpdvd = True


            ElseIf txtbox_serial.Text >= 280000000 And pass = True Then
                ' Si serial es mayor que LEH28, no acepta DVD.

                tmpBoot2 = False
                tmpdvd = False


            End If
        End If


        If reg = "negra" And pass = True Then
            tmpBoot2 = False
            tmpdvd = False

        End If






        If pass = True Then
            'MUESTRA INFORMACIÓN DE LA CONSOLA

            If tmpBoot2 = True Then 'INFORMACIÓN DE BOOT2
                lbl_bootmii.Text = "IOS/Boot2"
            Else
                lbl_bootmii.Text = "Solo IOS"
            End If

            If tmpdvd = True Then 'INFORMACIÓN DE DVD
                lbl_carga_dvd.Text = "Sí"
            Else
                lbl_carga_dvd.Text = "No"
            End If


            If reg = "eur" Then 'INFORMACIÓN DE REGIÓN
                lbl_region.Text = "Europea"
            ElseIf reg = "usa" Then
                lbl_region.Text = "Americana"
            ElseIf reg = "negra" Then
                lbl_region.Text = "Europea"
            End If

            lbl_carga_usb.Text = "Sí" 'INFORMACIÓN DE USB (SIEMPRE ES SÍ)

            Softmodii.boot2 = tmpBoot2 'Pasa datos a variables
            Softmodii.cargadvd = tmpdvd
            'Preparando siguiente pregunta
            btn_dvd.Enabled = tmpdvd 'Activa o desactiva botones
            btn_usb.Enabled = True
            btn_serial_aceptar.Enabled = False
            combo_serial.Enabled = False
            txtbox_serial.Enabled = False
            box1.Enabled = False
            Box2.Enabled = True

        End If

        If pass = False Then

            pass = True

        End If






    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dvd.Click
        Softmodii.dvd = True
        Softmodii.usb = False

        btn_dvd.Enabled = False
        btn_usb.Enabled = False
        btn_finalizar.Enabled = False
        btn_version_aceptar.Enabled = True
        Box2.Enabled = False
        Box3.Enabled = True


    End Sub

    Private Sub USB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_usb.Click
        Softmodii.dvd = False
        Softmodii.usb = True
        btn_dvd.Enabled = False
        btn_usb.Enabled = False

        btn_version_aceptar.Enabled = True
        Box2.Enabled = False
        Box3.Enabled = True

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_finalizar.Click
        Softmodii.reg = reg


        If Softmodii.ver = "42" Then
            Softmodii.cargar_tuto("hbc42")
            Softmodii.proceso = "hbc"
        End If



        If Softmodii.ver < 42 And Softmodii.ver > 20 Then
            Softmodii.cargar_tuto("hbc41")
            Softmodii.proceso = "hbc"
        End If

        If Softmodii.ver = 43 Then
            frmExploit.Show()


        End If

        'Preparo todo para el inicio del tutorial

        Softmodii.btn_back.Enabled = False
        Softmodii.btn_next.Enabled = True
        Softmodii.btn_help.Enabled = True
        Softmodii.btn_save.Enabled = True
        Softmodii.btn_print.Enabled = True
        Softmodii.lbl_mensajeinicio.Visible = False
        Softmodii.exploit = "NULL"
        Softmodii.exploit_comprobar = False

        If Softmodii.ver = "20" Then
            Softmodii.lbl_titulo.Text = "No puedes continuar"
            Softmodii.cargar_tuto("reiniciar")
            Softmodii.txtbox_big.Text = My.Resources.tuto_error
        End If

        Me.Close()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_version_aceptar.Click
        Select Case lst_version.SelectedIndex 'Comprobar versión
            Case 0
                Softmodii.ver = "20"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False
            Case 1
                Softmodii.ver = "32"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False
            Case 2
                Softmodii.ver = "32"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False

            Case 3
                Softmodii.ver = "32"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False
            Case 4
                Softmodii.ver = "33"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False
            Case 5
                Softmodii.ver = "34"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False
            Case 6
                Softmodii.ver = "40"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False
            Case 7
                Softmodii.ver = "41"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False
            Case 8
                Softmodii.ver = "42"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False

            Case 9
                Softmodii.ver = "43"
                lst_version.Enabled = False
                btn_version_aceptar.Enabled = False
                btn_finalizar.Enabled = True
                Box3.Enabled = False

            Case -1
                MsgBox("Por favor, elige una versión")


        End Select
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_serial.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_version.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles box1.Enter

    End Sub

    Private Sub dlgSerial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
