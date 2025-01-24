namespace Service_eHospital_DongNai_A.Implement
{
    public class Duoc_DonDatHangService : BaseService<Duoc_DonDatHang, IDuoc_DonDatHangRepository>
    , IDuoc_DonDatHangService
    {
    private readonly IDuoc_DonDatHangRepository _Duoc_DonDatHangRepository;
    public Duoc_DonDatHangService(IDuoc_DonDatHangRepository Duoc_DonDatHangRepository) : base(Duoc_DonDatHangRepository)
    {
    _Duoc_DonDatHangRepository = Duoc_DonDatHangRepository;
    }
    }
    }

