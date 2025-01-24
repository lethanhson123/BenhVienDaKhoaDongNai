namespace Service_eHospital_DongNai_A.Implement
{
    public class Cus_NoiXuatService : BaseService<Cus_NoiXuat, ICus_NoiXuatRepository>
    , ICus_NoiXuatService
    {
    private readonly ICus_NoiXuatRepository _Cus_NoiXuatRepository;
    public Cus_NoiXuatService(ICus_NoiXuatRepository Cus_NoiXuatRepository) : base(Cus_NoiXuatRepository)
    {
    _Cus_NoiXuatRepository = Cus_NoiXuatRepository;
    }
    }
    }

