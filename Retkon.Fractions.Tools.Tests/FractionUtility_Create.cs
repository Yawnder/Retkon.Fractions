namespace Retkon.Fractions.Tools.Tests;

[TestClass]
public class FractionUtility_Create
{
    private const decimal tolerance = 0.000_000_01M;

    [TestMethod]
    public void FractionFactory_Create_TooSmall_Positive()
    {
        // Arrange

        // Act
        try
        {
            var result = FractionUtility.Create((decimal)0.000_0004 / (decimal)8_347_577_871_347_577_871);
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (ArgumentOutOfRangeException) { }
    }

    [TestMethod]
    public void FractionFactory_Create_TooSmall_Negative()
    {
        // Arrange

        // Act
        try
        {
            var result = FractionUtility.Create((decimal)-0.000_0004 / (decimal)8_347_577_871_347_577_871);
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (ArgumentOutOfRangeException) { }
    }

    [TestMethod]
    public void FractionFactory_Create_ExtremelySmall_Positive()
    {
        // Arrange
        var expectedResult = new Fraction(34, 8_347_577_871_347_577_871);

        // Act
        var result = FractionUtility.Create((decimal)34 / (decimal)8_347_577_871_347_577_871);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_ExtremelySmall_Negative()
    {
        // Arrange
        var expectedResult = new Fraction(-34, 8_347_577_871_347_577_871);

        // Act
        var result = FractionUtility.Create((decimal)-34 / (decimal)8_347_577_871_347_577_871);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_VerySmall_Positive()
    {
        // Arrange
        var expectedResult = new Fraction(34, 871_347_577);

        // Act
        var result = FractionUtility.Create((decimal)34 / (decimal)871_347_577);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_VerySmall_Negative()
    {
        // Arrange
        var expectedResult = new Fraction(-34, 871_347_577);

        // Act
        var result = FractionUtility.Create((decimal)-34 / (decimal)871_347_577);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_Small_Positive()
    {
        // Arrange
        var expectedResult = new Fraction(34, 871);

        // Act
        var result = FractionUtility.Create((decimal)34 / (decimal)871);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_Small_Negative()
    {
        // Arrange
        var expectedResult = new Fraction(-34, 871);

        // Act
        var result = FractionUtility.Create((decimal)-34 / (decimal)871);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_Zero()
    {
        // Arrange
        var expectedResult = new Fraction(0, 1);

        // Act
        var result = FractionUtility.Create((decimal)0);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_Large_Positive()
    {
        // Arrange
        var expectedResult = new Fraction(871_347_577, 34);

        // Act
        var result = FractionUtility.Create((decimal)871_347_577 / (decimal)34);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_Large_Negative()
    {
        // Arrange
        var expectedResult = new Fraction(-871_347_577, 34);

        // Act
        var result = FractionUtility.Create((decimal)-871_347_577 / (decimal)34);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_VeryLarge_Positive()
    {
        // Arrange
        var expectedResult = new Fraction(871_347_577_643_342, 33);

        // Act
        var result = FractionUtility.Create((decimal)871_347_577_643_342 / (decimal)33);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_VeryLarge_Negative()
    {
        // Arrange
        var expectedResult = new Fraction(-871_347_577_643_342, 33);

        // Act
        var result = FractionUtility.Create((decimal)-871_347_577_643_342 / (decimal)33);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_ExtremelyLarge_Positive()
    {
        // Arrange
        var expectedResult = new Fraction(8_347_577_871_347_577_871, 33);

        // Act
        var result = FractionUtility.Create((decimal)8_347_577_871_347_577_871 / (decimal)33);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_ExtremelyLarge_Negative()
    {
        // Arrange
        var expectedResult = new Fraction(-8_347_577_871_347_577_871, 33);

        // Act
        var result = FractionUtility.Create((decimal)-8_347_577_871_347_577_871 / (decimal)33);

        // Assert
        Assert.AreEqual((decimal)expectedResult, (decimal)result, tolerance);
    }

    [TestMethod]
    public void FractionFactory_Create_TooLarge_Positive()
    {
        // Arrange

        // Act
        try
        {
            var result = FractionUtility.Create((decimal)577_871_347_577_871 / (decimal)0.000_000_000_000_4);
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (ArgumentOutOfRangeException) { }
    }

    [TestMethod]
    public void FractionFactory_Create_TooLarge_Negative()
    {
        // Arrange

        // Act
        try
        {
            var result = FractionUtility.Create((decimal)-8_347_577_871_347_577_871 / (decimal)0.000_0004);
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (ArgumentOutOfRangeException) { }
    }
}