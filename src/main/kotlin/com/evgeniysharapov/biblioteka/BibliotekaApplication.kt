package com.evgeniysharapov.biblioteka

import org.springframework.boot.autoconfigure.SpringBootApplication
import org.springframework.boot.runApplication

@SpringBootApplication
class BibliotekaApplication

fun main(args: Array<String>) {
	runApplication<BibliotekaApplication>(*args)
}
