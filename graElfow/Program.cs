namespace graElfow
{
    internal class Program
    {
        static private string zliczCiag(string ciag)
        {
            string wynik = "";
            int count = 0;
            char sprawChar = ciag[0];

            foreach(char c in ciag){
                if(c != sprawChar){
                    wynik += $"{count}{sprawChar}";
                    sprawChar = c;
                    count = 0;
                }
                count++;
            }
            wynik += $"{count}{sprawChar}";

            return wynik;
        }

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);

            for(int i = 0; i < n; i++){
                Console.WriteLine(zliczCiag(Console.ReadLine()));
            }
        }
    }
}
