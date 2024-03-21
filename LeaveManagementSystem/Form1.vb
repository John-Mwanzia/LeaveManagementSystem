Public Class Form1
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsRegEmp.Click
        closeChildForm()
        showForm(frm_Employee)
    End Sub

    Private Sub tsListEmp_Click(sender As Object, e As EventArgs) Handles tsListEmp.Click
        closeChildForm()
        showForm(frm_ListofEmployee)
    End Sub

    Private Sub tsApply_Click(sender As Object, e As EventArgs) Handles tsApply.Click
        closeChildForm()
        showForm(frm_ApplyLeave)
    End Sub

    Private Sub tsLeaveHistory_Click(sender As Object, e As EventArgs) Handles tsLeaveHistory.Click
        closeChildForm()
        showForm(frm_HistoryLeaveAbsence)
    End Sub

    Private Sub tsMaintenance_Click(sender As Object, e As EventArgs) Handles tsMaintenance.Click
        closeChildForm()
        showForm(frm_Settings)
    End Sub

    Private Sub tsUser_Click(sender As Object, e As EventArgs) Handles tsUser.Click
        closeChildForm()
        showForm(frm_User)
    End Sub

    Private Sub tsReport_Click(sender As Object, e As EventArgs) Handles tsReport.Click
        closeChildForm()
        showForm(frm_Reports)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        tsEmployee.Visible = False
        tsLeave.Visible = False
        tsMaintenance.Visible = False
        tsUser.Visible = False
        tsReport.Visible = False
        tsLogin.Text = "Login"
        tsLogin.Image = My.Resources.login

    End Sub

    Private Sub tsLogin_Click(sender As Object, e As EventArgs) Handles tsLogin.Click
        If tsLogin.Text = "Login" Then
            closeChildForm()
            showForm(LoginForm1)
        Else
            tsEmployee.Visible = False
            tsLeave.Visible = False
            tsMaintenance.Visible = False
            tsUser.Visible = False
            tsReport.Visible = False
            tsLogin.Text = "Login"
            tsLogin.Image = My.Resources.login
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub tsEmployee_Click(sender As Object, e As EventArgs) Handles tsEmployee.Click

    End Sub
End Class
