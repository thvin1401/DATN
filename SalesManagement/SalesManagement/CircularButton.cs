using System.Drawing.Drawing2D;

namespace SalesManagement
{
    public partial class CircularButton : Button
    {
        public string Initial { get; set; } = "A";

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Make the button circular
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, this.Width, this.Height);
                this.Region = new Region(path);
            }

            // Set anti-aliasing for smoother edges
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the initial in the center
            using (Font font = new Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Point))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                SizeF textSize = e.Graphics.MeasureString(Initial, font);
                PointF textPosition = new PointF(
                    (this.Width - textSize.Width) / 2,
                    (this.Height - textSize.Height) / 2
                );

                e.Graphics.DrawString(Initial, font, brush, textPosition);
            }
        }
    }
}
