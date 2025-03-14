import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_BacSi_DichVu } from './DM_BacSi_DichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_BacSi_DichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BacSi_DichVu_Id', 'NhanVien_Id', 'DichVu_Id'];

    List: DM_BacSi_DichVu[] | undefined;
    ListFilter: DM_BacSi_DichVu[] | undefined;
    FormData!: DM_BacSi_DichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_BacSi_DichVu";
    }
}

