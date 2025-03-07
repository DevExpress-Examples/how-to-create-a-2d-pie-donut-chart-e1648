Imports System.Collections.ObjectModel
Imports System.Windows

Namespace PieDonut2DChart

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ChartViewModel

        Private _Data As Collection(Of PieDonut2DChart.ChartViewModel.DataPoint)

        Public Property Data As Collection(Of DataPoint)
            Get
                Return _Data
            End Get

            Private Set(ByVal value As Collection(Of DataPoint))
                _Data = value
            End Set
        End Property

        Public Sub New()
            Data = New Collection(Of DataPoint) From {New DataPoint("Bikes", 142345), New DataPoint("Accessories", 266344), New DataPoint("Components", 631359), New DataPoint("Clothing", 120007)}
        End Sub

        Public Class DataPoint

            Private _Argument As String, _Value As Double

            Public Property Argument As String
                Get
                    Return _Argument
                End Get

                Private Set(ByVal value As String)
                    _Argument = value
                End Set
            End Property

            Public Property Value As Double
                Get
                    Return _Value
                End Get

                Private Set(ByVal value As Double)
                    _Value = value
                End Set
            End Property

            Public Sub New(ByVal argument As String, ByVal value As Double)
                Me.Argument = argument
                Me.Value = value
            End Sub
        End Class
    End Class
End Namespace
