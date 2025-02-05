namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_PhongBan_DinhSuatService : BaseService<NS_PhongBan_DinhSuat, INS_PhongBan_DinhSuatRepository>
    , INS_PhongBan_DinhSuatService
    {
    private readonly INS_PhongBan_DinhSuatRepository _NS_PhongBan_DinhSuatRepository;
    public NS_PhongBan_DinhSuatService(INS_PhongBan_DinhSuatRepository NS_PhongBan_DinhSuatRepository) : base(NS_PhongBan_DinhSuatRepository)
    {
    _NS_PhongBan_DinhSuatRepository = NS_PhongBan_DinhSuatRepository;
    }
    }
    }

