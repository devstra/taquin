<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fenetreMenu
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
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.ComboBoxNomJoueur = New System.Windows.Forms.ComboBox()
        Me.labelTitre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnJouer
        '
        Me.btnJouer.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnJouer.Enabled = False
        Me.btnJouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJouer.Location = New System.Drawing.Point(93, 137)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(75, 35)
        Me.btnJouer.TabIndex = 0
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = False
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Location = New System.Drawing.Point(93, 178)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(75, 35)
        Me.btnOptions.TabIndex = 1
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'btnScores
        '
        Me.btnScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScores.Location = New System.Drawing.Point(93, 219)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(75, 35)
        Me.btnScores.TabIndex = 2
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = False
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.Location = New System.Drawing.Point(93, 260)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 35)
        Me.btnQuitter.TabIndex = 3
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'ComboBoxNomJoueur
        '
        Me.ComboBoxNomJoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxNomJoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxNomJoueur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxNomJoueur.FormattingEnabled = True
        Me.ComboBoxNomJoueur.Location = New System.Drawing.Point(70, 96)
        Me.ComboBoxNomJoueur.Name = "ComboBoxNomJoueur"
        Me.ComboBoxNomJoueur.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNomJoueur.TabIndex = 4
        '
        'labelTitre
        '
        Me.labelTitre.AutoSize = True
        Me.labelTitre.Font = New System.Drawing.Font("Oswald", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitre.ForeColor = System.Drawing.Color.Coral
        Me.labelTitre.Location = New System.Drawing.Point(42, 35)
        Me.labelTitre.Name = "labelTitre"
        Me.labelTitre.Size = New System.Drawing.Size(179, 36)
        Me.labelTitre.TabIndex = 5
        Me.labelTitre.Text = "Taquin Cylindrique"
        '
        'fenetreMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.CancelButton = Me.btnQuitter
        Me.ClientSize = New System.Drawing.Size(274, 332)
        Me.Controls.Add(Me.labelTitre)
        Me.Controls.Add(Me.ComboBoxNomJoueur)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnJouer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "fenetreMenu"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "M E N U"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnJouer As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents ComboBoxNomJoueur As ComboBox
    Friend WithEvents labelTitre As Label
End Class
