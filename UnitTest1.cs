using System;
using Xunit;

class Crypto
{

    private int _cezarShift = 1;

    public char cipher(char ch, int shift)
    {
        if (!char.IsLetter(ch))
        {

            return ch;
        }

        return (char)(ch + shift);
    }

    public string cezarCode(string input)
    {
        string output = string.Empty;

        foreach (char ch in input)
            output += cipher(ch, _cezarShift);

        return output;
    }

    public string cezarDecode(string input)
    {
        string output = string.Empty;

        foreach (char ch in input)
            output += cipher(ch, -_cezarShift);

        return output;
    }
}

namespace CinemaApiTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Crypto crypto = new Crypto();
            string toCode = "abc";
            string coded = crypto.cezarCode(toCode);
            string decoded = crypto.cezarDecode(coded);

            Assert.Equal(toCode, decoded);
        }
    }
}
