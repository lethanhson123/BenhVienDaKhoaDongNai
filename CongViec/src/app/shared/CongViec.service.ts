import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CongViec } from 'src/app/shared/CongViec.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CongViecService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'NgayYeuCau', 'Name', 'ThanhVienYeuCauName', 'ThanhVienGiaiQuyetName', 'DanhMucTinhTrangName', 'Save'];
        
    List: CongViec[] | undefined;
    ListFilter: CongViec[] | undefined;
    FormData!: CongViec;
    

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CongViec";
    }

    GetBySearchString_BatDau_KetThucToListAsync() {
        var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
        if (ThanhVienID) {
            this.BaseParameter.ThanhVienID = Number(ThanhVienID);
        }
        this.BaseParameter.Active = true;
        let url = this.APIURL + this.Controller + '/GetBySearchString_BatDau_KetThucToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByThanhVienIDToListAsync() {
        var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
        if (ThanhVienID) {
            this.BaseParameter.ThanhVienID = Number(ThanhVienID);
        }
        this.BaseParameter.Active = true;
        let url = this.APIURL + this.Controller + '/GetByThanhVienIDToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

