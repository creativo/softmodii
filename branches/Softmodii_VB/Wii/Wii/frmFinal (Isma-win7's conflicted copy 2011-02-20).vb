Public Class frmFinal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        TextBox1.Text = "_----INFORME DE SOFTMODII " + Softmodii.inf_softmodii + "----_  Generado automáticamente el día " + DateString + " a las " + TimeOfDay _
        & Chr(13) & "                                           " & Chr(13) & "-cIOS de Waninkoko: " + Softmodii.inf_wanin_cios & Chr(13) & "            -cIOS Hermes: " + Softmodii.inf_hermes_cios & Chr(13) & "            -Homebrew Channel: " + Softmodii.inf_homebrew_channel + "            -Bootmii: " + Softmodii.inf_bootmii _
        & Chr(13) & "            -IOS36: " + Softmodii.inf_ios36 & Chr(13) & "            -CFG USB Loader: " + Softmodii.inf_cfg & Chr(13) & "            -uLoader: " + Softmodii.inf_uloader & Chr(13) & "            -Priiloader: " + Softmodii.inf_priiloader
        Softmodii.StringToPrint = TextBox1.Text

        Softmodii.prnDoc.Print()
        btncerrar.Visible = True
        lbl1.Visible = True
        btnImprimir.Enabled = False
        btnno.Enabled = False
        btncerrar.Visible = True

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnno.Click
        lbl1.Visible = True
        btnImprimir.Enabled = False
        btnno.Enabled = False
        btncerrar.Visible = True
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Softmodii.btnPrint.Enabled = False
        Softmodii.ver = "00"
        Softmodii.dvd = "false"
        Softmodii.usb = "false"
        Softmodii.proceso = "inicio"
        Softmodii.Back1.Enabled = False
        Softmodii.help.Enabled = False
        Softmodii.next1.Enabled = False

        Softmodii.Start.Enabled = True

        Softmodii.Label1.Text = "Has completado el tutorial"
        Softmodii.Label3.Visible = True
        Softmodii.TextBox1.LoadFile("data/fin.smi")
        Softmodii.Image1.Image = My.Resources.imageninicial
        Softmodii.Label3.Text = "Con Softmodii abrirás tu Wii " & Chr(13) & "al mundo del Homebrew y de" & Chr(13) & "la carga de backups fácilmente"
        Softmodii.changeimage1.Image = My.Resources.blanco
        Softmodii.changeimage2.Image = My.Resources.blanco
        Softmodii.changeimage3.Image = My.Resources.blanco
        Softmodii.btnsave.Enabled = False
        Softmodii.btnload.Enabled = True
        Me.Close()
    End Sub
End Class