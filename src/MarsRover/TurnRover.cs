namespace MarsRover
{
    public class TurnRover
    {
        public static string Turn(string directionToTurn, string currentDirection)
        {
            directionToTurn = directionToTurn.ToLower();

            if (directionToTurn != "r" && directionToTurn != "l")
                return currentDirection;

            switch (currentDirection.ToLower())
            {
                case "n":
                    return directionToTurn == "r" ? "e" : "w";
                case "e":
                    return directionToTurn == "r" ? "s" : "n";
                case "s":
                    return directionToTurn == "r" ? "w" : "e";
                case "w":
                    return directionToTurn == "r" ? "n" : "s";
                default:
                    return currentDirection;
            }
        }
    }
}
