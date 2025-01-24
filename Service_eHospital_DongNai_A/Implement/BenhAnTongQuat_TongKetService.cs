namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TongKetService : BaseService<BenhAnTongQuat_TongKet, IBenhAnTongQuat_TongKetRepository>
    , IBenhAnTongQuat_TongKetService
    {
    private readonly IBenhAnTongQuat_TongKetRepository _BenhAnTongQuat_TongKetRepository;
    public BenhAnTongQuat_TongKetService(IBenhAnTongQuat_TongKetRepository BenhAnTongQuat_TongKetRepository) : base(BenhAnTongQuat_TongKetRepository)
    {
    _BenhAnTongQuat_TongKetRepository = BenhAnTongQuat_TongKetRepository;
    }
    }
    }

