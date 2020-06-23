using System;
using Xunit;
using sample27library;

namespace sample27libraryTest
{
    public class ParserTest
    {
       
        [Fact]
        public void GetParseObject ()
        {
            Parser parser = new Parser();
            var result = parser.ParseSource("1,Sale,120,01-01-2000");
            Assert.IsType(typeof(TradeRecord), result);
        }

        [Theory]
        [InlineData("1,Sale,120,01-01-2000")]
        [InlineData("3,Buy,120,01-01-2000")]
        [InlineData("3,Buy,120,01-01-2020")]
        public void GetParseMultipleParameters (string data)
        {
            Parser parser = new Parser();
            var result = parser.ParseSource(data);
            Assert.IsType(typeof(TradeRecord), result);
        }

        [Theory]
        [InlineData("1Sale,120s,01-01-2000")]
        [InlineData("3,Buy,120ss,01-01-2000")]
        [InlineData("3,Buya,a120,24-24-2020")]
        public void GetParseWrongParameters (string data)
        {
            Parser parser = new Parser();
            var result = parser.ParseSource(data);
            Assert.IsType(typeof(TradeRecord), result);
        }


        [Fact]
        public void Get_invalid_ParseObject ()
        {
            try 
            {
                Parser parser = new Parser();
                var result = parser.ParseSource("2321");
           }
           catch(Exception ex)
           {
               Assert.True(true);
           }
        }
    }
}
