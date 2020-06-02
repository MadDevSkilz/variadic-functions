const helloWorld = name =>{
    console.log("Hello World!  But specifically, hello " + name);
}
const variadicExample = function(...args){
    let total = 0;
    for(let i = 0; i < args.length; i++){
        total += args[i];
    }
    console.log("The total is " + total);
    return total;
}

// You can send a comma-separated list of arguments into the function using the rest operator.
// Normal JavaScript doesn't do type checking, so we should probably either use a library for that (e.g. Flow.js)
// or check to make sure everything passed in really is a number.  There is no limit to how many arguments you
// pass other than practical considerations for memory and processing speed.

variadicExample(1, 2, 3, 4);
variadicExample(100, 213, 432, 123, 234, 123, 643, 785, 934);

// Arguments are optional.  You can call the function with zero arguments.
variadicExample();