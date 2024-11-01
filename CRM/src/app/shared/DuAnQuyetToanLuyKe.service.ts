import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuAnQuyetToanLuyKe } from 'src/app/shared/DuAnQuyetToanLuyKe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuAnQuyetToanLuyKeService extends BaseService{
    
    DisplayColumns001: string[] = ['STT', 'ID', 'DuAnQuyetDinhSoQuyetDinh', 'Nam', 'Thang', 'DauKy', 'GhiCo', 'GhiNo', 'CuoiKy', 'Active'];

    List: DuAnQuyetToanLuyKe[] | undefined;
    ListFilter: DuAnQuyetToanLuyKe[] | undefined;
    FormData!: DuAnQuyetToanLuyKe;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuAnQuyetToanLuyKe";
    }
    GetBySoQuyetDinhToListAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/GetBySoQuyetDinhToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

