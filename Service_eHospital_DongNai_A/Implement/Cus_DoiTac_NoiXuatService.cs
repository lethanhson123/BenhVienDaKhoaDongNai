namespace Service_eHospital_DongNai_A.Implement
{
    public class Cus_DoiTac_NoiXuatService : BaseService<Cus_DoiTac_NoiXuat, ICus_DoiTac_NoiXuatRepository>
    , ICus_DoiTac_NoiXuatService
    {
    private readonly ICus_DoiTac_NoiXuatRepository _Cus_DoiTac_NoiXuatRepository;
    public Cus_DoiTac_NoiXuatService(ICus_DoiTac_NoiXuatRepository Cus_DoiTac_NoiXuatRepository) : base(Cus_DoiTac_NoiXuatRepository)
    {
    _Cus_DoiTac_NoiXuatRepository = Cus_DoiTac_NoiXuatRepository;
    }
    }
    }

