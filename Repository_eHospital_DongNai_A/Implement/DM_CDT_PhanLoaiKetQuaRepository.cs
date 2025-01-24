namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_CDT_PhanLoaiKetQuaRepository : BaseRepository<DM_CDT_PhanLoaiKetQua>
    , IDM_CDT_PhanLoaiKetQuaRepository
    {
    private readonly Context _context;
    public DM_CDT_PhanLoaiKetQuaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

