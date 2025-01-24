namespace Service_eHospital_DongNai_A.Implement
{
    public class Duoc_KiemKeService : BaseService<Duoc_KiemKe, IDuoc_KiemKeRepository>
    , IDuoc_KiemKeService
    {
    private readonly IDuoc_KiemKeRepository _Duoc_KiemKeRepository;
    public Duoc_KiemKeService(IDuoc_KiemKeRepository Duoc_KiemKeRepository) : base(Duoc_KiemKeRepository)
    {
    _Duoc_KiemKeRepository = Duoc_KiemKeRepository;
    }
    }
    }

