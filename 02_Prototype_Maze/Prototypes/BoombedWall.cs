namespace _02_Prototype_Maze
{
    public class BoombedWall : Wall
    {
        public override Wall Clone()
        {
            return new BoombedWall();
        }
    }
}