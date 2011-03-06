Public Class frmGuardar

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.cabecera = TextBox1.Text
        If TextBox1.Text = "asd" Then
            MsgBox("4 8 15 16 23 42")
        ElseIf TextBox1.Text = "pirateo" Then
            MsgBox("Softmodii no da soporte a la piratería, solo a la carga de copias de seguridad propias.")
        ElseIf TextBox1.Text = "piratear" Then
            MsgBox("Softmodii no da soporte a la piratería, solo a la carga de copias de seguridad propias.")
        ElseIf TextBox1.Text = "softmodii" Then
            MsgBox("Así me llaman!")
        ElseIf TextBox1.Text = "lost" Then
            MsgBox("DHARMA: We are the others")
        End If

        My.Settings.next1_text = Softmodii.btn_next.Text
        If Softmodii.lbl_mensajeinicio.Visible = True Then
            My.Settings.label3 = True
        Else
            My.Settings.label3 = False
        End If
        My.Settings.tutoarchivo = Softmodii.tutoarchivo
        My.Settings.exploit = Softmodii.exploit
        My.Settings.ver = Softmodii.ver
        My.Settings.proceso = Softmodii.proceso
        My.Settings.dvd = Softmodii.dvd
        My.Settings.reg = Softmodii.reg
        My.Settings.usb = Softmodii.usb
        My.Settings.boot2 = Softmodii.boot2
        My.Settings.label1 = Softmodii.lbl_titulo.Text
        If Softmodii.btn_back.Enabled = True Then
            My.Settings.back1 = True
        Else
            My.Settings.back1 = False
        End If
        If Softmodii.btn_next.Enabled = True Then
            My.Settings.next1 = True
        ElseIf Softmodii.btn_next.Enabled = False Then
            My.Settings.next1 = False
        End If
        MsgBox("Tutorial guardado")
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmGuardar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class