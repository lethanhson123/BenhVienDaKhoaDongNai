namespace Repository_eHospital_DongNai_A.Implement
{
    public class Duoc_SoLoNhap_GiaBan_Delete20230518Repository : BaseRepository<Duoc_SoLoNhap_GiaBan_Delete20230518>
    , IDuoc_SoLoNhap_GiaBan_Delete20230518Repository
    {
    private readonly Context _context;
    public Duoc_SoLoNhap_GiaBan_Delete20230518Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

