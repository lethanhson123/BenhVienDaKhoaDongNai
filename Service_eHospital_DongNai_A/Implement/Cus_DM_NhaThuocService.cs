namespace Service_eHospital_DongNai_A.Implement
{
    public class Cus_DM_NhaThuocService : BaseService<Cus_DM_NhaThuoc, ICus_DM_NhaThuocRepository>
    , ICus_DM_NhaThuocService
    {
    private readonly ICus_DM_NhaThuocRepository _Cus_DM_NhaThuocRepository;
    public Cus_DM_NhaThuocService(ICus_DM_NhaThuocRepository Cus_DM_NhaThuocRepository) : base(Cus_DM_NhaThuocRepository)
    {
    _Cus_DM_NhaThuocRepository = Cus_DM_NhaThuocRepository;
    }
    }
    }

