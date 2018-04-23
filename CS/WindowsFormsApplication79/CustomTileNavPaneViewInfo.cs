using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WindowsFormsApplication79 {
    public class CustomTileNavPaneViewInfo : TileNavPaneViewInfo {
        public CustomTileNavPaneViewInfo(TileNavPane tileNavBar) : base(tileNavBar) {
            //arrowGlyph
        }
        protected override void CreateArrowButton() {
            Bitmap arrowGlyph = (this.TileNavPane as CustomTileNavPane).ArrowGlyph;
            if (arrowGlyph != null) {
                typeof(TileNavPaneViewInfo).GetField("arrowGlyph", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(this, arrowGlyph);
            }
            base.CreateArrowButton();
        }
    }
}
