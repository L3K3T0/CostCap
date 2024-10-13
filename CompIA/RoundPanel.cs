using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class RoundedPanel : Panel
{
    public int CornerRadius { get; set; } = 10; // Adjust this value to change the corner radius

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;
        Rectangle bounds = new Rectangle(0, 0, Width, Height);

        // Fill the background with the panel's BackColor
        g.FillRectangle(new SolidBrush(BackColor), bounds);

        // Create a GraphicsPath with rounded corners
        using (GraphicsPath path = RoundedRectangle(bounds, CornerRadius))
        {
            // Set the panel's Region to the rounded GraphicsPath
            Region = new Region(path);

            // Draw a border (optional)
            g.DrawPath(Pens.Black, path);
        }
    }

    private GraphicsPath RoundedRectangle(Rectangle bounds, int cornerRadius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = cornerRadius * 2;
        Rectangle arc = new Rectangle(bounds.X, bounds.Y, diameter, diameter);

        // Top-left corner
        path.AddArc(arc, 180, 90);

        // Top-right corner
        arc.X = bounds.Right - diameter;
        path.AddArc(arc, 270, 90);

        // Bottom-right corner
        arc.Y = bounds.Bottom - diameter;
        path.AddArc(arc, 0, 90);

        // Bottom-left corner
        arc.X = bounds.Left;
        path.AddArc(arc, 90, 90);

        path.CloseFigure();
        return path;
    }
}
