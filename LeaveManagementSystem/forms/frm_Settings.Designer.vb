<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnpositionload = New System.Windows.Forms.Button()
        Me.dtglistposition = New System.Windows.Forms.DataGridView()
        Me.npositiondelete = New System.Windows.Forms.Button()
        Me.npositionupdate = New System.Windows.Forms.Button()
        Me.npositionsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btndeptLoad = New System.Windows.Forms.Button()
        Me.dtgdeptlist = New System.Windows.Forms.DataGridView()
        Me.btndeptDelete = New System.Windows.Forms.Button()
        Me.btndeptUpdate = New System.Windows.Forms.Button()
        Me.btndeptSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdepartment = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtglistposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgdeptlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnpositionload)
        Me.GroupBox1.Controls.Add(Me.dtglistposition)
        Me.GroupBox1.Controls.Add(Me.npositiondelete)
        Me.GroupBox1.Controls.Add(Me.npositionupdate)
        Me.GroupBox1.Controls.Add(Me.npositionsave)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtposition)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(318, 359)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position of the Employee"
        '
        'btnpositionload
        '
        Me.btnpositionload.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnpositionload.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpositionload.Location = New System.Drawing.Point(237, 109)
        Me.btnpositionload.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnpositionload.Name = "btnpositionload"
        Me.btnpositionload.Size = New System.Drawing.Size(75, 40)
        Me.btnpositionload.TabIndex = 6
        Me.btnpositionload.Text = "Load"
        Me.btnpositionload.UseVisualStyleBackColor = False
        '
        'dtglistposition
        '
        Me.dtglistposition.AllowUserToAddRows = False
        Me.dtglistposition.AllowUserToDeleteRows = False
        Me.dtglistposition.AllowUserToResizeColumns = False
        Me.dtglistposition.AllowUserToResizeRows = False
        Me.dtglistposition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtglistposition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtglistposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistposition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglistposition.Location = New System.Drawing.Point(6, 61)
        Me.dtglistposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtglistposition.Name = "dtglistposition"
        Me.dtglistposition.Size = New System.Drawing.Size(225, 290)
        Me.dtglistposition.TabIndex = 1
        '
        'npositiondelete
        '
        Me.npositiondelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.npositiondelete.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npositiondelete.Location = New System.Drawing.Point(237, 205)
        Me.npositiondelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.npositiondelete.Name = "npositiondelete"
        Me.npositiondelete.Size = New System.Drawing.Size(75, 40)
        Me.npositiondelete.TabIndex = 5
        Me.npositiondelete.Text = "Delete"
        Me.npositiondelete.UseVisualStyleBackColor = False
        '
        'npositionupdate
        '
        Me.npositionupdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.npositionupdate.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npositionupdate.Location = New System.Drawing.Point(237, 157)
        Me.npositionupdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.npositionupdate.Name = "npositionupdate"
        Me.npositionupdate.Size = New System.Drawing.Size(75, 40)
        Me.npositionupdate.TabIndex = 4
        Me.npositionupdate.Text = "Update"
        Me.npositionupdate.UseVisualStyleBackColor = False
        '
        'npositionsave
        '
        Me.npositionsave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.npositionsave.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npositionsave.Location = New System.Drawing.Point(237, 61)
        Me.npositionsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.npositionsave.Name = "npositionsave"
        Me.npositionsave.Size = New System.Drawing.Size(75, 40)
        Me.npositionsave.TabIndex = 3
        Me.npositionsave.Text = "Save"
        Me.npositionsave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Position :"
        '
        'txtposition
        '
        Me.txtposition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.Location = New System.Drawing.Point(79, 27)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtposition.Multiline = True
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(233, 26)
        Me.txtposition.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btndeptLoad)
        Me.GroupBox2.Controls.Add(Me.dtgdeptlist)
        Me.GroupBox2.Controls.Add(Me.txtdepartment)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btndeptDelete)
        Me.GroupBox2.Controls.Add(Me.btndeptUpdate)
        Me.GroupBox2.Controls.Add(Me.btndeptSave)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(346, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(340, 359)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Department of the Employee"
        '
        'btndeptLoad
        '
        Me.btndeptLoad.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btndeptLoad.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptLoad.Location = New System.Drawing.Point(259, 109)
        Me.btndeptLoad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndeptLoad.Name = "btndeptLoad"
        Me.btndeptLoad.Size = New System.Drawing.Size(75, 40)
        Me.btndeptLoad.TabIndex = 6
        Me.btndeptLoad.Text = "Load"
        Me.btndeptLoad.UseVisualStyleBackColor = False
        '
        'dtgdeptlist
        '
        Me.dtgdeptlist.AllowUserToAddRows = False
        Me.dtgdeptlist.AllowUserToDeleteRows = False
        Me.dtgdeptlist.AllowUserToResizeColumns = False
        Me.dtgdeptlist.AllowUserToResizeRows = False
        Me.dtgdeptlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgdeptlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgdeptlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgdeptlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgdeptlist.Location = New System.Drawing.Point(6, 61)
        Me.dtgdeptlist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgdeptlist.Name = "dtgdeptlist"
        Me.dtgdeptlist.Size = New System.Drawing.Size(247, 290)
        Me.dtgdeptlist.TabIndex = 1
        '
        'btndeptDelete
        '
        Me.btndeptDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btndeptDelete.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptDelete.Location = New System.Drawing.Point(259, 205)
        Me.btndeptDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndeptDelete.Name = "btndeptDelete"
        Me.btndeptDelete.Size = New System.Drawing.Size(75, 40)
        Me.btndeptDelete.TabIndex = 5
        Me.btndeptDelete.Text = "Delete"
        Me.btndeptDelete.UseVisualStyleBackColor = False
        '
        'btndeptUpdate
        '
        Me.btndeptUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btndeptUpdate.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptUpdate.Location = New System.Drawing.Point(259, 157)
        Me.btndeptUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndeptUpdate.Name = "btndeptUpdate"
        Me.btndeptUpdate.Size = New System.Drawing.Size(75, 40)
        Me.btndeptUpdate.TabIndex = 4
        Me.btndeptUpdate.Text = "Update"
        Me.btndeptUpdate.UseVisualStyleBackColor = False
        '
        'btndeptSave
        '
        Me.btndeptSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btndeptSave.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptSave.Location = New System.Drawing.Point(259, 61)
        Me.btndeptSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndeptSave.Name = "btndeptSave"
        Me.btndeptSave.Size = New System.Drawing.Size(75, 40)
        Me.btndeptSave.TabIndex = 3
        Me.btndeptSave.Text = "Save"
        Me.btndeptSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department :"
        '
        'txtdepartment
        '
        Me.txtdepartment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepartment.Location = New System.Drawing.Point(114, 27)
        Me.txtdepartment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdepartment.Multiline = True
        Me.txtdepartment.Name = "txtdepartment"
        Me.txtdepartment.Size = New System.Drawing.Size(211, 26)
        Me.txtdepartment.TabIndex = 2
        '
        'frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 391)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frm_Settings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtglistposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgdeptlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnpositionload As Button
    Friend WithEvents dtglistposition As DataGridView
    Friend WithEvents npositiondelete As Button
    Friend WithEvents npositionupdate As Button
    Friend WithEvents npositionsave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtposition As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btndeptLoad As Button
    Friend WithEvents dtgdeptlist As DataGridView
    Friend WithEvents btndeptDelete As Button
    Friend WithEvents btndeptUpdate As Button
    Friend WithEvents btndeptSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdepartment As TextBox
End Class
