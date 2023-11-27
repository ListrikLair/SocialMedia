namespace SocialMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            data.GenerateData();
            data.DisplayData();
        }
    }
}