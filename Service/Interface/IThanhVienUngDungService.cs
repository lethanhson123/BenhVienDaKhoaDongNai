namespace Service.Interface
{
    public interface IThanhVienUngDungService : IBaseService<ThanhVienUngDung>
    {
        Task<List<ThanhVienUngDung>> GetSQLByParentIDToListAsync(long ParentID);
    }
}

