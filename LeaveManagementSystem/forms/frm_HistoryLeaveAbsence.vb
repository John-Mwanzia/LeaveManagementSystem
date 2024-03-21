Public Class frm_HistoryLeaveAbsence
    Private Sub frm_HistoryLeaveAbsence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT  e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' ,DATE(`LEAVEDATE`) as 'Start of Date Leave', DATE(LEAVEENDDATE) as 'End of Date Leave',`NODAYS` as 'No. Days', `REASON` as 'Reasons'  FROM `employee` e,`leave` l  WHERE  e.`EMPID`=l.`EMPID`"
        reloadDtg(sql, dtgapprovedlist)
    End Sub

    Private Sub txtapprovesearch_TextChanged(sender As Object, e As EventArgs) Handles txtapprovesearch.TextChanged
        Try
            '----------------------------------approved list.
            sql = "SELECT  e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' , DATE(`LEAVEDATE`) as 'Start of Date Leave',`LEAVEENDDATE` as 'End of Date Leave', `NODAYS` as 'No. Days', `REASON` as 'Reasons'   FROM `employee` e,`leave` l  WHERE e.`EMPID`=l.`EMPID` " &
        " AND (e.`EMPID` LIKE '%" & txtapprovesearch.Text & "%' OR concat( `emp_fname`,' ', `emp_lname`) LIKE '%" & txtapprovesearch.Text & "%')"
            reloadDtg(sql, dtgapprovedlist)
            'sql = "SELECT LEAVECODE, e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' , DATE(`LEAVEDATE`) as 'Date of Leave', `NODAYS` as 'No. Days', `REASON` as 'Reasons', `DAYOFFSCHEDULE` as 'Dayoff Schedule'   FROM `employee` e,`leave` l  WHERE   AND e.`EMPID`=l.`EMPID`" & _
            '" AND (e.`EMPID` LIKE '%" & txtapprovesearch.Text & "%' OR concat( `emp_fname`,' ', `emp_lname`) LIKE '%" & txtapprovesearch.Text & "%')"
            'reloadDtg(sql, dtgapprovedlist)
            'dtgapprovedlist.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class