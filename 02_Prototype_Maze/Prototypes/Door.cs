using System;

namespace _02_Prototype_Maze
{
    public class Door : IClonable<Door>
    {
        private Room _room1;
        private Room _room2;
        public void Initialize(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }
        public virtual Door Clone()
        {
            Door door = new Door();
            door.Initialize(_room1, _room2);
            return door;
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}