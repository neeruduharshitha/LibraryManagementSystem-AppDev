using System;
using System.Collections.Generic;

public class Library{
    public List<Book> Books = new List<Book>();
    public List<Person> Patrons = new List<Person>();

    public void AddBook(Book book){
        Books.Add(book);
    }

    public void AddPatron(Person person){
        Patrons.Add(person);
    }

    public void DisplayBooks(){
        Console.WriteLine("Books in Library:");
        foreach(var book in Books){
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
        }
    }

    public void DisplayPatrons(){
        Console.WriteLine("\nPatrons in Library:");
        foreach(var patron in Patrons){
            Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
        }
    }
}