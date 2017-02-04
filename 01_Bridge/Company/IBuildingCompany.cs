namespace _01_Bridge
{
    public interface IBuildingCompany
    {
        void BuildingFondation();
        void BuildingRoom();
        void BuildingRoof();
        IWallCreator WallCreator { get; }
    }
}
