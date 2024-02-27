package com.evgeniysharapov.biblioteka

import org.springframework.boot.CommandLineRunner
import org.springframework.boot.SpringApplication
import org.springframework.boot.autoconfigure.EnableAutoConfiguration
import org.springframework.boot.autoconfigure.SpringBootApplication
import org.springframework.boot.runApplication
import org.springframework.context.ApplicationContext
import org.springframework.context.annotation.Bean
import org.springframework.data.jpa.repository.config.EnableJpaRepositories
import java.util.*

@SpringBootApplication
@EnableJpaRepositories
class BibliotekaApplication
//@Bean
fun commandLineRunner(ctx: ApplicationContext): CommandLineRunner {
	return CommandLineRunner {
		System.out.println("Let's inspect the beans provided by Spring Boot:");
		var beanNames = ctx.beanDefinitionNames;
		Arrays.sort(beanNames);
		beanNames.forEach { beanName -> System.out.println(beanName) };
	};
}

fun main(args: Array<String>) {
	runApplication<BibliotekaApplication>(*args)
}

