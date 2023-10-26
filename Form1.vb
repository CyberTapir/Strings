Imports System

Public Class Form1
    Dim letters(100) As Char
    Dim InitialText As String
    Dim upper As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReadTextFile()
        ListBox1.Items.Add(InitialText)
        ExtractText()
        PrintArray()
    End Sub

    Private Sub ReadTextFile()
        ' Use StreamReader to read text from a file.
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("lol.txt")
        InitialText = fileReader.ReadToEnd()
        fileReader.Close()
    End Sub

    Private Sub ExtractText()
        upper = InitialText.Length
        For counter = 0 To upper - 1
            letters(counter) = InitialText(counter)
        Next counter
    End Sub

    Private Sub PrintArray()
        ListBox1.Items.Clear() ' Clear existing items to avoid duplicates.
        For counter = 0 To upper - 1
            ListBox1.Items.Add(letters(counter))
        Next counter
    End Sub
End Class
