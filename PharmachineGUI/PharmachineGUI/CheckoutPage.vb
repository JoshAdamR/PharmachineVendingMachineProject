Public Class CheckoutPage
    Private Access As New DBController

    '' \\\\\\\\\\\\\\\\\\\\ control events functions ////////////////////// ''
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        ListPage.Show()
        Close()
    End Sub

    Private Sub minusBtn_Click(sender As Object, e As EventArgs) Handles minusBtn.Click
        AddQty(-1)
    End Sub

    Private Sub plusBtn_Click(sender As Object, e As EventArgs) Handles plusBtn.Click
        AddQty(1)
    End Sub

    Public Sub payBtn_Click(sender As Object, e As EventArgs) Handles payBtn.Click
        Dim amt As Integer = Val(qtyLabel.Text)
        Dim pName As String = nameLabel.Text
        Dim todayDate As Date = Date.Today

        Dim currentAmt As Integer
        Dim newAmt As Integer

        If cashOption.Checked Then
            ' set msg to empty
            errMsg.Text = Nothing

            ' check if any entries
            Dim numRecords = GetNumRecords()

            If numRecords > 0 Then
                Dim Row As DataRow = Access.DataTable.Rows(0)
                ' date of latest entry in DB
                Dim accessedDate As Date = Row("purchasedate")

                ' scroll through DB to see if any dates equal to today
                If Not accessedDate.Equals(todayDate) Then
                    For i As Integer = 1 To Access.RecordCount - 1
                        Row = Access.DataTable.Rows(i)
                        accessedDate = Row("purchasedate")

                        If accessedDate.Equals(todayDate) Then
                            accessedDate = todayDate
                            Exit For
                        Else
                            Continue For
                        End If
                    Next
                End If

                ' if latest entry is today, UPDATE
                If accessedDate.Equals(todayDate) Then
                    Dim newAmount = Row("amount") + amt
                    UpdateRecord(todayDate, newAmount)
                Else
                    EnterRecord(todayDate, amt)
                End If
            Else
                ' if no entries of today INSERT
                EnterRecord(todayDate, amt)
            End If

            currentAmt = CInt(amountLabel.Text)
            newAmt = currentAmt - amt

            ' update products in machine
            If UpdateProduct(newAmt) Then
                MsgBox("Please insert specified total", MsgBoxStyle.Information, "Payment")
                MsgBox("Payment successful! Please check collection area for your product",
                        MsgBoxStyle.Information,
                        "Purchase success!")
                StartPage.Show()
                Close()
            Else
                MsgBox("System Failure!", MsgBoxStyle.Exclamation, "ERROR!")
            End If
        Else
            errMsg.Text = "Please choose payment option"
        End If
    End Sub

    '' \\\\\\\\\\\\\\\\\\\\ DB Related functions////////////////////// ''
    Public Sub LoadProductDetails(pName As String)
        Access.AddParams("@pName", pName)

        Access.RunQuery("SELECT ProductName, ProductPrice, ProductImage, Amount " &
                        "FROM Products " &
                        "WHERE ProductName=@pName ")

        If HasErrors(True) Then Exit Sub

        Dim Row As DataRow = Access.DataTable.Rows(0)

        nameLabel.Text = Row("ProductName")
        priceLabel.Text = Format(Row("ProductPrice"), "RM 0.00")
        amountLabel.Text = Row("Amount")
        imgDisplay.Image = RetrieveImageFromDb(Row)

        totalLabel.Text = Format(Row("ProductPrice"), "RM 0.00")
    End Sub

    Private Function GetNumRecords() As Integer
        Access.AddParams("@pName", nameLabel.Text)
        Access.RunQuery("SELECT purchasedate, amount " &
                        "FROM stats " &
                        "WHERE productname=@pName " &
                        "ORDER BY purchasedate DESC")

        If HasErrors(True) Then
            Return -1
            Exit Function
        End If

        Return Access.RecordCount
    End Function

    Private Sub EnterRecord(pDate As Date, amt As Integer)
        Access.AddParams("@pName", nameLabel.Text)
        Access.AddParams("@pDate", pDate)
        Access.AddParams("@amt", amt)

        Access.RunQuery("INSERT INTO Stats(productname, purchasedate, amount) " &
                        "VALUES(@pName, @pDate, @amt)")

        If HasErrors(True) Then Exit Sub
    End Sub

    Private Sub UpdateRecord(pDate As Date, amt As Integer)
        ' order of params matter!!!
        Access.AddParams("@amt", amt)
        Access.AddParams("@pDate", pDate)
        Access.AddParams("@pName", nameLabel.Text)

        Access.RunQuery("UPDATE Stats " &
                        "SET amount=@amt " &
                        "WHERE purchasedate=@pDate AND productname=@pName")
    End Sub

    Private Function UpdateProduct(newAmt As Integer) As Boolean
        Access.AddParams("@amt", newAmt)
        Access.AddParams("@pName", nameLabel.Text)

        Access.RunQuery("UPDATE Products " &
                        "SET amount=@amt " &
                        "WHERE productname=@pName")

        If HasErrors(True) Then
            Return False
            Exit Function
        End If

        Return True
    End Function

    '' \\\\\\\\\\\\\\\\\\\\ other functions ////////////////////// ''
    Private Sub AddQty(value As Integer)
        Dim qty = Val(qtyLabel.Text)
        Dim amountLeft = Val(amountLabel.Text)

        ' allow user to buy at most 5
        Dim limit = 5

        If amountLeft < limit Then limit = amountLeft
        qty += value

        If qty > limit Then
            qty = limit
        ElseIf qty < 1 Then
            qty = 1
        End If

        qtyLabel.Text = qty
        totalLabel.Text = Format(qty * priceLabel.Text, "RM 0.00")
    End Sub

    Private Function RetrieveImageFromDb(imgFromDb As DataRow) As Image
        Using memStream As New IO.MemoryStream(DirectCast(imgFromDb("ProductImage"), Byte()))
            Return Image.FromStream(memStream)
        End Using
    End Function

    Private Function IsNotEmpty(str As String) As Boolean
        Return Not String.IsNullOrEmpty(str)
    End Function

    Private Function HasErrors(Optional report As Boolean = False) As Boolean
        If IsNotEmpty(Access.Exception) Then
            If report = True Then
                MsgBox(Access.Exception, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "DB Error")
            End If
            Return True
        Else
            Return False
        End If
    End Function

    '' \\\\\\\\\\\\\\\\\\\\ simple animations ////////////////////// ''
    ' handle minusBtn pressing animation
    Private Sub minusBtn_MouseDown(sender As Object, e As EventArgs) Handles minusBtn.MouseDown
        minusBtn.BackgroundImage = My.Resources.minusPressed
    End Sub
    Private Sub minusBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles minusBtn.MouseUp
        minusBtn.BackgroundImage = My.Resources.minus
    End Sub

    ' handle plusBtn pressing animation
    Private Sub plusBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles plusBtn.MouseDown
        plusBtn.BackgroundImage = My.Resources.plusPressed
    End Sub
    Private Sub plusBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles plusBtn.MouseUp
        plusBtn.BackgroundImage = My.Resources.plus
    End Sub

    ' simple pressing animation For back button
    Private Sub backBtn_MouseDown(sender As Object, e As EventArgs) Handles backBtn.MouseDown
        backBtn.BackgroundImage = My.Resources.backBtnPressed
    End Sub
    Private Sub backBtn_MouseUp(sender As Object, e As EventArgs) Handles backBtn.MouseUp
        backBtn.BackgroundImage = My.Resources.backBtn
    End Sub

    ' simple pressing animation for pay button
    Private Sub payBtn_MouseDown(sender As Object, e As EventArgs) Handles payBtn.MouseDown
        payBtn.BackgroundImage = My.Resources.payBtnPressed
    End Sub
    Private Sub payBtn_MouseUp(sender As Object, e As EventArgs) Handles payBtn.MouseUp
        payBtn.BackgroundImage = My.Resources.payBtn
    End Sub
End Class