import { Component, OnInit } from '@angular/core';
import { BookService } from '../app/services/book.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  constructor(private dataService: BookService) { }

  books: any;

  ngOnInit() {
    this.dataService.getBooks().subscribe((param) => (this.books = param));
  };
}

interface Book {
  Author: string,
  Title: string,
  Year: Date;
}
