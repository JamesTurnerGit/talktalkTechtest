# Talk Talk tech test

## Description
A simple model representing a vending machine and a quick interface written around it for simplified user interaction.
The interface itself is very limiting in how it was written as it's designed from what a vending machine user would see, the model itself is much more flexable.

![interface image](interface.PNG)

## Instructions
to try the app simply download and run the following file and follow the onscreen instructions
\talktalkTechtest\VendingApp\bin\Debug\vendingApp.exe

to run the tests:
1. download the whole repo 
2. open "VendingApp.sln" in Visual studio
3. press "ctrl + r" followed by "a"


## Things I'm happy with
Coins have a ToString implementation as well as contruction protection to make sure you're not creating an invalid coin. It'd be easy to convert the coin class to another regions currency.

## Improvements
Better test isolation - was having trouble figuring out how to inject coins into the vending machine without hardcoding the classname into the class. Fixing this would be my top priority as it's a lesson that would be usefull elsewhere.

I think this goes past the scope of the test, but this machine has infinite versions of whatever you put into it, and it generates cash out of thin air! would change this if I knew more about the specs of the machine in terms of max stock on items and coins.

## Class Diagram
![class diagram](class.PNG)


## Sidenote
I've seen a very similar problem before in a game! 
shenzhen IO where you design circuits and code chips using an assembly-like language.

Just for fun heres my solution in the game 

![ShenZhen IO screenshot](shenzhen.PNG)
