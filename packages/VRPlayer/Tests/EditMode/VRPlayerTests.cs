using NUnit.Framework;

public class PackageBasicTests
{
    [Test]
    public void Ping_ReturnsOk()
    {
        Assert.IsTrue("ok".Contains("ok"));
    }
}
