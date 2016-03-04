Imports Zara4.API
Imports Zara4.API.ImageProcessing

Public Class CompressionForm

    Private Sub BrowseFileBtn_Click(sender As Object, e As EventArgs) Handles BrowseFileBtn.Click
        If (BrowseFileDialog.ShowDialog() = DialogResult.OK) Then
            BrowseFilePath.Text = BrowseFileDialog.FileName
        End If
    End Sub



    Private Sub CompressBtn_Click(sender As Object, e As EventArgs) Handles CompressBtn.Click

        Dim apiClient = New Client(ApiClientIdText.Text, ApiClientSecretText.Text)
        Dim originalImage = New LocalImageRequest(BrowseFilePath.Text)


        originalImage.optimisationMode = OptimisationMode.HIGHEST
        originalImage.colourEnhancement = ColourEnhancement.IMPROVE_COLOUR
        'originalImage.resizeMode = ResizeMode.STRETCH
        'originalImage.width = 50
        'originalImage.height = 50


        Dim processedImage = apiClient.processImage(originalImage)

        Dim path = System.IO.Path.GetTempPath() + "/" + processedImage.requestId()
        apiClient.downloadProcessedImage(processedImage, path)


        Dim frm = New ImageCompareForm(BrowseFilePath.Text, path, processedImage.originalFileSizeString(), processedImage.compressedFileSizeString(), processedImage.percentageSavingString(), processedImage.compressionRatioString())
        frm.Show()

    End Sub


End Class
