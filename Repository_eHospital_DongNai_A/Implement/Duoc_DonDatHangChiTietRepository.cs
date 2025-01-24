namespace Repository_eHospital_DongNai_A.Implement
{
    public class Duoc_DonDatHangChiTietRepository : BaseRepository<Duoc_DonDatHangChiTiet>
    , IDuoc_DonDatHangChiTietRepository
    {
    private readonly Context _context;
    public Duoc_DonDatHangChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

