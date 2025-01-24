namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository : BaseRepository<ChanDoanTeBaoHocCoTuCungAmDao_KetQua>
    , IChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository
    {
    private readonly Context _context;
    public ChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

