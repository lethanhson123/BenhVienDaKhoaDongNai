import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMPhongBanComponent } from './dm-phong-ban.component';

describe('DMPhongBanComponent', () => {
  let component: DMPhongBanComponent;
  let fixture: ComponentFixture<DMPhongBanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMPhongBanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMPhongBanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
