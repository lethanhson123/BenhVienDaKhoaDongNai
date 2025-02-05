namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LyDoNghiViecService : BaseService<NS_DM_LyDoNghiViec, INS_DM_LyDoNghiViecRepository>
    , INS_DM_LyDoNghiViecService
    {
    private readonly INS_DM_LyDoNghiViecRepository _NS_DM_LyDoNghiViecRepository;
    public NS_DM_LyDoNghiViecService(INS_DM_LyDoNghiViecRepository NS_DM_LyDoNghiViecRepository) : base(NS_DM_LyDoNghiViecRepository)
    {
    _NS_DM_LyDoNghiViecRepository = NS_DM_LyDoNghiViecRepository;
    }
    }
    }

