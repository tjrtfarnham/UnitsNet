//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of MagneticFlux.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MagneticFluxTestsBase : QuantityTestsBase
    {
        protected abstract double WebersInOneWeber { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double WebersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(MagneticFluxUnit unit)
        {
            return unit switch
            {
                MagneticFluxUnit.Weber => (WebersInOneWeber, WebersTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { MagneticFluxUnit.Weber },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new MagneticFlux();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MagneticFluxUnit.Weber, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MagneticFlux(double.PositiveInfinity, MagneticFluxUnit.Weber));
            Assert.Throws<ArgumentException>(() => new MagneticFlux(double.NegativeInfinity, MagneticFluxUnit.Weber));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MagneticFlux(double.NaN, MagneticFluxUnit.Weber));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MagneticFlux(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new MagneticFlux(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (MagneticFlux) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void MagneticFlux_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new MagneticFlux(1, MagneticFluxUnit.Weber);

            QuantityInfo<MagneticFluxUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(MagneticFlux.Zero, quantityInfo.Zero);
            Assert.Equal("MagneticFlux", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<MagneticFluxUnit>().ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void WeberToMagneticFluxUnits()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            AssertEx.EqualTolerance(WebersInOneWeber, weber.Webers, WebersTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = MagneticFlux.From(1, MagneticFluxUnit.Weber);
            AssertEx.EqualTolerance(1, quantity00.Webers, WebersTolerance);
            Assert.Equal(MagneticFluxUnit.Weber, quantity00.Unit);

        }

        [Fact]
        public void FromWebers_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MagneticFlux.FromWebers(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => MagneticFlux.FromWebers(double.NegativeInfinity));
        }

        [Fact]
        public void FromWebers_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MagneticFlux.FromWebers(double.NaN));
        }

        [Fact]
        public void As()
        {
            var weber = MagneticFlux.FromWebers(1);
            AssertEx.EqualTolerance(WebersInOneWeber, weber.As(MagneticFluxUnit.Weber), WebersTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new MagneticFlux(value: 1, unit: MagneticFlux.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = MagneticFlux.Parse("1 Wb", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Webers, WebersTolerance);
                Assert.Equal(MagneticFluxUnit.Weber, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(MagneticFlux.TryParse("1 Wb", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Webers, WebersTolerance);
                Assert.Equal(MagneticFluxUnit.Weber, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = MagneticFlux.ParseUnit("Wb", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(MagneticFluxUnit.Weber, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(MagneticFlux.TryParseUnit("Wb", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(MagneticFluxUnit.Weber, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(MagneticFluxUnit unit)
        {
            var inBaseUnits = MagneticFlux.From(1.0, MagneticFlux.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, (double)converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(MagneticFluxUnit unit)
        {
            var quantity = MagneticFlux.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(MagneticFluxUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = MagneticFlux.Units.Where(u => u != MagneticFlux.BaseUnit).DefaultIfEmpty(MagneticFlux.BaseUnit).First();

            var quantity = MagneticFlux.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            AssertEx.EqualTolerance(1, MagneticFlux.FromWebers(weber.Webers).Webers, WebersTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MagneticFlux v = MagneticFlux.FromWebers(1);
            AssertEx.EqualTolerance(-1, -v.Webers, WebersTolerance);
            AssertEx.EqualTolerance(2, (MagneticFlux.FromWebers(3)-v).Webers, WebersTolerance);
            AssertEx.EqualTolerance(2, (v + v).Webers, WebersTolerance);
            AssertEx.EqualTolerance(10, (v*10).Webers, WebersTolerance);
            AssertEx.EqualTolerance(10, (10*v).Webers, WebersTolerance);
            AssertEx.EqualTolerance(2, (MagneticFlux.FromWebers(10)/5).Webers, WebersTolerance);
            AssertEx.EqualTolerance(2, MagneticFlux.FromWebers(10)/MagneticFlux.FromWebers(5), WebersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MagneticFlux oneWeber = MagneticFlux.FromWebers(1);
            MagneticFlux twoWebers = MagneticFlux.FromWebers(2);

            Assert.True(oneWeber < twoWebers);
            Assert.True(oneWeber <= twoWebers);
            Assert.True(twoWebers > oneWeber);
            Assert.True(twoWebers >= oneWeber);

            Assert.False(oneWeber > twoWebers);
            Assert.False(oneWeber >= twoWebers);
            Assert.False(twoWebers < oneWeber);
            Assert.False(twoWebers <= oneWeber);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.Equal(0, weber.CompareTo(weber));
            Assert.True(weber.CompareTo(MagneticFlux.Zero) > 0);
            Assert.True(MagneticFlux.Zero.CompareTo(weber) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.Throws<ArgumentException>(() => weber.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.Throws<ArgumentNullException>(() => weber.CompareTo(null));
        }

        [Theory]
        [InlineData(1, MagneticFluxUnit.Weber, 1, MagneticFluxUnit.Weber, true)]  // Same value and unit.
        [InlineData(1, MagneticFluxUnit.Weber, 2, MagneticFluxUnit.Weber, false)] // Different value.
        [InlineData(2, MagneticFluxUnit.Weber, 1, MagneticFluxUnit.Weber, false)] // Different value and unit.
        public void Equality_MatchesOnValueAndUnit(double valueA, MagneticFluxUnit unitA, double valueB, MagneticFluxUnit unitB, bool expectEqual)
        {
            var a = new MagneticFlux(valueA, unitA);
            var b = new MagneticFlux(valueB, unitB);

            // Operator overloads.
            Assert.Equal(a == b, expectEqual);
            Assert.Equal(b == a, expectEqual);
            Assert.Equal(a != b, !expectEqual);
            Assert.Equal(b != a, !expectEqual);

            // IEquatable<T>
            Assert.Equal(a.Equals(b), expectEqual);
            Assert.Equal(b.Equals(a), expectEqual);

            // IEquatable
            Assert.Equal(a.Equals((object)b), expectEqual);
            Assert.Equal(b.Equals((object)a), expectEqual);
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = MagneticFlux.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = MagneticFlux.FromWebers(1);
            Assert.True(v.Equals(MagneticFlux.FromWebers(1), WebersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MagneticFlux.Zero, WebersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = MagneticFlux.FromWebers(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(MagneticFlux.FromWebers(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.False(weber.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.False(weber.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MagneticFluxUnit)).Cast<MagneticFluxUnit>();
            foreach(var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MagneticFlux.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 Wb", new MagneticFlux(1, MagneticFluxUnit.Weber).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 Wb", new MagneticFlux(1, MagneticFluxUnit.Weber).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s1"));
                Assert.Equal("0.12 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s2"));
                Assert.Equal("0.123 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s3"));
                Assert.Equal("0.1235 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s1", culture));
            Assert.Equal("0.12 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s2", culture));
            Assert.Equal("0.123 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s3", culture));
            Assert.Equal("0.1235 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(MagneticFlux)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(MagneticFluxUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(MagneticFlux.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(MagneticFlux.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(new {MagneticFlux.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = MagneticFlux.FromWebers(value);
            Assert.Equal(MagneticFlux.FromWebers(-value), -quantity);
        }
    }
}
