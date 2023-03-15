Imports System.Security.Cryptography

Public Class PassEncDec
    Private TDES As New TripleDESCryptoServiceProvider

    Public Sub New()
        ' initialize crypto provider
        TDES.Key = TruncateHash("Admin", TDES.KeySize \ 8)
        TDES.IV = TruncateHash("", TDES.BlockSize \ 8)
    End Sub

    'create and return a byte array of a specified length from the hash of the specified key.
    Private Function TruncateHash(key As String, length As Integer) As Byte()
        Dim sha1 As New SHA1CryptoServiceProvider

        ' hash the given key
        Dim keyByteArr() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyByteArr)

        ' truncate the hash
        ReDim Preserve hash(length - 1)

        Return hash
    End Function

    ' method to encrypt
    Public Function Encrypt(text As String) As String
        ' convert to byte arr
        Dim textByteArr() As Byte = System.Text.Encoding.Unicode.GetBytes(text)

        ' use memory stream
        Using memStream As New IO.MemoryStream
            ' save encoding stream to memory stream
            Using encStream As New CryptoStream(memStream, TDES.CreateEncryptor, CryptoStreamMode.Write)

                ' use encoding stream to write to the memory stream
                encStream.Write(textByteArr, 0, textByteArr.Length)
                encStream.FlushFinalBlock()

            End Using
            Return Convert.ToBase64String(memStream.ToArray)
        End Using
    End Function

    Public Function Decrypt(encryptedtext As String) As String
        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Using memStream As New System.IO.MemoryStream
            ' Create the decoder to write to the stream.
            Using decStream As New CryptoStream(memStream, TDES.CreateDecryptor, CryptoStreamMode.Write)
                ' Use the crypto stream to write the byte array to the stream.
                decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
                decStream.FlushFinalBlock()
            End Using
            ' Convert the plaintext stream to a string.
            Return Text.Encoding.Unicode.GetString(memStream.ToArray)
        End Using
    End Function
End Class