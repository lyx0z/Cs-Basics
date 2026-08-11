namespace VariablesDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstelle eine Variable mit deinem Namen und deinem Alter. Finde jeweils geeignete Namen.
            string name = "Nikita ";
            int age = 16;
            string nameAndAge = name + age.ToString();
            Console.WriteLine(nameAndAge);

            //Wieso funktioniert das erste Beispiel, das zweite aber nicht? (Siehe Code Snippet)
            // geht nicht weil eine int kann ein double sein, aber double kann nicht int sein weil int ist nur volle zahlen ohne komma
            // wurde gehen wenn y am ende war ein double oder float

            //Schreibe ein Programm, dass die Zahl PI und die eulersche Zahl als Konstante auf 6 Stellen genau definiert und dies auf der Konsole ausgibt, benutze dafür einmal float und einmal double.
            double pi = Math.PI;
            double e = Math.E;

            float fpi = (float)Math.PI;
            float fe = (float)Math.E;

            double RoundedPi = Math.Round(pi, 6);
            double RoundedE = Math.Round(e, 6);
            Console.WriteLine($"{RoundedE} {RoundedPi}");

            //Erkläre Typinferenz in deinen eigenen Worten. Schreibe ein Beispiel mit int und float
            

        }
    }
}
