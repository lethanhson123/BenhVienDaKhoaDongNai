namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_MatService : BaseService<BenhAnTongQuat_Mat, IBenhAnTongQuat_MatRepository>
    , IBenhAnTongQuat_MatService
    {
    private readonly IBenhAnTongQuat_MatRepository _BenhAnTongQuat_MatRepository;
    public BenhAnTongQuat_MatService(IBenhAnTongQuat_MatRepository BenhAnTongQuat_MatRepository) : base(BenhAnTongQuat_MatRepository)
    {
    _BenhAnTongQuat_MatRepository = BenhAnTongQuat_MatRepository;
    }
    }
    }

