using FluentAssertions;
using Laba7OOP;
using Laba7OOP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Laba7OOPTest
{
    public class SquareTests
    {
        private readonly Square square;
        public SquareTests()
        {
            square = new Square(
                new Point { x = 0, y = 0 },
                new Point { x = 0, y = 4 },
                new Point { x = 4, y = 4 },
                new Point { x = 4, y = 0 });
        }

        [Fact]
        public void Square_GetArea()
        {
            // Act

            // Arrange
            var actual = square.getArea();
            // Assert
            actual.Should().Be(16);
        }

        [Fact]
        public void Square_getPerimeter()
        {
            // Act

            // Arrange
            var actual = square.getPerimeter();
            // Assert
            actual.Should().Be(16);
        }

        [Fact]
        public void Square_GetCoord()
        {
            // Act
            var expected = new List<Point>{
                new Point{ x = 0, y = 0 },
                new Point { x = 0, y = 4 },
                new Point { x = 4, y = 4 },
                new Point { x = 4, y = 0 }
            };
            // Arrange
            var actual = square.getCoord();
            // Assert
            expected.Should().BeEquivalentTo(actual);
        }

        [Fact]
        public void Square_GetTextCoord()
        {
            // Act
            var expected = "A(0;0),B(0;4),C(4;4),D(4;0)";
            // Arrege
            var actual = square.getTextCoord();
            // Assert
            expected.Should().Be(actual);
        }

        [Fact]
        public void Squre_MoveTo()
        {
            // Act
            var vector = new Vector
            {
                P1 = new Point
                {
                    x = 0,
                    y = 0
                },
                P2 = new Point
                {
                    x = 2,
                    y = 1
                }
            };
            var expected = new List<Point>
            {
                new Point
                {
                    x = 2,
                    y = 1
                },
                new Point
                {
                    x = 2,
                    y = 5
                },
                new Point
                {
                    x = 6,
                    y = 5
                },
                new Point
                {
                    x = 6,
                    y = 1
                }
            };
            // Arrange
            square.moveAround(vector);
            var actual = square.getCoord();
            // Assert
            expected.Should().BeEquivalentTo(actual);
        }

        [Fact]
        public void Square_GetArea_NotSquare()
        {
            // Act
            var notSquare = new Square(
                new Point { x = 0, y = 5 },
                new Point { x = 12, y = 3 },
                new Point { x = 16, y = 6 },
                new Point { x = 11, y = 1 });
            // Arrange
            var actual = notSquare.getArea();
            // Assert
            actual.Should().BeNull();
        }

        [Fact]
        public void Square_GetPerimeter_NotSquare()
        {
            // Act
            var notSquare = new Square(
                new Point { x = 0, y = 5 },
                new Point { x = 12, y = 3 },
                new Point { x = 16, y = 6 },
                new Point { x = 11, y = 1 });
            // Arrange
            var actual = notSquare.getPerimeter();
            // Assert
            actual.Should().BeNull();
        }

        [Fact]
        public void Square_GetCoord_GetException()
        {
            // Act
            var notSquare = new Square(
                new Point { x = 0, y = 0 },
                null,
                null,
                null);
            // Arrange
            Action act = () => notSquare.getCoord();
            // Assert
            act.Should().Throw<ArgumentException>().WithMessage("Argument not found");

        }


    }
}
