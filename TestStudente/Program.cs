using System;


namespace TestStudente
{
    class Program
    {
        static void Main(string[] args)
        {
            Studente s1 = new Studente("mario", "rossi", 18);
            s1.Presentati();
            LIbro l = new LIbro(500, "pippo", "disneay");
        }
    }
}
