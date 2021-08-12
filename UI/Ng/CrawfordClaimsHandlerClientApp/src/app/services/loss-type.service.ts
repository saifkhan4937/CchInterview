import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { from, Observable } from 'rxjs';
import { LossType } from '../interfaces/LossType';

@Injectable({
  providedIn: 'root'
})
export class LossTypeService {

  constructor(private http: HttpClient) {
  }

  GetLossTypes() {
    return this.http.get<LossType[]>('losstype');
  }
}
