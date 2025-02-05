namespace Service.Interface
{
    public interface IDanhMucKhuVucService : IBaseService<DanhMucKhuVuc>
    {
        Task<List<DanhMucKhuVuc>> KhoiPhucAsync();
    }
    }

