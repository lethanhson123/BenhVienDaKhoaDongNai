import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucQuocGia } from 'src/app/shared/DanhMucQuocGia.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucQuocGiaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'Code2', 'Code3', 'SoHieu', 'ThuDo', 'TienTe', 'TienTeCode', 'TienTeKyHieu', 'KhuVuc', 'MaDienThoai'];
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucQuocGia";
    }
}

