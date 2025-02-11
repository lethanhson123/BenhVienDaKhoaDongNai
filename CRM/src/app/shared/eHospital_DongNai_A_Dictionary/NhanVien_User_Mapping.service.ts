import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NhanVien_User_Mapping } from './NhanVien_User_Mapping.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NhanVien_User_MappingService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'NhanVien_User_Id', 'NhanVien_Id', 'User_Id'];
    DisplayColumns002: string[] = ['Save', 'STT', 'NhanVien_User_Id', 'User_Id'];
    DisplayColumns003: string[] = ['Save', 'STT', 'NhanVien_User_Id', 'NhanVien_Id'];
    DisplayColumns004: string[] = ['Save', 'NhanVien_Id'];
    List: NhanVien_User_Mapping[] | undefined;
    ListFilter: NhanVien_User_Mapping[] | undefined;
    FormData!: NhanVien_User_Mapping;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NhanVien_User_Mapping";
    }
    GetByNhanVien_IdToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByNhanVien_IdToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByNhanVien_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByNhanVien_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByUser_IdToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByUser_IdToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByUser_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByUser_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

