namespace WindowsFormsApplication79 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.customTileNavPane1 = new WindowsFormsApplication79.CustomTileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileNavCategory3 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.tileNavItem1 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem2 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavCategory4 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.tileNavCategory5 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.SuspendLayout();
            // 
            // customTileNavPane1
            // 
            this.customTileNavPane1.ArrowGlyph = global::WindowsFormsApplication79.Properties.Resources.next_16x16;
            this.customTileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.customTileNavPane1.Buttons.Add(this.navButton2);
            this.customTileNavPane1.Categories.AddRange(new DevExpress.XtraBars.Navigation.TileNavCategory[] {
            this.tileNavCategory3,
            this.tileNavCategory4,
            this.tileNavCategory5});
            // 
            // tileNavCategory1
            // 
            this.customTileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.customTileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.customTileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.customTileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.customTileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.customTileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.customTileNavPane1.Name = "customTileNavPane1";
            this.customTileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.customTileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.customTileNavPane1.Size = new System.Drawing.Size(476, 40);
            this.customTileNavPane1.TabIndex = 0;
            this.customTileNavPane1.Text = "customTileNavPane1";
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Main Menu";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // tileNavCategory3
            // 
            this.tileNavCategory3.Caption = "Item";
            this.tileNavCategory3.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tileNavItem1,
            this.tileNavItem2});
            this.tileNavCategory3.Name = "tileNavCategory3";
            this.tileNavCategory3.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavCategory3.OwnerCollection = this.customTileNavPane1.Categories;
            // 
            // 
            // 
            this.tileNavCategory3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "tileNavCategory3";
            this.tileNavCategory3.Tile.Elements.Add(tileItemElement3);
            this.tileNavCategory3.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavCategory3.Tile.Name = "tileBarItem2";
            // 
            // tileNavItem1
            // 
            this.tileNavItem1.Caption = "SubItem";
            this.tileNavItem1.Name = "tileNavItem1";
            this.tileNavItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem1.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // 
            // 
            this.tileNavItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "tileNavItem1";
            this.tileNavItem1.Tile.Elements.Add(tileItemElement1);
            this.tileNavItem1.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem1.Tile.Name = "tileBarItem1";
            // 
            // tileNavItem2
            // 
            this.tileNavItem2.Caption = "tileNavItem2";
            this.tileNavItem2.Name = "tileNavItem2";
            this.tileNavItem2.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem2.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // 
            // 
            this.tileNavItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "tileNavItem2";
            this.tileNavItem2.Tile.Elements.Add(tileItemElement2);
            this.tileNavItem2.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem2.Tile.Name = "tileBarItem5";
            // 
            // tileNavCategory4
            // 
            this.tileNavCategory4.Caption = "tileNavCategory4";
            this.tileNavCategory4.Name = "tileNavCategory4";
            this.tileNavCategory4.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavCategory4.OwnerCollection = this.customTileNavPane1.Categories;
            // 
            // 
            // 
            this.tileNavCategory4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "tileNavCategory4";
            this.tileNavCategory4.Tile.Elements.Add(tileItemElement4);
            this.tileNavCategory4.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavCategory4.Tile.Name = "tileBarItem3";
            // 
            // tileNavCategory5
            // 
            this.tileNavCategory5.Caption = "tileNavCategory5";
            this.tileNavCategory5.Name = "tileNavCategory5";
            this.tileNavCategory5.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavCategory5.OwnerCollection = this.customTileNavPane1.Categories;
            // 
            // 
            // 
            this.tileNavCategory5.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "tileNavCategory5";
            this.tileNavCategory5.Tile.Elements.Add(tileItemElement5);
            this.tileNavCategory5.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavCategory5.Tile.Name = "tileBarItem4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 185);
            this.Controls.Add(this.customTileNavPane1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTileNavPane customTileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory3;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem1;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem2;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory4;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory5;
    }
}

