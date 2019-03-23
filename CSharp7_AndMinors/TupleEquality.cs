namespace CSharp7_AndMinors
{
    internal class TupleEquality
    {
        public static void Demo()
        {
            (int X, int Y) homePlaceCoordinates = (X: 10, Y: 20);
            (int X, int Y) workPlaceCoordinates = (X: 10, Y: 20);

            // Before C# 7.3
            if (homePlaceCoordinates.X == workPlaceCoordinates.X && homePlaceCoordinates.Y == workPlaceCoordinates.Y)
            {
                // ...
            }

            // With C# 7.3
            // Compiler will generater same code
            if (workPlaceCoordinates == homePlaceCoordinates)
            {
                // ...
            }
        }
    }
}
