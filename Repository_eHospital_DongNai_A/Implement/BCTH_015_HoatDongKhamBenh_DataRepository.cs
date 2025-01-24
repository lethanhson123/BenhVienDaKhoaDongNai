namespace Repository_eHospital_DongNai_A.Implement
{
    public class BCTH_015_HoatDongKhamBenh_DataRepository : BaseRepository<BCTH_015_HoatDongKhamBenh_Data>
    , IBCTH_015_HoatDongKhamBenh_DataRepository
    {
    private readonly Context _context;
    public BCTH_015_HoatDongKhamBenh_DataRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

