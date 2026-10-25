using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernButton : Button
{
    // Настройки внешнего вида в инспекторе Visual Studio (раздел "Modern Appearance")
    [Category("Modern Appearance")]
    [Description("Желаемый радиус закругления углов. Программа автоматически уменьшит его, если кнопка слишком мала, чтобы избежать багов.")]
    public int BorderRadius { get; set; } = 20;

    [Category("Modern Appearance")]
    [Description("Пастельный цвет кнопки в обычном состоянии.")]
    public Color NormalColor { get; set; } = Color.FromArgb(221, 235, 247); // Нежно-голубой

    [Category("Modern Appearance")]
    [Description("Цвет кнопки при наведении курсора мыши.")]
    public Color HoverColor { get; set; } = Color.FromArgb(198, 218, 238); // Чуть темнее

    [Category("Modern Appearance")]
    [Description("Цвет кнопки в момент клика.")]
    public Color PressedColor { get; set; } = Color.FromArgb(174, 199, 227); // Еще плотнее

    [Category("Modern Appearance")]
    [Description("Цвет тонкой пастельной обводки.")]
    public Color BorderColor { get; set; } = Color.FromArgb(180, 205, 230); // Мягкий контур

    [Category("Modern Appearance")]
    [Description("Цвет текста (рекомендуется использовать темно-серые оттенки вместо черного).")]
    public Color CustomTextColor { get; set; } = Color.FromArgb(70, 90, 110); // Элегантный грифельный

    private bool isHovered = false;
    private bool isPressed = false;

    public ModernButton()
    {
        // Включаем продвинутые стили отрисовки и буферизацию
        SetStyle(ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.UserPaint |
                 ControlStyles.ResizeRedraw |
                 ControlStyles.SupportsTransparentBackColor, true);

        // Базовые настройки стиля
        BackColor = Color.Transparent;
        Size = new Size(160, 45);
        Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular); // Современный утонченный шрифт
        Cursor = Cursors.Hand; // Курсор-рука при наведении
    }

    // Отслеживание событий мыши для смены состояний
    protected override void OnMouseEnter(EventArgs e) { isHovered = true; Invalidate(); base.OnMouseEnter(e); }
    protected override void OnMouseLeave(EventArgs e) { isHovered = false; isPressed = false; Invalidate(); base.OnMouseLeave(e); }
    protected override void OnMouseDown(MouseEventArgs mevent) { isPressed = true; Invalidate(); base.OnMouseDown(mevent); }
    protected override void OnMouseUp(MouseEventArgs mevent) { isPressed = false; Invalidate(); base.OnMouseUp(mevent); }

    // Метод построения сглаженного пути для закругления
    private GraphicsPath GetRoundPath(RectangleF rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        float diameter = radius * 2;

        if (radius <= 0)
        {
            path.AddRectangle(rect);
            return path;
        }

        float x = rect.X;
        float y = rect.Y;
        float width = rect.Width;
        float height = rect.Height;

        path.StartFigure();
        path.AddArc(x, y, diameter, diameter, 180, 90);
        path.AddArc(x + width - diameter, y, diameter, diameter, 270, 90);
        path.AddArc(x + width - diameter, y + height - diameter, diameter, diameter, 0, 90);
        path.AddArc(x, y + height - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();
        return path;
    }

    // Основная отрисовка компонента
    protected override void OnPaint(PaintEventArgs pevent)
    {
        Graphics g = pevent.Graphics;

        // Включаем максимальное сглаживание графики GDI+
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        g.PixelOffsetMode = PixelOffsetMode.HighQuality;

        // ИСПРАВЛЕНИЕ ЧЕРНЫХ УГЛОВ: Закрашиваем подложку цветом фона формы
        Color parentColor = this.Parent != null ? this.Parent.BackColor : SystemColors.Control;
        using (SolidBrush parentBrush = new SolidBrush(parentColor))
        {
            g.FillRectangle(parentBrush, ClientRectangle);
        }

        // АВТО-КОРРЕКТИРОВКА РАДИУСА ДЛЯ МАЛЕНЬКИХ КНОПОК:
        // Защита от выворачивания геометрии наизнанку и появления «ушек»
        int activeRadius = BorderRadius;
        int maxRadius = Math.Min(Width, Height) / 2;
        if (activeRadius > maxRadius)
        {
            activeRadius = maxRadius;
        }

        // Выбор пастельного цвета в зависимости от состояния кнопки
        Color currentBgColor = NormalColor;
        if (isPressed) currentBgColor = PressedColor;
        else if (isHovered) currentBgColor = HoverColor;

        // Небольшой отступ в 0.5 пикселя, чтобы контур не обрезался по краям контейнера
        RectangleF rectBounds = new RectangleF(0.5f, 0.5f, Width - 1f, Height - 1f);

        if (activeRadius > 0)
        {
            using (GraphicsPath path = GetRoundPath(rectBounds, activeRadius))
            {
                // Рисуем мягкое пастельное тело кнопки
                using (SolidBrush brush = new SolidBrush(currentBgColor))
                {
                    g.FillPath(brush, path);
                }

                // Рисуем аккуратную обводку для эффекта объема и гладкости стыков
                using (Pen pen = new Pen(BorderColor, 1f))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
        else
        {
            // Отрисовка без закругления, если activeRadius оказался равен 0
            using (SolidBrush brush = new SolidBrush(currentBgColor))
            {
                g.FillRectangle(brush, rectBounds);
            }
            using (Pen pen = new Pen(BorderColor, 1f))
            {
                g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }

        // Рисуем текст красивым цветом ровно по центру кнопки
        TextRenderer.DrawText(g, Text, Font, ClientRectangle, CustomTextColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
