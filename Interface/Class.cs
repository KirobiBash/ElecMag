{
    class Book:IComparable
    {
        //Data fields for getting and setting information
        public string Name { set; get; }
        public int Isbn { set; get; }
        public String Title { set; get; }
        public double Pages { set; get; }

        //Constructor for initializing the data fields
        public Book(string name, int isbn, string Title, double pages)
        {
            //Setting value to the initilized data fields
            this.Name = name;
            this.Isbn = isbn;
            this.Title = Title;
            this.Pages = pages;
        }

        internal static void Add(object b1)
        {
            throw new NotImplementedException();
        }

        public Book() { }

        //Overriding the original output
        /*public override string ToString()
        {
            return "Teacher: " + this.teacher + " Title: " + this.Title + "pages:" + this.pages;
        }*/

        //This is for comparing two or more data sets using the interface method
        public int CompareTo(object obj)
        {
            Book teach = (Book)obj;
            return this.Pages.CompareTo(this.Pages);
        }
    }
}