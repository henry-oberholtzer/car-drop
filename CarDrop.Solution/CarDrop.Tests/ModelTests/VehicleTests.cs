using CarDrop.Models;

namespace CarDrop.Tests
{
  [TestClass]
  public class VehicleTests
  {
    [TestMethod]
    public void VehicleConstructor_CreateAnInstancesOfVehicle_Vehicle()
    {
      Vehicle alfaromeo = new("Spyder", 168, 64, 50, 2464);
      Assert.AreEqual(typeof(Vehicle), alfaromeo.GetType());
    }
    [TestMethod]
    public void VehicleConstructor_GetProperties_IntString()
    {
      string name = "Spyder";
      int length = 168;
      int width = 64;
      int height = 50;
      int weight = 2464;
      Vehicle alfaromeo = new(name, length, width, height, weight);
      Assert.AreEqual(alfaromeo.Name, name);
      Assert.AreEqual(alfaromeo.Length, length);
      Assert.AreEqual(alfaromeo.Width, width);
      Assert.AreEqual(alfaromeo.Height, height);
      Assert.AreEqual(alfaromeo.Weight, weight);

    }
    [TestMethod]
    public void VehicleConstructor_SetProperties()
    {
      string name = "Spyder";
      int length = 168;
      int width = 64;
      int height = 50;
      int weight = 2464;
      Vehicle alfaromeo = new("Toyota", 10, 10, 10, 10);
      alfaromeo.Name = name;
      alfaromeo.Length = length;
      alfaromeo.Width = width;
      alfaromeo.Height = height;
      alfaromeo.Weight = weight;
      Assert.AreEqual(alfaromeo.Name, name);
      Assert.AreEqual(alfaromeo.Length, length);
      Assert.AreEqual(alfaromeo.Width, width);
      Assert.AreEqual(alfaromeo.Height, height);
      Assert.AreEqual(alfaromeo.Weight, weight);
    }
    [TestMethod]
    public void VehicleConstructor_GetVolume()
    {
      Vehicle alfaromeo = new("Spyder", 168, 64, 50, 2464);
      int expected = 537600;
      Assert.AreEqual(alfaromeo.GetVolume(), expected);
    }
  }
}
