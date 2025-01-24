namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChanXaTriTrongService : BaseService<HoiChanXaTriTrong, IHoiChanXaTriTrongRepository>
    , IHoiChanXaTriTrongService
    {
    private readonly IHoiChanXaTriTrongRepository _HoiChanXaTriTrongRepository;
    public HoiChanXaTriTrongService(IHoiChanXaTriTrongRepository HoiChanXaTriTrongRepository) : base(HoiChanXaTriTrongRepository)
    {
    _HoiChanXaTriTrongRepository = HoiChanXaTriTrongRepository;
    }
    }
    }

