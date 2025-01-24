namespace Service_eHospital_DongNai_A.Implement
{
    public class ShiftDetailService : BaseService<ShiftDetail, IShiftDetailRepository>
    , IShiftDetailService
    {
    private readonly IShiftDetailRepository _ShiftDetailRepository;
    public ShiftDetailService(IShiftDetailRepository ShiftDetailRepository) : base(ShiftDetailRepository)
    {
    _ShiftDetailRepository = ShiftDetailRepository;
    }
    }
    }

