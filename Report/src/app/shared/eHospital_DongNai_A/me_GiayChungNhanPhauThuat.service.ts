import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_GiayChungNhanPhauThuat } from './me_GiayChungNhanPhauThuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_GiayChungNhanPhauThuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnPhauThuat_Id', 'TruongKhoa_id', 'Khoa_id', 'NgayTao', 'NguoiTao', 'NgayCapNhat', 'NguoiCapNhat'];

    List: me_GiayChungNhanPhauThuat[] | undefined;
    ListFilter: me_GiayChungNhanPhauThuat[] | undefined;
    FormData!: me_GiayChungNhanPhauThuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_GiayChungNhanPhauThuat";
    }
}

