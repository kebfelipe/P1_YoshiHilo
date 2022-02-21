Public Class GeneradorYoshi
    Dim Validar As New Validaciones()
    Private Sub btnAdopatar_Click(sender As Object, e As EventArgs) Handles btnAdopatar.Click
        If (Validar.TextoNoVacio(txbNombreMascota.Text)) Then
            If (Validar.TextoNoVacio(cmbColorYoshi.Text)) Then
                If (Validar.ColorValido(cmbColorYoshi.Text)) Then
                    Dim NuevoYoshi As New Yoshi()
                    NuevoYoshi.setAtributosYoshi(txbNombreMascota.Text, cmbColorYoshi.Text)
                    NuevoYoshi.Show()
                    txbNombreMascota.Text = ""
                    cmbColorYoshi.Text = ""
                Else
                    MessageBox.Show("¡Lo sentimos!, No hay Yoshi's de ese color.", "No existe el color", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Else
                MessageBox.Show("¡Alto!, No has escogido un color de Yoshi." + vbCrLf + vbCrLf + "Busca tu color favorito", "Yoshi sin color", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Else
            MessageBox.Show("¡Alto!, No has colocado un nombre a Yoshi." + vbCrLf + vbCrLf + "Recuerda que no hay nadie más fiel que el." + vbCrLf + "Merece que le des más de tu amor.", "Yoshi sin nombre", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub
End Class
