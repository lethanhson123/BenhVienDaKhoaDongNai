namespace Repository_eHospital_DongNai_A.Implement
{
    public class BCTH_018_DieuTri_NoiTru_DataRepository : BaseRepository<BCTH_018_DieuTri_NoiTru_Data>
    , IBCTH_018_DieuTri_NoiTru_DataRepository
    {
    private readonly Context _context;
    public BCTH_018_DieuTri_NoiTru_DataRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

