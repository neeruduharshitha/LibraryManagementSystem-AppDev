public class Book{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int AvailableCopies { get; set; }

    public Book(string title, string author, string isbn, int copies){
        Title = title;
        Author = author;
        ISBN = isbn;
        AvailableCopies = copies;
    }

    public bool BorrowBook(){
        if(AvailableCopies > 0){
            AvailableCopies--;
            return true;;
        }
        return false;
    }

    public void ReturnBook(){
        AvailableCopies++;
    }


}