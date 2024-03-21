<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewEmployee
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtempsearch = New System.Windows.Forms.TextBox()
        Me.dtgemplist = New System.Windows.Forms.DataGridView()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 31)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "List of Employees"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(603, 13)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(99, 34)
        Me.btnSelect.TabIndex = 31
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(708, 13)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 34)
        Me.btnClose.TabIndex = 32
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(6, 317)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(47, 13)
        Me.Label46.TabIndex = 30
        Me.Label46.Text = "Search :"
        '
        'txtempsearch
        '
        Me.txtempsearch.Location = New System.Drawing.Point(64, 314)
        Me.txtempsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtempsearch.Name = "txtempsearch"
        Me.txtempsearch.Size = New System.Drawing.Size(282, 20)
        Me.txtempsearch.TabIndex = 29
        '
        'dtgemplist
        '
        Me.dtgemplist.AllowUserToAddRows = False
        Me.dtgemplist.AllowUserToDeleteRows = False
        Me.dtgemplist.AllowUserToResizeColumns = False
        Me.dtgemplist.AllowUserToResizeRows = False
        Me.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgemplist.Location = New System.Drawing.Point(6, 53)
        Me.dtgemplist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgemplist.Name = "dtgemplist"
        Me.dtgemplist.RowTemplate.Height = 24
        Me.dtgemplist.Size = New System.Drawing.Size(801, 251)
        Me.dtgemplist.TabIndex = 28
        '
        'frmviewEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 351)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtempsearch)
        Me.Controls.Add(Me.dtgemplist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmviewEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View"
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label46 As Label
    Friend WithEvents txtempsearch As TextBox
    Friend WithEvents dtgemplist As DataGridView
End Class
