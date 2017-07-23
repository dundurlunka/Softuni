using System;
using System.Text;

public class Tesla : ICar, IElectricCar
{
    private string model;
    private string color;
    private int batteries;

    public Tesla(string model, string color, int batteries)
    {
        Model = model;
        Color = color;
        Batteries = batteries;
    }

    public string Model { get => model; set => model = value; }
    public string Color { get => color; set => color = value; }
    public int Batteries { get => batteries; set => batteries = value; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Batteries} Batteries");
        sb.AppendLine(this.Start());
        sb.AppendLine(this.Stop());
        return sb.ToString().Trim();
    }
}

