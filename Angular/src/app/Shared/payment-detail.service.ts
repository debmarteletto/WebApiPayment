
import { PaymentDetail } from './payment-detail.model';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {
  formData: PaymentDetail = {
    paymentId: 0,
    cardNumber: "",
    cardOwnerName: "",
    expirationDate: "",
    CVV: ""

  };

  readonly rootURL = 'http://localhost:62380/api';
  list: PaymentDetail[] = [];

  constructor(private http: HttpClient) { }

  PostPayment() {
    return this.http.post(this.rootURL + '/PaymentDetail', this.formData);
  }

  PutPayment() {
    return this.http.put(this.rootURL + '/PaymentDetail/' + this.formData.paymentId, this.formData);
  }

  DeletePayment(id: number = 0) {
    return this.http.delete(this.rootURL + '/PaymentDetail/' + id);
  }

  refreshList() {
    this.http.get(this.rootURL + '/PaymentDetail')
      .toPromise()
      .then(res => this.list = res as PaymentDetail[]);
  }
}
