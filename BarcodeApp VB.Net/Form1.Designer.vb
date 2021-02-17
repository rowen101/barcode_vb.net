<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Me.btndecode = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtencode = New MetroFramework.Controls.MetroTextBox()
        Me.txtdecode = New MetroFramework.Controls.MetroTextBox()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndecode
        '
        Me.btndecode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndecode.Location = New System.Drawing.Point(169, 257)
        Me.btndecode.Name = "btndecode"
        Me.btndecode.Size = New System.Drawing.Size(75, 23)
        Me.btndecode.TabIndex = 0
        Me.btndecode.Text = "Encode"
        Me.btndecode.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(25, 203)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Encode"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 233)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Decode"
        '
        'txtencode
        '
        Me.txtencode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtencode.CustomButton.Image = Nothing
        Me.txtencode.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.txtencode.CustomButton.Name = ""
        Me.txtencode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtencode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtencode.CustomButton.TabIndex = 1
        Me.txtencode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtencode.CustomButton.UseSelectable = True
        Me.txtencode.CustomButton.Visible = False
        Me.txtencode.Lines = New String(-1) {}
        Me.txtencode.Location = New System.Drawing.Point(85, 199)
        Me.txtencode.MaxLength = 32767
        Me.txtencode.Name = "txtencode"
        Me.txtencode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtencode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtencode.SelectedText = ""
        Me.txtencode.SelectionLength = 0
        Me.txtencode.SelectionStart = 0
        Me.txtencode.ShortcutsEnabled = True
        Me.txtencode.Size = New System.Drawing.Size(240, 23)
        Me.txtencode.TabIndex = 2
        Me.txtencode.UseSelectable = True
        Me.txtencode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtencode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtdecode
        '
        Me.txtdecode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtdecode.CustomButton.Image = Nothing
        Me.txtdecode.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.txtdecode.CustomButton.Name = ""
        Me.txtdecode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtdecode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdecode.CustomButton.TabIndex = 1
        Me.txtdecode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdecode.CustomButton.UseSelectable = True
        Me.txtdecode.CustomButton.Visible = False
        Me.txtdecode.Lines = New String(-1) {}
        Me.txtdecode.Location = New System.Drawing.Point(85, 228)
        Me.txtdecode.MaxLength = 32767
        Me.txtdecode.Name = "txtdecode"
        Me.txtdecode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdecode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdecode.SelectedText = ""
        Me.txtdecode.SelectionLength = 0
        Me.txtdecode.SelectionStart = 0
        Me.txtdecode.ShortcutsEnabled = True
        Me.txtdecode.Size = New System.Drawing.Size(240, 23)
        Me.txtdecode.TabIndex = 2
        Me.txtdecode.UseSelectable = True
        Me.txtdecode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdecode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(25, 64)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(300, 129)
        Me.pic.TabIndex = 3
        Me.pic.TabStop = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(250, 257)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "Reset"
        Me.MetroButton1.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 305)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.txtdecode)
        Me.Controls.Add(Me.txtencode)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btndecode)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.Text = "Barcode generator"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btndecode As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtencode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtdecode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pic As PictureBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
