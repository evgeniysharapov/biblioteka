package com.evgeniysharapov.biblioteka.data

/**
 * Represents a book title in the library.
 */
data class BookTitle (
        var isbn: String,
        var title: String,
        var authors: List<Author>,
        var publisher: String,
        var publishedDate: String,
        var description: String,
        var pageCount: Int,
        var categories: List<String>,
        var thumbnail: String,
        var edition: String,
        var language: String)