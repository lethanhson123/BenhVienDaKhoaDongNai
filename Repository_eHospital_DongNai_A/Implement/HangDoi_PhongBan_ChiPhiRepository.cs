namespace Repository_eHospital_DongNai_A.Implement
{
    public class HangDoi_PhongBan_ChiPhiRepository : BaseRepository<HangDoi_PhongBan_ChiPhi>
    , IHangDoi_PhongBan_ChiPhiRepository
    {
    private readonly Context _context;
    public HangDoi_PhongBan_ChiPhiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

