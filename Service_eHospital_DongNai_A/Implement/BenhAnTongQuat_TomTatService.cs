namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TomTatService : BaseService<BenhAnTongQuat_TomTat, IBenhAnTongQuat_TomTatRepository>
    , IBenhAnTongQuat_TomTatService
    {
    private readonly IBenhAnTongQuat_TomTatRepository _BenhAnTongQuat_TomTatRepository;
    public BenhAnTongQuat_TomTatService(IBenhAnTongQuat_TomTatRepository BenhAnTongQuat_TomTatRepository) : base(BenhAnTongQuat_TomTatRepository)
    {
    _BenhAnTongQuat_TomTatRepository = BenhAnTongQuat_TomTatRepository;
    }
    }
    }

