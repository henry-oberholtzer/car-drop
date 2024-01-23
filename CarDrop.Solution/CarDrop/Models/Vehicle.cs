namespace CarDrop.Models
{
  public class Vehicle
  {
    public string Name { get; set; }
    public  int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    private static List<Vehicle> _instances = new() { };

    public Vehicle(string name, int length, int width, int height, int weight)
    {
      Name = name;
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      _instances.Add(this);
    }
    public int GetVolume()
    {
      return (Length * Width * Height) / (12 * 12 * 12);
    }

    public double CalcShippingCost()
    {
      double density = (double) Weight / GetVolume();
      return (double) (Convert.ToInt32(((double) GetVolume() * 10.99)  * ((double) 100 - density)/100)*100) / 100;
    }

    public static List<Vehicle> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
