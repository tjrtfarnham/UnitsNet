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
    /// Test of ElectricPotentialDc.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricPotentialDcTestsBase : QuantityTestsBase
    {
        protected abstract double KilovoltsDcInOneVoltDc { get; }
        protected abstract double MegavoltsDcInOneVoltDc { get; }
        protected abstract double MicrovoltsDcInOneVoltDc { get; }
        protected abstract double MillivoltsDcInOneVoltDc { get; }
        protected abstract double VoltsDcInOneVoltDc { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltsDcTolerance { get { return 1e-5; } }
        protected virtual double MegavoltsDcTolerance { get { return 1e-5; } }
        protected virtual double MicrovoltsDcTolerance { get { return 1e-5; } }
        protected virtual double MillivoltsDcTolerance { get { return 1e-5; } }
        protected virtual double VoltsDcTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricPotentialDcUnit unit)
        {
            return unit switch
            {
                ElectricPotentialDcUnit.KilovoltDc => (KilovoltsDcInOneVoltDc, KilovoltsDcTolerance),
                ElectricPotentialDcUnit.MegavoltDc => (MegavoltsDcInOneVoltDc, MegavoltsDcTolerance),
                ElectricPotentialDcUnit.MicrovoltDc => (MicrovoltsDcInOneVoltDc, MicrovoltsDcTolerance),
                ElectricPotentialDcUnit.MillivoltDc => (MillivoltsDcInOneVoltDc, MillivoltsDcTolerance),
                ElectricPotentialDcUnit.VoltDc => (VoltsDcInOneVoltDc, VoltsDcTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricPotentialDcUnit.KilovoltDc },
            new object[] { ElectricPotentialDcUnit.MegavoltDc },
            new object[] { ElectricPotentialDcUnit.MicrovoltDc },
            new object[] { ElectricPotentialDcUnit.MillivoltDc },
            new object[] { ElectricPotentialDcUnit.VoltDc },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricPotentialDc();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricPotentialDcUnit.VoltDc, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricPotentialDc(double.PositiveInfinity, ElectricPotentialDcUnit.VoltDc));
            Assert.Throws<ArgumentException>(() => new ElectricPotentialDc(double.NegativeInfinity, ElectricPotentialDcUnit.VoltDc));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricPotentialDc(double.NaN, ElectricPotentialDcUnit.VoltDc));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricPotentialDc(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricPotentialDc(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricPotentialDc) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricPotentialDc_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricPotentialDc(1, ElectricPotentialDcUnit.VoltDc);

            QuantityInfo<ElectricPotentialDcUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricPotentialDc.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricPotentialDc", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricPotentialDcUnit>().ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void VoltDcToElectricPotentialDcUnits()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            AssertEx.EqualTolerance(KilovoltsDcInOneVoltDc, voltdc.KilovoltsDc, KilovoltsDcTolerance);
            AssertEx.EqualTolerance(MegavoltsDcInOneVoltDc, voltdc.MegavoltsDc, MegavoltsDcTolerance);
            AssertEx.EqualTolerance(MicrovoltsDcInOneVoltDc, voltdc.MicrovoltsDc, MicrovoltsDcTolerance);
            AssertEx.EqualTolerance(MillivoltsDcInOneVoltDc, voltdc.MillivoltsDc, MillivoltsDcTolerance);
            AssertEx.EqualTolerance(VoltsDcInOneVoltDc, voltdc.VoltsDc, VoltsDcTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricPotentialDc.From(1, ElectricPotentialDcUnit.KilovoltDc);
            AssertEx.EqualTolerance(1, quantity00.KilovoltsDc, KilovoltsDcTolerance);
            Assert.Equal(ElectricPotentialDcUnit.KilovoltDc, quantity00.Unit);

            var quantity01 = ElectricPotentialDc.From(1, ElectricPotentialDcUnit.MegavoltDc);
            AssertEx.EqualTolerance(1, quantity01.MegavoltsDc, MegavoltsDcTolerance);
            Assert.Equal(ElectricPotentialDcUnit.MegavoltDc, quantity01.Unit);

            var quantity02 = ElectricPotentialDc.From(1, ElectricPotentialDcUnit.MicrovoltDc);
            AssertEx.EqualTolerance(1, quantity02.MicrovoltsDc, MicrovoltsDcTolerance);
            Assert.Equal(ElectricPotentialDcUnit.MicrovoltDc, quantity02.Unit);

            var quantity03 = ElectricPotentialDc.From(1, ElectricPotentialDcUnit.MillivoltDc);
            AssertEx.EqualTolerance(1, quantity03.MillivoltsDc, MillivoltsDcTolerance);
            Assert.Equal(ElectricPotentialDcUnit.MillivoltDc, quantity03.Unit);

            var quantity04 = ElectricPotentialDc.From(1, ElectricPotentialDcUnit.VoltDc);
            AssertEx.EqualTolerance(1, quantity04.VoltsDc, VoltsDcTolerance);
            Assert.Equal(ElectricPotentialDcUnit.VoltDc, quantity04.Unit);

        }

        [Fact]
        public void FromVoltsDc_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricPotentialDc.FromVoltsDc(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricPotentialDc.FromVoltsDc(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltsDc_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricPotentialDc.FromVoltsDc(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltdc = ElectricPotentialDc.FromVoltsDc(1);
            AssertEx.EqualTolerance(KilovoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.KilovoltDc), KilovoltsDcTolerance);
            AssertEx.EqualTolerance(MegavoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.MegavoltDc), MegavoltsDcTolerance);
            AssertEx.EqualTolerance(MicrovoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.MicrovoltDc), MicrovoltsDcTolerance);
            AssertEx.EqualTolerance(MillivoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.MillivoltDc), MillivoltsDcTolerance);
            AssertEx.EqualTolerance(VoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.VoltDc), VoltsDcTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricPotentialDc(value: 1, unit: ElectricPotentialDc.BaseUnit);
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
                var parsed = ElectricPotentialDc.Parse("1 kVdc", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilovoltsDc, KilovoltsDcTolerance);
                Assert.Equal(ElectricPotentialDcUnit.KilovoltDc, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricPotentialDc.Parse("1 MVdc", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.MegavoltsDc, MegavoltsDcTolerance);
                Assert.Equal(ElectricPotentialDcUnit.MegavoltDc, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricPotentialDc.Parse("1 µVdc", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.MicrovoltsDc, MicrovoltsDcTolerance);
                Assert.Equal(ElectricPotentialDcUnit.MicrovoltDc, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricPotentialDc.Parse("1 mVdc", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.MillivoltsDc, MillivoltsDcTolerance);
                Assert.Equal(ElectricPotentialDcUnit.MillivoltDc, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricPotentialDc.Parse("1 Vdc", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.VoltsDc, VoltsDcTolerance);
                Assert.Equal(ElectricPotentialDcUnit.VoltDc, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ElectricPotentialDc.TryParse("1 kVdc", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilovoltsDc, KilovoltsDcTolerance);
                Assert.Equal(ElectricPotentialDcUnit.KilovoltDc, parsed.Unit);
            }

            {
                Assert.True(ElectricPotentialDc.TryParse("1 µVdc", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.MicrovoltsDc, MicrovoltsDcTolerance);
                Assert.Equal(ElectricPotentialDcUnit.MicrovoltDc, parsed.Unit);
            }

            {
                Assert.True(ElectricPotentialDc.TryParse("1 Vdc", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.VoltsDc, VoltsDcTolerance);
                Assert.Equal(ElectricPotentialDcUnit.VoltDc, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ElectricPotentialDc.ParseUnit("kVdc", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricPotentialDcUnit.KilovoltDc, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricPotentialDc.ParseUnit("MVdc", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricPotentialDcUnit.MegavoltDc, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricPotentialDc.ParseUnit("µVdc", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricPotentialDcUnit.MicrovoltDc, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricPotentialDc.ParseUnit("mVdc", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricPotentialDcUnit.MillivoltDc, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricPotentialDc.ParseUnit("Vdc", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricPotentialDcUnit.VoltDc, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ElectricPotentialDc.TryParseUnit("kVdc", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricPotentialDcUnit.KilovoltDc, parsedUnit);
            }

            {
                Assert.True(ElectricPotentialDc.TryParseUnit("µVdc", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricPotentialDcUnit.MicrovoltDc, parsedUnit);
            }

            {
                Assert.True(ElectricPotentialDc.TryParseUnit("Vdc", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricPotentialDcUnit.VoltDc, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ElectricPotentialDcUnit unit)
        {
            var inBaseUnits = ElectricPotentialDc.From(1.0, ElectricPotentialDc.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, (double)converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricPotentialDcUnit unit)
        {
            var quantity = ElectricPotentialDc.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricPotentialDcUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ElectricPotentialDc.Units.Where(u => u != ElectricPotentialDc.BaseUnit).DefaultIfEmpty(ElectricPotentialDc.BaseUnit).First();

            var quantity = ElectricPotentialDc.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromKilovoltsDc(voltdc.KilovoltsDc).VoltsDc, KilovoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromMegavoltsDc(voltdc.MegavoltsDc).VoltsDc, MegavoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromMicrovoltsDc(voltdc.MicrovoltsDc).VoltsDc, MicrovoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromMillivoltsDc(voltdc.MillivoltsDc).VoltsDc, MillivoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromVoltsDc(voltdc.VoltsDc).VoltsDc, VoltsDcTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricPotentialDc v = ElectricPotentialDc.FromVoltsDc(1);
            AssertEx.EqualTolerance(-1, -v.VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotentialDc.FromVoltsDc(3)-v).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotentialDc.FromVoltsDc(10)/5).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(2, ElectricPotentialDc.FromVoltsDc(10)/ElectricPotentialDc.FromVoltsDc(5), VoltsDcTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricPotentialDc oneVoltDc = ElectricPotentialDc.FromVoltsDc(1);
            ElectricPotentialDc twoVoltsDc = ElectricPotentialDc.FromVoltsDc(2);

            Assert.True(oneVoltDc < twoVoltsDc);
            Assert.True(oneVoltDc <= twoVoltsDc);
            Assert.True(twoVoltsDc > oneVoltDc);
            Assert.True(twoVoltsDc >= oneVoltDc);

            Assert.False(oneVoltDc > twoVoltsDc);
            Assert.False(oneVoltDc >= twoVoltsDc);
            Assert.False(twoVoltsDc < oneVoltDc);
            Assert.False(twoVoltsDc <= oneVoltDc);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.Equal(0, voltdc.CompareTo(voltdc));
            Assert.True(voltdc.CompareTo(ElectricPotentialDc.Zero) > 0);
            Assert.True(ElectricPotentialDc.Zero.CompareTo(voltdc) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.Throws<ArgumentException>(() => voltdc.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.Throws<ArgumentNullException>(() => voltdc.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ElectricPotentialDcUnit.VoltDc, 1, ElectricPotentialDcUnit.VoltDc, true)]  // Same value and unit.
        [InlineData(1, ElectricPotentialDcUnit.VoltDc, 2, ElectricPotentialDcUnit.VoltDc, false)] // Different value.
        [InlineData(2, ElectricPotentialDcUnit.VoltDc, 1, ElectricPotentialDcUnit.KilovoltDc, false)] // Different value and unit.
        [InlineData(1, ElectricPotentialDcUnit.VoltDc, 1, ElectricPotentialDcUnit.KilovoltDc, false)] // Different unit.
        public void Equality_MatchesOnValueAndUnit(double valueA, ElectricPotentialDcUnit unitA, double valueB, ElectricPotentialDcUnit unitB, bool expectEqual)
        {
            var a = new ElectricPotentialDc(valueA, unitA);
            var b = new ElectricPotentialDc(valueB, unitB);

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
            var a = ElectricPotentialDc.Zero;

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
            var v = ElectricPotentialDc.FromVoltsDc(1);
            Assert.True(v.Equals(ElectricPotentialDc.FromVoltsDc(1), VoltsDcTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricPotentialDc.Zero, VoltsDcTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricPotentialDc.FromVoltsDc(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricPotentialDc.FromVoltsDc(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.False(voltdc.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.False(voltdc.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricPotentialDcUnit)).Cast<ElectricPotentialDcUnit>();
            foreach(var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricPotentialDc.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 kVdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.KilovoltDc).ToString());
                Assert.Equal("1 MVdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.MegavoltDc).ToString());
                Assert.Equal("1 µVdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.MicrovoltDc).ToString());
                Assert.Equal("1 mVdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.MillivoltDc).ToString());
                Assert.Equal("1 Vdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.VoltDc).ToString());
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

            Assert.Equal("1 kVdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.KilovoltDc).ToString(swedishCulture));
            Assert.Equal("1 MVdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.MegavoltDc).ToString(swedishCulture));
            Assert.Equal("1 µVdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.MicrovoltDc).ToString(swedishCulture));
            Assert.Equal("1 mVdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.MillivoltDc).ToString(swedishCulture));
            Assert.Equal("1 Vdc", new ElectricPotentialDc(1, ElectricPotentialDcUnit.VoltDc).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Vdc", new ElectricPotentialDc(0.123456, ElectricPotentialDcUnit.VoltDc).ToString("s1"));
                Assert.Equal("0.12 Vdc", new ElectricPotentialDc(0.123456, ElectricPotentialDcUnit.VoltDc).ToString("s2"));
                Assert.Equal("0.123 Vdc", new ElectricPotentialDc(0.123456, ElectricPotentialDcUnit.VoltDc).ToString("s3"));
                Assert.Equal("0.1235 Vdc", new ElectricPotentialDc(0.123456, ElectricPotentialDcUnit.VoltDc).ToString("s4"));
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
            Assert.Equal("0.1 Vdc", new ElectricPotentialDc(0.123456, ElectricPotentialDcUnit.VoltDc).ToString("s1", culture));
            Assert.Equal("0.12 Vdc", new ElectricPotentialDc(0.123456, ElectricPotentialDcUnit.VoltDc).ToString("s2", culture));
            Assert.Equal("0.123 Vdc", new ElectricPotentialDc(0.123456, ElectricPotentialDcUnit.VoltDc).ToString("s3", culture));
            Assert.Equal("0.1235 Vdc", new ElectricPotentialDc(0.123456, ElectricPotentialDcUnit.VoltDc).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
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
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricPotentialDc)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricPotentialDcUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal(ElectricPotentialDc.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal(ElectricPotentialDc.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(1.0);
            Assert.Equal(new {ElectricPotentialDc.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricPotentialDc.FromVoltsDc(value);
            Assert.Equal(ElectricPotentialDc.FromVoltsDc(-value), -quantity);
        }
    }
}
