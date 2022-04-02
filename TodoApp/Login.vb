Imports System.Data.SQLite
Public Class Login
    Dim dbName As String = "ToDo.db"
    Dim dbpath As String = Application.StartupPath & "\" & dbName
    Dim connStr As String = "Data Source=" & dbName & ";Version=3;"


    Dim SQLiteConn As New SQLiteConnection(connStr)
    Dim SQLitecmd As New SQLiteCommand("", SQLiteConn)


    Private Sub LogBTN_Click(sender As Object, e As EventArgs) Handles LogBTN.Click
        Try
            'Check if files are populates
            If (UsernameTXT.Text <> "" And PasswordTXT.Text <> "") Then
                'open db
                SQLiteConn.Open()
                If SQLiteConn.State = ConnectionState.Open Then
                    SQLitecmd.Connection = SQLiteConn
                    SQLitecmd.CommandText = "SELECT Username,Password FROM User WHERE Username='" & UsernameTXT.Text & "';"
                    Dim SQLiteReader As SQLiteDataReader = SQLitecmd.ExecuteReader
                    Using SQLiteReader
                        While (SQLiteReader.Read())
                            'evauate user name and pass
                            If SQLiteReader("Username") = UsernameTXT.Text And SQLiteReader("Password") = PasswordTXT.Text Then
                                Me.Hide()
                                Form1.Show()
                            Else
                                MsgBox("Incorrect details")
                                UsernameTXT.Text = ""
                                PasswordTXT.Text = ""

                            End If
                        End While
                    End Using
                End If
                SQLiteConn.Close()
            Else
                MsgBox("Incorrect details")
            End If
        Catch ex As Exception
            MsgBox("Faild database connection. Check and fix")

        End Try

    End Sub

    Private Sub SignInLKLB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignInLKLB.LinkClicked
        Me.Hide()
        Signup.Show()
    End Sub
End Class