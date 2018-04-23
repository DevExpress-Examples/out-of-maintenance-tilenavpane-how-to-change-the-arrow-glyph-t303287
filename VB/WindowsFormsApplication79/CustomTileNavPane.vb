Imports DevExpress.XtraBars.Navigation
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication79
    Public Class CustomTileNavPane
        Inherits TileNavPane

        Private _arrowGlyph As Bitmap
        Public Sub New()
            MyBase.New()

        End Sub
        Protected Overrides Function CreateViewInfo() As TileNavPaneViewInfo
            Return New CustomTileNavPaneViewInfo(Me)
        End Function
        Public Property ArrowGlyph() As Bitmap
            Get
                Return _arrowGlyph
            End Get
            Set(ByVal value As Bitmap)
                _arrowGlyph = value
            End Set
        End Property
    End Class
End Namespace
