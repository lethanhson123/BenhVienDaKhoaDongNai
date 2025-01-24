namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocGiaVonService : BaseService<DuocGiaVon, IDuocGiaVonRepository>
    , IDuocGiaVonService
    {
    private readonly IDuocGiaVonRepository _DuocGiaVonRepository;
    public DuocGiaVonService(IDuocGiaVonRepository DuocGiaVonRepository) : base(DuocGiaVonRepository)
    {
    _DuocGiaVonRepository = DuocGiaVonRepository;
    }
    }
    }

