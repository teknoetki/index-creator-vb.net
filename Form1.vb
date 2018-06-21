Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.DocumentText = out_txt_1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '       Me.WebBrowser1.DocumentText = TextBox1.Text
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        out_txt_1.Focus()
        SendKeys.Send("<html> 
<body> 



</body>
</html>")
    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty
        Dim başlık As Object
        prompt = "Başlık Nedir?"
        title = "Başlık Belirleyiniz"
        out_txt_1.Focus()
        başlık = InputBox(prompt, title, defaultResponse)
        out_txt_1.Focus()
        SendKeys.Send("<title>" + başlık + "</title>")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim conv As New ColorConverter
        If (ColorDialog1.ShowDialog() = DialogResult.OK) Then
            Dim hex_color As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
            out_txt_1.Focus()
            SendKeys.Send("<body bgcolor=" + hex_color + ">")
        Else

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Me.WebBrowser1.DocumentText = out_txt_1.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel1.Width = 213 Then
            Panel1.Width = 47
        ElseIf Panel1.Width = 47 Then
            Panel1.Width = 213
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

        Dim Df_1 As String = String.Empty
        Dim in_1 As Object = String.Empty
        in_1 = InputBox("Paragraf yazısı belirleyiniz ?", "Paragraf Ekle", Df_1)
        out_txt_1.Focus()
        SendKeys.Send("<p>" + in_1)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        ''<h1>Bu bir başlık</h1>
        Dim Df_2 As String = String.Empty
        Dim in_2 As Object = String.Empty
        Dim ds1_ As String = String.Empty
        Dim kacıncı As Object = String.Empty
        in_2 = InputBox(" Eklenecek başlık nedir ?", "Başlık Ekle", Df_2)
        out_txt_1.Focus()
        ds1_ = InputBox("Sayfaya eklediğiniz yazının boyutu ne olsun ? 
Başlıklar <h1> ve <h6> dahil olmak üzere aradaki tüm rakamlar kullanılarak tanımlanabilir. 
<h1> en büyük puntoyu belirtirken, <h6> ise en küçük puntoyu belirtir.")

        SendKeys.Send("<h" + ds1_ + ">" + in_2 + "</h" + ds1_ + ">")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        ''<!-- Bu bir açıklama -->

        out_txt_1.Focus()
        SendKeys.Send("<!--" + InputBox("Açıklamayı nedir ?") + "-->")
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        out_txt_1.Focus()
        SendKeys.Send("<hr>")
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        out_txt_1.Focus()
        SendKeys.Send("<b>" + InputBox("Yazılacak olan koyu metin nedir ?"))
    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        ''<h1>Bu bir başlık</h1>
        Dim Df_2 As String = String.Empty
        Dim in_2 As Object = String.Empty
        Dim ds1_ As String = String.Empty
        Dim kacıncı As Object = String.Empty
        in_2 = InputBox(" Eklenecek başlık nedir ?", "Başlık Ekle", Df_2)
        out_txt_1.Focus()
        ds1_ = InputBox("Sayfaya eklediğiniz yazının boyutu ne olsun ? 
Başlıklar <h1> ve <h6> dahil olmak üzere aradaki tüm rakamlar kullanılarak tanımlanabilir. 
<h1> en büyük puntoyu belirtirken, <h6> ise en küçük puntoyu belirtir.")

        SendKeys.Send("<h" + ds1_ + ">" + in_2 + "</h" + ds1_ + ">")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click


        out_txt_1.Focus()
        SendKeys.Send("<center>" +
                        " </center>")
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

        out_txt_1.Focus()
        SendKeys.Send("<em>" + InputBox("Yazılacak olan vurgulanmış metin nedir ?"))
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

        out_txt_1.Focus()
        SendKeys.Send("<i>" + InputBox("Yazılacak olan italik metin nedir ?"))

    End Sub



    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

        out_txt_1.Focus()
        SendKeys.Send("<del>" + InputBox("Yazılacak olan Üstüçizili metin nedir ?"))
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        out_txt_1.Focus()
        SendKeys.Send("<ins>" + InputBox("Yazılacak olan Altıçizili metin nedir ?"))

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

        out_txt_1.Focus()
        SendKeys.Send("<a " + "href = " + InputBox("İnternet sitesi nedir ?") + ">" + InputBox("Görüntülenecek Metin nedir ?") + "</a>")
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

        out_txt_1.Focus()
        SendKeys.Send("<img src=" + InputBox("Resim link nedir ?") + ">")

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        ''  <embed src = "https://www.youtube.com/embed/m7gggsKG9bc" width=400px height=300px  allowfullscreen=true autostart=0 ></embed>
        Dim a, b, c, d, f As String
        a = "400px"
        b = "300px"
        c = "true"
        d = "0"

        out_txt_1.Focus()
        SendKeys.Send("<embed src= " + "https://www.youtube.com/embed/" + InputBox("Video URL ismi Nedir ?
Örnek : https://www.youtube.com/watch?v=lnejdmI6P5M bu video da lnejdmI6P5M bu kısmı yazıyoruz.") + " width=400px height=300px  allowfullscreen=true autostart=0 ></embed>")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*"
            Dim klasor As String
            Dim file As String
            file = "index.html"
            Dim fs As FileStream = New FileStream(file, FileMode.Append)
            Dim w As StreamWriter = New StreamWriter(fs)
            w.WriteLine(out_txt_1.Text)
            w.Close()
            fs.Close()
            MsgBox("Programın bulunduğu dizine kaydedildi.", MsgBoxStyle.Information)

        Catch ex As Exception

        End Try



    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        out_txt_1.Clear()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class
