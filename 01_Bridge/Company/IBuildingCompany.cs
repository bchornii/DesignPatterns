namespace _01_Bridge
{
    interface IBuildingCompany
    {
        void BuildingFondation();
        void BuildingRoom();
        void BuildingRoof();
        IWallCreator WallCreator { get; set; }
    }
}
