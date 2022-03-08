using Series.Interfaces;

namespace Series.Classes
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();
        public void Delete(int id)
        {
            listSerie[id].removing();
        }

        public void Insert(Serie entitie)
        {
            listSerie.Add(entitie);
        }

        public List<Serie> List()
        {
            return listSerie;
        }

        public int NextId()
        {
            return listSerie.Count;
        }

        public Serie ReturnForId(int id)
        {
            return listSerie[id];
        }

        public void Update(int id, Serie entitie)
        {
            listSerie[id] = entitie;
        }
    }
}
