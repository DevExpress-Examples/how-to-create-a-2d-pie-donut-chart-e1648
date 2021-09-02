Imports System.Collections.ObjectModel
Imports System.Windows

Namespace PieDonut2DChart
	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class ChartViewModel
		Private privateData As Collection(Of DataPoint)
		Public Property Data() As Collection(Of DataPoint)
			Get
				Return privateData
			End Get
			Private Set(ByVal value As Collection(Of DataPoint))
				privateData = value
			End Set
		End Property
		Public Sub New()
			Data = New Collection(Of DataPoint) From {
				New DataPoint("Bikes", 142345),
				New DataPoint("Accessories", 266344),
				New DataPoint("Components", 631359),
				New DataPoint("Clothing", 120007)
			}
		End Sub
		Public Class DataPoint
			Private privateArgument As String
			Public Property Argument() As String
				Get
					Return privateArgument
				End Get
				Private Set(ByVal value As String)
					privateArgument = value
				End Set
			End Property
			Private privateValue As Double
			Public Property Value() As Double
				Get
					Return privateValue
				End Get
				Private Set(ByVal value As Double)
					privateValue = value
				End Set
			End Property
			Public Sub New(ByVal argument As String, ByVal value As Double)
				Me.Argument = argument
				Me.Value = value
			End Sub
		End Class
	End Class
End Namespace


