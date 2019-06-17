Imports System.ComponentModel

Public Class Form1

    Private toolTip As New ToolTip()
    Private PersonCounter As Integer = 0
    Private AmountCounter As Integer = 0
    Private TotalAmount As Decimal = 0.0
    Private PersonAmountArray(100, 100) As Integer
    Private Status As String = String.Empty
    Private bw As BackgroundWorker = New BackgroundWorker

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddPersonTB.Select()
    End Sub

    Private Sub AddPersonBtn_Click(sender As Object, e As EventArgs) Handles AddPersonBtn.Click
        If AddPersonTB.Text = "" Then
            Exit Sub
        End If
        NameCB.Items.Insert(PersonCounter, AddPersonTB.Text)
        Status &= AddPersonTB.Text & " Added" & Environment.NewLine
        AddPersonTB.Text = ""
        'ReDim Preserve PersonAmountArray(PersonCounter, AmountCounter)
        PersonAmountArray(PersonCounter, 0) = 0
        PersonCounter = PersonCounter + 1
        AddPersonTB.Select()
        AnswerRTB.Text = Status
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If Not IsNumeric(AmountTB.Text) Then
            Status &= "Invalid Amount"
            AnswerRTB.Text = Status
            Exit Sub
        End If
        TotalAmount = TotalAmount + AmountTB.Text
        Dim personId As Integer
        Try
            personId = NameCB.SelectedIndex
        Catch ex As Exception
            Exit Sub
        End Try
        PersonAmountArray(personId, AmountCounter) = AmountTB.Text
        AmountCounter = AmountCounter + 1
        NameCB.Select()
        Status &= NameCB.SelectedItem.ToString & " Has Paid Rs." & AmountTB.Text & Environment.NewLine
        AnswerRTB.Text = Status
    End Sub

    Private Sub HisabBtn_Click(sender As Object, e As EventArgs) Handles HisabBtn.Click
        'If Not bw.IsBusy = True Then
        '    bw.RunWorkerAsync()
        'End If
        Dim PerHeadAmount, IndividualAmount, ExtraDueAmount, SettlementAmount As Decimal
        Dim ExtraDueArray(PersonCounter - 1) As Integer
        Dim Hisab As String = "Total Amount is Rs." & TotalAmount
        PerHeadAmount = Math.Round(TotalAmount / PersonCounter, 0)
        Hisab &= Environment.NewLine
        Hisab &= Environment.NewLine
        Hisab &= "Each one has to pay Rs." & PerHeadAmount
        Hisab &= Environment.NewLine
        Hisab &= Environment.NewLine
        For pCount = 0 To PersonCounter - 1
            IndividualAmount = 0
            For aCount = 0 To AmountCounter - 1
                IndividualAmount = IndividualAmount + PersonAmountArray(pCount, aCount)
            Next
            ExtraDueAmount = IndividualAmount - PerHeadAmount
            ExtraDueArray(pCount) = ExtraDueAmount
            Hisab &= NameCB.Items(pCount).ToString() & " paid Rs." & IndividualAmount & "  =>  " & ExtraDueAmount
            Hisab &= Environment.NewLine
        Next
        Hisab &= Environment.NewLine
        For hCount = 0 To ExtraDueArray.Count - 1
            SettlementAmount = 0
            If ExtraDueArray(hCount) < 0 Then
                For cCount = 0 To ExtraDueArray.Count - 1
                    If ExtraDueArray(cCount) > 0 Then
                        SettlementAmount = ExtraDueArray(cCount) + ExtraDueArray(hCount)
                        If SettlementAmount = 0 Then
                            Hisab &= NameCB.Items(hCount).ToString() & " has to pay Rs." & ExtraDueArray(hCount) * (-1) & " to " & NameCB.Items(cCount).ToString()
                            Hisab &= Environment.NewLine
                            ExtraDueArray(hCount) = SettlementAmount
                            ExtraDueArray(cCount) = SettlementAmount
                            Exit For
                        ElseIf SettlementAmount < 0 Then
                            Hisab &= NameCB.Items(hCount).ToString() & " has to pay Rs." & ExtraDueArray(cCount) & " to " & NameCB.Items(cCount).ToString()
                            Hisab &= Environment.NewLine
                            ExtraDueArray(hCount) = SettlementAmount
                            ExtraDueArray(cCount) = SettlementAmount
                            Exit For
                        ElseIf SettlementAmount > 0 Then
                            Hisab &= NameCB.Items(hCount).ToString() & " has to pay Rs." & ExtraDueArray(hCount) * (-1) & " to " & NameCB.Items(cCount).ToString()
                            Hisab &= Environment.NewLine
                            ExtraDueArray(hCount) = 0
                            ExtraDueArray(cCount) = SettlementAmount
                            Exit For
                        End If
                    End If
                Next
            End If
        Next       
        AnswerRTB.Text = Hisab
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click        
        PersonCounter = 0
        AmountCounter = 0
        TotalAmount = 0
        ReDim PersonAmountArray(100, 100)
        NameCB.Items.Clear()
        AnswerRTB.Clear()
        NameCB.Text = "-- Select Person --"
        AmountTB.Text = "Enter Amount"
        Status = ""
    End Sub

    Private Sub NameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameCB.SelectedIndexChanged

    End Sub

#Region "BackGroundWorker"

    Private Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker.DoWork
        TotalAmount = TotalAmount + 0
    End Sub

    Private Sub BackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged

    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        AnswerRTB.Text = "TOTAL AMOUNT = " & TotalAmount
    End Sub

#End Region


#Region "ExtraEffects"

    Private Sub AmountTB_TextChanged(sender As Object, e As EventArgs) Handles AmountTB.TextChanged
        
    End Sub

    Private Sub AmountTB_Enter(sender As Object, e As EventArgs) Handles AmountTB.Enter
        If AmountTB.Text = "Enter Amount" Then
            AmountTB.Text = ""
        End If
    End Sub

    Private Sub AmountTB_Leave(sender As Object, e As EventArgs) Handles AmountTB.Leave
        If AmountTB.Text = "" Then
            AmountTB.Text = "Enter Amount"
        End If
    End Sub

#End Region

End Class
