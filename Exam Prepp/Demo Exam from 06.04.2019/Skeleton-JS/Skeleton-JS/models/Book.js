const mongoose = require('mongoose');

const bookSchema = new mongoose.Schema({
  // TODO:
});

const Book = mongoose.model('Book', bookSchema);
module.exports = Book;