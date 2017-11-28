import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'customer-list',
    templateUrl: './customer-list.component.html'
})
export class CustomerListComponent {
    public customers: Customer[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Customer/GetAll').subscribe(result => {
            this.customers = result.json() as Customer[];
        }, error => console.error(error));
    }

    haha() {
        alert('soso');
    }
}

interface Customer {
    id: number;
    name: string;
    code: number;
    createDate: Date;
}