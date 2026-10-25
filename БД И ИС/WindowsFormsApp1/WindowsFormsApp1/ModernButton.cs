
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernButton : Button
{
    private int borderRadius = 15;

    private Color normalColor =
        Color.FromArgb(48, 68, 102);

    private Color hoverColor =
        Color.FromArgb(65, 100, 160);

    private Color pressedColor =
        Color.FromArgb(30, 55, 100);

    private Color borderColor =
        Color.FromArgb(84, 109, 148);

    private Color customTextColor = Color.White;

    private bool isHovered;
    private bool isPressed;

    [Category("Modern Appearance")]
    public int BorderRadius
    {
        get { return borderRadius; }
        set
        {
            borderRadius = Math.Max(0, value);
            Invalidate();
        }
    }

    [Category("Modern Appearance")]
    public Color NormalColor
    {
        get { return normalColor; }
        set
        {
            normalColor = value;
            Invalidate();
        }
    }

    [Category("Modern Appearance")]
    public Color HoverColor
    {
        get { return hoverColor; }
        set
        {
            hoverColor = value;
            Invalidate();
        }
    }

    [Category("Modern Appearance")]
    public Color PressedColor
    {
        get { return pressedColor; }
        set
        {
            pressedColor = value;
            Invalidate();
        }
    }

    [Category("Modern Appearance")]
    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            borderColor = value;
            Invalidate();
        }
    }

    [Category("Modern Appearance")]
    public Color CustomTextColor
    {
        get { return customTextColor; }
        set
        {
            customTextColor = value;
            Invalidate();
        }
    }

    public ModernButton()
    {
        SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw,
            true);

        // Не используем Transparent у Button
        BackColor = normalColor;

        Size = new Size(160, 50);
        Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        ForeColor = Color.White;
        Cursor = Cursors.Hand;

        UseVisualStyleBackColor = false;
    }

    // Фон будем рисовать самостоятельно в OnPaint
    protected override void OnPaintBackground(PaintEventArgs e)
    {
    }

    // ГЛАВНОЕ ИСПРАВЛЕНИЕ ЧЁРНЫХ УГЛОВ
    private void DrawParentBackground(PaintEventArgs e)
    {
        if (Parent == null)
        {
            e.Graphics.Clear(SystemColors.Control);
            return;
        }

        Graphics g = e.Graphics;
        GraphicsState state = g.Save();

        try
        {
            // Переходим к координатам родителя
            g.TranslateTransform(-Left, -Top);

            Rectangle bounds = new Rectangle(
                Left, Top, Width, Height);

            using (PaintEventArgs args =
                new PaintEventArgs(g, bounds))
            {
                // Рисуем фон родителя
                InvokePaintBackground(Parent, args);

                // Рисуем его пользовательский Paint
                InvokePaint(Parent, args);
            }
        }
        finally
        {
            g.Restore(state);
        }
    }

    // ПЛАВНЫЕ СКРУГЛЕНИЯ
    private GraphicsPath GetRoundPath(
        RectangleF rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();

        radius = Math.Max(0,
            Math.Min(radius,
                Math.Min(rect.Width, rect.Height) / 2f));

        if (radius <= 0)
        {
            path.AddRectangle(rect);
            return path;
        }

        float d = radius * 2;

        path.AddArc(
            rect.X, rect.Y, d, d, 180, 90);

        path.AddArc(
            rect.Right - d, rect.Y,
            d, d, 270, 90);

        path.AddArc(
            rect.Right - d, rect.Bottom - d,
            d, d, 0, 90);

        path.AddArc(
            rect.X, rect.Bottom - d,
            d, d, 90, 90);

        path.CloseFigure();

        return path;
    }

    // ОТРИСОВКА
    protected override void OnPaint(PaintEventArgs e)
    {
        if (Width <= 2 || Height <= 2)
            return;

        Graphics g = e.Graphics;

        // Сначала восстанавливаем фон под кнопкой
        DrawParentBackground(e);

        // Затем рисуем сглаженную кнопку
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.PixelOffsetMode = PixelOffsetMode.HighQuality;

        Color currentColor = NormalColor;

        if (!Enabled)
            currentColor = Color.Gray;
        else if (isPressed)
            currentColor = PressedColor;
        else if (isHovered)
            currentColor = HoverColor;

        RectangleF rect = new RectangleF(
            0.5f, 0.5f,
            Width - 1f, Height - 1f);

        using (GraphicsPath path =
            GetRoundPath(rect, BorderRadius))
        {
            using (SolidBrush brush =
                new SolidBrush(currentColor))
            {
                g.FillPath(brush, path);
            }

            using (Pen pen =
                new Pen(BorderColor, 1f))
            {
                g.DrawPath(pen, path);
            }
        }

        // Текст
        TextRenderer.DrawText(
            g,
            Text,
            Font,
            ClientRectangle,
            Enabled ? CustomTextColor : Color.LightGray,
            TextFormatFlags.HorizontalCenter |
            TextFormatFlags.VerticalCenter |
            TextFormatFlags.EndEllipsis);
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        isHovered = true;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        isHovered = false;
        isPressed = false;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);

        if (e.Button == MouseButtons.Left)
        {
            isPressed = true;
            Invalidate();
        }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        isPressed = false;
        Invalidate();
    }

    protected override void OnMouseCaptureChanged(EventArgs e)
    {
        base.OnMouseCaptureChanged(e);
        isPressed = false;
        Invalidate();
    }

    protected override void OnLocationChanged(EventArgs e)
    {
        base.OnLocationChanged(e);
        Invalidate();
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        Invalidate();
    }
}
