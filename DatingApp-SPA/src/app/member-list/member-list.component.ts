import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

  locations: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getlocations();
  }

  getlocations() {
    this.http.get('http://localhost:5000/api/locations')
    .subscribe(response => {
      this.locations = response;
    }, error => {
      console.log(error);
    });
  }

}
