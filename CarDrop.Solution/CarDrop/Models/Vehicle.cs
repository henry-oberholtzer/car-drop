namespace CarDrop.Models
{
  public class Vehicle
  {
    public string Name { get; set; }
    public  int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public Vehicle(string name, int length, int width, int height, int weight)
    {
      Name = name;
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }
    public int GetVolume()
    {
      return Length * Width * Height;
    }

    public double CalcShippingCost()
    {
      double density = (double) Weight / GetVolume();
      return ((double) GetVolume() * 10.99)  * ((double) 100 - density)/100;
    }

  }
}
