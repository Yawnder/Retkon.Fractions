using Retkon.Fractions;
using Retkon.Fractions.Tools;
using Retkon.Fractions.Units;

namespace Retkon.Fractions.Tools.Tests;

[TestClass]
public class FractionUnitFactoryTest
{
    private const float tolerance = 0.000_000_01f;

    [TestMethod]
    public void FractionUnitFactory_Create_TooSmall_Positive()
    {
        // Arrange

        // Act
        try
        {
            var result = FractionUnitFactory.Create((float)0.000_0004 / (float)8_347_577_871_347_577_871, new Dictionary<string, short> { { "Tomato", 2 } });
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (ArgumentOutOfRangeException) { }
    }

    [TestMethod]
    public void FractionUnitFactory_Create_TooSmall_Negative()
    {
        // Arrange

        // Act
        try
        {
            var result = FractionUnitFactory.Create((float)-0.000_0004 / (float)8_347_577_871_347_577_871, new Dictionary<string, short> { { "Tomato", 2 } });
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (ArgumentOutOfRangeException) { }
    }

    [TestMethod]
    public void FractionUnitFactory_Create_ExtremelySmall_Positive()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(34, 8_347_577_871_347_577_871), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)34 / (float)8_347_577_871_347_577_871, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_ExtremelySmall_Negative()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(-34, 8_347_577_871_347_577_871), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)-34 / (float)8_347_577_871_347_577_871, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_VerySmall_Positive()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(34, 871_347_577), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)34 / (float)871_347_577, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_VerySmall_Negative()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(-34, 871_347_577), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)-34 / (float)871_347_577, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_Small_Positive()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(34, 871), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)34 / (float)871, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_Small_Negative()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(-34, 871), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)-34 / (float)871, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_Zero()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(0, 1), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)0, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_Large_Positive()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(871_347_577, 34), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)871_347_577 / (float)34, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_Large_Negative()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(-871_347_577, 34), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)-871_347_577 / (float)34, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_VeryLarge_Positive()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(871_347_577_643_342, 33), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)871_347_577_643_342 / (float)33, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_VeryLarge_Negative()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(-871_347_577_643_342, 33), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)-871_347_577_643_342 / (float)33, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_ExtremelyLarge_Positive()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(8_347_577_871_347_577_871, 33), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)8_347_577_871_347_577_871 / (float)33, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_ExtremelyLarge_Negative()
    {
        // Arrange
        var expectedResult = new FractionUnit(new Fraction(-8_347_577_871_347_577_871, 33), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        var result = FractionUnitFactory.Create((float)-8_347_577_871_347_577_871 / (float)33, new Dictionary<string, short> { { "Tomato", 2 } });

        // Assert
        Assert.AreEqual((float)expectedResult, (float)result, tolerance);
    }

    [TestMethod]
    public void FractionUnitFactory_Create_TooLarge_Positive()
    {
        // Arrange

        // Act
        try
        {
            var result = FractionUnitFactory.Create((float)8_347_577_871_347_577_871 / (float)0.000_000_000_000_000_4, new Dictionary<string, short> { { "Tomato", 2 } });
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (ArgumentOutOfRangeException) { }
    }

    [TestMethod]
    public void FractionUnitFactory_Create_TooLarge_Negative()
    {
        // Arrange

        // Act
        try
        {
            var result = FractionUnitFactory.Create((float)-8_347_577_871_347_577_871 / (float)0.000_0004, new Dictionary<string, short> { { "Tomato", 2 } });
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (ArgumentOutOfRangeException) { }
    }
}