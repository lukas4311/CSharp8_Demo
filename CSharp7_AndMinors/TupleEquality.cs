namespace CSharp7_AndMinors
{
    internal class TupleEquality
    {
        public static void Demo()
        {
            (int X, int YZ) homePlaceCoordinates = (X: 10, YZ: 20);
            (int Y, int X) workPlaceCoordinates = (Y: 10, X: 20);

            // Before C# 7.3
            if (homePlaceCoordinates.X == workPlaceCoordinates.X && homePlaceCoordinates.YZ == workPlaceCoordinates.Y)
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
