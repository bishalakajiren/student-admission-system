'Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class payment
    Dim cn As New MySqlConnection("server=localhost;database=sas;user=root; pwd=root")
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    'Sub FK2()
    '    cn.Open()
    '    cmd = New MySqlCommand("select course_id from course", cn)
    '    Dim dr As MySqlDataReader = cmd.ExecuteReader
    '    'ComboBox3.Items.Clear()
    '    While (dr.Read)
    '        'ComboBox3.Items.Add(dr(0))
    '        TextBox4.Text = dr(1).ToString
    '    End While
    '    dr.Close()
    '    cn.Close()

    'End Sub
    Sub FK1()
        TextBox3.Enabled = False
        'TextBox5.Enabled = False
        cn.Open()
        cmd = New MySqlCommand("select student_id from student ", cn)
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        While (dr.Read)
            ComboBox1.Items.Add(dr(0))
            'TextBox5.Text = dr(0).ToString
            ' TextBox3.Text.Add(dr(2))

        End While
        dr.Close()
        cn.Close()
    End Sub
    Sub auto_g()
        TextBox1.Enabled = False
        cn.Open()
        cmd = New MySqlCommand("select max(payment_id)+1 from payment", cn)
        If IsDBNull(cmd.ExecuteScalar) Then
            TextBox1.Text = 101
        Else
            TextBox1.Text = cmd.ExecuteScalar
        End If
        cn.Close()
    End Sub
    Sub auto1_g()
        TextBox1.Enabled = False
        cn.Open()
        cmd = New MySqlCommand("select max(payment_id)+1 from payment", cn)
        If IsDBNull(cmd.ExecuteScalar) Then
            TextBox1.Text = 101
        Else
            TextBox1.Text = cmd.ExecuteScalar
        End If
        cn.Close()
    End Sub




    Private Sub payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FK1()
        ' FK2()
        auto_g()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
    '    TextBox2.Enabled = False
    '    TextBox4.Enabled = False
    '    cn.Open()
    '    cmd = New MySqlCommand("select * from course where course_id= ' " & ComboBox3.Text & " ' ", cn)
    '    Dim dr As MySqlDataReader = cmd.ExecuteReader
    '    While (dr.Read)
    '        TextBox2.Text = dr(2).ToString
    '        TextBox4.Text = dr(1).ToString
    '    End While
    '    dr.Close()
    '    cn.Close()
    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        TextBox4.Enabled = False
        cn.Open()
        cmd = New MySqlCommand("select * from student where student_id= ' " & ComboBox1.Text & " ' ", cn)
        'cmd = New MySqlCommand("select * from student where course_id= ' " & ComboBox1.Text & " ' ", cn)
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        While (dr.Read)
            TextBox3.Text = dr(1).ToString
            TextBox5.Text = dr(3).ToString

        End While
        dr.Close()
        cn.Close()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
            cmd = New MySqlCommand("select course_name from course where course_id='" & TextBox5.Text & "'", cn)
            Dim dr1 As MySqlDataReader = cmd.ExecuteReader
            While (dr1.Read)
                TextBox4.Text = dr1.Item(0)

            End While
            dr1.Close()
            cn.Close()
        End If

        If cn.State = ConnectionState.Closed Then
            cn.Open()
            cmd = New MySqlCommand("select course_fee from course where course_id='" & TextBox5.Text & "'", cn)
            Dim dr2 As MySqlDataReader = cmd.ExecuteReader
            While (dr2.Read)
                TextBox2.Text = dr2.Item(0)

            End While
            dr2.Close()
            cn.Close()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()
        cmd = New MySqlCommand("insert into payment values (' " & TextBox2.Text & " ' , ' " & TextBox1.Text & " ' , ' " & ComboBox1.Text & " ',' " & TextBox5.Text & " '   )", cn)
        cmd.ExecuteNonQuery()
        MsgBox("submit sucessfully")
        cn.Close()
        'showdb()
        'clear()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
       
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class