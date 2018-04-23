Imports DevExpress.XtraBars.Navigation
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text

Namespace WindowsFormsApplication79
    Public Class CustomTileNavPaneViewInfo
        Inherits TileNavPaneViewInfo

        Public Sub New(ByVal tileNavBar As TileNavPane)
            MyBase.New(tileNavBar)
            'arrowGlyph
        End Sub
        Protected Overrides Sub CreateArrowButton()
            Dim arrowGlyph As Bitmap = (TryCast(Me.TileNavPane, CustomTileNavPane)).ArrowGlyph
            If arrowGlyph IsNot Nothing Then
                GetType(TileNavPaneViewInfo).GetField("arrowGlyph", BindingFlags.NonPublic Or BindingFlags.Instance).SetValue(Me, arrowGlyph)
            End If
            MyBase.CreateArrowButton()
        End Sub
    End Class
End Namespace
