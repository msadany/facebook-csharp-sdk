// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace Facebook.Utilities
{
    public partial class UnixDateTimeTest
    {
[TestMethod]
[PexGeneratedBy(typeof(UnixDateTimeTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void FromUnixTimeThrowsArgumentNullException609()
{
    DateTime dt;
    dt = this.FromUnixTime((string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(UnixDateTimeTest))]
[PexRaisedException(typeof(FormatException))]
public void FromUnixTimeThrowsFormatException569()
{
    DateTime dt;
    dt = this.FromUnixTime("\0");
}
[TestMethod]
[PexGeneratedBy(typeof(UnixDateTimeTest))]
public void FromUnixTime715()
{
    DateTime dt;
    dt = this.FromUnixTime("0");
    Assert.AreEqual<int>(1, dt.Day);
    Assert.AreEqual<DayOfWeek>(DayOfWeek.Thursday, dt.DayOfWeek);
    Assert.AreEqual<int>(1, dt.DayOfYear);
    Assert.AreEqual<int>(0, dt.Hour);
    Assert.AreEqual<DateTimeKind>(DateTimeKind.Utc, dt.Kind);
    Assert.AreEqual<int>(0, dt.Millisecond);
    Assert.AreEqual<int>(0, dt.Minute);
    Assert.AreEqual<int>(1, dt.Month);
    Assert.AreEqual<int>(0, dt.Second);
    Assert.AreEqual<int>(1970, dt.Year);
}
    }
}
