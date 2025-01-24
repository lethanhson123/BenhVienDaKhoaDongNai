namespace Repository_eHospital_DongNai_A.Implement
{
    public class PhieuChanDoanHoaMoMienDichRepository : BaseRepository<PhieuChanDoanHoaMoMienDich>
    , IPhieuChanDoanHoaMoMienDichRepository
    {
    private readonly Context _context;
    public PhieuChanDoanHoaMoMienDichRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

