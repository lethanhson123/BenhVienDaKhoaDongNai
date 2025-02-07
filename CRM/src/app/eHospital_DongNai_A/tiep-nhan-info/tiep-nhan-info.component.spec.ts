import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TiepNhanInfoComponent } from './tiep-nhan-info.component';

describe('TiepNhanInfoComponent', () => {
  let component: TiepNhanInfoComponent;
  let fixture: ComponentFixture<TiepNhanInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TiepNhanInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TiepNhanInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
