import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_BenhNhan_Notes } from './DM_BenhNhan_Notes.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_BenhNhan_NotesService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhan_Notes_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'TieuDe', 'NoiDung', 'NgayBatDau', 'NgayKetThuc', 'Status_Id', 'Reminder', 'Reminder_Position', 'NguoiLap_Id', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: DM_BenhNhan_Notes[] | undefined;
    ListFilter: DM_BenhNhan_Notes[] | undefined;
    FormData!: DM_BenhNhan_Notes;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_BenhNhan_Notes";
    }
}

