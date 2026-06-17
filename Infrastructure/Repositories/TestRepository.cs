using Domain.Interfaces.Repositories;

namespace Infrastructure.Repositories;

public class TestRepository : ITestRepository
{
    public int QueryRandomNumber()
    {
        var random = new Random();
        return random.Next(100);
    }
}
