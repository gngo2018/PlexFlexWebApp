using Application.Interfaces;

namespace Application.Services
{
    public class TestService
    {
        private readonly ITestRepository _testRepository;
        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public int GetRandomNumber()
        {
            return _testRepository.QueryRandomNumber();
        }
    }    
}