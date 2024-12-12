import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThanhVienDichVu } from 'src/app/shared/ThanhVienDichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThanhVienDichVuService extends BaseService{
    //DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'ThanhVienUngDungID', 'DanhMucNgonNguName', 'ThanhVienUngDungName'];

    DisplayColumns001: string[] = ['STT', 'ID', 'Name', 'Active'];   
    DisplayColumns002: string[] = ['DanhMucThanhVienID', 'Save'];   
        
    List: ThanhVienDichVu[] | undefined;
    ListFilter: ThanhVienDichVu[] | undefined;
    FormData!: ThanhVienDichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThanhVienDichVu";
    }
    GetSQLByParentIDToListAsync() {
        let url = this.APIURL + this.Controller + '/GetSQLByParentIDToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}
