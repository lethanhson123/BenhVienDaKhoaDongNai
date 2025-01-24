import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DONGIA_DEFINITIONS_LAMTRON } from './DM_DONGIA_DEFINITIONS_LAMTRON.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DONGIA_DEFINITIONS_LAMTRONService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DONGIA_DEFINITIONS_Tron', 'DonGia', 'LamTron'];

    List: DM_DONGIA_DEFINITIONS_LAMTRON[] | undefined;
    ListFilter: DM_DONGIA_DEFINITIONS_LAMTRON[] | undefined;
    FormData!: DM_DONGIA_DEFINITIONS_LAMTRON;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DONGIA_DEFINITIONS_LAMTRON";
    }
}

