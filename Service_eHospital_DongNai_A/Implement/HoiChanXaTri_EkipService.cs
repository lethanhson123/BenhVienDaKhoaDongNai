namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChanXaTri_EkipService : BaseService<HoiChanXaTri_Ekip, IHoiChanXaTri_EkipRepository>
    , IHoiChanXaTri_EkipService
    {
    private readonly IHoiChanXaTri_EkipRepository _HoiChanXaTri_EkipRepository;
    public HoiChanXaTri_EkipService(IHoiChanXaTri_EkipRepository HoiChanXaTri_EkipRepository) : base(HoiChanXaTri_EkipRepository)
    {
    _HoiChanXaTri_EkipRepository = HoiChanXaTri_EkipRepository;
    }
    }
    }

