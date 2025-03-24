namespace Service_eHospital_DongNai_A.Interface
{
    public interface IKhamBenh_SinhHieuService : IBaseService<KhamBenh_SinhHieu>
    {
        Task<List<KhamBenh_SinhHieu>> GetByBenhNhan_IdToListAsync(int BenhNhan_Id);
    }
}

