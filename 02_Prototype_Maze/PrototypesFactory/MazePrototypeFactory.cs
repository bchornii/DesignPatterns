namespace _02_Prototype_Maze
{
    /*********************************************************************************
    * We'll define a MazePrototypeFactory subclass of the MazeFactory class.
    * MazePrototypeFactory will be initialized with prototypes of the objects it will
    * create so that we don't have to subclass it just to change the classes of walls
    * or rooms it creates. 
    **********************************************************************************/
    public class MazePrototypeFactory : MazeFactory
    {
        private readonly Maze _mazePrototype;
        private readonly Wall _wallPrototype;
        private readonly Room _roomPrototype;
        private readonly Door _doorPrototype;

        public MazePrototypeFactory(Maze maze, Wall wall, Room room, Door door)
        {
            _mazePrototype = maze;
            _wallPrototype = wall;
            _roomPrototype = room;
            _doorPrototype = door;
        }

        public override Maze MakeMaze() => _mazePrototype.Clone();        

        public override Room MakeRoom(int number)
        {
            Room room = _roomPrototype.Clone();
            room.Initialize(number);
            return room;
        }

        public override Wall MakeWall() => _wallPrototype.Clone();

        public override Door MakeDoor(Room room1, Room room2)
        {
            Door door = _doorPrototype.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}