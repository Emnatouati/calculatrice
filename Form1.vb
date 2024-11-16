Public Class Form1
    Dim A As String
    Dim B As String
    Dim op = ""
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"

        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"

        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        If Not A = "" Then
            op = "+"
        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"

        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"

        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"

        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_c_Click(sender As Object, e As EventArgs) Handles btn_c.Click
        text_affiche.Text = ""
        A = ""
        B = ""
        op = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles text_affiche.TextChanged

    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"

        End If
        text_affiche.Text = A + "" + op + "" + B

    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"

        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"

        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"

        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        If Not A = "" Then
            op = "-"
        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        If Not A = "" Then
            op = "*"
        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        If Not A = "" Then
            op = "/"
        End If
        text_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)



            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" Then
                res = va / vb

            Else
                MessageBox.Show("A et B doivent etre des entiers")
                test = False
            End If
            If test Then
                text_affiche.Text = text_affiche.Text + "=" + res.ToString
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Dot_btn.Click
        If op = "" Then
            A = A + "."
        Else
            B = B + "."

        End If
        text_affiche.Text = A + "" + op + "" + B

    End Sub
End Class
