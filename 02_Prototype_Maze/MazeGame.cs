namespace _02_Prototype_Maze
{
    public class MazeGame
    {
        public Maze CreateGame(MazeFactory factory)
        {
            return factory.MakeMaze();
        }
    }
}