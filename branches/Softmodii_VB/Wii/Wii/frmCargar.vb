Public Class frmCargar

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Softmodii.btn_next.Text = My.Settings.next1_text
        Softmodii.pic_imagenes.Image = My.Resources.cargado
        Softmodii.usb = My.Settings.usb
        If My.Settings.label3 = True Then
            Softmodii.lbl_mensajeinicio.Visible = True
        Else
            Softmodii.lbl_mensajeinicio.Visible = False
        End If
        Softmodii.btn_print.Enabled = True
        Softmodii.exploit = My.Settings.exploit
        Softmodii.ver = My.Settings.ver
        My.Settings.label3 = False
        Softmodii.dvd = My.Settings.dvd
        Softmodii.reg = My.Settings.reg
        Softmodii.btn_save.Enabled = True
        Softmodii.boot2 = My.Settings.boot2
        Softmodii.proceso = My.Settings.proceso
        Softmodii.lbl_titulo.Text = My.Settings.label1
        Softmodii.txtbox_big.LoadFile(My.Settings.tutoarchivo)
        MsgBox("Archivo cargado")
        If My.Settings.next1 = True Then
            Softmodii.btn_next.Enabled = True
        Else
            Softmodii.btn_next.Enabled = False
        End If
        If My.Settings.back1 = True Then
            Softmodii.btn_back.Enabled = True
        Else
            Softmodii.btn_back.Enabled = False
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class