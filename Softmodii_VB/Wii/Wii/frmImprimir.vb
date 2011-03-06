Public Class frmImprimir

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        Softmodii.StringToPrint = Softmodii.txtbox_big.Text

        Softmodii.prnDoc.Print()
    End Sub

    Private Sub Label1_Text(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_print.TextChanged

    End Sub

    Private Sub frmImprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class