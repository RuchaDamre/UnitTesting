

using Xunit;
public class test
{
[Theory]
[InlineData(3)]
[InlineData(5)]
[InlineData(6)]

public void Theory(int n)
{
    Assert.True(Program.isOdd(n));
}

[Fact]
public void AddTest()
{
    Assert.Equal(4,Program.Add(2,2));
    
}

[Fact]
public void FailTest()
{
    Assert.NotEqual(5,Program.Add(2,2));
    
}



}
