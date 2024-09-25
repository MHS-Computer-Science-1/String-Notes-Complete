Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' A STRING is a value that represents text 
        ' (like a word or phrase)
        Dim myName As String
        ' String values must be surrounded by " "
        myName = "Put your name here"

        Label1.Text = myName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' We can take multiple strings and combine them with
        ' the & sign. This is called CONCATONATION
        Dim greeting, name, title As String

        name = TextBox2.Text
        title = TextBox1.Text

        greeting = "Dear " & title & " " & name & ","

        Label1.Text = greeting

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' We can use .toUpper and .toLower to make
        ' a string upper or lower case

        Dim state, lower, upper As String
        state = "mICHigAn"

        lower = state.ToLower
        upper = state.ToUpper

        Label1.Text = state & " " & lower & " " & upper
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' We can find the location of something within a
        ' string using INDEXOF

        Dim sentence As String
        sentence = "I am a cat."

        Dim aLocation As Integer
        aLocation = sentence.IndexOf("a")
        Label1.Text = "The first a is located at index " & aLocation

        ' But what is an index? 
        ' Each position in the string is given a number starting at 0
        '        I   a m   a   c a t .
        ' index: 0 1 2 3 4 5 6 7 8 9 10

        ' IndexOf finds the first occurance of a, which is at index 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' If indexOf searches and doesn't find what
        ' we're looking for, it gives us -1

        Dim animal As String
        animal = "Koala Bear"

        Dim index As Integer
        index = animal.IndexOf(TextBox2.Text)

        If index = -1 Then
            Label1.Text = "What you searched for was not found"
        Else
            Label1.Text = "What you searched for was found at index " & index
        End If
    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Substring allows us to extract a piece of a string
        Dim food As String
        food = "Avocados"

        Dim twoInSpanish As String
        twoInSpanish = food.Substring(5, 3)
        Label1.Text = twoInSpanish

        '5 = start index, 3 = how many characters
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim name, lastName As String
        name = "Pete Cat"

        'Locate the space
        Dim space As Integer
        space = name.IndexOf(" ")

        ' When you only give substring 1 number, it takes everything
        ' from that index to the end
        lastName = name.Substring(space + 1)

        Label1.Text = lastName
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim name, initial As String
        name = "Pete Cat"

        ' Write a substring to get the first initial
        initial = name.Substring(0, 1)

        Label1.Text = initial
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim fullName As String
        fullName = "Pete The Cat"

        ' Locate the spaces
        Dim space1, space2 As Integer

        space1 = fullName.IndexOf(" ")
        space2 = fullName.IndexOf(" ", space1 + 1)

        ' IndexOf can take an optional start index
        ' For space1, we search from the beginning
        ' For space2, we search from one after space1

        Label1.Text = "The spaces are located at index " & space1 & " and " & space2
    End Sub


End Class
