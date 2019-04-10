Public Class Form1
    Dim MyIp As System.Net.IPAddress

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyIp = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0)
        lbIp.Text = MyIp.ToString
    End Sub

    'Funktion zur Konvertierung
    Private Function fnConvert(ByVal MyIp As Net.IPAddress)

        'Dim aZtoB(11, 11) As Char
        'aZtoB(0, 0) = 0
        Dim length As String
        length = MyIp.ToString.Length

        For i As Integer = 1 To length
            Debug.Write(i.ToString & " ")
            MyIp.ToString.Trim()



        Next
        Debug.WriteLine("")



        Return length
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lbConv.Text = fnConvert(MyIp)

    End Sub


End Class
