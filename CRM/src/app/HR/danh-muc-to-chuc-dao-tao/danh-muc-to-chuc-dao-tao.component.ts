import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucToChucDaoTao } from 'src/app/shared/DanhMucToChucDaoTao.model';
import { DanhMucToChucDaoTaoService } from 'src/app/shared/DanhMucToChucDaoTao.service';

@Component({
  selector: 'app-danh-muc-to-chuc-dao-tao',
  templateUrl: './danh-muc-to-chuc-dao-tao.component.html',
  styleUrls: ['./danh-muc-to-chuc-dao-tao.component.css']
})
export class DanhMucToChucDaoTaoComponent implements OnInit {

  @ViewChild('DanhMucToChucDaoTaoSort') DanhMucToChucDaoTaoSort: MatSort;
  @ViewChild('DanhMucToChucDaoTaoPaginator') DanhMucToChucDaoTaoPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucToChucDaoTaoService: DanhMucToChucDaoTaoService,
  ) { }

  ngOnInit(): void {

  }
  ngAfterViewInit() {
    this.DanhMucToChucDaoTaoSearch();
  }
  DanhMucToChucDaoTaoSearch() {
    this.DanhMucToChucDaoTaoService.SearchAll(this.DanhMucToChucDaoTaoSort, this.DanhMucToChucDaoTaoPaginator);
  }
  DanhMucToChucDaoTaoSave(element: DanhMucToChucDaoTao) {
    this.DanhMucToChucDaoTaoService.FormData = element;
    this.NotificationService.warn(this.DanhMucToChucDaoTaoService.ComponentSaveAll(this.DanhMucToChucDaoTaoSort, this.DanhMucToChucDaoTaoPaginator));
  }
  DanhMucToChucDaoTaoDelete(element: DanhMucToChucDaoTao) {
    this.DanhMucToChucDaoTaoService.FormData = element;
    this.NotificationService.warn(this.DanhMucToChucDaoTaoService.ComponentDeleteAll(this.DanhMucToChucDaoTaoSort, this.DanhMucToChucDaoTaoPaginator));
  }
}