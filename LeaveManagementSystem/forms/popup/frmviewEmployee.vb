﻿Public Class frmviewEmployee
    Private Sub frmviewEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sql = "SELECT `EMPID` AS 'EMPLOYEEID',CONCAT( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) AS 'NAME'" _
                & ", `emp_age` AS 'AGE', `emp_sex` AS 'GENDER', `status` AS 'STATUS', `address` AS 'ADDRESS', `contact` AS 'CONTACT'  FROM `employee` WHERE REMAININGLEAVE not in (0)"
            reloadDtg(sql, dtgemplist)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtempsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtempsearch.TextChanged
        Try
            sql = "SELECT `EMPID` AS 'EMPLOYEEID',CONCAT( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) AS 'NAME'" _
           & ", `emp_age` AS 'AGE', `emp_sex` AS 'GENDER', `status` AS 'STATUS', `address` AS 'ADDRESS'" _
           & ", `contact` AS 'CONTACT'  FROM `employee` WHERE REMAININGLEAVE not in (0) and (`EMPID` LIKE '%" & txtempsearch.Text & "%'" _
           & " OR emp_fname LIKE '%" & txtempsearch.Text & "%' OR emp_lname LIKE '%" & txtempsearch.Text & "%')"
            reloadDtg(sql, dtgemplist)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dtgemplist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgemplist.DoubleClick
        Try
            frm_ApplyLeave.txtEmployeeId.Text = dtgemplist.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Try
            frm_ApplyLeave.txtEmployeeId.Text = dtgemplist.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub
End Class