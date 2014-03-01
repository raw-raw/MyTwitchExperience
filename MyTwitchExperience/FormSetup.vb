﻿

Public Class FormSetup

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormGetAuth.Show()

    End Sub

    Private Sub FormSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TextBoxUsername.Text = My.Settings.username
            ComboBoxLocale.Text = My.Settings.locale
            LabelOAuthToken.Text = My.Settings.authkey
            LabelVLCdir.Text = My.Settings.vlcdir
            ComboBoxQuality.Text = My.Settings.quality
            Me.TopMost = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.username = TextBoxUsername.Text
        My.Settings.locale = ComboBoxLocale.Text
        My.Settings.authkey = LabelOAuthToken.Text
        My.Settings.vlcdir = LabelVLCdir.Text
        My.Settings.quality = ComboBoxQuality.Text
        My.Settings.Save()
        MsgBox("Settings successfully saved!")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            LabelVLCdir.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim files() As String = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies))
        For i As Integer = 0 To files.length - 1
            System.IO.File.Delete(files(i))
        Next
    End Sub

    Private Sub FormSetup_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.TopMost = False
    End Sub
End Class