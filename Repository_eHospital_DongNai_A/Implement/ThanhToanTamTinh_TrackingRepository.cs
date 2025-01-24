namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThanhToanTamTinh_TrackingRepository : BaseRepository<ThanhToanTamTinh_Tracking>
    , IThanhToanTamTinh_TrackingRepository
    {
    private readonly Context _context;
    public ThanhToanTamTinh_TrackingRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

