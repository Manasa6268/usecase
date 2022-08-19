import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-searchbooks',
  templateUrl: './searchbooks.component.html',
  styleUrls: ['./searchbooks.component.css']
})
export class SearchbooksComponent implements OnInit {
  myForm!: FormGroup;

  

  constructor(private fb: FormBuilder) {
    
  }
  ngOnInit(): void {
   
  }

  

 
}
 