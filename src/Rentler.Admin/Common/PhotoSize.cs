using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class PhotoSize
    {
        public PhotoSize(int width, int height, ScaleBehavior behavior)
        {
            this.Width = width;
            this.Height = height;
            this.ScaleBehavior = behavior;
        }
        public int Width { get; set; }
        public int Height { get; set; }

        public ScaleBehavior ScaleBehavior { get; set; }

        public bool IsOriginal
        {
            get
            {
                return Width == 0 && Height == 0;
            }
        }
    }

    public enum ScaleBehavior
    {
        ScaleWidth,
        ScaleHeight,
        ScaleBoth,
        Crop,
        None
    }
}
