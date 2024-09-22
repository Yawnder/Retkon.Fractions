namespace Retkon.Fractions.Units.Tests.UnitsPart;

[TestClass]
public class FractionUnitSubstraction
{
    [TestMethod]
    public void FractionUnit_Substraction_NonePlusNone()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), []);
        var b = new FractionUnit(new Fraction(2, 3), []);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-1, 6), []), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_NonePlusSome()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), []);
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", 2 } });

        // Act
        try
        {
            var result = a - b;
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (InvalidOperationException) { };
    }

    [TestMethod]
    public void FractionUnit_Substraction_SomePlusSome()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", 2 } });

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-1, 6), new Dictionary<string, short> { { "Potato", 2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Substraction_SomePlusNone()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), []);

        // Act
        try
        {
            var result = a - b;
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (InvalidOperationException) { };
    }

    [TestMethod]
    public void FractionUnit_Substraction_SomePlusOther()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", 2 } });

        // Act
        try
        {
            var result = a - b;
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (InvalidOperationException) { };
    }
}
