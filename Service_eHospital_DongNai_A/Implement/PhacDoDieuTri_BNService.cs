namespace Service_eHospital_DongNai_A.Implement
{
    public class PhacDoDieuTri_BNService : BaseService<PhacDoDieuTri_BN, IPhacDoDieuTri_BNRepository>
    , IPhacDoDieuTri_BNService
    {
    private readonly IPhacDoDieuTri_BNRepository _PhacDoDieuTri_BNRepository;
    public PhacDoDieuTri_BNService(IPhacDoDieuTri_BNRepository PhacDoDieuTri_BNRepository) : base(PhacDoDieuTri_BNRepository)
    {
    _PhacDoDieuTri_BNRepository = PhacDoDieuTri_BNRepository;
    }
    }
    }

