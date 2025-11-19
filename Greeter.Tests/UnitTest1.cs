namespace Greeter.Tests;

public class UnitTest1
{
    [Fact]
    public void GetGreeting_Should_Return_HelloWorld()
    {
        //Arrange
        string expected = "Hello, World!";

        //Act 
        string actual = Program.GetGreeting();

        //Assert
        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("spanish", "Hola, Sam!")]
    [InlineData("french", "Bonjour, Sam!")]
    public void GetGreeting_With__Name_Return_NameGreeting(string language, string expected)
    {
        //Act
        string actual = Program.GetGreeting("Sam", language);

        //
        Assert.Equal(expected, actual);

    }
}
