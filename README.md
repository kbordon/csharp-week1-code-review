# _Address Book_

#### _An address book application for Epicodus Object-Oriented C# Code Review , 10.13.2017_

#### By _**Kimberly Bordon**_

## Description

_This is an that application uses object-oriented C# to store a user's contacts. The user can enter in a single contact, which will store this in a list. They can also choose to see a specific contact, search for contacts matching a search keyword, remove a contact, or clear their entire list of contacts. The data is stored and accessed through unique classes, and static lists._


## Specifications

| Behavior | Input Example | Output Example |
|----------|---------------|----------------|
| It will allow user to add a contact's information.| User inputs information| Information is stored and displayed |
| It will return a confirmation page upon user entering a contact, displaying information just added. | User adds contact| "You have successfully added a contact."|
| It will list all contacts currently stored on main page by contact's name. | Enters several contacts | All contacts listed on homepage |
| It will allow user to return to contact's details when clicking the contact's name on the main page list. | - Abraham <br> - Bernard <br> - Tina | Bernard _123-4567_ <br> 1 Goode St <br> Portland <br> OR <br> 88888 |
| It will allow user to clear their entire contact list on the homepage. | User clicks clear button| "Your contact list was cleared."|
| It will allow user to delete an individual contact. | User clicks Remove | This contact has been removed.|
| It will allow the user to search through their contacts with keyword, and it will return contacts containing the keyword. | Kim | Kimmy <br> Kimberly <br>kim |
## Setup/Installation Requirements

* Using terminal or your preferred shell, clone this repository.
  * Alternatively, you can use a browser to download the .zip file from the Github web interface.
  * You can also open this project with a text editor, such as Atom or Visual Studio.
* To run the application, using terminal or powershell, navigate to the project's root folder, and then enter the command "dotnet restore".
* After the packages have been restored, enter the command "dotnet run".
* If successful, open your web browser, and type the URL "http://http://localhost:5000/", or whatever location your terminal provides you.
* Navigate the application using the buttons.
* When finished, exit the browser, and don't forget to close your server with <kbd>Ctrl</kbd> + <kbd>C</kbd> on your terminal.


## Support and contact details

_If you have any questions, comments, or concerns, please contact Kimberly at [kbordon@gmail.com](mailto:kbordon@gmail.com)._

## Technologies Used

* HTML
* Bootstrap
* C#
* .NET

### License

*This software is licensed under the MIT license.*

Copyright © 2017 **_Kimberly Bordon_**
