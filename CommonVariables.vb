Imports System.Data.SqlClient
Module CommonVariables

    Public logedInEmail As String           'to store the email of the logged in user
    Public alterUid = 0                     'to store the uid of the card to be altered in teh admin site
    Public selectCardUid As Integer         'to store the uid of the card customer has selected to buy
    Public quantitySelected As Integer      'to store the quantity of the card selected by the customer
    Public totalAmount As Double            'to store the total discounted price of the cards
    Public costprice As Double              'to store the original price of the cards
    Public deliveryDate As Integer          'to store the delivery date of the cards
End Module
