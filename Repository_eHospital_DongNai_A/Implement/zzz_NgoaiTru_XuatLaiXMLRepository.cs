namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_NgoaiTru_XuatLaiXMLRepository : BaseRepository<zzz_NgoaiTru_XuatLaiXML>
    , Izzz_NgoaiTru_XuatLaiXMLRepository
    {
    private readonly Context _context;
    public zzz_NgoaiTru_XuatLaiXMLRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

