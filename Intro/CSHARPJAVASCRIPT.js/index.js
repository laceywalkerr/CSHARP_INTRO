// this is delcaring a variable
let name;

// assigning a value "adam" to the variable "name"
// variable type  =  string 
name = "Adam";

let myName = "Terra";

// variable type  = int
const cohort = 43;

//reassigning
cohort = 44;
cohort = "taco";

// variable type  = object
const person = { name: "Adam", cohort: 43 };

// variable type  = date object
const birthday = new Date("03/14/1987");

//declaring and initiallizing languages
// variable type  =  array of strings
const languages = ["JS", "C#"];

// ********functions********
// name of function = sayHello
// it takes one parameter (named "name", which is a string)
// it returns another string 
const sayHello = (name) => {
    return `Hello, ${name}`;
};

// pretend the commented out data below is in a proper C# file
// int cohort = 43;
// object person = { name: "Adam", cohort: 43 };
// Date birthday = new Date("03/14/1987");
// string const languages = ["JS", "C#"];
