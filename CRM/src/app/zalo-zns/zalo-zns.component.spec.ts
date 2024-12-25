import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ZaloZNSComponent } from './zalo-zns.component';

describe('ZaloZNSComponent', () => {
  let component: ZaloZNSComponent;
  let fixture: ComponentFixture<ZaloZNSComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ZaloZNSComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ZaloZNSComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
