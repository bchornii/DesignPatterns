namespace _02_Prototype_Maze
{
    internal class Program
    {
        private static void Main()
        {
            var game = new MazeGame();
            var factory = new MazePrototypeFactory(new Maze(), new BoombedWall(), new Room(), new Door());
            var maze = game.CreateGame(factory);
        }
    }
}
