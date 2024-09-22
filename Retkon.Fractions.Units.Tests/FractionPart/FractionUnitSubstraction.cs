namespace Retkon.Fractions.Units.Tests.FractionPart;

[TestClass]
public class FractionUnitSubstraction
{
    [TestMethod]
    public void FractionUnit_Substraction_ZeroMinusZero()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_ZeroMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = TestUtility.FractionUnitOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitMinusOne, result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_ZeroMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-24, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_ZeroMinusMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitOne, result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_ZeroMinusMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(24, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_OneMinusZero()
    {
        // Arrange
        var a = TestUtility.FractionUnitOne;
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitOne, result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_OneMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitOne;
        var b = TestUtility.FractionUnitOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_OneMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitOne;
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(163, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_OneMinusMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitOne;
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(2, 1), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_OneMinusMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitOne;
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(211, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusOneMinusZero()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitMinusOne, result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusOneMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = TestUtility.FractionUnitOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-2, 1), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusOneMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-211, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusOneMinusMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusOneMinusMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-163, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MoreMinusZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MoreMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = TestUtility.FractionUnitOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-167, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MoreMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-2052, 33473), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MoreMinusMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(191, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MoreMinusMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(6540, 33473), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusMoreMinusZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusMoreMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = TestUtility.FractionUnitOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-191, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusMoreMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-6540, 33473), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusMoreMinusMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(167, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_MinusMoreMinusMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(2052, 33473), []), result);
    }
}