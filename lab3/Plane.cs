using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3;

public class Plane : Transport
{
    private const string NAME = "Plane";
    public int Height { get; private set; }
    public int Speed { get; private set; }
    public Plane(int h, int v) : base(NAME)
    {
        Height = h;
        Speed = v;
    }

    public override string Show()
    {
        return $"{base.Show()} Height: {Height} Speed: {Speed} Price: {GetPrice()}";
    }

    public override int GetPrice()
    {
        return 100 * Height * Speed;
    }
}
