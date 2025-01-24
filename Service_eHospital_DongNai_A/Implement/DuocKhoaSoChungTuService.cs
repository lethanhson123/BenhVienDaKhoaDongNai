namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocKhoaSoChungTuService : BaseService<DuocKhoaSoChungTu, IDuocKhoaSoChungTuRepository>
    , IDuocKhoaSoChungTuService
    {
    private readonly IDuocKhoaSoChungTuRepository _DuocKhoaSoChungTuRepository;
    public DuocKhoaSoChungTuService(IDuocKhoaSoChungTuRepository DuocKhoaSoChungTuRepository) : base(DuocKhoaSoChungTuRepository)
    {
    _DuocKhoaSoChungTuRepository = DuocKhoaSoChungTuRepository;
    }
    }
    }

