
Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class student
    Dim cn As New MySqlConnection("server=localhost;database=sas;user=root; pwd=root")
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Sub FK()
        cn.Open()
        cmd = New MySqlCommand("select course_id from course", cn)
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        While (dr.Read)
            ComboBox1.Items.Add(dr(0))
        End While
        dr.Close()
        cn.Close()


    End Sub


    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FK()
        showdb()
        auto_g()
        '  refresh()


    End Sub
    Sub auto_g()
        TextBox1.Enabled = False
        cn.Open()
        cmd = New MySqlCommand("select max(student_id)+1 from student", cn)
        If IsDBNull(cmd.ExecuteScalar) Then
            TextBox1.Text = 101
        Else
            TextBox1.Text = cmd.ExecuteScalar
        End If
        cn.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()
        cmd = New MySqlCommand("insert into student values (' " & TextBox1.Text & " ' , ' " & TextBox2.Text & " ' , ' " & TextBox3.Text & " ' , ' " & ComboBox1.Text & " ' , ' " & TextBox5.Text & " ' )", cn)
        cmd.ExecuteNonQuery()
        MsgBox("saved sucessfully")
        cn.Close()
        showdb()
        'clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox4.Enabled = False
        cn.Open()
        cmd = New MySqlCommand("select * from course where course_id= ' " & ComboBox1.Text & " ' ", cn)
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        While (dr.Read)
            TextBox4.Text = dr(1).ToString
        End While
        dr.Close()
        cn.Close()
    End Sub
    Sub showdb()
        Dim dt As New DataTable
        cn.Open()
        da = New MySqlDataAdapter("select * from student ", cn)
        da.Fill(dt)
        dgv1.DataSource = dt
        cn.Close()
    End Sub


    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox1.Focus()
        ' cn.Close()
        auto_g()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn.Open()
        Dim cmd As New MySqlCommand("update student set student_id=' " & TextBox1.Text & " ',student_name=' " & TextBox2.Text & " ' where student_id=' " & TextBox1.Text & " ' ", cn)
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
            x = InputBox("enter the student_id to be searched:")
            da = New MySqlDataAdapter("select * from student where student_id=' " & x & " ' ", cn)
            da.Fill(dt)
            TextBox1.Text = dt.Rows(0).Item(0)
            TextBox2.Text = dt.Rows(0).Item(1)
            TextBox3.Text = dt.Rows(0).Item(2)
            'TextBox4.Text = dt.Rows(0).Item(3)
            ComboBox1.Text = dt.Rows(0).Item(3)
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim dt As New DataTable
        Dim x As String
        'Dim cn As New MySqlConnection("dsn=sas;user=root; pwd=root")
        Try
            cn.Open()
            x = InputBox("enter the student_id to be deleted :")
            da = New MySqlDataAdapter("delete from student where student_id=' " & x & " ' ", cn)
            'cmd = New OdbcCommand("delete from course where course_id=' " & TextBox1.Text & " ' ", cn)
            da.Fill(dt)
            dgv1.DataSource = dt
            'MsgBox("searched sucessfully")
            cn.Close()
            'cmd.ExecuteNonQuery()
            MsgBox("deleted successfully")
        Catch ex As Exception
            MsgBox("invalid course_id,try again!!")

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

    'Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Call refresh()
    'End Sub
    'Sub refresh()
    '    TextBox1.Clear()
    '    TextBox2.Clear()
    '    TextBox3.Clear()
    '    TextBox5.Clear()
    '    ComboBox1.Text = ""
    'End Sub
End Class