namespace Repository_eHospital_DongNai_A.Implement
{
    public class Duoc_SoLoNhap_GiaBanRepository : BaseRepository<Duoc_SoLoNhap_GiaBan>
    , IDuoc_SoLoNhap_GiaBanRepository
    {
    private readonly Context _context;
    public Duoc_SoLoNhap_GiaBanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

