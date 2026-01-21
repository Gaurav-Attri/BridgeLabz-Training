class EduResultsUtility: IEduResults
{
    private static District[] _districts;
    private static int _districtsCount;
    private static int _districtPointer;
    public void AddDistrictData()
    {
        if(_districtsCount != 0)
        {
            Console.WriteLine("\nData already available.\n");
            return;
        }

        Console.WriteLine("\n==== ADD DISTRICT DATA ====\n");
        Console.Write("Enter number of districts: ");
        _districtsCount = int.Parse(Console.ReadLine());
        _districts = new District[_districtsCount];
        Console.WriteLine("\n");
        District district = null;

        for(int i = 0; i < _districtsCount; i++)
        {
            Console.Write($"\nEnter name of the district number {i+1}: ");
            string districtName = Console.ReadLine();
            Console.Write($"Enter number of students in {districtName}: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            district = new District(districtName);
            district.CreateStudentArray(numberOfStudents);

            for(int j = 0; j < numberOfStudents; j++)
            {
                Console.Write($"\nEnter name of student number {j+1}: ");
                string studentName = Console.ReadLine();
                Console.Write($"Enter {studentName}'s marks: ");
                int studentMarks = int.Parse(Console.ReadLine());

                Student student = new Student(studentName, studentMarks, districtName);

                district.AddStudent(student);
                Console.WriteLine("\n");
            }
            district.SortStudentsByScore();
            _districts[_districtPointer++] = district;
        }
    }

    public void DisplayDistrictData()
    {
        Console.WriteLine("\n==== DISTRICT DATA ====\n");
        for(int i = 0; i < _districtsCount; i++)
        {
            Console.WriteLine(_districts[i]);
        }
    }

    public void ShowStudentRanking()
    {
        Console.WriteLine("\n==== STUDENTS STATE-WISE RANKING ====\n");
        if(_districtsCount == 0)
        {
            Console.WriteLine("\nDistrict data not available.\n");
            return;
        }

        Student[][] arrays = new Student[_districtsCount][];
        int totalStudents = 0;

        for (int i = 0; i < _districtsCount; i++)
        {
            arrays[i] = _districts[i].GetStudentsArray();
            totalStudents += arrays[i].Length;
        }

        // idx[i] means how many students from district i have already been used
        int[] idx = new int[_districtsCount];
        Student[] merged = new Student[totalStudents];

        for (int k = 0; k < totalStudents; k++)
        {
            int minArray = -1;

            for (int i = 0; i < _districtsCount; i++)
            {
                if (idx[i] < arrays[i].Length)
                {
                    if (minArray == -1 ||
                        arrays[i][idx[i]].GetStudentScore() <
                        arrays[minArray][idx[minArray]].GetStudentScore())
                    {
                        minArray = i;
                    }
                }
            }

            merged[k] = arrays[minArray][idx[minArray]++];
        }

        int rank = 1;
        for (int i = merged.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Rank {rank++}: {merged[i]}");
        }
    }
}