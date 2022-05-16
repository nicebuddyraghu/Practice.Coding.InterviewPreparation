namespace Practices.Coding.DesignPatterns.Creational.Builder
{
    internal class CivilEngineer : IEngineer
    {
        public IHouseBuilder Builder {get;set;}

        public CivilEngineer(IHouseBuilder builder)
        {
            Builder = builder;
        }

        public IHouse ConstructHouse(IHouseBuilder builder)
        {
            builder.BuildFoundation();
            builder.BuildPillars();
            builder.BuildRoof();
            builder.BuildRooms();
            builder.BuildWalls();

            return builder.GetHouse();
        }
    }
}
