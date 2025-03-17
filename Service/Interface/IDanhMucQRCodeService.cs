namespace Service.Interface
{
    public interface IDanhMucQRCodeService : IBaseService<DanhMucQRCode>
    {
        Task<List<DanhMucQRCode>> GetByNumberToListAsync(int Number);
    }
}

