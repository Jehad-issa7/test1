namespace Greeter.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        string expected = "Hello, Jehad!";

        //Act 
        string actual = Program.GetGreeting("Jehad");

        //Assert
        Assert.Equal(expected, actual);
    }
}
