import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoiSoChiTietInfoComponent } from './goi-so-chi-tiet-info.component';

describe('GoiSoChiTietInfoComponent', () => {
  let component: GoiSoChiTietInfoComponent;
  let fixture: ComponentFixture<GoiSoChiTietInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoiSoChiTietInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoiSoChiTietInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
