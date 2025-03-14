import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { sysdiagrams } from './sysdiagrams.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class sysdiagramsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'name', 'principal_id', 'diagram_id', 'version', 'definition'];

    List: sysdiagrams[] | undefined;
    ListFilter: sysdiagrams[] | undefined;
    FormData!: sysdiagrams;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "sysdiagrams";
    }
}

