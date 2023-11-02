Public Class Form1
    Private Sub Init()
        txt_NomUtilisateur.Clear()
        Txt_MotdePasse.Clear()

    End Sub

    Private Sub Btn_valider_Click(sender As Object, e As EventArgs) Handles Btn_valider.Click
        Dim nomutilisateur As String
        Dim motdepasse As String
        nomutilisateur = txt_NomUtilisateur.Text
        motdepasse = Txt_MotdePasse.Text
        If (nomutilisateur = "admin") And (motdepasse = "1234") Then
            Me.Hide()
            form2.Show()
        Else
            Init()

        End If
    End Sub

    Private Sub Btn_annuler_Click(sender As Object, e As EventArgs) Handles Btn_annuler.Click
        Init()
    End Sub
End Class
