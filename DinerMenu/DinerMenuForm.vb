'Owen Fujii
'RCET 2265
'Spring 2024
'DinerMenu
'


Option Strict On
Option Explicit On


Public Class DinerMenuForm

    Private Sub DinerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplaySpecialLabel.Text = ""

    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = $"~ Soup of the Day ~ 
Posola Pork soup
A rich soup comprised of Hominy and Tomallias giving this soup a rich
and tangy nature. Combined with tender pork, this dish is a traditional
favorite that will have you coming back for more"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = $"~ House Salad ~ 
Taco Salad
This is as special salad that we pride ourselves in making. From the 
crunch of tortilla chips to the tangly flavor of the dressing this meal has all
it takes to enjoy a taco in salad form"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "~ Chef's Special Fish ~
Pescado Zarandeado
This simple fish dish is sure to delight. Fresh red snapper is lightly smoked over 
mangrave wood giving a distinct light smoke to the fish which melts your taste buds. 
Served with a side of lime and our special lime rice for a refreshing meal"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
