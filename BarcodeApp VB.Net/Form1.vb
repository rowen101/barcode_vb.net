Imports ZXing

Public Class Form1


    Private Sub Btnencode_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub Btndecode_Click(sender As Object, e As EventArgs) Handles btndecode.Click
        If btndecode.Text = "Encode" Then
            Dim writer As New BarcodeWriter
            writer.Format = BarcodeFormat.CODE_128
            pic.Image = writer.Write(txtencode.Text)
            btndecode.Text = "Decode"
            txtdecode.Clear()
        ElseIf btndecode.Text = "Decode" Then
            Dim reader As New BarcodeReader
            Dim result = reader.Decode(CType(pic.Image, Bitmap))
            If result IsNot Nothing Then
                txtdecode.Text = result.Text
            End If
            btndecode.Text = "Encode"
        End If
    End Sub
    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click, MetroLabel2.Click

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        txtdecode.Clear()
        txtencode.Clear()

    End Sub
End Class
