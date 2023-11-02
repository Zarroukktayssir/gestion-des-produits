<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lbl_produit = New System.Windows.Forms.Label()
        Me.Lbl_prixU = New System.Windows.Forms.Label()
        Me.lbl_quantitè = New System.Windows.Forms.Label()
        Me.lbl_montantHT = New System.Windows.Forms.Label()
        Me.lst_produit = New System.Windows.Forms.ComboBox()
        Me.txt_PrixU = New System.Windows.Forms.TextBox()
        Me.txt_MontantHT = New System.Windows.Forms.TextBox()
        Me.Btn_ajouter = New System.Windows.Forms.Button()
        Me.Btn_supprimer = New System.Windows.Forms.Button()
        Me.Btn_vider = New System.Windows.Forms.Button()
        Me.Btn_calculer = New System.Windows.Forms.Button()
        Me.Btn_Quitter = New System.Windows.Forms.Button()
        Me.lst_FfProduit = New System.Windows.Forms.ListBox()
        Me.lst_FfPrixunitaire = New System.Windows.Forms.ListBox()
        Me.lst_FfQuantitè = New System.Windows.Forms.ListBox()
        Me.lst_Ffmontant = New System.Windows.Forms.ListBox()
        Me.lbl_TVA = New System.Windows.Forms.Label()
        Me.lbl_remise = New System.Windows.Forms.Label()
        Me.txt_TVA = New System.Windows.Forms.TextBox()
        Me.txt_remise = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_totalPU = New System.Windows.Forms.TextBox()
        Me.txt_totalQuantite = New System.Windows.Forms.TextBox()
        Me.txt_totalmontant = New System.Windows.Forms.TextBox()
        Me.txt_quantitè = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_modifier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_produit
        '
        Me.lbl_produit.AutoSize = True
        Me.lbl_produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produit.Location = New System.Drawing.Point(141, 30)
        Me.lbl_produit.Name = "lbl_produit"
        Me.lbl_produit.Size = New System.Drawing.Size(67, 20)
        Me.lbl_produit.TabIndex = 0
        Me.lbl_produit.Text = "produit"
        '
        'Lbl_prixU
        '
        Me.Lbl_prixU.AutoSize = True
        Me.Lbl_prixU.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_prixU.Location = New System.Drawing.Point(119, 78)
        Me.Lbl_prixU.Name = "Lbl_prixU"
        Me.Lbl_prixU.Size = New System.Drawing.Size(111, 20)
        Me.Lbl_prixU.TabIndex = 1
        Me.Lbl_prixU.Text = "Prix unitaire"
        '
        'lbl_quantitè
        '
        Me.lbl_quantitè.AutoSize = True
        Me.lbl_quantitè.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantitè.Location = New System.Drawing.Point(128, 121)
        Me.lbl_quantitè.Name = "lbl_quantitè"
        Me.lbl_quantitè.Size = New System.Drawing.Size(80, 20)
        Me.lbl_quantitè.TabIndex = 2
        Me.lbl_quantitè.Text = "Quantitè"
        '
        'lbl_montantHT
        '
        Me.lbl_montantHT.AutoSize = True
        Me.lbl_montantHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_montantHT.Location = New System.Drawing.Point(101, 169)
        Me.lbl_montantHT.Name = "lbl_montantHT"
        Me.lbl_montantHT.Size = New System.Drawing.Size(107, 20)
        Me.lbl_montantHT.TabIndex = 3
        Me.lbl_montantHT.Text = "Montant HT"
        '
        'lst_produit
        '
        Me.lst_produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_produit.FormattingEnabled = True
        Me.lst_produit.Items.AddRange(New Object() {"clavier", "souris", "imprimante", "ordinateur"})
        Me.lst_produit.Location = New System.Drawing.Point(242, 30)
        Me.lst_produit.Name = "lst_produit"
        Me.lst_produit.Size = New System.Drawing.Size(210, 24)
        Me.lst_produit.TabIndex = 4
        Me.lst_produit.Text = "choisir votre produit"
        '
        'txt_PrixU
        '
        Me.txt_PrixU.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrixU.Location = New System.Drawing.Point(242, 76)
        Me.txt_PrixU.Name = "txt_PrixU"
        Me.txt_PrixU.Size = New System.Drawing.Size(262, 22)
        Me.txt_PrixU.TabIndex = 5
        '
        'txt_MontantHT
        '
        Me.txt_MontantHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MontantHT.Location = New System.Drawing.Point(242, 167)
        Me.txt_MontantHT.Name = "txt_MontantHT"
        Me.txt_MontantHT.Size = New System.Drawing.Size(240, 22)
        Me.txt_MontantHT.TabIndex = 6
        '
        'Btn_ajouter
        '
        Me.Btn_ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ajouter.Location = New System.Drawing.Point(674, 65)
        Me.Btn_ajouter.Name = "Btn_ajouter"
        Me.Btn_ajouter.Size = New System.Drawing.Size(108, 23)
        Me.Btn_ajouter.TabIndex = 8
        Me.Btn_ajouter.Text = "Ajouter"
        Me.Btn_ajouter.UseVisualStyleBackColor = True
        '
        'Btn_supprimer
        '
        Me.Btn_supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_supprimer.Location = New System.Drawing.Point(674, 106)
        Me.Btn_supprimer.Name = "Btn_supprimer"
        Me.Btn_supprimer.Size = New System.Drawing.Size(118, 23)
        Me.Btn_supprimer.TabIndex = 9
        Me.Btn_supprimer.Text = "Supprimer"
        Me.Btn_supprimer.UseVisualStyleBackColor = True
        '
        'Btn_vider
        '
        Me.Btn_vider.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_vider.Location = New System.Drawing.Point(674, 145)
        Me.Btn_vider.Name = "Btn_vider"
        Me.Btn_vider.Size = New System.Drawing.Size(118, 23)
        Me.Btn_vider.TabIndex = 10
        Me.Btn_vider.Text = "Vide"
        Me.Btn_vider.UseVisualStyleBackColor = True
        '
        'Btn_calculer
        '
        Me.Btn_calculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_calculer.Location = New System.Drawing.Point(1165, 277)
        Me.Btn_calculer.Name = "Btn_calculer"
        Me.Btn_calculer.Size = New System.Drawing.Size(91, 23)
        Me.Btn_calculer.TabIndex = 11
        Me.Btn_calculer.Text = "Calculer"
        Me.Btn_calculer.UseVisualStyleBackColor = True
        '
        'Btn_Quitter
        '
        Me.Btn_Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Quitter.Location = New System.Drawing.Point(1156, 342)
        Me.Btn_Quitter.Name = "Btn_Quitter"
        Me.Btn_Quitter.Size = New System.Drawing.Size(100, 23)
        Me.Btn_Quitter.TabIndex = 12
        Me.Btn_Quitter.Text = "Quitter"
        Me.Btn_Quitter.UseVisualStyleBackColor = True
        '
        'lst_FfProduit
        '
        Me.lst_FfProduit.FormattingEnabled = True
        Me.lst_FfProduit.ItemHeight = 16
        Me.lst_FfProduit.Location = New System.Drawing.Point(132, 342)
        Me.lst_FfProduit.Name = "lst_FfProduit"
        Me.lst_FfProduit.Size = New System.Drawing.Size(120, 180)
        Me.lst_FfProduit.TabIndex = 13
        '
        'lst_FfPrixunitaire
        '
        Me.lst_FfPrixunitaire.FormattingEnabled = True
        Me.lst_FfPrixunitaire.ItemHeight = 16
        Me.lst_FfPrixunitaire.Location = New System.Drawing.Point(374, 342)
        Me.lst_FfPrixunitaire.Name = "lst_FfPrixunitaire"
        Me.lst_FfPrixunitaire.Size = New System.Drawing.Size(120, 180)
        Me.lst_FfPrixunitaire.TabIndex = 14
        '
        'lst_FfQuantitè
        '
        Me.lst_FfQuantitè.FormattingEnabled = True
        Me.lst_FfQuantitè.ItemHeight = 16
        Me.lst_FfQuantitè.Location = New System.Drawing.Point(612, 342)
        Me.lst_FfQuantitè.Name = "lst_FfQuantitè"
        Me.lst_FfQuantitè.Size = New System.Drawing.Size(120, 180)
        Me.lst_FfQuantitè.TabIndex = 15
        '
        'lst_Ffmontant
        '
        Me.lst_Ffmontant.FormattingEnabled = True
        Me.lst_Ffmontant.ItemHeight = 16
        Me.lst_Ffmontant.Location = New System.Drawing.Point(785, 342)
        Me.lst_Ffmontant.Name = "lst_Ffmontant"
        Me.lst_Ffmontant.Size = New System.Drawing.Size(120, 180)
        Me.lst_Ffmontant.TabIndex = 16
        '
        'lbl_TVA
        '
        Me.lbl_TVA.AutoSize = True
        Me.lbl_TVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TVA.Location = New System.Drawing.Point(318, 578)
        Me.lbl_TVA.Name = "lbl_TVA"
        Me.lbl_TVA.Size = New System.Drawing.Size(88, 16)
        Me.lbl_TVA.TabIndex = 17
        Me.lbl_TVA.Text = "TVA (20%) :"
        '
        'lbl_remise
        '
        Me.lbl_remise.AutoSize = True
        Me.lbl_remise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_remise.Location = New System.Drawing.Point(318, 627)
        Me.lbl_remise.Name = "lbl_remise"
        Me.lbl_remise.Size = New System.Drawing.Size(75, 18)
        Me.lbl_remise.TabIndex = 18
        Me.lbl_remise.Text = "Remise :"
        '
        'txt_TVA
        '
        Me.txt_TVA.Location = New System.Drawing.Point(416, 575)
        Me.txt_TVA.Name = "txt_TVA"
        Me.txt_TVA.Size = New System.Drawing.Size(387, 22)
        Me.txt_TVA.TabIndex = 19
        '
        'txt_remise
        '
        Me.txt_remise.Location = New System.Drawing.Point(416, 627)
        Me.txt_remise.Name = "txt_remise"
        Me.txt_remise.Size = New System.Drawing.Size(387, 22)
        Me.txt_remise.TabIndex = 20
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(187, 539)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(63, 20)
        Me.lbl_total.TabIndex = 21
        Me.lbl_total.Text = "Total :"
        '
        'txt_totalPU
        '
        Me.txt_totalPU.Location = New System.Drawing.Point(382, 537)
        Me.txt_totalPU.Name = "txt_totalPU"
        Me.txt_totalPU.Size = New System.Drawing.Size(100, 22)
        Me.txt_totalPU.TabIndex = 22
        '
        'txt_totalQuantite
        '
        Me.txt_totalQuantite.Location = New System.Drawing.Point(612, 537)
        Me.txt_totalQuantite.Name = "txt_totalQuantite"
        Me.txt_totalQuantite.Size = New System.Drawing.Size(100, 22)
        Me.txt_totalQuantite.TabIndex = 23
        '
        'txt_totalmontant
        '
        Me.txt_totalmontant.Location = New System.Drawing.Point(785, 537)
        Me.txt_totalmontant.Name = "txt_totalmontant"
        Me.txt_totalmontant.Size = New System.Drawing.Size(100, 22)
        Me.txt_totalmontant.TabIndex = 24
        '
        'txt_quantitè
        '
        Me.txt_quantitè.Location = New System.Drawing.Point(242, 121)
        Me.txt_quantitè.Name = "txt_quantitè"
        Me.txt_quantitè.Size = New System.Drawing.Size(262, 22)
        Me.txt_quantitè.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "produit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(383, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Prix unitaire"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(632, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Quantitè"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(798, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Montant HT"
        '
        'Btn_modifier
        '
        Me.Btn_modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_modifier.Location = New System.Drawing.Point(1156, 399)
        Me.Btn_modifier.Name = "Btn_modifier"
        Me.Btn_modifier.Size = New System.Drawing.Size(118, 23)
        Me.Btn_modifier.TabIndex = 30
        Me.Btn_modifier.Text = "Modifier"
        Me.Btn_modifier.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1268, 691)
        Me.Controls.Add(Me.Btn_modifier)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_quantitè)
        Me.Controls.Add(Me.txt_totalmontant)
        Me.Controls.Add(Me.txt_totalQuantite)
        Me.Controls.Add(Me.txt_totalPU)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_remise)
        Me.Controls.Add(Me.txt_TVA)
        Me.Controls.Add(Me.lbl_remise)
        Me.Controls.Add(Me.lbl_TVA)
        Me.Controls.Add(Me.lst_Ffmontant)
        Me.Controls.Add(Me.lst_FfQuantitè)
        Me.Controls.Add(Me.lst_FfPrixunitaire)
        Me.Controls.Add(Me.lst_FfProduit)
        Me.Controls.Add(Me.Btn_Quitter)
        Me.Controls.Add(Me.Btn_calculer)
        Me.Controls.Add(Me.Btn_vider)
        Me.Controls.Add(Me.Btn_supprimer)
        Me.Controls.Add(Me.Btn_ajouter)
        Me.Controls.Add(Me.txt_MontantHT)
        Me.Controls.Add(Me.txt_PrixU)
        Me.Controls.Add(Me.lst_produit)
        Me.Controls.Add(Me.lbl_montantHT)
        Me.Controls.Add(Me.lbl_quantitè)
        Me.Controls.Add(Me.Lbl_prixU)
        Me.Controls.Add(Me.lbl_produit)
        Me.Name = "Form2"
        Me.Text = "frm_gestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_produit As Label
    Friend WithEvents Lbl_prixU As Label
    Friend WithEvents lbl_quantitè As Label
    Friend WithEvents lbl_montantHT As Label
    Friend WithEvents lst_produit As ComboBox
    Friend WithEvents txt_PrixU As TextBox
    Friend WithEvents txt_MontantHT As TextBox
    Friend WithEvents Btn_ajouter As Button
    Friend WithEvents Btn_supprimer As Button
    Friend WithEvents Btn_vider As Button
    Friend WithEvents Btn_calculer As Button
    Friend WithEvents Btn_Quitter As Button
    Friend WithEvents lst_FfProduit As ListBox
    Friend WithEvents lst_FfPrixunitaire As ListBox
    Friend WithEvents lst_FfQuantitè As ListBox
    Friend WithEvents lst_Ffmontant As ListBox
    Friend WithEvents lbl_TVA As Label
    Friend WithEvents lbl_remise As Label
    Friend WithEvents txt_TVA As TextBox
    Friend WithEvents txt_remise As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_totalPU As TextBox
    Friend WithEvents txt_totalQuantite As TextBox
    Friend WithEvents txt_totalmontant As TextBox
    Friend WithEvents txt_quantitè As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_modifier As Button
End Class
