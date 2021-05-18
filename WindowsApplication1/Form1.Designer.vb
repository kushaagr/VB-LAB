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
        Me.add = New System.Windows.Forms.Button()
        Me.divide = New System.Windows.Forms.Button()
        Me.multiply = New System.Windows.Forms.Button()
        Me.subtract = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.output = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'add
        '
        Me.add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.add.Location = New System.Drawing.Point(41, 75)
        Me.add.Margin = New System.Windows.Forms.Padding(4)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(197, 28)
        Me.add.TabIndex = 0
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = False
        '
        'divide
        '
        Me.divide.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.divide.Location = New System.Drawing.Point(41, 182)
        Me.divide.Margin = New System.Windows.Forms.Padding(4)
        Me.divide.Name = "divide"
        Me.divide.Size = New System.Drawing.Size(197, 28)
        Me.divide.TabIndex = 7
        Me.divide.Text = "/"
        Me.divide.UseVisualStyleBackColor = False
        '
        'multiply
        '
        Me.multiply.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.multiply.Location = New System.Drawing.Point(41, 146)
        Me.multiply.Margin = New System.Windows.Forms.Padding(4)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(197, 28)
        Me.multiply.TabIndex = 8
        Me.multiply.Text = "*"
        Me.multiply.UseVisualStyleBackColor = False
        '
        'subtract
        '
        Me.subtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.subtract.Location = New System.Drawing.Point(41, 111)
        Me.subtract.Margin = New System.Windows.Forms.Padding(4)
        Me.subtract.Name = "subtract"
        Me.subtract.Size = New System.Drawing.Size(197, 28)
        Me.subtract.TabIndex = 9
        Me.subtract.Text = "-"
        Me.subtract.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Accumulator"
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(105, 43)
        Me.input.Margin = New System.Windows.Forms.Padding(4)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(132, 22)
        Me.input.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = " A"
        '
        'output
        '
        Me.output.Location = New System.Drawing.Point(114, 239)
        Me.output.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(51, 17)
        Me.output.TabIndex = 22
        Me.output.Text = "Output"
        Me.output.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 293)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.subtract)
        Me.Controls.Add(Me.multiply)
        Me.Controls.Add(Me.divide)
        Me.Controls.Add(Me.add)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator prototype one"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents divide As System.Windows.Forms.Button
    Friend WithEvents multiply As System.Windows.Forms.Button
    Friend WithEvents subtract As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents input As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents output As System.Windows.Forms.Label

End Class
