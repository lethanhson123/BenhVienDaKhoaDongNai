import { Base } from "./Base.model";
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

export class BaseParameter extends Base{      
    SearchString?: string;    
    Page?: number;
    PageSize?: number;     
    BenhAn_Id?: number;        
    PhongBan_Id?: number;      
    TiepNhan_Id?: number; 
    KhamBenh_Id?: number; 
    NgayVaoVien?: Date;            
    NgayTiepNhan?: Date;
    NgayKham?: Date;
    Note?: string;
}
