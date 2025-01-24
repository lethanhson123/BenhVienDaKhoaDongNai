namespace Repository_eHospital_DongNai_A.Implement
{
    public class BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository : BaseRepository<BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_Data>
    , IBCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository
    {
    private readonly Context _context;
    public BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

