//namespace Retkon.Fractions.Tests;

//[TestClass]
//public class FractionModulo
//{
//    [TestMethod]
//    public void Fraction_Modulo_ZeroModuloZero()
//    {
//        // Arrange
//        var a = Fraction.Zero;
//        var b = Fraction.Zero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(Fraction.Zero, result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_ZeroModuloOne()
//    {
//        // Arrange
//        var a = Fraction.Zero;
//        var b = new Fraction(1, 1);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(Fraction.One, result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_ZeroModuloMore()
//    {
//        // Arrange
//        var a = Fraction.Zero;
//        var b = new Fraction(24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(b, result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_ZeroModuloMinusOne()
//    {
//        // Arrange
//        var a = Fraction.Zero;
//        var b = Fraction.MinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(b, result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_ZeroModuloMinusMore()
//    {
//        // Arrange
//        var a = Fraction.Zero;
//        var b = new Fraction(-24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(b, result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_OneModuloZero()
//    {
//        // Arrange
//        var a = new Fraction(1, 1);
//        var b = Fraction.Zero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(Fraction.One, result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_OneModuloOne()
//    {
//        // Arrange
//        var a = new Fraction(1, 1);
//        var b = new Fraction(1, 1);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(2, 1), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_OneModuloMore()
//    {
//        // Arrange
//        var a = new Fraction(1, 1);
//        var b = new Fraction(24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(211, 187), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_OneModuloMinusOne()
//    {
//        // Arrange
//        var a = new Fraction(1, 1);
//        var b = Fraction.MinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(Fraction.Zero, result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_OneModuloMinusMore()
//    {
//        // Arrange
//        var a = new Fraction(1, 1);
//        var b = new Fraction(-24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(163, 187), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusOneModuloZero()
//    {
//        // Arrange
//        var a = Fraction.MinusOne;
//        var b = Fraction.Zero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(Fraction.MinusOne, result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusOneModuloOne()
//    {
//        // Arrange
//        var a = Fraction.MinusOne;
//        var b = new Fraction(1, 1);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(Fraction.Zero, result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusOneModuloMore()
//    {
//        // Arrange
//        var a = Fraction.MinusOne;
//        var b = new Fraction(24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(-163, 187), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusOneModuloMinusOne()
//    {
//        // Arrange
//        var a = Fraction.MinusOne;
//        var b = Fraction.MinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(-2, 1), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusOneModuloMinusMore()
//    {
//        // Arrange
//        var a = Fraction.MinusOne;
//        var b = new Fraction(-24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(-211, 187), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MoreModuloZero()
//    {
//        // Arrange
//        var a = new Fraction(12, 179);
//        var b = Fraction.Zero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(12, 179), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MoreModuloOne()
//    {
//        // Arrange
//        var a = new Fraction(12, 179);
//        var b = new Fraction(1, 1);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(191, 179), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MoreModuloMore()
//    {
//        // Arrange
//        var a = new Fraction(12, 179);
//        var b = new Fraction(24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(6540, 33473), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MoreModuloMinusOne()
//    {
//        // Arrange
//        var a = new Fraction(12, 179);
//        var b = Fraction.MinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(-167, 179), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MoreModuloMinusMore()
//    {
//        // Arrange
//        var a = new Fraction(12, 179);
//        var b = new Fraction(-24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(-2052, 33473), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusMoreModuloZero()
//    {
//        // Arrange
//        var a = new Fraction(-12, 179);
//        var b = Fraction.Zero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(-12, 179), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusMoreModuloOne()
//    {
//        // Arrange
//        var a = new Fraction(-12, 179);
//        var b = new Fraction(1, 1);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(167, 179), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusMoreModuloMore()
//    {
//        // Arrange
//        var a = new Fraction(-12, 179);
//        var b = new Fraction(24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(2052, 33473), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusMoreModuloMinusOne()
//    {
//        // Arrange
//        var a = new Fraction(-12, 179);
//        var b = Fraction.MinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(-191, 179), result);
//    }

//    [TestMethod]
//    public void Fraction_Modulo_MinusMoreModuloMinusMore()
//    {
//        // Arrange
//        var a = new Fraction(-12, 179);
//        var b = new Fraction(-24, 187);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new Fraction(-6540, 33473), result);
//    }
//}