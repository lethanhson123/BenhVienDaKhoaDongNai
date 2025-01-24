namespace Repository_eHospital_DongNai_A.Implement
{
    public class YTDP_KetQuaRepository : BaseRepository<YTDP_KetQua>
    , IYTDP_KetQuaRepository
    {
    private readonly Context _context;
    public YTDP_KetQuaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

