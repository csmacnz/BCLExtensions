BCLExtensions
=============

[![License](http://img.shields.io/:license-mit-blue.svg)](http://csmacnz.mit-license.org)
[![AppVeyor Build status](https://img.shields.io/appveyor/ci/MarkClearwater/bclextensions.svg)](https://ci.appveyor.com/project/MarkClearwater/bclextensions)
[![Travis Build Status](https://img.shields.io/travis/csMACnz/BCLExtensions.svg)](https://travis-ci.org/csMACnz/BCLExtensions)
[![Coverage Status](https://img.shields.io/coveralls/csMACnz/BCLExtensions.svg)](https://coveralls.io/r/csMACnz/BCLExtensions?branch=master)
[![Coverity Scan Build Status](https://scan.coverity.com/projects/3770/badge.svg)](https://scan.coverity.com/projects/3770)
[![Stories in Ready](https://badge.waffle.io/csmacnz/BCLExtensions.png?label=ready&title=Ready)](https://waffle.io/csmacnz/BCLExtensions)

Base Class Library Extensions for C# base class library classes, across .Net, Silverlight, WinRT.

For now, this is build upon the most generic PCL possible, but may explore specific additional components if required.

PCL Profile(Profile328)
-----------------------
* .Net Framework 4
* Silverlight 5
* Windows 8/8.1(winrt)
* Windows Phone 8.1
* Window Phone Silverlight 8
* Xamarin.Android
* Xamarin.iOS

At some point this can include nuget packages.


Proposed Extensions
===================

String Extensions
-----------------
* string Left(this string value, int length)
* string Right(this string value, int length)
* string SafeLeft(this string value, int length)
* string SafeRight(this string value, int length)
* string SafeToString&lt;T&gt;(this T item)
* string SafeTrim(this string value)
* string SafeTrimStart(this string value)
* string SafeTrimEnd(this string value)
* string SafeTruncate(this string value)
* string ToLines(this string value)
* string ToNoBlankLines(this string value)
* string JoinWith(this string value, string delimiter)
* string JoinAsLines(this string value)
* long NumberOfLines(this string s);
* long NumberOfNonBlankLines(this string s);
* bool IsNumeric(this string value, bool trimWhitespace = true)

Timespan Extensions
-------------------
* TimeSpan Years(this int value)
* TimeSpan Months(this int value)
* TimeSpan Weeks(this int value)
* TimeSpan Days(this int value)
* TimeSpan Hours(this int value)
* TimeSpan Minutes(this int value)
* TimeSpan Seconds(this int value)
* TimeSpan Milliseconds(this int value)


DateTime Extensions
-------------------
* DateTime Ago(this TimeSpan interval)
* DateTime Since(this TimeSpan interval, DateTime origin)


(Mutable)Collection Extensions
-------------------
* void AddRange&lt;T&gt;(this ICollection&lt;T&gt; collection, IEnumerable&lt;T&gt; itemsToAppend)
* ICollection&lt;T&gt; RemoveEach&lt;T&gt;(this ICollection&lt;T&gt; collection)
* ICollection&lt;T&gt; RemoveEach&lt;T&gt;(this ICollection&lt;T&gt; collection, Func&lt;T, bool&gt; whereExpression)
* ICollection&lt;T&gt; RemoveEach&lt;T&gt;(this ICollection&lt;T&gt; collection, Func&lt;T, int, bool&gt; whereExpression)
* ICollection&lt;T&gt; RemoveEachInReverse&lt;T&gt;(this ICollection&lt;T&gt; collection)
* ICollection&lt;T&gt; RemoveEachInReverse&lt;T&gt;(this ICollection&lt;T&gt; collection, Func&lt;T, bool&gt; whereExpression)
* ICollection&lt;T&gt; RemoveEachInReverse&lt;T&gt;(this ICollection&lt;T&gt; collection, Func&lt;T, int, bool&gt; whereExpression)
* ICollection&lt;T&gt; OrNullIfEmpty(this ICollection&lt;T&gt; collection)
* ICollection&lt;T&gt; OrEmptyIfNull(this ICollection&lt;T&gt; collection)


IList Extensions
----------------------
* IList&lt;T&gt; RemoveEach&lt;T&gt;(this IList&lt;T&gt; items)
* IList&lt;T&gt; RemoveEach&lt;T&gt;(this IList&lt;T&gt; items, Func&lt;T, bool&gt; whereExpression)
* IList&lt;T&gt; RemoveEach&lt;T&gt;(this IList&lt;T&gt; items, Func&lt;T, int, bool&gt; whereExpression)
* IList&lt;T&gt; RemoveEachInReverse&lt;T&gt;(this IList&lt;T&gt; items)
* IList&lt;T&gt; RemoveEachInReverse&lt;T&gt;(this IList&lt;T&gt; items, Func&lt;T, bool&gt; whereExpression)
* IList&lt;T&gt; RemoveEachInReverse&lt;T&gt;(this IList&lt;T&gt; items, Func&lt;T, int, bool&gt; whereExpression)
* IList&lt;T&gt; RemoveEachByIndex&lt;T&gt;(this IList&lt;T&gt; items)
* IList&lt;T&gt; RemoveEachByIndex&lt;T&gt;(this IList&lt;T&gt; items, Func&lt;T, bool&gt; whereExpression)
* IList&lt;T&gt; RemoveEachByIndex&lt;T&gt;(this IList&lt;T&gt; items, Func&lt;T, int, bool&gt; whereExpression)
* IList&lt;T&gt; RemoveEachByIndexInReverse&lt;T&gt;(this IList&lt;T&gt; items)
* IList&lt;T&gt; RemoveEachByIndexInReverse&lt;T&gt;(this IList&lt;T&gt; items, Func&lt;T, bool&gt; whereExpression)
* IList&lt;T&gt; RemoveEachByIndexInReverse&lt;T&gt;(this IList&lt;T&gt; items, Func&lt;T, int, bool&gt; whereExpression)
* IList&lt;T&gt; OrNullIfEmpty(this IList&lt;T&gt; items)
* IList&lt;T&gt; OrEmptyIfNull(this IList&lt;T&gt; items)


List Extensions
----------------------
* List&lt;T&gt; RemoveEach&lt;T&gt;(this List&lt;T&gt; items)
* List&lt;T&gt; RemoveEach&lt;T&gt;(this List&lt;T&gt; items, Func&lt;T, bool&gt; whereExpression)
* List&lt;T&gt; RemoveEach&lt;T&gt;(this List&lt;T&gt; items, Func&lt;T, int, bool&gt; whereExpression)
* List&lt;T&gt; RemoveEachInReverse&lt;T&gt;(this List&lt;T&gt; items)
* List&lt;T&gt; RemoveEachInReverse&lt;T&gt;(this List&lt;T&gt; items, Func&lt;T, bool&gt; whereExpression)
* List&lt;T&gt; RemoveEachInReverse&lt;T&gt;(this List&lt;T&gt; items, Func&lt;T, int, bool&gt; whereExpression)
* List&lt;T&gt; RemoveEachByIndex&lt;T&gt;(this List&lt;T&gt; items)
* List&lt;T&gt; RemoveEachByIndex&lt;T&gt;(this List&lt;T&gt; items, Func&lt;T, bool&gt; whereExpression)
* List&lt;T&gt; RemoveEachByIndex&lt;T&gt;(this List&lt;T&gt; items, Func&lt;T, int, bool&gt; whereExpression)
* List&lt;T&gt; RemoveEachByIndexInReverse&lt;T&gt;(this List&lt;T&gt; items)
* List&lt;T&gt; RemoveEachByIndexInReverse&lt;T&gt;(this List&lt;T&gt; items, Func&lt;T, bool&gt; whereExpression)
* List&lt;T&gt; RemoveEachByIndexInReverse&lt;T&gt;(this List&lt;T&gt; items, Func&lt;T, int, bool&gt; whereExpression)
* List&lt;T&gt; OrNullIfEmpty(this List&lt;T&gt; items)
* List&lt;T&gt; OrEmptyIfNull(this List&lt;T&gt; items)


Array Extensions
----------------------
* void Clear&lt;T&gt;(this T[] items)
* T[] OrNullIfEmpty(this T[] items)
* T[] OrEmptyIfNull(this T[] items)


IEnumerable Extensions
----------------------
* List&lt;T&gt; ToListOf&lt;T&gt;(this IEnumerable items)
* List&lt;T&gt; SafeToListOf&lt;T&gt;(this IEnumerable items)
* List&lt;T&gt; SafeToList&lt;T&gt;(this IEnumerable&lt;T&gt; items)
* T[] SafeToArray&lt;T&gt;(this IEnumerable&lt;T&gt; items)
* Dictionary&lt;TKey, TItem&gt; SafeToDictionary&lt;TItem, TKey&gt;(this IEnumerable&lt;T&gt; items, Func&lt;TItem, TKey&gt; keySelector)
* HashSet&lt;T&gt; SafeToHashSet&lt;T&gt;(this IEnumerable&lt;T&gt; items)
* HashSet&lt;T&gt; SafeToHashSet&lt;T&gt;(this IEnumerable&lt;T&gt; items, IEqualityComparer&lt;T&gt; equalityComparer)


Dictionary Extensions
---------------------
* Dictionary&lt;TKey, TValue&gt; OrNullIfEmpty(this Dictionary&lt;TKey, TValue&gt; dictionary)
* Dictionary&lt;TKey, TValue&gt; OrEmptyIfNull(this Dictionary&lt;TKey, TValue&gt; dictionary)
* T GetValueOrDefault&lt;TKey, TValue&gt;(this Dictionary&lt;TKey, TValue&gt; dictionary, TKey key) where TValue : struct
* T GetValueOrDefault&lt;TKey, TValue&gt;(this Dictionary&lt;TKey, TValue&gt; dictionary, TKey key, TValue defaultValue)


Type Extensions
---------------
* bool DerivesFrom&lt;Type&gt;(this object item) where T : class
* bool IsNullable(this Type itemType)
* IEnumerable&lt;Type&gt; SafeGetTypes(this Assembly assembly)


EnumExtensions
--------------
* void EnsureIsEnum&lt;T&gt;() where T : struct, IComparable, IConvertible, IFormattable
* bool IsEnum&lt;T&gt;() where T : struct, IComparable, IConvertible, IFormattable
* void EnsureIsEnum(this object enumerationValue)
* bool IsEnum(this object enumerationValue)


IntExtensions
-------------
* bool IsBetween(this int value, int lowerLimit, int upperLimit)
* bool IsBetweenExclusive(this int value, int lowerLimit, int upperLimit)
* bool IsBetween(this int value, ExclusiveInteger lowerLimit, ExclusiveInteger upperLimit)
* bool IsBetween(this int value, InclusiveInteger lowerLimit, ExclusiveInteger upperLimit)
* bool IsBetween(this int value, ExclusiveInteger lowerLimit, InclusiveInteger upperLimit)
* bool IsBetween(this int value, InclusiveInteger lowerLimit, InclusiveInteger upperLimit)
* InclusiveInteger Inclusive(this int value)
* ExclusiveInteger Exclusive(this int value)


Example : 5.IsBetween(2.Exclusive(), 5.Inclusive())


LongExtensions
-------------
* bool IsBetween(this long value, long lowerLimit, long upperLimit)
* bool IsBetweenExclusive(this long value, long lowerLimit, long upperLimit)
* bool IsBetween(this long value, ExclusiveLongInteger lowerLimit, ExclusiveLongInteger upperLimit)
* bool IsBetween(this long value, InclusiveLongInteger lowerLimit, ExclusiveLongInteger upperLimit)
* bool IsBetween(this long value, ExclusiveLongInteger lowerLimit, InclusiveLongInteger upperLimit)
* bool IsBetween(this long value, InclusiveLongInteger lowerLimit, InclusiveLongInteger upperLimit)
* InclusiveLongInteger Inclusive(this long value)
* ExclusiveLongInteger Exclusive(this long value)


Example: 5.IsBetween(2.Exclusive(), 5.Inclusive())


DecimalExtensions
-------------
* bool IsBetween(this decimal value, decimal lowerLimit, decimal upperLimit)
* bool IsBetweenExclusive(this decimal value, decimal lowerLimit, decimal upperLimit)
* bool IsBetween(this decimal value, ExclusiveDecimal lowerLimit, ExclusiveDecimal upperLimit)
* bool IsBetween(this decimal value, InclusiveDecimal lowerLimit, ExclusiveDecimal upperLimit)
* bool IsBetween(this decimal value, ExclusiveDecimal lowerLimit, InclusiveDecimal upperLimit)
* bool IsBetween(this decimal value, InclusiveDecimal lowerLimit, InclusiveDecimal upperLimit)
* InclusiveDecimal Inclusive(this decimal value)
* ExclusiveDecimal Exclusive(this decimal value)


Example: (5m).IsBetween((2m).Exclusive(), (5m).Inclusive())


ExpressionExtensions
--------------------
* string GetMemberName&lt;TExpressionBody&gt;(this Expression&lt;TExpressionBody&gt; expression)


Example: ExpressionExtensions.GetMemberName(() =&gt; MyProperty)


Other
-----
* Build implementation of ContractAnnotation

Completed Extensions
====================

Object Extensions
-----------------
* void EnsureIsNotNull(this object instance)
* void EnsureIsNotNull(this object instance, string argumentName)
* bool IsNotNull(this object instance)
* bool IsNull(this object instance)


Generic Extensions
-----------------
* T GetValueOrDefault&lt;T&gt;(this T item, T defaultValue) where T : class


IEnumerable Extensions
----------------------
* bool IsNotEmpty&lt;TItem&gt;(this IEnumerable&lt;TItem&gt; items)
* bool IsNullOrEmpty&lt;TItem&gt;(this IEnumerable&lt;TItem&gt; items)
* IEnumerable&lt;TItem&gt; OrEmptyIfNull&lt;TItem&gt;(this IEnumerable&lt;TItem&gt; items)
* IEnumerable&lt;TItem&gt; OrNullIfEmpty&lt;TItem&gt;(this IEnumerable&lt;TItem&gt; items)


String Extensions
-----------------
* string FormatWith(this string format, params object[] parameters)
* bool IsNotNullOrWhitespace(this String s)
* bool IsNullOrWhitespace(this String s)
* string ValueOrEmptyIfNull(this string value)
* string ValueOrEmptyIfNullOrWhitespace(this string value)
* string ValueOrIfNull(this string value, String replacement)
* string ValueOrIfNullOrWhitespace(this string value, String replacement)
* string ValueOrNullIfWhitespace(this string value)

Type Extensions
---------------
* bool IsOfType&lt;T&gt;(this object item)
