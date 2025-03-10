﻿namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_UserMenusService : BaseService<Sys_UserMenus, ISys_UserMenusRepository>
    , ISys_UserMenusService
    {
        private readonly ISys_UserMenusRepository _Sys_UserMenusRepository;

        private readonly ISys_MenusRepository _Sys_MenusRepository;
        public Sys_UserMenusService(ISys_UserMenusRepository Sys_UserMenusRepository

            , ISys_MenusRepository sys_MenusRepository

         ) : base(Sys_UserMenusRepository)
        {
            _Sys_UserMenusRepository = Sys_UserMenusRepository;
            _Sys_MenusRepository = sys_MenusRepository;
        }
        public virtual async Task<List<Sys_UserMenus>> GetByUser_Id_SearchStringToListAsync(int User_Id, string searchString)
        {
            List<Sys_UserMenus> result = new List<Sys_UserMenus>();
            if (User_Id > 0)
            {
                result = await GetByCondition(item => item.User_Id == User_Id).ToListAsync();
                if (!string.IsNullOrEmpty(searchString))
                {
                    List<Sys_Menus> ListSys_Menus = await _Sys_MenusRepository.GetByCondition(item => item.Menu_Name.Contains(searchString) || item.Menu_Code.Contains(searchString)).ToListAsync();
                    if (ListSys_Menus == null)
                    {
                        ListSys_Menus = new List<Sys_Menus>();
                    }
                    List<int> ListSys_MenusID = ListSys_Menus.Select(item => item.Menu_Id.Value).ToList();
                    if (ListSys_MenusID.Count > 0)
                    {
                        result = result.Where(item => ListSys_MenusID.Contains(item.Menu_Id.Value)).ToList();
                    }
                }
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_UserMenus>();
            }
            return result;
        }
        public virtual async Task<List<Sys_UserMenus>> GetByUser_Id_SearchStringAndEmptyToListAsync(int User_Id, string searchString)
        {
            List<Sys_UserMenus> result = new List<Sys_UserMenus>();
            Sys_UserMenus empty = new Sys_UserMenus();
            result.Add(empty);
            List<Sys_UserMenus> list = await GetByUser_Id_SearchStringToListAsync(User_Id, searchString);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
        public virtual async Task<List<Sys_UserMenus>> GetByUser_IdToListAsync(int User_Id)
        {
            List<Sys_UserMenus> result = new List<Sys_UserMenus>();
            if (User_Id > 0)
            {
                result = await GetByCondition(item => item.User_Id == User_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_UserMenus>();
            }
            return result;
        }
        public virtual async Task<List<Sys_UserMenus>> GetByUser_IdAndEmptyToListAsync(int User_Id)
        {
            List<Sys_UserMenus> result = new List<Sys_UserMenus>();
            Sys_UserMenus empty = new Sys_UserMenus();
            result.Add(empty);
            List<Sys_UserMenus> list = await GetByUser_IdToListAsync(User_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

