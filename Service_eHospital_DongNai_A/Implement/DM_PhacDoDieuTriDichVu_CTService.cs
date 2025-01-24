namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_PhacDoDieuTriDichVu_CTService : BaseService<DM_PhacDoDieuTriDichVu_CT, IDM_PhacDoDieuTriDichVu_CTRepository>
    , IDM_PhacDoDieuTriDichVu_CTService
    {
    private readonly IDM_PhacDoDieuTriDichVu_CTRepository _DM_PhacDoDieuTriDichVu_CTRepository;
    public DM_PhacDoDieuTriDichVu_CTService(IDM_PhacDoDieuTriDichVu_CTRepository DM_PhacDoDieuTriDichVu_CTRepository) : base(DM_PhacDoDieuTriDichVu_CTRepository)
    {
    _DM_PhacDoDieuTriDichVu_CTRepository = DM_PhacDoDieuTriDichVu_CTRepository;
    }
    }
    }

