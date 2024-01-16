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
        Me.Field1 = New System.Windows.Forms.TextBox()
        Me.Field2 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Field3 = New System.Windows.Forms.TextBox()
        Me.Field4 = New System.Windows.Forms.TextBox()
        Me.Field5 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ShoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Field1
        '
        Me.Field1.Location = New System.Drawing.Point(129, 176)
        Me.Field1.Name = "Field1"
        Me.Field1.Size = New System.Drawing.Size(100, 22)
        Me.Field1.TabIndex = 0
        '
        'Field2
        '
        Me.Field2.Location = New System.Drawing.Point(129, 134)
        Me.Field2.Name = "Field2"
        Me.Field2.Size = New System.Drawing.Size(100, 22)
        Me.Field2.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Field3
        '
        Me.Field3.Location = New System.Drawing.Point(129, 260)
        Me.Field3.Name = "Field3"
        Me.Field3.Size = New System.Drawing.Size(100, 22)
        Me.Field3.TabIndex = 3
        '
        'Field4
        '
        Me.Field4.Location = New System.Drawing.Point(129, 302)
        Me.Field4.Name = "Field4"
        Me.Field4.Size = New System.Drawing.Size(100, 22)
        Me.Field4.TabIndex = 4
        '
        'Field5
        '
        Me.Field5.Location = New System.Drawing.Point(129, 218)
        Me.Field5.Name = "Field5"
        Me.Field5.Size = New System.Drawing.Size(100, 22)
        Me.Field5.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(456, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 286)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShoesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ShoesToolStripMenuItem
        '
        Me.ShoesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.ShoesToolStripMenuItem.Name = "ShoesToolStripMenuItem"
        Me.ShoesToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.ShoesToolStripMenuItem.Text = "Cats"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Field5)
        Me.Controls.Add(Me.Field4)
        Me.Controls.Add(Me.Field3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Field2)
        Me.Controls.Add(Me.Field1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Field1 As TextBox
    Friend WithEvents Field2 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Field3 As TextBox
    Friend WithEvents Field4 As TextBox
    Friend WithEvents Field5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ShoesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
End Class
