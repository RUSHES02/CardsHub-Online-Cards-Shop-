Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Imports System.Net
Imports System.Text.RegularExpressions

Public Class FormOrderPage

    'sql variables
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand

    Dim paymentMode As String       'variable to payment mode selected
    Dim orderDate As Date           'variable to store the date of order
    Dim deliveryDays As Integer     'variable to store the number of days of delivery
    Dim deliveryDate As Date        'to store the delivery date
    Dim uid As Integer

    Private Sub FormOrderPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormCardList.Close()
        FormRegister.Close()
        FormLogin.Hide()
        Dim states() As String = {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal"}

        ' Add each state to the ComboBox control
        For Each state As String In states
            ComboBoxState.Items.Add(state)
        Next

        'initially setting to text box and label of upi and card details false
        LabelUPIOrCard.Visible = False
        TextBox1UPIOrCard.Visible = False

        'setting all error images to false initially
        PictureBoxErrorName.Visible = False
        PictureBoxErrorPhone.Visible = False
        PictureBoxErrorState.Visible = False
        PictureBoxErrorCity.Visible = False
        PictureBoxErrorAddress.Visible = False
        PictureBoxErrorLandmark.Visible = False
        PictureBoxErrorPincode.Visible = False
        PictureBoxErrorPaymentMode.Visible = False
        PictureBoxErrorUPI.Visible = False

        'calculating the days of delivery
        deliveryDays = CInt(Int((7 * Rnd()) + 3))
        TimerDeliveryDate.Enabled = True

        LabelMRP.Text = costprice
        LabelDiscountedPrice.Text = totalAmount
        LabelDeliveryCharge.Text = CInt(Int((50 * Rnd()) + 30))
        LabelPayableAmount.Text = totalAmount + LabelDeliveryCharge.Text

        'sql connection and query to get the name and phone no of the customer
        conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
        conn.Open()
        cmd = New SqlCommand("SELECT Name, Phone FROM TableUser WHERE Email = @email", conn)
        cmd.Parameters.AddWithValue("@email", logedInEmail)
        cmd.ExecuteNonQuery()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        reader.Read()

        'setting the name and phone text box
        TextBoxName.Text = reader.Item("Name")
        TextBoxPhoneNo.Text = reader.Item("Phone")
        conn.Close()
    End Sub

    'confirm order details
    Private Sub ButtonConfirmOrder_Click(sender As Object, e As EventArgs) Handles ButtonConfirmOrder.Click
        'setting the error alert images to false
        PictureBoxErrorName.Visible = False
        PictureBoxErrorPhone.Visible = False
        PictureBoxErrorState.Visible = False
        PictureBoxErrorCity.Visible = False
        PictureBoxErrorAddress.Visible = False
        PictureBoxErrorLandmark.Visible = False
        PictureBoxErrorPincode.Visible = False
        PictureBoxErrorPaymentMode.Visible = False
        PictureBoxErrorUPI.Visible = False

        'checking if all the fields are entered correctly
        If (checkName() And
            checkPhoneNo() And
            checkState() And
            checkCity() And
            checkAddress() And
            checkPincode() And
            checkLandmark() And
            checkPaymentMode() And
            checkUPIorCard()) Then

            'setting sql server and inserting data in the table order
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
            conn.Open()
            cmd = New SqlCommand("INSERT INTO TableOrder VALUES ((SELECT ISNULL(MAX(OrderId) + 1, 1) FROM TableOrder), @state, @city, @addLine, @pincode, @landmark, @email, @cId, @quantity, @totalCost, @deliveryDate, @pMode, @name, @phone)", conn)
            cmd.Parameters.AddWithValue("@state", ComboBoxState.SelectedItem)
            cmd.Parameters.AddWithValue("@city", TextBoxCity.Text)
            cmd.Parameters.AddWithValue("@addLine", TextBoxAddress.Text)
            cmd.Parameters.AddWithValue("@pincode", TextBoxPincode.Text)
            cmd.Parameters.AddWithValue("@landmark", TextBoxLandmark.Text)
            cmd.Parameters.AddWithValue("@email", logedInEmail)
            cmd.Parameters.AddWithValue("@cId", selectCardUid)
            cmd.Parameters.AddWithValue("@quantity", quantitySelected)
            cmd.Parameters.AddWithValue("@totalCost", LabelPayableAmount.Text)
            cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate)
            cmd.Parameters.AddWithValue("@pMode", paymentMode)
            cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
            cmd.Parameters.AddWithValue("@phone", TextBoxPhoneNo.Text)

            cmd.ExecuteNonQuery()

            'updating the inventory table
            cmd = New SqlCommand("UPDATE TableInventory Set Quantity = ((SELECT Quantity FROM TableInventory WHERE CardId = @id) - @qSet) WHERE CardId = @id", conn)
            cmd.Parameters.AddWithValue("@id", selectCardUid)
            cmd.Parameters.AddWithValue("@qSet", quantitySelected)
            cmd.ExecuteNonQuery()
            conn.Close()

            'message box gor order confirmation
            MessageBox.Show("Your transaction of ₹" + LabelPayableAmount.Text + " is succesful." + vbCrLf + "Your order will be deliverd on " + deliveryDate + vbCrLf + "Thank You for shopping")
            Me.Close()
            FormCardList.Show()
        End If

    End Sub

    Private Sub RadioButtonCard_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCard.CheckedChanged
        LabelUPIOrCard.Visible = True
        LabelUPIOrCard.Text = "Card No."
        TextBox1UPIOrCard.Visible = True
        TextBox1UPIOrCard.Text = ""
        paymentMode = "Card"
    End Sub

    Private Sub RadioButtonUPI_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUPI.CheckedChanged
        LabelUPIOrCard.Visible = True
        LabelUPIOrCard.Text = "UPI Id"
        TextBox1UPIOrCard.Visible = True
        TextBox1UPIOrCard.Text = ""
        paymentMode = "UPI"
    End Sub

    Private Sub RadioButtonPOD_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPOD.CheckedChanged
        paymentMode = "POD"
        LabelUPIOrCard.Visible = False
        TextBox1UPIOrCard.Visible = False
    End Sub

    Private Sub TimerDeliveryDate_Tick(sender As Object, e As EventArgs) Handles TimerDeliveryDate.Tick
        orderDate = Date.Now.ToString("dd MMM yyyy")
        deliveryDate = orderDate.AddDays(deliveryDays)
    End Sub

    'to check only numbers are being enterd in the pincode text box
    Private Sub TextBoxPincode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPincode.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'to check only numbers are being enterd in the phoneno text box
    Private Sub TextBoxPhoneNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPhoneNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox1UPIOrCard_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1UPIOrCard.KeyPress
        If paymentMode = "Card" Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If

    End Sub
    'checking if the name is entered
    Private Function checkName() As Boolean
        If (TextBoxName.Text = "") Then
            PictureBoxErrorName.Visible = True
            Return False
        End If
        Return True
    End Function

    'checking if the phoneno is entered correctly
    Private Function checkPhoneNo() As Boolean
        'checking if the phone no is of length of 10
        Dim phone = TextBoxPhoneNo.Text
        If (phone.Length <> 10) Then
            PictureBoxErrorPhone.Visible = True
            Return False
        End If
        Return True
    End Function

    'checking if the state is being entered
    Private Function checkState() As Boolean
        If (ComboBoxState.SelectedIndex = -1) Then
            PictureBoxErrorState.Visible = True
            Return False
        End If
        Return True
    End Function

    'checking if the city is entered
    Private Function checkCity() As Boolean
        If (TextBoxCity.Text = "") Then
            PictureBoxErrorCity.Visible = True
            Return False
        End If
        Return True
    End Function

    'checking if the address is being entered
    Private Function checkAddress() As Boolean
        If (TextBoxAddress.Text = "") Then
            PictureBoxErrorAddress.Visible = True
            Return False
        End If
        Return True
    End Function

    'checking if the landmark is entered
    Private Function checkLandmark() As Boolean
        If (TextBoxLandmark.Text = "") Then
            PictureBoxErrorLandmark.Visible = True
            Return False
        End If
        Return True
    End Function

    'checking if the pincode is enterd correctly
    Private Function checkPincode() As Boolean
        'checking if the phone no is of length of 10
        Dim pin = TextBoxPincode.Text
        If (pin.Length <> 6) Then
            PictureBoxErrorPincode.Visible = True
            Return False
        End If
        Return True
    End Function

    'checking if the payment mode is set
    Private Function checkPaymentMode() As Boolean
        If (paymentMode = "") Then
            PictureBoxErrorPaymentMode.Visible = True
            Return False
        End If
        Return True
    End Function

    'to check upi id or card no is entered correctly
    Private Function checkUPIorCard() As Boolean
        If paymentMode = "UPI" Then
            If (TextBox1UPIOrCard.Text = "") Then
                PictureBoxErrorUPI.Visible = True
                Return False
            End If

            If Not (Regex.IsMatch(TextBox1UPIOrCard.Text, "[a-zA-Z0-9.\-_]{2,256}@[a-zA-Z]{2,64}")) Then
                PictureBoxErrorUPI.Visible = True
                Return False
            End If

        ElseIf paymentMode = "Card" Then
            If Not TextBox1UPIOrCard.Text.ToString().Length = 12 Then
                PictureBoxErrorUPI.Visible = True
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub FormOrderPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormCardPage.Show()
    End Sub
End Class