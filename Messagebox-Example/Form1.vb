Public Class Form1
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim result As DialogResult

        result = MessageBox.Show(“Close form?”, ”quit?”, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub
End Class
