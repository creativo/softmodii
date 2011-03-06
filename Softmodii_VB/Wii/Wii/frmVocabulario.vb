Public Class frmVocabulario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case ListBox1.SelectedIndex 'Primero compruebo que la selección de región sea correcta.
            Case 0
                TextBox1.Text = My.Resources.def_ios
            Case 1
                TextBox1.Text = My.Resources.def_cios
            Case 2
                TextBox1.Text = My.Resources.def_cmios
            Case 3
                TextBox1.Text = My.Resources.def_wad
            Case 4
                TextBox1.Text = My.Resources.def_boot2
            Case 5
                TextBox1.Text = My.Resources.def_systemmenu
            Case 6
                TextBox1.Text = My.Resources.def_usbloader
            Case 7
                TextBox1.Text = My.Resources.def_brick
            Case -1


        End Select
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class