namespace Repository_eHospital_DongNai_A.Implement
{
    public class Import_Lst_Dictionary_NgheNghiepRepository : BaseRepository<Import_Lst_Dictionary_NgheNghiep>
    , IImport_Lst_Dictionary_NgheNghiepRepository
    {
    private readonly Context _context;
    public Import_Lst_Dictionary_NgheNghiepRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

