namespace Retkon.Fractions.Tools.Tests;

[TestClass]
public class FractionUtility_Ceiling
{
    [TestMethod]
    public void FractionFactory_Ceiling_Zero()
    {
        // Arrange

        // Act
        try
        {
            var result = FractionUtility.Ceiling(Fraction.One, Fraction.Zero);
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (ArgumentException) { }
    }

    [TestMethod]
    public void FractionFactory_Ceiling_One_One()
    {
        // Arrange
        var expectedResult = Fraction.One;

        // Act
        var result = FractionUtility.Ceiling(Fraction.One, Fraction.One);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_Two_One()
    {
        // Arrange
        var expectedResult = new Fraction(2, 1);

        // Act
        var result = FractionUtility.Ceiling(new Fraction(2, 1), Fraction.One);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_TwoFive_One()
    {
        // Arrange
        var expectedResult = new Fraction(3, 1);

        // Act
        var result = FractionUtility.Ceiling(new Fraction(5, 2), Fraction.One);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_MinusTwoFive_One()
    {
        // Arrange
        var expectedResult = new Fraction(-2, 1);

        // Act
        var result = FractionUtility.Ceiling(new Fraction(-5, 2), Fraction.One);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_PointTwoFive_One()
    {
        // Arrange
        var expectedResult = Fraction.One;

        // Act
        var result = FractionUtility.Ceiling(new Fraction(1, 4), Fraction.One);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_MinusPointTwoFive_One()
    {
        // Arrange
        var expectedResult = Fraction.Zero;

        // Act
        var result = FractionUtility.Ceiling(new Fraction(-1, 4), Fraction.One);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_One_ThreeEleventh()
    {
        // Arrange
        var expectedResult = new Fraction(12, 11);

        // Act
        var result = FractionUtility.Ceiling(Fraction.One, new Fraction(3, 11));

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_Two_ThreeEleventh()
    {
        // Arrange
        var expectedResult = new Fraction(24, 11);

        // Act
        var result = FractionUtility.Ceiling(new Fraction(2, 1), new Fraction(3, 11));

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_TwoFive_ThreeEleventh()
    {
        // Arrange
        var expectedResult = new Fraction(30, 11);

        // Act
        var result = FractionUtility.Ceiling(new Fraction(5, 2), new Fraction(3, 11));

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_MinusTwoFive_ThreeEleventh()
    {
        // Arrange
        var expectedResult = new Fraction(-27, 11);

        // Act
        var result = FractionUtility.Ceiling(new Fraction(-5, 2), new Fraction(3, 11));

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_PointTwoFive_ThreeEleventh()
    {
        // Arrange
        var expectedResult = new Fraction(3, 11);

        // Act
        var result = FractionUtility.Ceiling(new Fraction(1, 4), new Fraction(3, 11));

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Ceiling_MinusPointTwoFive_ThreeEleventh()
    {
        // Arrange
        var expectedResult = Fraction.Zero;

        // Act
        var result = FractionUtility.Ceiling(new Fraction(-1, 4), new Fraction(3, 11));

        // Assert
        Assert.AreEqual(expectedResult, result);
    }
}
