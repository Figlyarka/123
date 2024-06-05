using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer.Filters.Transformations
{
    public class BevelUpTransformer : ITransformer<BevelUpParameters>
    {
        double alpha;
        Size oldSize;
        public Size ResultSize { get; private set; }

        public void Initialize(Size oldSize, BevelUpParameters parameters)
        {
            this.oldSize = oldSize;
            alpha = parameters.AngleInDegrees * Math.PI / 180;

            int newHeight = (int)(oldSize.Height + oldSize.Width * Math.Tan(alpha));
            ResultSize = new Size(oldSize.Width, newHeight);
        }

        public Point? MapPoint(Point newPoint)
        {
            int dy = (int)(newPoint.X * Math.Sin(alpha));

            int x = newPoint.X;
            int y = newPoint.Y - dy; 

            if (x < 0 || x >= oldSize.Width || y < 0 || y >= oldSize.Height)
                return null;

            return new Point(x, y);
        }
    }
}
