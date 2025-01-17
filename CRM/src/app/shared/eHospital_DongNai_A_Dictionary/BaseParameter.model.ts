import { Base } from "./Base.model";
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

export class BaseParameter extends Base{      
    SearchString?: string;    
    Page?: number;
    PageSize?: number;     
    Dictionary_Type_Id?: number;        
    CapDonVi?: number;      
    CapTren_Id?: number;      
    TinhThanh_Id?: number;      
    QuanHuyen_Id?: number;      
    XaPhuong_Id?: number;      
    BenhNhan_Id?: number;      
}
