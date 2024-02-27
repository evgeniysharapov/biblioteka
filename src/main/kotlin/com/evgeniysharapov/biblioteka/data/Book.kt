package com.evgeniysharapov.biblioteka.data

/**
 * Represents a book in the library.
 */
data class Book (
        var id: Int,
        var bookTitle: BookTitle,
        var owner: User,
)