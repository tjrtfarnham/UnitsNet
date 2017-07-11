﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Power engineers measure apparent power as the magnitude of the vector sum of active and reactive power. Apparent power is the product of the root-mean-square of voltage and current.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class ApparentPower
#else
    public partial struct ApparentPower : IComparable, IComparable<ApparentPower>
#endif
    {
        /// <summary>
        ///     Base unit of ApparentPower.
        /// </summary>
        private readonly double _voltamperes;

		// Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public ApparentPower() : this(0)
        {
        }
#endif

        public ApparentPower(double voltamperes)
        {
            _voltamperes = Convert.ToDouble(voltamperes);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        ApparentPower(long voltamperes)
        {
            _voltamperes = Convert.ToDouble(voltamperes);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        ApparentPower(decimal voltamperes)
        {
            _voltamperes = Convert.ToDouble(voltamperes);
        }

        #region Properties

        public static ApparentPowerUnit BaseUnit
        {
            get { return ApparentPowerUnit.Voltampere; }
        }

        /// <summary>
        ///     Get ApparentPower in Kilovoltamperes.
        /// </summary>
        public double Kilovoltamperes
        {
            get { return (_voltamperes) / 1e3d; }
        }

        /// <summary>
        ///     Get ApparentPower in Megavoltamperes.
        /// </summary>
        public double Megavoltamperes
        {
            get { return (_voltamperes) / 1e6d; }
        }

        /// <summary>
        ///     Get ApparentPower in Voltamperes.
        /// </summary>
        public double Voltamperes
        {
            get { return _voltamperes; }
        }

        #endregion

        #region Static

        public static ApparentPower Zero
        {
            get { return new ApparentPower(); }
        }

        /// <summary>
        ///     Get ApparentPower from Kilovoltamperes.
        /// </summary>
        public static ApparentPower FromKilovoltamperes(double kilovoltamperes)
        {
            return new ApparentPower((kilovoltamperes) * 1e3d);
        }

        /// <summary>
        ///     Get ApparentPower from Megavoltamperes.
        /// </summary>
        public static ApparentPower FromMegavoltamperes(double megavoltamperes)
        {
            return new ApparentPower((megavoltamperes) * 1e6d);
        }

        /// <summary>
        ///     Get ApparentPower from Voltamperes.
        /// </summary>
        public static ApparentPower FromVoltamperes(double voltamperes)
        {
            return new ApparentPower(voltamperes);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable ApparentPower from nullable Kilovoltamperes.
        /// </summary>
        public static ApparentPower? FromKilovoltamperes(double? kilovoltamperes)
        {
            if (kilovoltamperes.HasValue)
            {
                return FromKilovoltamperes(kilovoltamperes.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ApparentPower from nullable Megavoltamperes.
        /// </summary>
        public static ApparentPower? FromMegavoltamperes(double? megavoltamperes)
        {
            if (megavoltamperes.HasValue)
            {
                return FromMegavoltamperes(megavoltamperes.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ApparentPower from nullable Voltamperes.
        /// </summary>
        public static ApparentPower? FromVoltamperes(double? voltamperes)
        {
            if (voltamperes.HasValue)
            {
                return FromVoltamperes(voltamperes.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ApparentPowerUnit" /> to <see cref="ApparentPower" />.
        /// </summary>
        /// <param name="val">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ApparentPower unit value.</returns>
        public static ApparentPower From(double val, ApparentPowerUnit fromUnit)
        {
            switch (fromUnit)
            {
                case ApparentPowerUnit.Kilovoltampere:
                    return FromKilovoltamperes(val);
                case ApparentPowerUnit.Megavoltampere:
                    return FromMegavoltamperes(val);
                case ApparentPowerUnit.Voltampere:
                    return FromVoltamperes(val);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ApparentPowerUnit" /> to <see cref="ApparentPower" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ApparentPower unit value.</returns>
        public static ApparentPower? From(double? value, ApparentPowerUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case ApparentPowerUnit.Kilovoltampere:
                    return FromKilovoltamperes(value.Value);
                case ApparentPowerUnit.Megavoltampere:
                    return FromMegavoltamperes(value.Value);
                case ApparentPowerUnit.Voltampere:
                    return FromVoltamperes(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ApparentPowerUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ApparentPowerUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static ApparentPower operator -(ApparentPower right)
        {
            return new ApparentPower(-right._voltamperes);
        }

        public static ApparentPower operator +(ApparentPower left, ApparentPower right)
        {
            return new ApparentPower(left._voltamperes + right._voltamperes);
        }

        public static ApparentPower operator -(ApparentPower left, ApparentPower right)
        {
            return new ApparentPower(left._voltamperes - right._voltamperes);
        }

        public static ApparentPower operator *(double left, ApparentPower right)
        {
            return new ApparentPower(left*right._voltamperes);
        }

        public static ApparentPower operator *(ApparentPower left, double right)
        {
            return new ApparentPower(left._voltamperes*(double)right);
        }

        public static ApparentPower operator /(ApparentPower left, double right)
        {
            return new ApparentPower(left._voltamperes/(double)right);
        }

        public static double operator /(ApparentPower left, ApparentPower right)
        {
            return Convert.ToDouble(left._voltamperes/right._voltamperes);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is ApparentPower)) throw new ArgumentException("Expected type ApparentPower.", "obj");
            return CompareTo((ApparentPower) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(ApparentPower other)
        {
            return _voltamperes.CompareTo(other._voltamperes);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(ApparentPower left, ApparentPower right)
        {
            return left._voltamperes <= right._voltamperes;
        }

        public static bool operator >=(ApparentPower left, ApparentPower right)
        {
            return left._voltamperes >= right._voltamperes;
        }

        public static bool operator <(ApparentPower left, ApparentPower right)
        {
            return left._voltamperes < right._voltamperes;
        }

        public static bool operator >(ApparentPower left, ApparentPower right)
        {
            return left._voltamperes > right._voltamperes;
        }

        public static bool operator ==(ApparentPower left, ApparentPower right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._voltamperes == right._voltamperes;
        }

        public static bool operator !=(ApparentPower left, ApparentPower right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._voltamperes != right._voltamperes;
        }
#endif

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _voltamperes.Equals(((ApparentPower) obj)._voltamperes);
        }

        public override int GetHashCode()
        {
            return _voltamperes.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(ApparentPowerUnit unit)
        {
            switch (unit)
            {
                case ApparentPowerUnit.Kilovoltampere:
                    return Kilovoltamperes;
                case ApparentPowerUnit.Megavoltampere:
                    return Megavoltamperes;
                case ApparentPowerUnit.Voltampere:
                    return Voltamperes;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ApparentPower Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ApparentPower Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return UnitParser.ParseUnit<ApparentPower>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    ApparentPowerUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromVoltamperes(x.Voltamperes + y.Voltamperes));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ApparentPower result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out ApparentPower result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(ApparentPower);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ApparentPowerUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ApparentPowerUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static ApparentPowerUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<ApparentPowerUnit>(str.Trim());

            if (unit == ApparentPowerUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized ApparentPowerUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is Voltampere
        /// </summary>
        public static ApparentPowerUnit ToStringDefaultUnit { get; set; } = ApparentPowerUnit.Voltampere;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(ApparentPowerUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(ApparentPowerUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ApparentPowerUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ApparentPowerUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of ApparentPower
        /// </summary>
        public static ApparentPower MaxValue
        {
            get
            {
                return new ApparentPower(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of ApparentPower
        /// </summary>
        public static ApparentPower MinValue
        {
            get
            {
                return new ApparentPower(double.MinValue);
            }
        }
    }
}
