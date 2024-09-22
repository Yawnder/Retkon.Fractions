namespace Retkon.Fractions.Units.Tests.UnitsPart;

[TestClass]
public class FractionUnitDivision
{
    [TestMethod]
    public void FractionUnit_Division_NonePlusNone()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), []);
        var b = new FractionUnit(new Fraction(2, 3), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_NonePlusSome()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), []);
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", 2 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Potato", -2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_NonePlusMinusSome()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), []);
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -2 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Potato", 2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_SomePlusSome()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", 2 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_SomePlusMinusSomePlus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -1 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Potato", 3 } }), result);
    }


    [TestMethod]
    public void FractionUnit_Division_SomePlusMinusSomeZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -2 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Potato", 4 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_SomePlusMinusSomeMinus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -3 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Potato", 5 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_SomePlusNone()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), []);


        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Potato", 2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_SomePlusOther()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", 2 } });


        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Potato", 2 }, { "Tomato", -2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_SomePlusMinusOther()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", -2 } });


        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Potato", 2 }, { "Tomato", 2 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_OtherAndSomePlusMinusSomePlus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -1 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 3 } }), result);
    }


    [TestMethod]
    public void FractionUnit_Division_OtherAndSomePlusMinusSomeZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -2 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 4 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_OtherAndSomePlusMinusSomeMinus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Potato", -3 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 5 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_SomePlusMinusOtherAndSomePlus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", 2 }, { "Potato", -1 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 3 } }), result);
    }


    [TestMethod]
    public void FractionUnit_Division_SomePlusMinusOtherAndSomeZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", 2 }, { "Potato", -2 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 4 } }), result);
    }

    [TestMethod]
    public void FractionUnit_Division_SomePlusMinusOtherAndSomeMinus()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 2), new Dictionary<string, short> { { "Potato", 2 } });
        var b = new FractionUnit(new Fraction(2, 3), new Dictionary<string, short> { { "Tomato", 2 }, { "Potato", -3 } });

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(3, 4), new Dictionary<string, short> { { "Tomato", -2 }, { "Potato", 5 } }), result);
    }
}
