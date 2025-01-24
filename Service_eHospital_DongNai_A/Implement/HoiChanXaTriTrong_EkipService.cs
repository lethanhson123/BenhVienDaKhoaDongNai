namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChanXaTriTrong_EkipService : BaseService<HoiChanXaTriTrong_Ekip, IHoiChanXaTriTrong_EkipRepository>
    , IHoiChanXaTriTrong_EkipService
    {
    private readonly IHoiChanXaTriTrong_EkipRepository _HoiChanXaTriTrong_EkipRepository;
    public HoiChanXaTriTrong_EkipService(IHoiChanXaTriTrong_EkipRepository HoiChanXaTriTrong_EkipRepository) : base(HoiChanXaTriTrong_EkipRepository)
    {
    _HoiChanXaTriTrong_EkipRepository = HoiChanXaTriTrong_EkipRepository;
    }
    }
    }

