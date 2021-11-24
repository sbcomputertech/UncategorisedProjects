package com.example.springboot;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloController {

	@GetMapping("/")
	public String index() {
		return "Greetings from Spring Boot!<br>" + "<button onclick=\"alert('Hello, there!');\">hi</button><br>" + "<a href=\"http://192.168.1.92:8080/info\">Click here for more info</a>";
	}
	@GetMapping("/info")
	public String info() {
		final String additionalInfo = "This is a web app made with the Spring Boot framework. It is run from the command line, and serves HTML content over HTTP on port 8080";
		final String infoStr = "<h1>I am Sam, and this is my first java web app!</h1><br><h3>Click the button below for more info</h3><br>" + "<button id=\"more\" onclick=\"document.getElementById('panel').innerHTML = '<p>" + additionalInfo + "</p>'\">Here</button><br><br>" + "<div id=\"panel\"></div><br>" + "<a href=\"http://192.168.1.92:8080/\">Click to go back</a>";
		return infoStr;
	}
	@GetMapping("/0/3/2/8/9/1")
	public String _032891() {
		return "well done! you got the secret code. enjoy this source code! jk lol";
	}
}
