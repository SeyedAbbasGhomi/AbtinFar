Public Class Form1
 Private Sub AbtinFar1_ArabicDateChanged(ArabicDate As String) Handles AbtinFar1.ArabicDateChanged
        MessageBox.Show(ArabicDate)
    End Sub
    Private Sub AbtinFar1_EnglishDateChanged(EnglishDate As String) Handles AbtinFar1.EnglishDateChanged
        MessageBox.Show(EnglishDate)
    End Sub

    Private Sub AbtinFar1_DayEvents(Events As String) Handles AbtinFar1.DayEvents
        MessageBox.Show(Events)
    End Sub

    Private Sub AbtinFar1_DateChanged(FDate As String) Handles AbtinFar1.DateChanged
        MessageBox.Show(FDate)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbtinFar1.TodayDate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       tharf.Text= AbtinFarConvertor1.ConvertDigits(Double.Parse(tadad.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtShamsi01.Text=AbtinFarConvertor1.English2Persian(DateTime.Parse(txtMiladi01.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtMiladi02.Text=AbtinFarConvertor1.Persian2English(txtShamsi02.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtQamari.Text=AbtinFarConvertor1.Persian2Qamari(txtShamsi03.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
         AbtinFar1.SetCalendarStyle(ComboBox1.SelectedItem)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex=0
    End Sub

   
End Class
