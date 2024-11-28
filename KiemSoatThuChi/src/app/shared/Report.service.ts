import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Report } from 'src/app/shared/Report.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ReportService extends BaseService {

    DisplayColumns001: string[] = ['STT', 'ID', 'NgayBatDau', 'NgayKetThuc', 'NgayKy', 'Name', 'SoHoSo', 'SoQuyetDinh', 'BenDauTuName', 'BenThucHienName', 'ThoiHan', 'MucDauTu', 'GhiCo', 'GhiNo', 'ConLai', 'Save'];

    List: Report[] | undefined;
    ListFilter: Report[] | undefined;
    FormData!: Report;

    List0001: Report[] | undefined;
    List0002: Report[] | undefined;
    List0003: Report[] | undefined;
    List0005: Report[] | undefined;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Report";
    }    
    Report0001ToListAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/Report0001ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }    
    Report0002ToListAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/Report0002ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }    
    Report0003ToListAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/Report0003ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }    
    Report0004ToAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/Report0004ToAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }   
    Report0005ToListAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/Report0005ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }    
}

