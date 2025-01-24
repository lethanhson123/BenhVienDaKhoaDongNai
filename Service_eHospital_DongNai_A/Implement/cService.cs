namespace Service_eHospital_DongNai_A.Implement
{
    public class cService : BaseService<c, IcRepository>
    , IcService
    {
    private readonly IcRepository _cRepository;
    public cService(IcRepository cRepository) : base(cRepository)
    {
    _cRepository = cRepository;
    }
    }
    }

