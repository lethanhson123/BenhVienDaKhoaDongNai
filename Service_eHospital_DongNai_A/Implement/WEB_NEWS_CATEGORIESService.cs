namespace Service_eHospital_DongNai_A.Implement
{
    public class WEB_NEWS_CATEGORIESService : BaseService<WEB_NEWS_CATEGORIES, IWEB_NEWS_CATEGORIESRepository>
    , IWEB_NEWS_CATEGORIESService
    {
    private readonly IWEB_NEWS_CATEGORIESRepository _WEB_NEWS_CATEGORIESRepository;
    public WEB_NEWS_CATEGORIESService(IWEB_NEWS_CATEGORIESRepository WEB_NEWS_CATEGORIESRepository) : base(WEB_NEWS_CATEGORIESRepository)
    {
    _WEB_NEWS_CATEGORIESRepository = WEB_NEWS_CATEGORIESRepository;
    }
    }
    }

