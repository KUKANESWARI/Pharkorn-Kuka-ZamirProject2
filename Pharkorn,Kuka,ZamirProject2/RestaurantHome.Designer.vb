<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurantHome
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
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkCyan
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ChefToolStripMenuItem, Me.StaffToolStripMenuItem, Me.CustomerDataToolStripMenuItem, Me.FoodToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 31)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(71, 27)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ChefToolStripMenuItem
        '
        Me.ChefToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ChefToolStripMenuItem.Name = "ChefToolStripMenuItem"
        Me.ChefToolStripMenuItem.Size = New System.Drawing.Size(59, 27)
        Me.ChefToolStripMenuItem.Text = "Chef"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(57, 27)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'CustomerDataToolStripMenuItem
        '
        Me.CustomerDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CustomerDataToolStripMenuItem.Name = "CustomerDataToolStripMenuItem"
        Me.CustomerDataToolStripMenuItem.Size = New System.Drawing.Size(98, 27)
        Me.CustomerDataToolStripMenuItem.Text = "Customer"
        '
        'FoodToolStripMenuItem
        '
        Me.FoodToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FoodToolStripMenuItem.Name = "FoodToolStripMenuItem"
        Me.FoodToolStripMenuItem.Size = New System.Drawing.Size(62, 27)
        Me.FoodToolStripMenuItem.Text = "Food"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(51, 27)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(621, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kayu Kitchen, Changlun, Kedah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "WELCOME"
        '
        'RestaurantHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pharkorn_Kuka_ZamirProject2.My.Resources.Resources.Creative_Images_HD_picture_12
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "RestaurantHome"
        Me.Text = "RestaurantHome"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChefToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FoodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
