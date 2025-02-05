namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TinhTrangQuanHeService : BaseService<NS_DM_TinhTrangQuanHe, INS_DM_TinhTrangQuanHeRepository>
    , INS_DM_TinhTrangQuanHeService
    {
    private readonly INS_DM_TinhTrangQuanHeRepository _NS_DM_TinhTrangQuanHeRepository;
    public NS_DM_TinhTrangQuanHeService(INS_DM_TinhTrangQuanHeRepository NS_DM_TinhTrangQuanHeRepository) : base(NS_DM_TinhTrangQuanHeRepository)
    {
    _NS_DM_TinhTrangQuanHeRepository = NS_DM_TinhTrangQuanHeRepository;
    }
    }
    }

