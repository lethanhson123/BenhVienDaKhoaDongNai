import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TT_SYS_UPLOAD_LIENTHONGNHATHUOC } from './TT_SYS_UPLOAD_LIENTHONGNHATHUOC.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TT_SYS_UPLOAD_LIENTHONGNHATHUOCService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'REF_ID', 'REF_TABLE', 'LOAI_IDREFD', 'BENHVIEN_ID', 'THOIGIAN_UPLOAD', 'TRANGTHAI_UPLOAD', 'TIEPNHAN_ID', 'BENHNHAN_ID', 'TENBENHNHAN', 'PHIENLAMVIEC', 'LYDO', 'MA_RETURN', 'STT_NT'];

    List: TT_SYS_UPLOAD_LIENTHONGNHATHUOC[] | undefined;
    ListFilter: TT_SYS_UPLOAD_LIENTHONGNHATHUOC[] | undefined;
    FormData!: TT_SYS_UPLOAD_LIENTHONGNHATHUOC;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TT_SYS_UPLOAD_LIENTHONGNHATHUOC";
    }
}

