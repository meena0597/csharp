# Gilded Rose

Welcome to the Gilded Rose project! This project manages the inventory of a small inn, updating the quality and sell-in value of items based on predefined rules.

## Choices Made
1. I have refactored the given code using simple factory pattern. The factory pattern that allows the abstraction of object creation, allowing subclasses to decide which class to instantiate. It follows the Open-Closed Principle.
2. 'IItem' interface defines a contract for all item types. It declares a method 'UpdateQuality()' that must be implemented by item classes.
3. There are several item classes, each representing a specific item type:
     i.	AgedBrie: Updates the quality of "Aged Brie" items.
    ii.	BackstagePasses: Updates the quality of "Backstage passes" items.
   iii. Conjured: Updates the quality of "Conjured" items.
    iv.	StandardItem: Updates the quality of standard items.
     v.	Sulfuras: Represents the "Sulfuras" legendary item.
   Each item class implements the 'IItem' interface and provides its own logic for updating quality based on the item type.
4. The 'Helper' class provides static methods to validate the quality and sell-in properties of items. It contains the common conditions.
5. 'Item' class represents an item with properties such as name, sell-in, and quality.
6. 'ItemFactory' class provides a factory method 'CreateItem()' to create instances of item classes based on the item name. It maps each item’s name to its corresponding item class.
7. Main method initializes a list of items with initial properties. Using the 'ItemFactory', it creates instances of concrete item classes for each item in the list. It creates an instance of 'GildedRose' and updates the properties of items for 30 days, printing the results after each day.
8. This refactoring approach enhances maintainability and extensibility by allowing easy addition of new item types without modifying the existing code.
 
## Instructions to Build

To build the project, follow these steps:

1. Clone the repository (https://github.com/meena0597/csharp) to your local machine.
2. Open the solution file (`csharp.sln`) in Visual Studio.
3. Build the solution by selecting `Build > Build Solution` from the menu, or by pressing `Ctrl+Shift+B`.

## Instructions to Run

To run the project, follow these steps:
1. Right-click on Solution file (`csharp.sln`), and select Set as 'Startup Item'
2. Then, press F5 or select Debug > Start Debugging from the menu to run the code.

## Instructions to Run Test File

To run the Test File, follow these steps:
1. Right-click on  file (`GildedRoseTest.cs`) / (`ApprovalTest.cs`), and select 'RunTest'


