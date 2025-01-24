namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_NoiTru_XuatLaiXMLRepository : BaseRepository<zzz_NoiTru_XuatLaiXML>
    , Izzz_NoiTru_XuatLaiXMLRepository
    {
    private readonly Context _context;
    public zzz_NoiTru_XuatLaiXMLRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

