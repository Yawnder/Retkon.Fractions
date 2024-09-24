namespace Retkon.Fractions.Tools.Tests;
[TestClass]
public class FractionUtility_SameBase
{
    [TestMethod]
    public void FractionUtility_SameBase_NoValues()
    {
        // Arrange
        var expectedResult = new List<Fraction>();

        // Act
        var result = FractionUtility.SameBase();

        // Assert
        Assert.IsTrue(Enumerable.SequenceEqual(expectedResult, result));
    }

    [TestMethod]
    public void FractionUtility_SameBase_OneValue()
    {
        // Arrange
        var expectedResult = new List<Fraction> { new Fraction(1, 18) };

        // Act
        var result = FractionUtility.SameBase(new Fraction(1, 18));

        // Assert
        Assert.IsTrue(Enumerable.SequenceEqual(expectedResult, result));
    }

    [TestMethod]
    public void FractionUtility_SameBase_OneValue_ToReduce()
    {
        // Arrange
        var expectedResult = new List<Fraction> { new Fraction(1, 9) };

        // Act
        var result = FractionUtility.SameBase(new Fraction(2, 18));

        // Assert
        Assert.IsTrue(Enumerable.SequenceEqual(expectedResult, result));
    }

    [TestMethod]
    public void FractionUtility_SameBase_OneValueMultipleTimes()
    {
        // Arrange
        var expectedResult = new List<Fraction> { new Fraction(1, 18), new Fraction(1, 18) };

        // Act
        var result = FractionUtility.SameBase(new Fraction(1, 18), new Fraction(1, 18));

        // Assert
        Assert.IsTrue(Enumerable.SequenceEqual(expectedResult, result));
    }

    [TestMethod]
    public void FractionUtility_SameBase_OneValueMultipleTimes_ToReduceAll()
    {
        // Arrange
        var expectedResult = new List<Fraction> { new Fraction(1, 9), new Fraction(1, 9) };

        // Act
        var result = FractionUtility.SameBase(new Fraction(2, 18), new Fraction(2, 18));

        // Assert
        Assert.IsTrue(Enumerable.SequenceEqual(expectedResult, result));
    }

    [TestMethod]
    public void FractionUtility_SameBase_OneValueMultipleTimes_ToReduceSome()
    {
        // Arrange
        var expectedResult = new List<Fraction> { new Fraction(1, 9), new Fraction(1, 9) };

        // Act
        var result = FractionUtility.SameBase(new Fraction(2, 18), new Fraction(1, 9));

        // Assert
        Assert.IsTrue(Enumerable.SequenceEqual(expectedResult, result));
    }

    [TestMethod]
    public void FractionUtility_SameBase_OneValueMultipleTimesAndDifferent()
    {
        // Arrange
        var expectedResult = new List<Fraction> { new Fraction(5, 90, false), new Fraction(5, 90, false), new Fraction(-54, 90, false) };

        // Act
        var result = FractionUtility.SameBase(new Fraction(1, 18), new Fraction(1, 18), new Fraction(-3, 5));

        // Assert
        Assert.IsTrue(Enumerable.SequenceEqual(expectedResult, result));
    }

    [TestMethod]
    public void FractionUtility_SameBase_OneValueMultipleTimesAndDifferent_OneToReduce()
    {
        // Arrange
        var expectedResult = new List<Fraction> { new Fraction(5, 90, false), new Fraction(5, 90, false), new Fraction(-54, 90, false) };

        // Act
        var result = FractionUtility.SameBase(new Fraction(2, 36), new Fraction(1, 18), new Fraction(-3, 5));

        // Assert
        Assert.IsTrue(Enumerable.SequenceEqual(expectedResult, result));
    }

    [TestMethod]
    public void FractionUtility_SameBase_OneValueMultipleTimesAndDifferent_ManyToReduce()
    {
        // Arrange
        var expectedResult = new List<Fraction> { new Fraction(5, 90, false), new Fraction(5, 90, false), new Fraction(-54, 90, false) };

        // Act
        var result = FractionUtility.SameBase(new Fraction(2, 36), new Fraction(1, 18), new Fraction(-9, 15));

        // Assert
        Assert.IsTrue(Enumerable.SequenceEqual(expectedResult, result));
    }
}
