Public Class Form2
    Private Sub Lst_produit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_produit.SelectedIndexChanged
        If lst_produit.SelectedIndex = -1 Then
            MsgBox("erreur")
        ElseIf (lst_produit.SelectedIndex = 0) Then
            txt_PrixU.Text = 30
        ElseIf (lst_produit.SelectedIndex = 1) Then
            txt_PrixU.Text = 15
        ElseIf (lst_produit.SelectedIndex = 2) Then
            txt_PrixU.Text = 500
        Else
            txt_PrixU.Text = 1000
        End If
    End Sub

    Private Sub Btn_vider_Click(sender As Object, e As EventArgs) Handles Btn_vider.Click
        txt_PrixU.Clear()
        txt_quantitè.Clear()
        txt_MontantHT.Clear()

    End Sub

    Private Sub Btn_Quitter_Click(sender As Object, e As EventArgs) Handles Btn_Quitter.Click
        Me.Close()
    End Sub







    Private Sub Btn_supprimer_Click(sender As Object, e As EventArgs) Handles Btn_supprimer.Click
        If lst_FfProduit.SelectedIndex >= 0 Then
            Dim A As Integer = lst_FfProduit.SelectedIndex
            lst_FfProduit.Items.RemoveAt(A)
            lst_FfPrixunitaire.Items.RemoveAt(A)
            lst_Ffmontant.Items.Remove(A)
            lst_FfQuantitè.Items.RemoveAt(A)
        End If



    End Sub

    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles Btn_ajouter.Click
        Dim prixUnitaire As Integer
        Dim quantite As Integer


        Integer.TryParse(txt_PrixU.Text, prixUnitaire)
        Integer.TryParse(txt_quantitè.Text, quantite)


        Dim montant As Integer = prixUnitaire * quantite
        txt_MontantHT.Text = montant.ToString()


        lst_FfProduit.Items.Add(lst_produit.SelectedItem)
        lst_FfQuantitè.Items.Add(quantite)
        lst_Ffmontant.Items.Add(montant)
        lst_FfPrixunitaire.Items.Add(prixUnitaire)
    End Sub

    Private Sub Btn_calculer_Click(sender As Object, e As EventArgs) Handles Btn_calculer.Click
        Dim X As Integer = 0
        Dim X1 As Integer = 0
        Dim X2 As Integer = 0
        Dim tva As Double
        For Each item As Integer In lst_FfPrixunitaire.Items
            X1 += item

        Next
        txt_PrixU.Text = X1
        For Each item As Integer In lst_Ffmontant.Items
            X2 += item
        Next
        txt_quantitè.Text = X1
        For Each item As Integer In lst_FfQuantitè.Items
            X2 += item


        Next
        txt_MontantHT.Text = X2
        tva = (X2) * 0.2
        txt_TVA.Text = X2 + tva.ToString()
        If (txt_TVA.Text > 1000) Then
            txt_remise.Text = (X2) * 0.01
        Else
            txt_remise.Text = " le remise n'est pas validè "
        End If
    End Sub
End Class