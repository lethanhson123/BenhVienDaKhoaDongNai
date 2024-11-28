import { Base } from "./Base.model";
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

export class BaseParameter extends Base{   
    ListID?: number[];
    SearchString?: string;
    Token?: string;
    IDString?: string;
    Password01?: string;
    Password02?: string;
    Password03?: string;
    TaiKhoan?: string;
    SoQuyetDinh?: string;    
    Page?: number;
    PageSize?: number;    
    ThanhVienID?: number;    
    DanhMucUngDungID?: number;    
    DanhMucChucNangID?: number;    
    Nam?: number;
    Thang?: number;
    NgayGhiNhan?: Date;
    BatDau?: Date;
    KetThuc?: Date;  
    DanhMucDichVuID?: number;    
    DanhMucQuayDichVuID?: number;    
    DuAnQuyetDinhID?: number;    
    SoHienTai?: number;    
    NgayCapSoSoThuTu?: number;    
    Number?: number;    
}
