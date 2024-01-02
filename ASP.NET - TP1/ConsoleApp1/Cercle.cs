internal class Cercle : Forme
{
    public int Rayon { get; set; }
    public override double Area => Math.PI * Rayon * Rayon;
    public override double Perimeter => Math.PI * Rayon * 2;
    public override string ToString()
    {
        return $"{base.ToString}";
    }
}