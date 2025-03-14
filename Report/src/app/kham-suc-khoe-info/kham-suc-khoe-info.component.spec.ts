import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KhamSucKhoeInfoComponent } from './kham-suc-khoe-info.component';

describe('KhamSucKhoeInfoComponent', () => {
  let component: KhamSucKhoeInfoComponent;
  let fixture: ComponentFixture<KhamSucKhoeInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KhamSucKhoeInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KhamSucKhoeInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
