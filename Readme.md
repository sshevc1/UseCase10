Application Description:

This application provides a string evaluation service, which uses .NET's Regular Expressions to validate that a given string satisfies specific conditions. The application includes a class StringEvaluator with the function ValidateString. This function checks if the input string is within a certain length, includes at least one uppercase letter, one lowercase letter, one digit, and one special character from a specified set, and does not contain any whitespace characters. It is an invaluable tool for data validation tasks, particularly useful in scenarios such as password validation, input sanitization, and data filtering.

Regex Implementation Description:

The regular expression is implemented in the ValidateString function of the StringEvaluator class. The regex pattern string is built dynamically to include the maximum acceptable length. The pattern uses positive lookahead assertions to confirm the presence of at least one lowercase letter ((?=.*[a-z])), one uppercase letter ((?=.*[A-Z])), one digit ((?=.*\d)), and one special character ((?=.*[!""#$%&'()*+,-.\/:;<=>?@\\\\[\\\]^_{|}~])). It uses a negative lookahead to reject any whitespace ((?!.*\s)). The expression .{1," + maxLength + "}$specifies that the string should be within the acceptable range of 1 tomaxLength` characters. This regex is optimized for execution speed and simplicity. However, due to the nature of lookahead assertions, the performance may degrade for very long input strings.

How to Run the Application Locally:

Ensure you have .NET SDK installed on your machine. You can download it from Microsoft's official .NET download page.

Clone the repository or download the project to your local machine.

Open a terminal window and navigate to the project directory.

Run the command dotnet build to build the project.

If you wish to use this as a library in another application, reference the built DLL in your project.

If you wish to test the StringEvaluator class directly, create a test application within the project, create an instance of StringEvaluator and call the ValidateString function with your test inputs.

Run the command dotnet run from your terminal to run the application or your test suite.