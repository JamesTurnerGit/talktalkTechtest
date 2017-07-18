# Feedback on the Vending Machine Tech Test

## Good things
Separation of logic and view. Excellent, above what I'd expect of a junior developer.

## Suggestions for improvement
Summary blocks can be used to describe classes and methods. These will appear in Intellisense, which makes it easier for other developers to use APIs you create. Comments at the top of code files are not common in C#/.Net for this reason.

A using directive will make the tests more familiar for experienced .Net developers, rather than referring to the main namespace every time it is used

Test project should be named according to what it tests. In larger solutions this will be helpful to keep track of which tests are where.

Project Namespace & Assembly Name can be changed in the properties of a project (In Solution Explorer: Right-click -> Properties -> Application)

## Style points / Some options
ToString is present on object, and does not need to be in the ICoin interface. You might be interested to look up how you can specify that the base object.ToString() method should be used. https://www.dotnetperls.com/tostring has some more information on ToString, I recommend you read up to the beginning of the discussion of numbers - be warned that CultureInfo and displaying numbers is a big subject, you may wish to steer clear of it for now.