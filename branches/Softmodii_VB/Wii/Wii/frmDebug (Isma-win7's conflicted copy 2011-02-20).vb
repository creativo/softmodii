Public Class frmDebug

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Softmodii.reg = "negra"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Softmodii.ver = "42"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Softmodii.ver = "41"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Softmodii.ver = "40"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Softmodii.ver = "34"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Softmodii.ver = "33"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Softmodii.ver = "32"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Softmodii.boot2 = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Softmodii.boot2 = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Softmodii.reg = "eur"
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Softmodii.reg = "usa"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Softmodii.dvd = True
        Softmodii.usb = False
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Softmodii.dvd = False
        Softmodii.usb = True
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back1.Click
        If Softmodii.Back1.Enabled = True Then
            Softmodii.Back1.Enabled = False
        Else
            Softmodii.Back1.Enabled = True
        End If
    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Softmodii.Back1.Enabled = False
        Softmodii.next1.Enabled = True
        Softmodii.btnPrint.Enabled = True
        Softmodii.help.Enabled = True
        Softmodii.proceso = "hbc"
        Softmodii.boot2 = True
        Softmodii.ver = 42
        Softmodii.TextBox1.LoadFile("data\hbc42.smi")
        Softmodii.usb = True
        Softmodii.dvd = False
        Softmodii.Label3.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.Text = Softmodii.proceso
        TextBox2.Text = Softmodii.ver
        If Softmodii.boot2 = True Then
            TextBox3.Text = "Boot2"
        Else : TextBox3.Text = "IOS"
        End If
        If Softmodii.dvd = True Then
            TextBox4.Text = "DVD"
        ElseIf Softmodii.usb = True Then
            TextBox4.Text = "USB"
        End If
       
        If Softmodii.Back1.Enabled = True Then


            back1.BackColor = Color.GreenYellow
        ElseIf Softmodii.Back1.Enabled = False Then
            back1.BackColor = Color.Red
        End If

        If Softmodii.next1.Enabled = True Then


            next1.BackColor = Color.GreenYellow
        ElseIf Softmodii.next1.Enabled = False Then
            next1.BackColor = Color.Red
        End If

        If Softmodii.ver = 43 Then
            TextBox5.Text = Softmodii.exploit
        Else
            TextBox5.Text = "NULL"

        End If
        lblinfo1.Text = Softmodii.version
        lblinfo2.Text = Softmodii.csd_version




    End Sub

    Private Sub Button9_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next1.Click
        If Softmodii.next1.Enabled = True Then
            Softmodii.next1.Enabled = False
        Else
            Softmodii.next1.Enabled = True
        End If
    End Sub

    Private Sub Button9_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Softmodii.ver = "43"
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Softmodii.ver = 43 Then
            Softmodii.exploit = "lego"
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If Softmodii.ver = 43 Then
            Softmodii.exploit = "ssbb"
        End If
    End Sub
End Class