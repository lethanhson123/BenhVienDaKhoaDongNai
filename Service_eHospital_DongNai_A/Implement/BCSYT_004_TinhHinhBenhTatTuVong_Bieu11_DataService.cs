namespace Service_eHospital_DongNai_A.Implement
{
    public class BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService : BaseService<BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_Data, IBCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository>
    , IBCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService
    {
    private readonly IBCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository _BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository;
    public BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService(IBCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository) : base(BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository)
    {
    _BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository = BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataRepository;
    }
    }
    }

