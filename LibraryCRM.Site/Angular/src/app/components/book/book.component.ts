import { Component, OnInit } from '@angular/core';
import { BookService } from '../../services/book.service';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss']
})
export class BookComponent implements OnInit {

  constructor(private bookService: BookService) { }

  books: any;

  ngOnInit() {
    console.log("Books Console Log");
    this.bookService.getBooks().subscribe(val => console.log(val));
    this.bookService.getBooks().subscribe(val => this.books = val);
  }
}
