<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FORMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COURSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.STUDENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PAYMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PAYMENTREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Violet
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FORMSToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FORMSToolStripMenuItem
        '
        Me.FORMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COURSEToolStripMenuItem, Me.STUDENTToolStripMenuItem, Me.PAYMENTToolStripMenuItem})
        Me.FORMSToolStripMenuItem.Name = "FORMSToolStripMenuItem"
        Me.FORMSToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.FORMSToolStripMenuItem.Text = "FORMS"
        '
        'COURSEToolStripMenuItem
        '
        Me.COURSEToolStripMenuItem.Name = "COURSEToolStripMenuItem"
        Me.COURSEToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.COURSEToolStripMenuItem.Text = "COURSE"
        '
        'STUDENTToolStripMenuItem
        '
        Me.STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        Me.STUDENTToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.STUDENTToolStripMenuItem.Text = "STUDENT"
        '
        'PAYMENTToolStripMenuItem
        '
        Me.PAYMENTToolStripMenuItem.Name = "PAYMENTToolStripMenuItem"
        Me.PAYMENTToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PAYMENTToolStripMenuItem.Text = "PAYMENT"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PAYMENTREPORTToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'PAYMENTREPORTToolStripMenuItem
        '
        Me.PAYMENTREPORTToolStripMenuItem.Name = "PAYMENTREPORTToolStripMenuItem"
        Me.PAYMENTREPORTToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PAYMENTREPORTToolStripMenuItem.Text = "PAYMENT REPORT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "Student Admission System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FORMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COURSEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STUDENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PAYMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PAYMENTREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
