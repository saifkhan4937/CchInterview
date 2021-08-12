import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LossTypesComponent } from './loss-types.component';

describe('LossTypesComponent', () => {
  let component: LossTypesComponent;
  let fixture: ComponentFixture<LossTypesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LossTypesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LossTypesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
