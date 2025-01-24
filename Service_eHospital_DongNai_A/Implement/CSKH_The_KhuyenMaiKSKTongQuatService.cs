namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_KhuyenMaiKSKTongQuatService : BaseService<CSKH_The_KhuyenMaiKSKTongQuat, ICSKH_The_KhuyenMaiKSKTongQuatRepository>
    , ICSKH_The_KhuyenMaiKSKTongQuatService
    {
    private readonly ICSKH_The_KhuyenMaiKSKTongQuatRepository _CSKH_The_KhuyenMaiKSKTongQuatRepository;
    public CSKH_The_KhuyenMaiKSKTongQuatService(ICSKH_The_KhuyenMaiKSKTongQuatRepository CSKH_The_KhuyenMaiKSKTongQuatRepository) : base(CSKH_The_KhuyenMaiKSKTongQuatRepository)
    {
    _CSKH_The_KhuyenMaiKSKTongQuatRepository = CSKH_The_KhuyenMaiKSKTongQuatRepository;
    }
    }
    }

