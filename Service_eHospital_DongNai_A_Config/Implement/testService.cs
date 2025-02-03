namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class testService : BaseService<test, ItestRepository>
    , ItestService
    {
    private readonly ItestRepository _testRepository;
    public testService(ItestRepository testRepository) : base(testRepository)
    {
    _testRepository = testRepository;
    }
    }
    }

