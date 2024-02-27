package com.evgeniysharapov.biblioteka.data

data class User (
        var id: Int,
        var name: String,
        var email: String,
        var password: String,
        var role: String,
        var active: Boolean
)
