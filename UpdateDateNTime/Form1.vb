﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Do something when the window loads
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' "Update!" Button
        Dim command As String
        command = "initialize.cmd" & " & " & "startTimeService.cmd" & " & " & "resync.cmd"

        Shell("cmd.exe /c " & command)
    End Sub
    ' TODO: Restart w32time button (hidden)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    ' TODO: Repair w32time button (hidden)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
