namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_LichCongTac_KetQuaRepository : BaseRepository<CDT_LichCongTac_KetQua>
    , ICDT_LichCongTac_KetQuaRepository
    {
    private readonly Context _context;
    public CDT_LichCongTac_KetQuaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

