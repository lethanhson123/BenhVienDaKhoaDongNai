namespace Service_eHospital_DongNai_A.Implement
{
    public class PhieuSoKetDieuTriService : BaseService<PhieuSoKetDieuTri, IPhieuSoKetDieuTriRepository>
    , IPhieuSoKetDieuTriService
    {
    private readonly IPhieuSoKetDieuTriRepository _PhieuSoKetDieuTriRepository;
    public PhieuSoKetDieuTriService(IPhieuSoKetDieuTriRepository PhieuSoKetDieuTriRepository) : base(PhieuSoKetDieuTriRepository)
    {
    _PhieuSoKetDieuTriRepository = PhieuSoKetDieuTriRepository;
    }
    }
    }

