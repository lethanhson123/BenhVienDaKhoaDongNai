import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GoiSo } from 'src/app/shared/GoiSo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GoiSoService extends BaseService{
  
    DisplayColumns001: string[] = ['STT', 'ID', 'Name', 'Active'];   
    DisplayColumns002: string[] = ['DanhMucThanhVienID', 'Save'];   
        
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
    GoiSoTiepTheoByDanhMucDichVuIDAsync() {
        let url = this.APIURL + this.Controller + '/GoiSoTiepTheoByDanhMucDichVuIDAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync() {
        let url = this.APIURL + this.Controller + '/GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync';
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
    SaveByDanhMucDichVuID_CodeAsync() {
        let url = this.APIURL + this.Controller + '/SaveByDanhMucDichVuID_CodeAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync() {
        let url = this.APIURL + this.Controller + '/SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GoiSoTiepTheoByDanhMucPhongKhamIDAsync() {
        let url = this.APIURL + this.Controller + '/GoiSoTiepTheoByDanhMucPhongKhamIDAsync';
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
}

