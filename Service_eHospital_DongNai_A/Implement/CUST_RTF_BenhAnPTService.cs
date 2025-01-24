namespace Service_eHospital_DongNai_A.Implement
{
    public class CUST_RTF_BenhAnPTService : BaseService<CUST_RTF_BenhAnPT, ICUST_RTF_BenhAnPTRepository>
    , ICUST_RTF_BenhAnPTService
    {
    private readonly ICUST_RTF_BenhAnPTRepository _CUST_RTF_BenhAnPTRepository;
    public CUST_RTF_BenhAnPTService(ICUST_RTF_BenhAnPTRepository CUST_RTF_BenhAnPTRepository) : base(CUST_RTF_BenhAnPTRepository)
    {
    _CUST_RTF_BenhAnPTRepository = CUST_RTF_BenhAnPTRepository;
    }
    }
    }

