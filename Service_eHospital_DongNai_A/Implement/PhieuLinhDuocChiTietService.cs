namespace Service_eHospital_DongNai_A.Implement
{
    public class PhieuLinhDuocChiTietService : BaseService<PhieuLinhDuocChiTiet, IPhieuLinhDuocChiTietRepository>
    , IPhieuLinhDuocChiTietService
    {
    private readonly IPhieuLinhDuocChiTietRepository _PhieuLinhDuocChiTietRepository;
    public PhieuLinhDuocChiTietService(IPhieuLinhDuocChiTietRepository PhieuLinhDuocChiTietRepository) : base(PhieuLinhDuocChiTietRepository)
    {
    _PhieuLinhDuocChiTietRepository = PhieuLinhDuocChiTietRepository;
    }
    }
    }

