Imports System.Text
Imports System.Security.Cryptography
Imports System.Net
Imports System.IO

Public Class Trial

    Public Sub signIn()

        Dim name As String = ""
        Dim code As String = ""
        Dim valide As MsgBoxResult = MsgBoxResult.No

        While valide = vbNo

            name = InputBox("Entrez le nom : ", "Enregistrement")
            If name = "" Then Return

            code = InputBox("Entrez le code : ")
            If code = "" Then Return

            valide = MsgBox("Enregistrement de Gestionnaire d'Archive sous le nom de " & name & vbCrLf & "Avec le code d'enregistrement " & code & vbCrLf & vbCrLf & "Les informations saisies sont-elles correctes ?", vbYesNoCancel, "Enregistrement")
            If valide = MsgBoxResult.Cancel Then Return

        End While

        If validateSerial(code) Then

            Dim uri As String
            uri = "?serial=" & code & "&user=" & name
            'json = "{""serial"": " & code & ", ""user"": """ & name & """}"
            Dim resp As String = postMethod("http://phoenixz-group.web44.net/GestionnaireArchive/Cloud/register.php", uri)

            MsgBox(resp)

        End If


    End Sub
    Public Sub login()

    End Sub

#Region "HTTP"

    Private Function postMethod(ByVal url As String, ByVal uri As String)

        Dim urn As String = url & "/" & uri
        Dim data As Byte() = Encoding.UTF8.GetBytes(urn)
        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        postReq.Method = "POST"
        postReq.KeepAlive = True
        postReq.ContentType = "application/x-www-form-urlencoded"
        postReq.ContentLength = data.Length

        Dim postStream As CryptoStream = postReq.GetRequestStream()
        postStream.Write(data, 0, data.Length)
        postStream.Close()

        Dim postResponse As HttpWebResponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
        Dim respReader As New StreamReader(postResponse.GetResponseStream())

        Return respReader.ReadToEnd()

    End Function

#End Region

    Private Function hashMD5(ByVal value As String) As String

        ' Based on : http://www.a1vbcode.com/vbtip-149.asp

        Dim uE As New UnicodeEncoding()
        Dim byteValue() As Byte = uE.GetBytes(value)
        Dim md5 As New MD5CryptoServiceProvider()
        Dim byteHash() As Byte = md5.ComputeHash(byteValue)

        Return Convert.ToBase64String(byteHash)

    End Function
    Private Function checkTrial(ByVal name_t As String, ByVal code_t As String)

        Dim code() As String
        Dim value As UInteger = 0

        If name_t = "######||######" And code_t = "######||######" Or name_t = "" And code_t = "" Then Return True

        code = Split(code_t, "-")
        For i = 0 To code.Length - 1
            value += valueOf(code(i))
        Next

        If value * 255 = 19125 Then
            Main.trial = False
            Return False
        Else
            MsgBox("Code d'enregistrement incorrecte, veuillez vous re-enregistrer ultérieurement")
            Return True
        End If

    End Function
    Private Function validateSerial(ByVal serial As String)

        Dim part() As String
        Dim val As UInteger = 0

        part = Split(serial, "-")
        For i = 0 To part.Length - 1
            val += valueOf(part(i))
        Next

        If val * 255 = 19125 Then
            Return True
        End If

        Return False

    End Function
    Private Function numberLength(ByVal nb As ULong)

        Dim length As ULong = 0

        While (nb / 10) <> 0
            nb = nb / 10
            length += 1
        End While

        Return length

    End Function
    Private Function valueOf(ByVal val As ULong)

        If val = 0 Then Return 0

        Dim valeur As ULong = val
        Dim length As ULong = numberLength(val)
        Dim ret As ULong = 0
        Dim i As ULong = 0

        While i < length
            ret += valeur Mod 10
            valeur = valeur / 10
            i += 1
        End While

        Return ret

    End Function

End Class
