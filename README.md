# ioet coding exercise

The company ACME offers their employees the flexibility to work the hours they want. They will pay for the hours worked based on the day of the week and time of day, according to the following table:

Monday - Friday

00:01 - 09:00 25 USD

09:01 - 18:00 15 USD

18:01 - 00:00 20 USD

Saturday and Sunday

00:01 - 09:00 30 USD

09:01 - 18:00 20 USD

18:01 - 00:00 25 USD

The goal of this exercise is to calculate the total that the company has to pay an employee, based on the hours they worked and the times during which they worked. The following abbreviations will be used for entering data:

MO: Monday

TU: Tuesday

WE: Wednesday

TH: Thursday

FR: Friday

SA: Saturday

SU: Sunday

Input: the name of an employee and the schedule they worked, indicating the time and hours. This should be a .txt file with at least five sets of data. You can include the data from our two examples below.

Output: indicate how much the employee has to be paid

For example:

Case 1:

INPUT

RENE=MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00-21:00

OUTPUT:

The amount to pay RENE is: 215 USD

Case 2:

INPUT

ASTRID=MO10:00-12:00,TH12:00-14:00,SU20:00-21:00

OUTPUT:

The amount to pay ASTRID is: 85 USD

## Overview
It was build using Visual Studio 2022.

This have a Model folder with some classes (Employee, Schedule, Rules), a Business folder where the logic is done, and Program (main) where is the call to the Business.

## Usage
Download the file employeesSchedules.txt, this file should be put on "C:\Temp" of the computer, if you want to use the default folder, or anywhere on your computer, if you want to introduce the path and File manually.
## How to run 

**Clone or download this repository**

From your shell or command line:

```Shell
git clone https://github.com/eduar2/AcmeSchedule.git
```

or download and extract the repository .zip file.

**Step 2: Build solution and run**

You can open Visual Studio (2022 version preferred): 

- Select Build Solution from Build menu.
- Press F5 to run it. 

Or you can use the command line: 

Inside AcmeSchedule directory, from your command line:

```Shell
dotnet build
```

```Shell
dotnet run -p ./AcmeSchedule
```



