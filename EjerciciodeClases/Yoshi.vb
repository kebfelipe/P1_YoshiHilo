Public Class Yoshi
    Private lenguetazo() As Image
    Private NombrePersonaje As String = ""
    Private ColorPersonaje As String = ""
    Private posLenguetazo = 0
    Private Sub btnComer_Click(sender As Object, e As EventArgs) Handles btnComer.Click
        timTick.Start()
    End Sub

    Private Sub timTick_Tick(sender As Object, e As EventArgs) Handles timTick.Tick
        picYoshi.Image = lenguetazo(posLenguetazo)
        If (posLenguetazo >= 8) Then
            posLenguetazo = 0
            timTick.Stop()
        Else
            posLenguetazo += 1
        End If
    End Sub

    Private Sub VentanaYoshi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Yoshi - " + NombrePersonaje
        lblNombre.Text = NombrePersonaje
        lblColor.Text = ColorPersonaje
        picYoshi.Image = VerYoshi()
        VerYoshiLenguetazo()
    End Sub
    Public Sub setAtributosYoshi(ByVal Nombre As String, ByVal Color As String)
        NombrePersonaje = Nombre
        ColorPersonaje = Color
    End Sub

    Public Function VerYoshi() As Image
        Select Case ColorPersonaje
            Case "Verde"
                Return My.Resources.yoshiVerde
            Case "Rojo"
                Return My.Resources.yoshiRojo
            Case "Azul"
                Return My.Resources.yoshiAzul
            Case "Negro"
                Return My.Resources.yoshiNegro
            Case Else
                Return My.Resources.yoshiVerde
        End Select
    End Function
    Public Sub VerYoshiLenguetazo()
        Select Case ColorPersonaje
            Case "Verde"
                lenguetazo = {My.Resources.yoshiVerde, My.Resources.YoshiVerdeB1, My.Resources.YoshiVerdeB2, My.Resources.YoshiVerdeB3, My.Resources.YoshiVerdeB4, My.Resources.YoshiVerdeB3, My.Resources.YoshiVerdeB2, My.Resources.YoshiVerdeB1, My.Resources.yoshiVerde}
            Case "Azul"
                lenguetazo = {My.Resources.yoshiAzul, My.Resources.YoshiAzulB1, My.Resources.YoshiAzulB2, My.Resources.YoshiAzulB3, My.Resources.YoshiAzulB4, My.Resources.YoshiAzulB3, My.Resources.YoshiAzulB2, My.Resources.YoshiAzulB1, My.Resources.yoshiAzul}
            Case "Rojo"
                lenguetazo = {My.Resources.yoshiRojo, My.Resources.YoshiRojoB1, My.Resources.YoshiRojoB2, My.Resources.YoshiRojoB3, My.Resources.YoshiRojoB4, My.Resources.YoshiRojoB3, My.Resources.YoshiRojoB2, My.Resources.YoshiRojoB1, My.Resources.yoshiRojo}
            Case "Negro"
                lenguetazo = {My.Resources.yoshiNegro, My.Resources.YoshiNegroB1, My.Resources.YoshiNegroB2, My.Resources.YoshiNegroB3, My.Resources.YoshiNegroB4, My.Resources.YoshiNegroB3, My.Resources.YoshiNegroB2, My.Resources.YoshiNegroB1, My.Resources.yoshiNegro}
            Case Else
                lenguetazo = {My.Resources.yoshiVerde, My.Resources.YoshiVerdeB1, My.Resources.YoshiVerdeB2, My.Resources.YoshiVerdeB3, My.Resources.YoshiVerdeB4, My.Resources.YoshiVerdeB3, My.Resources.YoshiVerdeB2, My.Resources.YoshiVerdeB1, My.Resources.yoshiVerde}
        End Select
    End Sub
End Class