namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_TheService : BaseService<CSKH_The, ICSKH_TheRepository>
    , ICSKH_TheService
    {
    private readonly ICSKH_TheRepository _CSKH_TheRepository;
    public CSKH_TheService(ICSKH_TheRepository CSKH_TheRepository) : base(CSKH_TheRepository)
    {
    _CSKH_TheRepository = CSKH_TheRepository;
    }
    }
    }

