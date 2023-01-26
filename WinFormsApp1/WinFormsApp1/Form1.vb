Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nummer As Integer = InputBox("Geef de eerste nummer in:") 'inputbox ipv hard coded cijfers pull nr #1
        Dim nummer2 As Integer = InputBox("Geef de tweede nummer in:")
        Dim verschil = nummer - nummer2
        MsgBox("Het verschil van de twee cijfers is " & verschil)  'som vervangen door verschil

        ' ik weet niet wat te veranderen, here's a smiley --> :) -Ugur
        'We are the Borg. Resistance is futile. May the Force be with you Harry, said Arslan. --- Raf
    End Sub
End Class
