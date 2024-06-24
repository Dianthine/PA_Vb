Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With FormDashboard
            .TopLevel = False
            Panel3.Controls.Add(FormDashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With FormLibrary
            .TopLevel = False
            Panel3.Controls.Add(FormLibrary)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With FormAnggota
            .TopLevel = False
            Panel3.Controls.Add(FormAnggota)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With FormReport
            .TopLevel = False
            Panel3.Controls.Add(FormReport)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
