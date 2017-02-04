namespace _02_Prototype_Maze
{
    public abstract class MazeFactory
    {
        public abstract Maze MakeMaze();
        public abstract Room MakeRoom(int number);
        public abstract Wall MakeWall();
        public abstract Door MakeDoor(Room room1, Room room2);
    }
}