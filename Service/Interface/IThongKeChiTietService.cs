namespace Service.Interface
{
    public interface IThongKeChiTietService : IBaseService<ThongKeChiTiet>
    {
        Task<List<ThongKeChiTiet>> ReportAToaThuoc_MinhToListAsync(DateTime BatDau, DateTime KetThuc, string MaDuoc);
    }
}

