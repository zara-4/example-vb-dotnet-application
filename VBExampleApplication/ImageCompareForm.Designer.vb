<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageCompareForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageCompareForm))
        Me.OriginalImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.CompressedImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.ImageComparisonPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CompressionRatioValue = New System.Windows.Forms.Label()
        Me.PercentageSavingValue = New System.Windows.Forms.Label()
        Me.CompressionRatioLabel = New System.Windows.Forms.Label()
        Me.PercentageSavingLabel = New System.Windows.Forms.Label()
        Me.CompressedFileSizeValue = New System.Windows.Forms.Label()
        Me.CompressedFileSizeLabel = New System.Windows.Forms.Label()
        Me.OriginalFileSizeValue = New System.Windows.Forms.Label()
        Me.OriginalFileSizeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.OriginalImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompressedImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImageComparisonPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OriginalImagePictureBox
        '
        Me.OriginalImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OriginalImagePictureBox.Location = New System.Drawing.Point(0, 0)
        Me.OriginalImagePictureBox.Name = "OriginalImagePictureBox"
        Me.OriginalImagePictureBox.Size = New System.Drawing.Size(481, 286)
        Me.OriginalImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OriginalImagePictureBox.TabIndex = 0
        Me.OriginalImagePictureBox.TabStop = False
        '
        'CompressedImagePictureBox
        '
        Me.CompressedImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompressedImagePictureBox.Location = New System.Drawing.Point(0, 0)
        Me.CompressedImagePictureBox.Name = "CompressedImagePictureBox"
        Me.CompressedImagePictureBox.Size = New System.Drawing.Size(481, 286)
        Me.CompressedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompressedImagePictureBox.TabIndex = 1
        Me.CompressedImagePictureBox.TabStop = False
        '
        'ImageComparisonPanel
        '
        Me.ImageComparisonPanel.AutoSize = True
        Me.ImageComparisonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ImageComparisonPanel.ColumnCount = 2
        Me.ImageComparisonPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ImageComparisonPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ImageComparisonPanel.Controls.Add(Me.Panel2, 1, 0)
        Me.ImageComparisonPanel.Controls.Add(Me.Panel3, 0, 0)
        Me.ImageComparisonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageComparisonPanel.Location = New System.Drawing.Point(3, 33)
        Me.ImageComparisonPanel.Name = "ImageComparisonPanel"
        Me.ImageComparisonPanel.RowCount = 1
        Me.ImageComparisonPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ImageComparisonPanel.Size = New System.Drawing.Size(974, 292)
        Me.ImageComparisonPanel.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ImageComparisonPanel, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(980, 328)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CompressionRatioValue)
        Me.Panel1.Controls.Add(Me.PercentageSavingValue)
        Me.Panel1.Controls.Add(Me.CompressionRatioLabel)
        Me.Panel1.Controls.Add(Me.PercentageSavingLabel)
        Me.Panel1.Controls.Add(Me.CompressedFileSizeValue)
        Me.Panel1.Controls.Add(Me.CompressedFileSizeLabel)
        Me.Panel1.Controls.Add(Me.OriginalFileSizeValue)
        Me.Panel1.Controls.Add(Me.OriginalFileSizeLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 24)
        Me.Panel1.TabIndex = 4
        '
        'CompressionRatioValue
        '
        Me.CompressionRatioValue.AutoSize = True
        Me.CompressionRatioValue.Location = New System.Drawing.Point(423, 6)
        Me.CompressionRatioValue.Name = "CompressionRatioValue"
        Me.CompressionRatioValue.Size = New System.Drawing.Size(16, 13)
        Me.CompressionRatioValue.TabIndex = 19
        Me.CompressionRatioValue.Text = "..."
        '
        'PercentageSavingValue
        '
        Me.PercentageSavingValue.AutoSize = True
        Me.PercentageSavingValue.Location = New System.Drawing.Point(608, 6)
        Me.PercentageSavingValue.Name = "PercentageSavingValue"
        Me.PercentageSavingValue.Size = New System.Drawing.Size(16, 13)
        Me.PercentageSavingValue.TabIndex = 18
        Me.PercentageSavingValue.Text = "..."
        '
        'CompressionRatioLabel
        '
        Me.CompressionRatioLabel.AutoSize = True
        Me.CompressionRatioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompressionRatioLabel.Location = New System.Drawing.Point(305, 6)
        Me.CompressionRatioLabel.Name = "CompressionRatioLabel"
        Me.CompressionRatioLabel.Size = New System.Drawing.Size(112, 13)
        Me.CompressionRatioLabel.TabIndex = 17
        Me.CompressionRatioLabel.Text = "Compression Ratio"
        '
        'PercentageSavingLabel
        '
        Me.PercentageSavingLabel.AutoSize = True
        Me.PercentageSavingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentageSavingLabel.Location = New System.Drawing.Point(487, 6)
        Me.PercentageSavingLabel.Name = "PercentageSavingLabel"
        Me.PercentageSavingLabel.Size = New System.Drawing.Size(115, 13)
        Me.PercentageSavingLabel.TabIndex = 16
        Me.PercentageSavingLabel.Text = "Percentage Saving"
        '
        'CompressedFileSizeValue
        '
        Me.CompressedFileSizeValue.AutoSize = True
        Me.CompressedFileSizeValue.Location = New System.Drawing.Point(233, 6)
        Me.CompressedFileSizeValue.Name = "CompressedFileSizeValue"
        Me.CompressedFileSizeValue.Size = New System.Drawing.Size(16, 13)
        Me.CompressedFileSizeValue.TabIndex = 15
        Me.CompressedFileSizeValue.Text = "..."
        '
        'CompressedFileSizeLabel
        '
        Me.CompressedFileSizeLabel.AutoSize = True
        Me.CompressedFileSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompressedFileSizeLabel.Location = New System.Drawing.Point(152, 6)
        Me.CompressedFileSizeLabel.Name = "CompressedFileSizeLabel"
        Me.CompressedFileSizeLabel.Size = New System.Drawing.Size(75, 13)
        Me.CompressedFileSizeLabel.TabIndex = 14
        Me.CompressedFileSizeLabel.Text = "Compressed"
        '
        'OriginalFileSizeValue
        '
        Me.OriginalFileSizeValue.AutoSize = True
        Me.OriginalFileSizeValue.Location = New System.Drawing.Point(65, 6)
        Me.OriginalFileSizeValue.Name = "OriginalFileSizeValue"
        Me.OriginalFileSizeValue.Size = New System.Drawing.Size(16, 13)
        Me.OriginalFileSizeValue.TabIndex = 13
        Me.OriginalFileSizeValue.Text = "..."
        '
        'OriginalFileSizeLabel
        '
        Me.OriginalFileSizeLabel.AutoSize = True
        Me.OriginalFileSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OriginalFileSizeLabel.Location = New System.Drawing.Point(9, 6)
        Me.OriginalFileSizeLabel.Name = "OriginalFileSizeLabel"
        Me.OriginalFileSizeLabel.Size = New System.Drawing.Size(50, 13)
        Me.OriginalFileSizeLabel.TabIndex = 12
        Me.OriginalFileSizeLabel.Text = "Original"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Compressed Image"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CompressedImagePictureBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(490, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(481, 286)
        Me.Panel2.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.OriginalImagePictureBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(481, 286)
        Me.Panel3.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Original Image"
        '
        'ImageCompareForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 328)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(996, 366)
        Me.Name = "ImageCompareForm"
        Me.Text = "Image Comparison"
        CType(Me.OriginalImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompressedImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImageComparisonPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OriginalImagePictureBox As PictureBox
    Friend WithEvents CompressedImagePictureBox As PictureBox
    Friend WithEvents ImageComparisonPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CompressionRatioValue As Label
    Friend WithEvents PercentageSavingValue As Label
    Friend WithEvents CompressionRatioLabel As Label
    Friend WithEvents PercentageSavingLabel As Label
    Friend WithEvents CompressedFileSizeValue As Label
    Friend WithEvents CompressedFileSizeLabel As Label
    Friend WithEvents OriginalFileSizeValue As Label
    Friend WithEvents OriginalFileSizeLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
End Class
