# xUnit Environment Variable Isolation

The following repository contains a subset of choice solutions discussed in the following blog post article:

**[Isolating Environment Variables in xUnit Tests &#124; these are my thoughts](https://thoughts.jacobjmarks.dev/posts/20230301-isolating-environment-variables-in-xunit-tests/)**

> _When testing systems that utilise environment variables at runtime, careful consideration needs to be given to the design of both the system, if governed, and the test suite to avoid unexpected and seemingly irreproducible runtime and assertion failures when these variables are used in parallel._
>
> [Read more](https://thoughts.jacobjmarks.dev/posts/20230301-isolating-environment-variables-in-xunit-tests/)

## Contents

For simplicity and demonstration purposes, each example project below is self-contained; the projects each contain the system under test, the associated test suites, and no code is shared between them.

You will find any additional components which are required to support a given solution within a respective `/Support` folder.

### Solution B: Serial Execution

[Go to example](./Examples.SerialExecution)

### Solution C: Dependency Inversion

[Go to example](./Examples.DependencyInversion)
