# variadic-functions
https://youtu.be/R2TfNZchApM

These are the code samples for the YouTube video titled "What are Variadic Functions".

Transcript:

Variadic Functions

I think we all know what a normal method signature looks like, regardless of what your favorite language might be.  If you don’t, a method signature refers to the pattern of a functions definition.  It consists of the name, sometimes an access modifier if you’re language supports them, a return type for strongly typed languages, and the number and types of the arguments you can pass in.

For example in C#, a method signature looks like this.  We can see the name, preceded by an access modifier, in this case public, the ubiquitous	set of parenthesis that tells us this is a function or method.  The parenthesis contains an optional list of arguments which are variables you can pass into the function to allow it to do its work.  In the case of C#, a strongly typed language, we need the types for the arguments.

If your working in Java, the method signature pattern is almost indistinguishable from C#.

Here it is in python 3.  I’m not using a class here, so there is no access modifier is needed.  You don’t normally define the return type of the function in Python, but the rest of this method signature is identifiable.  We have a list of arguments enclosed in parenthesis and I’ve included the optional hints for python to work effectively with types.

JavaScript is a weakly typed language, and it doesn’t support access modifiers like most object oriented languages.  That said, you can still recognize the parts of the method signature, starting with a name and a set of arguments.

No matter what language you use, there are rules.

1). Your method signature must be unique within it’s defined scope.
2). You can’t use spaces in your method signature’s name.  It wouldn’t surprise me if someone challenged this idea with JavaScript, but that doesn’t mean its useful or a good idea.
3). Don’t name your functions the same name you use a variable in the same scope.
4).  The parenthesis are required even if there are no arguments.  The exception, again, is JavaScript where a fat-arrow function with one argument doesn’t need parenthesis.

So now we have an idea of what a method signature and one idea seems clear.  Method signatures may include a fixed number of arguments whether its none, one, five, or twenty-five, at which point you’d probably want to refactor.  The point is, the number of arguments is fixed by the method signature.

But what if it wasn’t?  What if you could pass in an indeterminate number of arguments and have your function operate on all of them?

Well in some languages, you can.  Say hello to variadic functions!  A variadic function is a function that takes a variable number of arguments.  While method signatures are easily recognizable when you switch languages, the big four have very different formats and requirements for a variadic function.  Let’s look at C#, Python 3, Java, and JavaScript.

Here’s some C# code and here is a variadic function definition.  It uses the params keyword inside the parenthesis and it requires you to set a type.  Like collections in C#, you have to use the same type of arguments.  So you can pass in a list of ints, floats, strings, or objects, but the list members, the things in the list, must be the same type.

In Python 3, we see variadic functions defined as the first argument in a method signature.  The *args is the pythonic way of defining variadic functions.  If you want to make a variadic function in python, the variadic argument definition should be the first one in the method signature.

In Java, we use an ellipsis, which are 3 dots at the end of the variable name.  You’ll see this again in a minute with JavaScript, and you’ll hear this referred to as the spread operator.  Like C# the type is required, but you could just use Object for the type and pass anything in if you really wanted to.

That leaves JavaScript.  For variadic functions in javascript you need to use ES6 or later.  Like java, we use the ellipsis.  A note of caution, in JavaScript the ellipsis can be different things depending on where it is.  I alluded earlier to the ellipsis being called the spread operator.  Spread is part of object destructuring which deals with assignment, and isn’t directly related to variadic functions. That’s what people call it because destructuring is likely more common than variadic functions.

In ES6, the variadic capability is called rest.  Not to be confused with the acronym for representational state transfer, a rest parameter allows you to pass in an indeterminate number of arguments with one caveat:  it must be the last variable defined in the method signature.

Variadic functions can be a very useful addition to any data science or computational workflow, and now you’re ready to use them in your language of choice.  What will you use them for?  I can’t wait to find out, leave your use cases in the comments and if you found value in this video, help me out with like and subscribe.

For more videos on software engineering and DevOps from a developer’s perspective, visit my site at maddevskilz.com or find us on twitter @DevSkilz

Notes:

C# example:
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params

Java Example:
https://stackoverflow.com/questions/2635229/java-variadic-function-parameters

Python Example:
https://stackoverflow.com/questions/33048359/in-python-can-you-pass-variadic-arguments-after-named-parameters

JavaScript rest parameters
https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/rest_parameters
