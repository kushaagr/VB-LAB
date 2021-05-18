<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorprototypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrototypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorprototypeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 28)
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
        Me.PrototypeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PrototypeToolStripMenuItem.Text = "Prototype"
        '
        'SimpleToolStripMenuItem
        '
        Me.SimpleToolStripMenuItem.Name = "SimpleToolStripMenuItem"
        Me.SimpleToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SimpleToolStripMenuItem.Text = "Simple"
        '
        'ButtonToolStripMenuItem
        '
        Me.ButtonToolStripMenuItem.Name = "ButtonToolStripMenuItem"
        Me.ButtonToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ButtonToolStripMenuItem.Text = "9-button"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form10"
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
End Class
