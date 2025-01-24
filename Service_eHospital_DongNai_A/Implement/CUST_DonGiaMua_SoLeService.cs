namespace Service_eHospital_DongNai_A.Implement
{
    public class CUST_DonGiaMua_SoLeService : BaseService<CUST_DonGiaMua_SoLe, ICUST_DonGiaMua_SoLeRepository>
    , ICUST_DonGiaMua_SoLeService
    {
    private readonly ICUST_DonGiaMua_SoLeRepository _CUST_DonGiaMua_SoLeRepository;
    public CUST_DonGiaMua_SoLeService(ICUST_DonGiaMua_SoLeRepository CUST_DonGiaMua_SoLeRepository) : base(CUST_DonGiaMua_SoLeRepository)
    {
    _CUST_DonGiaMua_SoLeRepository = CUST_DonGiaMua_SoLeRepository;
    }
    }
    }

