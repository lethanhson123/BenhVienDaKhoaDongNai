namespace Service_eHospital_DongNai_A.Implement
{
    public class ShiftService : BaseService<Shift, IShiftRepository>
    , IShiftService
    {
    private readonly IShiftRepository _ShiftRepository;
    public ShiftService(IShiftRepository ShiftRepository) : base(ShiftRepository)
    {
    _ShiftRepository = ShiftRepository;
    }
    }
    }

