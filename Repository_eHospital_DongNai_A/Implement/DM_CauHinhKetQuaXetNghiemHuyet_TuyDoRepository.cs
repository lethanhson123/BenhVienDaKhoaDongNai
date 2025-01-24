namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository : BaseRepository<DM_CauHinhKetQuaXetNghiemHuyet_TuyDo>
    , IDM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository
    {
    private readonly Context _context;
    public DM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

