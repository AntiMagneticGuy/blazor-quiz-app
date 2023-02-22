namespace quiz_app_opgave.Shared
{
    public class Spørgsmål // json
    {
        public string category { get; set; }

        public string type { get; set; }

        public string difficulty { get; set; }

        public string question { get; set; }

        public string correct_answer { get; set; }

        public string[] incorrect_answers { get; set; }

    }

   
    public static class Svar
    {
        public static string[,] svarMuligheder { get; set; } = new string[4,4];

        public static string[] userAnswer { get; set; } = new string[4];
        public static string[] question { get; set; } = new string[4];


        public static string[] correctAnswer { get; set; } = new string[4];
    }

}
