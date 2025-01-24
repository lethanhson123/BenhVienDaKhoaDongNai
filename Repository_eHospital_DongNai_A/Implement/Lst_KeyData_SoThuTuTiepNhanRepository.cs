namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_SoThuTuTiepNhanRepository : BaseRepository<Lst_KeyData_SoThuTuTiepNhan>
    , ILst_KeyData_SoThuTuTiepNhanRepository
    {
    private readonly Context _context;
    public Lst_KeyData_SoThuTuTiepNhanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

