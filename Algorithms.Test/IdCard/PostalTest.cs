using Algorithms;
namespace Algorithms.Test.IdCard;

[TestClass]
public class PostalTest
{
    [TestMethod]
    public void PostalIsValid()
    {
        Assert.IsTrue(new PostalCode("A3C T6Y").IsValid()); // true
         Assert.IsFalse(new PostalCode("A").IsValid()); // false
        
    }


}