using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Tests;

[TestClass]
public class ShipTests
{
    [TestMethod]
    public void GetPrice_10Passangers_Returns500()
    {
        var item = new Ship(10, "");

        Assert.AreEqual(500, item.GetPrice());
    }
}
