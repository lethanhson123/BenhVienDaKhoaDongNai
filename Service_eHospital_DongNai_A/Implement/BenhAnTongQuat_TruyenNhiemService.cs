namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TruyenNhiemService : BaseService<BenhAnTongQuat_TruyenNhiem, IBenhAnTongQuat_TruyenNhiemRepository>
    , IBenhAnTongQuat_TruyenNhiemService
    {
    private readonly IBenhAnTongQuat_TruyenNhiemRepository _BenhAnTongQuat_TruyenNhiemRepository;
    public BenhAnTongQuat_TruyenNhiemService(IBenhAnTongQuat_TruyenNhiemRepository BenhAnTongQuat_TruyenNhiemRepository) : base(BenhAnTongQuat_TruyenNhiemRepository)
    {
    _BenhAnTongQuat_TruyenNhiemRepository = BenhAnTongQuat_TruyenNhiemRepository;
    }
    }
    }

