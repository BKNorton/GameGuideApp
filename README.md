<h1>
	Description
</h1>
<p>
	This menu system I built was designed to display game guide information to use as a tool while playing video games. It was also set up so that others could contribute to it and add a guide for their own favorite games. 
</p>

<h2>
	A little background
</h2>
<p>
	I started this as a project for school and decided I wanted to make a game guide for the game Monster Hunter Rise that me and my friends were playing at the time. There was a lot of information that I wish I had readily available that either did not exist in the game or was not easy to view in game; especialy while in the middle of a 	hunt. 
</p>
<p>
	I did not know any app dev framework at the time or any other way to display data so I needed to just stick with what I knew which was a console application.
</p>
<p>
	I also did not know how to create and work with databases at the time of starting this project which is why I just store all data as json files.
</p>

<h2>
	Skills
</h2>
<p>
	This project showcases my programming knowledge and skills to future potential employers by:
</p>
<ui>
	<li>Demonstrating my understanding of C# and Object Oriented Programming</li>
	<li>Using Abstract classes to reduce code duplication</li>
	<li>Using interfaces and constructor dependency injection to abstract dependencies and loosely couple classes</li>
	<li>Using json to store data and read data and convert json strings into models and from models into json strings</li>
	<li>Using SOLID Princibles to make my code more modularized and easier to understand, edit, and add too</li>
</ui>

<h2>
	What's cool about this
</h2>
<p>
	This project may have become a little more complicated than it needed to be for the scope of my school project but once I started It was hard to stop.
</p>
<p>
	I wanted to find a way to implement everyting I was learning inside and outside of class into this one project. Originaly this menu system was very simple and was not modularized. Everything was in one project and a lot of the code was written in just a few classes.

 But as I learned more I decided I wanted to be able to make this modularized with expansion and growth in mind. 
 </p>
 <h3>
	So I needed to make some changes 
 </h3>
 <ol>
	 <li>I wanted to decouple the menu system from the games and the UI, and make it so that the UI could be swapped out for when I learned how to display data in other ways like a windows forms. (Again I did not know any UI framework)</li>
	 <li>I wanted others to be able to contribute and create their own game guides without needing to know how the menu system or the UI worked</li>
 </ol>

 <p>
	 After refactoring the whole solution to achieve these goals I had a much larger project than was originally needed.

  Originaly I had to format all the strings in the json file to display everything the way I wanted. This however was not optimal because I had to use string formating for every string and that took a very long time and a lot of trial and error to get.

  Instead, I created a formatting tool for console output that formats all the data for me as it displays. This saved me a lot of ugly tedious code.

  Later on when I learned how to use .Net MAUI, I realized my menu system shared similarities with this framework. Of course mine is nowhere near as good but they contained similar concepts.
 </p>
 <ul>
	 <li>Adding pages in MAUI is similar to how you use the menus in mine.</li>
	 <li>Pages/Menus allow you to add predefined views (or attributes in mine) to the page that represents the view.</li>
	 <li>I also realized that I was using MVVM princibles before I had even learned them.</li>
	 <li>The AppShell in MAUI that holds all pages within the app and provides navigation is similar to how my class Navigation_Menu contains all menus and provides navigation</li>
 </ul>

 <h2>
	 Notes
 </h2>
 <ui>
	 <li>The only game that currently has any menu views workig is Monster Hunter Rise</li>
	 <li>The Materials menu in Monster Hunter Rise has not been implemented</li>
 </ui>
 <h2>
	 To Do
 </h2>
 <ol>
	 <li>Finish Monster Hunter Rise game guide</li>
	 <li>Add more attributes that allow users to persist data</li>
	 <li>Finsh all code documentation</li>
	 <li>Potentially I would like to add a view that allows users to create game guides in the app (very ambitious).</li>
</ol>
 
<h1>
	 Instructions
</h1>
<p align="center">
  <img 
    height="300"
    src="https://github.com/BKNorton/GameGuideApp/assets/112774855/c2fb0679-a7a6-46cd-8760-9c3a586731b0"/>
  <img
    height="300"
    src="https://github.com/BKNorton/GameGuideApp/assets/112774855/3a75ea25-7574-4fb5-985f-dd74fe3339d1"/>
  <img
    height="300"
    src="https://github.com/BKNorton/GameGuideApp/assets/112774855/12f3629d-3071-4b92-8d63-9a650ea90fb9"/>
</p>



<h2>
	 How to start and navigate through the app
</h2>
<ol>
	<li>Clone repository to local file.</li>
	<li>Open the new file and start the debugger.</li>
	<li>Type the number associated with the game you would like to view and press Enter.</li>
	<li>Use this same method to navigate through all menu lists.</li>
	<li>If you would like to go back to the previous menu, type 0 into the entry field and press Enter.</li>
	<li>If you want to exit the program, return to the main menu and type 0 and press Enter.</li>
</ol>

<p align="center">
  <img 
    width="600"
    src="https://github.com/BKNorton/GameGuideApp/assets/112774855/16676f3c-1d11-458f-a969-4b4d438e4f18"/>
</p>
<h2>
	How to add more games
</h2>
<p>
	Use the Monster Hunter Rise game as your example. Can be found in GameGuideApp.GameLibrary.
</p>
<ol>
	<li>In the GameLibrary project create a folder with the name of your game.</li>
	<li>Create a class that inherits from Game that can be found in GameGuideApp.MenuSystem.Menus</li>
	<li>Create a folder in your game folder to hold all of your menus and name it "Menus"</li>
	<li>Create all your menus using the Menu Templates that can be found in GameGuideApp.MenuSystem.Menus.MenuTemplates</li>
	<ul>
		<li>All menu temeplates are abstract and must be implemented when inherited</li>
	</ul>
	<li>Add your game to the List<Game> games in the Program.cs file in GameGuideApp.GameGuideConsole</li>
</ol>


