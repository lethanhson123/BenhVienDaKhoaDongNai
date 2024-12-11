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

    List: GoiSoChiTietPhongKham[] | undefined;
    ListFilter: GoiSoChiTietPhongKham[] | undefined;
    FormData!: GoiSoChiTietPhongKham;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GoiSoChiTietPhongKham";
    }
    SaveAsync() {        
        let url = this.APIURL + this.Controller + '/SaveAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.FormData));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

