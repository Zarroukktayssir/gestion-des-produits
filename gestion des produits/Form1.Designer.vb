<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_NomUtilisateur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_MotdePasse = New System.Windows.Forms.TextBox()
        Me.Btn_valider = New System.Windows.Forms.Button()
        Me.Btn_annuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom Utilisateur"
        '
        'txt_NomUtilisateur
        '
        Me.txt_NomUtilisateur.Location = New System.Drawing.Point(253, 99)
        Me.txt_NomUtilisateur.Name = "txt_NomUtilisateur"
        Me.txt_NomUtilisateur.Size = New System.Drawing.Size(335, 22)
        Me.txt_NomUtilisateur.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mot de Passe"
        '
        'Txt_MotdePasse
        '
        Me.Txt_MotdePasse.Location = New System.Drawing.Point(237, 158)
        Me.Txt_MotdePasse.Name = "Txt_MotdePasse"
        Me.Txt_MotdePasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_MotdePasse.Size = New System.Drawing.Size(374, 22)
        Me.Txt_MotdePasse.TabIndex = 3
        '
        'Btn_valider
        '
        Me.Btn_valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_valider.Location = New System.Drawing.Point(439, 236)
        Me.Btn_valider.Name = "Btn_valider"
        Me.Btn_valider.Size = New System.Drawing.Size(188, 46)
        Me.Btn_valider.TabIndex = 4
        Me.Btn_valider.Text = "Valider"
        Me.Btn_valider.UseVisualStyleBackColor = True
        '
        'Btn_annuler
        '
        Me.Btn_annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_annuler.Location = New System.Drawing.Point(132, 236)
        Me.Btn_annuler.Name = "Btn_annuler"
        Me.Btn_annuler.Size = New System.Drawing.Size(195, 46)
        Me.Btn_annuler.TabIndex = 5
        Me.Btn_annuler.Text = "Annuler"
        Me.Btn_annuler.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.Btn_annuler)
        Me.Controls.Add(Me.Btn_valider)
        Me.Controls.Add(Me.Txt_MotdePasse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_NomUtilisateur)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_NomUtilisateur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_MotdePasse As TextBox
    Friend WithEvents Btn_valider As Button
    Friend WithEvents Btn_annuler As Button
End Class
