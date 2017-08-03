{
    class Program
    {
        static void Main(string[] args)
        {
            


            //Create a list of Books
            List<Library> Book = new List<Library>();

            //declaring and initialising School objects
            Book b1 = new Book("Mrs. Frizzle", 153, "World Teacher", 50000);
            Book b2 = new Book("Mr. Haney", 204, "History Teacher", 50000);
            if (b1.CompareTo(b2) == -1)
                Console.WriteLine(b2.Name + "Employee {0} earns more");
            else if (b1.CompareTo(b2) == 0)
                Console.WriteLine("Both have the same salary");
            else
                Console.WriteLine(b1.Name + "Earns more");

            //Adding teacher objects into the list.
            Library.Add(b1);
            Library.Add(b2);

            //Displays the teacher details to the user.
            foreach (Book b in Book)
            {
                Console.WriteLine(b.ToString());
            }

            //Total number of teachers on the list.
            Console.WriteLine("Total number of Teachers in this School: " + Book.Count);

            Console.ReadLine();
        }
    }
}
