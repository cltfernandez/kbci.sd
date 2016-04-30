Imports System.Windows.Forms

Public Class frmSDS_Main_TEntry_Oth
    Private sdother As ent_sdothers_list
    Private newdata As Boolean
    Private othtran As ent_sdothers
    Private closeform As Boolean = False
    Private Sub frmSDS_Main_TEntry_Oth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadList()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        newdata = True
        GroupBox3.Visible = True
        GroupBox1.Enabled = False
        SetSecDefBtn()
        ClearFields()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox3.Visible = False
        GroupBox1.Enabled = True
        SetMainDefBtn()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim _sdother As ent_sdothers = New ent_sdothers
        With _sdother
            .OthType = Mid(ComboBox1.Text, 1, 1)
            .OthName = TextBox5.Text
            .OthAmount = Decimal.Parse(TextBox2.Text)
            .OthBank = TextBox3.Text
            .OthChkNo = TextBox4.Text
            .OthUser = SPUSER.SPUSERID
            .OthDate = CTRL_S.SYSDATE
            .OthTime = TimeValue(Now)
            If newdata Then .addData() Else .sdothers_id = othtran.sdothers_id : .updData()
        End With
        GroupBox3.Visible = False
        GroupBox1.Enabled = True
        SetMainDefBtn()
        LoadList()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListView1.SelectedIndices.Count > 0 Then
            newdata = False
            GroupBox3.Visible = True
            GroupBox1.Enabled = False
            SetSecDefBtn()
            With othtran
                ComboBox1.SelectedIndex = ComboBox1.FindString(.OthType & " - ")
                TextBox5.Text = .OthName
                TextBox2.Text = FormatNumber(.OthAmount, 2)
                TextBox3.Text = .OthBank
                TextBox4.Text = .OthChkNo
            End With
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Then e.Handled = False Else e.Handled = True
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        If IsNumeric(TextBox2.Text) Then TextBox2.Text = FormatNumber(TextBox2.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox2.Text = "0.00"
    End Sub
    Private Sub LoadList()
        Dim _sdother As New BindingSource
        sdother = New ent_sdothers_list
        sdother.getDataList("WHERE OTHUSER='" & SPUSER.SPUSERID & "'")
        _sdother.DataSource = sdother
        DataGridView1.DataSource = _sdother
        FillLV(ListView1, DataGridView1, "0:94:77:168:112:68:132:136:52", "1:2:2:1:3:2:1:2:2", False)
        _sdother = Nothing
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedIndices.Count > 0 Then
            othtran = sdother.Find(AddressOf FindID)
        End If        

    End Sub
    Private Function FindID(ByVal sdo As ent_sdothers) As Boolean
        If sdo.sdothers_id = Integer.Parse(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text.ToString()) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListView1.SelectedIndices.Count > 0 Then
            Dim xmsg
            xmsg = MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "DELETE TRANSACTION")
            If xmsg = vbYes Then
                othtran.delData()
                LoadList()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        closeform = True
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        LoadList()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim _sdother As New BindingSource
        sdother = New ent_sdothers_list
        sdother.getDataList("WHERE OTHUSER='" & SPUSER.SPUSERID & "' AND OTHNAME LIKE '%" & TextBox1.Text.Trim & "%'")
        _sdother.DataSource = sdother
        DataGridView1.DataSource = _sdother
        FillLV(ListView1, DataGridView1, "0:94:77:168:112:68:132:136:52", "1:2:2:1:3:2:1:2:2", False)
        _sdother = Nothing
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        Me.AcceptButton = Button10
        Me.CancelButton = Button7
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        SetMainDefBtn()
    End Sub

    Private Sub SetMainDefBtn()
        Me.AcceptButton = Button3
        Me.CancelButton = Button1
    End Sub
    Private Sub SetSecDefBtn()
        Me.AcceptButton = Button6
        Me.CancelButton = Button5        
    End Sub
    Private Sub ClearFields()
        For Each Control In GroupBox3.Controls
            If TypeOf Control Is TextBox Then Control.Text = String.Empty
            If TypeOf Control Is ComboBox Then Control.SelectedIndex = -1
        Next
    End Sub

    Private Sub frmSDS_Main_TEntry_Oth_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closeform Then e.Cancel = True
    End Sub
End Class
