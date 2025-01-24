namespace Service_eHospital_DongNai_A.Implement
{
    public class BCTH_015_HoatDongKhamBenh_DataService : BaseService<BCTH_015_HoatDongKhamBenh_Data, IBCTH_015_HoatDongKhamBenh_DataRepository>
    , IBCTH_015_HoatDongKhamBenh_DataService
    {
    private readonly IBCTH_015_HoatDongKhamBenh_DataRepository _BCTH_015_HoatDongKhamBenh_DataRepository;
    public BCTH_015_HoatDongKhamBenh_DataService(IBCTH_015_HoatDongKhamBenh_DataRepository BCTH_015_HoatDongKhamBenh_DataRepository) : base(BCTH_015_HoatDongKhamBenh_DataRepository)
    {
    _BCTH_015_HoatDongKhamBenh_DataRepository = BCTH_015_HoatDongKhamBenh_DataRepository;
    }
    }
    }

