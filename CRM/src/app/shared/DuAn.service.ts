import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuAn } from 'src/app/shared/DuAn.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuAnService extends BaseService {

    DisplayColumns001: string[] = ['STT', 'ID', 'NgayBatDau', 'NgayKetThuc', 'NgayKy', 'Name', 'SoHoSo', 'SoQuyetDinh', 'BenDauTuName', 'BenThucHienName', 'ThoiHan', 'MucDauTu', 'GhiCo', 'GhiNo', 'ConLai', 'Save'];

    List: DuAn[] | undefined;
    ListFilter: DuAn[] | undefined;
    FormData!: DuAn;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuAn";
    }

    GetBySearchString_BatDau_KetThucToListAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/GetBySearchString_BatDau_KetThucToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }

    CreateHTMLByIDAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/CreateHTMLByIDAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

