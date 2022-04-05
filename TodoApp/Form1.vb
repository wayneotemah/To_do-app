Imports System.Data.SQLite

Public Class Form1
    Dim dbName As String = "ToDo.db"
    Dim dbpath As String = Application.StartupPath & "\" & dbName
    Dim connStr As String = "Data Source=" & dbName & ";Version=3;"


    Dim SQLiteConn As New SQLiteConnection(connStr)
    Dim SQLitecmd As New SQLiteCommand("", SQLiteConn)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            'open db
            SQLiteConn.Open()
            If SQLiteConn.State = ConnectionState.Open Then
                SQLitecmd.Connection = SQLiteConn
                SQLitecmd.CommandText = "SELECT * FROM Activity WHERE Activity_User='" & AccUsernameTxt.Text & "' "
                Dim SQLiteReader As SQLiteDataReader = SQLitecmd.ExecuteReader()
                Dim ActivityBTN_Item As New ListViewItem

                Using SQLiteReader

                    While (SQLiteReader.Read())

                        ActivityListBX.Items.Add(SQLiteReader.GetString(0))

                            AcivityemptyinfoTXT.Hide()

                        End While


                End Using
            End If
            SQLiteConn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub accountLKLB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles accountLKLB.LinkClicked
        Call SwitchAccount()
    End Sub

    Private Sub SwitchAccount()
        Throw New NotImplementedException()
    End Sub

    Private Sub NewTaskBTN_Click(sender As Object, e As EventArgs) Handles NewTaskBTN.Click
        If ActivityTitleLBL.Text <> "" Then

            Task.Show()
            Task.AccUsernameLBL.Text = AccUsernameTxt.Text
            Task.TaskTitileLBL.Text = ActivityTitleLBL.Text
            Me.Close()
        Else
            MsgBox("Please select an aktivity to create a task for, or create one if you dont have any")
        End If

    End Sub

    Private Sub NewActivityBTN_Click(sender As Object, e As EventArgs) Handles NewActivityBTN.Click

        AddActivity.AccUserNameLBL.Text = AccUsernameTxt.Text
        AddActivity.Show()

        Me.Close()
    End Sub

    Private Sub ActivityListBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActivityListBX.SelectedIndexChanged
        Dim activityTitleName = ActivityListBX.SelectedItem.ToString
        ActivityTitleLBL.Text = activityTitleName

        Try
            'open db
            SQLiteConn.Open()
            If SQLiteConn.State = ConnectionState.Open Then
                SQLitecmd.Connection = SQLiteConn
                SQLitecmd.CommandText = "SELECT * FROM Task  WHERE User='" & AccUsernameTxt.Text & "' AND Task_Activity='" & activityTitleName & "'"
                Dim SQLiteReader As SQLiteDataReader = SQLitecmd.ExecuteReader()
                Dim ActivityBTN_Item As New ListViewItem
                SelectTaskLIstView.Show()
                SelectTaskLIstView.Refresh()

                Using SQLiteReader

                    While (SQLiteReader.Read())

                        SelectTaskLIstView.Items.Add(SQLiteReader.GetString(1))

                        'AcivityemptyinfoTXT.Hide()
                    End While

                End Using


            End If
            SQLiteConn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub SelectTaskLIstView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectTaskLIstView.SelectedIndexChanged
        TaskDetails.TaskDetailTitleLBL.Text = SelectTaskLIstView.SelectedItem
        TaskDetails.TaskDetailsAccUsername.Text = AccUsernameTxt.Text


        TaskDetails.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutBTN_Click(sender As Object, e As EventArgs) Handles LogoutBTN.Click
        Login.Show()
        Me.Close()
    End Sub
End Class
