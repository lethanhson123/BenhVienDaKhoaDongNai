namespace Service_eHospital_DongNai_A.Implement
{
    public class me_AppListService : BaseService<me_AppList, Ime_AppListRepository>
    , Ime_AppListService
    {
    private readonly Ime_AppListRepository _me_AppListRepository;
    public me_AppListService(Ime_AppListRepository me_AppListRepository) : base(me_AppListRepository)
    {
    _me_AppListRepository = me_AppListRepository;
    }
    }
    }

