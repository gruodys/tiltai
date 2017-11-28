import { Http } from "@angular/http/src";
import { Inject } from "@angular/core/src/di";
import { Component, OnInit, Input } from "@angular/core/src/metadata";

@Component({
    selector: 'customer-edit',
    templateUrl: './customer-edit.component.html'
})

export class CustomerEdit implements OnInit {
    @Input() customer: Customer;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
    }

    ngOnInit() {
        alert('customer-edit.component.html');
    }

    haha() {

    }
}

interface Customer {
    id: number;
    name: string;
    code: number;
    createDate: Date;
}