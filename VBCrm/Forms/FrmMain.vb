﻿Imports System.Reflection

Imports System.Text
Imports System.Environment
Imports MaterialSkin.Controls

''' <summary>
''' Represents the main form.
''' </summary>
Public Class FrmMain
    Private dbOperations As DbOperations

#Region "Events"

#Region "Form events"
    ''' <summary>
    ''' Handles the main form load event.
    ''' </summary>
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbOperations = New DbOperations()
        dbOperations.CreateCustomersTable()

        ApplyDarkModeColorScheme(dgvResults, frm:=Me)

        btnSearch.PerformClick()
        dgvResults.ClearSelection()
    End Sub

    ''' <summary>
    ''' Handles the main form closing event.
    ''' </summary>
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbOperations.CloseConnection()
    End Sub
#End Region

#Region "Menu events"
    Private Sub MnuItmExit_Click(sender As Object, e As EventArgs) Handles mnuItmExit.Click
        Me.Close()
    End Sub

    Private Sub MnuItmAbout_Click(sender As Object, e As EventArgs) Handles mnuItmAbout.Click
        ShowAboutForm()
        ApplyDarkModeColorScheme(dgvResults, Me)
    End Sub
#End Region

#Region "Grid events"
    Private Sub dgvResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellDoubleClick
        btnEdit.PerformClick()
    End Sub

#End Region

#Region "Button events"


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim name As String = txtName.Text.Trim()
        Dim phoneNumber As String = txtPhoneNumber.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        Try
            Dim dataTable As DataTable = dbOperations.SearchContacts(name, phoneNumber, email)
            dgvResults.DataSource = dataTable

            dgvResults.DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            MessageBox.Show(Me, "An error occurred while searching contacts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim createForm As New FrmCreateEdit With {
            .IsNewRecord = True
        }

        createForm.ShowDialog(Me)
        btnSearch.PerformClick()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvResults.SelectedRows.Count <= 0 Then
            MessageBox.Show(Me, "Please select a Contact to edit...",
                            My.Application.Info.Title & " - No Contact selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvResults.SelectedRows(0)

        Dim contact As New Contact With {
            .ContactId = CInt(selectedRow.Cells(colId.Index).Value.ToString().Trim()),
            .ContactName = selectedRow.Cells(colName.Index).Value.ToString().Trim(),
            .ContactPhone = selectedRow.Cells(colPhone.Index).Value.ToString().Trim(),
            .ContactEmail = selectedRow.Cells(colEmail.Index).Value.ToString().Trim()
        }

        Dim editForm As New FrmCreateEdit With {
            .Contact = contact,
            .IsNewRecord = False
        }

        editForm.ShowDialog(Me)
        btnSearch.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFormControls(Me)
    End Sub
#End Region

#Region "Textbox events"
    Private Sub txtPhoneNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown, txtName.KeyDown, txtPhoneNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub mnuItmDarkMode_Click(sender As Object, e As EventArgs) Handles mnuItmDarkMode.Click
        ApplyDarkModeColorScheme(dgvResults, frm:=Me)
    End Sub

    Private Sub mnuItmLightMode_Click(sender As Object, e As EventArgs) Handles mnuItmLightMode.Click
        ApplyLightModeColorScheme(dgvResults, frm:=Me)
    End Sub

#End Region

#End Region

#Region "Functions and subs"



#End Region



End Class
