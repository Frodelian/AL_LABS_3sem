namespace FigureTest;

using FigureNS;
using PointNS;

[TestClass] // указывает что это класс с модульными тестами
public class FigureTest
{
    [TestMethod] // представляет собой один тестовый сценарий для проверки функциональности класса Figure
    public void TestMethod1()
    {
        Figure figure = new Figure(new Point(1, 1), new Point(1, 4), new Point(5, 1)); // Создает объект figure типа Figure, 
        // передавая в конструктор три объекта типа Point, которые представляют координаты вершин фигуры 
        figure.PerimeterCalculator();
        Assert.AreEqual("Triangle", figure.name); // проверка имени фигуры
        Assert.AreEqual(12, figure.Perimeter); // и значения вычисления его периметра
    }
}
