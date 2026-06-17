namespace Application.Services
{
    public class TestService
    {
        public int GetRandomNumber()
        {
            var random = new Random();
            return random.Next(100);
        }
    }    
}