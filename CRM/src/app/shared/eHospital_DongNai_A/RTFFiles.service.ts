import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { RTFFiles } from './RTFFiles.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class RTFFilesService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'FileID', 'RTFFileText', 'HTMLFileText'];

    List: RTFFiles[] | undefined;
    ListFilter: RTFFiles[] | undefined;
    FormData!: RTFFiles;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "RTFFiles";
    }
}

