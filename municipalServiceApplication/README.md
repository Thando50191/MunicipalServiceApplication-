# Municipal Services Application

## 1. Introduction 
The municipal Service Application is a Windows Forms application designed to improve communication between residents and their municipality.
The application allows residents to report municipal issues by providing the location, category and description of an issue and attaching a support file or image.

## 2. Requirements
To compile and run the application, the following is needed:
-Windows operating system
-Visual Studio
-.NET SDK
-Windows Forms support

## 3. How to compile the Application

1. Open the Municipal Service Application project in Visual Studio.
2. Open the solution explorer.
3. Allow Visual Studio to load all project files.
4. Select Build to Build Solution from the menu.
5. Confirm that the build complete successfully without errors.

## 4. How to run the Application

1. Open the project in Visual Studio.
2. Make sure the project builds successfully.
3. Press ctrl, F5 or you can select start in Visual Studio to run the application.
4. The Main Menu will appear. 

## 5. How to Use the Application

The Main Menu gives users access to the available municipal services.

The user can select:

-Report Issues
-Local Events and Announcements
-Service Request Status
-Exit

The Report Issues feature is available.
## Reporting an Issue

1. Select "Report Issues" from the Main Menu.
2. Enter the location where the issue occured.
3. Select an issue in the category options provided.
4. Enter a description of the issues.
5. Select "Attach File" to attach an image or supporting file.
6. Click "Submmit".
7. The application validates the information entered. 
8. If all required information is provided, the issue is submitted successfully.
9.  The progress bar provides visual feedback during the reporting process.
10. Select "Back" to return to the Main Menu. 

## 6. Validation
The application checks that the required information has been provided before an issue can be submitted.

The following information is required:

- Location
- Category
- Description
- File or image attachment

If information is missing, the application displays a warning message asking the user to complete the missing information.

## 7. Features Implemented

The application includes:

- User-friendly Main Menu
- Report Issues form
- Location input
- Issue category selection
- Issue description
- File attachment
- Progress bar
- Engagement message
- Input validation
- - Issue submission
- Navigation between forms

## 8. Data Structure

Reported issues are represented using an `Issue` class containing:

- Location
- Category
- Description
- Attached File

Submitted issues are stored using a `List<Issue>` collection during application use.