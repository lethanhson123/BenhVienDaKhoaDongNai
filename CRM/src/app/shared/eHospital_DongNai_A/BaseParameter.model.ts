import { Base } from "./Base.model";
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

export class BaseParameter extends Base{    
    ListYear?: number[];  
    ListMonth?: number[];  
    ListIDString?: string[];  
    IsSearchAPI?: boolean;  
    BatDau?: Date;    
    KetThuc?: Date;    
    SearchString?: string;    
    Page?: number;
    PageSize?: number;     
    BenhAn_Id?: number;        
    PhongBan_Id?: number;      
    TiepNhan_Id?: number; 
    KhamBenh_Id?: number; 
    KhamBenhVaoVien_Id?: number; 
    KhamBenh_ToaThuoc_Id?: number; 
    ChungTu_Id?: number;
    NgayVaoVien?: Date;            
    NgayTiepNhan?: Date;
    NgayKham?: Date;
    NgayToaThuoc?: Date;
    NgayChungTu?: Date;
    Note?: string;
    Note001?: string;
    Year?: number;
    Month?: number;
    Day?: number;
}
