namespace Service.Implement
{
    public class ToChucTaiKhoanService : BaseService<ToChucTaiKhoan, IToChucTaiKhoanRepository>
    , IToChucTaiKhoanService
    {
    private readonly IToChucTaiKhoanRepository _ToChucTaiKhoanRepository;
    public ToChucTaiKhoanService(IToChucTaiKhoanRepository ToChucTaiKhoanRepository) : base(ToChucTaiKhoanRepository)
    {
    _ToChucTaiKhoanRepository = ToChucTaiKhoanRepository;
    }
    }
    }

