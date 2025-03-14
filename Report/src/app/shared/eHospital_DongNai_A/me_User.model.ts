import { Base } from "./Base.model";

export class me_User extends Base{
User_id?: number;
User_Code?: string;
User_Name?: string;
Pass?: string;
User_Level?: number;
NgayTao?: Date;
NgayDieuChinh?: Date;
IsLocked?: boolean;

}


