//namespace Retkon.Fractions.Units.Tests;

//[TestClass]
//public class FractionUnitModulo
//{
//    [TestMethod]
//    public void FractionUnit_Modulo_ZeroModuloZero()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitZero;
//        var b = TestUtility.FractionUnitZero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(TestUtility.FractionUnitZero, result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_ZeroModuloOne()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitZero;
//        var b = new FractionUnit(new Fraction(1, 1), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(TestUtility.FractionUnitOne, result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_ZeroModuloMore()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitZero;
//        var b = new FractionUnit(new Fraction(24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(b, result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_ZeroModuloMinusOne()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitZero;
//        var b = TestUtility.FractionUnitMinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(b, result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_ZeroModuloMinusMore()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitZero;
//        var b = new FractionUnit(new Fraction(-24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(b, result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_OneModuloZero()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(1, 1), []);
//        var b = TestUtility.FractionUnitZero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(TestUtility.FractionUnitOne, result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_OneModuloOne()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(1, 1), []);
//        var b = new FractionUnit(new Fraction(1, 1), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(2, 1), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_OneModuloMore()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(1, 1), []);
//        var b = new FractionUnit(new Fraction(24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(211, 187), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_OneModuloMinusOne()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(1, 1), []);
//        var b = TestUtility.FractionUnitMinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(TestUtility.FractionUnitZero, result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_OneModuloMinusMore()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(1, 1), []);
//        var b = new FractionUnit(new Fraction(-24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(163, 187), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusOneModuloZero()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitMinusOne;
//        var b = TestUtility.FractionUnitZero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(TestUtility.FractionUnitMinusOne, result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusOneModuloOne()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitMinusOne;
//        var b = new FractionUnit(new Fraction(1, 1), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(TestUtility.FractionUnitZero, result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusOneModuloMore()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitMinusOne;
//        var b = new FractionUnit(new Fraction(24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(-163, 187), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusOneModuloMinusOne()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitMinusOne;
//        var b = TestUtility.FractionUnitMinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(-2, 1), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusOneModuloMinusMore()
//    {
//        // Arrange
//        var a = TestUtility.FractionUnitMinusOne;
//        var b = new FractionUnit(new Fraction(-24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(-211, 187), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MoreModuloZero()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(12, 179), []);
//        var b = TestUtility.FractionUnitZero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(12, 179), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MoreModuloOne()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(12, 179), []);
//        var b = new FractionUnit(new Fraction(1, 1), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(191, 179), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MoreModuloMore()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(12, 179), []);
//        var b = new FractionUnit(new Fraction(24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(6540, 33473), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MoreModuloMinusOne()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(12, 179), []);
//        var b = TestUtility.FractionUnitMinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(-167, 179), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MoreModuloMinusMore()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(12, 179), []);
//        var b = new FractionUnit(new Fraction(-24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(-2052, 33473), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusMoreModuloZero()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(-12, 179), []);
//        var b = TestUtility.FractionUnitZero;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(-12, 179), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusMoreModuloOne()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(-12, 179), []);
//        var b = new FractionUnit(new Fraction(1, 1), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(167, 179), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusMoreModuloMore()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(-12, 179), []);
//        var b = new FractionUnit(new Fraction(24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(2052, 33473), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusMoreModuloMinusOne()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(-12, 179), []);
//        var b = TestUtility.FractionUnitMinusOne;

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(-191, 179), []), result);
//    }

//    [TestMethod]
//    public void FractionUnit_Modulo_MinusMoreModuloMinusMore()
//    {
//        // Arrange
//        var a = new FractionUnit(new Fraction(-12, 179), []);
//        var b = new FractionUnit(new Fraction(-24, 187), []);

//        // Act
//        var result = a % b;

//        // Assert
//        Assert.AreEqual(new FractionUnit(new Fraction(-6540, 33473), []), result);
//    }
//}