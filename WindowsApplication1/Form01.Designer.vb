<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form01
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorprototypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrototypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherAppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorprototypeToolStripMenuItem, Me.DataGridViewToolStripMenuItem, Me.NotepadToolStripMenuItem, Me.OtherAppsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(671, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculatorprototypeToolStripMenuItem
        '
        Me.CalculatorprototypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrototypeToolStripMenuItem, Me.SimpleToolStripMenuItem, Me.ButtonToolStripMenuItem})
        Me.CalculatorprototypeToolStripMenuItem.Name = "CalculatorprototypeToolStripMenuItem"
        Me.CalculatorprototypeToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CalculatorprototypeToolStripMenuItem.Text = "Calculator"
        '
        'PrototypeToolStripMenuItem
        '
        Me.PrototypeToolStripMenuItem.Name = "PrototypeToolStripMenuItem"
        Me.PrototypeToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.PrototypeToolStripMenuItem.Text = "Prototype (Form1)"
        '
        'SimpleToolStripMenuItem
        '
        Me.SimpleToolStripMenuItem.Name = "SimpleToolStripMenuItem"
        Me.SimpleToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.SimpleToolStripMenuItem.Text = "Simple (Form2)"
        '
        'ButtonToolStripMenuItem
        '
        Me.ButtonToolStripMenuItem.Name = "ButtonToolStripMenuItem"
        Me.ButtonToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.ButtonToolStripMenuItem.Text = "9-button (Form3)"
        '
        'DataGridViewToolStripMenuItem
        '
        Me.DataGridViewToolStripMenuItem.Name = "DataGridViewToolStripMenuItem"
        Me.DataGridViewToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.DataGridViewToolStripMenuItem.Text = "DataGridView (Fo.9a)"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.NotepadToolStripMenuItem.Text = "Notepad (Fo.7)"
        '
        'OtherAppsToolStripMenuItem
        '
        Me.OtherAppsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Form5ToolStripMenuItem, Me.Form6ToolStripMenuItem, Me.Form8ToolStripMenuItem, Me.Form9ToolStripMenuItem})
        Me.OtherAppsToolStripMenuItem.Name = "OtherAppsToolStripMenuItem"
        Me.OtherAppsToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.OtherAppsToolStripMenuItem.Text = "Other apps"
        '
        'Form5ToolStripMenuItem
        '
        Me.Form5ToolStripMenuItem.Name = "Form5ToolStripMenuItem"
        Me.Form5ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Form5ToolStripMenuItem.Text = "Form5"
        '
        'Form6ToolStripMenuItem
        '
        Me.Form6ToolStripMenuItem.Name = "Form6ToolStripMenuItem"
        Me.Form6ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Form6ToolStripMenuItem.Text = "Form6"
        '
        'Form8ToolStripMenuItem
        '
        Me.Form8ToolStripMenuItem.Name = "Form8ToolStripMenuItem"
        Me.Form8ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Form8ToolStripMenuItem.Text = "Form8"
        '
        'Form9ToolStripMenuItem
        '
        Me.Form9ToolStripMenuItem.Name = "Form9ToolStripMenuItem"
        Me.Form9ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Form9ToolStripMenuItem.Text = "Form9"
        '
        'Form01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 544)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form01"
        Me.Text = "Form10"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculatorprototypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrototypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherAppsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form9ToolStripMenuItem As ToolStripMenuItem
End Class
