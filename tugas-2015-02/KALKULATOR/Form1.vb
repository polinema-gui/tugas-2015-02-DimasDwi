﻿Public Class Form1

    Dim variabel1 As Integer
    Dim variabel2 As Byte

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (mengecek()) Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text &= "0"
        End If
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (mengecek()) Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text &= "1"
        End If
    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (mengecek()) Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text &= "2"
        End If
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (mengecek()) Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text &= "3"
        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (mengecek()) Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text &= "4"
        End If
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (mengecek()) Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text &= "5"
        End If
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (mengecek()) Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text &= "6"
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (mengecek()) Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text &= "7"
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (mengecek()) Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text &= "8"
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (mengecek()) Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text &= "9"
        End If
    End Sub



    Private Function mengecek()
        If (TextBox1.Text.Equals("0") Or Me.variabel2 > 0) Then
            Return True
        Else
            Return False
        End If
    End Function



    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (Me.variabel2 = 1) Then
            Me.variabel1 -= Convert.ToInt32(TextBox1.Text)
        Else
            Me.variabel1 += Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.variabel1.ToString
        Me.variabel2 = 2
    End Sub



    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (Me.variabel1 = 0 Or Me.variabel2 = 2) Then
            Me.variabel1 += Convert.ToInt32(TextBox1.Text)
        Else
            Me.variabel1 -= Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.variabel1.ToString
        Me.variabel2 = 1
    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Select Case Me.variabel2
            Case 1
                TextBox1.Text = Convert.ToString(Me.variabel1 - Convert.ToString(TextBox1.Text))
            Case 2
                TextBox1.Text = Convert.ToString(Me.variabel1 + Convert.ToString(TextBox1.Text))
        End Select
        Me.variabel1 = 0
    End Sub



    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = "0"
        Me.variabel1 = 0
        Me.variabel2 = 0
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
