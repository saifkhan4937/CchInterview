import { Component, OnInit } from '@angular/core';
import { LossType } from '../interfaces/LossType';
import { LossTypeService } from '../services/loss-type.service';

@Component({
  selector: 'app-loss-types',
  templateUrl: './loss-types.component.html',
  styleUrls: ['./loss-types.component.scss']
})
export class LossTypesComponent implements OnInit {
  lossTypes: LossType[] = [];

  constructor(private _lossTypeService: LossTypeService) { }

  ngOnInit(): void {
    this._lossTypeService.GetLossTypes().subscribe(res => { this.lossTypes = res })
  }

}
