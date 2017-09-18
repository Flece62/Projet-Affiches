<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.btnConnexion = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbPseudoGagnant = New System.Windows.Forms.Label()
        Me.lbDateMembre = New System.Windows.Forms.Label()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuPrincipale = New System.Windows.Forms.MenuStrip()
        Me.MenuPAccueil = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrersousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperçuavantimpressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPAffiaches = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPAdherents = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPContact = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuPrincipale.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnexion
        '
        Me.btnConnexion.Location = New System.Drawing.Point(661, 12)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(96, 29)
        Me.btnConnexion.TabIndex = 0
        Me.btnConnexion.Text = "btnConnexion"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(650, 65)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom du gagnant de la compétition ce mois ci"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nom du gagnant : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Note : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Membre depuis : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Description :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(436, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 150)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lbPseudoGagnant
        '
        Me.lbPseudoGagnant.AutoSize = True
        Me.lbPseudoGagnant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPseudoGagnant.Location = New System.Drawing.Point(165, 115)
        Me.lbPseudoGagnant.Name = "lbPseudoGagnant"
        Me.lbPseudoGagnant.Size = New System.Drawing.Size(122, 17)
        Me.lbPseudoGagnant.TabIndex = 9
        Me.lbPseudoGagnant.Text = "lbPseudoGagnant"
        '
        'lbDateMembre
        '
        Me.lbDateMembre.AutoSize = True
        Me.lbDateMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDateMembre.Location = New System.Drawing.Point(165, 167)
        Me.lbDateMembre.Name = "lbDateMembre"
        Me.lbDateMembre.Size = New System.Drawing.Size(100, 17)
        Me.lbDateMembre.TabIndex = 10
        Me.lbDateMembre.Text = "lbDateMembre"
        '
        'tbDescription
        '
        Me.tbDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescription.Location = New System.Drawing.Point(168, 193)
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.Size = New System.Drawing.Size(262, 72)
        Me.tbDescription.TabIndex = 11
        Me.tbDescription.Text = "tbDescription"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(13, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 220)
        Me.Panel1.TabIndex = 12
        '
        'MenuPrincipale
        '
        Me.MenuPrincipale.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuPrincipale.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuPrincipale.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPAccueil, Me.MenuPAffiaches, Me.MenuPAdherents, Me.MenuPContact})
        Me.MenuPrincipale.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipale.Name = "MenuPrincipale"
        Me.MenuPrincipale.Size = New System.Drawing.Size(812, 27)
        Me.MenuPrincipale.TabIndex = 13
        Me.MenuPrincipale.Text = "MenuStrip1"
        '
        'MenuPAccueil
        '
        Me.MenuPAccueil.Name = "MenuPAccueil"
        Me.MenuPAccueil.Size = New System.Drawing.Size(106, 23)
        Me.MenuPAccueil.Text = "MenuPAccueil"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Image = CType(resources.GetObject("NouveauToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Image = CType(resources.GetObject("OuvrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OuvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.OuvrirToolStripMenuItem.Text = "&Ouvrir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(202, 6)
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Image = CType(resources.GetObject("EnregistrerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EnregistrerToolStripMenuItem.Text = "&Enregistrer"
        '
        'EnregistrersousToolStripMenuItem
        '
        Me.EnregistrersousToolStripMenuItem.Name = "EnregistrersousToolStripMenuItem"
        Me.EnregistrersousToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EnregistrersousToolStripMenuItem.Text = "Enregistrer &sous"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.Image = CType(resources.GetObject("ImprimerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ImprimerToolStripMenuItem.Text = "&Imprimer"
        '
        'AperçuavantimpressionToolStripMenuItem
        '
        Me.AperçuavantimpressionToolStripMenuItem.Image = CType(resources.GetObject("AperçuavantimpressionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AperçuavantimpressionToolStripMenuItem.Name = "AperçuavantimpressionToolStripMenuItem"
        Me.AperçuavantimpressionToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(202, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'MenuPAffiaches
        '
        Me.MenuPAffiaches.Name = "MenuPAffiaches"
        Me.MenuPAffiaches.Size = New System.Drawing.Size(118, 23)
        Me.MenuPAffiaches.Text = "MenuPAffiaches"
        '
        'MenuPAdherents
        '
        Me.MenuPAdherents.Name = "MenuPAdherents"
        Me.MenuPAdherents.Size = New System.Drawing.Size(127, 23)
        Me.MenuPAdherents.Text = "MenuPAdherents"
        '
        'MenuPContact
        '
        Me.MenuPContact.Name = "MenuPContact"
        Me.MenuPContact.Size = New System.Drawing.Size(113, 23)
        Me.MenuPContact.Text = "MenuPContact"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 433)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.lbDateMembre)
        Me.Controls.Add(Me.lbPseudoGagnant)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.btnConnexion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuPrincipale)
        Me.MainMenuStrip = Me.MenuPrincipale
        Me.Name = "Accueil"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuPrincipale.ResumeLayout(False)
        Me.MenuPrincipale.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnexion As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbPseudoGagnant As Label
    Friend WithEvents lbDateMembre As Label
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuPrincipale As MenuStrip
    Friend WithEvents MenuPAccueil As ToolStripMenuItem
    Friend WithEvents MenuPAffiaches As ToolStripMenuItem
    Friend WithEvents MenuPAdherents As ToolStripMenuItem
    Friend WithEvents MenuPContact As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrersousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ImprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AperçuavantimpressionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
End Class
