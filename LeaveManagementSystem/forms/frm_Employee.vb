Public Class frm_Employee

    'declares a public string variable named empid and initializes it with an empty string. This variable will be used to store an employee ID.
    Public empid As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'loadautonumber("employee", txtcode)
            'starts a loop that iterates over each control within GroupBox9.
            For Each ctrl As Control In GroupBox9.Controls
                If ctrl.GetType Is GetType(TextBox) Then  'Checks if the current control in the loop is a text box.
                    If ctrl.Text = "" Then  'Checks if the text of the current control is empty.
                        MsgBox("One of the box is empty. It needed to be filled up.", MsgBoxStyle.Exclamation)
                        'Exits the subroutine early if a required field is empty.
                        Return
                    End If
                End If
                If ctrl.GetType Is GetType(ComboBox) Then
                    If ctrl.Text = "----Select-----" Then
                        MsgBox("You have to set the correct information.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If
            Next

            For Each ctrl As Control In GroupBox10.Controls
                If ctrl.GetType Is GetType(ComboBox) Then
                    If ctrl.Text = "----Select-----" Then
                        MsgBox("You have to set the correct information.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If

                If ctrl.GetType Is GetType(TextBox) Then
                    If ctrl.Text = "" Then
                        MsgBox("One of the box is empty. It needs to be filled up.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If
            Next

            ' Calculates the age of the employee based on their birth date (dtpdbirth.Value). It divides the difference in days between the birth date and the current date by 12 months and 31 days per month.
            Dim bdate As Integer = Math.Round(DateDiff(DateInterval.DayOfYear, dtpdbirth.Value, Now) / 12 / 31)
            If bdate < 18 Then
                MsgBox("Invalid birth of date.", MsgBoxStyle.Exclamation)
                Exit Sub  ' Exits the subroutine early if the birth date is invalid.
            End If


            '---------------------------------------------------------
            Dim rdo As String = ""
            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew " _
                & " WHERE e.`EMPID`=ew.`EMPID` AND e.EMPID ='" & txtcode.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then  ' Checks if any rows were returned from the query, indicating that the employee already exists in the database.
                MsgBox("user already exists")

                '-------------------update
                'determines the gender of the employee.
                If rdomale.Checked = True Then
                    rdo = "MALE"
                Else
                    rdo = "FEMALE"
                End If

                'update the employee_workinfo table with the new employee data.
                sql = "UPDATE `employee_workinfo` SET  `d_rate`='" & txtdrate.Text _
                                 & "', `p_method`='" & txtpmethod.Text & "', `position`='" & txtposition.Text _
                                 & "', `d_hired`='" & Format(dtpdhired.Value, "yyyy-MM-dd") &
                                 "', `DEPARTMENT`='" & cbodeaprtment.Text &
                                 "',`w_type`='" & cbowtype.Text & "' WHERE `EMPID`='" & txtcode.Text & "'"

                'Executes the SQL update query to update the employee_workinfo table without displaying a message box upon success.
                createNoMsg(sql)

                'SQL query to update the employee table with the new employee data.
                sql = "UPDATE `employee` SET  `emp_fname`='" & txtfname.Text _
                & "', `emp_lname`='" & txtlname.Text & "', `emp_mname`='" & txtmname.Text _
                & "', `address`='" & txtaddress.Text & "', `contact`='" & txtcontact.Text & "', `status`='" & txtstatus.Text _
                & "', `birth_date`='" & Format(dtpdbirth.Value, "yyyy-MM-dd") & "', `birth_place`='" & txtbplace.Text & "', `emp_sex`='" & rdo _
                & "' , `emerg_contct`='" & txtemerg.Text _
                & "'  WHERE `EMPID`='" & txtcode.Text & "'"

                'Executes the SQL update query to update the employee table, passing the last name of the employee as an argument for identifying the record.
                updates(sql, txtlname.Text)



                '--------------end update
            Else
                'Executes this block of code if the employee doesn't already exist in the database.
                '------------------insert
                If rdomale.Checked = True Then
                    rdo = "MALE"
                Else
                    rdo = "FEMALE"
                End If
                sql = "INSERT INTO `employee_workinfo` (`EMPID`, `d_rate`, `p_method`, `position`,   `d_hired`,DEPARTMENT,w_type)" _
                        & " VALUES ('" & txtcode.Text & "','" & txtdrate.Text & "','" & txtpmethod.Text & "','" & txtposition.Text _
                        & "', '" & Format(dtpdhired.Value, "yyyy-MM-dd") & "','" & cbodeaprtment.Text & "','" & cbowtype.Text & "')"
                createNoMsg(sql)
                '------------------------------------------------------------------------------
                sql = "INSERT INTO `employee` (`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`" _
                & ", `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`" _
                & ", `emerg_contct`,`REMAININGLEAVE`,`DEFAULTLEAVE`) VALUES ('" & txtcode.Text & "','" & txtfname.Text & "','" & txtlname.Text _
                & "','" & txtmname.Text & "','" & txtaddress.Text & "','" & txtcontact.Text & "','" & txtstatus.Text _
                & "','" & Format(dtpdbirth.Value, "yyyy-MM-dd") & "','" & txtbplace.Text & "','" & rdo & "','" & txtemerg.Text & "',30,30)"

                'Executes the SQL insert query to insert the new employee data into the employee table, passing the full name of the employee as an argument for identifying the record.
                create(sql, txtfname.Text & " " & txtlname.Text)
                ''-----------------------------------------------
                'SQL query to insert default leave information for the new employee into the tblleaveinfo table
                sql = "INSERT INTO `tblleaveinfo`  (`EMPID`, `LEAVEDAYS`, `REASONS`)" _
                & " VALUES ('" & txtcode.Text & "',15,'SICK'),('" & txtcode.Text & "',15,'Vacation')"
                createNoMsg(sql)
                '--------------------------------------------------
                'Updates the auto-generated employee ID in the database to ensure uniqueness.
                updateautonumber("employee")
                '---------------end insert
            End If
            'Clears the text fields
            cleartext(GroupBox9)
            cleartext(GroupBox10)
            ' Loads the auto-generated employee ID into the txtcode text box.
            loadautonumber("employee", txtcode)
            ' Display a message indicating successful addition of the employee
            MsgBox("Employee information saved successfully.", MsgBoxStyle.Information)


        Catch ex As Exception
            MsgBox(ex.Message & " btnempsave_Click", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ts_New_Click(sender As Object, e As EventArgs) Handles ts_New.Click
        cleartext(GroupBox9)
        cleartext(GroupBox10)
        ' Loads the auto-generated employee ID into the txtcode text box.
        loadautonumber("employee", txtcode)
        emptitle.Text = "Add New Employee"
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged  'handles the TextChanged event of a text box named txtcode.
        Try

            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew " _
                 & " WHERE e.`EMPID`=ew.`EMPID` AND e.EMPID ='" & txtcode.Text & "'"
            reloadtxt(sql)

            If dt.Rows.Count > 0 Then





                txtdrate.Text = dt.Rows(0).Item("d_rate")
                txtpmethod.Text = dt.Rows(0).Item("p_method")
                txtposition.Text = dt.Rows(0).Item("position")
                dtpdhired.Value = dt.Rows(0).Item("d_hired")

                txtfname.Text = dt.Rows(0).Item("emp_fname")
                txtlname.Text = dt.Rows(0).Item("emp_lname")
                txtmname.Text = dt.Rows(0).Item("emp_mname")
                txtaddress.Text = dt.Rows(0).Item("address")
                txtcontact.Text = dt.Rows(0).Item("contact")
                txtstatus.Text = dt.Rows(0).Item("status")
                dtpdbirth.Value = dt.Rows(0).Item("birth_date")
                txtbplace.Text = dt.Rows(0).Item("birth_place")
                If dt.Rows(0).Item("emp_sex") = "MALE" Then
                    rdomale.Checked = True
                Else
                    rdofemale.Checked = True
                End If
                txtemerg.Text = dt.Rows(0).Item("emerg_contct")
                cbodeaprtment.Text = dt.Rows(0).Item("DEPARTMENT")
                cbowtype.Text = dt.Rows(0).Item("w_type")
                'Else
                '    cleartext(GroupBox10)
                '    cleartext(GroupBox9)

            End If
            'aloadautonumber("employee", txtcode)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillcbo("SELECT * FROM `tblsettings` WHERE  `FORTHE`='Position'", txtposition)  'query the tblsettings for the positions fill the select options of the txtposition combo box when the form loads
        cleartext(GroupBox9)
        cleartext(GroupBox10)
        fillcbo("SELECT `DEPARTMENT` FROM `tbldepartment` ", cbodeaprtment)
        If empid = "" Then
            'Loads the auto-generated employee ID into the txtcode text box if empid is empty.
            loadautonumber("employee", txtcode)
        Else
            txtcode.Text = empid
        End If

    End Sub

    Private Sub ts_Close_Click(sender As Object, e As EventArgs) Handles ts_Close.Click
        Me.Close()
    End Sub
End Class