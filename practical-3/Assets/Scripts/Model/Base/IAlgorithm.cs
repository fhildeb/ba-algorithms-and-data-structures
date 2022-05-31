namespace Model.Base
{
    public interface IAlgorithm
    {
        IDataContainer generate();
        void visualize(IDataContainer container, Prefabs pf);
        void applyAlgorithm(IDataContainer obj);
    }

    public interface IAlgorithm<T> : IAlgorithm where T : IDataContainer
    {
        new T generate();
        void visualize(T container, Prefabs pf);
        void applyAlgorithm(T g);
    }
}