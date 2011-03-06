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
        Softmodii.cargar_tuto("reiniciar")
        Softmodii.lbl_titulo.Text = "Has completado el tutorial"
        Softmodii.txtbox_big.LoadFile("data/fin.smi")
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class