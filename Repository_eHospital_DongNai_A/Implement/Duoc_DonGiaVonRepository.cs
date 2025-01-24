namespace Repository_eHospital_DongNai_A.Implement
{
    public class Duoc_DonGiaVonRepository : BaseRepository<Duoc_DonGiaVon>
    , IDuoc_DonGiaVonRepository
    {
    private readonly Context _context;
    public Duoc_DonGiaVonRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

