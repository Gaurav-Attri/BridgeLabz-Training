class District
{
    private string _districtName;
    private Student[] _students;
    private int _studentsPointer;

    public District(string districtName)
    {
        _districtName = districtName;
        _studentsPointer = 0;
    }

    public void CreateStudentArray(int size)
    {
        _students = new Student[size];
    }

    public Student[] GetStudentsArray()
    {
        return _students;
    }

    public void AddStudent(Student student)
    {
        if(_studentsPointer >= _students.Length)
        {
            return;
        }
        _students[_studentsPointer++] = student;
    }

    public void SortStudentsByScore()
    {
        MergeSort(0, _studentsPointer - 1);
    }

    private void MergeSort(int left, int right)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;
        MergeSort(left, mid);
        MergeSort(mid + 1, right);
        Merge(left, mid, right);
    }

    private void Merge(int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        Student[] L = new Student[n1];
        Student[] R = new Student[n2];

        for (int i = 0; i < n1; i++)
            L[i] = _students[left + i];

        for (int j = 0; j < n2; j++)
            R[j] = _students[mid + 1 + j];

        int iL = 0, iR = 0, k = left;

        while (iL < n1 && iR < n2)
        {
            if (L[iL].GetStudentScore() <= R[iR].GetStudentScore())
                _students[k++] = L[iL++];
            else
                _students[k++] = R[iR++];
        }

        while (iL < n1) _students[k++] = L[iL++];
        while (iR < n2) _students[k++] = R[iR++];
    }


    public override string ToString()
    {
        string districtRepresentation = $"\n{_districtName}\n";
        districtRepresentation += "========================\n";

        foreach(Student student in _students)
        {
            districtRepresentation += student;
        }

        return districtRepresentation;

    }
}