Imports System.Security.Cryptography
Imports System.Text

Public Class Hasher
    Private Function GetHash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object
            ' Convert to byte array and get hash
            Dim dbytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        TextBox1.Text = GetHash(RichTextBox1.Text)
    End Sub
End Class
