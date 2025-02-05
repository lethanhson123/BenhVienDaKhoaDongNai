namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_DinhSuatService : BaseService<NS_DM_DinhSuat, INS_DM_DinhSuatRepository>
    , INS_DM_DinhSuatService
    {
    private readonly INS_DM_DinhSuatRepository _NS_DM_DinhSuatRepository;
    public NS_DM_DinhSuatService(INS_DM_DinhSuatRepository NS_DM_DinhSuatRepository) : base(NS_DM_DinhSuatRepository)
    {
    _NS_DM_DinhSuatRepository = NS_DM_DinhSuatRepository;
    }
    }
    }

