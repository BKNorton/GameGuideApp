<p align="center">
  <img 
    height="500"
    src="https://github.com/BKNorton/GameGuideApp/assets/112774855/26bd3761-b50b-4e9a-9e9e-d70635c92d8c"/>
</p>

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
	<li>Demonstrating my understanding of c# and Object Oriented Programming</li>
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

  Later on when I learned how to use .Net MAUI I realized my menu system shared similarities with this framework. Of course mine is nowhere near as good but they contained similar concepts.
 </p>
 <ul>
	 <li>Adding pages in MAUI is similar to how you use the menus in mine.</li>
	 <li>Pages/Menus allow you to add predefined views (or attributes in mine) to the page that represents the view.</li>
	 <li>I also realized that I was using MVVM princibles before I had even learned them.</li>
	 <li>The AppShell in MAUI that holds all pages within the app and provides navigation is similar to how my class Navigation_Menu contains all menus and provides navigation</li>
 </ul>
 
 
