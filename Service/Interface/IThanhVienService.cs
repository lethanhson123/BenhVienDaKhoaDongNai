namespace Service.Interface
{
    public interface IThanhVienService : IBaseService<ThanhVien>
    {
        Task<ThanhVien> AuthenticationAsync(ThanhVien model);
    }
}

