import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { dtproperties } from './dtproperties.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class dtpropertiesService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'id', 'objectid', 'property', 'value', 'uvalue', 'lvalue', 'version'];

    List: dtproperties[] | undefined;
    ListFilter: dtproperties[] | undefined;
    FormData!: dtproperties;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "dtproperties";
    }
}

