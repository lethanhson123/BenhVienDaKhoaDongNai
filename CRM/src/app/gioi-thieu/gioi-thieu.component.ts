import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';


@Component({
  selector: 'app-gioi-thieu',
  templateUrl: './gioi-thieu.component.html',
  styleUrls: ['./gioi-thieu.component.css']
})
export class GioiThieuComponent implements OnInit {

  PageTitle = environment.PageTitle;
  PageDescription = environment.PageDescription;
  PageTitleShort = environment.PageTitleShort;
  constructor() { }

  ngOnInit(): void {
  }

}
