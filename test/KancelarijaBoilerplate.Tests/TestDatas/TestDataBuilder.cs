using KancelarijaBoilerplate.EntityFrameworkCore;

namespace KancelarijaBoilerplate.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly KancelarijaBoilerplateDbContext _context;

        public TestDataBuilder(KancelarijaBoilerplateDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}