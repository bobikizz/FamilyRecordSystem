using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientForm : Form
{
    public GradientForm()
    {
        SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw, true);
    }


    protected override void OnPaintBackground(PaintEventArgs e)
    {
        DrawGradientBackground(e.Graphics);
    }

    public void DrawGradientBackground(Graphics g)
    {
        Rectangle rect = ClientRectangle;

        if (rect.Width <= 0 || rect.Height <= 0)
            return;

        // Основной градиент
        using (LinearGradientBrush brush =
            new LinearGradientBrush(
                rect,
                Color.FromArgb(15, 23, 42),
                Color.FromArgb(37, 54, 93),
                LinearGradientMode.ForwardDiagonal))
        {
            g.FillRectangle(brush, rect);
        }

        GraphicsState state = g.Save();

        try
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Синее свечение
            DrawGlow(
                g,
                new Point(ClientSize.Width - 80, 60),
                250,
                Color.FromArgb(59, 130, 246));

            // Фиолетовое свечение
            DrawGlow(
                g,
                new Point(50, ClientSize.Height - 80),
                230,
                Color.FromArgb(139, 92, 246));
        }
        finally
        {
            g.Restore(state);
        }
    }


    private void DrawGlow(
        Graphics g, Point center, int radius, Color color)
    {
        Rectangle area = new Rectangle(
            center.X - radius,
            center.Y - radius,
            radius * 2,
            radius * 2);

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddEllipse(area);

            using (PathGradientBrush brush =
                new PathGradientBrush(path))
            {
                brush.CenterColor = Color.FromArgb(
                    75, color.R, color.G, color.B);

                brush.SurroundColors = new Color[]
                {
                    Color.FromArgb(0, color.R, color.G, color.B)
                };

                g.FillPath(brush, path);
            }
        }
    }
}
