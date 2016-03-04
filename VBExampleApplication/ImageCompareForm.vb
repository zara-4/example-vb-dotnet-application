Public Class ImageCompareForm

    Public Sub New(ByVal originalImagePath As String, ByVal compressedImagePath As String, ByVal originalFileSize As String, ByVal compressedFileSize As String, ByVal percentageSaving As String, ByVal compressionRatio As String)
        MyBase.New()
        InitializeComponent()

        OriginalImagePictureBox.Image = Image.FromFile(originalImagePath)
        CompressedImagePictureBox.Image = Image.FromFile(compressedImagePath)

        OriginalFileSizeValue.Text = originalFileSize
        CompressedFileSizeValue.Text = compressedFileSize
        PercentageSavingValue.Text = percentageSaving
        CompressionRatioValue.Text = compressionRatio
    End Sub

End Class