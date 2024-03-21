<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsEmployee = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsRegEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsListEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLeave = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsApply = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLeaveHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMaintenance = New System.Windows.Forms.ToolStripButton()
        Me.tsUser = New System.Windows.Forms.ToolStripButton()
        Me.tsReport = New System.Windows.Forms.ToolStripButton()
        Me.tsLogin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(34, 34)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsEmployee, Me.tsLeave, Me.tsMaintenance, Me.tsUser, Me.tsReport, Me.tsLogin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(113, 502)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsEmployee
        '
        Me.tsEmployee.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsRegEmp, Me.tsListEmp, Me.ToolStripComboBox1})
        Me.tsEmployee.Image = CType(resources.GetObject("tsEmployee.Image"), System.Drawing.Image)
        Me.tsEmployee.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEmployee.Name = "tsEmployee"
        Me.tsEmployee.Size = New System.Drawing.Size(110, 53)
        Me.tsEmployee.Text = "Employees"
        Me.tsEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsRegEmp
        '
        Me.tsRegEmp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripMenuItem1})
        Me.tsRegEmp.Name = "tsRegEmp"
        Me.tsRegEmp.Size = New System.Drawing.Size(198, 22)
        Me.tsRegEmp.Text = "Register New Employee"
        '
        'tsListEmp
        '
        Me.tsListEmp.Name = "tsListEmp"
        Me.tsListEmp.Size = New System.Drawing.Size(198, 22)
        Me.tsListEmp.Text = "List of Employee's"
        '
        'tsLeave
        '
        Me.tsLeave.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsApply, Me.tsLeaveHistory})
        Me.tsLeave.Image = CType(resources.GetObject("tsLeave.Image"), System.Drawing.Image)
        Me.tsLeave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLeave.Name = "tsLeave"
        Me.tsLeave.Size = New System.Drawing.Size(110, 53)
        Me.tsLeave.Text = "Leave of Absence"
        Me.tsLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsApply
        '
        Me.tsApply.Name = "tsApply"
        Me.tsApply.Size = New System.Drawing.Size(200, 22)
        Me.tsApply.Text = "Apply Leave of Absence"
        '
        'tsLeaveHistory
        '
        Me.tsLeaveHistory.Name = "tsLeaveHistory"
        Me.tsLeaveHistory.Size = New System.Drawing.Size(200, 22)
        Me.tsLeaveHistory.Text = "History"
        '
        'tsMaintenance
        '
        Me.tsMaintenance.Image = CType(resources.GetObject("tsMaintenance.Image"), System.Drawing.Image)
        Me.tsMaintenance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsMaintenance.Name = "tsMaintenance"
        Me.tsMaintenance.Size = New System.Drawing.Size(110, 53)
        Me.tsMaintenance.Text = "Maintenance"
        Me.tsMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsUser
        '
        Me.tsUser.Image = CType(resources.GetObject("tsUser.Image"), System.Drawing.Image)
        Me.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUser.Name = "tsUser"
        Me.tsUser.Size = New System.Drawing.Size(110, 53)
        Me.tsUser.Text = "Manage User"
        Me.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsReport
        '
        Me.tsReport.Image = CType(resources.GetObject("tsReport.Image"), System.Drawing.Image)
        Me.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReport.Name = "tsReport"
        Me.tsReport.Size = New System.Drawing.Size(110, 53)
        Me.tsReport.Text = "Reports"
        Me.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsLogin
        '
        Me.tsLogin.Image = Global.LeaveManagementSystem.My.Resources.Resources.login
        Me.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLogin.Name = "tsLogin"
        Me.tsLogin.Size = New System.Drawing.Size(110, 53)
        Me.tsLogin.Text = "Login"
        Me.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 502)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsMaintenance As ToolStripButton
    Friend WithEvents tsUser As ToolStripButton
    Friend WithEvents tsReport As ToolStripButton
    Friend WithEvents tsLogin As ToolStripButton
    Friend WithEvents tsLeave As ToolStripDropDownButton
    Friend WithEvents tsApply As ToolStripMenuItem
    Friend WithEvents tsLeaveHistory As ToolStripMenuItem
    Friend WithEvents tsEmployee As ToolStripDropDownButton
    Friend WithEvents tsRegEmp As ToolStripMenuItem
    Friend WithEvents tsListEmp As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
