# Package Express

## Overview

Package Express is a C# console-based application created to calculate an estimated shipping quote for a package.

The application asks the user to enter the package's weight, width, height, and length. It then checks whether the package meets the shipping requirements. If the package is within the allowed limits, the program calculates and displays the estimated shipping cost.

## Assignment Requirements

The application performs the following steps:

1. Displays the welcome message:

   > Welcome to Package Express. Please follow the instructions below.

2. Prompts the user to enter the package weight.

3. Checks whether the package weight is greater than 50.

   * If the weight is greater than 50, the program displays:

   > Package too heavy to be shipped via Package Express. Have a good day.

4. Prompts the user to enter:

   * Package width
   * Package height
   * Package length

5. Adds the width, height, and length together.

6. Checks whether the total dimensions are greater than 50.

   * If the total is greater than 50, the program displays:

   > Package too big to be shipped via Package Express.

7. Calculates the shipping quote using the following formula:

   **Height × Width × Length × Weight ÷ 100**

8. Displays the estimated shipping cost as a dollar amount with two decimal places.

9. Displays a thank-you message after a successful calculation.

## Technologies Used

* **C#**
* **.NET**
* **Visual Studio**
* **Console Application**
* **Git**
* **GitHub**

## Example

### Input

```text
Package weight: 40
Package width: 10
Package height: 12
Package length: 11
```

### Calculation

```text
10 × 12 × 11 × 40 ÷ 100 = 528
```

### Output

```text
Your estimated total for shipping this package is: $528.00
Thank you!
```

## Error Handling

### Package Too Heavy

If the package weight is greater than 50:

```text
Package too heavy to be shipped via Package Express. Have a good day.
```

The program ends immediately.

### Package Too Large

If the combined width, height, and length are greater than 50:

```text
Package too big to be shipped via Package Express.
```

The program ends immediately.

## Project Structure

```text
PackageExpress/
│
├── Program.cs
└── README.md
```

## How to Run the Program

1. Clone or download this repository.
2. Open the project in Visual Studio.
3. Build the project.
4. Run the application.
5. Follow the instructions displayed in the console.
6. Enter the package weight and dimensions when prompted.

## Learning Objectives

This project demonstrates the use of:

* Console input and output
* Variables
* Decimal data types
* User input conversion
* `if` statements
* Conditional logic
* Arithmetic calculations
* String interpolation
* Number formatting
* Program termination using `return`
* Comments and code documentation

## Author

**Selcuk Kaplan**

## Assignment

This project was completed as part of a C# programming course assignment focused on creating a console-based package shipping quote application.
