import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoiSoChiTietComponent } from './goi-so-chi-tiet.component';

describe('GoiSoChiTietComponent', () => {
  let component: GoiSoChiTietComponent;
  let fixture: ComponentFixture<GoiSoChiTietComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoiSoChiTietComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoiSoChiTietComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
