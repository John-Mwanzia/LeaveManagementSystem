﻿Public Class frm_ApplyLeave
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ' opens another form named frmviewEmployee as a dialog box. The With statement is used to simplify referencing properties and methods of the frmviewEmployee form.
        With frmviewEmployee
            .ShowDialog()
        End With
    End Sub

    Private Sub txtEmployeeId_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeId.TextChanged     'handles the TextChanged event of a textbox named txtEmployeeId.
        Try
            'select data from the database tables employee and employee_workinfo based on the provided employee ID (txtEmployeeId.Text).
            sql = "SELECT `d_rate`, `position`, `DEPARTMENT` FROM `employee` e ,`employee_workinfo` ew WHERE e.`EMPID`=ew.`EMPID` AND e.`EMPID`='" & txtEmployeeId.Text & "'"
            reloadtxt(sql) 'This line  executes the SQL query and loads the result into a DataTable.
            If dt.Rows.Count > 0 Then 'checks if there are rows in the DataTable dt, which would indicate that the employee information was successfully retrieved from the database.
                With dt.Rows(0) 'access to properties of the first row in the DataTable dt.
                    'retrieve specific column values from the first row of the DataTable dt and assign them to corresponding textboxes.
                    txtposition.Text = .Item("position")
                    txtsalary.Text = .Item("d_rate")
                    txtdepartment.Text = .Item("DEPARTMENT")
                End With
                sql = "SELECT * FROM `employee_workinfo` WHERE `EMPID` ='" & txtemid.Text & "'"  ' SQL query to retrieve additional information from the employee_workinfo table based on the employee ID.
                reloadtxt(sql)

                If dt.Rows(0).Item("w_type") = "Regular" Then
                    rdowithPay.Enabled = True
                Else
                    rdowithPay.Enabled = False
                End If

            Else
                'If no employee information is found in the database, this block of code clears the text from various textboxes.
                txtEmployeeId.Clear()
                txtposition.Clear()
                txtsalary.Clear()
                txtdepartment.Clear()
            End If

        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtpenddate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpenddate.ValueChanged, dtpdatestart.ValueChanged  'subroutine is triggered when the value of either dtpenddate or dtpdatestart date picker controls changes.
        Try
            'Calculates the number of days between the selected start date (dtpdatestart) and end date (dtpenddate) and assigns the result to a textbox named txtnoDays.
            txtnoDays.Text = DateDiff(DateInterval.Day, dtpdatestart.Value, dtpenddate.Value)

            'Calculates the number of days between the selected start and end dates again and stores it in the variable numdays.
            Dim numdays As Integer

            numdays = DateDiff(DateInterval.Day, dtpdatestart.Value, dtpenddate.Value)

            'Checks if the number of days is greater than zero. If so, it disables the time picker controls (dtpTimeFrom and dtpTimeTo) because it implies that the leave duration is more than a single day. Otherwise, it enables them.
            If numdays > 0 Then
                dtpTimeFrom.Enabled = False
                dtpTimeTo.Enabled = False
            Else
                dtpTimeFrom.Enabled = True
                dtpTimeTo.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_ApplyLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load  ' subroutine is executed when the form (frm_ApplyLeave) loads.
        Try
            'For Each rdo As Control In GroupBox2.Controls
            '    If TypeOf rdo Is RadioButton Then
            '        rdo.Enabled = False
            '    End If
            'Next
            '---------------------------------------
            'Sets the format of the time picker control dtpTimeFrom to display only the time and enables the option to select time directly from the control.
            dtpTimeFrom.Format = DateTimePickerFormat.Time
            dtpTimeFrom.ShowUpDown = True
            '----------------------------------
            dtpTimeTo.Format = DateTimePickerFormat.Time
            dtpTimeTo.ShowUpDown = True
            '-----------------------------------
            '  loadautonumber("applicationcode", lblcode)
            '--------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ts_New_Click(sender As Object, e As EventArgs) Handles ts_New.Click  'associated with a "New" or "Reset" functionality.

        ' functions clears the text content of the controls contained within the specified group boxes and the form.
        cleartext(GroupBox1)
        cleartext(GroupBox2)
        cleartext(GroupBox3)
        cleartext(GroupBox4)
        cleartext(GroupBox5)
        cleartext(Me)

        'Loops through each control within GroupBox2. For each control, it checks if it's a radio button. If it is, it disables the radio button (rdo.Enabled = False) and unchecks it (TryCast(rdo, RadioButton).Checked = False).
        For Each rdo As Control In GroupBox2.Controls
            If TypeOf rdo Is RadioButton Then
                rdo.Enabled = False
            End If
            If TypeOf rdo Is RadioButton Then
                TryCast(rdo, RadioButton).Checked = False
            End If
        Next

        'unchecks two specific radio buttons rdoWithoutPay and rdowithPay.
        rdoWithoutPay.Checked = False
        rdowithPay.Checked = False
    End Sub

    Private Sub ts_Save_Click(sender As Object, e As EventArgs) Handles ts_Save.Click
        'triggered when a button named ts_Save is clicked. It handles the process of saving leave application details.


        Try

            'For Each grp As Control In Me.Controls
            '    If TypeOf grp Is GroupBox Then
            '        For Each ctrl As Control In grp.Controls
            '            If TypeOf ctrl Is TextBox Then
            '                If ctrl.Text = "" Then
            '                    MessageBox.Show("Please put information in " & ctrl.Tag, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '                    Exit Sub
            '                End If
            '            End If
            '            If TypeOf ctrl Is RichTextBox Then
            '                If ctrl.Text = "" Then
            '                    MessageBox.Show("Please put information in " & ctrl.Tag, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '                    Exit Sub
            '                End If
            '            End If

            '        Next
            '    End If
            'Next

            'Checks if none of the radio buttons representing different types of leave (e.g., Sick, Vacation, Funeral) are selected. If none are selected, it displays an error message prompting the user to choose a leave type and exits the subroutine.

            If rdoAcidentOnDuty.Checked = False And rdoPaternity.Checked = False And rdoMaternity.Checked = False _
             And rdoVacation.Checked = False And rdoFuneral.Checked = False And rdoSick.Checked = False Then
                MessageBox.Show("Please choose your leave applied for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ''----------------------------------
            Dim rdoleaveformat As String = ""
            Dim rdoleaveapplied As String = ""

            If rdoWithoutPay.Checked = True Then
                rdoleaveformat = "Without Pay"
            ElseIf rdowithPay.Checked = True Then
                rdoleaveformat = "With Pay"
            End If

            ' --------------------------
            If rdoSick.Checked = True Then
                rdoleaveapplied = "Sick"
            ElseIf rdoVacation.Checked = True Then
                rdoleaveapplied = "Vacation"
            ElseIf rdoFuneral.Checked = True Then
                rdoleaveapplied = "Funeral"
            ElseIf rdoPaternity.Checked = True Then
                rdoleaveapplied = "Paternity"
            ElseIf rdoMaternity.Checked = True Then
                rdoleaveapplied = "Maternity"
            ElseIf rdoAcidentOnDuty.Checked = True Then
                rdoleaveapplied = "AccidentOnDuty"
            End If
            ''----------------------------------------------------

            'Calculates the duration of the leave in days (day). If the leave duration is less than a day, it calculates it based on the difference in hours between the start and end times.
            Dim day As Double
            Dim numdays As Integer
            Dim numtime As Integer
            numtime = DateDiff(DateInterval.Hour, dtpTimeFrom.Value, dtpTimeTo.Value)
            ' MsgBox(numtime)
            numdays = DateDiff(DateInterval.Day, dtpdatestart.Value, dtpenddate.Value)
            'MsgBox(numdays)
            If numdays = 0 Then
                If numtime >= 0 Then
                    day = 0.5
                ElseIf numtime = 12 Then
                    day = 1
                End If
            Else
                day = numdays
            End If


            ''------------------------------------------
            'SQL query to insert the leave application details into the leave table in the database.  executes this query using the create function.
            sql = "INSERT INTO `leave` (`EMPID`,`LEAVECODE`,`LEAVEFORMAT`, `LEAVEAPPLIED`, `DATEFROM`, `DATETO`,`LEAVEDATE`,`LEAVEENDDATE`, `NODAYS`, `REASON`,  `DAYOFFSCHEDULE`,`REMARKS`,`APPLIED`,`STATUS`) " _
            & "VALUES ('" & txtEmployeeId.Text & "','" & lblcode.Text & "','" & rdoleaveformat & "','" & rdoleaveapplied & "','" & Format(dtpTimeFrom.Value, "yyyy-MM-dd hh:mm:ss tt") &
            "','" & Format(dtpTimeTo.Value, "yyyy-MM-dd hh:mm:ss tt") & "','" & Format(dtpdatestart.Value, "yyyy-MM-dd hh:mm:ss tt") & "','" & Format(dtpenddate.Value, "yyyy-MM-dd hh:mm:ss tt") & "'," & day &
            ",'" & txtreasons.Text & "','" & Format(dtpNotfallWeekened.Value, "yyyy-MM-dd hh:mm:ss tt") & "','Approved',1,'Approved')"
            create(sql, "New Leave")


            ''------------------------------------------
            'SQL query to update the employee's status to on leave and decrease their remaining leave days in the database. It then executes this query using the createNoMsg function.
            sql = "UPDATE `employee` set `ONLEAVE`=1 ,`REMAININGLEAVE` =`REMAININGLEAVE`- " & day & " WHERE `EMPID`='" & txtemid.Text & "'"
            createNoMsg(sql)
            '-----------------------------------------
            'Updates the autonumber for application codes.
            updateautonumber("applicationcode")

            'Calls the ts_New_Click subroutine to reset the form for a new leave application.
            Call ts_New_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub txtemid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemid.KeyPress, txtnoDays.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtreasons_TextChanged(sender As Object, e As EventArgs) Handles txtreasons.TextChanged

    End Sub
End Class