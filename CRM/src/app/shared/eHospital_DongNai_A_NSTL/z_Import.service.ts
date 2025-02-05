import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { z_Import } from './z_Import.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class z_ImportService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaNhanVien', 'SoTaikhoan'];

    List: z_Import[] | undefined;
    ListFilter: z_Import[] | undefined;
    FormData!: z_Import;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "z_Import";
    }
}

