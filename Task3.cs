class Task3
{
    static void Main(string[] args)
    {
        Student[] students = new Student[3];
        int count = 0;
        students = FillArray(4);
        PrintArray(students);
        Calc3(students, ref count);
        Console.WriteLine($"Count = {count}");
    }

    static void Calc3(Student[] st, ref int count)
    {
        for (int i = 0; i < st.Length; i++)
        {
            if (st[i].ifGrade == 5 && st[i].mathGrade == 5 &&
                st[i].physicsGrade == 5)
            {
                count++;
            }
        }
    }

    static Student[] FillArray(int Size)
    {
        Student[] st = new Student[Size];
        Random rand = new Random(1);
        string[] name = { "Oleg", "Andrew", "Mykola","Igor" };
        string[] spec = { "SS", "IN", "KV", "SD", "UG", "TR" };
        for (int i = 0; i < Size; i++)
        {
            int randValue = rand.Next(0, name.Length);
            int randValue2 = rand.Next(0, spec.Length);
            st[i].surname = name[randValue];
            st[i].course = rand.Next(1,5);
            st[i].specialty = spec[randValue2];
            st[i].ifGrade = rand.Next(1,6);
            st[i].mathGrade = rand.Next(1,6);
            st[i].physicsGrade = rand.Next(1,6);
        }
        return st;
    }
    static void PrintArray(Student[] st)
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Surname | course |  Spec  |  IFG |  MTG  |  PSG  |");
        for (int i = 0; i < st.Length; i++)
        {
            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"{st[i].surname}\t|\t{st[i].course}|\t{st[i].specialty}|\t{st[i].ifGrade}|\t{st[i].mathGrade}|\t{st[i].physicsGrade}|");
        }
        Console.WriteLine("--------------------------------------");
    }


    public struct Student
    {
        public string surname; // прізвище студента
        public int course; // курс
        public string specialty; // спеціальність
        public int physicsGrade; // оцінка з фізики
        public int mathGrade; // оцінка з математики
        public int ifGrade; // оцінка з інформатики
    }
    
}
