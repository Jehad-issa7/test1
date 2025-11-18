namespace Greeter.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        string expected = "Hello,world";

        //Act 
        string actual = Program.GetGreeting();

        //Assert
        Assert.Equal(expected, actual);
    }
}
