using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication79 {
    public class CustomTileNavPane : TileNavPane {
        Bitmap _arrowGlyph;
        public CustomTileNavPane() : base() {

        }
        protected override TileNavPaneViewInfo CreateViewInfo() {
            return new CustomTileNavPaneViewInfo(this);
        }
        public Bitmap ArrowGlyph { get { return _arrowGlyph; } set { _arrowGlyph = value; } }
    }
}
