namespace Greeter.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        string expected = "Hello,Sam!";

        //Act 
        string actual = Program.GetGreeting("Sam");

        //Assert
        Assert.Equal(expected, actual);
    }
}
