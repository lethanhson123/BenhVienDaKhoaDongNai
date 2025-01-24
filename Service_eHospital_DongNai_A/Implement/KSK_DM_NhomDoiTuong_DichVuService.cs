namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_DM_NhomDoiTuong_DichVuService : BaseService<KSK_DM_NhomDoiTuong_DichVu, IKSK_DM_NhomDoiTuong_DichVuRepository>
    , IKSK_DM_NhomDoiTuong_DichVuService
    {
    private readonly IKSK_DM_NhomDoiTuong_DichVuRepository _KSK_DM_NhomDoiTuong_DichVuRepository;
    public KSK_DM_NhomDoiTuong_DichVuService(IKSK_DM_NhomDoiTuong_DichVuRepository KSK_DM_NhomDoiTuong_DichVuRepository) : base(KSK_DM_NhomDoiTuong_DichVuRepository)
    {
    _KSK_DM_NhomDoiTuong_DichVuRepository = KSK_DM_NhomDoiTuong_DichVuRepository;
    }
    }
    }

