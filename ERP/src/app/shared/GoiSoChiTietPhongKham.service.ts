import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GoiSoChiTietPhongKham } from 'src/app/shared/GoiSoChiTietPhongKham.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GoiSoChiTietPhongKhamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucPhongKhamID', 'DanhMucPhongKhamName', 'DanhMucPhongKhamCode'];
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GoiSoChiTietPhongKham";
    }
}

