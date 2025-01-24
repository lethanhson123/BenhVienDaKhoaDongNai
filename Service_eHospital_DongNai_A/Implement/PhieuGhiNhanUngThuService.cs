namespace Service_eHospital_DongNai_A.Implement
{
    public class PhieuGhiNhanUngThuService : BaseService<PhieuGhiNhanUngThu, IPhieuGhiNhanUngThuRepository>
    , IPhieuGhiNhanUngThuService
    {
    private readonly IPhieuGhiNhanUngThuRepository _PhieuGhiNhanUngThuRepository;
    public PhieuGhiNhanUngThuService(IPhieuGhiNhanUngThuRepository PhieuGhiNhanUngThuRepository) : base(PhieuGhiNhanUngThuRepository)
    {
    _PhieuGhiNhanUngThuRepository = PhieuGhiNhanUngThuRepository;
    }
    }
    }

