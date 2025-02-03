namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_BangGiaService : IBaseService<DM_BangGia>
    {
        Task<DM_BangGia> GetByBangGia_IdAsync(int BangGia_Id);
    }
}

