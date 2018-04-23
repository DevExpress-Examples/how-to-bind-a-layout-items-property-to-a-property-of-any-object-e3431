Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Data
Imports DevExpress.Xpf.Docking

Namespace BindToProperty_Ex
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			Dim targetControl As DependencyObject = dm1.GetItem("myLabel")
			BindingOperations.SetBinding(targetControl, BaseLayoutItem.CaptionProperty, New Binding("Text") With {.Source = myTextEdit})
		End Sub
	End Class
End Namespace
