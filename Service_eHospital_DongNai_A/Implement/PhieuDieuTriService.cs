namespace Service_eHospital_DongNai_A.Implement
{
    public class PhieuDieuTriService : BaseService<PhieuDieuTri, IPhieuDieuTriRepository>
    , IPhieuDieuTriService
    {
    private readonly IPhieuDieuTriRepository _PhieuDieuTriRepository;
    public PhieuDieuTriService(IPhieuDieuTriRepository PhieuDieuTriRepository) : base(PhieuDieuTriRepository)
    {
    _PhieuDieuTriRepository = PhieuDieuTriRepository;
    }
    }
    }

