# Feedback on the Vending Machine Tech Test

## Good things

Separation of logic and view. Excellent, above what I'd expect of a junior developer.

Tests are well laid-out and there's some evidence of TDD.

APIs/communication between components - the VendingMachine class has a clear API to add stock and make purchases, it is clear thought has gone into that.

## Suggestions for improvement

DRY - There's a subtle violation of DRY here - made more obvious by the fact the water bottle is mis-priced on the menu. The menu information can be derived from the object, and this makes it clear that the display menu is actually coupled to the vending machine it is displaying a menu for. The implementation I'm submitting for you will display poorly for prices over £1; if I needed this to work better, I'd look for other solutions on the internet.

Extending Logic and view Separation - By pulling the interactions with the console into a ConsoleWrapper class, you could pull a view class out of program which you can test. This means you can significantly reduce your untested code, and achieve better separation of responsibilities, between (for example) Main Entry point; console view; setup; and vending machine logic.

Test project should be named according to what it tests. In larger solutions this will be helpful to keep track of which tests are where.

Project Namespace & Assembly Name can be changed in the properties of a project (In Solution Explorer: Right-click -> Properties -> Application).

One of the Vending Machine tests was not complete. I picked this up because I use ReSharper, which tells me when code is not used.

One of the vending machine tests was looking at behaviour which is the responsibility of the CoinCalculator; This has been mocked and tested with better separation of responsiblity in the tests, and the ICoinCalculator has been injected using "Poor Man's Dependency injection".

## Style points / Some options

Summary blocks can be used to describe classes and methods. These will appear in Intellisense, which makes it easier for other developers to use APIs you create. Comments at the top of code files are not common in C#/.Net for this reason.

A using directive will make the tests more familiar for experienced .Net developers, rather than referring to the main VendingApp namespace every time it is used.

ToString is present on object, and does not need to be in the ICoin interface. You might be interested to look up how you can specify that the base object.ToString() method should be used. <https://www.dotnetperls.com/tostring> has some more information on ToString, I recommend you read up to the beginning of the discussion of numbers - be warned that CultureInfo and displaying numbers is a big subject, you may wish to steer clear of it for now.

It is relatively common not to have interfaces for objects where the intent is for them to contain information, rather than behaviour. It is my opinion that Coin and Item have this intent.

It's uncommon to include compiled code in a git repository. Using a .gitignore such as <https://github.com/github/gitignore/blob/master/VisualStudio.gitignore> will prevent this by default. I can see why you chose to include compiled code, but I think you should steer clear of this, instead relying on having a standard, well-formatted project to guide your reader. Including instructions as an aide-memoire is sensible, but these should be at the bottom of a readme file where they are standard (e.g. "`npm start` to run the website").

Be Happier! You only talked about one thing you're happy with, you need only look above to see that your solution has more merit than you exposed immediately for your user. Advertisers tell you how you feel about their products for a reason ;)

I suspect that the class diagram was requested to facilitate gentle conversation about your solution at the start of an in-person interview. As such, it is fine, although you might expect an interviewer to notice that it makes no mention of interfaces.

Writing Style - be aware that you are going to put this in front of some highly detail-oriented people who have to make a decision about you. Formal language is appropriate, as in a CV or Cover Letter. This extends to the code as well.

## Suggestions for further work on this project

- Write tests for the Console View

- Consider where the vendingMachine should be set up, move it to the location you feel is most appropriate

- Consider the work required to add more items to the vending machine. Does this reveal any places where your code is coupled?

- Could this use the MVC or MVVM patterns? How should it change to follow either of these?
