using NUnit.Framework;

using App;

namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual("hey", Hello.Wrap("thing"));
    }
}
