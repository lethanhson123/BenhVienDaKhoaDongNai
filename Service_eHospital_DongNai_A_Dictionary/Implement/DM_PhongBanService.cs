namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_PhongBanService : BaseService<DM_PhongBan, IDM_PhongBanRepository>
    , IDM_PhongBanService
    {
    private readonly IDM_PhongBanRepository _DM_PhongBanRepository;
    public DM_PhongBanService(IDM_PhongBanRepository DM_PhongBanRepository) : base(DM_PhongBanRepository)
    {
    _DM_PhongBanRepository = DM_PhongBanRepository;
    }
    }
    }

