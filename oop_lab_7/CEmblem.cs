using System.Drawing;

namespace oop_lab_7 {
    public class CEmblem {
        // Константи
        const int DefaultRadius = 50;   // Радіус кола за замовчуванням, пікс
        // Поля
        private Graphics graphics;
        private int _radius;            // Підтримуюче поле для властивості Radius
        // Властивості
        public int X { get; set; }      // Координата X центра кола
        public int Y { get; set; }      // Координата Y центра кола
        public int Radius               // Радіус кола
        { 
            get { return _radius; }
            set {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }
        }
        // Конструктор, створює об'єкт кола (для заданої поверхні
        // малювання GDI+) з заданими координатами.
        // Радіус кола приймається за замовчуванням
        public CEmblem(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }
        // Конструктор, створює об'єкт кола (для заданої поверхні
        // малювання GDI+) з заданими координатами та радіусом
        public CEmblem(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }
        // Малює коло на поверхні малювання GDI+.
        // Параметри кола задає перо pen
        private void Draw(Pen pen)
        {
            Rectangle rectangle1 = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            Rectangle rectangle2 = new Rectangle(X - Radius / 2, Y - Radius / 2, Radius, Radius);
            Point[] P =
                {
                  new Point(X - (int)(Radius*0.866), Y + Radius/2),
                  new Point(X + (int)(Radius*0.866), Y + Radius/2),
                  new Point(X, Y - Radius),
                };
            graphics.DrawEllipse(pen, rectangle1);
            graphics.DrawEllipse(pen, rectangle2);
            graphics.DrawPolygon(pen, P);
        }
        public void Show() { Draw(Pens.Red); } // Показує коло
        public void Hide() { Draw(Pens.White); } // Приховує коло 
        public void Expand() // Розширює коло: збільшує радіус на один піксель
        {
            Hide();
            Radius++;
            Show();
        }
        public void Expand(int dR) // Розширює коло: збільшує радіус на dR пікселів
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }
        public void Collapse() // Стискає коло: зменшує радіус на один піксель
        {
            Hide();
            Radius--;
            Show();
        }        
        public void Collapse(int dR) // Стискає коло: зменшує радіус на dR пікселів
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }
        public void Move(int dX, int dY) // Переміщує коло
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
    }
}