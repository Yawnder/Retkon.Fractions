namespace Retkon.Fractions.Units.Tests.FractionPart;

[TestClass]
public class FractionUnitMultiplication
{
    [TestMethod]
    public void FractionUnit_Multiplication_ZeroMultipliedByZero()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_ZeroMultipliedByOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_ZeroMultipliedByMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_ZeroMultipliedByMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_ZeroMultipliedByMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_OneMultipliedByZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_OneMultipliedByOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitOne, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_OneMultipliedByMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(24, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_OneMultipliedByMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitMinusOne, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_OneMultipliedByMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-24, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusOneMultipliedByZero()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusOneMultipliedByOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitMinusOne, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusOneMultipliedByMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-24, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusOneMultipliedByMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitOne, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusOneMultipliedByMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(24, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MoreMultipliedByZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MoreMultipliedByOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MoreMultipliedByMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(288, 33473), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MoreMultipliedByMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MoreMultipliedByMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-288, 33473), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusMoreMultipliedByZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusMoreMultipliedByOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusMoreMultipliedByMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-288, 33473), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusMoreMultipliedByMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_MinusMoreMultipliedByMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(288, 33473), []), result);
    }
}