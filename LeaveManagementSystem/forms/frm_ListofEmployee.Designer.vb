<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListofEmployee
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtempsearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtgemplist = New System.Windows.Forms.DataGridView()
        Me.dtgremain_List = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ts_PrevAll = New System.Windows.Forms.ToolStripButton()
        Me.ts_PrevSelected = New System.Windows.Forms.ToolStripButton()
        Me.ts_EditEmp = New System.Windows.Forms.ToolStripButton()
        Me.ts_DeleteEmp = New System.Windows.Forms.ToolStripButton()
        Me.ts_close = New System.Windows.Forms.ToolStripButton()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgremain_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(266, 41)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "List of Employees"
        '
        'txtempsearch
        '
        Me.txtempsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtempsearch.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempsearch.Location = New System.Drawing.Point(615, 24)
        Me.txtempsearch.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtempsearch.Multiline = True
        Me.txtempsearch.Name = "txtempsearch"
        Me.txtempsearch.Size = New System.Drawing.Size(214, 28)
        Me.txtempsearch.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(548, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Search :"
        '
        'dtgemplist
        '
        Me.dtgemplist.AllowUserToAddRows = False
        Me.dtgemplist.AllowUserToDeleteRows = False
        Me.dtgemplist.AllowUserToResizeColumns = False
        Me.dtgemplist.AllowUserToResizeRows = False
        Me.dtgemplist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgemplist.Location = New System.Drawing.Point(19, 68)
        Me.dtgemplist.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dtgemplist.Name = "dtgemplist"
        Me.dtgemplist.RowHeadersVisible = False
        Me.dtgemplist.RowTemplate.Height = 24
        Me.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgemplist.Size = New System.Drawing.Size(810, 390)
        Me.dtgemplist.StandardTab = True
        Me.dtgemplist.TabIndex = 39
        '
        'dtgremain_List
        '
        Me.dtgremain_List.AllowUserToAddRows = False
        Me.dtgremain_List.AllowUserToDeleteRows = False
        Me.dtgremain_List.AllowUserToResizeColumns = False
        Me.dtgremain_List.AllowUserToResizeRows = False
        Me.dtgremain_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgremain_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgremain_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgremain_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgremain_List.Location = New System.Drawing.Point(393, 118)
        Me.dtgremain_List.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dtgremain_List.Name = "dtgremain_List"
        Me.dtgremain_List.RowHeadersVisible = False
        Me.dtgremain_List.RowTemplate.Height = 24
        Me.dtgremain_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgremain_List.ShowCellToolTips = False
        Me.dtgremain_List.Size = New System.Drawing.Size(21, 18)
        Me.dtgremain_List.TabIndex = 40
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_PrevAll, Me.ts_PrevSelected, Me.ts_EditEmp, Me.ts_DeleteEmp, Me.ts_close})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 473)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(844, 32)
        Me.ToolStrip1.TabIndex = 50
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ts_PrevAll
        '
        Me.ts_PrevAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_PrevAll.Image = Global.LeaveManagementSystem.My.Resources.Resources.print
        Me.ts_PrevAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_PrevAll.Name = "ts_PrevAll"
        Me.ts_PrevAll.Size = New System.Drawing.Size(29, 29)
        Me.ts_PrevAll.Text = "Preview All Employee"
        '
        'ts_PrevSelected
        '
        Me.ts_PrevSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_PrevSelected.Image = Global.LeaveManagementSystem.My.Resources.Resources._1000px_Gnome_document_print_svg
        Me.ts_PrevSelected.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_PrevSelected.Name = "ts_PrevSelected"
        Me.ts_PrevSelected.Size = New System.Drawing.Size(29, 29)
        Me.ts_PrevSelected.Text = "Preview Selected Employee"
        '
        'ts_EditEmp
        '
        Me.ts_EditEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_EditEmp.Image = Global.LeaveManagementSystem.My.Resources.Resources.edit
        Me.ts_EditEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_EditEmp.Name = "ts_EditEmp"
        Me.ts_EditEmp.Size = New System.Drawing.Size(29, 29)
        Me.ts_EditEmp.Text = "Edit"
        '
        'ts_DeleteEmp
        '
        Me.ts_DeleteEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_DeleteEmp.Enabled = False
        Me.ts_DeleteEmp.Image = Global.LeaveManagementSystem.My.Resources.Resources.trash
        Me.ts_DeleteEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_DeleteEmp.Name = "ts_DeleteEmp"
        Me.ts_DeleteEmp.Size = New System.Drawing.Size(29, 29)
        Me.ts_DeleteEmp.Text = "Delete"
        '
        'ts_close
        '
        Me.ts_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_close.Image = Global.LeaveManagementSystem.My.Resources.Resources.close
        Me.ts_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_close.Name = "ts_close"
        Me.ts_close.Size = New System.Drawing.Size(29, 29)
        Me.ts_close.Text = "Close"
        '
        'frm_ListofEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 505)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtempsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtgemplist)
        Me.Controls.Add(Me.dtgremain_List)
        Me.Name = "frm_ListofEmployee"
        Me.Text = "Employee"
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgremain_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents txtempsearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtgemplist As DataGridView
    Friend WithEvents dtgremain_List As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ts_PrevAll As ToolStripButton
    Friend WithEvents ts_PrevSelected As ToolStripButton
    Friend WithEvents ts_EditEmp As ToolStripButton
    Friend WithEvents ts_close As ToolStripButton
    Friend WithEvents ts_DeleteEmp As ToolStripButton
End Class
