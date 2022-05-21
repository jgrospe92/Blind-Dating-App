# Blind-Dating-App
 Academic Project for Application Development Course

- [Blind-Dating-App](#blind-dating-app)
- [Description](#description)
- [App Features](#app-features)
  - [User Registration](#user-registration)
  - [User Login](#user-login)
  - [Gender Limitation](#gender-limitation)
  - [Friendly UI](#friendly-ui)
  - [Match notification](#match-notification)
  - [User Profile](#user-profile)
  - [Report](#report)
  - [Scalability](#scalability)
  - [Internalization && Localization](#internalization--localization)
- [How does the matching works?](#how-does-the-matching-works)
- [Design Flow](#design-flow)
- [Future Updates](#future-updates)
- [Found a bug?](#found-a-bug)
- [Want to contribute?](#want-to-contribute)
- [Developers](#developers)

# Description
This project demonstrates our proficiency in C# language, design pattern and  windows form. It also demonstrates our creativity in designing layouts. We implement json to store and retrieve the data. The app offers internalization up to 4 languages.
Our goal for this app is to guaranteed users the chance to find partners or potential long time relationships. Similar to other dating apps such as Tinder, Bumble and Hinge. We encourage people to start and initiate conversations online and then go on dates in real life.

# App Features
## User Registration
New user will have to fill in the form in order for them to show up in the database. Every new user will scale the database.
## User Login
After registration, the user can login using their username and password. We implement invalid credentials to verify the user credentials.
## Gender Limitation
We eliminate the gender limitation, we want this app to be free and accessible for everyone. No separation of gender, our algorithm does not check for gender but rather users interests. All users are able to accept or decline a match up.
## Friendly UI 
At the current development, we want to keep it simple and functional.
## Match notification
You will be informed when your profiles matches with other people. You can accept or decline the match up.
## User Profile
Each user will have to build their own profile and add their own photo and short info about themselves.
**IMPORTANT** Currently, adding your own photo is not yet available.
## Report
If you find someone that is suspicious or has a malicious intent. You can report that user. 
## Scalability
It automatically populate the database every time a new user register. There is no limit, the database will grow as long as people are registering.

## Internalization && Localization
Our app is available in 4 different languages. English, French, Spanish and Filipino.

# How does the matching works?
We simply use a match making algorithm. It takes the user likes or interest and look through the database and check for each user traits or characters. If that user has something in common it will add that into a list and return that list. It will then display it on the GUI as matched users.

# Design Flow
<img src="Images\Design-Flow.png" alt="Design flow image">

# Future Updates
- Better error handling
- User photo profile submission
- Use of Web api to store the json data
- Redesign the GUI

# Found a bug?
Please help us to improve this app, you can do so by reporting any bug you find.

# Want to contribute?
Feel free to make a pull request. Right now we are only 2 developers. You are more than welcome to join us.

# Developers
Jeffrey Grospe - Lead programmer
Md Saqliyan Islam - programmer