namespace Service_eHospital_DongNai_A.Implement
{
    public class ThanhToanTamTinh_TrackingService : BaseService<ThanhToanTamTinh_Tracking, IThanhToanTamTinh_TrackingRepository>
    , IThanhToanTamTinh_TrackingService
    {
    private readonly IThanhToanTamTinh_TrackingRepository _ThanhToanTamTinh_TrackingRepository;
    public ThanhToanTamTinh_TrackingService(IThanhToanTamTinh_TrackingRepository ThanhToanTamTinh_TrackingRepository) : base(ThanhToanTamTinh_TrackingRepository)
    {
    _ThanhToanTamTinh_TrackingRepository = ThanhToanTamTinh_TrackingRepository;
    }
    }
    }

