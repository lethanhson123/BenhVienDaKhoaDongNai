namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChanXaTriService : BaseService<HoiChanXaTri, IHoiChanXaTriRepository>
    , IHoiChanXaTriService
    {
    private readonly IHoiChanXaTriRepository _HoiChanXaTriRepository;
    public HoiChanXaTriService(IHoiChanXaTriRepository HoiChanXaTriRepository) : base(HoiChanXaTriRepository)
    {
    _HoiChanXaTriRepository = HoiChanXaTriRepository;
    }
    }
    }

