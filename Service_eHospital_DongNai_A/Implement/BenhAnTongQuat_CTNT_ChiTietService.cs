namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_CTNT_ChiTietService : BaseService<BenhAnTongQuat_CTNT_ChiTiet, IBenhAnTongQuat_CTNT_ChiTietRepository>
    , IBenhAnTongQuat_CTNT_ChiTietService
    {
    private readonly IBenhAnTongQuat_CTNT_ChiTietRepository _BenhAnTongQuat_CTNT_ChiTietRepository;
    public BenhAnTongQuat_CTNT_ChiTietService(IBenhAnTongQuat_CTNT_ChiTietRepository BenhAnTongQuat_CTNT_ChiTietRepository) : base(BenhAnTongQuat_CTNT_ChiTietRepository)
    {
    _BenhAnTongQuat_CTNT_ChiTietRepository = BenhAnTongQuat_CTNT_ChiTietRepository;
    }
    }
    }

