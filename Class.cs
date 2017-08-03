class School:IComparable
    {
        //Data fields for getting and setting information
        public string teacher { set; get; }
        public int classroom { set; get; }
        public String Title { set; get; }
        public double salary { set; get; }

        //Constructor for initializing the data fields
        public School(string teacher, int classroom, string Title, double salary)
        {
            //Setting value to the initilized data fields
            this.teacher = teacher;
            this.classroom = classroom;
            this.Title = Title;
            this.salary = salary;
        }

         public School() { }

         public int CompareTo(object obj)
        {
            School teach = (School)obj;
            return this.salary.CompareTo(this.salary);
        }