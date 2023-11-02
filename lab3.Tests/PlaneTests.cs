namespace lab3.Tests;

[TestClass]
public class PlaneTests
{
    [TestMethod]
    public void GetPrice_10Speed10Height_Returns10000()
    {
        var item = new Plane(10, 10);

        Assert.AreEqual(10000, item.GetPrice());
    }
}