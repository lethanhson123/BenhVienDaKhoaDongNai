namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_ThoiHanSDTheService : BaseService<CSKH_The_ThoiHanSDThe, ICSKH_The_ThoiHanSDTheRepository>
    , ICSKH_The_ThoiHanSDTheService
    {
    private readonly ICSKH_The_ThoiHanSDTheRepository _CSKH_The_ThoiHanSDTheRepository;
    public CSKH_The_ThoiHanSDTheService(ICSKH_The_ThoiHanSDTheRepository CSKH_The_ThoiHanSDTheRepository) : base(CSKH_The_ThoiHanSDTheRepository)
    {
    _CSKH_The_ThoiHanSDTheRepository = CSKH_The_ThoiHanSDTheRepository;
    }
    }
    }

