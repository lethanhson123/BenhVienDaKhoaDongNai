import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ComputerName } from './ComputerName.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ComputerNameService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenPC_id', 'TenPC', 'PhongBan_id', 'TenPhongBan', 'Khu'];

    List: ComputerName[] | undefined;
    ListFilter: ComputerName[] | undefined;
    FormData!: ComputerName;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ComputerName";
    }
}

