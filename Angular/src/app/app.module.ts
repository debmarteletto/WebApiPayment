import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms"

import { AppComponent } from './app.component';
import { PaymentDetailsComponent } from './payment-details/payment-details.component'

import { PaymentDetailComponent } from './payment-details/payment-detail/payment-detail.component'
import { PaymentDetailService } from './Shared/payment-detail.service';
import { PaymentDetailListComponent } from './payment-details/payment-details-list/payment-details-list.component';

@NgModule({
  declarations: [
    AppComponent,
    PaymentDetailsComponent,
    PaymentDetailComponent,
    PaymentDetailListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [PaymentDetailService],
  bootstrap: [AppComponent]
})
export class AppModule { }
