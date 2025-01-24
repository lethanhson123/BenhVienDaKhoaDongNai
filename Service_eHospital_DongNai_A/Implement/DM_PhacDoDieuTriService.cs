namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_PhacDoDieuTriService : BaseService<DM_PhacDoDieuTri, IDM_PhacDoDieuTriRepository>
    , IDM_PhacDoDieuTriService
    {
    private readonly IDM_PhacDoDieuTriRepository _DM_PhacDoDieuTriRepository;
    public DM_PhacDoDieuTriService(IDM_PhacDoDieuTriRepository DM_PhacDoDieuTriRepository) : base(DM_PhacDoDieuTriRepository)
    {
    _DM_PhacDoDieuTriRepository = DM_PhacDoDieuTriRepository;
    }
    }
    }

