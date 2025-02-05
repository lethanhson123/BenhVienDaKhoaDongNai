namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_LICHTRUCService : BaseService<NS_LICHTRUC, INS_LICHTRUCRepository>
    , INS_LICHTRUCService
    {
    private readonly INS_LICHTRUCRepository _NS_LICHTRUCRepository;
    public NS_LICHTRUCService(INS_LICHTRUCRepository NS_LICHTRUCRepository) : base(NS_LICHTRUCRepository)
    {
    _NS_LICHTRUCRepository = NS_LICHTRUCRepository;
    }
    }
    }

