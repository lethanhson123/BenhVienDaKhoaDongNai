namespace Service_eHospital_DongNai_A.Implement
{
    public class PhieuMoPhongService : BaseService<PhieuMoPhong, IPhieuMoPhongRepository>
    , IPhieuMoPhongService
    {
    private readonly IPhieuMoPhongRepository _PhieuMoPhongRepository;
    public PhieuMoPhongService(IPhieuMoPhongRepository PhieuMoPhongRepository) : base(PhieuMoPhongRepository)
    {
    _PhieuMoPhongRepository = PhieuMoPhongRepository;
    }
    }
    }

