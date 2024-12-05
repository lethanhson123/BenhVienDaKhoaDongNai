import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TiepNhanFullComponent } from './tiep-nhan-full.component';

describe('TiepNhanFullComponent', () => {
  let component: TiepNhanFullComponent;
  let fixture: ComponentFixture<TiepNhanFullComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TiepNhanFullComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TiepNhanFullComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
