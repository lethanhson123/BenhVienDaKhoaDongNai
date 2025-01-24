namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzBS_KhamTrungService : BaseService<zzzBS_KhamTrung, IzzzBS_KhamTrungRepository>
    , IzzzBS_KhamTrungService
    {
    private readonly IzzzBS_KhamTrungRepository _zzzBS_KhamTrungRepository;
    public zzzBS_KhamTrungService(IzzzBS_KhamTrungRepository zzzBS_KhamTrungRepository) : base(zzzBS_KhamTrungRepository)
    {
    _zzzBS_KhamTrungRepository = zzzBS_KhamTrungRepository;
    }
    }
    }

