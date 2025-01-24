namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_DM_GoiDichVuService : BaseService<CSKH_DM_GoiDichVu, ICSKH_DM_GoiDichVuRepository>
    , ICSKH_DM_GoiDichVuService
    {
    private readonly ICSKH_DM_GoiDichVuRepository _CSKH_DM_GoiDichVuRepository;
    public CSKH_DM_GoiDichVuService(ICSKH_DM_GoiDichVuRepository CSKH_DM_GoiDichVuRepository) : base(CSKH_DM_GoiDichVuRepository)
    {
    _CSKH_DM_GoiDichVuRepository = CSKH_DM_GoiDichVuRepository;
    }
    }
    }

