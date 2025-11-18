Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Modes.Gcm


Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' On Error Resume Next
        Dim idl As Integer = Request.QueryString("id")
        Dim sql As String
        Dim con As New MySqlConnection("server=127.0.0.1;uid=root;pwd=ajmal@79792004;database=Feedback")
        con.Open()
        Dim com As New MySqlCommand("SELECT count(*) as tot FROM feedback where idlink='" & idl & "'", con)
        Dim rs As MySqlDataReader
        rs = com.ExecuteReader
        If rs.Read Then
            Label1.Text = rs("tot")
        End If
        rs.Close()
        sql = "SELECT count(*) as tot FROM feedback where idlink='" & idl & "' and covered=0"
        com = New MySqlCommand(sql, con)
        rs = com.ExecuteReader
        If rs.Read Then
            Label2.Text = rs("tot")
        End If
        rs.Close()
        sql = "SELECT count(*) as tot FROM feedback where idlink='" & idl & "' and covered=1"
        com = New MySqlCommand(sql, con)
        rs = com.ExecuteReader
        If rs.Read Then
            Label3.Text = rs("tot")
        End If
        rs.Close()

        sql = "SELECT count(*) as tot FROM feedback where idlink='" & idl & "' and  organized=0"
        com = New MySqlCommand(sql, con)
        rs = com.ExecuteReader
        If rs.Read Then
            Label4.Text = rs("tot")
        End If
        rs.Close()



        sql = "SELECT count(*) as tot FROM feedback where idlink='" & idl & "' and  organized=1"
        com = New MySqlCommand(sql, con)
        rs = com.ExecuteReader
        If rs.Read Then
            Label5.Text = rs("tot")
        End If
        rs.Close()


        sql = "SELECT count(*) as tot FROM feedback where idlink='" & idl & "' and  organized=2"
        com = New MySqlCommand(sql, con)
        rs = com.ExecuteReader
        If rs.Read Then
            Label6.Text = rs("tot")
        End If
        rs.Close()


        sql = "SELECT count(*) as tot FROM feedback where idlink='" & idl & "' and  organized=3"
        com = New MySqlCommand(sql, con)
        rs = com.ExecuteReader
        If rs.Read Then
            Label7.Text = rs("tot")
        End If
        rs.Close()



        sql = "SELECT count(*) as tot FROM feedback where idlink='" & idl & "' and  organized=4"
        com = New MySqlCommand(sql, con)
        rs = com.ExecuteReader
        If rs.Read Then
            Label8.Text = rs("tot")
        End If
        rs.Close()


        sql = "SELECT suggession FROM feedback where idlink='" & idl & "'"
        com = New MySqlCommand(sql, con)
        rs = com.ExecuteReader
        Dim sno As Integer = 1
        While rs.Read
            Dim tr As New TableRow
            Dim td1, td2 As New TableCell
            td1.Text = sno
            td2.Text = rs("suggession")
            tr.Cells.Add(td1)
            tr.Cells.Add(td2)
            Table2.Rows.Add(tr)
            sno = sno + 1
        End While

        con.Close()
    End Sub
End Class
