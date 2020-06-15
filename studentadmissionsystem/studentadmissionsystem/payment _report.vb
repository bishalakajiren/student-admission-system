Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class payment__report
    Dim cn As New MySqlConnection("server=localhost;database=sas;user=root; pwd=root")
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Sub FK2()
        cn.Open()
        cmd = New MySqlCommand("select payment_id from payment", cn)
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        While (dr.Read)
            ComboBox1.Items.Add(dr(0))
            'TextBox4.Text = dr(0).ToString
        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ReadCrystalReport1()



    End Sub

    Private Sub payment__report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FK2()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim da As New MySqlDataAdapter("select * from payment where payment_id= ' " & ComboBox1.Text & " '", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim rpath = "C:\Users\HP\Documents\Visual Studio 2008\Projects\studentadmissionsystem\studentadmissionsystem\CrystalReport2.rpt"
        Dim doc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        doc.Load(rpath)
        doc.SetDataSource(ds.Tables(0))
        CrystalReportViewer1.ReportSource = doc
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub CrystalReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class