# Municipal Services Application – Part 2

---

## 1. Project Overview

The Municipal Services Application is a Windows Forms application developed in C#. The application is designed to provide residents with access to different municipal services.

Part 1 of the project focused on the Report Issues functionality. Part 2 extends the application by introducing the **Local Events and Announcements** feature and implementing different data structures and algorithms.

The application allows users to:

* Report municipal issues.
* View local events and announcements.
* Search for events by category and date.
* View all available events.
* Receive recommendations based on previous searches.
* Navigate between the different sections of the application.

---

## 2. Part 2 Features

### Local Events and Announcements

The Local Events and Announcements feature allows users to view upcoming events in the community.

Each event contains:

* Event name
* Category
* Date
* Location
* Description

The application currently contains example events such as:

* Community Clean-up Day
* Youth Career Workshop
* Local Food Festival
* Municipal Sports Day
* Small Business Information Session

---

## 3. Event Searching

Users can search for events by selecting a category and date.

The available categories include:

* Community
* Education
* Culture
* Sports
* Business

The application checks the stored event information and displays events that match the selected search criteria.

If no event matches the selected criteria, the application displays a message informing the user that no events were found.

The **Show All Events** button allows the user to return to the complete list of events.

---

## 4. Data Structures Used

Several data structures were implemented in Part 2.

### Stack

A `Stack<string>` called `recentSearches` stores the user's recent category searches.

The stack follows the Last-In-First-Out (LIFO) principle.

### Queue

A `Queue<Event>` called `upcomingEvents` stores upcoming events.

The queue follows the First-In-First-Out (FIFO) principle.

### Priority Queue

A `PriorityQueue<Event, int>` called `priorityEvents` stores events according to their assigned priority.

Different event categories are assigned different priority values.

### Hash Table

A `Hashtable` called `eventHashTable` stores events using the event name as the key.

This allows an event to be identified using its name.

### Dictionary

A `Dictionary<string, int>` called `searchHistory` records how many times the user searches for each event category.

This information is used by the recommendation feature.

### Sorted Dictionary

A `SortedDictionary<DateTime, List<Event>>` called `eventsByDate` stores events according to their dates.

This allows events to be displayed chronologically.

### HashSet

A `HashSet<string>` called `eventCategories` stores unique event categories.

This prevents duplicate categories from being added to the category selection list.

---

## 5. Smart Recommendation Feature

The application includes a smart recommendation feature based on the user's search behaviour.

Each time a user searches for an event category, the search is recorded in the `searchHistory` dictionary. The number of searches for each category is increased.

The application then identifies the category with the highest number of searches.

Events belonging to the user's most frequently searched category are displayed in the Recommendations section.

For example, if the user searches for Sports more frequently than other categories, the application recommends available Sports events.

The `recentSearches` stack is also used to keep track of recent category searches.

---

## 6. User Interface

The application contains a Main Menu with the following options:

1. **Report Issues**
2. **Local Events and Announcements**
3. **Service Request Status**
4. **Exit**

The Local Events and Announcements form contains:

* Category selection
* Date selection
* Search button
* Show All Events button
* Event results list
* Recommendations list
* Back button

The interface was designed to be simple and easy to understand.

---

## 7. Testing

The application was tested to make sure that the implemented features work correctly.

Testing included:

* Opening the Local Events and Announcements form.
* Displaying all events.
* Searching for events by category and date.
* Searching for dates where no events are available.
* Testing the Show All Events button.
* Testing the Back button.
* Testing the different data structures.
* Testing search history.
* Testing the smart recommendation feature.

The tests showed that the main features of Part 2 work as expected.

---

## 8. Technologies Used

* **C#**
* **Windows Forms**
* **.NET**
* **Visual Studio**
* **GitHub**
* **Generic Collections**
* **Data Structures and Algorithms**

---

## 9. How to Run the Application

1. Download or clone the project from GitHub.
2. Open the project in Visual Studio.
3. Open the solution/project file.
4. Make sure the correct .NET SDK is installed.
5. Build the solution.
6. If the build is successful, run the application using the **Start** button.
7. The Main Menu will be displayed.
8. Select **Local Events and Announcements** to test the Part 2 functionality.

---

## 10. Part 2 Outcome

Part 2 successfully extends the Municipal Services Application by adding the Local Events and Announcements feature.

The project demonstrates the practical use of different data structures, searching techniques and user-based recommendations in a C# Windows Forms application.

The application provides users with an accessible way to view local events while demonstrating the use of programming concepts covered in the module.
