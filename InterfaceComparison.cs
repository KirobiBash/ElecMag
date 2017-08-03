//Program.cs file


 //declaring and initialising School objects
            School t1 = new School("Mrs. Frizzle", 153, "World Teacher", 50000);
            School t2 = new School("Mr. Haney", 204, "History Teacher", 50000);
            if (t1.CompareTo(t2) == -1)
                Console.WriteLine(t2.teacher + "Employee {0} earns more");
            else if (t1.CompareTo(t2) == 0)
                Console.WriteLine("Both have the same salary");
            else
                Console.WriteLine(t1.teacher + "Earns more");