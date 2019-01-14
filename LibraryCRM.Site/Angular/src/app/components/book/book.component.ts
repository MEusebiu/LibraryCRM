import { Component, OnInit } from '@angular/core';
import { BookService } from '../../services/book.service';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss']
})
export class BookComponent implements OnInit {

  constructor(private dataService: BookService) { }

  books: any;

  ngOnInit() {
    this.dataService.getBooks().subscribe(val => this.books = val);
  }
}
