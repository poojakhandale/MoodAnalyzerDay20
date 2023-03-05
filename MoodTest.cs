using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using   MoodAnalyzer;

namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Mood_Success()
        {
            //Arrange
            string h = "Sad";
            MoodAnalyzer m1 = new MoodAnalyzer();
            string expectedOutput = "SAD";

            //Act 
            string actualOutput = m1.Mood(h);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}


