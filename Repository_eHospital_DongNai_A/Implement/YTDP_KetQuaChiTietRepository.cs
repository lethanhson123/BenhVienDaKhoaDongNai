namespace Repository_eHospital_DongNai_A.Implement
{
    public class YTDP_KetQuaChiTietRepository : BaseRepository<YTDP_KetQuaChiTiet>
    , IYTDP_KetQuaChiTietRepository
    {
    private readonly Context _context;
    public YTDP_KetQuaChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

