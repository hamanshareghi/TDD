using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Models;

namespace TTDTest
{
    public class SumTest
    {
        [Theory]
        [InlineData("1,5",6)]
        [InlineData("",0)]
        [InlineData("0", 0)]
        [InlineData("50,30,20",100)]
        [InlineData("50,30,20,", 100)]
        public void Execute_SumNumbers_When_StringNumbers(string numbers,int expected)
        {

            //arrange
            Sum sum = new Sum();

            //act
            var result = sum.Execute(numbers);
            //assert 
            Assert.Equal(expected, result);

        }

        
    } 
}
