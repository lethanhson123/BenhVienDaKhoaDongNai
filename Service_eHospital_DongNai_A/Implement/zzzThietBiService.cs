namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzThietBiService : BaseService<zzzThietBi, IzzzThietBiRepository>
    , IzzzThietBiService
    {
    private readonly IzzzThietBiRepository _zzzThietBiRepository;
    public zzzThietBiService(IzzzThietBiRepository zzzThietBiRepository) : base(zzzThietBiRepository)
    {
    _zzzThietBiRepository = zzzThietBiRepository;
    }
    }
    }

