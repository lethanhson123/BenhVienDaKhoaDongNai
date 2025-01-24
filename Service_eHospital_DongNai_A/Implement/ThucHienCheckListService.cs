namespace Service_eHospital_DongNai_A.Implement
{
    public class ThucHienCheckListService : BaseService<ThucHienCheckList, IThucHienCheckListRepository>
    , IThucHienCheckListService
    {
    private readonly IThucHienCheckListRepository _ThucHienCheckListRepository;
    public ThucHienCheckListService(IThucHienCheckListRepository ThucHienCheckListRepository) : base(ThucHienCheckListRepository)
    {
    _ThucHienCheckListRepository = ThucHienCheckListRepository;
    }
    }
    }

