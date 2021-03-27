<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fenetreOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBoxTailleTaquin = New System.Windows.Forms.GroupBox()
        Me.taille66 = New System.Windows.Forms.RadioButton()
        Me.taille44 = New System.Windows.Forms.RadioButton()
        Me.GroupBoxOptionsJeu = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownTemps = New System.Windows.Forms.NumericUpDown()
        Me.optTempsLimite = New System.Windows.Forms.CheckBox()
        Me.optBoutonPause = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSauvegarder = New System.Windows.Forms.GroupBox()
        Me.pathToFileText = New System.Windows.Forms.Label()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnFileDialog = New System.Windows.Forms.Button()
        Me.labelEmplacementFichier = New System.Windows.Forms.Label()
        Me.SaveFileDialogJoueurs = New System.Windows.Forms.SaveFileDialog()
        Me.btDefault = New System.Windows.Forms.Button()
        Me.btValider = New System.Windows.Forms.Button()
        Me.GroupBoxTailleTaquin.SuspendLayout()
        Me.GroupBoxOptionsJeu.SuspendLayout()
        CType(Me.NumericUpDownTemps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSauvegarder.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxTailleTaquin
        '
        Me.GroupBoxTailleTaquin.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBoxTailleTaquin.Controls.Add(Me.taille66)
        Me.GroupBoxTailleTaquin.Controls.Add(Me.taille44)
        Me.GroupBoxTailleTaquin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxTailleTaquin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupBoxTailleTaquin.Location = New System.Drawing.Point(20, 24)
        Me.GroupBoxTailleTaquin.Name = "GroupBoxTailleTaquin"
        Me.GroupBoxTailleTaquin.Size = New System.Drawing.Size(94, 100)
        Me.GroupBoxTailleTaquin.TabIndex = 0
        Me.GroupBoxTailleTaquin.TabStop = False
        Me.GroupBoxTailleTaquin.Text = "Taille"
        '
        'taille66
        '
        Me.taille66.AutoSize = True
        Me.taille66.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.taille66.Location = New System.Drawing.Point(17, 59)
        Me.taille66.Name = "taille66"
        Me.taille66.Size = New System.Drawing.Size(47, 17)
        Me.taille66.TabIndex = 1
        Me.taille66.TabStop = True
        Me.taille66.Text = "6 x 6"
        Me.taille66.UseVisualStyleBackColor = True
        '
        'taille44
        '
        Me.taille44.AutoSize = True
        Me.taille44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.taille44.Location = New System.Drawing.Point(17, 36)
        Me.taille44.Name = "taille44"
        Me.taille44.Size = New System.Drawing.Size(47, 17)
        Me.taille44.TabIndex = 0
        Me.taille44.TabStop = True
        Me.taille44.Text = "4 x 4"
        Me.taille44.UseVisualStyleBackColor = False
        '
        'GroupBoxOptionsJeu
        '
        Me.GroupBoxOptionsJeu.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBoxOptionsJeu.Controls.Add(Me.NumericUpDownTemps)
        Me.GroupBoxOptionsJeu.Controls.Add(Me.optTempsLimite)
        Me.GroupBoxOptionsJeu.Controls.Add(Me.optBoutonPause)
        Me.GroupBoxOptionsJeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxOptionsJeu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupBoxOptionsJeu.Location = New System.Drawing.Point(157, 24)
        Me.GroupBoxOptionsJeu.Name = "GroupBoxOptionsJeu"
        Me.GroupBoxOptionsJeu.Size = New System.Drawing.Size(145, 115)
        Me.GroupBoxOptionsJeu.TabIndex = 1
        Me.GroupBoxOptionsJeu.TabStop = False
        Me.GroupBoxOptionsJeu.Text = "Options de jeu"
        '
        'NumericUpDownTemps
        '
        Me.NumericUpDownTemps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDownTemps.Enabled = False
        Me.NumericUpDownTemps.Location = New System.Drawing.Point(17, 83)
        Me.NumericUpDownTemps.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.NumericUpDownTemps.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownTemps.Name = "NumericUpDownTemps"
        Me.NumericUpDownTemps.Size = New System.Drawing.Size(84, 20)
        Me.NumericUpDownTemps.TabIndex = 3
        Me.NumericUpDownTemps.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'optTempsLimite
        '
        Me.optTempsLimite.AutoSize = True
        Me.optTempsLimite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optTempsLimite.Location = New System.Drawing.Point(17, 56)
        Me.optTempsLimite.Name = "optTempsLimite"
        Me.optTempsLimite.Size = New System.Drawing.Size(81, 17)
        Me.optTempsLimite.TabIndex = 1
        Me.optTempsLimite.Text = "Temps limité"
        Me.optTempsLimite.UseVisualStyleBackColor = True
        '
        'optBoutonPause
        '
        Me.optBoutonPause.AutoSize = True
        Me.optBoutonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optBoutonPause.Location = New System.Drawing.Point(17, 29)
        Me.optBoutonPause.Name = "optBoutonPause"
        Me.optBoutonPause.Size = New System.Drawing.Size(89, 17)
        Me.optBoutonPause.TabIndex = 0
        Me.optBoutonPause.Text = "Bouton pause"
        Me.optBoutonPause.UseVisualStyleBackColor = True
        '
        'GroupBoxSauvegarder
        '
        Me.GroupBoxSauvegarder.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBoxSauvegarder.Controls.Add(Me.pathToFileText)
        Me.GroupBoxSauvegarder.Controls.Add(Me.btnSauvegarder)
        Me.GroupBoxSauvegarder.Controls.Add(Me.btnFileDialog)
        Me.GroupBoxSauvegarder.Controls.Add(Me.labelEmplacementFichier)
        Me.GroupBoxSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxSauvegarder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GroupBoxSauvegarder.Location = New System.Drawing.Point(20, 164)
        Me.GroupBoxSauvegarder.Name = "GroupBoxSauvegarder"
        Me.GroupBoxSauvegarder.Size = New System.Drawing.Size(370, 113)
        Me.GroupBoxSauvegarder.TabIndex = 2
        Me.GroupBoxSauvegarder.TabStop = False
        Me.GroupBoxSauvegarder.Text = "Sauvegarder scores"
        '
        'pathToFileText
        '
        Me.pathToFileText.AutoSize = True
        Me.pathToFileText.Location = New System.Drawing.Point(84, 33)
        Me.pathToFileText.Name = "pathToFileText"
        Me.pathToFileText.Size = New System.Drawing.Size(53, 13)
        Me.pathToFileText.TabIndex = 3
        Me.pathToFileText.Text = "non defini"
        '
        'btnSauvegarder
        '
        Me.btnSauvegarder.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSauvegarder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSauvegarder.ForeColor = System.Drawing.Color.Black
        Me.btnSauvegarder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSauvegarder.Location = New System.Drawing.Point(11, 74)
        Me.btnSauvegarder.Name = "btnSauvegarder"
        Me.btnSauvegarder.Size = New System.Drawing.Size(91, 27)
        Me.btnSauvegarder.TabIndex = 2
        Me.btnSauvegarder.Text = "Sauvegarder"
        Me.btnSauvegarder.UseVisualStyleBackColor = False
        '
        'btnFileDialog
        '
        Me.btnFileDialog.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnFileDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFileDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileDialog.ForeColor = System.Drawing.Color.Black
        Me.btnFileDialog.Location = New System.Drawing.Point(124, 74)
        Me.btnFileDialog.Name = "btnFileDialog"
        Me.btnFileDialog.Size = New System.Drawing.Size(139, 27)
        Me.btnFileDialog.TabIndex = 1
        Me.btnFileDialog.Text = "Choisir emplacement..."
        Me.btnFileDialog.UseVisualStyleBackColor = False
        '
        'labelEmplacementFichier
        '
        Me.labelEmplacementFichier.AutoSize = True
        Me.labelEmplacementFichier.Location = New System.Drawing.Point(8, 33)
        Me.labelEmplacementFichier.Name = "labelEmplacementFichier"
        Me.labelEmplacementFichier.Size = New System.Drawing.Size(77, 13)
        Me.labelEmplacementFichier.TabIndex = 0
        Me.labelEmplacementFichier.Text = "Emplacement :"
        '
        'btDefault
        '
        Me.btDefault.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDefault.Location = New System.Drawing.Point(196, 303)
        Me.btDefault.Name = "btDefault"
        Me.btDefault.Size = New System.Drawing.Size(106, 34)
        Me.btDefault.TabIndex = 4
        Me.btDefault.Text = "options par défaut"
        Me.btDefault.UseVisualStyleBackColor = False
        '
        'btValider
        '
        Me.btValider.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btValider.Location = New System.Drawing.Point(96, 303)
        Me.btValider.Name = "btValider"
        Me.btValider.Size = New System.Drawing.Size(94, 34)
        Me.btValider.TabIndex = 5
        Me.btValider.Text = "Valider"
        Me.btValider.UseVisualStyleBackColor = False
        '
        'fenetreOptions
        '
        Me.AcceptButton = Me.btValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(411, 354)
        Me.Controls.Add(Me.btValider)
        Me.Controls.Add(Me.btDefault)
        Me.Controls.Add(Me.GroupBoxSauvegarder)
        Me.Controls.Add(Me.GroupBoxOptionsJeu)
        Me.Controls.Add(Me.GroupBoxTailleTaquin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "fenetreOptions"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "O P T I O N S"
        Me.GroupBoxTailleTaquin.ResumeLayout(False)
        Me.GroupBoxTailleTaquin.PerformLayout()
        Me.GroupBoxOptionsJeu.ResumeLayout(False)
        Me.GroupBoxOptionsJeu.PerformLayout()
        CType(Me.NumericUpDownTemps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSauvegarder.ResumeLayout(False)
        Me.GroupBoxSauvegarder.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxTailleTaquin As GroupBox
    Friend WithEvents taille66 As RadioButton
    Friend WithEvents taille44 As RadioButton
    Friend WithEvents GroupBoxOptionsJeu As GroupBox
    Friend WithEvents optBoutonPause As CheckBox
    Friend WithEvents GroupBoxSauvegarder As GroupBox
    Friend WithEvents pathToFileText As Label
    Friend WithEvents btnSauvegarder As Button
    Friend WithEvents btnFileDialog As Button
    Friend WithEvents labelEmplacementFichier As Label
    Friend WithEvents optTempsLimite As CheckBox
    Friend WithEvents NumericUpDownTemps As NumericUpDown
    Friend WithEvents SaveFileDialogJoueurs As SaveFileDialog
    Friend WithEvents btDefault As Button
    Friend WithEvents btValider As Button
End Class
