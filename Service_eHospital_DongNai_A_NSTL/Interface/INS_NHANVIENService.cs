namespace Service_eHospital_DongNai_A_NSTL.Interface
{
    public interface INS_NHANVIENService : IBaseService<NS_NHANVIEN>
    {
        Task<NS_NHANVIEN> GetByNhanVien_IdAsync(int NhanVien_Id);
        Task<NS_NHANVIEN> GetByMaNhanVienAsync(string MaNhanVien);
    }
}

