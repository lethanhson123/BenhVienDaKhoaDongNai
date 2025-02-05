namespace Service.Interface
{
    public interface IDanhMucQuayDichVuService : IBaseService<DanhMucQuayDichVu>
    {
        Task<List<DanhMucQuayDichVu>> KhoiPhucAsync();
    }
}

