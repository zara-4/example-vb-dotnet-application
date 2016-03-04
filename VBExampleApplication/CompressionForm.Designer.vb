<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompressionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompressionForm))
        Me.CompressBtn = New System.Windows.Forms.Button()
        Me.BrowseFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BrowseFilePath = New System.Windows.Forms.TextBox()
        Me.BrowseFileBtn = New System.Windows.Forms.Button()
        Me.BrowseFileGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ApiClientSecretText = New System.Windows.Forms.TextBox()
        Me.ApiClientIdText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrowseFileGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CompressBtn
        '
        Me.CompressBtn.Location = New System.Drawing.Point(12, 193)
        Me.CompressBtn.Name = "CompressBtn"
        Me.CompressBtn.Size = New System.Drawing.Size(440, 34)
        Me.CompressBtn.TabIndex = 0
        Me.CompressBtn.Text = "Compress Image"
        Me.CompressBtn.UseVisualStyleBackColor = True
        '
        'BrowseFileDialog
        '
        Me.BrowseFileDialog.FileName = "OpenFileDialog1"
        '
        'BrowseFilePath
        '
        Me.BrowseFilePath.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BrowseFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseFilePath.Location = New System.Drawing.Point(6, 19)
        Me.BrowseFilePath.Name = "BrowseFilePath"
        Me.BrowseFilePath.ReadOnly = True
        Me.BrowseFilePath.Size = New System.Drawing.Size(338, 22)
        Me.BrowseFilePath.TabIndex = 1
        '
        'BrowseFileBtn
        '
        Me.BrowseFileBtn.Location = New System.Drawing.Point(350, 18)
        Me.BrowseFileBtn.Name = "BrowseFileBtn"
        Me.BrowseFileBtn.Size = New System.Drawing.Size(84, 23)
        Me.BrowseFileBtn.TabIndex = 2
        Me.BrowseFileBtn.Text = "Browse..."
        Me.BrowseFileBtn.UseVisualStyleBackColor = True
        '
        'BrowseFileGroupBox
        '
        Me.BrowseFileGroupBox.Controls.Add(Me.BrowseFilePath)
        Me.BrowseFileGroupBox.Controls.Add(Me.BrowseFileBtn)
        Me.BrowseFileGroupBox.Location = New System.Drawing.Point(12, 122)
        Me.BrowseFileGroupBox.Name = "BrowseFileGroupBox"
        Me.BrowseFileGroupBox.Size = New System.Drawing.Size(440, 49)
        Me.BrowseFileGroupBox.TabIndex = 3
        Me.BrowseFileGroupBox.TabStop = False
        Me.BrowseFileGroupBox.Text = "Select your image"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ApiClientSecretText)
        Me.GroupBox1.Controls.Add(Me.ApiClientIdText)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 86)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "API Credentials"
        '
        'ApiClientSecretText
        '
        Me.ApiClientSecretText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApiClientSecretText.Location = New System.Drawing.Point(121, 49)
        Me.ApiClientSecretText.Name = "ApiClientSecretText"
        Me.ApiClientSecretText.Size = New System.Drawing.Size(301, 22)
        Me.ApiClientSecretText.TabIndex = 3
        '
        'ApiClientIdText
        '
        Me.ApiClientIdText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApiClientIdText.Location = New System.Drawing.Point(121, 23)
        Me.ApiClientIdText.Name = "ApiClientIdText"
        Me.ApiClientIdText.Size = New System.Drawing.Size(301, 22)
        Me.ApiClientIdText.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "API Client Secret"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "API Client Id"
        '
        'CompressionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 238)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BrowseFileGroupBox)
        Me.Controls.Add(Me.CompressBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CompressionForm"
        Me.Text = "Zara 4 Example Program"
        Me.BrowseFileGroupBox.ResumeLayout(False)
        Me.BrowseFileGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CompressBtn As Button
    Friend WithEvents BrowseFileDialog As OpenFileDialog
    Friend WithEvents BrowseFilePath As TextBox
    Friend WithEvents BrowseFileBtn As Button
    Friend WithEvents BrowseFileGroupBox As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ApiClientSecretText As TextBox
    Friend WithEvents ApiClientIdText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
