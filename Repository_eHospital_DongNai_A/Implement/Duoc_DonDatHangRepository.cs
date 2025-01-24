namespace Repository_eHospital_DongNai_A.Implement
{
    public class Duoc_DonDatHangRepository : BaseRepository<Duoc_DonDatHang>
    , IDuoc_DonDatHangRepository
    {
    private readonly Context _context;
    public Duoc_DonDatHangRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

