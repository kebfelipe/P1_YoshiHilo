<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Yoshi
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Yoshi))
        Me.timTick = New System.Windows.Forms.Timer(Me.components)
        Me.btnComer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.picYoshi = New System.Windows.Forms.PictureBox()
        CType(Me.picYoshi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timTick
        '
        '
        'btnComer
        '
        Me.btnComer.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnComer.FlatAppearance.BorderSize = 0
        Me.btnComer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnComer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnComer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnComer.Location = New System.Drawing.Point(74, 280)
        Me.btnComer.Name = "btnComer"
        Me.btnComer.Size = New System.Drawing.Size(218, 60)
        Me.btnComer.TabIndex = 2
        Me.btnComer.Text = "Lenguetazo"
        Me.btnComer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Color:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(167, 178)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(125, 31)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.ForeColor = System.Drawing.Color.White
        Me.lblColor.Location = New System.Drawing.Point(167, 218)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(125, 31)
        Me.lblColor.TabIndex = 7
        Me.lblColor.Text = "Nombre:"
        '
        'picYoshi
        '
        Me.picYoshi.Image = Global.EjerciciodeClases.My.Resources.Resources.yoshiVerde
        Me.picYoshi.Location = New System.Drawing.Point(31, 25)
        Me.picYoshi.Name = "picYoshi"
        Me.picYoshi.Size = New System.Drawing.Size(300, 150)
        Me.picYoshi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picYoshi.TabIndex = 0
        Me.picYoshi.TabStop = False
        '
        'Yoshi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(364, 383)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnComer)
        Me.Controls.Add(Me.picYoshi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Yoshi"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yoshi"
        CType(Me.picYoshi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picYoshi As PictureBox
    Friend WithEvents timTick As Timer
    Friend WithEvents btnComer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblColor As Label
End Class
