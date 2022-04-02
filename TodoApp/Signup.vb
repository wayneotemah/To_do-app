Imports System.Data.SQLite

Public Class Signup

    Dim dbName As String = "ToDo.db"
    Dim dbpath As String = Application.StartupPath & "\" & dbName
    Dim connStr As String = "Data Source=" & dbName & ";Version=3;"


    Dim SQLiteConn As New SQLiteConnection(connStr)



    Private Sub SignUpBTN_Click(sender As Object, e As EventArgs) Handles SignUpBTN.Click
        Try
            'Check if files are populates
            If (SignUpNametxt.Text <> "" And SignupPasswordTXT.Text <> "" And SignUpEmailTXT.Text <> "") Then
                'open db
                SQLiteConn.Open()
                If SQLiteConn.State = ConnectionState.Open Then


                    'Using SQLiteConn As New SQLiteConnection(connStr)
                    Dim Command As String = "INSERT into User(Email,Username,Password) VALUES(@Email,@Username,@Password);"
                    Dim SQLitecmd As New SQLiteCommand(Command, SQLiteConn)
                    SQLitecmd.Parameters.AddWithValue("@Email", SignUpEmailTXT.Text)
                    SQLitecmd.Parameters.AddWithValue("@Username", SignUpNametxt.Text)
                    SQLitecmd.Parameters.AddWithValue("@Password", SignupPasswordTXT.Text)
                    SQLitecmd.ExecuteNonQuery()
                    'End Using
                    MsgBox("Your account has been created ")
                    SignUpNametxt.Text = ""
                    SignupPasswordTXT.Text = ""
                    SignUpEmailTXT.Text = ""
                    Me.Hide()
                    Form1.Show()

                End If

                SQLiteConn.Close()
            Else
                MsgBox("Fill all the details in the form")
                SignUpNametxt.Text = ""
                SignupPasswordTXT.Text = ""
                SignUpEmailTXT.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex)
            SignUpNametxt.Text = ""
            SignupPasswordTXT.Text = ""
            SignUpEmailTXT.Text = ""


        End Try
    End Sub

End Class