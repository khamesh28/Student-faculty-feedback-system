Imports MySql.Data.MySqlClient


Public Class WebForm1
    Inherits System.Web.UI.Page


    Class details
        Public facname, subcode, classdet As String
    End Class



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        display(Request.QueryString("id"))

    End Sub

    Public Function read(linkid As String) As details
        Dim a As New details
        Dim con As New MySqlConnection("server=127.0.0.1;uid=root;pwd=ajmal@79792004;database=Feedback")
        con.Open()
        Dim com As New MySqlCommand("select * from links where linkscol='" & linkid & "'", con)
        Dim rs As MySqlDataReader
        rs = com.ExecuteReader
        If rs.Read Then
            'idlinks, , , , linkscol, feedbackno
            a.subcode = rs("subname")
            a.facname = rs("facname")
            a.classdet = rs("class")
            con.Close()
            Return a
        End If
        con.Close()
        Return Nothing
    End Function


    Public Function display(linkid As String) As details
        Dim a As New details
        Dim con As New MySqlConnection("server=127.0.0.1;uid=root;pwd=ajmal@79792004;database=Feedback")
        con.Open()
        Dim com As New MySqlCommand("select * from links where linkscol='" & linkid & "'", con)
        Dim rs As MySqlDataReader
        rs = com.ExecuteReader
        If rs.Read Then
            'idlinks, , , , linkscol, feedbackno
            Label14.Text = rs("subname") & " - " & rs("facname")
            con.Close()
            Return a
        End If
        con.Close()
        Return Nothing
    End Function


    Protected Sub RadioButtonList2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub RadioButtonList2_SelectedIndexChanged1(sender As Object, e As EventArgs)

    End Sub

    Public Function getNumber(c1 As RadioButton, c2 As RadioButton, c3 As RadioButton, c4 As RadioButton, c5 As RadioButton)
        Dim i As Integer = -1
        If c1.Checked Then
            i = 1
        ElseIf c2.Checked Then
            i = 2
        ElseIf c3.Checked Then
            i = 3
        ElseIf c4.Checked Then
            i = 4
        ElseIf c5.Checked Then
            i = 5
        End If
        Return i
    End Function


    Public Function getNumber(c1 As RadioButton, c2 As RadioButton)
        Dim i As Integer = -1
        If c1.Checked Then
            i = 1
        ElseIf c2.Checked Then
            i = 2
        End If
        Return i
    End Function


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As details = read(Request.QueryString("id"))
        Dim flag As Boolean
        flag = True
        If IsNothing(a) Then
            Return
        End If
        If RadioButtonList1.SelectedIndex = -1 Then
            flag = False
            Label1.Visible = True
        End If
        If RadioButtonList2.SelectedIndex = -1 Then
            flag = False
            Label2.Visible = True
        End If
        If RadioButtonList3.SelectedIndex = -1 Then
            flag = False
            Label3.Visible = True
        End If
        If RadioButtonList4.SelectedIndex = -1 Then
            flag = False
            Label4.Visible = True
        End If
        If RadioButtonList5.SelectedIndex = -1 Then
            flag = False
            Label5.Visible = True
        End If
        If RadioButtonList6.SelectedIndex = -1 Then
            flag = False
            Label6.Visible = True
        End If
        If RadioButtonList7.SelectedIndex = -1 Then
            flag = False
            Label7.Visible = True
        End If
        If RadioButtonList8.SelectedIndex = -1 Then
            flag = False
            Label8.Visible = True
        End If
        If RadioButtonList9.SelectedIndex = -1 Then
            flag = False
            Label9.Visible = True
        End If
        If RadioButtonList10.SelectedIndex = -1 Then
            flag = False
            Label10.Visible = True
        End If
        If RadioButtonList11.SelectedIndex = -1 Then
            flag = False
            Label11.Visible = True
        End If
        If RadioButtonList12.SelectedIndex = -1 Then
            flag = False
            Label12.Visible = True
        End If
        If Len(Trim(TextBox1.Text)) = 0 Then
            flag = False
            Label13.Visible = True
        End If



        If flag Then
            Dim con As New MySqlConnection("server=127.0.0.1;uid=root;pwd=ajmal@79792004;database=Feedback")
            con.Open()
            Dim com As New MySqlCommand("insert into feedback (subcode, facname, class, covered, organized, communicated, discussion, helping, material, completed, m1, m2, q1, d1, e1, suggession) values(@subcode, @facname, @class, @covered, @organized, @communicated, @discussion, @helping, @material, @completed, @m1, @m2, @q1, @d1, @e1, @suggession)", con)
            With com.Parameters
                .AddWithValue("@subcode", a.subcode)
                .AddWithValue("@facname", a.facname)
                .AddWithValue("@class", a.classdet)
                .AddWithValue("@covered", RadioButtonList1.SelectedIndex)
                .AddWithValue("@organized", RadioButtonList2.SelectedIndex)
                .AddWithValue("@communicated", RadioButtonList3.SelectedIndex)
                .AddWithValue("@discussion", RadioButtonList4.SelectedIndex)
                .AddWithValue("@helping", RadioButtonList5.SelectedIndex)
                .AddWithValue("@material", RadioButtonList6.SelectedIndex)
                .AddWithValue("@completed", RadioButtonList7.SelectedIndex)
                .AddWithValue("@m1", RadioButtonList8.SelectedIndex)
                .AddWithValue("@m2", RadioButtonList9.SelectedIndex)
                .AddWithValue("@q1", RadioButtonList10.SelectedIndex)
                .AddWithValue("@d1", RadioButtonList11.SelectedIndex)
                .AddWithValue("@e1", RadioButtonList12.SelectedIndex)
                .AddWithValue("@suggession", TextBox1.Text)
            End With
            com.ExecuteNonQuery()
            con.Close()
            Response.Redirect("WebForm2.aspx")
        End If
    End Sub

End Class

