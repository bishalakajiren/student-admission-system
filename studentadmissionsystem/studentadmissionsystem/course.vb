Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class course
    Dim cn As New MySqlConnection("server=localhost;database=sas;user=root; pwd=root")
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()
        cmd = New MySqlCommand("insert into course values (' " & TextBox1.Text & " ' , ' " & TextBox2.Text & " ' , ' " & TextBox3.Text & " ' , ' " & TextBox4.Text & " ' , ' " & TextBox5.Text & " ' )", cn)
        cmd.ExecuteNonQuery()
        MsgBox("saved sucessfully")
        cn.Close()
        showdb()
        clear()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        cn.Open()

    End Sub

    Private Sub course_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showdb()
        auto_g()

    End Sub
    Sub showdb()
        Dim dt As New DataTable
        cn.Open()
        da = New MySqlDataAdapter("select * from course ", cn)
        da.Fill(dt)
        dgv1.DataSource = dt
        cn.Close()

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox1.Focus()
        cn.Close()
        auto_g()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn.Open()
        cmd = New MySqlCommand("update course set course_id=' " & TextBox1.Text & " ',course_name=' " & TextBox2.Text & " ' where course_id=' " & TextBox1.Text & " ' ", cn)
        cmd.ExecuteNonQuery()
        MsgBox("updated sucessfully")
        cn.Close()
        'clear()
        'clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dt As New DataTable
        Dim x As String
        Try
            cn.Open()
            x = InputBox("enter the course_id to be deleted :")
            da = New MySqlDataAdapter("delete from course where course_id=' " & x & " ' ", cn)
            'cmd = New OdbcCommand("delete from course where course_id=' " & TextBox1.Text & " ' ", cn)
            'cmd = New OdbcCommand("delete from course where course_id=' " & TextBox1.Text & " ' ", cn)
            da.Fill(dt)
            dgv1.DataSource = dt
            MsgBox(" sucessfully")
            cn.Close()
            'cmd.ExecuteNonQuery()
            'MsgBox("invalid course_id,try again!!")
        Catch ex As Exception
            MsgBox("deleted successfully")
        Finally
            showdb()
            auto_g()

            cn.Close()
        End Try
        'cn.Open()
        'cmd = New OdbcCommand("delete from course where course_id=' " & TextBox1.Text & " ' ", cn)
        'da.Fill(dt)
        'cmd.ExecuteNonQuery()
        ' MsgBox("deleted successfully")
        ' cn.Close()
        'clear()
        ' auto_g()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim dt As New DataTable
        Dim x As String
        cn = New MySqlConnection("dsn=sas;user=root; pwd=root")
        Try
            cn.Open()
            x = InputBox("enter the course_id to be searched:")
            da = New MySqlDataAdapter("select * from course where course_id=' " & x & " ' ", cn)
            da.Fill(dt)
            TextBox1.Text = dt.Rows(0).Item(0)
            TextBox2.Text = dt.Rows(0).Item(1)
            TextBox3.Text = dt.Rows(0).Item(2)
            TextBox4.Text = dt.Rows(0).Item(3)
            TextBox5.Text = dt.Rows(0).Item(4)
            dgv1.DataSource = dt
            MsgBox("searched sucessfully")
            cn.Close()

        Catch ex As Exception
            MsgBox("invalid course_id,try again!!")
        Finally
            cn.Close()

        End Try

    End Sub
    Sub auto_g()
        TextBox1.Enabled = False
        cn.Open()
        cmd = New MySqlCommand("select max(course_id+1) from course ", cn)
        If IsDBNull(cmd.ExecuteScalar) Then
            TextBox1.Text = 1
        Else
            TextBox1.Text = cmd.ExecuteScalar
        End If
        cn.Close()
    End Sub
    Sub clear()
        TextBox1.Clear()
        TextBox1.Clear()
        TextBox1.Clear()
        TextBox1.Clear()
        TextBox1.Clear()


    End Sub
End Class
