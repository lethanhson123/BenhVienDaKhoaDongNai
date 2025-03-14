import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucDichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName'];
    DisplayColumns02: string[] = ['STT', 'ID', 'Name', 'Code', 'Display', 'Note', 'SortOrder', 'Active', 'Save'];
    DisplayColumns03: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Code', 'Note', 'SortOrder', 'IsBHYT', 'Active', 'Save'];
    DisplayColumns04: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Code', 'Note', 'SortOrder', 'IsBHYT', 'IsHangDoiPhanNhanh', 'Active', 'Save'];
    DisplayColumns05: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Display', 'Code', 'Note', 'SortOrder', 'IsBHYT', 'IsHangDoiPhanNhanh', 'Active', 'Save'];
    DisplayColumns06: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Display', 'Code', 'Note', 'BuocNhay', 'GroupOrder', 'SortOrder', 'IsBHYT', 'IsHangDoiPhanNhanh', 'Active', 'Save'];
    DisplayColumns07: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Display', 'Code', 'Note', 'BuocNhay', 'GroupOrder', 'DanhMucNgonNguID', 'DanhMucNgonNguName', 'SortOrder', 'IsBHYT', 'IsHangDoiPhanNhanh', 'Active', 'Save'];
    DisplayColumns08: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Display', 'Code', 'Note', 'BuocNhay', 'GroupOrder', 'DanhMucNgonNguID', 'DanhMucNgonNguName', 'TypeName', 'Description', 'SortOrder', 'IsBHYT', 'IsHangDoiPhanNhanh', 'Active', 'Save'];

    List: DanhMucDichVu[] | undefined;
    ListFilter: DanhMucDichVu[] | undefined;
    FormData!: DanhMucDichVu;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucDichVu";
    }
    GetByThanhVienID_ActiveToListAsync() {
        var lastUpdatedMembershipID = localStorage.getItem(environment.ThanhVienID);
        if (lastUpdatedMembershipID) {
            this.BaseParameter.ThanhVienID = Number(lastUpdatedMembershipID);
        }
        this.BaseParameter.Active = true;
        let url = this.APIURL + this.Controller + '/GetByThanhVienID_ActiveToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    KhoiPhucAsync() {
        let url = this.APIURL + this.Controller + '/KhoiPhucAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

