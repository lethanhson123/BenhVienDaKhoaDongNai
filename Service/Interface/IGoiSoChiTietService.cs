namespace Service.Interface
{
    public interface IGoiSoChiTietService : IBaseService<GoiSoChiTiet>
    {
        Task<GoiSoChiTiet> GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync(long DanhMucDichVuID, int NgayCapSoSoThuTu);
        Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy01ToListAsync();
        Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02ToListAsync(List<long> ListDanhMucQuayDichVuID);
        Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy03ToListAsync(long DanhMucQuayDichVuID, long DanhMucDichVuID, int Number);
    }
}

