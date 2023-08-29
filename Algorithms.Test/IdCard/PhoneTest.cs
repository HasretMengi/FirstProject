using Algorithms;
namespace Algorithms.Test.IdCard;

[TestClass]
public class PhoneTest
{
   
   //Test chaque valeur ! 
     [TestMethod]
   public void TestIsValid()
    {
        Assert.IsTrue(new Phone("5148695423").IsValid()); 
        Assert.IsFalse(new Phone("514").IsValid());
    }

    //Plusieurs valeur + une methode pour tester
    [TestMethod]
    [DataRow("5148965420")]
    [DataRow("514")]
    [DataRow("5148965558811")]

    public void TestIsValid(string phone)
    {
        // Call l'instance 
        Phone phoneNum = new Phone(phone);
        //Variable de validite
        bool isValid = phoneNum.IsValid();

        if (phone.Length >= 10)
        {
            //sans variable bool
            //Assert.IsTrue(phoneNum.IsValid(),$"{phoneNum} should be valid");

            //Avec variable bool 
            Assert.IsTrue(isValid, $"Phone number {phone} should be valid");
        }
        else
        {
            //sans variable bool
            //Assert.IsTrue(phoneNum.IsValid(),$"{phoneNum} should not be valid");

             //Avec variable bool 
            Assert.IsFalse(isValid, $"Phone number {phone} should be invalid");
        }
    }

}