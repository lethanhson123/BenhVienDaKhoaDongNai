import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysFunctionsComponent } from './sys-functions.component';

describe('SysFunctionsComponent', () => {
  let component: SysFunctionsComponent;
  let fixture: ComponentFixture<SysFunctionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysFunctionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysFunctionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
