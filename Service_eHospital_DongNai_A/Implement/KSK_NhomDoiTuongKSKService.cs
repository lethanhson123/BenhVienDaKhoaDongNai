namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_NhomDoiTuongKSKService : BaseService<KSK_NhomDoiTuongKSK, IKSK_NhomDoiTuongKSKRepository>
    , IKSK_NhomDoiTuongKSKService
    {
    private readonly IKSK_NhomDoiTuongKSKRepository _KSK_NhomDoiTuongKSKRepository;
    public KSK_NhomDoiTuongKSKService(IKSK_NhomDoiTuongKSKRepository KSK_NhomDoiTuongKSKRepository) : base(KSK_NhomDoiTuongKSKRepository)
    {
    _KSK_NhomDoiTuongKSKRepository = KSK_NhomDoiTuongKSKRepository;
    }
    }
    }

