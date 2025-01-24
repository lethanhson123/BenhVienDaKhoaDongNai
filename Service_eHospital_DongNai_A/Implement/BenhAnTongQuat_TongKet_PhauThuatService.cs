namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TongKet_PhauThuatService : BaseService<BenhAnTongQuat_TongKet_PhauThuat, IBenhAnTongQuat_TongKet_PhauThuatRepository>
    , IBenhAnTongQuat_TongKet_PhauThuatService
    {
    private readonly IBenhAnTongQuat_TongKet_PhauThuatRepository _BenhAnTongQuat_TongKet_PhauThuatRepository;
    public BenhAnTongQuat_TongKet_PhauThuatService(IBenhAnTongQuat_TongKet_PhauThuatRepository BenhAnTongQuat_TongKet_PhauThuatRepository) : base(BenhAnTongQuat_TongKet_PhauThuatRepository)
    {
    _BenhAnTongQuat_TongKet_PhauThuatRepository = BenhAnTongQuat_TongKet_PhauThuatRepository;
    }
    }
    }

