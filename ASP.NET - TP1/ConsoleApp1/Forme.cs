internal abstract class Forme
{
    public abstract double Area { get; set; }
    public abstract double Perimeter { get; set; }
    public override string ToString()
    {
        return $"Area = {Area}{Environment.NewLine}Perimeter = {Perimeter}{Environment.NewLine}";
    }
}