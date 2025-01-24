namespace Service_eHospital_DongNai_A.Implement
{
    public class Zzz_Excel_ListBN_HuyetApService : BaseService<Zzz_Excel_ListBN_HuyetAp, IZzz_Excel_ListBN_HuyetApRepository>
    , IZzz_Excel_ListBN_HuyetApService
    {
    private readonly IZzz_Excel_ListBN_HuyetApRepository _Zzz_Excel_ListBN_HuyetApRepository;
    public Zzz_Excel_ListBN_HuyetApService(IZzz_Excel_ListBN_HuyetApRepository Zzz_Excel_ListBN_HuyetApRepository) : base(Zzz_Excel_ListBN_HuyetApRepository)
    {
    _Zzz_Excel_ListBN_HuyetApRepository = Zzz_Excel_ListBN_HuyetApRepository;
    }
    }
    }

