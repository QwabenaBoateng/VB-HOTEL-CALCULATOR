<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        lblTotalCharges = New Label()
        lblTax = New Label()
        lblSubtotal = New Label()
        lblAdditionalCharges = New Label()
        lblRoomCharges = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox2 = New GroupBox()
        lblNighlyCharges = New Label()
        lblNights = New Label()
        txtNightlyCharges = New TextBox()
        txtNights = New TextBox()
        GroupBox3 = New GroupBox()
        lblMisc = New Label()
        lblTelephone = New Label()
        lblRoomService = New Label()
        txtMisc = New TextBox()
        txtTelephone = New TextBox()
        txtRoomService = New TextBox()
        lblTimeToday = New Label()
        lblDateToday = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImageLayout = ImageLayout.None
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(lblTotalCharges)
        GroupBox1.Controls.Add(lblTax)
        GroupBox1.Controls.Add(lblSubtotal)
        GroupBox1.Controls.Add(lblAdditionalCharges)
        GroupBox1.Controls.Add(lblRoomCharges)
        GroupBox1.Font = New Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(144, 466)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(879, 277)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Total Charges:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(277, 222)
        Label17.Name = "Label17"
        Label17.Size = New Size(125, 23)
        Label17.TabIndex = 9
        Label17.Text = "Total Charges"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(356, 174)
        Label16.Name = "Label16"
        Label16.Size = New Size(46, 23)
        Label16.TabIndex = 8
        Label16.Text = "Tax:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(328, 127)
        Label15.Name = "Label15"
        Label15.Size = New Size(86, 23)
        Label15.TabIndex = 7
        Label15.Text = "Subtotal:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(238, 76)
        Label14.Name = "Label14"
        Label14.Size = New Size(176, 23)
        Label14.TabIndex = 6
        Label14.Text = "Additional Charges:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(262, 36)
        Label13.Name = "Label13"
        Label13.Size = New Size(140, 23)
        Label13.TabIndex = 5
        Label13.Text = "Room Charges:"
        ' 
        ' lblTotalCharges
        ' 
        lblTotalCharges.BackColor = Color.White
        lblTotalCharges.BorderStyle = BorderStyle.Fixed3D
        lblTotalCharges.Location = New Point(440, 222)
        lblTotalCharges.Margin = New Padding(4, 0, 4, 0)
        lblTotalCharges.Name = "lblTotalCharges"
        lblTotalCharges.Size = New Size(221, 31)
        lblTotalCharges.TabIndex = 4
        ' 
        ' lblTax
        ' 
        lblTax.BackColor = Color.White
        lblTax.BorderStyle = BorderStyle.Fixed3D
        lblTax.Location = New Point(440, 174)
        lblTax.Margin = New Padding(4, 0, 4, 0)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(221, 31)
        lblTax.TabIndex = 3
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.BackColor = Color.White
        lblSubtotal.BorderStyle = BorderStyle.Fixed3D
        lblSubtotal.Location = New Point(440, 127)
        lblSubtotal.Margin = New Padding(4, 0, 4, 0)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(221, 31)
        lblSubtotal.TabIndex = 2
        ' 
        ' lblAdditionalCharges
        ' 
        lblAdditionalCharges.BackColor = Color.White
        lblAdditionalCharges.BorderStyle = BorderStyle.Fixed3D
        lblAdditionalCharges.Location = New Point(440, 76)
        lblAdditionalCharges.Margin = New Padding(4, 0, 4, 0)
        lblAdditionalCharges.Name = "lblAdditionalCharges"
        lblAdditionalCharges.Size = New Size(221, 31)
        lblAdditionalCharges.TabIndex = 1
        ' 
        ' lblRoomCharges
        ' 
        lblRoomCharges.BackColor = Color.White
        lblRoomCharges.BorderStyle = BorderStyle.Fixed3D
        lblRoomCharges.Location = New Point(440, 27)
        lblRoomCharges.Margin = New Padding(4, 0, 4, 0)
        lblRoomCharges.Name = "lblRoomCharges"
        lblRoomCharges.Size = New Size(221, 31)
        lblRoomCharges.TabIndex = 0
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = SystemColors.Control
        btnCalculate.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalculate.Location = New Point(326, 754)
        btnCalculate.Margin = New Padding(4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(143, 58)
        btnCalculate.TabIndex = 1
        btnCalculate.Text = "&Calculate Charges"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.Control
        btnClear.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(536, 754)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(113, 58)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear&"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.Control
        btnExit.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.Location = New Point(710, 754)
        btnExit.Margin = New Padding(4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(127, 58)
        btnExit.TabIndex = 3
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblNighlyCharges)
        GroupBox2.Controls.Add(lblNights)
        GroupBox2.Controls.Add(txtNightlyCharges)
        GroupBox2.Controls.Add(txtNights)
        GroupBox2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(144, 227)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(402, 217)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Room Information"
        ' 
        ' lblNighlyCharges
        ' 
        lblNighlyCharges.AutoSize = True
        lblNighlyCharges.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblNighlyCharges.Location = New Point(85, 128)
        lblNighlyCharges.Name = "lblNighlyCharges"
        lblNighlyCharges.Size = New Size(150, 23)
        lblNighlyCharges.TabIndex = 3
        lblNighlyCharges.Text = "Nightly Charge&s:"
        ' 
        ' lblNights
        ' 
        lblNights.AutoSize = True
        lblNights.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblNights.Location = New Point(164, 65)
        lblNights.Margin = New Padding(4, 0, 4, 0)
        lblNights.Name = "lblNights"
        lblNights.Size = New Size(71, 23)
        lblNights.TabIndex = 2
        lblNights.Text = "&Nights:"
        ' 
        ' txtNightlyCharges
        ' 
        txtNightlyCharges.Font = New Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtNightlyCharges.Location = New Point(267, 118)
        txtNightlyCharges.Margin = New Padding(4)
        txtNightlyCharges.Name = "txtNightlyCharges"
        txtNightlyCharges.Size = New Size(127, 39)
        txtNightlyCharges.TabIndex = 1
        ' 
        ' txtNights
        ' 
        txtNights.Font = New Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtNights.Location = New Point(267, 55)
        txtNights.Margin = New Padding(4)
        txtNights.Name = "txtNights"
        txtNights.Size = New Size(127, 39)
        txtNights.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lblMisc)
        GroupBox3.Controls.Add(lblTelephone)
        GroupBox3.Controls.Add(lblRoomService)
        GroupBox3.Controls.Add(txtMisc)
        GroupBox3.Controls.Add(txtTelephone)
        GroupBox3.Controls.Add(txtRoomService)
        GroupBox3.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(645, 227)
        GroupBox3.Margin = New Padding(4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4)
        GroupBox3.Size = New Size(378, 217)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Additional Charges"
        ' 
        ' lblMisc
        ' 
        lblMisc.AutoSize = True
        lblMisc.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblMisc.Location = New Point(146, 158)
        lblMisc.Name = "lblMisc"
        lblMisc.Size = New Size(57, 23)
        lblMisc.TabIndex = 5
        lblMisc.Text = "&Misc:"
        ' 
        ' lblTelephone
        ' 
        lblTelephone.AutoSize = True
        lblTelephone.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTelephone.Location = New Point(102, 103)
        lblTelephone.Name = "lblTelephone"
        lblTelephone.Size = New Size(101, 23)
        lblTelephone.TabIndex = 4
        lblTelephone.Text = "&Telephone:"
        ' 
        ' lblRoomService
        ' 
        lblRoomService.AutoSize = True
        lblRoomService.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRoomService.Location = New Point(69, 45)
        lblRoomService.Name = "lblRoomService"
        lblRoomService.Size = New Size(134, 23)
        lblRoomService.TabIndex = 3
        lblRoomService.Text = "Room Se&rvice:"
        ' 
        ' txtMisc
        ' 
        txtMisc.Font = New Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMisc.Location = New Point(229, 158)
        txtMisc.Margin = New Padding(4)
        txtMisc.Name = "txtMisc"
        txtMisc.Size = New Size(127, 39)
        txtMisc.TabIndex = 2
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Font = New Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTelephone.Location = New Point(229, 93)
        txtTelephone.Margin = New Padding(4)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(127, 39)
        txtTelephone.TabIndex = 1
        ' 
        ' txtRoomService
        ' 
        txtRoomService.Font = New Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtRoomService.Location = New Point(229, 35)
        txtRoomService.Margin = New Padding(4)
        txtRoomService.Name = "txtRoomService"
        txtRoomService.Size = New Size(127, 39)
        txtRoomService.TabIndex = 0
        ' 
        ' lblTimeToday
        ' 
        lblTimeToday.BackColor = Color.White
        lblTimeToday.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTimeToday.Location = New Point(873, 175)
        lblTimeToday.Margin = New Padding(4, 0, 4, 0)
        lblTimeToday.Name = "lblTimeToday"
        lblTimeToday.Size = New Size(128, 35)
        lblTimeToday.TabIndex = 6
        ' 
        ' lblDateToday
        ' 
        lblDateToday.BackColor = Color.White
        lblDateToday.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDateToday.Location = New Point(874, 121)
        lblDateToday.Margin = New Padding(4, 0, 4, 0)
        lblDateToday.Name = "lblDateToday"
        lblDateToday.Size = New Size(127, 29)
        lblDateToday.TabIndex = 7
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(726, 121)
        Label18.Name = "Label18"
        Label18.Size = New Size(122, 23)
        Label18.TabIndex = 9
        Label18.Text = "Today's Date:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(779, 175)
        Label19.Name = "Label19"
        Label19.Size = New Size(58, 23)
        Label19.TabIndex = 10
        Label19.Text = "Time:"
        ' 
        ' Label20
        ' 
        Label20.Font = New Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(444, 32)
        Label20.Name = "Label20"
        Label20.Size = New Size(327, 33)
        Label20.TabIndex = 11
        Label20.Text = "HIGHLANDER HOTEL"
        ' 
        ' Form1
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        BackgroundImageLayout = ImageLayout.None
        CancelButton = btnExit
        ClientSize = New Size(1077, 825)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(lblDateToday)
        Controls.Add(lblTimeToday)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox1)
        Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Room Charge Calculator"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotalCharges As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblAdditionalCharges As Label
    Friend WithEvents lblRoomCharges As Label
    Friend WithEvents txtNightlyCharges As TextBox
    Friend WithEvents txtNights As TextBox
    Friend WithEvents txtMisc As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtRoomService As TextBox
    Friend WithEvents lblTimeToday As Label
    Friend WithEvents lblDateToday As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblNighlyCharges As Label
    Friend WithEvents lblNights As Label
    Friend WithEvents lblMisc As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblRoomService As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
