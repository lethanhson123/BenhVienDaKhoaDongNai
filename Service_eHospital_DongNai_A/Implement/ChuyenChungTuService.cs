namespace Service_eHospital_DongNai_A.Implement
{
    public class ChuyenChungTuService : BaseService<ChuyenChungTu, IChuyenChungTuRepository>
    , IChuyenChungTuService
    {
    private readonly IChuyenChungTuRepository _ChuyenChungTuRepository;
    public ChuyenChungTuService(IChuyenChungTuRepository ChuyenChungTuRepository) : base(ChuyenChungTuRepository)
    {
    _ChuyenChungTuRepository = ChuyenChungTuRepository;
    }
    }
    }

