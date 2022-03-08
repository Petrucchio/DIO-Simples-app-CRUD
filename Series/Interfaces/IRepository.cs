namespace Series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnForId(int id);
        void Insert(T entitie);
        void Delete(int id);
        void Update(int id,T entitie);
        int NextId();
    }
}
