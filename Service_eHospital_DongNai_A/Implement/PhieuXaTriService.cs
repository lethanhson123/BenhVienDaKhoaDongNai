namespace Service_eHospital_DongNai_A.Implement
{
    public class PhieuXaTriService : BaseService<PhieuXaTri, IPhieuXaTriRepository>
    , IPhieuXaTriService
    {
    private readonly IPhieuXaTriRepository _PhieuXaTriRepository;
    public PhieuXaTriService(IPhieuXaTriRepository PhieuXaTriRepository) : base(PhieuXaTriRepository)
    {
    _PhieuXaTriRepository = PhieuXaTriRepository;
    }
    }
    }

