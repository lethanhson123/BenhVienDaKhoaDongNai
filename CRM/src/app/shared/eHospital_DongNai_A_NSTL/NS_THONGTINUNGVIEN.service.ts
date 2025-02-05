import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_THONGTINUNGVIEN } from './NS_THONGTINUNGVIEN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_THONGTINUNGVIENService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaUngVien', 'Ho', 'Ten', 'Gioitinh', 'Ngaysinh', 'Noisinh', 'DiachiHokhau', 'Diachilienlac', 'Dienthoai', 'Didong', 'Email', 'MaQuoctich', 'CMND', 'MaTrinhDo', 'ChuyenMon', 'Chucdanhdutuyen', 'Ngaynopdon', 'Congviec', 'Mucluongyeucau', 'Nangkhieu', 'Honnhan', 'Suckhoe', 'Chieucao', 'Cannang', 'Nhommau', 'Hinhanh', 'MaPhongBan', 'MaNhom', 'Ketluansaucung', 'Ngaybatdauvaolam', 'Ghichu'];

    List: NS_THONGTINUNGVIEN[] | undefined;
    ListFilter: NS_THONGTINUNGVIEN[] | undefined;
    FormData!: NS_THONGTINUNGVIEN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_THONGTINUNGVIEN";
    }
}

