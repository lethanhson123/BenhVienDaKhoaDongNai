namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_DoiTheService : BaseService<CSKH_The_DoiThe, ICSKH_The_DoiTheRepository>
    , ICSKH_The_DoiTheService
    {
    private readonly ICSKH_The_DoiTheRepository _CSKH_The_DoiTheRepository;
    public CSKH_The_DoiTheService(ICSKH_The_DoiTheRepository CSKH_The_DoiTheRepository) : base(CSKH_The_DoiTheRepository)
    {
    _CSKH_The_DoiTheRepository = CSKH_The_DoiTheRepository;
    }
    }
    }

