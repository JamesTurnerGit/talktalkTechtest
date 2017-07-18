# Feedback on the Vending Machine Tech Test

## Good things
Separation of logic and view. Excellent, above what I'd expect of a junior developer.

## Suggestions for improvement
DRY - There's a subtle violation of DRY here - made more obvious by the fact the water bottle is mis-priced on the menu. The menu information can be derived from the object, and this makes it clear that the display menu is actually coupled to the vending machine it is displaying a menu for. The implementation I'm submitting for you will display poorly for prices over £1; if I needed this to work better, I'd look for other solutions on the internet.

Summary blocks can be used to describe classes and methods. These will appear in Intellisense, which makes it easier for other developers to use APIs you create. Comments at the top of code files are not common in C#/.Net for this reason.

A using directive will make the tests more familiar for experienced .Net developers, rather than referring to the main namespace every time it is used

Test project should be named according to what it tests. In larger solutions this will be helpful to keep track of which tests are where.

Project Namespace & Assembly Name can be changed in the properties of a project (In Solution Explorer: Right-click -> Properties -> Application)

One of the Vending Machine tests was not complete. I picked this up because I use ReSharper, which tells me when code is not used.

## Style points / Some options
ToString is present on object, and does not need to be in the ICoin interface. You might be interested to look up how you can specify that the base object.ToString() method should be used. https://www.dotnetperls.com/tostring has some more information on ToString, I recommend you read up to the beginning of the discussion of numbers - be warned that CultureInfo and displaying numbers is a big subject, you may wish to steer clear of it for now.

It is relatively common not to have interfaces for objects where the intent is for them to contain information, rather than behaviour. It is my opinion that Coin and Item have this intent.