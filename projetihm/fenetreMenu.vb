Imports System.ComponentModel

Public Class fenetreMenu

    'Gère les clics sur le bouton Quitter
    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        If MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Quitter") = MsgBoxResult.Yes Then

            Application.Exit()
        End If
    End Sub


    'Charge la fenetre de Scores quand le bouton Scores est appuyé
    Private Sub BtnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        fenetreScores.chargerStatistiques()
        changerDeFenetre(Me, fenetreScores)
    End Sub


    'Gère les clics du bouton Jouer
    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        fenetreJeu.reinitJeu()
        changerDeFenetre(Me, fenetreJeu)
    End Sub


    'Gère les clics du bouton Options
    Private Sub BtnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        changerDeFenetre(Me, fenetreOptions)
    End Sub


    'Gère les clics sur le bouton X (fermeture de la fenêtre)
    Private Sub fenetreMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True

        If MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Quitter") = MsgBoxResult.Yes Then

            Application.Exit()
        End If
    End Sub


    'Contrôle le contenu de la comboBox (Empecher de taper des chiffress, etc..)
    Private Sub ComboBoxNomJoueur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNomJoueur.KeyPress

        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    'Met la première lettre du nom en majuscule dans la comboBox
    Private Sub ComboBoxNomJoueur_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxNomJoueur.LostFocus
        ComboBoxNomJoueur.Text = StrConv(ComboBoxNomJoueur.Text, VbStrConv.ProperCase)
    End Sub


    'Active/Désactive le bouton Jouer en fonction de la comboBox
    Private Sub ComboBoxNomJoueur_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboBoxNomJoueur.KeyUp

        If ComboBoxNomJoueur.Text = "" Then
            btnJouer.Enabled = False
        Else
            btnJouer.Enabled = True
        End If
    End Sub


    'Active le bouton Jouer si le joueur selectionne son nom dans la comboBox
    Private Sub ComboBoxNomJoueur_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxNomJoueur.SelectedValueChanged
        If Not ComboBoxNomJoueur.Text = "" Then
            btnJouer.Enabled = True
        End If
    End Sub


    ' Charge les données de jeu sauvegardées si elles existent
    Private Sub fenetreMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        chargerDonneesSauvegardees()
    End Sub
End Class
