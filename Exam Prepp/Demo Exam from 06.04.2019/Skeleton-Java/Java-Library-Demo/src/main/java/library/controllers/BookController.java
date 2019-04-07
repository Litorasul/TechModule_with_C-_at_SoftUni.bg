package library.controllers;

import library.bindingModels.BookBindingModel;
import library.entities.Book;
import library.repositories.BookRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class BookController {
    private final BookRepository bookRepository;

    @Autowired
    public BookController(BookRepository bookRepository) {
        this.bookRepository = bookRepository;
    }


    @GetMapping("/")
    public ModelAndView index(ModelAndView modelAndView) {

      //TODO
        return null;
    }

    @GetMapping("/create")
    public ModelAndView create(ModelAndView modelAndView) {
        //TODO

        return null;
    }

    @PostMapping("/create")
    public String create(Book book) {
      //TODO
        return null;
    }

    @GetMapping("/edit/{id}")
    public ModelAndView edit(@PathVariable(value = "id") Integer id, ModelAndView modelAndView) {
       //TODO
        return null;
    }

    @PostMapping("edit/{id}")
    public String edit(@PathVariable(value = "id") Integer id, BookBindingModel bookBindingModel){
      //TODO
        return null;
    }

    @GetMapping("/delete/{id}")
    public ModelAndView remove(@PathVariable(value = "id")Integer id, ModelAndView modelAndView){
        //TODO
        return null;
    }

    @PostMapping("/delete/{id}")
    public String remove(Book book){
      //TODO
        return null;
    }
}
