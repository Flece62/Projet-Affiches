Public Class Connexion
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuPAccueil.Text = "Accueil"
        MenuPAffiaches.Text = "Les affiches"
        MenuPAdherents.Text = "Les adhérents"
        MenuPContact.Text = "Contact"
        MenuPMonCompte.Text = "Mon compte"
        MenuPMonProfil.Text = "Mon profil"
        MenuPEmprunt.Text = "Demande d'emprunt"
        MenuPNotes.Text = "Mes notes attribués"
        MenuPAffiches2.Text = "Mes affiches"
        Button1.Text = "S'inscrire"
        Button2.Text = "Se connecter"s
        Button3.Text = "Se connecter avec Facebook"
        CheckBox1.Text = "Rester connecté"
    End Sub

End Class