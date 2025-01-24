namespace Service_eHospital_DongNai_A.Implement
{
    public class CUST_DM_NhaThuocDungChungService : BaseService<CUST_DM_NhaThuocDungChung, ICUST_DM_NhaThuocDungChungRepository>
    , ICUST_DM_NhaThuocDungChungService
    {
    private readonly ICUST_DM_NhaThuocDungChungRepository _CUST_DM_NhaThuocDungChungRepository;
    public CUST_DM_NhaThuocDungChungService(ICUST_DM_NhaThuocDungChungRepository CUST_DM_NhaThuocDungChungRepository) : base(CUST_DM_NhaThuocDungChungRepository)
    {
    _CUST_DM_NhaThuocDungChungRepository = CUST_DM_NhaThuocDungChungRepository;
    }
    }
    }

