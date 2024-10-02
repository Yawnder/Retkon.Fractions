namespace Retkon.Fractions.Tools.Tests;

[TestClass]
public class FractionUtility_Create_AfterCreateDefaultTransformation
{

    [TestCleanup]
    public void TestCleanup()
    {
        FractionUtility.AfterCreateDefaultTransformation = null;
    }

    [TestMethod]
    public void FractionFactory_Create_AfterCreateDefaultTransformation_NoOps()
    {
        // Arrange
        var expectedResult = new Fraction(41, 10);
        FractionUtility.AfterCreateDefaultTransformation = null;

        // Act
        var result = FractionUtility.Create(4.1f);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Create_AfterCreateDefaultTransformation_One()
    {
        // Arrange
        var expectedResult = Fraction.One;
        FractionUtility.AfterCreateDefaultTransformation = e => Fraction.One;

        // Act
        var result = FractionUtility.Create(4.1f);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Create_AfterCreateDefaultTransformation_Round()
    {
        // Arrange
        var expectedResult = new Fraction(4, 1);
        FractionUtility.AfterCreateDefaultTransformation = e => FractionUtility.Round(e, new Fraction(1, 4));

        // Act
        var result = FractionUtility.Create(4.125f);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void FractionFactory_Create_AfterCreateDefaultTransformation_RoundAway()
    {
        // Arrange
        var expectedResult = new Fraction(17, 4);
        FractionUtility.AfterCreateDefaultTransformation = e => FractionUtility.Round(e, new Fraction(1, 4), MidpointRounding.AwayFromZero);

        // Act
        var result = FractionUtility.Create(4.125f);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }
}