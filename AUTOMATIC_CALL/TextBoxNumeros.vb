Imports System.ComponentModel
Imports System.Windows.Forms
Public Class TextBoxNumeros
    Inherits TextBox

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Se comprueba si el Caracter ingresado ES o No un numero
        If Not IsNumeric(e.KeyChar) Then
            ' Indicamos que no queremos que se escriba ese caracter
            e.Handled = True
        End If

        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub



End Class
