namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhNhan_TienCanService : BaseService<BenhNhan_TienCan, IBenhNhan_TienCanRepository>
    , IBenhNhan_TienCanService
    {
    private readonly IBenhNhan_TienCanRepository _BenhNhan_TienCanRepository;
    public BenhNhan_TienCanService(IBenhNhan_TienCanRepository BenhNhan_TienCanRepository) : base(BenhNhan_TienCanRepository)
    {
    _BenhNhan_TienCanRepository = BenhNhan_TienCanRepository;
    }
    }
    }

