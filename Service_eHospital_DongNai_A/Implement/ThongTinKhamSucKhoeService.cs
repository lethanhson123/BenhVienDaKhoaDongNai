namespace Service_eHospital_DongNai_A.Implement
{
    public class ThongTinKhamSucKhoeService : BaseService<ThongTinKhamSucKhoe, IThongTinKhamSucKhoeRepository>
    , IThongTinKhamSucKhoeService
    {
    private readonly IThongTinKhamSucKhoeRepository _ThongTinKhamSucKhoeRepository;
    public ThongTinKhamSucKhoeService(IThongTinKhamSucKhoeRepository ThongTinKhamSucKhoeRepository) : base(ThongTinKhamSucKhoeRepository)
    {
    _ThongTinKhamSucKhoeRepository = ThongTinKhamSucKhoeRepository;
    }
    }
    }

