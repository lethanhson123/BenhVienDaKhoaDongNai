namespace Service_eHospital_DongNai_A.Implement
{
    public class Duoc_SoLoNhap_GiaBanService : BaseService<Duoc_SoLoNhap_GiaBan, IDuoc_SoLoNhap_GiaBanRepository>
    , IDuoc_SoLoNhap_GiaBanService
    {
    private readonly IDuoc_SoLoNhap_GiaBanRepository _Duoc_SoLoNhap_GiaBanRepository;
    public Duoc_SoLoNhap_GiaBanService(IDuoc_SoLoNhap_GiaBanRepository Duoc_SoLoNhap_GiaBanRepository) : base(Duoc_SoLoNhap_GiaBanRepository)
    {
    _Duoc_SoLoNhap_GiaBanRepository = Duoc_SoLoNhap_GiaBanRepository;
    }
    }
    }

