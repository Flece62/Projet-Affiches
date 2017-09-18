Public Class Connexion
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuPAccueil.Text = "Accueil"
        MenuPAffiaches.Text = "Les affiches"
        MenuPAdherents.Text = "Les adhérents"
        MenuPContact.Text = "Contact"
        MenuPMonCompte.Text = "Mon compte"
        Button1.Text = "S'inscrire"
        Button2.Text = "Se connecter"
        Button3.Text = "Se connecter avec Facebook"
        CheckBox1.Text = "Rester connecté"
    End Sub

End Class