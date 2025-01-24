namespace Repository_eHospital_DongNai_A.Implement
{
    public class Import_DM_ICD_YHCT_Chuong_NhomRepository : BaseRepository<Import_DM_ICD_YHCT_Chuong_Nhom>
    , IImport_DM_ICD_YHCT_Chuong_NhomRepository
    {
    private readonly Context _context;
    public Import_DM_ICD_YHCT_Chuong_NhomRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

