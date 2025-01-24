namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhNhan_Di_UngThuocRepository : BaseRepository<BenhNhan_Di_UngThuoc>
    , IBenhNhan_Di_UngThuocRepository
    {
    private readonly Context _context;
    public BenhNhan_Di_UngThuocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

