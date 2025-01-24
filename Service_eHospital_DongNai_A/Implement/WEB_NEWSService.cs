namespace Service_eHospital_DongNai_A.Implement
{
    public class WEB_NEWSService : BaseService<WEB_NEWS, IWEB_NEWSRepository>
    , IWEB_NEWSService
    {
    private readonly IWEB_NEWSRepository _WEB_NEWSRepository;
    public WEB_NEWSService(IWEB_NEWSRepository WEB_NEWSRepository) : base(WEB_NEWSRepository)
    {
    _WEB_NEWSRepository = WEB_NEWSRepository;
    }
    }
    }

