import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GoiSo } from 'src/app/shared/GoiSo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GoiSoService extends BaseService {

    DisplayColumns001: string[] = ['STT', 'ID', 'Name', 'Active'];
    DisplayColumns002: string[] = ['DanhMucThanhVienID', 'Save'];

    DisplayColumns03: string[] = ['STT', 'ID', 'NgayGhiNhan', 'DanhMucDichVuName', 'DanhMucPhongKhamName', 'TongCong', 'SoHienTai', 'Save'];
    DisplayColumns04: string[] = ['STT', 'ID', 'NgayGhiNhan', 'DanhMucDichVuName', 'DanhMucQuayDichVuName', 'DanhMucPhongKhamName', 'TongCong', 'SoHienTai', 'Save'];
    DisplayColumns05: string[] = ['STT', 'NgayGhiNhan', 'DanhMucDichVuName', 'DanhMucQuayDichVuName', 'TongCong', 'SoHienTai', 'Save'];
    DisplayColumns06: string[] = ['STT', 'NgayGhiNhan', 'DanhMucUngDungID', 'DanhMucDichVuName', 'DanhMucQuayDichVuName', 'TongCong', 'SoHienTai', 'Save'];

    List: GoiSo[] | undefined;
    ListFilter: GoiSo[] | undefined;
    FormData!: GoiSo;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GoiSo";
        this.FormData = {
            SoHienTai: environment.InitializationNumber,
        };
    }
    GoiSoTiepTheoAsync() {
        let url = this.APIURL + this.Controller + '/GoiSoTiepTheoAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    SaveByDanhMucDichVuIDAsync() {
        let url = this.APIURL + this.Controller + '/SaveByDanhMucDichVuIDAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    CreateHTMLByModelAsync() {
        let url = this.APIURL + this.Controller + '/CreateHTMLByModelAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.FormData));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByNgayGhiNhanToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByNgayGhiNhanToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByYear_Month_DayToListAsync() {
        if (this.BaseParameter.NgayGhiNhan == null) {
            this.BaseParameter.NgayGhiNhan = new Date();
        }
        this.BaseParameter.Year = this.BaseParameter.NgayGhiNhan.getFullYear();
        this.BaseParameter.Month = this.BaseParameter.NgayGhiNhan.getMonth() + 1;
        this.BaseParameter.Day = this.BaseParameter.NgayGhiNhan.getDate();
        let url = this.APIURL + this.Controller + '/GetByYear_Month_DayToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    Sync_eHospital_DongNai_AAsync() {       
        let url = this.APIURL + this.Controller + '/Sync_eHospital_DongNai_AAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

