namespace Practices.Coding.DesignPatterns.Creational.Builder
{
    public interface IHouse
    {
        void ConstructFoundation();
        void ConstructPillars();
        void ConstructWalls();
        void ConstructRoof();
        void ConstructRooms();
    }
}
