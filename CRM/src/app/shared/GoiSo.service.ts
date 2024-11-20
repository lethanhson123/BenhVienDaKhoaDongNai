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
    }
    CreateHTMLByModelAsync() {
        let url = this.APIURL + this.Controller + '/CreateHTMLByModelAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.FormData));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    SaveByDanhMucDichVuIDAsync() {
        let url = this.APIURL + this.Controller + '/SaveByDanhMucDichVuIDAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

