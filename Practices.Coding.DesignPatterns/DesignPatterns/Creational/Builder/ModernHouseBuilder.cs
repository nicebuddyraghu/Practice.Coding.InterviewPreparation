namespace Practices.Coding.DesignPatterns.Creational.Builder
{
    internal class ModernHouseBuilder : IHouseBuilder
    {
        private IHouse house = new ModernHouse();

        public void BuildFoundation()
        {
            house.ConstructFoundation();
        }

        public void BuildPillars()
        {
            house.ConstructPillars();
        }

        public void BuildRoof()
        {
            house.ConstructRoof();
        }

        public void BuildRooms()
        {
            house.ConstructRooms();
        }

        public void BuildWalls()
        {
            house.ConstructWalls();
        }

        public IHouse GetHouse()
        {
            return house;
        }
    }
}
