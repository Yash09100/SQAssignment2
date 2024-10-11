using System;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleUnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Tringle_InputSameSides_OutputEquilateral()
        {
            // Arrange
            int a = 3;
            int b = 3;
            int c = 3;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Equilateral triangle", Is.EqualTo(output));
        }
    }
}
