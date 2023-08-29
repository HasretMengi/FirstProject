using Algorithms;
namespace Algorithms.Test.IdCard;

[TestClass]
public class NameTest
{
    [TestMethod]
    public void TestIsValid()
    {
        Assert.IsTrue(new Name("Rabia").IsValid());
    }

}