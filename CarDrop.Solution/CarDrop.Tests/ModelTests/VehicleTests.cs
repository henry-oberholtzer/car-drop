using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDrop.Models;

namespace CarDrop.Tests
{
  [TestClass]
  public class CarTests
  {
    [TestMethod]
    public void CarConstructor_CreateAnInstancesOfCar_Car()
    {
      Car alfaromeo = new()
      Assert.AreEqual(typeof(alfaromeo), Car.GetType())
    }
  }
}
