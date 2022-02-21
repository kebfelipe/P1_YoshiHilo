Public Class Validaciones
    Public Function TextoNoVacio(ByVal Texto As String) As Boolean
        If (Texto = "") Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function ColorValido(ByVal Color As String) As Boolean
        If (Color = "Verde" Or Color = "Azul" Or Color = "Rojo" Or Color = "Negro") Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
