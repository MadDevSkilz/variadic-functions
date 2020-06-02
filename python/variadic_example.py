# variadic function example


def hello_world(name: str):
    print("Hello world!  But more specifically, hello " + name)


def variadic_example(*args: int) -> int:
    total = 0
    for arg in args:
        total += arg

    print("The total is " + str(total))
    return total


if __name__ == "__main__":
    # You can send a comma-separated list of arguments
    # There is no limit to the number of arguments passed other than practical considerations
    # for memory and processor speed

    variadic_example(1, 2, 3, 4)
    variadic_example(100, 213, 432, 123, 234, 123, 643, 785)

    # You can pass in zero or more arguments.  If you don't pass any arguments, our function's total will be 0
    variadic_example()
