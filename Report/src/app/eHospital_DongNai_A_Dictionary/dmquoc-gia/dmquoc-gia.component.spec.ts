import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMQuocGiaComponent } from './dmquoc-gia.component';

describe('DMQuocGiaComponent', () => {
  let component: DMQuocGiaComponent;
  let fixture: ComponentFixture<DMQuocGiaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMQuocGiaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMQuocGiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
