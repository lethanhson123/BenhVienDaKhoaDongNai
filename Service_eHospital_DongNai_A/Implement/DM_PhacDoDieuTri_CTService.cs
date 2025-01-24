namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_PhacDoDieuTri_CTService : BaseService<DM_PhacDoDieuTri_CT, IDM_PhacDoDieuTri_CTRepository>
    , IDM_PhacDoDieuTri_CTService
    {
    private readonly IDM_PhacDoDieuTri_CTRepository _DM_PhacDoDieuTri_CTRepository;
    public DM_PhacDoDieuTri_CTService(IDM_PhacDoDieuTri_CTRepository DM_PhacDoDieuTri_CTRepository) : base(DM_PhacDoDieuTri_CTRepository)
    {
    _DM_PhacDoDieuTri_CTRepository = DM_PhacDoDieuTri_CTRepository;
    }
    }
    }

