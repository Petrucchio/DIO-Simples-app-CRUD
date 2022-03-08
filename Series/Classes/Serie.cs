namespace Series
{
    public class Serie : EntitiesBase
    {
        private Type Type { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool IsRemoved { get; set; }

        public Serie(int id,Type type, string title, string description, int year)
        {
            this.Id = id;
            this.Type = type;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.IsRemoved = false;
        }

        public override string ToString()
        {
            string returning = "";
            returning += "Type: " + this.Type + Environment.NewLine;
            returning += "Title: " + this.Title + Environment.NewLine;
            returning += "Description: " + this.Description + Environment.NewLine;
            returning += "Year: " + this.Year ;
            returning += "IsRemoved: " + this.IsRemoved ;
            return returning;
        }
        public string returnTitle()
        {
            return Title;
        }
        public int returnId()
        {
            return this.Id;
        }
        public void removing()
        {
            this.IsRemoved = true;
        }
        public bool returningRemoved()
        {
            return this.IsRemoved;
        }
    }

}
