namespace ConsoleApp1
{
    public interface IName
    {
        string IPrintAnimalName();

    }
    public interface IBird
    {
        void Fly();
    }
    public interface ILion
    {
        void Roar();
    }
    public interface ITiger
    {
        void Growl();
    }
    public interface ISnake
    {
        void Hiss();
        void Hood();
    }
    public interface IIguana
    {
        void Crawl();
        void Sneeze();
    }
    public interface IAmphibians
    {
        void Leaps();
        void Ribbet();
    }
    public interface IFish
    {
        void Swim(string swimType);
    }

}
