<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneradorYoshi
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneradorYoshi))
        Me.btnAdopatar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbNombreMascota = New System.Windows.Forms.TextBox()
        Me.Logo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbColorYoshi = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAdopatar
        '
        Me.btnAdopatar.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdopatar.FlatAppearance.BorderSize = 0
        Me.btnAdopatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAdopatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnAdopatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdopatar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdopatar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdopatar.Location = New System.Drawing.Point(326, 229)
        Me.btnAdopatar.Name = "btnAdopatar"
        Me.btnAdopatar.Size = New System.Drawing.Size(218, 67)
        Me.btnAdopatar.TabIndex = 1
        Me.btnAdopatar.Text = "Adopta un Yoshi"
        Me.btnAdopatar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(268, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'txbNombreMascota
        '
        Me.txbNombreMascota.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombreMascota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.txbNombreMascota.Location = New System.Drawing.Point(274, 73)
        Me.txbNombreMascota.MaxLength = 15
        Me.txbNombreMascota.Name = "txbNombreMascota"
        Me.txbNombreMascota.Size = New System.Drawing.Size(316, 38)
        Me.txbNombreMascota.TabIndex = 3
        Me.txbNombreMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Logo
        '
        Me.Logo.Image = Global.EjerciciodeClases.My.Resources.Resources.Logo
        Me.Logo.Location = New System.Drawing.Point(28, 54)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(221, 206)
        Me.Logo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(268, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Color:"
        '
        'cmbColorYoshi
        '
        Me.cmbColorYoshi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColorYoshi.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold)
        Me.cmbColorYoshi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.cmbColorYoshi.FormattingEnabled = True
        Me.cmbColorYoshi.Items.AddRange(New Object() {"Verde", "Rojo", "Azul", "Negro"})
        Me.cmbColorYoshi.Location = New System.Drawing.Point(274, 164)
        Me.cmbColorYoshi.Name = "cmbColorYoshi"
        Me.cmbColorYoshi.Size = New System.Drawing.Size(316, 39)
        Me.cmbColorYoshi.TabIndex = 5
        '
        'GeneradorYoshi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(635, 329)
        Me.Controls.Add(Me.cmbColorYoshi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbNombreMascota)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdopatar)
        Me.Controls.Add(Me.Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GeneradorYoshi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creador de Yoshi´s"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logo As Label
    Friend WithEvents btnAdopatar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txbNombreMascota As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbColorYoshi As ComboBox
End Class
