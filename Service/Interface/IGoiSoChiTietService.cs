namespace Service.Interface
{
    public interface IGoiSoChiTietService : IBaseService<GoiSoChiTiet>
    {
        Task<GoiSoChiTiet> UpdateByDanhMucDichVuID_NgayDangKySoThuTuTu_CodeAsync(long DanhMucDichVuID, int NgayDangKySoThuTu, string Code);
        Task<GoiSoChiTiet> GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync(long DanhMucDichVuID, int NgayCapSoSoThuTu);
        Task<GoiSoChiTiet> GetByDanhMucPhongKhamID_NgayCapSoSoThuTuAsync(long DanhMucPhongKhamID, int NgayCapSoSoThuTu);
        Task<GoiSoChiTiet> GetNgayCapSoSoThuTuStringToAsync(string NgayCapSoSoThuTuString);
        Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy01ToListAsync();
        Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02ToListAsync(List<long> ListDanhMucQuayDichVuID);
        Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02_001ToListAsync(string SearchString);
        Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02_002ToListAsync(string SearchString);
        Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy03ToListAsync(long DanhMucQuayDichVuID, long DanhMucDichVuID, int Number);
        Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy04ToListAsync(long DanhMucQuayDichVuID, int Number);        
        Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy04_001ToListAsync(string Code, int Number);
        Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy05ToListAsync(long DanhMucPhongKhamID, int Number);
        Task<List<GoiSoChiTiet>> GetGoiSoChiTietTiepNhan04_001ToListAsync(string Code, int Number);
        Task<List<GoiSoChiTiet>> GetByKhachHangIDToListAsync(long KhachHangID);
        Task<List<GoiSoChiTiet>> GetGoiSoChiTietTiepNhan05ToListAsync(int GroupOrder, int Number);
        Task<List<GoiSoChiTiet>> GetGoiSoChiTietTiepNhan06ToListAsync(long DanhMucQuayDichVuID, int Number);        
    }
}

