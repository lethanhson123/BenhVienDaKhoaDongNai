namespace Service_eHospital_DongNai_A.Implement
{
    public class BCDP_014_TheoLoService : BaseService<BCDP_014_TheoLo, IBCDP_014_TheoLoRepository>
    , IBCDP_014_TheoLoService
    {
    private readonly IBCDP_014_TheoLoRepository _BCDP_014_TheoLoRepository;
    public BCDP_014_TheoLoService(IBCDP_014_TheoLoRepository BCDP_014_TheoLoRepository) : base(BCDP_014_TheoLoRepository)
    {
    _BCDP_014_TheoLoRepository = BCDP_014_TheoLoRepository;
    }
    }
    }

