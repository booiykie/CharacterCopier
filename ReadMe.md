#Character Copier Project#
This project implements a Copier class that reads characters from a source (ISource) and writes them to a destination (IDestination) until a newline character ('\n') is encountered. The project also includes unit tests to ensure the correctness of the implementation.

##Prerequisites##
1. *.NET SDK*: Ensure you have the .NET SDK installed. You can download it from Microsoft's .NET website.

- Verify the installation:
```bash
dotnet --version
```

2. *NSubstitute*: The project uses the NSubstitute library for mocking dependencies during unit testing. This library is installed as part of the test project dependencies.

##Project Structure##
- *Copier/*: Contains the implementation of the Copier class and interfaces (ISource and IDestination).
- *Copier.Tests/*: Contains the unit tests for the Copier class.
- *CharacterCopierSolution.sln*: A solution file that links the two projects.

##Setup##
1. Clone the repository:

```bash
git clone <repository-url>
cd Copier
```

2. Build the solution to ensure all dependencies are installed and the code compiles:

```bash
dotnet build
```

##Running the Unit Tests##
1. Navigate to the test project directory:

```bash
cd CharacterCopier.Tests
```

2. Run the unit tests:

```bash
dotnet test
```

This command will:

- Build the test project.
- Execute all the test cases in the project.
- Display the results of the tests in the terminal.

##Expected Output##
If successful, you should see output similar to the following after running `dotnet test`:

```
Passed!  -  1 passed, 0 failed, 0 skipped, in 1.2s
```

##How It Works##
1. The Copier class is designed to:

Read characters from `ISource` one at a time using `ReadChar()`.
Write each character to IDestination using `WriteChar(char c)` until a newline (`'\n'`) is encountered.
Stop processing before writing the newline.

2. The unit tests use the `NSubstitute` library to mock `ISource` and `IDestination`, simulating different scenarios and verifying that the `Copier` class behaves as expected.

##Troubleshooting##
1. ###Test Failures:

- Ensure all dependencies are correctly installed by rebuilding the solution:
```bash
dotnet build
```
- Review the test output for details about what failed.

2. ###Environment Issues:

- Confirm the .NET SDK is installed and up to date.
- Run:
```bash
dotnet --list-sdks
```
to ensure you have a compatible version.
