Imports System.Reflection.Emit

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Code for Time and Date Visibility
        lblTimeToday.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDateToday.Text = DateTime.Now.ToShortDateString()

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Code for button clear
        txtNightlyCharges.Text = String.Empty
        txtNights.Text = String.Empty
        txtRoomService.Text = String.Empty
        txtTelephone.Text = String.Empty
        txtMisc.Text = String.Empty
        lblAdditionalCharges.Text = String.Empty
        lblRoomCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotalCharges.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Code for button Exit
        Dim result As DialogResult = MessageBox.Show("Do you wish to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declaring Variables
        Dim numberOfNights As Double    'Declaring Variables for Night
        Dim numberOfNightlyCharge As Double     'Declaring for Nightly Charges
        Dim decRoomCharges As Double
        numberOfNights = txtNights.Text
        numberOfNightlyCharge = txtNightlyCharges.Text
        decRoomCharges = numberOfNights * numberOfNightlyCharge
        lblRoomCharges.Text = decRoomCharges.ToString("C")

        'Declaring Variables 
        Dim myRoomService As Double 'Variables Room service
        Dim myTelephone As Double   'Variables Telephone
        Dim myMisc As Double        'Variables for Misc
        Dim decAdditionalCharges As Double
        myRoomService = txtRoomService.Text
        myTelephone = txtTelephone.Text
        myMisc = txtMisc.Text
        decAdditionalCharges = myRoomService + myTelephone + myMisc 'Adding variables
        lblAdditionalCharges.Text = decAdditionalCharges.ToString("C")

        'Calculating SubTotal
        Dim decSubTotal As Double
        decSubTotal = decRoomCharges + decAdditionalCharges
        lblSubtotal.Text = decSubTotal.ToString("C")

        'Calculating Tax
        Dim decTax As Double
        decTax = decSubTotal * 0.175
        lblTax.Text = decTax.ToString("C")

        'Calculating Total Charges
        Dim decTotal As Double
        decTotal = decSubTotal + decTax
        lblTotalCharges.Text = decTotal.ToString("C")



    End Sub

End Class
