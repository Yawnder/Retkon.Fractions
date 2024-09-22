namespace Retkon.Fractions.Units.Tests.UnitsPart;

[TestClass]
public class FractionUnitMultiplication
{
    [TestMethod]
    public void FractionUnit_Multiplication_NonePlusNone()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), []);
        var b = new FractionUnit(new Fraction(2, 3), []);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_NonePlusSome()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), []);
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", 2 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Potato", 2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_NonePlusMinusSome()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), []);
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -2 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Potato", -2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusSome()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", 2 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Potato", 4 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusMinusSomePlus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -1 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Potato", 1 } }), result);
    }


    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusMinusSomeZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -2 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), []), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusMinusSomeMinus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -3 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Potato", -1 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusNone()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), []);


        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Potato", 2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusOther()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", 2 } });


        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Potato", 2 }, { "Tomato", 2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusMinusOther()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", -2 } });


        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Potato", 2 }, { "Tomato", -2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_OtherAndSomePlusMinusSomePlus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -1 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 1 } }), result);
    }


    [TestMethod]
    public void FractionUnit_Multiplication_OtherAndSomePlusMinusSomeZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -2 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Tomato", -2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_OtherAndSomePlusMinusSomeMinus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -3 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", -1 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusMinusOtherAndSomePlus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", 2 }, { "Potato", -1 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Tomato", 2 }, { "Potato", 1 } }), result);
    }


    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusMinusOtherAndSomeZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", 2 }, { "Potato", -2 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Tomato", 2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Multiplication_SomePlusMinusOtherAndSomeMinus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", 2 }, { "Potato", -3 } });

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(1, 3), new Dictionary<string, short> { { "Tomato", 2 }, { "Potato", -1 } }), result);
    }
}
