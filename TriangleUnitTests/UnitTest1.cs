using System;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleUnitTests
{
    [TestFixture]
    public class UnitTest1
    {
      
        [Test]
        public void Tringle_InputSameSides_OutputEquilateralTringle()
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

        [Test]
        public void Tringle_InputSideABEqual_OutputIsoscelesTringle()
        {
            // Arrange
            int a = 33;
            int b = 33;
            int c = 23;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Isosceles triangle", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideACEqual_OutputIsoscelesTringle()
        {
            // Arrange
            int a = 13;
            int b = 16;
            int c = 13;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Isosceles triangle", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideBCEqual_OutputIsoscelesTringle()
        {
            // Arrange
            int a = 29;
            int b = 40;
            int c = 40;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Isosceles triangle", Is.EqualTo(output));
        }


        [Test]
        public void Tringle_InputSideABCBetween20To30_OutputScaleneTringle()
        {
            // Arrange
            int a = 23;
            int b = 25;
            int c = 29;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Scalene triangle", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideABCBetween0To9_OutputScaleneTringle()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int c = 4;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Scalene triangle", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideABCReverse_OutputScaleneTringle()
        {
            // Arrange
            int a = 4;
            int b = 3;
            int c = 2;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Scalene triangle", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideABCMorethan100_OutputScaleneTringle()
        {
            // Arrange
            int a = 120;
            int b = 130;
            int c = 140;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Scalene triangle", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideABCMorethan1000_OutputScaleneTringle()
        {
            // Arrange
            int a = 1100;
            int b = 1450;
            int c = 1360;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Scalene triangle", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideAIs0_OutputInvalidTriangle()
        {
            // Arrange
            int a = 0;
            int b = 23;
            int c = 25;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Invalid Triangle - a zero has been detected", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideBIs0_OutputInvalidTriangle()
        {
            // Arrange
            int a = 12;
            int b = 0;
            int c = 12;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Invalid Triangle - a zero has been detected", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideCIs0_OutputInvalidTriangle()
        {
            // Arrange
            int a = 54;
            int b = 54;
            int c = 0;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("Invalid Triangle - a zero has been detected", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideAIsGraterThanAPlusB_OutputInvalid()
        {
            // Arrange
            int a = 60;
            int b = 23;
            int c = 25;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("INVALID!!", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideBIsGraterThanAPlusC_OutputInvalid()
        {
            // Arrange
            int a = 34;
            int b = 230;
            int c = 54;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("INVALID!!", Is.EqualTo(output));
        }

        [Test]
        public void Tringle_InputSideCIsGraterThanAPlusB_OutputInvalid()
        {
            // Arrange
            int a = 54;
            int b = 34;
            int c = 1999;

            // Act
            string output = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.That("INVALID!!", Is.EqualTo(output));
        }
    }
}
