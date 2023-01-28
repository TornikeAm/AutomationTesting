using Xunit;

public class testclass{

    [Theory]
    [InlineData("a","aaadge")]
    [InlineData("b","gdbbesdff")]
    [InlineData("a","abgdevzt")]
    [InlineData("a","abgdevztilmnopjra")]
    public void MaxRepeatingTest(string excepted, string word){
        char character = char.Parse(excepted);
        var result = program.maxRepeating(word);
        Assert.Equal(character,result);

    }

    [Theory]
    [InlineData(3,"aaadge")]
    [InlineData(2,"gdbbesdff")]
    [InlineData(1,"abgdevzt")]
    [InlineData(2,"abgdevztikla")]
    public void MaxNumOfMostRepCharsTest(int excepted, string word){
        var result = program.MaxNumber(word);
        Assert.Equal(excepted,result);

    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void MaxIdenticalDigitsTest(int excepted, int[] arr){
        var result = program.MaxNumIdenticalDigits(arr);
        Assert.Equal(excepted,result);
        
    }

    public static IEnumerable<object[]> TestData(){
        
        yield return new object[]{3, new int[]{1,4,5}};
        yield return new object[]{5, new int[]{10,11,12,15,16,23,4,2,13}};
        yield return new object[]{3, new int[]{1,5,7,2,5,1}};
        yield return new object[]{8, new int[]{5,6,7,8,9,10,11,14,5,23,41,23,44}};

    }
}

