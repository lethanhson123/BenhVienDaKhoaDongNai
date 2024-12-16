import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoiSoThamSoComponent } from './goi-so-tham-so.component';

describe('GoiSoThamSoComponent', () => {
  let component: GoiSoThamSoComponent;
  let fixture: ComponentFixture<GoiSoThamSoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoiSoThamSoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GoiSoThamSoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
