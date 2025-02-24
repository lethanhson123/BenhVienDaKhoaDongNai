import { Base } from "./Base.model";
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

export class BaseParameter extends Base{      
    SearchString?: string;    
    Page?: number;
    PageSize?: number;     
    User_Id?: number;        
    Group_Code?: string;      
    IsSoNgayDuyetThuoc?: boolean; 
    IsVienPhiNgoaiTru?: boolean;     
}
