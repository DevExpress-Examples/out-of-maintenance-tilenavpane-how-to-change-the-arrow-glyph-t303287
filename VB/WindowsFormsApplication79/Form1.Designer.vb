Namespace WindowsFormsApplication79
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim tileItemElement3 As New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement1 As New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement2 As New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement4 As New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement5 As New DevExpress.XtraEditors.TileItemElement()
            Me.customTileNavPane1 = New WindowsFormsApplication79.CustomTileNavPane()
            Me.navButton2 = New DevExpress.XtraBars.Navigation.NavButton()
            Me.tileNavCategory3 = New DevExpress.XtraBars.Navigation.TileNavCategory()
            Me.tileNavItem1 = New DevExpress.XtraBars.Navigation.TileNavItem()
            Me.tileNavItem2 = New DevExpress.XtraBars.Navigation.TileNavItem()
            Me.tileNavCategory4 = New DevExpress.XtraBars.Navigation.TileNavCategory()
            Me.tileNavCategory5 = New DevExpress.XtraBars.Navigation.TileNavCategory()
            Me.SuspendLayout()
            ' 
            ' customTileNavPane1
            ' 
            Me.customTileNavPane1.ArrowGlyph = My.Resources.next_16x16
            Me.customTileNavPane1.ButtonPadding = New System.Windows.Forms.Padding(12)
            Me.customTileNavPane1.Buttons.Add(Me.navButton2)
            Me.customTileNavPane1.Categories.AddRange(New DevExpress.XtraBars.Navigation.TileNavCategory() { Me.tileNavCategory3, Me.tileNavCategory4, Me.tileNavCategory5})
            ' 
            ' tileNavCategory1
            ' 
            Me.customTileNavPane1.DefaultCategory.Name = "tileNavCategory1"
            Me.customTileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
            Me.customTileNavPane1.DefaultCategory.OwnerCollection = Nothing
            ' 
            ' 
            ' 
            Me.customTileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            Me.customTileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
            Me.customTileNavPane1.Dock = System.Windows.Forms.DockStyle.Top
            Me.customTileNavPane1.Location = New System.Drawing.Point(0, 0)
            Me.customTileNavPane1.Name = "customTileNavPane1"
            Me.customTileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
            Me.customTileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
            Me.customTileNavPane1.Size = New System.Drawing.Size(476, 40)
            Me.customTileNavPane1.TabIndex = 0
            Me.customTileNavPane1.Text = "customTileNavPane1"
            ' 
            ' navButton2
            ' 
            Me.navButton2.Caption = "Main Menu"
            Me.navButton2.IsMain = True
            Me.navButton2.Name = "navButton2"
            ' 
            ' tileNavCategory3
            ' 
            Me.tileNavCategory3.Caption = "Item"
            Me.tileNavCategory3.Items.AddRange(New DevExpress.XtraBars.Navigation.TileNavItem() { Me.tileNavItem1, Me.tileNavItem2})
            Me.tileNavCategory3.Name = "tileNavCategory3"
            Me.tileNavCategory3.OptionsDropDown.BackColor = System.Drawing.Color.Empty
            Me.tileNavCategory3.OwnerCollection = Me.customTileNavPane1.Categories
            ' 
            ' 
            ' 
            Me.tileNavCategory3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            tileItemElement3.Text = "tileNavCategory3"
            Me.tileNavCategory3.Tile.Elements.Add(tileItemElement3)
            Me.tileNavCategory3.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
            Me.tileNavCategory3.Tile.Name = "tileBarItem2"
            ' 
            ' tileNavItem1
            ' 
            Me.tileNavItem1.Caption = "SubItem"
            Me.tileNavItem1.Name = "tileNavItem1"
            Me.tileNavItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty
            Me.tileNavItem1.OwnerCollection = Me.tileNavCategory3.Items
            ' 
            ' 
            ' 
            Me.tileNavItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            tileItemElement1.Text = "tileNavItem1"
            Me.tileNavItem1.Tile.Elements.Add(tileItemElement1)
            Me.tileNavItem1.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
            Me.tileNavItem1.Tile.Name = "tileBarItem1"
            ' 
            ' tileNavItem2
            ' 
            Me.tileNavItem2.Caption = "tileNavItem2"
            Me.tileNavItem2.Name = "tileNavItem2"
            Me.tileNavItem2.OptionsDropDown.BackColor = System.Drawing.Color.Empty
            Me.tileNavItem2.OwnerCollection = Me.tileNavCategory3.Items
            ' 
            ' 
            ' 
            Me.tileNavItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            tileItemElement2.Text = "tileNavItem2"
            Me.tileNavItem2.Tile.Elements.Add(tileItemElement2)
            Me.tileNavItem2.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
            Me.tileNavItem2.Tile.Name = "tileBarItem5"
            ' 
            ' tileNavCategory4
            ' 
            Me.tileNavCategory4.Caption = "tileNavCategory4"
            Me.tileNavCategory4.Name = "tileNavCategory4"
            Me.tileNavCategory4.OptionsDropDown.BackColor = System.Drawing.Color.Empty
            Me.tileNavCategory4.OwnerCollection = Me.customTileNavPane1.Categories
            ' 
            ' 
            ' 
            Me.tileNavCategory4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            tileItemElement4.Text = "tileNavCategory4"
            Me.tileNavCategory4.Tile.Elements.Add(tileItemElement4)
            Me.tileNavCategory4.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
            Me.tileNavCategory4.Tile.Name = "tileBarItem3"
            ' 
            ' tileNavCategory5
            ' 
            Me.tileNavCategory5.Caption = "tileNavCategory5"
            Me.tileNavCategory5.Name = "tileNavCategory5"
            Me.tileNavCategory5.OptionsDropDown.BackColor = System.Drawing.Color.Empty
            Me.tileNavCategory5.OwnerCollection = Me.customTileNavPane1.Categories
            ' 
            ' 
            ' 
            Me.tileNavCategory5.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            tileItemElement5.Text = "tileNavCategory5"
            Me.tileNavCategory5.Tile.Elements.Add(tileItemElement5)
            Me.tileNavCategory5.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
            Me.tileNavCategory5.Tile.Name = "tileBarItem4"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(476, 185)
            Me.Controls.Add(Me.customTileNavPane1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private customTileNavPane1 As CustomTileNavPane
        Private navButton2 As DevExpress.XtraBars.Navigation.NavButton
        Private tileNavCategory3 As DevExpress.XtraBars.Navigation.TileNavCategory
        Private tileNavItem1 As DevExpress.XtraBars.Navigation.TileNavItem
        Private tileNavItem2 As DevExpress.XtraBars.Navigation.TileNavItem
        Private tileNavCategory4 As DevExpress.XtraBars.Navigation.TileNavCategory
        Private tileNavCategory5 As DevExpress.XtraBars.Navigation.TileNavCategory
    End Class
End Namespace

