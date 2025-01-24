namespace Service_eHospital_DongNai_A.Implement
{
    public class me_MenuListService : BaseService<me_MenuList, Ime_MenuListRepository>
    , Ime_MenuListService
    {
    private readonly Ime_MenuListRepository _me_MenuListRepository;
    public me_MenuListService(Ime_MenuListRepository me_MenuListRepository) : base(me_MenuListRepository)
    {
    _me_MenuListRepository = me_MenuListRepository;
    }
    }
    }

