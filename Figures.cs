namespace FiguresList
{
    public abstract class Figures
    {
        //Не дает возможность создавать экземпляры этого класса
    }

    public class Triangle : Figures
    {
        public Triangle(double a, double b, double c)
        {
            //Для того, что бы создать экземпляр класса, нужно что бы у этого класса был хоть один конструктор. 
            //Базовый(пустой), который не требует ничего на вход создается автоматически, если нет никаких других. 
            //Тут же я создал конструктор который на вход требует стороны в виде double.
            SideA = a;
            SideB = b;
            SideC = c;
        }
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
    }

    public class Circle : Figures
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
    }
}
