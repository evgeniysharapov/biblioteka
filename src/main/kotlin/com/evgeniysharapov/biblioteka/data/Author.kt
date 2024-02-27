package com.evgeniysharapov.biblioteka.data

/**
 * Represents an author of a book.
 * Most books have one or more authors although some books may have no author.
 * When we compare two Authors we consider them equal if names broken apart by comma are equal.
 * For instance, "John Smith" and "Smith, John" are considered equal.
 *
 * @property name the name of the author.
 * @constructor Creates an author with the given name.
 * @see Book
 */
data class Author(val name: String) {

}

