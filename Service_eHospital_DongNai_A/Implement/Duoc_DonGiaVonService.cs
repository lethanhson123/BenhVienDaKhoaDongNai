namespace Service_eHospital_DongNai_A.Implement
{
    public class Duoc_DonGiaVonService : BaseService<Duoc_DonGiaVon, IDuoc_DonGiaVonRepository>
    , IDuoc_DonGiaVonService
    {
    private readonly IDuoc_DonGiaVonRepository _Duoc_DonGiaVonRepository;
    public Duoc_DonGiaVonService(IDuoc_DonGiaVonRepository Duoc_DonGiaVonRepository) : base(Duoc_DonGiaVonRepository)
    {
    _Duoc_DonGiaVonRepository = Duoc_DonGiaVonRepository;
    }
    }
    }

