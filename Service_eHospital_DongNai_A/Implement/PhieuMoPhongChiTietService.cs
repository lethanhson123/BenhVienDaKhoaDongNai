namespace Service_eHospital_DongNai_A.Implement
{
    public class PhieuMoPhongChiTietService : BaseService<PhieuMoPhongChiTiet, IPhieuMoPhongChiTietRepository>
    , IPhieuMoPhongChiTietService
    {
    private readonly IPhieuMoPhongChiTietRepository _PhieuMoPhongChiTietRepository;
    public PhieuMoPhongChiTietService(IPhieuMoPhongChiTietRepository PhieuMoPhongChiTietRepository) : base(PhieuMoPhongChiTietRepository)
    {
    _PhieuMoPhongChiTietRepository = PhieuMoPhongChiTietRepository;
    }
    }
    }

