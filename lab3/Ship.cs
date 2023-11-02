using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace lab3;

public class Ship: Transport
{
    private const string NAME = "Ship";

    public int NumberOfPassangers { get; private set; }
    public string Port { get; set; }

    public Ship(int k, string portName) : base(NAME)
    {
        Port = portName;
        NumberOfPassangers = k;
    }

    public override string Show()
    {
        return $"{base.Show()} Passangers: {NumberOfPassangers} Port: {Port} Price: {GetPrice()}";
    }

    public override int GetPrice()
    {
        return Convert.ToInt32(5 * Math.Pow(NumberOfPassangers, 2));
    }
}
