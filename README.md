# Retkon.Fractions

Build Status: [![Test](https://github.com/Yawnder/Retkon.Fractions/actions/workflows/build-test.yml/badge.svg)](https://github.com/Yawnder/Retkon.Fractions/actions/workflows/build-test.yml)

## Retkon.Fractions.Core
The base for this library, containing the basic Fraction class.

### Usage
```cs
var fraction1 = new Fraction(34, 11);
var fraction2 = new Fraction(17, 16);
var result = fraction1 * fraction2;
Console.WriteLine(result);	// 578 / 176
```

### Supported operations
* Addition / Substraction
* Multiplication / Division

## Retkon.Fractions.Units
Adds the FractionUnit class, which enables handling units.

### Usage
```cs
var fraction1 = new FractionUnit(34, 11, new Dictionary<string, short> { { "Km", 1 }, { "s", -1 } });
var fraction2 = new FractionUnit(17, 16, new Dictionary<string, short> { { "s", 1 } });
var result = fraction1 * fraction2;
Console.WriteLine(result);	// { 578 / 176, Units: Km }
```

### Supported operations and features
* Addition / Substraction: Require the same units
* Multiplication / Division: Handle and simplifies units.
* Generic Unit handling (`new FractionUnit<MyUnit>(..., new Dictionary<MyUnit, short>(...))`).

Note: As a suggestion, in many cases the Units would simply be a `string`, so this could be added to the csproj:
```xml
  <ItemGroup>
    <Using Include="Retkon.Fractions.Units.FractionUnit&lt;string&gt;" Alias="FractionUnit" />
  </ItemGroup>
```

## Retkon.Fractions.Tools
Adds utilities (well, just one for now...) to using the Fraction and FractionUnit classes.

### Usage
```cs
var fraction = FractionUtility.Create(0.1484354748);
Console.WriteLine(fraction);	// { 742177 / 5000000 }
```

```cs
var fraction = FractionUnitFactory.Create(0.1484354748, new Dictionary<string, short> { { "s", 1 } });
Console.WriteLine(fraction);	// { 742177 / 5000000, Units: s }
```