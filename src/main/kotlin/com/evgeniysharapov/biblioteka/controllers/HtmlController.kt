package com.evgeniysharapov.biblioteka.controllers

import org.springframework.stereotype.Controller
import org.springframework.ui.Model
import org.springframework.ui.set
import org.springframework.web.bind.annotation.GetMapping
import org.springframework.web.bind.annotation.RequestMapping

@Controller
@RequestMapping("/")
class HtmlController {
    @GetMapping
    fun index(model: Model): String {
        model["title"] = "Home"
        return "index"
    }
}