'Owen Fujii
'RCET 2265
'Spring 2024
'DinerMenu
'


Option Strict On
Option Explicit On


Public Class DinerMenuForm

    'Private Sub 

    '        End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = $"~ Soup of the Day ~ {vbNewLine} Menudo "
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = $"~ Special Taco Salad ~ 
This is as special salad that we pride ourselves in making. From the 
crunch of tortilla chips to the tangly flavor of the dressing this meal has all
it takes to enjoy a taco in salad form"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "~ Chef's Special Fish ~"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
