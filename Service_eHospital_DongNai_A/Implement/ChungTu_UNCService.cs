namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTu_UNCService : BaseService<ChungTu_UNC, IChungTu_UNCRepository>
    , IChungTu_UNCService
    {
    private readonly IChungTu_UNCRepository _ChungTu_UNCRepository;
    public ChungTu_UNCService(IChungTu_UNCRepository ChungTu_UNCRepository) : base(ChungTu_UNCRepository)
    {
    _ChungTu_UNCRepository = ChungTu_UNCRepository;
    }
    }
    }

