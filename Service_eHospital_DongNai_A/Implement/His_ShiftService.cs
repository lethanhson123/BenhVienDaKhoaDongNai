namespace Service_eHospital_DongNai_A.Implement
{
    public class His_ShiftService : BaseService<His_Shift, IHis_ShiftRepository>
    , IHis_ShiftService
    {
    private readonly IHis_ShiftRepository _His_ShiftRepository;
    public His_ShiftService(IHis_ShiftRepository His_ShiftRepository) : base(His_ShiftRepository)
    {
    _His_ShiftRepository = His_ShiftRepository;
    }
    }
    }

