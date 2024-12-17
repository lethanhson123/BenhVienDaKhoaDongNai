import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucTinhThanhToaDo } from 'src/app/shared/DanhMucTinhThanhToaDo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucTinhThanhToaDoService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'DanhMucTinhThanhID', 'DanhMucQuanHuyenID', 'DanhMucXaPhuongID', 'DanhMucTinhThanhName', 'DanhMucQuanHuyenName', 'DanhMucXaPhuongName', 'KinhDo', 'ViDo'];
    List: DanhMucTinhThanhToaDo[] | undefined;
    ListFilter: DanhMucTinhThanhToaDo[] | undefined;
    FormData!: DanhMucTinhThanhToaDo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucTinhThanhToaDo";
    }

    GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync() {
        var lastUpdatedMembershipID = localStorage.getItem(environment.ThanhVienID);
        if (lastUpdatedMembershipID) {
            this.BaseParameter.ThanhVienID = Number(lastUpdatedMembershipID);
        }
        this.BaseParameter.Active = true;
        let url = this.APIURL + this.Controller + '/GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync() {
        var lastUpdatedMembershipID = localStorage.getItem(environment.ThanhVienID);
        if (lastUpdatedMembershipID) {
            this.BaseParameter.ThanhVienID = Number(lastUpdatedMembershipID);
        }
        this.BaseParameter.Active = true;
        let url = this.APIURL + this.Controller + '/GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

