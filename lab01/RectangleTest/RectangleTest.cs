using RectangleNS;

namespace RectangleTest;

[TestClass]
public class RectangleTest
{
    [TestMethod] // указание что это класс с модульными тестами 
    public void TestArea() // метод проверяет, что вычисления площади прямоугольника происходят корректно 
    {
        double side1 = 5.85;
        double side2 = 3.28;
        Rectangle rectangle = new(side1, side2); // создаёт объект rectangle типа Rectangle с заданными сторонами side1 и side2
        Assert.AreEqual(19.188, rectangle.Area, // сравнивается ожидаемое значение площади  с вычисленным значением площади прямоугольника (rectangle.Area).
            "Rectangle area mistake");
    }

    [TestMethod]
    public void TestPerimeter() // метод проверяет, что вычисления периметра происходят корректно 
    {
        double side1 = 5.85;
        double side2 = 3.28;
        Rectangle rectangle = new(side1, side2);
        Assert.AreEqual(18.26, rectangle.Perimeter, 0.001,
            "Rectangle perimeter mistake");
    }
}
