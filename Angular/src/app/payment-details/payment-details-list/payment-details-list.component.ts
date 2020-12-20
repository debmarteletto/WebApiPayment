import { Component, OnInit } from '@angular/core';
import { PaymentDetailService } from 'src/app/Shared/payment-detail.service';
import { PaymentDetail } from 'src/app/Shared/payment-detail.model';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-payment-details-list',
  templateUrl: './payment-details-list.component.html',
  styles: []
})
export class PaymentDetailListComponent implements OnInit {
  
  public service: PaymentDetailService
  public toastr: ToastrService;

  constructor() { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(pd: PaymentDetail) {
    this.service.formData = Object.assign({}, pd);
  }

  onDelete(paymentId: number | undefined) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.DeletePayment(paymentId)
        .subscribe(res => {
          debugger;
          this.service.refreshList();
          this.toastr.warning('Deleted successfully', 'Payment Detail Register');
        },
          err => {
            debugger;
            console.log(err);
          })
    }
  }

}