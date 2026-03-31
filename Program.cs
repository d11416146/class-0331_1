namespace class_0331_1
{
    internal class Test
    {
        static void Main(string[] args)
        {
            student joe,marry;
            joe = new student(1234, "AAA", 92, 88);
            Console.WriteLine(joe.Getstudent());

            Console.WriteLine(Student.count.ToString());

            marry = new student(1234, "AAA", 92, 88);
            Console.WriteLine(student.count.ToString());
        }
    }
}
