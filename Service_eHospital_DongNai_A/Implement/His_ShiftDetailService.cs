namespace Service_eHospital_DongNai_A.Implement
{
    public class His_ShiftDetailService : BaseService<His_ShiftDetail, IHis_ShiftDetailRepository>
    , IHis_ShiftDetailService
    {
    private readonly IHis_ShiftDetailRepository _His_ShiftDetailRepository;
    public His_ShiftDetailService(IHis_ShiftDetailRepository His_ShiftDetailRepository) : base(His_ShiftDetailRepository)
    {
    _His_ShiftDetailRepository = His_ShiftDetailRepository;
    }
    }
    }

