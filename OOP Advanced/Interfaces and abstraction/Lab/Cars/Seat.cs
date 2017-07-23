using System;
using System.Text;

class Seat : ICar
{
    private string model;
    private string color;

    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public string Model { get => model; set => model = value; }
    public string Color { get => color; set => color = value; }

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
        sb.AppendLine($"{this.Color} Seat {this.Model}");
        sb.AppendLine(this.Start());
        sb.AppendLine(this.Stop());
        return sb.ToString().Trim();
    }
}

