Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro

Namespace DotNetNote
	Partial Public Class Form1
		Inherits MetroAppForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub richTextBoxEx1_LinkClicked(ByVal sender As Object, ByVal e As LinkClickedEventArgs) Handles richTextBoxEx1.LinkClicked
			System.Diagnostics.Process.Start(e.LinkText)
		End Sub
	End Class
End Namespace