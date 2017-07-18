# Vending Machine

## Description

A simple model representing a vending machine. The vending machine only has two items in stock and only accepts 50p coins, although it can return any (UK) coins in change.

This solution includes a quick interface written around the vending machine model for simplified user interaction and demonstration. The interface itself is very limiting by design, as it's what a vending machine end-user would see. The vending machine model is much more flexable behind the scenes.

![interface image](interface.PNG)

## Things I'm happy with

Coins have a ToString implementation as well as validation in the constructor to make sure you're not creating an invalid coin. It'd be easy to convert the coin class to another region's currency.

## Improvements

Better test isolation - was having trouble figuring out how to inject coins into the vending machine without hardcoding the classname into the class. Fixing this would be my top priority as it's a lesson that would be usefull elsewhere.

I think this goes past the scope of the test, but this machine has infinite versions of whatever you put into it, and it generates cash out of thin air! I would change this if I knew more about the specs of the machine in terms of max stock on items and coins.

## Class diagram

![class diagram](class.PNG)

## Running the project

The app is a standard .Net solution written in C#, in most cases it can be run using the following instructions:

To try the app simply download and run the following file and follow the onscreen instructions
\talktalkTechtest\VendingApp\bin\Debug\vendingApp.exe

to run the tests:
1. download the whole repo 
2. open "VendingApp.sln" in Visual studio
3. press "ctrl + r" followed by "a"

## Sidenote

I've seen a very similar problem before in a game called Shenzhen IO where you design circuits and code chips using an assembly-like language.

Just for fun, here's my solution in the game:

![ShenZhen IO screenshot](shenzhen.PNG)
