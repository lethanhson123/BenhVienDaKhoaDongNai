namespace Repository_eHospital_DongNai_A.Implement
{
    public class Duoc_DuTruChiTietRepository : BaseRepository<Duoc_DuTruChiTiet>
    , IDuoc_DuTruChiTietRepository
    {
    private readonly Context _context;
    public Duoc_DuTruChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

