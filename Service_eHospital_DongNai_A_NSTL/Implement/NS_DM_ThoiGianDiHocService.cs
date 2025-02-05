namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_ThoiGianDiHocService : BaseService<NS_DM_ThoiGianDiHoc, INS_DM_ThoiGianDiHocRepository>
    , INS_DM_ThoiGianDiHocService
    {
    private readonly INS_DM_ThoiGianDiHocRepository _NS_DM_ThoiGianDiHocRepository;
    public NS_DM_ThoiGianDiHocService(INS_DM_ThoiGianDiHocRepository NS_DM_ThoiGianDiHocRepository) : base(NS_DM_ThoiGianDiHocRepository)
    {
    _NS_DM_ThoiGianDiHocRepository = NS_DM_ThoiGianDiHocRepository;
    }
    }
    }

