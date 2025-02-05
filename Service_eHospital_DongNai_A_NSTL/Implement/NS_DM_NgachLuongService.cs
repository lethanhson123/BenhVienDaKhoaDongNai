namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_NgachLuongService : BaseService<NS_DM_NgachLuong, INS_DM_NgachLuongRepository>
    , INS_DM_NgachLuongService
    {
    private readonly INS_DM_NgachLuongRepository _NS_DM_NgachLuongRepository;
    public NS_DM_NgachLuongService(INS_DM_NgachLuongRepository NS_DM_NgachLuongRepository) : base(NS_DM_NgachLuongRepository)
    {
    _NS_DM_NgachLuongRepository = NS_DM_NgachLuongRepository;
    }
    }
    }

