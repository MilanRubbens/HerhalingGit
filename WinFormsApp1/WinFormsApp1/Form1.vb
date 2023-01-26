Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nummer As Integer = InputBox("Geef de eerste nummer in:") 'inputbox ipv hard coded cijfers pull nr #1
        Dim nummer2 As Integer = InputBox("Geef de tweede nummer in:")
        Dim som = nummer + nummer2
        MsgBox("De som van de twee cijfers is " & som)

    End Sub
End Class
