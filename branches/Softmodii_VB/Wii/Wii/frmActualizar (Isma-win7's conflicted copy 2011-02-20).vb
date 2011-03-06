Public Class frmActualizar

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Softmodii.uponline = True
        Softmodii.Label1.Text = "Actualizando online"
        Softmodii.TextBox1.LoadFile("data\pimpmywii.smi")
        Softmodii.menu_cboot2.Enabled = False
        Softmodii.Menu_normal.Enabled = False
        Softmodii.proceso = "uponline"

        Me.Close()
        Softmodii.Back1.Enabled = False
        Softmodii.next1.Enabled = False
        Softmodii.Start.Enabled = True
        Softmodii.Label3.Visible = True
        Softmodii.Label3.Text = "Actualizando tu Wii de forma segura" & Chr(13) & "evitarás que se borre el HBC" & Chr(13) & "y demás aplicaciones." & Chr(13) & "    "
        Softmodii.csd.Enabled = False
        Softmodii.Image1.Image = My.Resources.update
    End Sub

  
End Class